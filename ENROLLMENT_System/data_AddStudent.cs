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
    public partial class data_AddStudent : Form
    {
        DataClassEnrollmentDataContext db = new DataClassEnrollmentDataContext();
        private string ProgramName { get; set; }
        private string ProgramType { get; set; }
        public data_AddStudent()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void data_AddStudent_Load(object sender, EventArgs e)
        {
            LoadProgramNames();
        }
        private void LoadProgramNames()
        {
            try
            {
                var programNames = db.display_progname()
                                      .Select(result => result.ProgramName)
                                      .ToList();

                // Add a default item at the top
                programNames.Insert(0, " ");

                // Assuming Stud_Prog is the name of your ComboBox control
                Stud_Prog.DataSource = programNames;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading program names: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_studentBtn_Click(object sender, EventArgs e)
        {
            string studStatus = Stud_Status.SelectedItem?.ToString();
            string studYear = Stud_year.SelectedItem?.ToString();
            DateTime? selectedDate = Stud_Bdate.Value == DateTime.MinValue ? (DateTime?)null : Stud_Bdate.Value;
            string Guardianame = Stud_Guardianfname.Text + " " + Stud_Guardianmname.Text + " " + Stud_Guardianlname.Text;
            string selectedgender = Stud_gender.SelectedItem?.ToString();


            bool isSLnameEmpty = string.IsNullOrWhiteSpace(Stud_lname.Text);
            bool isSFnameEmpty = string.IsNullOrWhiteSpace(Stud_Fname.Text);
            bool isSStatusEmpty = string.IsNullOrWhiteSpace(studStatus);
            bool isSYear = string.IsNullOrWhiteSpace(studYear);
            bool isSContactEmpty = string.IsNullOrWhiteSpace(Stud_Pnum.Text);
            bool isSEmailEmpty = string.IsNullOrWhiteSpace(Stud_email.Text);
            bool isSGenderEmpty = string.IsNullOrWhiteSpace(selectedgender);
            bool isSAddrEmpty = string.IsNullOrWhiteSpace(Stud_address.Text);
            bool isSGuardianameEmpty = string.IsNullOrWhiteSpace(Guardianame);
            bool isSGuardiannumtEmpty = string.IsNullOrWhiteSpace(Stud_GContact.Text);

            Regex sEmail = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w+$", RegexOptions.IgnoreCase);
            Regex sPhone = new Regex(@"(09|\+639)[-.\s]?[0-9]{9}");

            try
            {
                if (isSLnameEmpty || isSFnameEmpty || isSStatusEmpty || isSYear || isSContactEmpty || isSEmailEmpty || isSGenderEmpty || isSAddrEmpty || isSGuardianameEmpty || isSGuardiannumtEmpty)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error");
                }
                else
                {
                    if (sPhone.IsMatch(Stud_Pnum.Text) || sPhone.IsMatch(Stud_GContact.Text))
                    {
                        if (sEmail.IsMatch(Stud_email.Text))
                        {
                            if (selectedDate != DateTime.MinValue)
                            {
                                DateTime bdate = Stud_Bdate.Value.Date;
                                string[] progNameParts = Stud_Prog.SelectedValue.ToString().Trim().Split(' ');
                                // Debugging statement
                                string progStudname = progNameParts.ElementAtOrDefault(0) ?? string.Empty.Trim();
                                string progStudtype = progNameParts.ElementAtOrDefault(1) ?? string.Empty.Trim();
                                // Assuming your DataContext is named db

                                // Call the stored procedure and get the result
                                var result = db.select_progId(progStudname, progStudtype).SingleOrDefault();

                                if (result != null)
                                {
                                    int? pId = result.Prog_id;

                                    if (pId.HasValue)
                                    {
                                        // Call the check_Prof_exists method and retrieve MatchingCount directly
                                        var matchingCounts = new[]
                                        {
                                                db.check_Stud_exists(Stud_Fname.Text, Stud_lname.Text, Stud_mname.Text).Select(res => res.MatchingCount).FirstOrDefault(),
                                                db.check_Stud_exists(Stud_lname.Text, Stud_Fname.Text, Stud_mname.Text).Select(res => res.MatchingCount).FirstOrDefault(),
                                                db.check_Stud_exists(Stud_Fname.Text, Stud_mname.Text, Stud_lname.Text).Select(res => res.MatchingCount).FirstOrDefault()
                                            };

                                        // If any of the matching counts is greater than 0, professor exists
                                        if (matchingCounts.Any(count => count > 0))
                                        {
                                            MessageBox.Show($"Student exists. Matching Count: {matchingCounts.First(count => count > 0)}");
                                        }
                                        else
                                        {
                                            int getprogid = pId.Value;
                                            db.add_stud(Stud_Fname.Text, Stud_lname.Text, Stud_mname.Text, studStatus, studYear, Stud_Pnum.Text, Stud_email.Text, Stud_gender.Text, bdate, Stud_address.Text, Guardianame, Stud_GContact.Text, getprogid);
                                            MessageBox.Show("Recorded Successfully", "SAVE");
                                            clear();
                                        }
                                        // The result is not null, you can use pId
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error: Prog_id is null", "Error");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error: Result is null", "Error");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please select a Birthdate", "Error");
                            }


                        }
                        else
                        {
                            MessageBox.Show("Invalid Input for email: " + Stud_email.Text, "ERROR");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Input for phone: " + Stud_GContact.Text, "ERROR");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured" + ex.Message, "Error");
            }
        }
        private void clear()
        {
            Stud_Fname.Text = "";
            Stud_lname.Text = "";
            Stud_mname.Text = "";
            Stud_Status.Text = "";
            Stud_year.Text = "";
            Stud_Pnum.Text = "";
            Stud_email.Text = "";
            Stud_gender.Text = "";
            Stud_Bdate.Text = "";
            Stud_address.Text = "";
            Stud_Guardianfname.Text = "";
            Stud_Guardianlname.Text = "";
            Stud_Guardianmname.Text = "";
            Stud_GContact.Text = "";
        }

        private void Stud_Bdate_ValueChanged(object sender, EventArgs e)
        {
            string selectedProgram = Stud_Prog.SelectedItem.ToString();

            string[] parts = selectedProgram.Split(' ');
            if (parts.Length == 2)
            {
                ProgramName = parts[0];
                ProgramType = parts[1];
            }
            else
            {
                MessageBox.Show("No values found", "Error");
            }
        }
    }
}
