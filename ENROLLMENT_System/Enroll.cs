using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace ENROLLMENT_System
{
    public partial class Enroll : Form
    {
        DataClassEnrollmentDataContext db = new DataClassEnrollmentDataContext();
        private DateTime? selectedDate;
        private Label timeLabel;
        private Timer timer;
        private int id;
        public Enroll()
        {
            InitializeComponent();
            string Datenow = DateTime.Now.Date.ToString("D");

            lbdate.Text = Datenow;
            lbtime.Text = DateTime.Now.ToString("h:mm:ss tt");
            InitializeTimer();

            LoadClassCode();
            display();
            enrollpanel.Hide();

            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void InitializeTimer()
        {
            timeLabel = new Label();
            timeLabel.Dock = DockStyle.Fill;
            timeLabel.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
            timeLabel.TextAlign = ContentAlignment.MiddleCenter;

            Controls.Add(timeLabel);

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToString("h:mm:ss tt"); 
        }
        private void LoadClassCode()
        {
            try
            {
                var classNames = db.display_classname()
                                      .Select(result => new CLASS
                                      {
                                          Class_Code = result.Class_Code
                                      })
                                      .ToList();

                classNames.Insert(0, new CLASS { Class_Code = " " });

                ClassCodeEnroll.DataSource = classNames;
                ClassCodeEnroll.DisplayMember = "Class_Code";
                ClassCodeEnroll.ValueMember = "Class_Code";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Section names: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void submitbtn_Click(object sender, EventArgs e)
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
                    string sem = sem_enroll.SelectedItem.ToString();
                    string yr = yr_enroll.SelectedItem.ToString();
                    string Stud_ID = stud_enroll.Text;
                    string stat = "Pending";


                    if (!int.TryParse(Stud_ID, out int studIdInt))
                    {
                        MessageBox.Show("Can not convert into int", "Error");
                        return;
                    }
                    string classcode = ClassCodeEnroll.SelectedValue.ToString().Trim();
                    var classID = db.select_ClassId(classcode).SingleOrDefault();
                    if (classID == null)
                    {
                        MessageBox.Show("Error: No value for Class Found", "Error");
                        return;
                    }

                    var studID = db.select_stud_id(studIdInt).SingleOrDefault();

                    if (studID == null)
                    {
                        MessageBox.Show("Student not found", "Error");
                    }

                    int userId = userActive.CurrentUser.User.userid;
                    db.add_enroll(sem, DateTime.Now, stat, null, studID.Stud_id, userId, yr, classID.Class_id);
                    MessageBox.Show("Successfully Recorded", "Message");
                    clear();
                    display();
                    enrollpanel.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured" + ex.Message, "Error");
            }
        }
        private void clear()
        {
            sem_enroll.SelectedIndex = -1;
            stud_enroll.Text = " ";
            yr_enroll.SelectedIndex = -1;
            ClassCodeEnroll.SelectedIndex = -1;
            approvebtn.Checked = false;
            declinebtn.Checked = false;
        }

        private void display()
        {
            display_enrollees.DataSource = db.display_enrollee();
        }

        private void display_enrollees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (display_enrollees.Columns[e.ColumnIndex].Name == "Edit")
                {
                    enrollpanel.Show();
                    addEnrollees.Hide();
                    display_enrollees.Hide();
                    display_enrollees.Show();
                    display_enrollees.Show();
                    approvebtn.Show();
                    declinebtn.Show();
                    updatebtn.Show();
                    id = int.Parse(display_enrollees.CurrentRow.Cells[1].Value.ToString());
                    sem_enroll.SelectedItem = display_enrollees.CurrentRow.Cells[5].Value.ToString();
                    stud_enroll.Text = display_enrollees.CurrentRow.Cells[2].Value.ToString();
                    yr_enroll.SelectedItem = display_enrollees.CurrentRow.Cells[6].Value.ToString();
                    ClassCodeEnroll.SelectedItem = display_enrollees.CurrentRow.Cells[7].Value.ToString();
                    setClasscode();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has Occured : " + ex.Message, "Error");
            }
        }
        private void setClasscode()
        {
            try
            {
                int classId = int.Parse(display_enrollees.CurrentRow.Cells[7].Value.ToString());
                string classcode = GetClasscode(classId);

                if (!string.IsNullOrEmpty(classcode))
                {
                    foreach (CLASS item in ClassCodeEnroll.Items)
                    {
                        if (item.Class_Code == classcode)
                        {
                            ClassCodeEnroll.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error setting class code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private string GetClasscode(int classId)
        {
            try
            {
                using (var db = new DataClassEnrollmentDataContext())
                {
                    var result = db.select_classname(classId).SingleOrDefault();

                    // Ensure the result is not null before accessing properties
                    if (result != null)
                    {
                        return result.Class_code; // Access the ProgramName property
                    }
                }
                return string.Empty; // Return an empty string if no result is found
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting program name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private void addEnrollees_Click(object sender, EventArgs e)
        {
            updatebtn.Hide();
            label8.Hide();
            approvebtn.Hide();
            declinebtn.Hide();
            enrollpanel.Show();
        }

        private void updatebtn_Click(object sender, EventArgs e)
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
                    string sem = sem_enroll.SelectedItem.ToString();
                    string yr = yr_enroll.SelectedItem.ToString();
                    string Stud_ID = stud_enroll.Text;
                    string stat = "";

                    if (!approvebtn.Checked && !declinebtn.Checked)
                    {
                        MessageBox.Show("Please select one of the Status.", "Validation Error");
                    }
                    else
                    {
                        if (approvebtn.Checked)
                        {
                            stat = "Approve";
                        }
                        else
                        {
                            stat = "Decline";
                        }
                    }

                    // Convert Stud_ID to int
                    if (!int.TryParse(Stud_ID, out int studIdInt))
                    {
                        MessageBox.Show("Can not convert into int", "Error");
                        return;
                    }
                    string classcode = ClassCodeEnroll.SelectedValue.ToString().Trim();
                    var classID = db.select_ClassId(classcode).SingleOrDefault();
                    if (classID == null)
                    {
                        MessageBox.Show("Error: No value for Class Found", "Error");
                        return;
                    }

                    var studID = db.select_stud_id(studIdInt).SingleOrDefault();

                    if (studID == null)
                    {
                        MessageBox.Show("Student not found", "Error");
                    }

                    int userId = userActive.CurrentUser.User.userid;
                    id = int.Parse(display_enrollees.CurrentRow.Cells[1].Value.ToString());
                    // Get the previous date from the database
                    ISingleResult<getPreviousEnrollmentDateResult> result = db.getPreviousEnrollmentDate(id);

                    // Extract the first result from the ISingleResult
                    DateTime? previousDate = result.SingleOrDefault()?.Apply_date;

                    // Use the previous date if it exists, otherwise use the current date
                    DateTime enrollmentDate = previousDate ?? DateTime.Now;


                    // Update the record with the enrollmentDate
                    db.update_enroll_app(id, sem, enrollmentDate, stat, DateTime.Now, studID.Stud_id, userId, yr, classID.Class_id);

                    clear();
                    display();
                    enrollpanel.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured" + ex.Message, "Error");
            }
        }

        private void searchtb_TextChanged(object sender, EventArgs e)
        {
            bool issearchEmpty = string.IsNullOrWhiteSpace(searchtb.Text);
            if (issearchEmpty)
            {
                MessageBox.Show("Please input a value to search");
            }
            else
            {
                display_enrollees.DataSource = db.search_enroll(searchtb.Text);
            }
        }

    }
}
