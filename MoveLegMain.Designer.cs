
namespace MoveLegRef
{
    partial class MoveLegMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveLegMain));
            this.pbSplashScreen = new System.Windows.Forms.PictureBox();
            this.pbLoadSplashScreen = new System.Windows.Forms.ProgressBar();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbSplashScreen)).BeginInit();
            this.pnlMainContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSplashScreen
            // 
            this.pbSplashScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSplashScreen.Image = global::MoveLegRef.Resources.Imagenes.LogoMoveLeg.Logo_MoveLeg;
            this.pbSplashScreen.Location = new System.Drawing.Point(0, 0);
            this.pbSplashScreen.Name = "pbSplashScreen";
            this.pbSplashScreen.Size = new System.Drawing.Size(877, 498);
            this.pbSplashScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSplashScreen.TabIndex = 0;
            this.pbSplashScreen.TabStop = false;
            this.pbSplashScreen.UseWaitCursor = true;
            // 
            // pbLoadSplashScreen
            // 
            this.pbLoadSplashScreen.Location = new System.Drawing.Point(304, 416);
            this.pbLoadSplashScreen.MarqueeAnimationSpeed = 3;
            this.pbLoadSplashScreen.Name = "pbLoadSplashScreen";
            this.pbLoadSplashScreen.Size = new System.Drawing.Size(268, 23);
            this.pbLoadSplashScreen.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbLoadSplashScreen.TabIndex = 1;
            this.pbLoadSplashScreen.UseWaitCursor = true;
            this.pbLoadSplashScreen.Value = 50;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.pbLoadSplashScreen);
            this.pnlMainContent.Controls.Add(this.pbSplashScreen);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(877, 498);
            this.pnlMainContent.TabIndex = 2;
            this.pnlMainContent.UseWaitCursor = true;
            // 
            // MoveLegMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(877, 498);
            this.Controls.Add(this.pnlMainContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MoveLegMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoveLeg";
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.MoveLegMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSplashScreen)).EndInit();
            this.pnlMainContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSplashScreen;
        private System.Windows.Forms.ProgressBar pbLoadSplashScreen;
        private System.Windows.Forms.Panel pnlMainContent;
    }
}

