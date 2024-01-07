
namespace ENROLLMENT_System
{
    partial class FaceDetect
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
            this.label2 = new System.Windows.Forms.Label();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.btnDetect = new ENROLLMENT_System.TRControls.TRButtons();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "To verify that you are an admin, face recognition is required";
            // 
            // pbCamera
            // 
            this.pbCamera.Location = new System.Drawing.Point(185, 124);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(296, 207);
            this.pbCamera.TabIndex = 31;
            this.pbCamera.TabStop = false;
            // 
            // btnDetect
            // 
            this.btnDetect.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDetect.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.btnDetect.BorderColor = System.Drawing.Color.Black;
            this.btnDetect.BorderRadius = 20;
            this.btnDetect.BorderSize = 1;
            this.btnDetect.FlatAppearance.BorderSize = 0;
            this.btnDetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetect.Font = new System.Drawing.Font("Sitka Small Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetect.ForeColor = System.Drawing.Color.Black;
            this.btnDetect.Location = new System.Drawing.Point(245, 362);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(185, 43);
            this.btnDetect.TabIndex = 33;
            this.btnDetect.Text = "Detect";
            this.btnDetect.TextColor = System.Drawing.Color.Black;
            this.btnDetect.UseVisualStyleBackColor = false;
            // 
            // FaceDetect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 494);
            this.Controls.Add(this.btnDetect);
            this.Controls.Add(this.pbCamera);
            this.Controls.Add(this.label2);
            this.Name = "FaceDetect";
            this.Text = "FaceDetect";
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbCamera;
        private TRControls.TRButtons btnDetect;
    }
}