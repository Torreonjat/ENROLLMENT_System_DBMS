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
    public partial class dataEnt_Section : Form
    {
        DataClassEnrollmentDataContext db = new DataClassEnrollmentDataContext();
        int id;
        public dataEnt_Section()
        {
            InitializeComponent();
            displaySect();

            Sectupdate.Hide();
        }
        private void displaySect()
        {
            section_GridView.DataSource = db.display_sect();
        }
        public void clear()
        {
            Sect_name.Text = "";
            sec_yr.SelectedIndex = -1;
            Sect_block.SelectedIndex = -1;
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

        private void Sectsave_Click(object sender, EventArgs e)
        {
            string Secname = Sect_name.Text;
            string Secyear = sec_yr.SelectedItem?.ToString();
            string Sectype = Sect_block.SelectedItem?.ToString();

            bool allTextBoxesFilled = AllInputControlsFilled(this);

            try
            {
                if (!allTextBoxesFilled)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error");
                }
                else
                {
                    var existingSectiontCountResult = db.check_Sect_exists(Secname, Secyear, Sectype).SingleOrDefault();

                    // Check if the result is not null and access the MatchingCount property
                    if (existingSectiontCountResult != null)
                    {
                        if (existingSectiontCountResult.MatchingCount > 0)
                        {
                            MessageBox.Show($"Instructor already exists!");
                        }
                        else
                        {
                            db.add_sect(Secname, Secyear, Sectype);
                            MessageBox.Show("Successfully Recorded", "Message");
                            clear();
                            displaySect();
                        }
                    }
                    else
                    {
                        // Handle the case where the result is null (optional, depending on your requirements)
                        MessageBox.Show("Error retrieving existing student count.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }

        private void Sectupdate_Click(object sender, EventArgs e)
        {
            string Secname = Sect_name.Text;
            string Secyear = sec_yr.SelectedItem.ToString();
            string Secblock = Sect_block.SelectedItem.ToString();

            bool allTextBoxesFilled = AllInputControlsFilled(this);

            try
            {
                if (!allTextBoxesFilled)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error");
                }
                else
                {
                    id = int.Parse(section_GridView.CurrentRow.Cells[0].Value.ToString());
                    db.update_sect(id, Secname, Secyear, Secblock);
                    MessageBox.Show("Successfully Updated", "Message");
                    clear();
                    displaySect();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }

        private void searchsect_TextChanged(object sender, EventArgs e)
        {
            bool isSearchEmpty = string.IsNullOrEmpty(searchsect.Text);
            if (isSearchEmpty)
            {
                MessageBox.Show("Please input a value to search");
                displaySect();
            }
            else
            {
                section_GridView.DataSource = db.search_sect(searchsect.Text);
            }
        }

        private void section_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (section_GridView.Columns[e.ColumnIndex].Name == "Edit")
                {
                    Sectsave.Hide();
                    Sectupdate.Show();
                    id = int.Parse(section_GridView.CurrentRow.Cells[1].Value.ToString());
                    Sect_name.Text = section_GridView.CurrentRow.Cells[2].Value.ToString();
                    sec_yr.SelectedItem = section_GridView.CurrentRow.Cells[3].Value.ToString();
                    Sect_block.SelectedItem = section_GridView.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }
    }
}
