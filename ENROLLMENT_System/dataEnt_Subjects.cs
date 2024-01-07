using System;
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
    public partial class dataEnt_Subjects : Form
    {
        DataClassEnrollmentDataContext db = new DataClassEnrollmentDataContext();
        int id;
        public dataEnt_Subjects()
        {
            InitializeComponent();
            displaySubj();

            Subjupdate.Hide();
        }
        private void displaySubj()
        {
            subject_GridView.DataSource = db.display_subj();
        }

        private void clear()
        {
            subjcode.Text = "";
            subjDescrip.Text = "";
            SubSem.SelectedIndex = -1;
            SubjUnits.Text = "";
        }

        private void Subjsave_Click(object sender, EventArgs e)
        {
            string selectedsem = SubSem.SelectedItem?.ToString(); // Use ToString() to convert object to string

            bool issubMISempty = string.IsNullOrWhiteSpace(subjcode.Text);
            bool issubDescripempty = string.IsNullOrWhiteSpace(subjDescrip.Text);
            bool issubSemEmpty = string.IsNullOrWhiteSpace(selectedsem);
            bool issubUnitsempty = string.IsNullOrWhiteSpace(SubjUnits.Text);


            try
            {
                if (issubMISempty || issubDescripempty || issubSemEmpty || issubUnitsempty)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error");
                }
                else
                {
                    string sem = SubSem.SelectedItem.ToString();
                    var existingSubjectCountResult = db.check_subj_exists(subjcode.Text, sem).SingleOrDefault();

                    if (existingSubjectCountResult != null)
                    {
                        if (existingSubjectCountResult.MatchingCount > 0)
                        {
                            MessageBox.Show($"Subject already exists!");
                        }
                        else
                        {

                            db.add_subj(subjcode.Text, subjDescrip.Text, sem, SubjUnits.Text);
                            MessageBox.Show("Successfully Recorded", "Message");
                            clear();
                            displaySubj();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error retrieving existing student count.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }

        private void Subjupdate_Click(object sender, EventArgs e)
        {
            string sem = SubSem.SelectedItem.ToString();

            bool issubMISempty = string.IsNullOrWhiteSpace(subjcode.Text);
            bool issubDescripempty = string.IsNullOrWhiteSpace(subjDescrip.Text);
            bool issubSemEmpty = string.IsNullOrWhiteSpace(SubSem.Text);
            bool issubUnitsempty = string.IsNullOrWhiteSpace(SubjUnits.Text);

            try
            {
                if (issubMISempty || issubDescripempty || issubSemEmpty || issubUnitsempty)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error");
                }
                else
                {
                    db.update_subj(id, subjcode.Text, subjDescrip.Text, sem, SubjUnits.Text);
                    MessageBox.Show("Successfully Updated", "Message");
                    clear();
                    displaySubj();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }

        private void searchsub_TextChanged(object sender, EventArgs e)
        {
            bool isSearchEmpty = string.IsNullOrEmpty(searchsub.Text);
            if (isSearchEmpty)
            {
                MessageBox.Show("Please input a value to search");
                displaySubj();
            }
            else
            {
                subject_GridView.DataSource = db.search_subj(searchsub.Text);
            }
        }

        private void subject_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (subject_GridView.Columns[e.ColumnIndex].Name == "Edit")
                {
                    Subjsave.Hide();
                    Subjupdate.Show();
                    id = int.Parse(subject_GridView.CurrentRow.Cells[2].Value.ToString());
                    subjcode.Text = subject_GridView.CurrentRow.Cells[3].Value.ToString();
                    subjDescrip.Text = subject_GridView.CurrentRow.Cells[4].Value.ToString();
                    SubSem.SelectedItem = subject_GridView.CurrentRow.Cells[5].Value.ToString();
                    SubjUnits.Text = subject_GridView.CurrentRow.Cells[6].Value.ToString();
                }
                else if (subject_GridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("Are you sure you want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        id = int.Parse(subject_GridView.CurrentRow.Cells[2].Value.ToString());
                        db.delete_subj(id);
                        clear();
                        MessageBox.Show("Successfully Deleted", "Message");
                        subject_GridView.DataSource = db.display_subj();
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
