namespace ClipIt
{
    partial class Window
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
            this.CaptureScreenButton = new System.Windows.Forms.Button();
            this.ScreenCapture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // CaptureScreenButton
            // 
            this.CaptureScreenButton.Location = new System.Drawing.Point(846, 682);
            this.CaptureScreenButton.Name = "CaptureScreenButton";
            this.CaptureScreenButton.Size = new System.Drawing.Size(200, 50);
            this.CaptureScreenButton.TabIndex = 0;
            this.CaptureScreenButton.Text = "Clip It!";
            this.CaptureScreenButton.UseVisualStyleBackColor = true;
            // 
            // ScreenCapture
            // 
            this.ScreenCapture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScreenCapture.Location = new System.Drawing.Point(12, 12);
            this.ScreenCapture.Name = "ScreenCapture";
            this.ScreenCapture.Size = new System.Drawing.Size(1034, 609);
            this.ScreenCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ScreenCapture.TabIndex = 1;
            this.ScreenCapture.TabStop = false;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 744);
            this.Controls.Add(this.ScreenCapture);
            this.Controls.Add(this.CaptureScreenButton);
            this.Name = "Window";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ScreenCapture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CaptureScreenButton;
        private System.Windows.Forms.PictureBox ScreenCapture;
    }
}

