using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Data.Sqlite;
// https://github.com/dotnet/efcore

namespace STMCUCompare
{
    public partial class Form1 : Form
    {
        string baseName = "cube-finder-db.db";

        List<ComboboxItem> cpns = new List<ComboboxItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if(!System.IO.File.Exists(baseName))
            {
                MessageBox.Show("Extract cube-finder-db.db from STM32CubeIDE\\plugins\\com.st.stm32cube.common.mx_*\\db\\plugins\\mcufinder\\mcu\\cube-finder-db.zip or C:\\Program Files\\STMicroelectronics\\STM32Cube\\STM32CubeMX\\db\\plugins\\mcufinder\\mcu into current dirrectory", "cube-finder-db.db not found",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            using (var connection = new SqliteConnection("Data Source=" + baseName))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT id, cpn FROM cpn WHERE cpn like 'STM32F%' ORDER BY cpn";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cpns.Add(new ComboboxItem(reader.GetString(1), reader.GetInt16(0)));
                        //var url = reader.GetString(0);
                    }
                }
            }






            for (int i = 0; i < cpns.Count; i++)
            {
                cb_MCU1.Items.Add(cpns[i]);
                cb_MCU2.Items.Add(cpns[i]);

            }

            cb_MCU1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cb_MCU1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_MCU1.AutoCompleteSource = AutoCompleteSource.ListItems;

            cb_MCU2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cb_MCU2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_MCU2.AutoCompleteSource = AutoCompleteSource.ListItems;




            /*
                        var connection = new SQLiteConnection("Data Source=" + baseName);
                        SQLitePCL.raw.SetProvider(new SQLite3Provider_e_sqlite3());
                        connection.Open();


                        using (SqliteCommand fmd = connection.CreateCommand())
                        {
                            fmd.CommandText = @"SELECT DISTINCT * FROM cpn";
                            fmd.CommandType = CommandType.Text;
                            SqliteDataReader r = fmd.ExecuteReader();
                            while (r.Read())
                            {
                                r = r;
                                //ImportedFiles.Add(Convert.ToString(r["FileName"]));
                            }

                        }*/
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            ComboboxItem mcu1 = (ComboboxItem)cb_MCU1.SelectedItem;
            ComboboxItem mcu2 = (ComboboxItem)cb_MCU2.SelectedItem;

            if (mcu1 == null || mcu2 == null)
            {
                return;
            }

            dgvCompare.Rows.Clear();
            dgvCompare.Columns[1].HeaderText = (String)mcu1.Text;
            dgvCompare.Columns[2].HeaderText = (String)mcu2.Text;

            using (var connection = new SqliteConnection("Data Source=" + baseName))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT att.sourceName, att.type, att.unit, cpnha1.strValue as mcu1val, cpnha2.strValue as mcu2val  FROM attribute att  " +
                                        "left join cpn_has_attribute cpnha1 on att.id = cpnha1.attribute_id AND cpnha1.cpn_id = " + mcu1.Value + " " +
                                        "left join cpn_has_attribute cpnha2 on att.id = cpnha2.attribute_id AND cpnha2.cpn_id = " + mcu2.Value + " " +
                                        "where cpnha1.cpn_id is not null or cpnha2.cpn_id is not null " +
                                        "group by att.id " +
                                        "order by att.sourceName";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DataGridViewRow row = (DataGridViewRow)dgvCompare.Rows[0].Clone();
                        row.Cells[0].Value = reader.GetString(0);
                        if (!reader.IsDBNull(3))
                        {
                            row.Cells[1].Value = reader.GetString(3);
                        }

                        if (!reader.IsDBNull(4))
                        {
                            row.Cells[2].Value = reader.GetString(4);
                        }

                        String val1 = (String)row.Cells[1].Value;
                        String val2 = (String)row.Cells[2].Value;


                        if (String.Compare((String)row.Cells[1].Value, (String)row.Cells[2].Value) != 0)
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.White;
                        }

                        dgvCompare.Rows.Add(row);
                    }
                }
            }




        }
    }
}
