
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
            this.detectcambtn = new ENROLLMENT_System.TRControls.TRButtons();
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
            // detectcambtn
            // 
            this.detectcambtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.detectcambtn.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.detectcambtn.BorderColor = System.Drawing.Color.Black;
            this.detectcambtn.BorderRadius = 20;
            this.detectcambtn.BorderSize = 1;
            this.detectcambtn.FlatAppearance.BorderSize = 0;
            this.detectcambtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detectcambtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectcambtn.ForeColor = System.Drawing.Color.Black;
            this.detectcambtn.Location = new System.Drawing.Point(245, 362);
            this.detectcambtn.Name = "detectcambtn";
            this.detectcambtn.Size = new System.Drawing.Size(185, 43);
            this.detectcambtn.TabIndex = 33;
            this.detectcambtn.Text = "Detect";
            this.detectcambtn.TextColor = System.Drawing.Color.Black;
            this.detectcambtn.UseVisualStyleBackColor = false;
            this.detectcambtn.Click += new System.EventHandler(this.detectcambtn_Click);
            // 
            // FaceDetect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 494);
            this.Controls.Add(this.detectcambtn);
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
        private TRControls.TRButtons detectcambtn;
    }
}