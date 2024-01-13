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

namespace ENROLLMENT_System
{
    public partial class Set_Profile : Form
    {
        public int userId = userActive.CurrentUser.User.userid;
        FaceRec fc = new FaceRec();
        DataClassEnrollmentDataContext db = new DataClassEnrollmentDataContext();
        public Set_Profile()
        {
            InitializeComponent();
            userdetails();
        }

        private void btnCameraON_Click(object sender, EventArgs e)
        {
            fc.openCamera(pbCamera, pbCapture);
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
        private void userdetails()
        {
            var resUser = db.select_Userdetail(userId);

            foreach (var item in resUser)
            {
                tbUsername.Text = item.U_name;
                tbUFname.Text = item.U_Fname;
                tbULname.Text = item.U_Lname;
                tbContact.Text = item.U_Contact;
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            bool allTextBoxesFilled = AllTextBoxesFilled(this);
            if (allTextBoxesFilled)
            {
                bool hasImage = PictureBoxHasImage(pbCapture);
                if (hasImage)
                {
                    fc.Save_IMAGE(tbUsername.Text.ToUpper());
                    fc.Close();
                }
                else
                {
                    MessageBox.Show("Open the camera first", "Message");
                }

                
                if (MessageBox.Show("Are you sure all of the informations are correct?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.update_user(userId, tbUsername.Text, tbUFname.Text, tbULname.Text, tbContact.Text);
                    MessageBox.Show("Successfully Recorded", "Message");
                }
            }
            else
            {
                MessageBox.Show("Please Fill all fields", "Message");
            }
        }
        private bool PictureBoxHasImage(PictureBox pictureBox)
        {
            return pictureBox.Image != null;
        }
    }
}
