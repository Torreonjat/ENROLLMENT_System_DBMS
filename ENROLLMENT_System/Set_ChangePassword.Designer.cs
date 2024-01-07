
namespace ENROLLMENT_System
{
    partial class Set_ChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.contactpanel = new System.Windows.Forms.Panel();
            this.proceedBtn = new ENROLLMENT_System.TRControls.TRButtons();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcontactNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passpanel = new System.Windows.Forms.Panel();
            this.Submit = new ENROLLMENT_System.TRControls.TRButtons();
            this.label6 = new System.Windows.Forms.Label();
            this.tbconpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.contactpanel.SuspendLayout();
            this.passpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 44);
            this.label1.TabIndex = 13;
            this.label1.Text = "CHANGE PASSWORD";
            // 
            // contactpanel
            // 
            this.contactpanel.Controls.Add(this.proceedBtn);
            this.contactpanel.Controls.Add(this.label2);
            this.contactpanel.Controls.Add(this.tbcontactNum);
            this.contactpanel.Controls.Add(this.label3);
            this.contactpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactpanel.Location = new System.Drawing.Point(0, 100);
            this.contactpanel.Name = "contactpanel";
            this.contactpanel.Size = new System.Drawing.Size(1353, 186);
            this.contactpanel.TabIndex = 1;
            // 
            // proceedBtn
            // 
            this.proceedBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.proceedBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.proceedBtn.BorderColor = System.Drawing.Color.Black;
            this.proceedBtn.BorderRadius = 20;
            this.proceedBtn.BorderSize = 1;
            this.proceedBtn.FlatAppearance.BorderSize = 0;
            this.proceedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proceedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedBtn.ForeColor = System.Drawing.Color.White;
            this.proceedBtn.Location = new System.Drawing.Point(622, 131);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.Size = new System.Drawing.Size(150, 49);
            this.proceedBtn.TabIndex = 55;
            this.proceedBtn.Text = "Proceed";
            this.proceedBtn.TextColor = System.Drawing.Color.White;
            this.proceedBtn.UseVisualStyleBackColor = false;
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "To verify User please input your Contact Number";
            // 
            // tbcontactNum
            // 
            this.tbcontactNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcontactNum.Location = new System.Drawing.Point(521, 77);
            this.tbcontactNum.Multiline = true;
            this.tbcontactNum.Name = "tbcontactNum";
            this.tbcontactNum.Size = new System.Drawing.Size(339, 34);
            this.tbcontactNum.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Contact Number";
            // 
            // passpanel
            // 
            this.passpanel.Controls.Add(this.Submit);
            this.passpanel.Controls.Add(this.label6);
            this.passpanel.Controls.Add(this.tbconpass);
            this.passpanel.Controls.Add(this.label5);
            this.passpanel.Controls.Add(this.tbpass);
            this.passpanel.Controls.Add(this.label4);
            this.passpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passpanel.Location = new System.Drawing.Point(0, 286);
            this.passpanel.Name = "passpanel";
            this.passpanel.Size = new System.Drawing.Size(1353, 451);
            this.passpanel.TabIndex = 2;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Submit.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Submit.BorderColor = System.Drawing.Color.Black;
            this.Submit.BorderRadius = 20;
            this.Submit.BorderSize = 1;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(622, 201);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(150, 49);
            this.Submit.TabIndex = 58;
            this.Submit.Text = "Submit";
            this.Submit.TextColor = System.Drawing.Color.White;
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(372, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Input your new password";
            // 
            // tbconpass
            // 
            this.tbconpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbconpass.Location = new System.Drawing.Point(521, 144);
            this.tbconpass.Multiline = true;
            this.tbconpass.Name = "tbconpass";
            this.tbconpass.Size = new System.Drawing.Size(339, 34);
            this.tbconpass.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Confirm Password";
            // 
            // tbpass
            // 
            this.tbpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpass.Location = new System.Drawing.Point(521, 74);
            this.tbpass.Multiline = true;
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(339, 34);
            this.tbpass.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Password";
            // 
            // Set_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1353, 737);
            this.Controls.Add(this.passpanel);
            this.Controls.Add(this.contactpanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Set_ChangePassword";
            this.Text = "Set_ChangePassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contactpanel.ResumeLayout(false);
            this.contactpanel.PerformLayout();
            this.passpanel.ResumeLayout(false);
            this.passpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contactpanel;
        private System.Windows.Forms.Panel passpanel;
        private System.Windows.Forms.TextBox tbcontactNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbconpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Label label4;
        private TRControls.TRButtons proceedBtn;
        private TRControls.TRButtons Submit;
    }
}