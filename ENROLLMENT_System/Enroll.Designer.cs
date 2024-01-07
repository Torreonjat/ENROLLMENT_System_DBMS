
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbtime = new System.Windows.Forms.Label();
            this.lbdate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.updatebtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
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
            this.submitbtn = new System.Windows.Forms.Button();
            this.addEnrollees = new System.Windows.Forms.Button();
            this.searchtb = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.display_enrollees = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.display_enrollees)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1337, 77);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENROLL STUDENT";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbtime);
            this.panel2.Controls.Add(this.lbdate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1337, 44);
            this.panel2.TabIndex = 1;
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtime.Location = new System.Drawing.Point(1069, 12);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(43, 20);
            this.lbtime.TabIndex = 1;
            this.lbtime.Text = "Time";
            // 
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate.Location = new System.Drawing.Point(798, 12);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(44, 20);
            this.lbdate.TabIndex = 0;
            this.lbdate.Text = "Date";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.updatebtn);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.submitbtn);
            this.panel3.Controls.Add(this.addEnrollees);
            this.panel3.Controls.Add(this.searchtb);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1337, 274);
            this.panel3.TabIndex = 2;
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(1073, 146);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(187, 46);
            this.updatebtn.TabIndex = 15;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel5.Controls.Add(this.ClassCodeEnroll);
            this.panel5.Controls.Add(this.declinebtn);
            this.panel5.Controls.Add(this.sem_enroll);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.stud_enroll);
            this.panel5.Controls.Add(this.approvebtn);
            this.panel5.Controls.Add(this.yr_enroll);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(31, 61);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1028, 207);
            this.panel5.TabIndex = 14;
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
            this.stud_enroll.Size = new System.Drawing.Size(261, 20);
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
            // submitbtn
            // 
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.Location = new System.Drawing.Point(1073, 79);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(187, 46);
            this.submitbtn.TabIndex = 13;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            // 
            // addEnrollees
            // 
            this.addEnrollees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEnrollees.Location = new System.Drawing.Point(1073, 6);
            this.addEnrollees.Name = "addEnrollees";
            this.addEnrollees.Size = new System.Drawing.Size(187, 34);
            this.addEnrollees.TabIndex = 1;
            this.addEnrollees.Text = "Create  New";
            this.addEnrollees.UseVisualStyleBackColor = true;
            // 
            // searchtb
            // 
            this.searchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtb.Location = new System.Drawing.Point(491, 6);
            this.searchtb.Multiline = true;
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(568, 34);
            this.searchtb.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.display_enrollees);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 395);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1337, 303);
            this.panel4.TabIndex = 3;
            // 
            // display_enrollees
            // 
            this.display_enrollees.AllowUserToAddRows = false;
            this.display_enrollees.AllowUserToDeleteRows = false;
            this.display_enrollees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.display_enrollees.Location = new System.Drawing.Point(31, 20);
            this.display_enrollees.Name = "display_enrollees";
            this.display_enrollees.ReadOnly = true;
            this.display_enrollees.Size = new System.Drawing.Size(1272, 280);
            this.display_enrollees.TabIndex = 0;
            // 
            // Enroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1337, 698);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Enroll";
            this.Text = "Enroll";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.display_enrollees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
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
        private System.Windows.Forms.Button addEnrollees;
        private System.Windows.Forms.TextBox searchtb;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.DataGridView display_enrollees;
        private System.Windows.Forms.Button updatebtn;
    }
}