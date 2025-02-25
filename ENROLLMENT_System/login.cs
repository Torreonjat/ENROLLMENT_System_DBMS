﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENROLLMENT_System
{
    public partial class login : Form
    {
        DataClassEnrollmentDataContext db = new DataClassEnrollmentDataContext();
        private Label timeLabel;
        private Timer timer;
        public login()
        {
            InitializeComponent();

            tbPassword.PasswordChar = '*';
            tbPassword.UseSystemPasswordChar = false;

            string Datenow = DateTime.Now.Date.ToString("D");

            date.Text = Datenow;
            time.Text = DateTime.Now.ToString("h:mm:ss tt"); // Use "h" for 12-hour format
            InitializeTimer();

            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
        }
        private void InitializeTimer()
        {
            timeLabel = new Label();
            timeLabel.Dock = DockStyle.Fill;
            timeLabel.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
            timeLabel.TextAlign = ContentAlignment.MiddleCenter;

            Controls.Add(timeLabel);

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            // Start the timer
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("h:mm:ss tt"); 
        }
        private bool AllTextBoxesFilled(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return false; 
                    }
                }
                else if (ctrl.HasChildren)
                {
                    if (!AllTextBoxesFilled(ctrl)) 
                    {
                        return false;
                    }
                }
            }
            return true; 
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            bool allTextBoxesFilled = AllTextBoxesFilled(this);
            if (!allTextBoxesFilled)
            {
                MessageBox.Show("Please Fill all fields", "Message");
                return;
            }
            string Username = tbUsername.Text;
            string Password = tbPassword.Text;

            var resultUser = db.select_userId(tbUsername.Text, tbPassword.Text).SingleOrDefault();

            if (resultUser != null)
            {
                int userId = resultUser.U_id; 
                userActive userLog = new userActive(userId, tbUsername.Text);

                userActive.CurrentUser.User = userLog;
            }
            else
            {
                MessageBox.Show("user ID and Username can not be found", "Message");
            }



            var exists = db.User_login(Username, Password).SingleOrDefault();

            if (exists != null)
            {
                FaceDetect detect = new FaceDetect();
                detect.Show();
                this.Hide();

            }
            else

            {
                MessageBox.Show("Account doesn't exits! Please register", "Message");
            }
        }

        private void linkregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Register register = new Register();
                register.FormClosed += Register_FormClosed;
                register.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();  
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = showPass.Checked ? '\0' : '*';
            tbPassword.UseSystemPasswordChar = showPass.Checked;
        }
    }
}
