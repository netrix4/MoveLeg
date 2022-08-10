
namespace MoveLegRef.Forms
{
    partial class CompararResultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompararResultados));
            this.gbGraficaResultados = new System.Windows.Forms.GroupBox();
            this.pvContenido = new OxyPlot.WindowsForms.PlotView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblSeleccPaciente = new System.Windows.Forms.Label();
            this.cbSeleccPaciente = new System.Windows.Forms.ComboBox();
            this.gbGraficaResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGraficaResultados
            // 
            this.gbGraficaResultados.Controls.Add(this.pvContenido);
            this.gbGraficaResultados.Location = new System.Drawing.Point(12, 50);
            this.gbGraficaResultados.Name = "gbGraficaResultados";
            this.gbGraficaResultados.Size = new System.Drawing.Size(920, 539);
            this.gbGraficaResultados.TabIndex = 0;
            this.gbGraficaResultados.TabStop = false;
            this.gbGraficaResultados.Text = "Grafica Comparativa Resultados";
            // 
            // pvContenido
            // 
            this.pvContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pvContenido.Location = new System.Drawing.Point(3, 19);
            this.pvContenido.Name = "pvContenido";
            this.pvContenido.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.pvContenido.Size = new System.Drawing.Size(914, 517);
            this.pvContenido.TabIndex = 0;
            this.pvContenido.Text = "plotView1";
            this.pvContenido.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.pvContenido.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pvContenido.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(840, 592);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblSeleccPaciente
            // 
            this.lblSeleccPaciente.Location = new System.Drawing.Point(12, 14);
            this.lblSeleccPaciente.Name = "lblSeleccPaciente";
            this.lblSeleccPaciente.Size = new System.Drawing.Size(150, 23);
            this.lblSeleccPaciente.TabIndex = 3;
            this.lblSeleccPaciente.Text = "Seleccione paciente:";
            this.lblSeleccPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSeleccPaciente
            // 
            this.cbSeleccPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeleccPaciente.FormattingEnabled = true;
            this.cbSeleccPaciente.Location = new System.Drawing.Point(168, 14);
            this.cbSeleccPaciente.Name = "cbSeleccPaciente";
            this.cbSeleccPaciente.Size = new System.Drawing.Size(203, 23);
            this.cbSeleccPaciente.TabIndex = 6;
            this.cbSeleccPaciente.SelectedIndexChanged += new System.EventHandler(this.cbSeleccPaciente_SelectedIndexChanged);
            // 
            // CompararResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 630);
            this.Controls.Add(this.cbSeleccPaciente);
            this.Controls.Add(this.lblSeleccPaciente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbGraficaResultados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CompararResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparar Resultados";
            this.Load += new System.EventHandler(this.CompararResultados_Load);
            this.gbGraficaResultados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGraficaResultados;
        private OxyPlot.WindowsForms.PlotView pvContenido;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblSeleccPaciente;
        private System.Windows.Forms.ComboBox cbSeleccPaciente;
    }
}