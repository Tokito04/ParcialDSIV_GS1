namespace ParcialDSIV_GS1
{
    partial class Form1
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
            this.pnlBienvenida = new System.Windows.Forms.Panel();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.chkModoDificil = new System.Windows.Forms.CheckBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.grpEnergia = new System.Windows.Forms.GroupBox();
            this.rdbEnergiaBaja = new System.Windows.Forms.RadioButton();
            this.rdbEnergiaMedia = new System.Windows.Forms.RadioButton();
            this.rdbEnergiaAlta = new System.Windows.Forms.RadioButton();
            this.cboColorFavorito = new System.Windows.Forms.ComboBox();
            this.pnlJuego = new System.Windows.Forms.Panel();
            this.pgbEnergia = new System.Windows.Forms.ProgressBar();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.lblSigno = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblOperacionTitulo = new System.Windows.Forms.Label();
            this.pnlReto = new System.Windows.Forms.Panel();
            this.lblResultadoReto = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lstAnimales = new System.Windows.Forms.ListBox();
            this.lblReto = new System.Windows.Forms.Label();
            this.pnlFinal = new System.Windows.Forms.Panel();
            this.pbAnimal = new System.Windows.Forms.PictureBox();
            this.lblMensajeDivertido = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevoJuego = new System.Windows.Forms.Button();
            this.lblFinalEnergia = new System.Windows.Forms.Label();
            this.lblFinalColor = new System.Windows.Forms.Label();
            this.lblFinalMensaje = new System.Windows.Forms.Label();
            this.lblFinalAnimal = new System.Windows.Forms.Label();
            this.lblFinalJugador = new System.Windows.Forms.Label();
            this.lblFinalTitulo = new System.Windows.Forms.Label();
            this.pnlBienvenida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.pnlRegistro.SuspendLayout();
            this.grpEnergia.SuspendLayout();
            this.pnlJuego.SuspendLayout();
            this.pnlReto.SuspendLayout();
            this.pnlFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBienvenida
            // 
            this.pnlBienvenida.Controls.Add(this.btnComenzar);
            this.pnlBienvenida.Controls.Add(this.pbPortada);
            this.pnlBienvenida.Controls.Add(this.lblTitulo);
            this.pnlBienvenida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBienvenida.Location = new System.Drawing.Point(0, 0);
            this.pnlBienvenida.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBienvenida.Name = "pnlBienvenida";
            this.pnlBienvenida.Size = new System.Drawing.Size(1279, 719);
            this.pnlBienvenida.TabIndex = 0;
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnComenzar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnComenzar.Location = new System.Drawing.Point(582, 629);
            this.btnComenzar.Margin = new System.Windows.Forms.Padding(4);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(128, 44);
            this.btnComenzar.TabIndex = 2;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = false;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // pbPortada
            // 
            this.pbPortada.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbPortada.Location = new System.Drawing.Point(358, 187);
            this.pbPortada.Margin = new System.Windows.Forms.Padding(4);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(576, 389);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortada.TabIndex = 1;
            this.pbPortada.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(152, 80);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(970, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Juego de matemáticas. Por si no estas aburrido de matemáticas ya";
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.Controls.Add(this.lblNombre);
            this.pnlRegistro.Controls.Add(this.txtNombre);
            this.pnlRegistro.Controls.Add(this.lblColor);
            this.pnlRegistro.Controls.Add(this.chkModoDificil);
            this.pnlRegistro.Controls.Add(this.btnContinuar);
            this.pnlRegistro.Controls.Add(this.grpEnergia);
            this.pnlRegistro.Controls.Add(this.cboColorFavorito);
            this.pnlRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistro.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(1279, 719);
            this.pnlRegistro.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(99, 37);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(168, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre de Jugador";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(101, 80);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 28);
            this.txtNombre.TabIndex = 1;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(99, 333);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(123, 22);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Color Favorito";
            // 
            // chkModoDificil
            // 
            this.chkModoDificil.AutoSize = true;
            this.chkModoDificil.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModoDificil.Location = new System.Drawing.Point(100, 436);
            this.chkModoDificil.Margin = new System.Windows.Forms.Padding(4);
            this.chkModoDificil.Name = "chkModoDificil";
            this.chkModoDificil.Size = new System.Drawing.Size(125, 25);
            this.chkModoDificil.TabIndex = 5;
            this.chkModoDificil.Text = "Modo Dificil";
            this.chkModoDificil.UseVisualStyleBackColor = true;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnContinuar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnContinuar.Location = new System.Drawing.Point(100, 495);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(4);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(113, 43);
            this.btnContinuar.TabIndex = 6;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // grpEnergia
            // 
            this.grpEnergia.Controls.Add(this.rdbEnergiaBaja);
            this.grpEnergia.Controls.Add(this.rdbEnergiaMedia);
            this.grpEnergia.Controls.Add(this.rdbEnergiaAlta);
            this.grpEnergia.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEnergia.Location = new System.Drawing.Point(104, 141);
            this.grpEnergia.Margin = new System.Windows.Forms.Padding(4);
            this.grpEnergia.Name = "grpEnergia";
            this.grpEnergia.Padding = new System.Windows.Forms.Padding(4);
            this.grpEnergia.Size = new System.Drawing.Size(246, 157);
            this.grpEnergia.TabIndex = 2;
            this.grpEnergia.TabStop = false;
            this.grpEnergia.Text = "Nivel de Energia";
            // 
            // rdbEnergiaBaja
            // 
            this.rdbEnergiaBaja.AutoSize = true;
            this.rdbEnergiaBaja.Location = new System.Drawing.Point(8, 104);
            this.rdbEnergiaBaja.Margin = new System.Windows.Forms.Padding(4);
            this.rdbEnergiaBaja.Name = "rdbEnergiaBaja";
            this.rdbEnergiaBaja.Size = new System.Drawing.Size(134, 25);
            this.rdbEnergiaBaja.TabIndex = 2;
            this.rdbEnergiaBaja.TabStop = true;
            this.rdbEnergiaBaja.Text = "Energia Baja";
            this.rdbEnergiaBaja.UseVisualStyleBackColor = true;
            // 
            // rdbEnergiaMedia
            // 
            this.rdbEnergiaMedia.AutoSize = true;
            this.rdbEnergiaMedia.Location = new System.Drawing.Point(8, 75);
            this.rdbEnergiaMedia.Margin = new System.Windows.Forms.Padding(4);
            this.rdbEnergiaMedia.Name = "rdbEnergiaMedia";
            this.rdbEnergiaMedia.Size = new System.Drawing.Size(147, 25);
            this.rdbEnergiaMedia.TabIndex = 1;
            this.rdbEnergiaMedia.TabStop = true;
            this.rdbEnergiaMedia.Text = "Energia Media";
            this.rdbEnergiaMedia.UseVisualStyleBackColor = true;
            // 
            // rdbEnergiaAlta
            // 
            this.rdbEnergiaAlta.AutoSize = true;
            this.rdbEnergiaAlta.Location = new System.Drawing.Point(8, 46);
            this.rdbEnergiaAlta.Margin = new System.Windows.Forms.Padding(4);
            this.rdbEnergiaAlta.Name = "rdbEnergiaAlta";
            this.rdbEnergiaAlta.Size = new System.Drawing.Size(127, 25);
            this.rdbEnergiaAlta.TabIndex = 0;
            this.rdbEnergiaAlta.TabStop = true;
            this.rdbEnergiaAlta.Text = "Energia Alta";
            this.rdbEnergiaAlta.UseVisualStyleBackColor = true;
            // 
            // cboColorFavorito
            // 
            this.cboColorFavorito.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboColorFavorito.FormattingEnabled = true;
            this.cboColorFavorito.Items.AddRange(new object[] {
            "Rojo",
            "Verde",
            "Azul",
            "Amarillo",
            "Negro"});
            this.cboColorFavorito.Location = new System.Drawing.Point(100, 372);
            this.cboColorFavorito.Margin = new System.Windows.Forms.Padding(4);
            this.cboColorFavorito.Name = "cboColorFavorito";
            this.cboColorFavorito.Size = new System.Drawing.Size(160, 29);
            this.cboColorFavorito.TabIndex = 4;
            // 
            // pnlJuego
            // 
            this.pnlJuego.Controls.Add(this.pgbEnergia);
            this.pnlJuego.Controls.Add(this.lblIntentos);
            this.pnlJuego.Controls.Add(this.btnValidar);
            this.pnlJuego.Controls.Add(this.txtRespuesta);
            this.pnlJuego.Controls.Add(this.lblSigno);
            this.pnlJuego.Controls.Add(this.lblNum2);
            this.pnlJuego.Controls.Add(this.lblNum1);
            this.pnlJuego.Controls.Add(this.lblOperacionTitulo);
            this.pnlJuego.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlJuego.Location = new System.Drawing.Point(0, 0);
            this.pnlJuego.Margin = new System.Windows.Forms.Padding(4);
            this.pnlJuego.Name = "pnlJuego";
            this.pnlJuego.Size = new System.Drawing.Size(1279, 719);
            this.pnlJuego.TabIndex = 7;
            // 
            // pgbEnergia
            // 
            this.pgbEnergia.Location = new System.Drawing.Point(85, 431);
            this.pgbEnergia.Margin = new System.Windows.Forms.Padding(4);
            this.pgbEnergia.Name = "pgbEnergia";
            this.pgbEnergia.Size = new System.Drawing.Size(133, 28);
            this.pgbEnergia.TabIndex = 7;
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentos.Location = new System.Drawing.Point(81, 354);
            this.lblIntentos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(172, 21);
            this.lblIntentos.TabIndex = 6;
            this.lblIntentos.Text = "Intentos restantes: 3";
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(85, 291);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(100, 28);
            this.btnValidar.TabIndex = 5;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta.Location = new System.Drawing.Point(85, 208);
            this.txtRespuesta.Margin = new System.Windows.Forms.Padding(4);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(132, 28);
            this.txtRespuesta.TabIndex = 4;
            // 
            // lblSigno
            // 
            this.lblSigno.AutoSize = true;
            this.lblSigno.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigno.Location = new System.Drawing.Point(122, 153);
            this.lblSigno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(56, 21);
            this.lblSigno.TabIndex = 3;
            this.lblSigno.Text = "Signo";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(186, 153);
            this.lblNum2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(83, 21);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "Numero2";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(31, 153);
            this.lblNum1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(83, 21);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "Numero1";
            // 
            // lblOperacionTitulo
            // 
            this.lblOperacionTitulo.AutoSize = true;
            this.lblOperacionTitulo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacionTitulo.Location = new System.Drawing.Point(99, 58);
            this.lblOperacionTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperacionTitulo.Name = "lblOperacionTitulo";
            this.lblOperacionTitulo.Size = new System.Drawing.Size(118, 21);
            this.lblOperacionTitulo.TabIndex = 0;
            this.lblOperacionTitulo.Text = "Ronda 1 de 5";
            // 
            // pnlReto
            // 
            this.pnlReto.Controls.Add(this.lblResultadoReto);
            this.pnlReto.Controls.Add(this.btnSeleccionar);
            this.pnlReto.Controls.Add(this.lstAnimales);
            this.pnlReto.Controls.Add(this.lblReto);
            this.pnlReto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReto.Location = new System.Drawing.Point(0, 0);
            this.pnlReto.Margin = new System.Windows.Forms.Padding(4);
            this.pnlReto.Name = "pnlReto";
            this.pnlReto.Size = new System.Drawing.Size(1279, 719);
            this.pnlReto.TabIndex = 8;
            // 
            // lblResultadoReto
            // 
            this.lblResultadoReto.AutoSize = true;
            this.lblResultadoReto.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoReto.Location = new System.Drawing.Point(51, 227);
            this.lblResultadoReto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultadoReto.Name = "lblResultadoReto";
            this.lblResultadoReto.Size = new System.Drawing.Size(28, 21);
            this.lblResultadoReto.TabIndex = 3;
            this.lblResultadoReto.Text = "---";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSeleccionar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSeleccionar.Location = new System.Drawing.Point(55, 288);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(128, 41);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lstAnimales
            // 
            this.lstAnimales.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAnimales.FormattingEnabled = true;
            this.lstAnimales.ItemHeight = 21;
            this.lstAnimales.Items.AddRange(new object[] {
            "Perro",
            "Gato",
            "Elefante",
            "León",
            "Ratón"});
            this.lstAnimales.Location = new System.Drawing.Point(53, 93);
            this.lstAnimales.Margin = new System.Windows.Forms.Padding(4);
            this.lstAnimales.Name = "lstAnimales";
            this.lstAnimales.Size = new System.Drawing.Size(159, 109);
            this.lstAnimales.TabIndex = 1;
            // 
            // lblReto
            // 
            this.lblReto.AutoSize = true;
            this.lblReto.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReto.Location = new System.Drawing.Point(51, 40);
            this.lblReto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReto.Name = "lblReto";
            this.lblReto.Size = new System.Drawing.Size(132, 21);
            this.lblReto.TabIndex = 0;
            this.lblReto.Text = "Elige un animal";
            // 
            // pnlFinal
            // 
            this.pnlFinal.Controls.Add(this.pbAnimal);
            this.pnlFinal.Controls.Add(this.lblMensajeDivertido);
            this.pnlFinal.Controls.Add(this.btnSalir);
            this.pnlFinal.Controls.Add(this.btnNuevoJuego);
            this.pnlFinal.Controls.Add(this.lblFinalEnergia);
            this.pnlFinal.Controls.Add(this.lblFinalColor);
            this.pnlFinal.Controls.Add(this.lblFinalMensaje);
            this.pnlFinal.Controls.Add(this.lblFinalAnimal);
            this.pnlFinal.Controls.Add(this.lblFinalJugador);
            this.pnlFinal.Controls.Add(this.lblFinalTitulo);
            this.pnlFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFinal.Location = new System.Drawing.Point(0, 0);
            this.pnlFinal.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFinal.Name = "pnlFinal";
            this.pnlFinal.Size = new System.Drawing.Size(1279, 719);
            this.pnlFinal.TabIndex = 4;
            // 
            // pbAnimal
            // 
            this.pbAnimal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbAnimal.Location = new System.Drawing.Point(380, 37);
            this.pbAnimal.Name = "pbAnimal";
            this.pbAnimal.Size = new System.Drawing.Size(588, 409);
            this.pbAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimal.TabIndex = 9;
            this.pbAnimal.TabStop = false;
            // 
            // lblMensajeDivertido
            // 
            this.lblMensajeDivertido.AutoSize = true;
            this.lblMensajeDivertido.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeDivertido.Location = new System.Drawing.Point(376, 465);
            this.lblMensajeDivertido.Name = "lblMensajeDivertido";
            this.lblMensajeDivertido.Size = new System.Drawing.Size(154, 21);
            this.lblMensajeDivertido.TabIndex = 8;
            this.lblMensajeDivertido.Text = "Mensaje Divertido";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(55, 399);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 34);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevoJuego
            // 
            this.btnNuevoJuego.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNuevoJuego.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoJuego.Location = new System.Drawing.Point(55, 337);
            this.btnNuevoJuego.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoJuego.Name = "btnNuevoJuego";
            this.btnNuevoJuego.Size = new System.Drawing.Size(129, 34);
            this.btnNuevoJuego.TabIndex = 6;
            this.btnNuevoJuego.Text = "Nuevo Juego";
            this.btnNuevoJuego.UseVisualStyleBackColor = false;
            this.btnNuevoJuego.Click += new System.EventHandler(this.btnNuevoJuego_Click);
            // 
            // lblFinalEnergia
            // 
            this.lblFinalEnergia.AutoSize = true;
            this.lblFinalEnergia.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalEnergia.Location = new System.Drawing.Point(49, 245);
            this.lblFinalEnergia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalEnergia.Name = "lblFinalEnergia";
            this.lblFinalEnergia.Size = new System.Drawing.Size(120, 21);
            this.lblFinalEnergia.TabIndex = 5;
            this.lblFinalEnergia.Text = "Energia final: ";
            // 
            // lblFinalColor
            // 
            this.lblFinalColor.AutoSize = true;
            this.lblFinalColor.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalColor.Location = new System.Drawing.Point(49, 206);
            this.lblFinalColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalColor.Name = "lblFinalColor";
            this.lblFinalColor.Size = new System.Drawing.Size(133, 21);
            this.lblFinalColor.TabIndex = 4;
            this.lblFinalColor.Text = "Color Favorito: ";
            // 
            // lblFinalMensaje
            // 
            this.lblFinalMensaje.AutoSize = true;
            this.lblFinalMensaje.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalMensaje.Location = new System.Drawing.Point(49, 166);
            this.lblFinalMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalMensaje.Name = "lblFinalMensaje";
            this.lblFinalMensaje.Size = new System.Drawing.Size(88, 21);
            this.lblFinalMensaje.TabIndex = 3;
            this.lblFinalMensaje.Text = "Mensaje: ";
            // 
            // lblFinalAnimal
            // 
            this.lblFinalAnimal.AutoSize = true;
            this.lblFinalAnimal.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalAnimal.Location = new System.Drawing.Point(49, 132);
            this.lblFinalAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalAnimal.Name = "lblFinalAnimal";
            this.lblFinalAnimal.Size = new System.Drawing.Size(73, 21);
            this.lblFinalAnimal.TabIndex = 2;
            this.lblFinalAnimal.Text = "Animal: ";
            // 
            // lblFinalJugador
            // 
            this.lblFinalJugador.AutoSize = true;
            this.lblFinalJugador.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalJugador.Location = new System.Drawing.Point(49, 97);
            this.lblFinalJugador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalJugador.Name = "lblFinalJugador";
            this.lblFinalJugador.Size = new System.Drawing.Size(85, 21);
            this.lblFinalJugador.TabIndex = 1;
            this.lblFinalJugador.Text = "Jugador: ";
            // 
            // lblFinalTitulo
            // 
            this.lblFinalTitulo.AutoSize = true;
            this.lblFinalTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalTitulo.Location = new System.Drawing.Point(40, 37);
            this.lblFinalTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalTitulo.Name = "lblFinalTitulo";
            this.lblFinalTitulo.Size = new System.Drawing.Size(196, 24);
            this.lblFinalTitulo.TabIndex = 0;
            this.lblFinalTitulo.Text = "Resumen del Juego";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 719);
            this.Controls.Add(this.pnlFinal);
            this.Controls.Add(this.pnlJuego);
            this.Controls.Add(this.pnlReto);
            this.Controls.Add(this.pnlRegistro);
            this.Controls.Add(this.pnlBienvenida);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlBienvenida.ResumeLayout(false);
            this.pnlBienvenida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.grpEnergia.ResumeLayout(false);
            this.grpEnergia.PerformLayout();
            this.pnlJuego.ResumeLayout(false);
            this.pnlJuego.PerformLayout();
            this.pnlReto.ResumeLayout(false);
            this.pnlReto.PerformLayout();
            this.pnlFinal.ResumeLayout(false);
            this.pnlFinal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBienvenida;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.CheckBox chkModoDificil;
        private System.Windows.Forms.ComboBox cboColorFavorito;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.GroupBox grpEnergia;
        private System.Windows.Forms.RadioButton rdbEnergiaBaja;
        private System.Windows.Forms.RadioButton rdbEnergiaMedia;
        private System.Windows.Forms.RadioButton rdbEnergiaAlta;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Panel pnlJuego;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblOperacionTitulo;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblSigno;
        private System.Windows.Forms.ProgressBar pgbEnergia;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Panel pnlReto;
        private System.Windows.Forms.ListBox lstAnimales;
        private System.Windows.Forms.Label lblReto;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblResultadoReto;
        private System.Windows.Forms.Panel pnlFinal;
        private System.Windows.Forms.Label lblFinalTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevoJuego;
        private System.Windows.Forms.Label lblFinalEnergia;
        private System.Windows.Forms.Label lblFinalColor;
        private System.Windows.Forms.Label lblFinalMensaje;
        private System.Windows.Forms.Label lblFinalAnimal;
        private System.Windows.Forms.Label lblFinalJugador;
        private System.Windows.Forms.Label lblMensajeDivertido;
        private System.Windows.Forms.PictureBox pbAnimal;
    }
}

