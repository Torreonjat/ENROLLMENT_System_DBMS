using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ENROLLMENT_System
{
    public partial class Set_ChangePassword : Form
    {
        DataClassEnrollmentDataContext db = new DataClassEnrollmentDataContext();
        public Set_ChangePassword()
        {
            InitializeComponent();
            passpanel.Hide();
            
        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            var resContact = db.select_Contact(tbcontactNum.Text).SingleOrDefault();
            try
            {
                if (resContact != null)
                {
                    contactpanel.Hide();
                    passpanel.Show();
                }
                else
                {
                    MessageBox.Show("Error: Contact doesn't match to an account");
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Regex regpass = new Regex("^(?=.*[a-zA-Z])(?=.*\\d).{6,}$");
            try
            {
                var resultnum = db.select_Contact(tbcontactNum.Text).SingleOrDefault();
                if (resultnum != null)
                {


                    int ID = resultnum.U_id;
                    string currentPass = resultnum.U_pass;

                    string newPass = tbpass.Text;

                    if (!regpass.IsMatch(newPass))
                    {
                        MessageBox.Show("Invalid password. Password must consist of letters and numbers and have a minimum length of 6 characters.", "Message");
                        return;
                    }

                    if (newPass != tbconpass.Text)
                    {
                        MessageBox.Show("Password doesn't match! Try again.", "Message");
                        return;
                    }
                    // Update the currentPass variable to reflect the new password
                    currentPass = newPass;

                    // Optionally, update the UI with the new password
                    tbpass.Text = currentPass;

                    var existingPassCountResult = db.check_pass_exists(newPass).SingleOrDefault();
                    if (existingPassCountResult != null)
                    {
                        if (existingPassCountResult.MatchingCount > 0)
                        {
                            MessageBox.Show($"Password already exists!");
                        }
                        else
                        {
                            if (MessageBox.Show("Are you sure you want to change password?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                db.update_pass(ID, tbpass.Text);
                                MessageBox.Show("Password successfullly change!", "Message");
                                tbpass.Text = "";
                                tbconpass.Text = "";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error retrieving existing student count.");
                    }

                }
                else
                {
                    MessageBox.Show("Contact Number doesn't match! Please try again.", "Message");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
