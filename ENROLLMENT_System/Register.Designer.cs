
namespace ENROLLMENT_System
{
    partial class Register
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reg_usertype = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.reg_Contact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.reg_ConPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reg_Pass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reg_Uname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reg_Lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reg_Fname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCapture = new System.Windows.Forms.PictureBox();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.btnSignup = new ENROLLMENT_System.TRControls.TRButtons();
            this.btncamera = new ENROLLMENT_System.TRControls.TRButtons();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(92, 579);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btncamera);
            this.panel1.Controls.Add(this.btnSignup);
            this.panel1.Controls.Add(this.reg_usertype);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.reg_Contact);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.reg_ConPass);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.reg_Pass);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.reg_Uname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.reg_Lname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.reg_Fname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pbCapture);
            this.panel1.Controls.Add(this.pbCamera);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(92, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 579);
            this.panel1.TabIndex = 2;
            // 
            // reg_usertype
            // 
            this.reg_usertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_usertype.FormattingEnabled = true;
            this.reg_usertype.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.reg_usertype.Location = new System.Drawing.Point(505, 102);
            this.reg_usertype.Name = "reg_usertype";
            this.reg_usertype.Size = new System.Drawing.Size(339, 28);
            this.reg_usertype.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(356, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Type of User";
            // 
            // reg_Contact
            // 
            this.reg_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_Contact.Location = new System.Drawing.Point(505, 424);
            this.reg_Contact.Multiline = true;
            this.reg_Contact.Name = "reg_Contact";
            this.reg_Contact.Size = new System.Drawing.Size(339, 34);
            this.reg_Contact.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(357, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Contact No.";
            // 
            // reg_ConPass
            // 
            this.reg_ConPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_ConPass.Location = new System.Drawing.Point(505, 372);
            this.reg_ConPass.Multiline = true;
            this.reg_ConPass.Name = "reg_ConPass";
            this.reg_ConPass.Size = new System.Drawing.Size(339, 34);
            this.reg_ConPass.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Confirm Password";
            // 
            // reg_Pass
            // 
            this.reg_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_Pass.Location = new System.Drawing.Point(505, 317);
            this.reg_Pass.Multiline = true;
            this.reg_Pass.Name = "reg_Pass";
            this.reg_Pass.Size = new System.Drawing.Size(339, 34);
            this.reg_Pass.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Password";
            // 
            // reg_Uname
            // 
            this.reg_Uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_Uname.Location = new System.Drawing.Point(505, 260);
            this.reg_Uname.Multiline = true;
            this.reg_Uname.Name = "reg_Uname";
            this.reg_Uname.Size = new System.Drawing.Size(339, 34);
            this.reg_Uname.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Username";
            // 
            // reg_Lname
            // 
            this.reg_Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_Lname.Location = new System.Drawing.Point(505, 206);
            this.reg_Lname.Multiline = true;
            this.reg_Lname.Name = "reg_Lname";
            this.reg_Lname.Size = new System.Drawing.Size(339, 34);
            this.reg_Lname.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Last Name";
            // 
            // reg_Fname
            // 
            this.reg_Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_Fname.Location = new System.Drawing.Point(505, 149);
            this.reg_Fname.Multiline = true;
            this.reg_Fname.Name = "reg_Fname";
            this.reg_Fname.Size = new System.Drawing.Size(339, 34);
            this.reg_Fname.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "First Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(907, 86);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 44);
            this.label1.TabIndex = 11;
            this.label1.Text = "REGISTER FORM";
            // 
            // pbCapture
            // 
            this.pbCapture.Location = new System.Drawing.Point(183, 204);
            this.pbCapture.Name = "pbCapture";
            this.pbCapture.Size = new System.Drawing.Size(131, 133);
            this.pbCapture.TabIndex = 1;
            this.pbCapture.TabStop = false;
            // 
            // pbCamera
            // 
            this.pbCamera.Location = new System.Drawing.Point(23, 107);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(291, 230);
            this.pbCamera.TabIndex = 0;
            this.pbCamera.TabStop = false;
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSignup.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSignup.BorderColor = System.Drawing.Color.Black;
            this.btnSignup.BorderRadius = 20;
            this.btnSignup.BorderSize = 1;
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(403, 485);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(441, 82);
            this.btnSignup.TabIndex = 49;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.TextColor = System.Drawing.Color.White;
            this.btnSignup.UseVisualStyleBackColor = false;
            // 
            // btncamera
            // 
            this.btncamera.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btncamera.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btncamera.BorderColor = System.Drawing.Color.Black;
            this.btncamera.BorderRadius = 20;
            this.btncamera.BorderSize = 1;
            this.btncamera.FlatAppearance.BorderSize = 0;
            this.btncamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncamera.ForeColor = System.Drawing.Color.White;
            this.btncamera.Location = new System.Drawing.Point(107, 366);
            this.btncamera.Name = "btncamera";
            this.btncamera.Size = new System.Drawing.Size(150, 49);
            this.btncamera.TabIndex = 50;
            this.btncamera.Text = "Camera";
            this.btncamera.TextColor = System.Drawing.Color.White;
            this.btncamera.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Press the button to open the camera\r\n";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(999, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Register";
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbCapture;
        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox reg_Contact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox reg_ConPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reg_Pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reg_Uname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox reg_Lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reg_Fname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox reg_usertype;
        private TRControls.TRButtons btnSignup;
        private System.Windows.Forms.Label label9;
        private TRControls.TRButtons btncamera;
    }
}