
namespace ENROLLMENT_System
{
    partial class dataEnt_Proffessor
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
            this.prof_searchbar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updatepanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prof_bdate = new System.Windows.Forms.DateTimePicker();
            this.prof_gender = new System.Windows.Forms.ComboBox();
            this.profAddress = new System.Windows.Forms.TextBox();
            this.profEmail = new System.Windows.Forms.TextBox();
            this.profContact = new System.Windows.Forms.TextBox();
            this.ProfMname = new System.Windows.Forms.TextBox();
            this.profFname = new System.Windows.Forms.TextBox();
            this.profLname = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Prof_GridView = new System.Windows.Forms.DataGridView();
            this.displayprofResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Update = new ENROLLMENT_System.TRControls.TRButtons();
            this.createNew = new ENROLLMENT_System.TRControls.TRButtons();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.profidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profFnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profMnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profBdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profAddrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.updatepanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prof_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayprofResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.createNew);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.prof_searchbar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 80);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Search";
            // 
            // prof_searchbar
            // 
            this.prof_searchbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prof_searchbar.Location = new System.Drawing.Point(575, 43);
            this.prof_searchbar.Multiline = true;
            this.prof_searchbar.Name = "prof_searchbar";
            this.prof_searchbar.Size = new System.Drawing.Size(568, 34);
            this.prof_searchbar.TabIndex = 11;
            this.prof_searchbar.TextChanged += new System.EventHandler(this.prof_searchbar_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "TEACHER LIST";
            // 
            // updatepanel
            // 
            this.updatepanel.Controls.Add(this.Update);
            this.updatepanel.Controls.Add(this.label10);
            this.updatepanel.Controls.Add(this.label9);
            this.updatepanel.Controls.Add(this.label8);
            this.updatepanel.Controls.Add(this.label7);
            this.updatepanel.Controls.Add(this.label6);
            this.updatepanel.Controls.Add(this.label4);
            this.updatepanel.Controls.Add(this.label3);
            this.updatepanel.Controls.Add(this.label2);
            this.updatepanel.Controls.Add(this.prof_bdate);
            this.updatepanel.Controls.Add(this.prof_gender);
            this.updatepanel.Controls.Add(this.profAddress);
            this.updatepanel.Controls.Add(this.profEmail);
            this.updatepanel.Controls.Add(this.profContact);
            this.updatepanel.Controls.Add(this.ProfMname);
            this.updatepanel.Controls.Add(this.profFname);
            this.updatepanel.Controls.Add(this.profLname);
            this.updatepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.updatepanel.Location = new System.Drawing.Point(0, 80);
            this.updatepanel.Name = "updatepanel";
            this.updatepanel.Size = new System.Drawing.Size(1353, 249);
            this.updatepanel.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(455, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Contact";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(882, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(332, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Birth date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(681, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Middle name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Last name";
            // 
            // prof_bdate
            // 
            this.prof_bdate.Location = new System.Drawing.Point(439, 106);
            this.prof_bdate.Name = "prof_bdate";
            this.prof_bdate.Size = new System.Drawing.Size(200, 20);
            this.prof_bdate.TabIndex = 22;
            // 
            // prof_gender
            // 
            this.prof_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prof_gender.FormattingEnabled = true;
            this.prof_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.prof_gender.Location = new System.Drawing.Point(119, 96);
            this.prof_gender.Name = "prof_gender";
            this.prof_gender.Size = new System.Drawing.Size(148, 28);
            this.prof_gender.TabIndex = 21;
            // 
            // profAddress
            // 
            this.profAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profAddress.Location = new System.Drawing.Point(956, 22);
            this.profAddress.Multiline = true;
            this.profAddress.Name = "profAddress";
            this.profAddress.Size = new System.Drawing.Size(335, 94);
            this.profAddress.TabIndex = 17;
            // 
            // profEmail
            // 
            this.profEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profEmail.Location = new System.Drawing.Point(509, 164);
            this.profEmail.Multiline = true;
            this.profEmail.Name = "profEmail";
            this.profEmail.Size = new System.Drawing.Size(262, 34);
            this.profEmail.TabIndex = 16;
            // 
            // profContact
            // 
            this.profContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profContact.Location = new System.Drawing.Point(119, 164);
            this.profContact.Multiline = true;
            this.profContact.Name = "profContact";
            this.profContact.Size = new System.Drawing.Size(262, 34);
            this.profContact.TabIndex = 15;
            // 
            // ProfMname
            // 
            this.ProfMname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfMname.Location = new System.Drawing.Point(575, 22);
            this.ProfMname.Multiline = true;
            this.ProfMname.Name = "ProfMname";
            this.ProfMname.Size = new System.Drawing.Size(262, 34);
            this.ProfMname.TabIndex = 14;
            // 
            // profFname
            // 
            this.profFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profFname.Location = new System.Drawing.Point(307, 22);
            this.profFname.Multiline = true;
            this.profFname.Name = "profFname";
            this.profFname.Size = new System.Drawing.Size(262, 34);
            this.profFname.TabIndex = 13;
            // 
            // profLname
            // 
            this.profLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profLname.Location = new System.Drawing.Point(39, 22);
            this.profLname.Multiline = true;
            this.profLname.Name = "profLname";
            this.profLname.Size = new System.Drawing.Size(262, 34);
            this.profLname.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Prof_GridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 329);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1353, 408);
            this.panel3.TabIndex = 2;
            // 
            // Prof_GridView
            // 
            this.Prof_GridView.AllowUserToAddRows = false;
            this.Prof_GridView.AllowUserToDeleteRows = false;
            this.Prof_GridView.AutoGenerateColumns = false;
            this.Prof_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prof_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.profidDataGridViewTextBoxColumn,
            this.profFnameDataGridViewTextBoxColumn,
            this.profLnameDataGridViewTextBoxColumn,
            this.profMnameDataGridViewTextBoxColumn,
            this.profContactDataGridViewTextBoxColumn,
            this.profEmailDataGridViewTextBoxColumn,
            this.profGenderDataGridViewTextBoxColumn,
            this.profBdateDataGridViewTextBoxColumn,
            this.profAddrDataGridViewTextBoxColumn});
            this.Prof_GridView.DataSource = this.displayprofResultBindingSource;
            this.Prof_GridView.Location = new System.Drawing.Point(39, 7);
            this.Prof_GridView.Name = "Prof_GridView";
            this.Prof_GridView.ReadOnly = true;
            this.Prof_GridView.Size = new System.Drawing.Size(1274, 239);
            this.Prof_GridView.TabIndex = 0;
            this.Prof_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Prof_GridView_CellContentClick);
            // 
            // displayprofResultBindingSource
            // 
            this.displayprofResultBindingSource.DataSource = typeof(ENROLLMENT_System.display_profResult);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Update.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Update.BorderColor = System.Drawing.Color.Black;
            this.Update.BorderRadius = 20;
            this.Update.BorderSize = 1;
            this.Update.FlatAppearance.BorderSize = 0;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(1129, 178);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(162, 55);
            this.Update.TabIndex = 31;
            this.Update.Text = "Update";
            this.Update.TextColor = System.Drawing.Color.White;
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // createNew
            // 
            this.createNew.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.createNew.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.createNew.BorderColor = System.Drawing.Color.Black;
            this.createNew.BorderRadius = 15;
            this.createNew.BorderSize = 1;
            this.createNew.FlatAppearance.BorderSize = 0;
            this.createNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNew.ForeColor = System.Drawing.Color.White;
            this.createNew.Location = new System.Drawing.Point(1149, 34);
            this.createNew.Name = "createNew";
            this.createNew.Size = new System.Drawing.Size(142, 43);
            this.createNew.TabIndex = 13;
            this.createNew.Text = "CREATE NEW";
            this.createNew.TextColor = System.Drawing.Color.White;
            this.createNew.UseVisualStyleBackColor = false;
            this.createNew.Click += new System.EventHandler(this.createNew_Click);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // profidDataGridViewTextBoxColumn
            // 
            this.profidDataGridViewTextBoxColumn.DataPropertyName = "Prof_id";
            this.profidDataGridViewTextBoxColumn.HeaderText = "Prof_id";
            this.profidDataGridViewTextBoxColumn.Name = "profidDataGridViewTextBoxColumn";
            this.profidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profFnameDataGridViewTextBoxColumn
            // 
            this.profFnameDataGridViewTextBoxColumn.DataPropertyName = "Prof_Fname";
            this.profFnameDataGridViewTextBoxColumn.HeaderText = "Prof_Fname";
            this.profFnameDataGridViewTextBoxColumn.Name = "profFnameDataGridViewTextBoxColumn";
            this.profFnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profLnameDataGridViewTextBoxColumn
            // 
            this.profLnameDataGridViewTextBoxColumn.DataPropertyName = "Prof_Lname";
            this.profLnameDataGridViewTextBoxColumn.HeaderText = "Prof_Lname";
            this.profLnameDataGridViewTextBoxColumn.Name = "profLnameDataGridViewTextBoxColumn";
            this.profLnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profMnameDataGridViewTextBoxColumn
            // 
            this.profMnameDataGridViewTextBoxColumn.DataPropertyName = "Prof_Mname";
            this.profMnameDataGridViewTextBoxColumn.HeaderText = "Prof_Mname";
            this.profMnameDataGridViewTextBoxColumn.Name = "profMnameDataGridViewTextBoxColumn";
            this.profMnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profContactDataGridViewTextBoxColumn
            // 
            this.profContactDataGridViewTextBoxColumn.DataPropertyName = "Prof_Contact";
            this.profContactDataGridViewTextBoxColumn.HeaderText = "Prof_Contact";
            this.profContactDataGridViewTextBoxColumn.Name = "profContactDataGridViewTextBoxColumn";
            this.profContactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profEmailDataGridViewTextBoxColumn
            // 
            this.profEmailDataGridViewTextBoxColumn.DataPropertyName = "Prof_Email";
            this.profEmailDataGridViewTextBoxColumn.HeaderText = "Prof_Email";
            this.profEmailDataGridViewTextBoxColumn.Name = "profEmailDataGridViewTextBoxColumn";
            this.profEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profGenderDataGridViewTextBoxColumn
            // 
            this.profGenderDataGridViewTextBoxColumn.DataPropertyName = "Prof_Gender";
            this.profGenderDataGridViewTextBoxColumn.HeaderText = "Prof_Gender";
            this.profGenderDataGridViewTextBoxColumn.Name = "profGenderDataGridViewTextBoxColumn";
            this.profGenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profBdateDataGridViewTextBoxColumn
            // 
            this.profBdateDataGridViewTextBoxColumn.DataPropertyName = "Prof_Bdate";
            this.profBdateDataGridViewTextBoxColumn.HeaderText = "Prof_Bdate";
            this.profBdateDataGridViewTextBoxColumn.Name = "profBdateDataGridViewTextBoxColumn";
            this.profBdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profAddrDataGridViewTextBoxColumn
            // 
            this.profAddrDataGridViewTextBoxColumn.DataPropertyName = "Prof_Addr";
            this.profAddrDataGridViewTextBoxColumn.HeaderText = "Prof_Addr";
            this.profAddrDataGridViewTextBoxColumn.Name = "profAddrDataGridViewTextBoxColumn";
            this.profAddrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataEnt_Proffessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1353, 737);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.updatepanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dataEnt_Proffessor";
            this.Text = "dataEnt_Proffessor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.updatepanel.ResumeLayout(false);
            this.updatepanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Prof_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayprofResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel updatepanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prof_searchbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox profAddress;
        private System.Windows.Forms.TextBox profEmail;
        private System.Windows.Forms.TextBox profContact;
        private System.Windows.Forms.TextBox ProfMname;
        private System.Windows.Forms.TextBox profFname;
        private System.Windows.Forms.TextBox profLname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker prof_bdate;
        private System.Windows.Forms.ComboBox prof_gender;
        private System.Windows.Forms.DataGridView Prof_GridView;
        private TRControls.TRButtons createNew;
        private TRControls.TRButtons Update;
        private System.Windows.Forms.BindingSource displayprofResultBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn profidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profFnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profMnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profBdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profAddrDataGridViewTextBoxColumn;
    }
}