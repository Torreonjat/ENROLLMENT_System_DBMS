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

        private void Subjsave_Click(object sender, EventArgs e)
        {
            bool allTextBoxesFilled = AllInputControlsFilled(this);

            try
            {
                if (!allTextBoxesFilled)
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
                    id = int.Parse(subject_GridView.CurrentRow.Cells[1].Value.ToString());
                    subjcode.Text = subject_GridView.CurrentRow.Cells[2].Value.ToString();
                    subjDescrip.Text = subject_GridView.CurrentRow.Cells[3].Value.ToString();
                    SubSem.SelectedItem = subject_GridView.CurrentRow.Cells[4].Value.ToString();
                    SubjUnits.Text = subject_GridView.CurrentRow.Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }
    }
}
