
namespace ENROLLMENT_System
{
    partial class Enroll
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
            this.lbtime = new System.Windows.Forms.Label();
            this.lbdate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addEnrollees = new ENROLLMENT_System.TRControls.TRButtons();
            this.searchtb = new System.Windows.Forms.TextBox();
            this.enrollpanel = new System.Windows.Forms.Panel();
            this.updatebtn = new ENROLLMENT_System.TRControls.TRButtons();
            this.submitbtn = new ENROLLMENT_System.TRControls.TRButtons();
            this.panelin = new System.Windows.Forms.Panel();
            this.ClassCodeEnroll = new System.Windows.Forms.ComboBox();
            this.declinebtn = new System.Windows.Forms.RadioButton();
            this.sem_enroll = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stud_enroll = new System.Windows.Forms.TextBox();
            this.approvebtn = new System.Windows.Forms.RadioButton();
            this.yr_enroll = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.display_enrollees = new System.Windows.Forms.DataGridView();
            this.displayenrolleeResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.applyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studFnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applySemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyYrLvlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.enrollpanel.SuspendLayout();
            this.panelin.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.display_enrollees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayenrolleeResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbtime);
            this.panel1.Controls.Add(this.lbdate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 77);
            this.panel1.TabIndex = 0;
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtime.Location = new System.Drawing.Point(1025, 49);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(43, 20);
            this.lbtime.TabIndex = 1;
            this.lbtime.Text = "Time";
            // 
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate.Location = new System.Drawing.Point(754, 49);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(44, 20);
            this.lbdate.TabIndex = 0;
            this.lbdate.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENROLL STUDENT";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addEnrollees);
            this.panel2.Controls.Add(this.searchtb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1353, 69);
            this.panel2.TabIndex = 1;
            // 
            // addEnrollees
            // 
            this.addEnrollees.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addEnrollees.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.addEnrollees.BorderColor = System.Drawing.Color.Black;
            this.addEnrollees.BorderRadius = 20;
            this.addEnrollees.BorderSize = 1;
            this.addEnrollees.FlatAppearance.BorderSize = 0;
            this.addEnrollees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEnrollees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEnrollees.ForeColor = System.Drawing.Color.White;
            this.addEnrollees.Location = new System.Drawing.Point(1071, 9);
            this.addEnrollees.Name = "addEnrollees";
            this.addEnrollees.Size = new System.Drawing.Size(175, 50);
            this.addEnrollees.TabIndex = 19;
            this.addEnrollees.Text = "Create New";
            this.addEnrollees.TextColor = System.Drawing.Color.White;
            this.addEnrollees.UseVisualStyleBackColor = false;
            this.addEnrollees.Click += new System.EventHandler(this.addEnrollees_Click);
            // 
            // searchtb
            // 
            this.searchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtb.Location = new System.Drawing.Point(480, 19);
            this.searchtb.Multiline = true;
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(568, 34);
            this.searchtb.TabIndex = 0;
            this.searchtb.TextChanged += new System.EventHandler(this.searchtb_TextChanged);
            // 
            // enrollpanel
            // 
            this.enrollpanel.Controls.Add(this.updatebtn);
            this.enrollpanel.Controls.Add(this.submitbtn);
            this.enrollpanel.Controls.Add(this.panelin);
            this.enrollpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.enrollpanel.Location = new System.Drawing.Point(0, 146);
            this.enrollpanel.Name = "enrollpanel";
            this.enrollpanel.Size = new System.Drawing.Size(1353, 274);
            this.enrollpanel.TabIndex = 2;
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.updatebtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.updatebtn.BorderColor = System.Drawing.Color.Black;
            this.updatebtn.BorderRadius = 20;
            this.updatebtn.BorderSize = 1;
            this.updatebtn.FlatAppearance.BorderSize = 0;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.Location = new System.Drawing.Point(1071, 97);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(175, 50);
            this.updatebtn.TabIndex = 21;
            this.updatebtn.Text = "Update";
            this.updatebtn.TextColor = System.Drawing.Color.White;
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.submitbtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.submitbtn.BorderColor = System.Drawing.Color.Black;
            this.submitbtn.BorderRadius = 20;
            this.submitbtn.BorderSize = 1;
            this.submitbtn.FlatAppearance.BorderSize = 0;
            this.submitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.ForeColor = System.Drawing.Color.White;
            this.submitbtn.Location = new System.Drawing.Point(1071, 32);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(175, 50);
            this.submitbtn.TabIndex = 20;
            this.submitbtn.Text = "Submit";
            this.submitbtn.TextColor = System.Drawing.Color.White;
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // panelin
            // 
            this.panelin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelin.Controls.Add(this.ClassCodeEnroll);
            this.panelin.Controls.Add(this.declinebtn);
            this.panelin.Controls.Add(this.sem_enroll);
            this.panelin.Controls.Add(this.label4);
            this.panelin.Controls.Add(this.stud_enroll);
            this.panelin.Controls.Add(this.approvebtn);
            this.panelin.Controls.Add(this.yr_enroll);
            this.panelin.Controls.Add(this.label5);
            this.panelin.Controls.Add(this.label7);
            this.panelin.Controls.Add(this.label8);
            this.panelin.Controls.Add(this.label6);
            this.panelin.Location = new System.Drawing.Point(29, 21);
            this.panelin.Name = "panelin";
            this.panelin.Size = new System.Drawing.Size(1028, 207);
            this.panelin.TabIndex = 14;
            // 
            // ClassCodeEnroll
            // 
            this.ClassCodeEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassCodeEnroll.FormattingEnabled = true;
            this.ClassCodeEnroll.Location = new System.Drawing.Point(650, 76);
            this.ClassCodeEnroll.Name = "ClassCodeEnroll";
            this.ClassCodeEnroll.Size = new System.Drawing.Size(261, 28);
            this.ClassCodeEnroll.TabIndex = 9;
            // 
            // declinebtn
            // 
            this.declinebtn.AutoSize = true;
            this.declinebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.declinebtn.Location = new System.Drawing.Point(362, 154);
            this.declinebtn.Name = "declinebtn";
            this.declinebtn.Size = new System.Drawing.Size(80, 24);
            this.declinebtn.TabIndex = 12;
            this.declinebtn.TabStop = true;
            this.declinebtn.Text = "Decline";
            this.declinebtn.UseVisualStyleBackColor = true;
            // 
            // sem_enroll
            // 
            this.sem_enroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sem_enroll.FormattingEnabled = true;
            this.sem_enroll.Items.AddRange(new object[] {
            "1st Semester",
            "2nd Semester"});
            this.sem_enroll.Location = new System.Drawing.Point(144, 17);
            this.sem_enroll.Name = "sem_enroll";
            this.sem_enroll.Size = new System.Drawing.Size(226, 28);
            this.sem_enroll.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Semester";
            // 
            // stud_enroll
            // 
            this.stud_enroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_enroll.Location = new System.Drawing.Point(650, 17);
            this.stud_enroll.Multiline = true;
            this.stud_enroll.Name = "stud_enroll";
            this.stud_enroll.Size = new System.Drawing.Size(261, 28);
            this.stud_enroll.TabIndex = 6;
            // 
            // approvebtn
            // 
            this.approvebtn.AutoSize = true;
            this.approvebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvebtn.Location = new System.Drawing.Point(148, 156);
            this.approvebtn.Name = "approvebtn";
            this.approvebtn.Size = new System.Drawing.Size(86, 24);
            this.approvebtn.TabIndex = 11;
            this.approvebtn.TabStop = true;
            this.approvebtn.Text = "Approve";
            this.approvebtn.UseVisualStyleBackColor = true;
            // 
            // yr_enroll
            // 
            this.yr_enroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yr_enroll.FormattingEnabled = true;
            this.yr_enroll.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.yr_enroll.Location = new System.Drawing.Point(144, 76);
            this.yr_enroll.Name = "yr_enroll";
            this.yr_enroll.Size = new System.Drawing.Size(226, 28);
            this.yr_enroll.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(476, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Student ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(477, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Class Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Year Level";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.display_enrollees);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 420);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1353, 317);
            this.panel4.TabIndex = 3;
            // 
            // display_enrollees
            // 
            this.display_enrollees.AllowUserToAddRows = false;
            this.display_enrollees.AllowUserToDeleteRows = false;
            this.display_enrollees.AutoGenerateColumns = false;
            this.display_enrollees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.display_enrollees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.applyidDataGridViewTextBoxColumn,
            this.studidDataGridViewTextBoxColumn,
            this.studFnameDataGridViewTextBoxColumn,
            this.studLnameDataGridViewTextBoxColumn,
            this.applySemDataGridViewTextBoxColumn,
            this.applyYrLvlDataGridViewTextBoxColumn,
            this.classidDataGridViewTextBoxColumn,
            this.unameDataGridViewTextBoxColumn});
            this.display_enrollees.DataSource = this.displayenrolleeResultBindingSource;
            this.display_enrollees.Location = new System.Drawing.Point(31, 20);
            this.display_enrollees.Name = "display_enrollees";
            this.display_enrollees.ReadOnly = true;
            this.display_enrollees.Size = new System.Drawing.Size(1293, 280);
            this.display_enrollees.TabIndex = 0;
            this.display_enrollees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.display_enrollees_CellContentClick);
            // 
            // displayenrolleeResultBindingSource
            // 
            this.displayenrolleeResultBindingSource.DataSource = typeof(ENROLLMENT_System.display_enrolleeResult);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // applyidDataGridViewTextBoxColumn
            // 
            this.applyidDataGridViewTextBoxColumn.DataPropertyName = "Apply_id";
            this.applyidDataGridViewTextBoxColumn.HeaderText = "Apply_id";
            this.applyidDataGridViewTextBoxColumn.Name = "applyidDataGridViewTextBoxColumn";
            this.applyidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studidDataGridViewTextBoxColumn
            // 
            this.studidDataGridViewTextBoxColumn.DataPropertyName = "Stud_id";
            this.studidDataGridViewTextBoxColumn.HeaderText = "Stud_id";
            this.studidDataGridViewTextBoxColumn.Name = "studidDataGridViewTextBoxColumn";
            this.studidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studFnameDataGridViewTextBoxColumn
            // 
            this.studFnameDataGridViewTextBoxColumn.DataPropertyName = "Stud_Fname";
            this.studFnameDataGridViewTextBoxColumn.HeaderText = "Stud_Fname";
            this.studFnameDataGridViewTextBoxColumn.Name = "studFnameDataGridViewTextBoxColumn";
            this.studFnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studLnameDataGridViewTextBoxColumn
            // 
            this.studLnameDataGridViewTextBoxColumn.DataPropertyName = "Stud_Lname";
            this.studLnameDataGridViewTextBoxColumn.HeaderText = "Stud_Lname";
            this.studLnameDataGridViewTextBoxColumn.Name = "studLnameDataGridViewTextBoxColumn";
            this.studLnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // applySemDataGridViewTextBoxColumn
            // 
            this.applySemDataGridViewTextBoxColumn.DataPropertyName = "Apply_Sem";
            this.applySemDataGridViewTextBoxColumn.HeaderText = "Apply_Sem";
            this.applySemDataGridViewTextBoxColumn.Name = "applySemDataGridViewTextBoxColumn";
            this.applySemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // applyYrLvlDataGridViewTextBoxColumn
            // 
            this.applyYrLvlDataGridViewTextBoxColumn.DataPropertyName = "Apply_YrLvl";
            this.applyYrLvlDataGridViewTextBoxColumn.HeaderText = "Apply_YrLvl";
            this.applyYrLvlDataGridViewTextBoxColumn.Name = "applyYrLvlDataGridViewTextBoxColumn";
            this.applyYrLvlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classidDataGridViewTextBoxColumn
            // 
            this.classidDataGridViewTextBoxColumn.DataPropertyName = "Class_id";
            this.classidDataGridViewTextBoxColumn.HeaderText = "Class_id";
            this.classidDataGridViewTextBoxColumn.Name = "classidDataGridViewTextBoxColumn";
            this.classidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unameDataGridViewTextBoxColumn
            // 
            this.unameDataGridViewTextBoxColumn.DataPropertyName = "U_name";
            this.unameDataGridViewTextBoxColumn.HeaderText = "U_name";
            this.unameDataGridViewTextBoxColumn.Name = "unameDataGridViewTextBoxColumn";
            this.unameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Enroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1353, 737);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.enrollpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Enroll";
            this.Text = "Enroll";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.enrollpanel.ResumeLayout(false);
            this.panelin.ResumeLayout(false);
            this.panelin.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.display_enrollees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayenrolleeResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel enrollpanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.RadioButton declinebtn;
        private System.Windows.Forms.RadioButton approvebtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ClassCodeEnroll;
        private System.Windows.Forms.ComboBox yr_enroll;
        private System.Windows.Forms.ComboBox sem_enroll;
        private System.Windows.Forms.TextBox stud_enroll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchtb;
        private System.Windows.Forms.Panel panelin;
        private System.Windows.Forms.DataGridView display_enrollees;
        private TRControls.TRButtons addEnrollees;
        private TRControls.TRButtons submitbtn;
        private TRControls.TRButtons updatebtn;
        private System.Windows.Forms.BindingSource displayenrolleeResultBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studFnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applySemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyYrLvlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unameDataGridViewTextBoxColumn;
    }
}