
namespace STMCUCompare
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_MCU1 = new System.Windows.Forms.ComboBox();
            this.cb_MCU2 = new System.Windows.Forms.ComboBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.dgvCompare = new System.Windows.Forms.DataGridView();
            this.attribute_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCU1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCU2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompare)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_MCU1
            // 
            this.cb_MCU1.FormattingEnabled = true;
            this.cb_MCU1.Location = new System.Drawing.Point(6, 19);
            this.cb_MCU1.Name = "cb_MCU1";
            this.cb_MCU1.Size = new System.Drawing.Size(254, 21);
            this.cb_MCU1.TabIndex = 0;
            // 
            // cb_MCU2
            // 
            this.cb_MCU2.FormattingEnabled = true;
            this.cb_MCU2.Location = new System.Drawing.Point(266, 19);
            this.cb_MCU2.Name = "cb_MCU2";
            this.cb_MCU2.Size = new System.Drawing.Size(254, 21);
            this.cb_MCU2.TabIndex = 1;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(526, 19);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // dgvCompare
            // 
            this.dgvCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attribute_name,
            this.MCU1,
            this.MCU2});
            this.dgvCompare.Location = new System.Drawing.Point(12, 70);
            this.dgvCompare.Name = "dgvCompare";
            this.dgvCompare.Size = new System.Drawing.Size(889, 567);
            this.dgvCompare.TabIndex = 3;
            // 
            // attribute_name
            // 
            this.attribute_name.HeaderText = "Attribute Name";
            this.attribute_name.Name = "attribute_name";
            this.attribute_name.ReadOnly = true;
            this.attribute_name.Width = 300;
            // 
            // MCU1
            // 
            this.MCU1.HeaderText = "MCU 1";
            this.MCU1.Name = "MCU1";
            this.MCU1.Width = 200;
            // 
            // MCU2
            // 
            this.MCU2.HeaderText = "MCU 2";
            this.MCU2.Name = "MCU2";
            this.MCU2.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_MCU1);
            this.groupBox1.Controls.Add(this.cb_MCU2);
            this.groupBox1.Controls.Add(this.btnCompare);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 51);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select MCU to compare";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 649);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCompare);
            this.Name = "Form1";
            this.Text = "STMCUCompare";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompare)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_MCU1;
        private System.Windows.Forms.ComboBox cb_MCU2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.DataGridView dgvCompare;
        private System.Windows.Forms.DataGridViewTextBoxColumn attribute_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCU1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCU2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

