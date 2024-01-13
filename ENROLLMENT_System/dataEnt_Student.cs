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
    public partial class dataEnt_Student : Form
    {
        DataClassEnrollmentDataContext db = new DataClassEnrollmentDataContext();
        int id;
        public dataEnt_Student()
        {
            InitializeComponent();
            LoadProgramname();
            studpanel.Hide();
            display_Stud();
            Updatebtn.Hide();
        }
        private void LoadProgramname()
        {
            try
            {
                var programNames = db.display_progname().Select(result => result.ProgramName).ToList();

                programNames.Insert(0, " ");

                Program_Stud.DataSource = programNames;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading program names: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addStud_Click(object sender, EventArgs e)
        {
            studpanel.Show();
            try
            {
                data_AddStudent dataentstudent = new data_AddStudent();
                dataentstudent.FormClosed += data_AddStudent_FormClosed;
                dataentstudent.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }
        private void display_Stud()
        {
            student_GridView.DataSource = db.display_student();
        }
        private void data_AddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            student_GridView.DataSource = null; 
            student_GridView.Rows.Clear(); 
            student_GridView.Refresh(); 

            student_GridView.DataSource = db.display_student();
        }

        private void student_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            studpanel.Show();
            try
            {
                if (student_GridView.Columns[e.ColumnIndex].Name == "Edit")
                {
                    Updatebtn.Show();
                    setProgname();
                    int rowIndex = e.RowIndex; 

                    RetrieveDataByIndex(rowIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void setProgname()
        {
            try
            {
                int studentId = int.Parse(student_GridView.CurrentRow.Cells[1].Value.ToString());

                int progId = GetProgIdForStudent(studentId);

                string programName = GetProgramName(progId);

                Program_Stud.SelectedItem = programName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetProgIdForStudent(int studentId)
        {
            if (studentId != 0)
            {
                int progId = int.Parse(student_GridView.CurrentRow.Cells[14].Value.ToString());
                if (progId != 0)
                {
                    return progId;
                }
            }
            return 0; 
        }


        private string GetProgramName(int progId)
        {
            try
            {
                using (var db = new DataClassEnrollmentDataContext())
                {
                    var result = db.select_progname(progId).SingleOrDefault();

                    if (result != null)
                    {
                        return result.ProgramName; 
                    }
                }
                return string.Empty; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting program name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        public void RetrieveDataByIndex(int rowIndex)
        {
            try
            {
                var result = db.display_student().ToList();

                if (result.Count > rowIndex)
                {
                    var row = result[rowIndex];

                    id = row.Stud_id;
                    Fname_Stud.Text = row.Stud_Fname;
                    Lname_Stud.Text = row.Stud_Lname;
                    Mname_Stud.Text = row.Stud_Mname;
                    Phone_Stud.Text = row.Stud_Contact;
                    Email_Stud.Text = row.Stud_Email;
                    DateTime bdate = row.Stud_Bdate;
                    bDate_Stud.Value = bdate;
                    Address_Stud.Text = row.Stud_Addr;
                    Guardian_Stud.Text = row.Stud_Guardian;
                    Guardian_num.Text = row.Stud_Guardian_no;


                    string StuStatus = row.Stud_Status;
                    string StuYear = row.Stud_year;
                    string StuGender = row.Stud_Gender;
                    int StuProgram = (int)row.Prog_id;

                    int statusIndex = FindComboBoxIndexByValue(Status_Stud, StuStatus);
                    int statusYIndex = FindComboBoxIndexByValue(Year_Stud, StuYear);
                    int statusGenderIndex = FindComboBoxIndexByValue(Gender_stud, StuGender);


                    if (statusIndex != -1)
                    {
                        Status_Stud.SelectedIndex = statusIndex;
                    }
                    if (statusYIndex != -1)
                    {
                        Year_Stud.SelectedIndex = statusYIndex;
                    }
                    if (statusGenderIndex != -1)
                    {
                        Gender_stud.SelectedIndex = statusGenderIndex;
                    }
                }
                else
                {
                    Console.WriteLine("Row index out of range");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        private int FindComboBoxIndexByValue(ComboBox comboBox, string value)
        {
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                if (comboBox.Items[i].ToString() == value)
                {
                    return i;
                }
            }
            return -1; 
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
        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string studStatus = Status_Stud.SelectedItem.ToString();
            string studYear = Year_Stud.SelectedItem.ToString();
            DateTime bdate = bDate_Stud.Value.Date;
            string Guardianame = Guardian_Stud.Text;
            string progname = Program_Stud.SelectedValue.ToString();

            bool allTextBoxesFilled = AllInputControlsFilled(this);

            Regex sEmail = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w+$", RegexOptions.IgnoreCase);
            Regex sPhone = new Regex(@"(09|\+639)[-.\s]?[0-9]{9}");

            try
            {
                if (!sPhone.IsMatch(Phone_Stud.Text) || !sPhone.IsMatch(Guardian_num.Text))
                {
                    MessageBox.Show("Invalid Input for phone: ", "ERROR");
                    return;
                }
                if (sEmail.IsMatch(Email_Stud.Text))
                {
                    MessageBox.Show("Invalid Input for email: " + Email_Stud.Text, "ERROR");
                }

                if (!allTextBoxesFilled)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error");
                }
                else
                {
                    try
                    {
                        string[] progNameParts = Program_Stud.SelectedValue.ToString().Trim().Split(' ');

                        string progStudname = progNameParts.ElementAtOrDefault(0) ?? string.Empty.Trim();
                        string progStudtype = progNameParts.ElementAtOrDefault(1) ?? string.Empty.Trim();
                        var resultid = db.select_progId(progStudname, progStudtype).SingleOrDefault();

                        if (resultid != null)
                        {
                            int? pId = resultid.Prog_id;

                            if (pId.HasValue)
                            {
                                int getprogid = pId.Value;
                                db.update_stud(id, Fname_Stud.Text, Lname_Stud.Text, Mname_Stud.Text, studStatus, studYear, Phone_Stud.Text, Email_Stud.Text, Gender_stud.Text, bdate, Address_Stud.Text, Guardianame, Guardian_num.Text, getprogid);
                                MessageBox.Show("Recorded Successfully", "SAVE");
                                updateClear();
                                display_Stud();
                                studpanel.Hide();
                            }
                            else
                            {
                                MessageBox.Show("No matching program found for " + progname, "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error: Result is null", "Error");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error has occurred: " + ex.Message, "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured" + ex.Message, "Error");
            }
        }
        private void updateClear()
        {
            Fname_Stud.Text = "";
            Lname_Stud.Text = "";
            Mname_Stud.Text = "";
            Phone_Stud.Text = "";
            Email_Stud.Text = "";
            bDate_Stud.Text = "";
            Address_Stud.Text = "";
            Guardian_Stud.Text = "";
            Guardian_num.Text = "";
            Status_Stud.SelectedIndex = -1;
            Year_Stud.SelectedIndex = -1;
            Gender_stud.SelectedIndex = -1;
            Program_Stud.SelectedIndex = -1;
        }

        private void searchstud_TextChanged(object sender, EventArgs e)
        {
            bool issearchEmpty = string.IsNullOrWhiteSpace(searchstud.Text);
            if (issearchEmpty)
            {
                MessageBox.Show("Please input a value to search");
            }
            else
            {
                student_GridView.DataSource = db.search_student(searchstud.Text);
            }
        }
    }
}
