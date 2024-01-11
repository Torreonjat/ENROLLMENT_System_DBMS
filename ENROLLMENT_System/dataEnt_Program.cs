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
    public partial class dataEnt_Program : Form
    {
        DataClassEnrollmentDataContext db = new DataClassEnrollmentDataContext();
        int id;
        public dataEnt_Program()
        {
            InitializeComponent();
        }

        private void dataEnt_Program_Load(object sender, EventArgs e)
        {
            Progupdate.Hide();
            display_program();
        }
        private void clear()
        {
            Prog_namebox.Text = "";
            Prog_descripbox.Text = "";
            prog_type.SelectedIndex = -1;
        }
        public void display_program()
        {
            Prog_GridView.DataSource = db.display_prog();
        }

        private void Progsave_Click(object sender, EventArgs e)
        {
            string Progname = Prog_namebox.Text;
            string Progdescrip = Prog_descripbox.Text;
            string Progtype = prog_type.SelectedItem?.ToString();


            bool allTextBoxesFilled = AllInputControlsFilled(this);

            try
            {
                if (!allTextBoxesFilled)
                {
                    MessageBox.Show("Please fill in all required fields. ", "Validation Error");
                }
                else
                {
                    var existingProgramCountResult = db.check_prog_exists(Progname, Progtype).SingleOrDefault();
                    // Check if the result is not null and access the MatchingCount property
                    if (existingProgramCountResult != null)
                    {
                        if (existingProgramCountResult.MatchingCount > 0)
                        {
                            MessageBox.Show($"Program already exists!");
                        }
                        else
                        {
                            db.add_program(Progname, Progdescrip, Progtype);
                            MessageBox.Show("Recorded Successfully!", "Message");
                            display_program();
                            clear();
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
                MessageBox.Show("An Error has occured :" + ex.Message, "Error");
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
        private void Progupdate_Click(object sender, EventArgs e)
        {
            string Progtype = prog_type.SelectedItem.ToString();
            
            bool allTextBoxesFilled = AllInputControlsFilled(this);

            try
            {
                if (!allTextBoxesFilled)
                {
                    MessageBox.Show("Please fill in all required fields. ", "Validation Error");
                }
                else
                {
                    db.update_prog(id, Prog_namebox.Text, Prog_descripbox.Text, Progtype);
                    MessageBox.Show("Updated Successfully", "Message");
                    display_program();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occured :" + ex.Message, "Error");
            }
        }

        private void Prog_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Prog_GridView.Columns[e.ColumnIndex].Name == "Edit")
                {
                    Progsave.Hide();
                    Progupdate.Show();
                    id = int.Parse(Prog_GridView.CurrentRow.Cells[1].Value.ToString());
                    Prog_namebox.Text = Prog_GridView.CurrentRow.Cells[2].Value.ToString();
                    Prog_descripbox.Text = Prog_GridView.CurrentRow.Cells[3].Value.ToString();
                    prog_type.SelectedItem = Prog_GridView.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has Occured : " + ex.Message, "Error");
            }
        }

        private void searchtb_TextChanged(object sender, EventArgs e)
        {
            bool isSearchEmpty = string.IsNullOrWhiteSpace(searchtb.Text);
            if (isSearchEmpty)
            {
                MessageBox.Show("Please input a value to search");
                display_program();
            }
            else
            {
                Prog_GridView.DataSource = db.search_prog(searchtb.Text);
            }
        }
    }
}
