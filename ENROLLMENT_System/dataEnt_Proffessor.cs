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
            updatepanel.Hide();
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
            Prof_GridView.DataSource = null; 
            Prof_GridView.Rows.Clear(); 
            Prof_GridView.Refresh(); 

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
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
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
        private void Update_Click(object sender, EventArgs e)
        {

            DateTime bDate = prof_bdate.Value;
            DateTime dateOnly = bDate.Date;

            Regex regemail = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w+$", RegexOptions.IgnoreCase);
            Regex regphone = new Regex(@"(09|\+639)[-.\s]?[0-9]{9}");

            try
            {
                bool allTextBoxesFilled = AllInputControlsFilled(this);
                if (!regphone.IsMatch(profContact.Text))
                {
                    MessageBox.Show("Invalid Input for phone: " + profContact.Text, "ERROR");
                    return;
                }
                if (!regemail.IsMatch(profEmail.Text))
                {
                    MessageBox.Show("Invalid Input for email: " + profEmail.Text, "ERROR");
                    return;
                }


                if (!allTextBoxesFilled)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error");
                }
                else
                {
                    db.update_prof(id, profFname.Text, profLname.Text, ProfMname.Text, profContact.Text, profEmail.Text, prof_gender.Text, dateOnly, profAddress.Text);
                    MessageBox.Show("Updated Successfully", "SAVE");
                    clear();
                    display_prof();
                    updatepanel.Hide();    
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
                    updatepanel.Show();
                    Update.Show();
                    id = int.Parse(Prof_GridView.CurrentRow.Cells[1].Value.ToString());
                    profLname.Text = Prof_GridView.CurrentRow.Cells[2].Value.ToString();
                    profFname.Text = Prof_GridView.CurrentRow.Cells[3].Value.ToString();
                    ProfMname.Text = Prof_GridView.CurrentRow.Cells[4].Value.ToString();
                    profContact.Text = Prof_GridView.CurrentRow.Cells[5].Value.ToString();
                    profEmail.Text = Prof_GridView.CurrentRow.Cells[6].Value.ToString();
                    prof_bdate.Value = DateTime.Parse(Prof_GridView.CurrentRow.Cells[8].Value.ToString());
                    profAddress.Text = Prof_GridView.CurrentRow.Cells[9].Value.ToString();

                    string genderValue = Prof_GridView.CurrentRow.Cells[7].Value.ToString();

                    int genderIndex = prof_gender.FindStringExact(genderValue);

                    if (genderIndex != -1)
                    {
                        prof_gender.SelectedIndex = genderIndex;
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
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }
    }
}
