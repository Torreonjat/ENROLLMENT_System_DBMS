using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;
using System.Text.RegularExpressions;

namespace ENROLLMENT_System
{
    public partial class Register : Form
    {
        DataClassEnrollmentDataContext db = new DataClassEnrollmentDataContext();
        FaceRec fc = new FaceRec();
        public Register()
        {
            InitializeComponent();
            fc.openCamera(pbCamera, pbCapture);

            reg_Pass.PasswordChar = '*';
            reg_Pass.UseSystemPasswordChar = false;
            reg_ConPass.PasswordChar = '*';
            reg_ConPass.UseSystemPasswordChar = false;

            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
        }
        private bool AllTextBoxesFilled(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return false; // At least one textbox is not filled
                    }
                }
                else if (ctrl.HasChildren)
                {
                    if (!AllTextBoxesFilled(ctrl)) // Recursively check child controls
                    {
                        return false;
                    }
                }
            }
            return true; // All textboxes are filled
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            bool allTextBoxesFilled = AllTextBoxesFilled(this);
            if (!allTextBoxesFilled)
            {
                MessageBox.Show("Please Fill all fields", "Message");
                return;
            }

            Regex sPhone = new Regex(@"(09|\+639)[-.\s]?[0-9]{9}");

            if (reg_Pass.Text != reg_ConPass.Text)
            {
                MessageBox.Show("Password doesn't match! Try again.", "Message");
                return;
            }
            var existingPassCountResult = db.check_username_exists(reg_Uname.Text).SingleOrDefault();
            if (existingPassCountResult != null)
            {
                if (existingPassCountResult.MatchingCount > 0)
                {
                    MessageBox.Show($"Username already exists!");
                    return;
                }
            }
            var matchingCountClass = db.check_USER_exists(reg_Uname.Text, reg_Pass.Text).Select(res => res.MatchingCount).FirstOrDefault();

            if (matchingCountClass.HasValue)
            {
                int matchingCountValue = matchingCountClass.Value;

                // Check if matchingCountValue is greater than zero
                if (matchingCountValue > 0)
                {
                    MessageBox.Show("Username or password already exists!");
                }
                else
                {
                    bool hasImage = PictureBoxHasImage(pbCapture);
                    if (hasImage)
                    {
                        fc.Save_IMAGE(reg_Uname.Text.ToUpper());
                        fc.Close();
                    }
                    else
                    {
                        MessageBox.Show("Open the camera first", "Message");
                    }
                    db.add_user(reg_Uname.Text, reg_Fname.Text, reg_Lname.Text, reg_Pass.Text, reg_Contact.Text);
                    MessageBox.Show("Successfully Recorded", "Message");
                }
            }

            this.Close();
            // Open a new instance of the login form
            login Loguser = new login();
            Loguser.Show();
        }
        private bool PictureBoxHasImage(PictureBox pictureBox)
        {
            return pictureBox.Image != null;
        }
        private void showP_Click(object sender, EventArgs e)
        {
            reg_Pass.UseSystemPasswordChar = !reg_Pass.UseSystemPasswordChar;
        }

        private void conP_Click(object sender, EventArgs e)
        {
            reg_ConPass.UseSystemPasswordChar = !reg_ConPass.UseSystemPasswordChar;
        }

    }
}
