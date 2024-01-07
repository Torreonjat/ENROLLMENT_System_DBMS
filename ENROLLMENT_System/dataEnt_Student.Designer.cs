
namespace ENROLLMENT_System
{
    partial class dataEnt_Student
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
            this.addStud = new ENROLLMENT_System.TRControls.TRButtons();
            this.searchstud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Guardian_num = new System.Windows.Forms.TextBox();
            this.Guardian_Stud = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Address_Stud = new System.Windows.Forms.TextBox();
            this.bDate_Stud = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Email_Stud = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Gender_stud = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Phone_Stud = new System.Windows.Forms.TextBox();
            this.Program_Stud = new System.Windows.Forms.ComboBox();
            this.Year_Stud = new System.Windows.Forms.ComboBox();
            this.Status_Stud = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Mname_Stud = new System.Windows.Forms.TextBox();
            this.Fname_Stud = new System.Windows.Forms.TextBox();
            this.Lname_Stud = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.student_GridView = new System.Windows.Forms.DataGridView();
            this.Updatebtn = new ENROLLMENT_System.TRControls.TRButtons();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.studidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studFnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studMnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studBdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studAddrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studGuardianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studGuardiannoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prognameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displaystudentResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displaystudentResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addStud);
            this.panel1.Controls.Add(this.searchstud);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 80);
            this.panel1.TabIndex = 0;
            // 
            // addStud
            // 
            this.addStud.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addStud.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.addStud.BorderColor = System.Drawing.Color.Black;
            this.addStud.BorderRadius = 20;
            this.addStud.BorderSize = 1;
            this.addStud.FlatAppearance.BorderSize = 0;
            this.addStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStud.ForeColor = System.Drawing.Color.White;
            this.addStud.Location = new System.Drawing.Point(1150, 24);
            this.addStud.Name = "addStud";
            this.addStud.Size = new System.Drawing.Size(175, 50);
            this.addStud.TabIndex = 18;
            this.addStud.Text = "Create New";
            this.addStud.TextColor = System.Drawing.Color.White;
            this.addStud.UseVisualStyleBackColor = false;
            this.addStud.Click += new System.EventHandler(this.addStud_Click);
            // 
            // searchstud
            // 
            this.searchstud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchstud.Location = new System.Drawing.Point(660, 40);
            this.searchstud.Multiline = true;
            this.searchstud.Name = "searchstud";
            this.searchstud.Size = new System.Drawing.Size(469, 34);
            this.searchstud.TabIndex = 15;
            this.searchstud.TextChanged += new System.EventHandler(this.searchstud_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 44);
            this.label1.TabIndex = 14;
            this.label1.Text = "STUDENT MASTER LIST";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Updatebtn);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.Guardian_num);
            this.panel2.Controls.Add(this.Guardian_Stud);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.Address_Stud);
            this.panel2.Controls.Add(this.bDate_Stud);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.Email_Stud);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.Gender_stud);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Phone_Stud);
            this.panel2.Controls.Add(this.Program_Stud);
            this.panel2.Controls.Add(this.Year_Stud);
            this.panel2.Controls.Add(this.Status_Stud);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Mname_Stud);
            this.panel2.Controls.Add(this.Fname_Stud);
            this.panel2.Controls.Add(this.Lname_Stud);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1353, 293);
            this.panel2.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1048, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 20);
            this.label15.TabIndex = 52;
            this.label15.Text = "Phone Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1042, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 20);
            this.label14.TabIndex = 51;
            this.label14.Text = "Guardian Name";
            // 
            // Guardian_num
            // 
            this.Guardian_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardian_num.Location = new System.Drawing.Point(1046, 118);
            this.Guardian_num.Multiline = true;
            this.Guardian_num.Name = "Guardian_num";
            this.Guardian_num.Size = new System.Drawing.Size(265, 34);
            this.Guardian_num.TabIndex = 50;
            // 
            // Guardian_Stud
            // 
            this.Guardian_Stud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardian_Stud.Location = new System.Drawing.Point(1046, 50);
            this.Guardian_Stud.Multiline = true;
            this.Guardian_Stud.Name = "Guardian_Stud";
            this.Guardian_Stud.Size = new System.Drawing.Size(265, 34);
            this.Guardian_Stud.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1111, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 20);
            this.label13.TabIndex = 48;
            this.label13.Text = "GUARDIAN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(522, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "Address";
            // 
            // Address_Stud
            // 
            this.Address_Stud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_Stud.Location = new System.Drawing.Point(612, 197);
            this.Address_Stud.Multiline = true;
            this.Address_Stud.Name = "Address_Stud";
            this.Address_Stud.Size = new System.Drawing.Size(253, 34);
            this.Address_Stud.TabIndex = 46;
            // 
            // bDate_Stud
            // 
            this.bDate_Stud.Location = new System.Drawing.Point(612, 125);
            this.bDate_Stud.Name = "bDate_Stud";
            this.bDate_Stud.Size = new System.Drawing.Size(253, 20);
            this.bDate_Stud.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(522, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Birthdate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(522, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "Email";
            // 
            // Email_Stud
            // 
            this.Email_Stud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Stud.Location = new System.Drawing.Point(612, 154);
            this.Email_Stud.Multiline = true;
            this.Email_Stud.Name = "Email_Stud";
            this.Email_Stud.Size = new System.Drawing.Size(253, 34);
            this.Email_Stud.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(522, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Gender";
            // 
            // Gender_stud
            // 
            this.Gender_stud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_stud.FormattingEnabled = true;
            this.Gender_stud.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.Gender_stud.Location = new System.Drawing.Point(612, 78);
            this.Gender_stud.Name = "Gender_stud";
            this.Gender_stud.Size = new System.Drawing.Size(253, 28);
            this.Gender_stud.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Phone No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Program";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Year Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Status";
            // 
            // Phone_Stud
            // 
            this.Phone_Stud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_Stud.Location = new System.Drawing.Point(116, 198);
            this.Phone_Stud.Multiline = true;
            this.Phone_Stud.Name = "Phone_Stud";
            this.Phone_Stud.Size = new System.Drawing.Size(253, 34);
            this.Phone_Stud.TabIndex = 35;
            // 
            // Program_Stud
            // 
            this.Program_Stud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Program_Stud.FormattingEnabled = true;
            this.Program_Stud.Location = new System.Drawing.Point(116, 161);
            this.Program_Stud.Name = "Program_Stud";
            this.Program_Stud.Size = new System.Drawing.Size(253, 28);
            this.Program_Stud.TabIndex = 34;
            // 
            // Year_Stud
            // 
            this.Year_Stud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year_Stud.FormattingEnabled = true;
            this.Year_Stud.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.Year_Stud.Location = new System.Drawing.Point(116, 118);
            this.Year_Stud.Name = "Year_Stud";
            this.Year_Stud.Size = new System.Drawing.Size(253, 28);
            this.Year_Stud.TabIndex = 33;
            // 
            // Status_Stud
            // 
            this.Status_Stud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_Stud.FormattingEnabled = true;
            this.Status_Stud.Items.AddRange(new object[] {
            "New Student",
            "Old Student",
            "Transferee",
            "Returnee"});
            this.Status_Stud.Location = new System.Drawing.Point(116, 79);
            this.Status_Stud.Name = "Status_Stud";
            this.Status_Stud.Size = new System.Drawing.Size(253, 28);
            this.Status_Stud.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(661, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Middle name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Last name";
            // 
            // Mname_Stud
            // 
            this.Mname_Stud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mname_Stud.Location = new System.Drawing.Point(555, 6);
            this.Mname_Stud.Multiline = true;
            this.Mname_Stud.Name = "Mname_Stud";
            this.Mname_Stud.Size = new System.Drawing.Size(262, 34);
            this.Mname_Stud.TabIndex = 28;
            // 
            // Fname_Stud
            // 
            this.Fname_Stud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname_Stud.Location = new System.Drawing.Point(287, 6);
            this.Fname_Stud.Multiline = true;
            this.Fname_Stud.Name = "Fname_Stud";
            this.Fname_Stud.Size = new System.Drawing.Size(262, 34);
            this.Fname_Stud.TabIndex = 27;
            // 
            // Lname_Stud
            // 
            this.Lname_Stud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname_Stud.Location = new System.Drawing.Point(19, 6);
            this.Lname_Stud.Multiline = true;
            this.Lname_Stud.Name = "Lname_Stud";
            this.Lname_Stud.Size = new System.Drawing.Size(262, 34);
            this.Lname_Stud.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.student_GridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 373);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1353, 364);
            this.panel3.TabIndex = 2;
            // 
            // student_GridView
            // 
            this.student_GridView.AllowUserToAddRows = false;
            this.student_GridView.AllowUserToDeleteRows = false;
            this.student_GridView.AutoGenerateColumns = false;
            this.student_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete,
            this.studidDataGridViewTextBoxColumn,
            this.studFnameDataGridViewTextBoxColumn,
            this.studLnameDataGridViewTextBoxColumn,
            this.studMnameDataGridViewTextBoxColumn,
            this.studStatusDataGridViewTextBoxColumn,
            this.studyearDataGridViewTextBoxColumn,
            this.studContactDataGridViewTextBoxColumn,
            this.studEmailDataGridViewTextBoxColumn,
            this.studGenderDataGridViewTextBoxColumn,
            this.studBdateDataGridViewTextBoxColumn,
            this.studAddrDataGridViewTextBoxColumn,
            this.studGuardianDataGridViewTextBoxColumn,
            this.studGuardiannoDataGridViewTextBoxColumn,
            this.progidDataGridViewTextBoxColumn,
            this.prognameDataGridViewTextBoxColumn});
            this.student_GridView.DataSource = this.displaystudentResultBindingSource;
            this.student_GridView.Location = new System.Drawing.Point(20, 15);
            this.student_GridView.Name = "student_GridView";
            this.student_GridView.ReadOnly = true;
            this.student_GridView.Size = new System.Drawing.Size(1291, 290);
            this.student_GridView.TabIndex = 0;
            this.student_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_GridView_CellContentClick);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Updatebtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Updatebtn.BorderColor = System.Drawing.Color.Black;
            this.Updatebtn.BorderRadius = 20;
            this.Updatebtn.BorderSize = 1;
            this.Updatebtn.FlatAppearance.BorderSize = 0;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.ForeColor = System.Drawing.Color.White;
            this.Updatebtn.Location = new System.Drawing.Point(1105, 206);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(221, 59);
            this.Updatebtn.TabIndex = 53;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.TextColor = System.Drawing.Color.White;
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
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
            // studMnameDataGridViewTextBoxColumn
            // 
            this.studMnameDataGridViewTextBoxColumn.DataPropertyName = "Stud_Mname";
            this.studMnameDataGridViewTextBoxColumn.HeaderText = "Stud_Mname";
            this.studMnameDataGridViewTextBoxColumn.Name = "studMnameDataGridViewTextBoxColumn";
            this.studMnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studStatusDataGridViewTextBoxColumn
            // 
            this.studStatusDataGridViewTextBoxColumn.DataPropertyName = "Stud_Status";
            this.studStatusDataGridViewTextBoxColumn.HeaderText = "Stud_Status";
            this.studStatusDataGridViewTextBoxColumn.Name = "studStatusDataGridViewTextBoxColumn";
            this.studStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studyearDataGridViewTextBoxColumn
            // 
            this.studyearDataGridViewTextBoxColumn.DataPropertyName = "Stud_year";
            this.studyearDataGridViewTextBoxColumn.HeaderText = "Stud_year";
            this.studyearDataGridViewTextBoxColumn.Name = "studyearDataGridViewTextBoxColumn";
            this.studyearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studContactDataGridViewTextBoxColumn
            // 
            this.studContactDataGridViewTextBoxColumn.DataPropertyName = "Stud_Contact";
            this.studContactDataGridViewTextBoxColumn.HeaderText = "Stud_Contact";
            this.studContactDataGridViewTextBoxColumn.Name = "studContactDataGridViewTextBoxColumn";
            this.studContactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studEmailDataGridViewTextBoxColumn
            // 
            this.studEmailDataGridViewTextBoxColumn.DataPropertyName = "Stud_Email";
            this.studEmailDataGridViewTextBoxColumn.HeaderText = "Stud_Email";
            this.studEmailDataGridViewTextBoxColumn.Name = "studEmailDataGridViewTextBoxColumn";
            this.studEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studGenderDataGridViewTextBoxColumn
            // 
            this.studGenderDataGridViewTextBoxColumn.DataPropertyName = "Stud_Gender";
            this.studGenderDataGridViewTextBoxColumn.HeaderText = "Stud_Gender";
            this.studGenderDataGridViewTextBoxColumn.Name = "studGenderDataGridViewTextBoxColumn";
            this.studGenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studBdateDataGridViewTextBoxColumn
            // 
            this.studBdateDataGridViewTextBoxColumn.DataPropertyName = "Stud_Bdate";
            this.studBdateDataGridViewTextBoxColumn.HeaderText = "Stud_Bdate";
            this.studBdateDataGridViewTextBoxColumn.Name = "studBdateDataGridViewTextBoxColumn";
            this.studBdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studAddrDataGridViewTextBoxColumn
            // 
            this.studAddrDataGridViewTextBoxColumn.DataPropertyName = "Stud_Addr";
            this.studAddrDataGridViewTextBoxColumn.HeaderText = "Stud_Addr";
            this.studAddrDataGridViewTextBoxColumn.Name = "studAddrDataGridViewTextBoxColumn";
            this.studAddrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studGuardianDataGridViewTextBoxColumn
            // 
            this.studGuardianDataGridViewTextBoxColumn.DataPropertyName = "Stud_Guardian";
            this.studGuardianDataGridViewTextBoxColumn.HeaderText = "Stud_Guardian";
            this.studGuardianDataGridViewTextBoxColumn.Name = "studGuardianDataGridViewTextBoxColumn";
            this.studGuardianDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studGuardiannoDataGridViewTextBoxColumn
            // 
            this.studGuardiannoDataGridViewTextBoxColumn.DataPropertyName = "Stud_Guardian_no";
            this.studGuardiannoDataGridViewTextBoxColumn.HeaderText = "Stud_Guardian_no";
            this.studGuardiannoDataGridViewTextBoxColumn.Name = "studGuardiannoDataGridViewTextBoxColumn";
            this.studGuardiannoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // displaystudentResultBindingSource
            // 
            this.displaystudentResultBindingSource.DataSource = typeof(ENROLLMENT_System.display_studentResult);
            // 
            // dataEnt_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1353, 737);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dataEnt_Student";
            this.Text = "dataEnt_Student";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.student_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displaystudentResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox searchstud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Mname_Stud;
        private System.Windows.Forms.TextBox Fname_Stud;
        private System.Windows.Forms.TextBox Lname_Stud;
        private System.Windows.Forms.ComboBox Status_Stud;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Email_Stud;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Gender_stud;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Phone_Stud;
        private System.Windows.Forms.ComboBox Program_Stud;
        private System.Windows.Forms.ComboBox Year_Stud;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Guardian_num;
        private System.Windows.Forms.TextBox Guardian_Stud;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Address_Stud;
        private System.Windows.Forms.DateTimePicker bDate_Stud;
        private System.Windows.Forms.DataGridView student_GridView;
        private TRControls.TRButtons addStud;
        private TRControls.TRButtons Updatebtn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn studidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studFnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studMnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studBdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studAddrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studGuardianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studGuardiannoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn progidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prognameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource displaystudentResultBindingSource;
    }
}