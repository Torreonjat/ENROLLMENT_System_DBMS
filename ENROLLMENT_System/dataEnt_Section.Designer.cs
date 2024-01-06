
namespace ENROLLMENT_System
{
    partial class dataEnt_Section
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.searchsect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Sect_block = new System.Windows.Forms.ComboBox();
            this.section_GridView = new System.Windows.Forms.DataGridView();
            this.sec_yr = new System.Windows.Forms.ComboBox();
            this.Sect_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Sectupdate = new System.Windows.Forms.Button();
            this.Sectsave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.section_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.searchsect);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1337, 81);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(629, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Search";
            // 
            // searchsect
            // 
            this.searchsect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchsect.Location = new System.Drawing.Point(731, 31);
            this.searchsect.Multiline = true;
            this.searchsect.Name = "searchsect";
            this.searchsect.Size = new System.Drawing.Size(568, 34);
            this.searchsect.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "MANAGE SECTION";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Sect_block);
            this.panel2.Controls.Add(this.section_GridView);
            this.panel2.Controls.Add(this.sec_yr);
            this.panel2.Controls.Add(this.Sect_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Sectupdate);
            this.panel2.Controls.Add(this.Sectsave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1337, 617);
            this.panel2.TabIndex = 1;
            // 
            // Sect_block
            // 
            this.Sect_block.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sect_block.FormattingEnabled = true;
            this.Sect_block.Location = new System.Drawing.Point(172, 205);
            this.Sect_block.Name = "Sect_block";
            this.Sect_block.Size = new System.Drawing.Size(310, 28);
            this.Sect_block.TabIndex = 22;
            // 
            // section_GridView
            // 
            this.section_GridView.AllowUserToAddRows = false;
            this.section_GridView.AllowUserToDeleteRows = false;
            this.section_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.section_GridView.Location = new System.Drawing.Point(500, 46);
            this.section_GridView.Name = "section_GridView";
            this.section_GridView.ReadOnly = true;
            this.section_GridView.Size = new System.Drawing.Size(823, 524);
            this.section_GridView.TabIndex = 21;
            // 
            // sec_yr
            // 
            this.sec_yr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sec_yr.FormattingEnabled = true;
            this.sec_yr.Location = new System.Drawing.Point(172, 125);
            this.sec_yr.Name = "sec_yr";
            this.sec_yr.Size = new System.Drawing.Size(310, 28);
            this.sec_yr.TabIndex = 20;
            // 
            // Sect_name
            // 
            this.Sect_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sect_name.Location = new System.Drawing.Point(172, 46);
            this.Sect_name.Multiline = true;
            this.Sect_name.Name = "Sect_name";
            this.Sect_name.Size = new System.Drawing.Size(310, 34);
            this.Sect_name.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Block";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Section Name";
            // 
            // Sectupdate
            // 
            this.Sectupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sectupdate.Location = new System.Drawing.Point(344, 381);
            this.Sectupdate.Name = "Sectupdate";
            this.Sectupdate.Size = new System.Drawing.Size(138, 65);
            this.Sectupdate.TabIndex = 14;
            this.Sectupdate.Text = "Update";
            this.Sectupdate.UseVisualStyleBackColor = true;
            // 
            // Sectsave
            // 
            this.Sectsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sectsave.Location = new System.Drawing.Point(172, 381);
            this.Sectsave.Name = "Sectsave";
            this.Sectsave.Size = new System.Drawing.Size(138, 65);
            this.Sectsave.TabIndex = 13;
            this.Sectsave.Text = "Save";
            this.Sectsave.UseVisualStyleBackColor = true;
            // 
            // dataEnt_Section
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dataEnt_Section";
            this.Text = "dataEnt_Section";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.section_GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchsect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView section_GridView;
        private System.Windows.Forms.ComboBox sec_yr;
        private System.Windows.Forms.TextBox Sect_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Sectupdate;
        private System.Windows.Forms.Button Sectsave;
        private System.Windows.Forms.ComboBox Sect_block;
    }
}