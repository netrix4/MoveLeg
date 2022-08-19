
namespace MoveLegRef.Forms
{
    partial class ConsultaPaciente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPaciente));
            this.dgvSesiones = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDetalleResultados = new System.Windows.Forms.Button();
            this.cbSeleccPaciente = new System.Windows.Forms.ComboBox();
            this.lblSelecPaciente = new System.Windows.Forms.Label();
            this.btnAyudaListado = new System.Windows.Forms.Button();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.lblTTSValor = new System.Windows.Forms.Label();
            this.lblRepLogRodVal = new System.Windows.Forms.Label();
            this.lblRepLogTobVal = new System.Windows.Forms.Label();
            this.lblRepLogTob = new System.Windows.Forms.Label();
            this.lblRepLogRod = new System.Windows.Forms.Label();
            this.lblTTS = new System.Windows.Forms.Label();
            this.btnResultados = new System.Windows.Forms.Button();
            this.btnGenerarPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesiones)).BeginInit();
            this.gbResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSesiones
            // 
            this.dgvSesiones.AllowUserToAddRows = false;
            this.dgvSesiones.AllowUserToDeleteRows = false;
            this.dgvSesiones.AllowUserToResizeColumns = false;
            this.dgvSesiones.AllowUserToResizeRows = false;
            this.dgvSesiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSesiones.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSesiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSesiones.Location = new System.Drawing.Point(12, 38);
            this.dgvSesiones.MultiSelect = false;
            this.dgvSesiones.Name = "dgvSesiones";
            this.dgvSesiones.ReadOnly = true;
            this.dgvSesiones.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSesiones.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSesiones.RowTemplate.Height = 25;
            this.dgvSesiones.RowTemplate.ReadOnly = true;
            this.dgvSesiones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSesiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSesiones.Size = new System.Drawing.Size(915, 342);
            this.dgvSesiones.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(432, 520);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDetalleResultados
            // 
            this.btnDetalleResultados.Location = new System.Drawing.Point(682, 42);
            this.btnDetalleResultados.Name = "btnDetalleResultados";
            this.btnDetalleResultados.Size = new System.Drawing.Size(94, 23);
            this.btnDetalleResultados.TabIndex = 4;
            this.btnDetalleResultados.Text = "Detalles";
            this.btnDetalleResultados.UseVisualStyleBackColor = true;
            this.btnDetalleResultados.Click += new System.EventHandler(this.btnDetalleResultados_Click);
            // 
            // cbSeleccPaciente
            // 
            this.cbSeleccPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeleccPaciente.FormattingEnabled = true;
            this.cbSeleccPaciente.Location = new System.Drawing.Point(140, 9);
            this.cbSeleccPaciente.Name = "cbSeleccPaciente";
            this.cbSeleccPaciente.Size = new System.Drawing.Size(203, 23);
            this.cbSeleccPaciente.TabIndex = 5;
            this.cbSeleccPaciente.SelectedIndexChanged += new System.EventHandler(this.cbSeleccPaciente_SelectedIndexChanged);
            // 
            // lblSelecPaciente
            // 
            this.lblSelecPaciente.Location = new System.Drawing.Point(12, 9);
            this.lblSelecPaciente.Name = "lblSelecPaciente";
            this.lblSelecPaciente.Size = new System.Drawing.Size(122, 23);
            this.lblSelecPaciente.TabIndex = 6;
            this.lblSelecPaciente.Text = "Nombre de paciente:";
            this.lblSelecPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAyudaListado
            // 
            this.btnAyudaListado.Location = new System.Drawing.Point(852, 9);
            this.btnAyudaListado.Name = "btnAyudaListado";
            this.btnAyudaListado.Size = new System.Drawing.Size(75, 23);
            this.btnAyudaListado.TabIndex = 7;
            this.btnAyudaListado.Text = "Ayuda";
            this.btnAyudaListado.UseVisualStyleBackColor = true;
            this.btnAyudaListado.Click += new System.EventHandler(this.btnAyudaListado_Click);
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.btnGenerarPDF);
            this.gbResultados.Controls.Add(this.lblTTSValor);
            this.gbResultados.Controls.Add(this.lblRepLogRodVal);
            this.gbResultados.Controls.Add(this.lblRepLogTobVal);
            this.gbResultados.Controls.Add(this.lblRepLogTob);
            this.gbResultados.Controls.Add(this.lblRepLogRod);
            this.gbResultados.Controls.Add(this.lblTTS);
            this.gbResultados.Controls.Add(this.btnDetalleResultados);
            this.gbResultados.Location = new System.Drawing.Point(12, 415);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(915, 99);
            this.gbResultados.TabIndex = 8;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // lblTTSValor
            // 
            this.lblTTSValor.Location = new System.Drawing.Point(318, 19);
            this.lblTTSValor.Name = "lblTTSValor";
            this.lblTTSValor.Size = new System.Drawing.Size(122, 23);
            this.lblTTSValor.TabIndex = 10;
            this.lblTTSValor.Text = "...";
            this.lblTTSValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRepLogRodVal
            // 
            this.lblRepLogRodVal.Location = new System.Drawing.Point(318, 42);
            this.lblRepLogRodVal.Name = "lblRepLogRodVal";
            this.lblRepLogRodVal.Size = new System.Drawing.Size(122, 23);
            this.lblRepLogRodVal.TabIndex = 9;
            this.lblRepLogRodVal.Text = "...";
            this.lblRepLogRodVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRepLogTobVal
            // 
            this.lblRepLogTobVal.Location = new System.Drawing.Point(318, 65);
            this.lblRepLogTobVal.Name = "lblRepLogTobVal";
            this.lblRepLogTobVal.Size = new System.Drawing.Size(122, 23);
            this.lblRepLogTobVal.TabIndex = 8;
            this.lblRepLogTobVal.Text = "...";
            this.lblRepLogTobVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRepLogTob
            // 
            this.lblRepLogTob.Location = new System.Drawing.Point(31, 65);
            this.lblRepLogTob.Name = "lblRepLogTob";
            this.lblRepLogTob.Size = new System.Drawing.Size(202, 23);
            this.lblRepLogTob.TabIndex = 7;
            this.lblRepLogTob.Text = "Repeticiones logrdas de tobillo";
            this.lblRepLogTob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRepLogRod
            // 
            this.lblRepLogRod.Location = new System.Drawing.Point(31, 42);
            this.lblRepLogRod.Name = "lblRepLogRod";
            this.lblRepLogRod.Size = new System.Drawing.Size(202, 23);
            this.lblRepLogRod.TabIndex = 6;
            this.lblRepLogRod.Text = "Repeticiones logradas de rodilla:";
            this.lblRepLogRod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTTS
            // 
            this.lblTTS.Location = new System.Drawing.Point(31, 19);
            this.lblTTS.Name = "lblTTS";
            this.lblTTS.Size = new System.Drawing.Size(202, 23);
            this.lblTTS.TabIndex = 5;
            this.lblTTS.Text = "Tiempo transcurrido de sesion:";
            this.lblTTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResultados
            // 
            this.btnResultados.Location = new System.Drawing.Point(432, 386);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(75, 23);
            this.btnResultados.TabIndex = 9;
            this.btnResultados.Text = "Resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.Location = new System.Drawing.Point(782, 42);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarPDF.TabIndex = 11;
            this.btnGenerarPDF.Text = "PDF";
            this.btnGenerarPDF.UseVisualStyleBackColor = true;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // ConsultaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(939, 552);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.btnAyudaListado);
            this.Controls.Add(this.cbSeleccPaciente);
            this.Controls.Add(this.lblSelecPaciente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvSesiones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultaPaciente";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Informacion";
            this.Load += new System.EventHandler(this.ConsultaPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesiones)).EndInit();
            this.gbResultados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSesiones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDetalleResultados;
        private System.Windows.Forms.ComboBox cbSeleccPaciente;
        private System.Windows.Forms.Label lblSelecPaciente;
        private System.Windows.Forms.Button btnAyudaListado;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.Label lblTTS;
        private System.Windows.Forms.Label lblTTSValor;
        private System.Windows.Forms.Label lblRepLogRodVal;
        private System.Windows.Forms.Label lblRepLogTobVal;
        private System.Windows.Forms.Label lblRepLogTob;
        private System.Windows.Forms.Label lblRepLogRod;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Button btnGenerarPDF;
    }
}