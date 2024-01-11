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
    public partial class data_AddProffessor : Form
    {
        DataClassEnrollmentDataContext db = new DataClassEnrollmentDataContext();
        public data_AddProffessor()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
        }
        private void clear()
        {
            Fname.Text = "";
            Lname.Text = "";
            bdatebox.Text = "";
            genderbox.SelectedIndex = -1;
            Addressbox.Text = "";
            contactbox.Text = "";
            emailbox.Text = "";
        }
        private bool AllInputControlsFilled(Control control)
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
                else if (ctrl is ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex == -1)
                    {
                        return false;
                    }
                }
                else if (ctrl is DateTimePicker dateTimePicker)
                {
                    if (dateTimePicker.Value == DateTimePicker.MinimumDateTime)
                    {
                        return false;
                    }
                }
                else if (ctrl.HasChildren)
                {
                    if (!AllInputControlsFilled(ctrl))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            string lstname = Lname.Text;
            string fstname = Fname.Text;
            string mdname = Mname.Text;
            string gender = genderbox.SelectedItem?.ToString();
            string contact = contactbox.Text;
            string email = emailbox.Text;
            DateTime bDate = bdatebox.Value;
            DateTime dateOnly = bDate.Date;
            string Addr = Addressbox.Text;

            Regex regemail = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w+$", RegexOptions.IgnoreCase);
            Regex regphone = new Regex(@"(09|\+639)[-.\s]?[0-9]{9}");


            bool allTextBoxesFilled = AllInputControlsFilled(this);

            try
            {
                if (!allTextBoxesFilled)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error");
                }
                else
                {
                    if (regphone.IsMatch(contactbox.Text))
                    {
                        if (regemail.IsMatch(emailbox.Text))
                        {
                            var matchingCounts = new[]
                                    {
                                            db.check_Prof_exists(fstname, lstname, mdname).Select(res => res.MatchingCount).FirstOrDefault(),
                                            db.check_Prof_exists(lstname, fstname, mdname).Select(res => res.MatchingCount).FirstOrDefault(),
                                            db.check_Prof_exists(fstname, mdname, lstname).Select(res => res.MatchingCount).FirstOrDefault()
                                        };

                            //If any of the matching counts is greater than 0, professor exists
                            if (matchingCounts.Any(count => count > 0))
                            {
                                MessageBox.Show($"Instructor already exists!");
                            }
                            else
                            {
                                db.add_prof(fstname, lstname, mdname, contact, email, gender, dateOnly, Addr);
                                MessageBox.Show("Recorded Successfully", "SAVE");
                                clear();
                            }


                        }
                        else
                        {
                            MessageBox.Show("Invalid Input for email: " + emailbox.Text, "ERROR");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Input for phone: " + contactbox.Text, "ERROR");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }

        }

        private void bdatebox_ValueChanged(object sender, EventArgs e)
        {
            string pickedbDay = bdatebox.Text.Trim();

            try
            {
                if (string.IsNullOrEmpty(pickedbDay))
                {
                    MessageBox.Show("Please Choose a Date");
                }
                else
                {
                    DateTime selectedDate = bdatebox.Value;
                    DateTime today = DateTime.Today;

                    if (selectedDate > today)
                    {
                        MessageBox.Show("Please select a date not greater than today", "ERROR");
                        bdatebox.Value = today;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }
    }
}
