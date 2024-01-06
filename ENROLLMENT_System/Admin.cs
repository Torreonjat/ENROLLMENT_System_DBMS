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
    public partial class Admin : Form
    {
        bool dataentCollapsed;
        bool settingsCollapsed;
        public Admin()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Sizable;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;

            loadform(new Admin_dashboard());
        }
        private void ExpandCollapseContainer(Control container, Timer timer, ref bool isCollapsed)
        {
            if (isCollapsed)
            {
                container.Height += 10;
                if (container.Height >= container.MaximumSize.Height)
                {
                    isCollapsed = false;
                    timer.Stop();
                }
            }
            else
            {
                container.Height -= 10;
                if (container.Height <= container.MinimumSize.Height)
                {
                    isCollapsed = true;
                    timer.Stop();
                }
            }
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void dataEntryTimer_Tick_Tick(object sender, EventArgs e)
        {
            ExpandCollapseContainer(dataentryContainer, dataEntryTimer_Tick, ref dataentCollapsed);
        }

        private void btn_data_Click(object sender, EventArgs e)
        {
            dataEntryTimer_Tick.Start();
        }
        private void settingsTimer_Tick_Tick(object sender, EventArgs e)
        {
            ExpandCollapseContainer(settingscontainer, settingsTimer_Tick, ref settingsCollapsed);
        }
        private void btnsettings_Click(object sender, EventArgs e)
        {
            settingsTimer_Tick.Start();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            loadform(new Admin_dashboard());
        }

        private void btn_enroll_Click(object sender, EventArgs e)
        {
            loadform(new Enroll());
        }

        private void btnProgram_Click(object sender, EventArgs e)
        {
            loadform(new dataEnt_Program());
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            loadform(new dataEnt_Subjects());
        }

        private void btnSection_Click(object sender, EventArgs e)
        {
            loadform(new dataEnt_Section());
        }

        private void btnProffesor_Click(object sender, EventArgs e)
        {
            loadform(new dataEnt_Proffessor());
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            loadform(new dataEnt_Student());
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            loadform(new dataEnt_Class());
        }

        private void btnrecords_Click(object sender, EventArgs e)
        {
            loadform(new Records());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            loadform(new Set_Profile());
        }

        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            loadform(new Set_ChangePassword());
        }
    }
    

}
