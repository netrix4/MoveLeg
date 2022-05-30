
namespace MoveLegRef.Forms
{
    partial class GenerarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarSesion));
            this.gbGenerarSesion = new System.Windows.Forms.GroupBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.cbSeleccPaciente = new System.Windows.Forms.ComboBox();
            this.lblSelecPaciente = new System.Windows.Forms.Label();
            this.gbPorcentajesDisminucion = new System.Windows.Forms.GroupBox();
            this.btnGenerarSesionEST = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValorPiernaAfectada = new System.Windows.Forms.Label();
            this.lblTituloPiernaAfectada = new System.Windows.Forms.Label();
            this.nudPorcDisDespRod = new System.Windows.Forms.NumericUpDown();
            this.nudPorcDisMovTob = new System.Windows.Forms.NumericUpDown();
            this.lblDespRod = new System.Windows.Forms.Label();
            this.lblMovTob = new System.Windows.Forms.Label();
            this.nudPorcDisVelRod = new System.Windows.Forms.NumericUpDown();
            this.lblVelRod = new System.Windows.Forms.Label();
            this.btnIniciarTerapia = new System.Windows.Forms.Button();
            this.nudPorcDisVelTob = new System.Windows.Forms.NumericUpDown();
            this.btnAyudaPorcDism = new System.Windows.Forms.Button();
            this.lblVelTobillo = new System.Windows.Forms.Label();
            this.gbDispositivoGuia = new System.Windows.Forms.GroupBox();
            this.btnAyudaDisGuia = new System.Windows.Forms.Button();
            this.lblRangoRodillaValor = new System.Windows.Forms.Label();
            this.lblRangoTobilloValor = new System.Windows.Forms.Label();
            this.lblRangoRodilla = new System.Windows.Forms.Label();
            this.lblRangoTobillo = new System.Windows.Forms.Label();
            this.lblRodEst = new System.Windows.Forms.Label();
            this.lblTobilloDorsVelValor = new System.Windows.Forms.Label();
            this.lblRodillaEstVelValor = new System.Windows.Forms.Label();
            this.lblTobDors = new System.Windows.Forms.Label();
            this.lblRodFlex = new System.Windows.Forms.Label();
            this.lblTobilloFlexVelValor = new System.Windows.Forms.Label();
            this.lblRodillaFlexVelValor = new System.Windows.Forms.Label();
            this.lblPlantarFlex = new System.Windows.Forms.Label();
            this.lblTitulolRodilla = new System.Windows.Forms.Label();
            this.lblTituloTobillo = new System.Windows.Forms.Label();
            this.lblPromVelTitulo = new System.Windows.Forms.Label();
            this.btnIniciarLectura = new System.Windows.Forms.Button();
            this.nudRepRodilla = new System.Windows.Forms.NumericUpDown();
            this.nudRepTobillo = new System.Windows.Forms.NumericUpDown();
            this.lblRepRodilla = new System.Windows.Forms.Label();
            this.lblRepTobillo = new System.Windows.Forms.Label();
            this.gbGenerarSesion.SuspendLayout();
            this.gbPorcentajesDisminucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcDisDespRod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcDisMovTob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcDisVelRod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcDisVelTob)).BeginInit();
            this.gbDispositivoGuia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepRodilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepTobillo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGenerarSesion
            // 
            this.gbGenerarSesion.Controls.Add(this.btnInicio);
            this.gbGenerarSesion.Controls.Add(this.cbSeleccPaciente);
            this.gbGenerarSesion.Controls.Add(this.lblSelecPaciente);
            this.gbGenerarSesion.Controls.Add(this.gbPorcentajesDisminucion);
            this.gbGenerarSesion.Controls.Add(this.gbDispositivoGuia);
            this.gbGenerarSesion.Location = new System.Drawing.Point(4, 4);
            this.gbGenerarSesion.Name = "gbGenerarSesion";
            this.gbGenerarSesion.Size = new System.Drawing.Size(698, 411);
            this.gbGenerarSesion.TabIndex = 0;
            this.gbGenerarSesion.TabStop = false;
            this.gbGenerarSesion.Text = "Generar Sesion";
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(612, 22);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // cbSeleccPaciente
            // 
            this.cbSeleccPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeleccPaciente.FormattingEnabled = true;
            this.cbSeleccPaciente.Location = new System.Drawing.Point(134, 22);
            this.cbSeleccPaciente.Name = "cbSeleccPaciente";
            this.cbSeleccPaciente.Size = new System.Drawing.Size(203, 23);
            this.cbSeleccPaciente.TabIndex = 0;
            this.cbSeleccPaciente.SelectedIndexChanged += new System.EventHandler(this.cbSeleccPaciente_SelectedIndexChanged);
            // 
            // lblSelecPaciente
            // 
            this.lblSelecPaciente.Location = new System.Drawing.Point(6, 22);
            this.lblSelecPaciente.Name = "lblSelecPaciente";
            this.lblSelecPaciente.Size = new System.Drawing.Size(122, 23);
            this.lblSelecPaciente.TabIndex = 2;
            this.lblSelecPaciente.Text = "Nombre de paciente:";
            this.lblSelecPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbPorcentajesDisminucion
            // 
            this.gbPorcentajesDisminucion.Controls.Add(this.btnGenerarSesionEST);
            this.gbPorcentajesDisminucion.Controls.Add(this.numericUpDown1);
            this.gbPorcentajesDisminucion.Controls.Add(this.label1);
            this.gbPorcentajesDisminucion.Controls.Add(this.lblValorPiernaAfectada);
            this.gbPorcentajesDisminucion.Controls.Add(this.lblTituloPiernaAfectada);
            this.gbPorcentajesDisminucion.Controls.Add(this.nudPorcDisDespRod);
            this.gbPorcentajesDisminucion.Controls.Add(this.nudPorcDisMovTob);
            this.gbPorcentajesDisminucion.Controls.Add(this.lblDespRod);
            this.gbPorcentajesDisminucion.Controls.Add(this.lblMovTob);
            this.gbPorcentajesDisminucion.Controls.Add(this.nudPorcDisVelRod);
            this.gbPorcentajesDisminucion.Controls.Add(this.lblVelRod);
            this.gbPorcentajesDisminucion.Controls.Add(this.btnIniciarTerapia);
            this.gbPorcentajesDisminucion.Controls.Add(this.nudPorcDisVelTob);
            this.gbPorcentajesDisminucion.Controls.Add(this.btnAyudaPorcDism);
            this.gbPorcentajesDisminucion.Controls.Add(this.lblVelTobillo);
            this.gbPorcentajesDisminucion.Location = new System.Drawing.Point(3, 268);
            this.gbPorcentajesDisminucion.Name = "gbPorcentajesDisminucion";
            this.gbPorcentajesDisminucion.Size = new System.Drawing.Size(690, 139);
            this.gbPorcentajesDisminucion.TabIndex = 1;
            this.gbPorcentajesDisminucion.TabStop = false;
            this.gbPorcentajesDisminucion.Text = "Porcentajes de Disminucion";
            // 
            // btnGenerarSesionEST
            // 
            this.btnGenerarSesionEST.Location = new System.Drawing.Point(489, 104);
            this.btnGenerarSesionEST.Name = "btnGenerarSesionEST";
            this.btnGenerarSesionEST.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarSesionEST.TabIndex = 32;
            this.btnGenerarSesionEST.Text = "SesionEst";
            this.btnGenerarSesionEST.UseVisualStyleBackColor = true;
            this.btnGenerarSesionEST.Click += new System.EventHandler(this.btnGenerarSesionEST_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(395, 64);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 23);
            this.numericUpDown1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(289, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Pierna Afectada: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValorPiernaAfectada
            // 
            this.lblValorPiernaAfectada.Location = new System.Drawing.Point(395, 19);
            this.lblValorPiernaAfectada.Name = "lblValorPiernaAfectada";
            this.lblValorPiernaAfectada.Size = new System.Drawing.Size(136, 23);
            this.lblValorPiernaAfectada.TabIndex = 30;
            this.lblValorPiernaAfectada.Text = "...";
            this.lblValorPiernaAfectada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloPiernaAfectada
            // 
            this.lblTituloPiernaAfectada.Location = new System.Drawing.Point(289, 19);
            this.lblTituloPiernaAfectada.Name = "lblTituloPiernaAfectada";
            this.lblTituloPiernaAfectada.Size = new System.Drawing.Size(100, 23);
            this.lblTituloPiernaAfectada.TabIndex = 29;
            this.lblTituloPiernaAfectada.Text = "Pierna Afectada: ";
            this.lblTituloPiernaAfectada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudPorcDisDespRod
            // 
            this.nudPorcDisDespRod.Location = new System.Drawing.Point(218, 106);
            this.nudPorcDisDespRod.Name = "nudPorcDisDespRod";
            this.nudPorcDisDespRod.Size = new System.Drawing.Size(50, 23);
            this.nudPorcDisDespRod.TabIndex = 28;
            // 
            // nudPorcDisMovTob
            // 
            this.nudPorcDisMovTob.Location = new System.Drawing.Point(218, 77);
            this.nudPorcDisMovTob.Name = "nudPorcDisMovTob";
            this.nudPorcDisMovTob.Size = new System.Drawing.Size(50, 23);
            this.nudPorcDisMovTob.TabIndex = 27;
            // 
            // lblDespRod
            // 
            this.lblDespRod.Location = new System.Drawing.Point(6, 106);
            this.lblDespRod.Name = "lblDespRod";
            this.lblDespRod.Size = new System.Drawing.Size(193, 23);
            this.lblDespRod.TabIndex = 26;
            this.lblDespRod.Text = "Para desplazamiento de rodilla (%)";
            this.lblDespRod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMovTob
            // 
            this.lblMovTob.Location = new System.Drawing.Point(6, 77);
            this.lblMovTob.Name = "lblMovTob";
            this.lblMovTob.Size = new System.Drawing.Size(193, 23);
            this.lblMovTob.TabIndex = 25;
            this.lblMovTob.Text = "Para movimiento de tobillo (%)";
            this.lblMovTob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudPorcDisVelRod
            // 
            this.nudPorcDisVelRod.Location = new System.Drawing.Point(218, 48);
            this.nudPorcDisVelRod.Name = "nudPorcDisVelRod";
            this.nudPorcDisVelRod.Size = new System.Drawing.Size(50, 23);
            this.nudPorcDisVelRod.TabIndex = 23;
            // 
            // lblVelRod
            // 
            this.lblVelRod.Location = new System.Drawing.Point(8, 48);
            this.lblVelRod.Name = "lblVelRod";
            this.lblVelRod.Size = new System.Drawing.Size(193, 23);
            this.lblVelRod.TabIndex = 24;
            this.lblVelRod.Text = "Para velocidad de rodilla (%)";
            this.lblVelRod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIniciarTerapia
            // 
            this.btnIniciarTerapia.Location = new System.Drawing.Point(609, 104);
            this.btnIniciarTerapia.Name = "btnIniciarTerapia";
            this.btnIniciarTerapia.Size = new System.Drawing.Size(75, 23);
            this.btnIniciarTerapia.TabIndex = 22;
            this.btnIniciarTerapia.Text = "Iniciar";
            this.btnIniciarTerapia.UseVisualStyleBackColor = true;
            this.btnIniciarTerapia.Click += new System.EventHandler(this.btnIniciarTerapia_Click);
            // 
            // nudPorcDisVelTob
            // 
            this.nudPorcDisVelTob.Location = new System.Drawing.Point(218, 19);
            this.nudPorcDisVelTob.Name = "nudPorcDisVelTob";
            this.nudPorcDisVelTob.Size = new System.Drawing.Size(50, 23);
            this.nudPorcDisVelTob.TabIndex = 7;
            // 
            // btnAyudaPorcDism
            // 
            this.btnAyudaPorcDism.Location = new System.Drawing.Point(609, 17);
            this.btnAyudaPorcDism.Name = "btnAyudaPorcDism";
            this.btnAyudaPorcDism.Size = new System.Drawing.Size(75, 23);
            this.btnAyudaPorcDism.TabIndex = 6;
            this.btnAyudaPorcDism.Text = "Ayuda";
            this.btnAyudaPorcDism.UseVisualStyleBackColor = true;
            this.btnAyudaPorcDism.Click += new System.EventHandler(this.btnAyudaPorcDism_Click);
            // 
            // lblVelTobillo
            // 
            this.lblVelTobillo.Location = new System.Drawing.Point(6, 19);
            this.lblVelTobillo.Name = "lblVelTobillo";
            this.lblVelTobillo.Size = new System.Drawing.Size(193, 23);
            this.lblVelTobillo.TabIndex = 17;
            this.lblVelTobillo.Text = "Para velocidad de tobillo (%)";
            this.lblVelTobillo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbDispositivoGuia
            // 
            this.gbDispositivoGuia.Controls.Add(this.btnAyudaDisGuia);
            this.gbDispositivoGuia.Controls.Add(this.lblRangoRodillaValor);
            this.gbDispositivoGuia.Controls.Add(this.lblRangoTobilloValor);
            this.gbDispositivoGuia.Controls.Add(this.lblRangoRodilla);
            this.gbDispositivoGuia.Controls.Add(this.lblRangoTobillo);
            this.gbDispositivoGuia.Controls.Add(this.lblRodEst);
            this.gbDispositivoGuia.Controls.Add(this.lblTobilloDorsVelValor);
            this.gbDispositivoGuia.Controls.Add(this.lblRodillaEstVelValor);
            this.gbDispositivoGuia.Controls.Add(this.lblTobDors);
            this.gbDispositivoGuia.Controls.Add(this.lblRodFlex);
            this.gbDispositivoGuia.Controls.Add(this.lblTobilloFlexVelValor);
            this.gbDispositivoGuia.Controls.Add(this.lblRodillaFlexVelValor);
            this.gbDispositivoGuia.Controls.Add(this.lblPlantarFlex);
            this.gbDispositivoGuia.Controls.Add(this.lblTitulolRodilla);
            this.gbDispositivoGuia.Controls.Add(this.lblTituloTobillo);
            this.gbDispositivoGuia.Controls.Add(this.lblPromVelTitulo);
            this.gbDispositivoGuia.Controls.Add(this.btnIniciarLectura);
            this.gbDispositivoGuia.Controls.Add(this.nudRepRodilla);
            this.gbDispositivoGuia.Controls.Add(this.nudRepTobillo);
            this.gbDispositivoGuia.Controls.Add(this.lblRepRodilla);
            this.gbDispositivoGuia.Controls.Add(this.lblRepTobillo);
            this.gbDispositivoGuia.Location = new System.Drawing.Point(3, 51);
            this.gbDispositivoGuia.Name = "gbDispositivoGuia";
            this.gbDispositivoGuia.Size = new System.Drawing.Size(690, 203);
            this.gbDispositivoGuia.TabIndex = 0;
            this.gbDispositivoGuia.TabStop = false;
            this.gbDispositivoGuia.Text = "Dispositivo Guia";
            // 
            // btnAyudaDisGuia
            // 
            this.btnAyudaDisGuia.Location = new System.Drawing.Point(612, 19);
            this.btnAyudaDisGuia.Name = "btnAyudaDisGuia";
            this.btnAyudaDisGuia.Size = new System.Drawing.Size(75, 23);
            this.btnAyudaDisGuia.TabIndex = 2;
            this.btnAyudaDisGuia.Text = "Ayuda";
            this.btnAyudaDisGuia.UseVisualStyleBackColor = true;
            this.btnAyudaDisGuia.Click += new System.EventHandler(this.btnAyudaDisGuia_Click);
            // 
            // lblRangoRodillaValor
            // 
            this.lblRangoRodillaValor.Location = new System.Drawing.Point(616, 134);
            this.lblRangoRodillaValor.Name = "lblRangoRodillaValor";
            this.lblRangoRodillaValor.Size = new System.Drawing.Size(65, 23);
            this.lblRangoRodillaValor.TabIndex = 19;
            this.lblRangoRodillaValor.Text = "...";
            this.lblRangoRodillaValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRangoTobilloValor
            // 
            this.lblRangoTobilloValor.Location = new System.Drawing.Point(616, 100);
            this.lblRangoTobilloValor.Name = "lblRangoTobilloValor";
            this.lblRangoTobilloValor.Size = new System.Drawing.Size(65, 23);
            this.lblRangoTobilloValor.TabIndex = 18;
            this.lblRangoTobilloValor.Text = "...";
            this.lblRangoTobilloValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRangoRodilla
            // 
            this.lblRangoRodilla.Location = new System.Drawing.Point(393, 134);
            this.lblRangoRodilla.Name = "lblRangoRodilla";
            this.lblRangoRodilla.Size = new System.Drawing.Size(220, 23);
            this.lblRangoRodilla.TabIndex = 17;
            this.lblRangoRodilla.Text = "Rango de dezplazamiento de rodilla:";
            this.lblRangoRodilla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRangoTobillo
            // 
            this.lblRangoTobillo.Location = new System.Drawing.Point(393, 100);
            this.lblRangoTobillo.Name = "lblRangoTobillo";
            this.lblRangoTobillo.Size = new System.Drawing.Size(220, 23);
            this.lblRangoTobillo.TabIndex = 16;
            this.lblRangoTobillo.Text = "Rango de dezplazamiento de tobillo:";
            this.lblRangoTobillo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRodEst
            // 
            this.lblRodEst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRodEst.Location = new System.Drawing.Point(203, 123);
            this.lblRodEst.Name = "lblRodEst";
            this.lblRodEst.Size = new System.Drawing.Size(98, 23);
            this.lblRodEst.TabIndex = 15;
            this.lblRodEst.Text = "Estiramiento";
            this.lblRodEst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTobilloDorsVelValor
            // 
            this.lblTobilloDorsVelValor.Location = new System.Drawing.Point(203, 100);
            this.lblTobilloDorsVelValor.Name = "lblTobilloDorsVelValor";
            this.lblTobilloDorsVelValor.Size = new System.Drawing.Size(98, 23);
            this.lblTobilloDorsVelValor.TabIndex = 14;
            this.lblTobilloDorsVelValor.Text = "...";
            this.lblTobilloDorsVelValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRodillaEstVelValor
            // 
            this.lblRodillaEstVelValor.Location = new System.Drawing.Point(203, 146);
            this.lblRodillaEstVelValor.Name = "lblRodillaEstVelValor";
            this.lblRodillaEstVelValor.Size = new System.Drawing.Size(98, 23);
            this.lblRodillaEstVelValor.TabIndex = 13;
            this.lblRodillaEstVelValor.Text = "...";
            this.lblRodillaEstVelValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTobDors
            // 
            this.lblTobDors.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTobDors.Location = new System.Drawing.Point(203, 71);
            this.lblTobDors.Name = "lblTobDors";
            this.lblTobDors.Size = new System.Drawing.Size(98, 23);
            this.lblTobDors.TabIndex = 12;
            this.lblTobDors.Text = "Dorsiflexion";
            this.lblTobDors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRodFlex
            // 
            this.lblRodFlex.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRodFlex.Location = new System.Drawing.Point(99, 123);
            this.lblRodFlex.Name = "lblRodFlex";
            this.lblRodFlex.Size = new System.Drawing.Size(98, 23);
            this.lblRodFlex.TabIndex = 11;
            this.lblRodFlex.Text = "Flexion";
            this.lblRodFlex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTobilloFlexVelValor
            // 
            this.lblTobilloFlexVelValor.Location = new System.Drawing.Point(99, 100);
            this.lblTobilloFlexVelValor.Name = "lblTobilloFlexVelValor";
            this.lblTobilloFlexVelValor.Size = new System.Drawing.Size(98, 23);
            this.lblTobilloFlexVelValor.TabIndex = 10;
            this.lblTobilloFlexVelValor.Text = "...";
            this.lblTobilloFlexVelValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRodillaFlexVelValor
            // 
            this.lblRodillaFlexVelValor.Location = new System.Drawing.Point(99, 146);
            this.lblRodillaFlexVelValor.Name = "lblRodillaFlexVelValor";
            this.lblRodillaFlexVelValor.Size = new System.Drawing.Size(98, 23);
            this.lblRodillaFlexVelValor.TabIndex = 9;
            this.lblRodillaFlexVelValor.Text = "...";
            this.lblRodillaFlexVelValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlantarFlex
            // 
            this.lblPlantarFlex.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlantarFlex.Location = new System.Drawing.Point(99, 71);
            this.lblPlantarFlex.Name = "lblPlantarFlex";
            this.lblPlantarFlex.Size = new System.Drawing.Size(98, 23);
            this.lblPlantarFlex.TabIndex = 8;
            this.lblPlantarFlex.Text = "Plantar Flexion";
            this.lblPlantarFlex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulolRodilla
            // 
            this.lblTitulolRodilla.Location = new System.Drawing.Point(11, 146);
            this.lblTitulolRodilla.Name = "lblTitulolRodilla";
            this.lblTitulolRodilla.Size = new System.Drawing.Size(82, 23);
            this.lblTitulolRodilla.TabIndex = 7;
            this.lblTitulolRodilla.Text = "Rodilla";
            this.lblTitulolRodilla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloTobillo
            // 
            this.lblTituloTobillo.Location = new System.Drawing.Point(11, 100);
            this.lblTituloTobillo.Name = "lblTituloTobillo";
            this.lblTituloTobillo.Size = new System.Drawing.Size(82, 23);
            this.lblTituloTobillo.TabIndex = 6;
            this.lblTituloTobillo.Text = "Tobillo";
            this.lblTituloTobillo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPromVelTitulo
            // 
            this.lblPromVelTitulo.AutoSize = true;
            this.lblPromVelTitulo.Location = new System.Drawing.Point(6, 56);
            this.lblPromVelTitulo.Name = "lblPromVelTitulo";
            this.lblPromVelTitulo.Size = new System.Drawing.Size(118, 15);
            this.lblPromVelTitulo.TabIndex = 5;
            this.lblPromVelTitulo.Text = "Promedios Velocidad";
            // 
            // btnIniciarLectura
            // 
            this.btnIniciarLectura.Location = new System.Drawing.Point(612, 174);
            this.btnIniciarLectura.Name = "btnIniciarLectura";
            this.btnIniciarLectura.Size = new System.Drawing.Size(75, 23);
            this.btnIniciarLectura.TabIndex = 5;
            this.btnIniciarLectura.Text = "Iniciar";
            this.btnIniciarLectura.UseVisualStyleBackColor = true;
            // 
            // nudRepRodilla
            // 
            this.nudRepRodilla.Location = new System.Drawing.Point(489, 19);
            this.nudRepRodilla.Name = "nudRepRodilla";
            this.nudRepRodilla.Size = new System.Drawing.Size(83, 23);
            this.nudRepRodilla.TabIndex = 4;
            // 
            // nudRepTobillo
            // 
            this.nudRepTobillo.Location = new System.Drawing.Point(203, 19);
            this.nudRepTobillo.Name = "nudRepTobillo";
            this.nudRepTobillo.Size = new System.Drawing.Size(83, 23);
            this.nudRepTobillo.TabIndex = 3;
            // 
            // lblRepRodilla
            // 
            this.lblRepRodilla.Location = new System.Drawing.Point(292, 19);
            this.lblRepRodilla.Name = "lblRepRodilla";
            this.lblRepRodilla.Size = new System.Drawing.Size(191, 23);
            this.lblRepRodilla.TabIndex = 1;
            this.lblRepRodilla.Text = "Numero de repeticiones de rodilla:";
            this.lblRepRodilla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRepTobillo
            // 
            this.lblRepTobillo.Location = new System.Drawing.Point(6, 19);
            this.lblRepTobillo.Name = "lblRepTobillo";
            this.lblRepTobillo.Size = new System.Drawing.Size(191, 23);
            this.lblRepTobillo.TabIndex = 0;
            this.lblRepTobillo.Text = "Numero de repeticiones de tobillo: ";
            this.lblRepTobillo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenerarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 419);
            this.Controls.Add(this.gbGenerarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GenerarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Sesion";
            this.Load += new System.EventHandler(this.GenerarSesion_Load);
            this.gbGenerarSesion.ResumeLayout(false);
            this.gbPorcentajesDisminucion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcDisDespRod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcDisMovTob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcDisVelRod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcDisVelTob)).EndInit();
            this.gbDispositivoGuia.ResumeLayout(false);
            this.gbDispositivoGuia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepRodilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepTobillo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGenerarSesion;
        private System.Windows.Forms.GroupBox gbPorcentajesDisminucion;
        private System.Windows.Forms.GroupBox gbDispositivoGuia;
        private System.Windows.Forms.Label lblSelecPaciente;
        private System.Windows.Forms.ComboBox cbSeleccPaciente;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lblRepRodilla;
        private System.Windows.Forms.Label lblRepTobillo;
        private System.Windows.Forms.NumericUpDown nudRepTobillo;
        private System.Windows.Forms.Label lblTobilloFlexVelValor;
        private System.Windows.Forms.Label lblRodillaFlexVelValor;
        private System.Windows.Forms.Label lblPlantarFlex;
        private System.Windows.Forms.Label lblTitulolRodilla;
        private System.Windows.Forms.Label lblTituloTobillo;
        private System.Windows.Forms.Label lblPromVelTitulo;
        private System.Windows.Forms.Button btnIniciarLectura;
        private System.Windows.Forms.NumericUpDown nudRepRodilla;
        private System.Windows.Forms.Label lblRodEst;
        private System.Windows.Forms.Label lblTobilloDorsVelValor;
        private System.Windows.Forms.Label lblRodillaEstVelValor;
        private System.Windows.Forms.Label lblTobDors;
        private System.Windows.Forms.Label lblRodFlex;
        private System.Windows.Forms.Label lblRangoRodillaValor;
        private System.Windows.Forms.Label lblRangoTobilloValor;
        private System.Windows.Forms.Label lblRangoRodilla;
        private System.Windows.Forms.Label lblRangoTobillo;
        private System.Windows.Forms.Button btnIniciarTerapia;
        private System.Windows.Forms.NumericUpDown nudPorcDisVelTob;
        private System.Windows.Forms.Button btnAyudaPorcDism;
        private System.Windows.Forms.Label lblVelTobillo;
        private System.Windows.Forms.Button btnAyudaDisGuia;
        private System.Windows.Forms.NumericUpDown nudPorcDisVelRod;
        private System.Windows.Forms.Label lblVelRod;
        private System.Windows.Forms.Label lblDespRod;
        private System.Windows.Forms.Label lblMovTob;
        private System.Windows.Forms.NumericUpDown nudPorcDisDespRod;
        private System.Windows.Forms.NumericUpDown nudPorcDisMovTob;
        private System.Windows.Forms.Label lblValorPiernaAfectada;
        private System.Windows.Forms.Label lblTituloPiernaAfectada;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarSesionEST;
    }
}