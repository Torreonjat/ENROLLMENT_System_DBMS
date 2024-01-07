
namespace ENROLLMENT_System
{
    partial class dataEnt_Program
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.searchtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Progupdate = new ENROLLMENT_System.TRControls.TRButtons();
            this.Progsave = new ENROLLMENT_System.TRControls.TRButtons();
            this.Prog_GridView = new System.Windows.Forms.DataGridView();
            this.prog_type = new System.Windows.Forms.ComboBox();
            this.Prog_descripbox = new System.Windows.Forms.TextBox();
            this.Prog_namebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.progidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prognameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progDescripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayprogResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prog_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayprogResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.searchtb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 109);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(568, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Search";
            // 
            // searchtb
            // 
            this.searchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtb.Location = new System.Drawing.Point(670, 69);
            this.searchtb.Multiline = true;
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(568, 34);
            this.searchtb.TabIndex = 2;
            this.searchtb.TextChanged += new System.EventHandler(this.searchtb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANAGE PROGRAM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Progupdate);
            this.panel2.Controls.Add(this.Progsave);
            this.panel2.Controls.Add(this.Prog_GridView);
            this.panel2.Controls.Add(this.prog_type);
            this.panel2.Controls.Add(this.Prog_descripbox);
            this.panel2.Controls.Add(this.Prog_namebox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1353, 628);
            this.panel2.TabIndex = 1;
            // 
            // Progupdate
            // 
            this.Progupdate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Progupdate.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Progupdate.BorderColor = System.Drawing.Color.Black;
            this.Progupdate.BorderRadius = 20;
            this.Progupdate.BorderSize = 1;
            this.Progupdate.FlatAppearance.BorderSize = 0;
            this.Progupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Progupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Progupdate.ForeColor = System.Drawing.Color.White;
            this.Progupdate.Location = new System.Drawing.Point(174, 454);
            this.Progupdate.Name = "Progupdate";
            this.Progupdate.Size = new System.Drawing.Size(310, 72);
            this.Progupdate.TabIndex = 13;
            this.Progupdate.Text = "Update";
            this.Progupdate.TextColor = System.Drawing.Color.White;
            this.Progupdate.UseVisualStyleBackColor = false;
            this.Progupdate.Click += new System.EventHandler(this.Progupdate_Click);
            // 
            // Progsave
            // 
            this.Progsave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Progsave.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Progsave.BorderColor = System.Drawing.Color.Black;
            this.Progsave.BorderRadius = 20;
            this.Progsave.BorderSize = 1;
            this.Progsave.FlatAppearance.BorderSize = 0;
            this.Progsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Progsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Progsave.ForeColor = System.Drawing.Color.White;
            this.Progsave.Location = new System.Drawing.Point(174, 376);
            this.Progsave.Name = "Progsave";
            this.Progsave.Size = new System.Drawing.Size(310, 72);
            this.Progsave.TabIndex = 13;
            this.Progsave.Text = "Save";
            this.Progsave.TextColor = System.Drawing.Color.White;
            this.Progsave.UseVisualStyleBackColor = false;
            this.Progsave.Click += new System.EventHandler(this.Progsave_Click);
            // 
            // Prog_GridView
            // 
            this.Prog_GridView.AllowUserToAddRows = false;
            this.Prog_GridView.AllowUserToDeleteRows = false;
            this.Prog_GridView.AutoGenerateColumns = false;
            this.Prog_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prog_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete,
            this.progidDataGridViewTextBoxColumn,
            this.prognameDataGridViewTextBoxColumn,
            this.progDescripDataGridViewTextBoxColumn,
            this.progtypeDataGridViewTextBoxColumn});
            this.Prog_GridView.DataSource = this.displayprogResultBindingSource;
            this.Prog_GridView.Location = new System.Drawing.Point(502, 53);
            this.Prog_GridView.Name = "Prog_GridView";
            this.Prog_GridView.ReadOnly = true;
            this.Prog_GridView.Size = new System.Drawing.Size(823, 524);
            this.Prog_GridView.TabIndex = 12;
            this.Prog_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Prog_GridView_CellContentClick);
            // 
            // prog_type
            // 
            this.prog_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prog_type.FormattingEnabled = true;
            this.prog_type.Items.AddRange(new object[] {
            "Day",
            "Night"});
            this.prog_type.Location = new System.Drawing.Point(174, 132);
            this.prog_type.Name = "prog_type";
            this.prog_type.Size = new System.Drawing.Size(310, 28);
            this.prog_type.TabIndex = 11;
            // 
            // Prog_descripbox
            // 
            this.Prog_descripbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prog_descripbox.Location = new System.Drawing.Point(174, 212);
            this.Prog_descripbox.Multiline = true;
            this.Prog_descripbox.Name = "Prog_descripbox";
            this.Prog_descripbox.Size = new System.Drawing.Size(310, 123);
            this.Prog_descripbox.TabIndex = 10;
            // 
            // Prog_namebox
            // 
            this.Prog_namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prog_namebox.Location = new System.Drawing.Point(174, 53);
            this.Prog_namebox.Multiline = true;
            this.Prog_namebox.Name = "Prog_namebox";
            this.Prog_namebox.Size = new System.Drawing.Size(310, 34);
            this.Prog_namebox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Program Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Program Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Program Name";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // progidDataGridViewTextBoxColumn
            // 
            this.progidDataGridViewTextBoxColumn.DataPropertyName = "Prog_id";
            this.progidDataGridViewTextBoxColumn.HeaderText = "Prog_id";
            this.progidDataGridViewTextBoxColumn.Name = "progidDataGridViewTextBoxColumn";
            this.progidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prognameDataGridViewTextBoxColumn
            // 
            this.prognameDataGridViewTextBoxColumn.DataPropertyName = "Prog_name";
            this.prognameDataGridViewTextBoxColumn.HeaderText = "Prog_name";
            this.prognameDataGridViewTextBoxColumn.Name = "prognameDataGridViewTextBoxColumn";
            this.prognameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // progDescripDataGridViewTextBoxColumn
            // 
            this.progDescripDataGridViewTextBoxColumn.DataPropertyName = "Prog_Descrip";
            this.progDescripDataGridViewTextBoxColumn.HeaderText = "Prog_Descrip";
            this.progDescripDataGridViewTextBoxColumn.Name = "progDescripDataGridViewTextBoxColumn";
            this.progDescripDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // progtypeDataGridViewTextBoxColumn
            // 
            this.progtypeDataGridViewTextBoxColumn.DataPropertyName = "Prog_type";
            this.progtypeDataGridViewTextBoxColumn.HeaderText = "Prog_type";
            this.progtypeDataGridViewTextBoxColumn.Name = "progtypeDataGridViewTextBoxColumn";
            this.progtypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // displayprogResultBindingSource
            // 
            this.displayprogResultBindingSource.DataSource = typeof(ENROLLMENT_System.display_progResult);
            // 
            // dataEnt_Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1353, 737);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dataEnt_Program";
            this.Text = "dataEnt_Program";
            this.Load += new System.EventHandler(this.dataEnt_Program_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prog_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayprogResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Prog_descripbox;
        private System.Windows.Forms.TextBox Prog_namebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Prog_GridView;
        private System.Windows.Forms.ComboBox prog_type;
        private TRControls.TRButtons Progupdate;
        private TRControls.TRButtons Progsave;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn progidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prognameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn progDescripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn progtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource displayprogResultBindingSource;
    }
}