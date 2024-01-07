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
    public partial class Admin_dashboard : Form
    {
        DataClassEnrollmentDataContext db = new DataClassEnrollmentDataContext();

        public Admin_dashboard()
        {
            InitializeComponent();
        }

        private void Admin_dashboard_Load(object sender, EventArgs e)
        {
            display();
            totalnumStudents();
            totalEnrolled();
            totalproffessor();
            totalClasses();
        }
        private void display()
        {
            enrolled_Stud_view.DataSource = db.display_enrollee();
        }
        private void totalnumStudents()
        {
            try
            {
                var countStud = db.count_students().Single();

                lbTotalStud.Text = countStud.TotalStudents.ToString();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No students counted", "Message");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message, "Error");
            }
        }
        private void totalEnrolled()
        {
            try
            {
                var countEnrolled = db.count_enrollees().Single();

                lbTotEnrolled.Text = countEnrolled.TotalEnrolled.ToString();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No Enrolled Students counted", "Message");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message, "Error");
            }
        }
        private void totalproffessor()
        {
            try
            {
                var countProffessor = db.count_prof().Single();

                lbtotProf.Text = countProffessor.TotalTeachers.ToString();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No Teachers counted", "Message");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message, "Error");
            }
        }
        private void totalClasses()
        {
            try
            {
                var countClasses = db.count_class().Single();

                lbtotClass.Text = countClasses.TotalClass.ToString();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No Classes counted", "Message");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message, "Error");
            }
        }
    }
}
