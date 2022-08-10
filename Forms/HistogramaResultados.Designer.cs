
namespace MoveLegRef.Forms
{
    partial class HistogramaResultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistogramaResultados));
            this.gbContent = new System.Windows.Forms.GroupBox();
            this.pvHistograma = new OxyPlot.WindowsForms.PlotView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbContent
            // 
            this.gbContent.Controls.Add(this.pvHistograma);
            this.gbContent.Location = new System.Drawing.Point(12, 12);
            this.gbContent.Name = "gbContent";
            this.gbContent.Size = new System.Drawing.Size(776, 426);
            this.gbContent.TabIndex = 0;
            this.gbContent.TabStop = false;
            this.gbContent.Text = "Resultados";
            // 
            // pvHistograma
            // 
            this.pvHistograma.Location = new System.Drawing.Point(6, 22);
            this.pvHistograma.Name = "pvHistograma";
            this.pvHistograma.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.pvHistograma.Size = new System.Drawing.Size(764, 398);
            this.pvHistograma.TabIndex = 0;
            this.pvHistograma.Text = "HolaMundo";
            this.pvHistograma.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.pvHistograma.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pvHistograma.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(713, 444);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Ok";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // HistogramaResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HistogramaResultados";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histograma Resultados";
            this.gbContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContent;
        private OxyPlot.WindowsForms.PlotView pvHistograma;
        private System.Windows.Forms.Button btnSalir;
    }
}