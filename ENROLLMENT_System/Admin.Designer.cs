
namespace ENROLLMENT_System
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panelside = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboardContainer = new System.Windows.Forms.Panel();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.enrollContainer = new System.Windows.Forms.Panel();
            this.btn_enroll = new System.Windows.Forms.Button();
            this.dataentryContainer = new System.Windows.Forms.Panel();
            this.btn_data = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.btnProffesor = new System.Windows.Forms.Button();
            this.btnSection = new System.Windows.Forms.Button();
            this.btnProgram = new System.Windows.Forms.Button();
            this.recordscontainer = new System.Windows.Forms.Panel();
            this.btnrecords = new System.Windows.Forms.Button();
            this.settingscontainer = new System.Windows.Forms.Panel();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btn_ChangePass = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.logoutcontainer = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.dataEntryTimer_Tick = new System.Windows.Forms.Timer(this.components);
            this.settingsTimer_Tick = new System.Windows.Forms.Timer(this.components);
            this.panelside.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dashboardContainer.SuspendLayout();
            this.enrollContainer.SuspendLayout();
            this.dataentryContainer.SuspendLayout();
            this.recordscontainer.SuspendLayout();
            this.settingscontainer.SuspendLayout();
            this.logoutcontainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panelside.Controls.Add(this.panel1);
            this.panelside.Controls.Add(this.dashboardContainer);
            this.panelside.Controls.Add(this.enrollContainer);
            this.panelside.Controls.Add(this.dataentryContainer);
            this.panelside.Controls.Add(this.recordscontainer);
            this.panelside.Controls.Add(this.settingscontainer);
            this.panelside.Controls.Add(this.logoutcontainer);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 0);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(234, 737);
            this.panelside.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 180);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dashboardContainer
            // 
            this.dashboardContainer.Controls.Add(this.btn_dashboard);
            this.dashboardContainer.Location = new System.Drawing.Point(3, 189);
            this.dashboardContainer.Name = "dashboardContainer";
            this.dashboardContainer.Size = new System.Drawing.Size(226, 56);
            this.dashboardContainer.TabIndex = 1;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_dashboard.Image")));
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 0);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_dashboard.Size = new System.Drawing.Size(226, 56);
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.Text = "            DASHBOARD";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // enrollContainer
            // 
            this.enrollContainer.Controls.Add(this.btn_enroll);
            this.enrollContainer.Location = new System.Drawing.Point(3, 251);
            this.enrollContainer.Name = "enrollContainer";
            this.enrollContainer.Size = new System.Drawing.Size(226, 56);
            this.enrollContainer.TabIndex = 2;
            // 
            // btn_enroll
            // 
            this.btn_enroll.FlatAppearance.BorderSize = 0;
            this.btn_enroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enroll.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_enroll.Image = ((System.Drawing.Image)(resources.GetObject("btn_enroll.Image")));
            this.btn_enroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_enroll.Location = new System.Drawing.Point(0, 0);
            this.btn_enroll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_enroll.Name = "btn_enroll";
            this.btn_enroll.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_enroll.Size = new System.Drawing.Size(226, 56);
            this.btn_enroll.TabIndex = 0;
            this.btn_enroll.Text = "            ENROLL";
            this.btn_enroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_enroll.UseVisualStyleBackColor = true;
            this.btn_enroll.Click += new System.EventHandler(this.btn_enroll_Click);
            // 
            // dataentryContainer
            // 
            this.dataentryContainer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataentryContainer.Controls.Add(this.btn_data);
            this.dataentryContainer.Controls.Add(this.btnClass);
            this.dataentryContainer.Controls.Add(this.btnStudent);
            this.dataentryContainer.Controls.Add(this.btnSubjects);
            this.dataentryContainer.Controls.Add(this.btnProffesor);
            this.dataentryContainer.Controls.Add(this.btnSection);
            this.dataentryContainer.Controls.Add(this.btnProgram);
            this.dataentryContainer.Location = new System.Drawing.Point(3, 313);
            this.dataentryContainer.MaximumSize = new System.Drawing.Size(226, 227);
            this.dataentryContainer.MinimumSize = new System.Drawing.Size(226, 56);
            this.dataentryContainer.Name = "dataentryContainer";
            this.dataentryContainer.Size = new System.Drawing.Size(226, 56);
            this.dataentryContainer.TabIndex = 2;
            // 
            // btn_data
            // 
            this.btn_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_data.FlatAppearance.BorderSize = 0;
            this.btn_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_data.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_data.Image = ((System.Drawing.Image)(resources.GetObject("btn_data.Image")));
            this.btn_data.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_data.Location = new System.Drawing.Point(0, 0);
            this.btn_data.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_data.Name = "btn_data";
            this.btn_data.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_data.Size = new System.Drawing.Size(226, 56);
            this.btn_data.TabIndex = 15;
            this.btn_data.Text = "            DATA ENTRY";
            this.btn_data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_data.UseVisualStyleBackColor = false;
            this.btn_data.Click += new System.EventHandler(this.btn_data_Click);
            // 
            // btnClass
            // 
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Location = new System.Drawing.Point(0, 198);
            this.btnClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClass.Name = "btnClass";
            this.btnClass.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnClass.Size = new System.Drawing.Size(226, 29);
            this.btnClass.TabIndex = 14;
            this.btnClass.Text = "               CLASS";
            this.btnClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Location = new System.Drawing.Point(0, 170);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnStudent.Size = new System.Drawing.Size(226, 29);
            this.btnStudent.TabIndex = 13;
            this.btnStudent.Text = "               STUDENT";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.FlatAppearance.BorderSize = 0;
            this.btnSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubjects.Location = new System.Drawing.Point(0, 86);
            this.btnSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSubjects.Size = new System.Drawing.Size(226, 29);
            this.btnSubjects.TabIndex = 10;
            this.btnSubjects.Text = "               SUBJECTS";
            this.btnSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubjects.UseVisualStyleBackColor = true;
            this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
            // 
            // btnProffesor
            // 
            this.btnProffesor.FlatAppearance.BorderSize = 0;
            this.btnProffesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProffesor.Location = new System.Drawing.Point(0, 142);
            this.btnProffesor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProffesor.Name = "btnProffesor";
            this.btnProffesor.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnProffesor.Size = new System.Drawing.Size(226, 29);
            this.btnProffesor.TabIndex = 12;
            this.btnProffesor.Text = "               PROFFESSOR";
            this.btnProffesor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProffesor.UseVisualStyleBackColor = true;
            this.btnProffesor.Click += new System.EventHandler(this.btnProffesor_Click);
            // 
            // btnSection
            // 
            this.btnSection.FlatAppearance.BorderSize = 0;
            this.btnSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSection.Location = new System.Drawing.Point(0, 114);
            this.btnSection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSection.Name = "btnSection";
            this.btnSection.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSection.Size = new System.Drawing.Size(226, 29);
            this.btnSection.TabIndex = 11;
            this.btnSection.Text = "               SECTION";
            this.btnSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSection.UseVisualStyleBackColor = true;
            this.btnSection.Click += new System.EventHandler(this.btnSection_Click);
            // 
            // btnProgram
            // 
            this.btnProgram.FlatAppearance.BorderSize = 0;
            this.btnProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgram.Location = new System.Drawing.Point(0, 56);
            this.btnProgram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnProgram.Size = new System.Drawing.Size(226, 32);
            this.btnProgram.TabIndex = 9;
            this.btnProgram.Text = "               PROGRAM";
            this.btnProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProgram.UseVisualStyleBackColor = true;
            this.btnProgram.Click += new System.EventHandler(this.btnProgram_Click);
            // 
            // recordscontainer
            // 
            this.recordscontainer.Controls.Add(this.btnrecords);
            this.recordscontainer.Location = new System.Drawing.Point(3, 375);
            this.recordscontainer.Name = "recordscontainer";
            this.recordscontainer.Size = new System.Drawing.Size(226, 56);
            this.recordscontainer.TabIndex = 2;
            // 
            // btnrecords
            // 
            this.btnrecords.FlatAppearance.BorderSize = 0;
            this.btnrecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecords.ForeColor = System.Drawing.SystemColors.Control;
            this.btnrecords.Image = ((System.Drawing.Image)(resources.GetObject("btnrecords.Image")));
            this.btnrecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrecords.Location = new System.Drawing.Point(0, 0);
            this.btnrecords.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnrecords.Name = "btnrecords";
            this.btnrecords.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnrecords.Size = new System.Drawing.Size(226, 56);
            this.btnrecords.TabIndex = 0;
            this.btnrecords.Text = "            RECORDS";
            this.btnrecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrecords.UseVisualStyleBackColor = true;
            this.btnrecords.Click += new System.EventHandler(this.btnrecords_Click);
            // 
            // settingscontainer
            // 
            this.settingscontainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.settingscontainer.Controls.Add(this.btnsettings);
            this.settingscontainer.Controls.Add(this.btn_ChangePass);
            this.settingscontainer.Controls.Add(this.btnProfile);
            this.settingscontainer.Location = new System.Drawing.Point(3, 437);
            this.settingscontainer.MaximumSize = new System.Drawing.Size(226, 138);
            this.settingscontainer.MinimumSize = new System.Drawing.Size(226, 57);
            this.settingscontainer.Name = "settingscontainer";
            this.settingscontainer.Size = new System.Drawing.Size(226, 57);
            this.settingscontainer.TabIndex = 2;
            // 
            // btnsettings
            // 
            this.btnsettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnsettings.FlatAppearance.BorderSize = 0;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsettings.Image = ((System.Drawing.Image)(resources.GetObject("btnsettings.Image")));
            this.btnsettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsettings.Location = new System.Drawing.Point(0, -4);
            this.btnsettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnsettings.Size = new System.Drawing.Size(226, 61);
            this.btnsettings.TabIndex = 3;
            this.btnsettings.Text = "            SETTINGS";
            this.btnsettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsettings.UseVisualStyleBackColor = false;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // btn_ChangePass
            // 
            this.btn_ChangePass.FlatAppearance.BorderSize = 0;
            this.btn_ChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangePass.Location = new System.Drawing.Point(0, 93);
            this.btn_ChangePass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_ChangePass.Name = "btn_ChangePass";
            this.btn_ChangePass.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_ChangePass.Size = new System.Drawing.Size(226, 41);
            this.btn_ChangePass.TabIndex = 2;
            this.btn_ChangePass.Text = "            CHANGE PASSWORD";
            this.btn_ChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChangePass.UseVisualStyleBackColor = true;
            this.btn_ChangePass.Click += new System.EventHandler(this.btn_ChangePass_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Location = new System.Drawing.Point(0, 54);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(226, 41);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "            PROFILE";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // logoutcontainer
            // 
            this.logoutcontainer.Controls.Add(this.btnlogout);
            this.logoutcontainer.Location = new System.Drawing.Point(3, 500);
            this.logoutcontainer.Name = "logoutcontainer";
            this.logoutcontainer.Size = new System.Drawing.Size(226, 56);
            this.logoutcontainer.TabIndex = 2;
            // 
            // btnlogout
            // 
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(0, 0);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnlogout.Size = new System.Drawing.Size(226, 56);
            this.btnlogout.TabIndex = 0;
            this.btnlogout.Text = "            LOGOUT";
            this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.UseVisualStyleBackColor = true;
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(234, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1353, 737);
            this.mainpanel.TabIndex = 1;
            // 
            // dataEntryTimer_Tick
            // 
            this.dataEntryTimer_Tick.Interval = 1;
            this.dataEntryTimer_Tick.Tick += new System.EventHandler(this.dataEntryTimer_Tick_Tick);
            // 
            // settingsTimer_Tick
            // 
            this.settingsTimer_Tick.Interval = 1;
            this.settingsTimer_Tick.Tick += new System.EventHandler(this.settingsTimer_Tick_Tick);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 737);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelside);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelside.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.dashboardContainer.ResumeLayout(false);
            this.enrollContainer.ResumeLayout(false);
            this.dataentryContainer.ResumeLayout(false);
            this.recordscontainer.ResumeLayout(false);
            this.settingscontainer.ResumeLayout(false);
            this.logoutcontainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelside;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel dashboardContainer;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Panel logoutcontainer;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Panel settingscontainer;
        private System.Windows.Forms.Panel recordscontainer;
        private System.Windows.Forms.Button btnrecords;
        private System.Windows.Forms.Panel dataentryContainer;
        private System.Windows.Forms.Panel enrollContainer;
        private System.Windows.Forms.Button btn_enroll;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button btnProffesor;
        private System.Windows.Forms.Button btnSection;
        private System.Windows.Forms.Button btnProgram;
        private System.Windows.Forms.Button btn_data;
        private System.Windows.Forms.Button btn_ChangePass;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer dataEntryTimer_Tick;
        private System.Windows.Forms.Timer settingsTimer_Tick;
    }
}

