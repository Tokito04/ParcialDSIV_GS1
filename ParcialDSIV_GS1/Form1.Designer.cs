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
            this.SuspendLayout();
            // 
            // pnlBienvenida
            // 
            this.pnlBienvenida.Controls.Add(this.btnComenzar);
            this.pnlBienvenida.Controls.Add(this.pbPortada);
            this.pnlBienvenida.Controls.Add(this.lblTitulo);
            this.pnlBienvenida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBienvenida.Location = new System.Drawing.Point(0, 0);
            this.pnlBienvenida.Name = "pnlBienvenida";
            this.pnlBienvenida.Size = new System.Drawing.Size(959, 584);
            this.pnlBienvenida.TabIndex = 0;
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(424, 515);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(75, 23);
            this.btnComenzar.TabIndex = 2;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // pbPortada
            // 
            this.pbPortada.Location = new System.Drawing.Point(246, 152);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(432, 316);
            this.pbPortada.TabIndex = 1;
            this.pbPortada.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(114, 65);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(781, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Juego de matematica por si no estas aburrido de matematica ya";
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
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(959, 584);
            this.pnlRegistro.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(73, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre de Jugador";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(76, 278);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(72, 13);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Color Favorito";
            // 
            // chkModoDificil
            // 
            this.chkModoDificil.AutoSize = true;
            this.chkModoDificil.Location = new System.Drawing.Point(76, 376);
            this.chkModoDificil.Name = "chkModoDificil";
            this.chkModoDificil.Size = new System.Drawing.Size(81, 17);
            this.chkModoDificil.TabIndex = 5;
            this.chkModoDificil.Text = "Modo Dificil";
            this.chkModoDificil.UseVisualStyleBackColor = true;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(76, 434);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 6;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // grpEnergia
            // 
            this.grpEnergia.Controls.Add(this.rdbEnergiaBaja);
            this.grpEnergia.Controls.Add(this.rdbEnergiaMedia);
            this.grpEnergia.Controls.Add(this.rdbEnergiaAlta);
            this.grpEnergia.Location = new System.Drawing.Point(76, 122);
            this.grpEnergia.Name = "grpEnergia";
            this.grpEnergia.Size = new System.Drawing.Size(200, 100);
            this.grpEnergia.TabIndex = 2;
            this.grpEnergia.TabStop = false;
            this.grpEnergia.Text = "Nivel de Energia";
            // 
            // rdbEnergiaBaja
            // 
            this.rdbEnergiaBaja.AutoSize = true;
            this.rdbEnergiaBaja.Location = new System.Drawing.Point(26, 77);
            this.rdbEnergiaBaja.Name = "rdbEnergiaBaja";
            this.rdbEnergiaBaja.Size = new System.Drawing.Size(85, 17);
            this.rdbEnergiaBaja.TabIndex = 2;
            this.rdbEnergiaBaja.TabStop = true;
            this.rdbEnergiaBaja.Text = "Energia Baja";
            this.rdbEnergiaBaja.UseVisualStyleBackColor = true;
            // 
            // rdbEnergiaMedia
            // 
            this.rdbEnergiaMedia.AutoSize = true;
            this.rdbEnergiaMedia.Location = new System.Drawing.Point(26, 54);
            this.rdbEnergiaMedia.Name = "rdbEnergiaMedia";
            this.rdbEnergiaMedia.Size = new System.Drawing.Size(93, 17);
            this.rdbEnergiaMedia.TabIndex = 1;
            this.rdbEnergiaMedia.TabStop = true;
            this.rdbEnergiaMedia.Text = "Energia Media";
            this.rdbEnergiaMedia.UseVisualStyleBackColor = true;
            // 
            // rdbEnergiaAlta
            // 
            this.rdbEnergiaAlta.AutoSize = true;
            this.rdbEnergiaAlta.Location = new System.Drawing.Point(26, 30);
            this.rdbEnergiaAlta.Name = "rdbEnergiaAlta";
            this.rdbEnergiaAlta.Size = new System.Drawing.Size(82, 17);
            this.rdbEnergiaAlta.TabIndex = 0;
            this.rdbEnergiaAlta.TabStop = true;
            this.rdbEnergiaAlta.Text = "Energia Alta";
            this.rdbEnergiaAlta.UseVisualStyleBackColor = true;
            // 
            // cboColorFavorito
            // 
            this.cboColorFavorito.FormattingEnabled = true;
            this.cboColorFavorito.Items.AddRange(new object[] {
            "Verde"});
            this.cboColorFavorito.Location = new System.Drawing.Point(76, 317);
            this.cboColorFavorito.Name = "cboColorFavorito";
            this.cboColorFavorito.Size = new System.Drawing.Size(121, 21);
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
            this.pnlJuego.Name = "pnlJuego";
            this.pnlJuego.Size = new System.Drawing.Size(959, 584);
            this.pnlJuego.TabIndex = 7;
            // 
            // pgbEnergia
            // 
            this.pgbEnergia.Location = new System.Drawing.Point(215, 351);
            this.pgbEnergia.Name = "pgbEnergia";
            this.pgbEnergia.Size = new System.Drawing.Size(100, 23);
            this.pgbEnergia.TabIndex = 7;
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Location = new System.Drawing.Point(241, 278);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(103, 13);
            this.lblIntentos.TabIndex = 6;
            this.lblIntentos.Text = "Intentos restantes: 3";
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(215, 228);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 5;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(215, 165);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(100, 20);
            this.txtRespuesta.TabIndex = 4;
            // 
            // lblSigno
            // 
            this.lblSigno.AutoSize = true;
            this.lblSigno.Location = new System.Drawing.Point(212, 97);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(34, 13);
            this.lblSigno.TabIndex = 3;
            this.lblSigno.Text = "Signo";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(296, 98);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(50, 13);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "Numero2";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(99, 98);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(50, 13);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "Numero1";
            // 
            // lblOperacionTitulo
            // 
            this.lblOperacionTitulo.AutoSize = true;
            this.lblOperacionTitulo.Location = new System.Drawing.Point(358, 30);
            this.lblOperacionTitulo.Name = "lblOperacionTitulo";
            this.lblOperacionTitulo.Size = new System.Drawing.Size(72, 13);
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
            this.pnlReto.Name = "pnlReto";
            this.pnlReto.Size = new System.Drawing.Size(959, 584);
            this.pnlReto.TabIndex = 8;
            // 
            // lblResultadoReto
            // 
            this.lblResultadoReto.AutoSize = true;
            this.lblResultadoReto.Location = new System.Drawing.Point(408, 317);
            this.lblResultadoReto.Name = "lblResultadoReto";
            this.lblResultadoReto.Size = new System.Drawing.Size(35, 13);
            this.lblResultadoReto.TabIndex = 3;
            this.lblResultadoReto.Text = "label1";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(398, 242);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "button1";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lstAnimales
            // 
            this.lstAnimales.FormattingEnabled = true;
            this.lstAnimales.Items.AddRange(new object[] {
            "Gato"});
            this.lstAnimales.Location = new System.Drawing.Point(379, 90);
            this.lstAnimales.Name = "lstAnimales";
            this.lstAnimales.Size = new System.Drawing.Size(120, 95);
            this.lstAnimales.TabIndex = 1;
            // 
            // lblReto
            // 
            this.lblReto.AutoSize = true;
            this.lblReto.Location = new System.Drawing.Point(395, 30);
            this.lblReto.Name = "lblReto";
            this.lblReto.Size = new System.Drawing.Size(78, 13);
            this.lblReto.TabIndex = 0;
            this.lblReto.Text = "Elige un animal";
            // 
            // pnlFinal
            // 
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
            this.pnlFinal.Name = "pnlFinal";
            this.pnlFinal.Size = new System.Drawing.Size(959, 584);
            this.pnlFinal.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(475, 414);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevoJuego
            // 
            this.btnNuevoJuego.Location = new System.Drawing.Point(472, 350);
            this.btnNuevoJuego.Name = "btnNuevoJuego";
            this.btnNuevoJuego.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoJuego.TabIndex = 6;
            this.btnNuevoJuego.Text = "Nuevo Juego";
            this.btnNuevoJuego.UseVisualStyleBackColor = true;
            this.btnNuevoJuego.Click += new System.EventHandler(this.btnNuevoJuego_Click);
            // 
            // lblFinalEnergia
            // 
            this.lblFinalEnergia.AutoSize = true;
            this.lblFinalEnergia.Location = new System.Drawing.Point(472, 295);
            this.lblFinalEnergia.Name = "lblFinalEnergia";
            this.lblFinalEnergia.Size = new System.Drawing.Size(65, 13);
            this.lblFinalEnergia.TabIndex = 5;
            this.lblFinalEnergia.Text = "Energia final";
            // 
            // lblFinalColor
            // 
            this.lblFinalColor.AutoSize = true;
            this.lblFinalColor.Location = new System.Drawing.Point(472, 251);
            this.lblFinalColor.Name = "lblFinalColor";
            this.lblFinalColor.Size = new System.Drawing.Size(78, 13);
            this.lblFinalColor.TabIndex = 4;
            this.lblFinalColor.Text = "Color Favorito--";
            // 
            // lblFinalMensaje
            // 
            this.lblFinalMensaje.AutoSize = true;
            this.lblFinalMensaje.Location = new System.Drawing.Point(469, 192);
            this.lblFinalMensaje.Name = "lblFinalMensaje";
            this.lblFinalMensaje.Size = new System.Drawing.Size(53, 13);
            this.lblFinalMensaje.TabIndex = 3;
            this.lblFinalMensaje.Text = "Mensaje--";
            // 
            // lblFinalAnimal
            // 
            this.lblFinalAnimal.AutoSize = true;
            this.lblFinalAnimal.Location = new System.Drawing.Point(466, 139);
            this.lblFinalAnimal.Name = "lblFinalAnimal";
            this.lblFinalAnimal.Size = new System.Drawing.Size(44, 13);
            this.lblFinalAnimal.TabIndex = 2;
            this.lblFinalAnimal.Text = "Animal--";
            // 
            // lblFinalJugador
            // 
            this.lblFinalJugador.AutoSize = true;
            this.lblFinalJugador.Location = new System.Drawing.Point(463, 90);
            this.lblFinalJugador.Name = "lblFinalJugador";
            this.lblFinalJugador.Size = new System.Drawing.Size(51, 13);
            this.lblFinalJugador.TabIndex = 1;
            this.lblFinalJugador.Text = "Jugador--";
            // 
            // lblFinalTitulo
            // 
            this.lblFinalTitulo.AutoSize = true;
            this.lblFinalTitulo.Location = new System.Drawing.Point(437, 30);
            this.lblFinalTitulo.Name = "lblFinalTitulo";
            this.lblFinalTitulo.Size = new System.Drawing.Size(101, 13);
            this.lblFinalTitulo.TabIndex = 0;
            this.lblFinalTitulo.Text = "Resumen del Juego";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 584);
            this.Controls.Add(this.pnlFinal);
            this.Controls.Add(this.pnlReto);
            this.Controls.Add(this.pnlJuego);
            this.Controls.Add(this.pnlRegistro);
            this.Controls.Add(this.pnlBienvenida);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}

