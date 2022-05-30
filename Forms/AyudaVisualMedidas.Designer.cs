
namespace MoveLegRef.Forms
{
    partial class AyudaVisualMedidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AyudaVisualMedidas));
            this.pbMainContent = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainContent)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMainContent
            // 
            this.pbMainContent.Image = global::MoveLegRef.Resources.Imagenes.AyudasVisuales.Ayuda_visual_medidas;
            this.pbMainContent.Location = new System.Drawing.Point(12, 12);
            this.pbMainContent.Name = "pbMainContent";
            this.pbMainContent.Size = new System.Drawing.Size(467, 579);
            this.pbMainContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainContent.TabIndex = 0;
            this.pbMainContent.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(551, 567);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 24);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(485, 296);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(207, 54);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Ejemplo (medidas): Cadera - rodilla Medida de la longitud entre cadera y rodilla " +
    "en centimetros";
            // 
            // AyudaVisualMedidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 601);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pbMainContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AyudaVisualMedidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AyudaVisualMedidas";
            ((System.ComponentModel.ISupportInitialize)(this.pbMainContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainContent;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblInfo;
    }
}