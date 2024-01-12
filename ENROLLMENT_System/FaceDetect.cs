using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;
using Emgu.CV;

namespace ENROLLMENT_System
{
    public partial class FaceDetect : Form
    {
        FaceRec fc;

        public FaceDetect()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;

            fc = new FaceRec();
            fc.openCamera(pbCamera, pbCamera);
            fc.isTrained = true;
        }

        private bool IsTrained()
        {
            if (fc != null)
            {
                // You might not need to set fc.isTrained here, as it's already set to true in the constructor.
                return true;
            }
            else
            {
                // Handle the case where fc is null
                return false;
            }
        }
        private void detectcambtn_Click(object sender, EventArgs e)
        {
            if (IsTrained())
            {
                fc.Dispose();
                this.Hide();
                // Display the Admin_form
                Admin log = new Admin();
                log.ShowDialog();
            }
            else
            {
                MessageBox.Show("No matching face found for login.");
            }
        }
    }
}
