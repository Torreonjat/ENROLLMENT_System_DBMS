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
    public partial class dataEnt_Proffessor : Form
    {
        DataClassEnrollmentDataContext db = new DataClassEnrollmentDataContext();
        int id;
        public dataEnt_Proffessor()
        {
            InitializeComponent();
            display_prof();

            Update.Hide();
        }

        private void createNew_Click(object sender, EventArgs e)
        {
            try
            {
                data_AddProffessor addStudent = new data_AddProffessor();
                addStudent.FormClosed += data_AddProffessor_FormClosed;
                addStudent.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void data_AddProffessor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            Prof_GridView.DataSource = null; // Clear the existing data source
            Prof_GridView.Rows.Clear(); // Clear the existing rows
            Prof_GridView.Refresh(); // Refresh the DataGridView

            // Load the updated data from the database
            Prof_GridView.DataSource = db.display_prof();
        }
        private void display_prof()
        {
            Prof_GridView.DataSource = db.display_prof();
        }
        private void prof_searchbar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool isSearchEmpty = string.IsNullOrEmpty(prof_searchbar.Text);

                if (isSearchEmpty)
                {
                    MessageBox.Show("Please input a value to search");
                    display_prof();
                }
                else
                {
                    Prof_GridView.DataSource = db.search_prof(prof_searchbar.Text);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions that may occur during the search
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {

            DateTime bDate = prof_bdate.Value;
            DateTime dateOnly = bDate.Date;

            Regex regemail = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w+$", RegexOptions.IgnoreCase);
            Regex regphone = new Regex(@"(09|\+639)[-.\s]?[0-9]{9}");

            bool isFnameEmpty = string.IsNullOrWhiteSpace(profFname.Text);
            bool isLnameEmpty = string.IsNullOrWhiteSpace(profLname.Text);
            bool isGenderEmpty = string.IsNullOrWhiteSpace(prof_gender.Text);
            bool isAddressEmpty = string.IsNullOrWhiteSpace(profAddress.Text);
            bool isEmailEmpty = string.IsNullOrWhiteSpace(profEmail.Text);
            bool isContactEmpty = string.IsNullOrWhiteSpace(profContact.Text);

            try
            {
                if (isFnameEmpty || isLnameEmpty || isAddressEmpty || isEmailEmpty || isContactEmpty || isGenderEmpty)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error");
                }
                else
                {
                    if (regphone.IsMatch(profContact.Text))
                    {
                        if (regemail.IsMatch(profEmail.Text))
                        {
                            db.update_prof(id, profFname.Text, profLname.Text, ProfMname.Text, profContact.Text, profEmail.Text, prof_gender.Text, dateOnly, profAddress.Text);
                            MessageBox.Show("Updated Successfully", "SAVE");
                            clear();
                            display_prof();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Input for email: " + profEmail.Text, "ERROR");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Input for phone: " + profContact.Text, "ERROR");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }
        private void clear()
        {
            profLname.Text = "";
            profFname.Text = "";
            ProfMname.Text = "";
            prof_gender.Text = "";
            profContact.Text = "";
            profEmail.Text = "";
            prof_bdate.Text = "";
            profAddress.Text = "";
        }

        private void Prof_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Prof_GridView.Columns[e.ColumnIndex].Name == "Edit")
                {
                    Update.Show();
                    id = int.Parse(Prof_GridView.CurrentRow.Cells[2].Value.ToString());
                    profLname.Text = Prof_GridView.CurrentRow.Cells[3].Value.ToString();
                    profFname.Text = Prof_GridView.CurrentRow.Cells[4].Value.ToString();
                    ProfMname.Text = Prof_GridView.CurrentRow.Cells[5].Value.ToString();
                    profContact.Text = Prof_GridView.CurrentRow.Cells[6].Value.ToString();
                    profEmail.Text = Prof_GridView.CurrentRow.Cells[7].Value.ToString();
                    prof_bdate.Value = DateTime.Parse(Prof_GridView.CurrentRow.Cells[9].Value.ToString());
                    profAddress.Text = Prof_GridView.CurrentRow.Cells[10].Value.ToString();

                    string genderValue = Prof_GridView.CurrentRow.Cells[8].Value.ToString();

                    // Find the corresponding item in editGender ComboBox
                    int genderIndex = prof_gender.FindStringExact(genderValue);

                    // Set the selected item in the ComboBox based on the retrieved gender
                    if (genderIndex != -1)
                    {
                        prof_gender.SelectedIndex = genderIndex;
                    }
                }
                if (Prof_GridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("Are you sure you want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        id = int.Parse(Prof_GridView.CurrentRow.Cells[2].Value.ToString());
                        db.delete_prof(id);
                        MessageBox.Show("Successfully Deleted", "DELETE");
                        clear();
                        Prof_GridView.DataSource = db.display_prof();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }

        private void prof_searchbar_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                bool isSearchEmpty = string.IsNullOrEmpty(prof_searchbar.Text);

                if (isSearchEmpty)
                {
                    MessageBox.Show("Please input a value to search");
                    display_prof();
                }
                else
                {
                    Prof_GridView.DataSource = db.search_prof(prof_searchbar.Text);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions that may occur during the search
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }
    }
}
