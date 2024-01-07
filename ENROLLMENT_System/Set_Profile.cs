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
        FaceRec fc = new FaceRec();
        DataClassEnrollmentDataContext db = new DataClassEnrollmentDataContext();
        public Set_Profile()
        {
            InitializeComponent();
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

                
                int userId = userActive.CurrentUser.User.userid;
                
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
