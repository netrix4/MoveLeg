
namespace MoveLegRef.Forms
{
    partial class SeleccionMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionMenu));
            this.btnAgregarPaciente = new System.Windows.Forms.Button();
            this.btnNuevaSesion = new System.Windows.Forms.Button();
            this.btnSesion = new System.Windows.Forms.Button();
            this.btnListadoPacientes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarPaciente
            // 
            this.btnAgregarPaciente.Location = new System.Drawing.Point(167, 170);
            this.btnAgregarPaciente.Name = "btnAgregarPaciente";
            this.btnAgregarPaciente.Size = new System.Drawing.Size(117, 23);
            this.btnAgregarPaciente.TabIndex = 0;
            this.btnAgregarPaciente.Text = "Agregar Paciente";
            this.btnAgregarPaciente.UseVisualStyleBackColor = true;
            this.btnAgregarPaciente.Click += new System.EventHandler(this.btnAgregarPaciente_Click);
            // 
            // btnNuevaSesion
            // 
            this.btnNuevaSesion.Location = new System.Drawing.Point(167, 199);
            this.btnNuevaSesion.Name = "btnNuevaSesion";
            this.btnNuevaSesion.Size = new System.Drawing.Size(117, 23);
            this.btnNuevaSesion.TabIndex = 1;
            this.btnNuevaSesion.Text = "Generar Sesion";
            this.btnNuevaSesion.UseVisualStyleBackColor = true;
            this.btnNuevaSesion.Click += new System.EventHandler(this.btnNuevaSesion_Click);
            // 
            // btnSesion
            // 
            this.btnSesion.Location = new System.Drawing.Point(167, 228);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(117, 23);
            this.btnSesion.TabIndex = 2;
            this.btnSesion.Text = "Sesion";
            this.btnSesion.UseVisualStyleBackColor = true;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // btnListadoPacientes
            // 
            this.btnListadoPacientes.Location = new System.Drawing.Point(167, 257);
            this.btnListadoPacientes.Name = "btnListadoPacientes";
            this.btnListadoPacientes.Size = new System.Drawing.Size(117, 23);
            this.btnListadoPacientes.TabIndex = 3;
            this.btnListadoPacientes.Text = "Listado Pacientes";
            this.btnListadoPacientes.UseVisualStyleBackColor = true;
            this.btnListadoPacientes.Click += new System.EventHandler(this.btnListadoPacientes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(188, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // SeleccionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListadoPacientes);
            this.Controls.Add(this.btnSesion);
            this.Controls.Add(this.btnNuevaSesion);
            this.Controls.Add(this.btnAgregarPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SeleccionMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de Seleccion";
            this.Load += new System.EventHandler(this.SeleccionMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarPaciente;
        private System.Windows.Forms.Button btnNuevaSesion;
        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.Button btnListadoPacientes;
        private System.Windows.Forms.Button btnSalir;
    }
}