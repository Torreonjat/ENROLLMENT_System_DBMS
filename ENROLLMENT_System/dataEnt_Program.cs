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

            bool isPrognameEmpty = string.IsNullOrWhiteSpace(Progname);
            bool isProgdescripEmpty = string.IsNullOrWhiteSpace(Progdescrip);
            bool isProgtypeEmpty = string.IsNullOrWhiteSpace(Progtype);

            try
            {
                if (isPrognameEmpty || isProgdescripEmpty || isProgtypeEmpty)
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

        private void Progupdate_Click(object sender, EventArgs e)
        {
            string Progtype = prog_type.SelectedItem.ToString();
            bool isProgEditnameEmpty = string.IsNullOrWhiteSpace(Prog_namebox.Text);
            bool isProgEditDescripEmpty = string.IsNullOrWhiteSpace(Prog_descripbox.Text);
            bool isProgtypeEmpty = string.IsNullOrWhiteSpace(Progtype);

            try
            {
                if (isProgEditnameEmpty || isProgEditDescripEmpty || isProgtypeEmpty)
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
                    id = int.Parse(Prog_GridView.CurrentRow.Cells[2].Value.ToString());
                    Prog_namebox.Text = Prog_GridView.CurrentRow.Cells[3].Value.ToString();
                    Prog_descripbox.Text = Prog_GridView.CurrentRow.Cells[4].Value.ToString();
                    prog_type.SelectedItem = Prog_GridView.CurrentRow.Cells[5].Value.ToString();
                }
                else if (Prog_GridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("Are you sure you want to delete this record? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        id = int.Parse(Prog_GridView.CurrentRow.Cells[0].Value.ToString());
                        db.delete_prog(id);
                        clear();
                        MessageBox.Show("Successfully Deleted", "Message");
                        Prog_GridView.DataSource = db.display_prog();
                    }
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
