
namespace MoveLegRef.Forms
{
    partial class AyudaVisualAngulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AyudaVisualAngulos));
            this.pbAngulosCuerpoCompleto = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAngulosCuerpoCompleto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAngulosCuerpoCompleto
            // 
            this.pbAngulosCuerpoCompleto.Image = global::MoveLegRef.Resources.Imagenes.AyudasVisuales.Ayuda_visual_angulos;
            this.pbAngulosCuerpoCompleto.InitialImage = null;
            this.pbAngulosCuerpoCompleto.Location = new System.Drawing.Point(12, 12);
            this.pbAngulosCuerpoCompleto.Name = "pbAngulosCuerpoCompleto";
            this.pbAngulosCuerpoCompleto.Size = new System.Drawing.Size(1064, 389);
            this.pbAngulosCuerpoCompleto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAngulosCuerpoCompleto.TabIndex = 0;
            this.pbAngulosCuerpoCompleto.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(511, 422);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(459, 404);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(170, 15);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Ejemplo de angulos solicitados";
            // 
            // AyudaVisualAngulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 457);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pbAngulosCuerpoCompleto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AyudaVisualAngulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AyudaVisualAngulos";
            ((System.ComponentModel.ISupportInitialize)(this.pbAngulosCuerpoCompleto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAngulosCuerpoCompleto;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblInfo;
    }
}