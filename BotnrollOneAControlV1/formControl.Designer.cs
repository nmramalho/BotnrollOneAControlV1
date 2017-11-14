namespace BotnrollOneAControlV1
{
    partial class formControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formControl));
            this.button_move_frente = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button_move_direita = new System.Windows.Forms.Button();
            this.button_move_esquerda = new System.Windows.Forms.Button();
            this.button_move_tras = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.comboBox_portas = new System.Windows.Forms.ComboBox();
            this.label_porta = new System.Windows.Forms.Label();
            this.button_abrir_com = new System.Windows.Forms.Button();
            this.label_estado_ligacao = new System.Windows.Forms.Label();
            this.label_estado = new System.Windows.Forms.Label();
            this.button_fechar_ligacao = new System.Windows.Forms.Button();
            this.pictureClube = new System.Windows.Forms.PictureBox();
            this.groupBoxLigacao = new System.Windows.Forms.GroupBox();
            this.groupBoxControlo = new System.Windows.Forms.GroupBox();
            this.groupBoxSensores = new System.Windows.Forms.GroupBox();
            this.buttonLerBateria = new System.Windows.Forms.Button();
            this.labelSensorBateria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClube)).BeginInit();
            this.groupBoxLigacao.SuspendLayout();
            this.groupBoxControlo.SuspendLayout();
            this.groupBoxSensores.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_move_frente
            // 
            this.button_move_frente.Location = new System.Drawing.Point(142, 24);
            this.button_move_frente.Name = "button_move_frente";
            this.button_move_frente.Size = new System.Drawing.Size(75, 47);
            this.button_move_frente.TabIndex = 0;
            this.button_move_frente.Text = "Frente";
            this.button_move_frente.UseVisualStyleBackColor = true;
            this.button_move_frente.Click += new System.EventHandler(this.button_move_frente_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 57600;
            this.serialPort1.PortName = "COM";
            // 
            // button_move_direita
            // 
            this.button_move_direita.Location = new System.Drawing.Point(248, 99);
            this.button_move_direita.Name = "button_move_direita";
            this.button_move_direita.Size = new System.Drawing.Size(75, 47);
            this.button_move_direita.TabIndex = 1;
            this.button_move_direita.Text = "Direita";
            this.button_move_direita.UseVisualStyleBackColor = true;
            this.button_move_direita.Click += new System.EventHandler(this.button_move_direita_Click);
            // 
            // button_move_esquerda
            // 
            this.button_move_esquerda.Location = new System.Drawing.Point(29, 99);
            this.button_move_esquerda.Name = "button_move_esquerda";
            this.button_move_esquerda.Size = new System.Drawing.Size(75, 47);
            this.button_move_esquerda.TabIndex = 2;
            this.button_move_esquerda.Text = "Esquerda";
            this.button_move_esquerda.UseVisualStyleBackColor = true;
            this.button_move_esquerda.Click += new System.EventHandler(this.button_move_esquerda_Click);
            // 
            // button_move_tras
            // 
            this.button_move_tras.Location = new System.Drawing.Point(142, 173);
            this.button_move_tras.Name = "button_move_tras";
            this.button_move_tras.Size = new System.Drawing.Size(75, 50);
            this.button_move_tras.TabIndex = 3;
            this.button_move_tras.Text = "Trás";
            this.button_move_tras.UseVisualStyleBackColor = true;
            this.button_move_tras.Click += new System.EventHandler(this.button_move_tras_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(110, 77);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(132, 90);
            this.button_stop.TabIndex = 4;
            this.button_stop.Text = "STOP";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // comboBox_portas
            // 
            this.comboBox_portas.FormattingEnabled = true;
            this.comboBox_portas.Location = new System.Drawing.Point(64, 34);
            this.comboBox_portas.Name = "comboBox_portas";
            this.comboBox_portas.Size = new System.Drawing.Size(66, 21);
            this.comboBox_portas.TabIndex = 5;
            // 
            // label_porta
            // 
            this.label_porta.AutoSize = true;
            this.label_porta.Location = new System.Drawing.Point(24, 37);
            this.label_porta.Name = "label_porta";
            this.label_porta.Size = new System.Drawing.Size(32, 13);
            this.label_porta.TabIndex = 6;
            this.label_porta.Text = "Porta";
            // 
            // button_abrir_com
            // 
            this.button_abrir_com.Location = new System.Drawing.Point(136, 34);
            this.button_abrir_com.Name = "button_abrir_com";
            this.button_abrir_com.Size = new System.Drawing.Size(65, 21);
            this.button_abrir_com.TabIndex = 7;
            this.button_abrir_com.Text = "Abrir";
            this.button_abrir_com.UseVisualStyleBackColor = true;
            this.button_abrir_com.Click += new System.EventHandler(this.button_abrir_com_Click);
            // 
            // label_estado_ligacao
            // 
            this.label_estado_ligacao.AutoSize = true;
            this.label_estado_ligacao.Location = new System.Drawing.Point(24, 76);
            this.label_estado_ligacao.Name = "label_estado_ligacao";
            this.label_estado_ligacao.Size = new System.Drawing.Size(96, 13);
            this.label_estado_ligacao.TabIndex = 8;
            this.label_estado_ligacao.Text = "Estado da Ligação";
            // 
            // label_estado
            // 
            this.label_estado.AutoSize = true;
            this.label_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_estado.ForeColor = System.Drawing.Color.Red;
            this.label_estado.Location = new System.Drawing.Point(126, 76);
            this.label_estado.Name = "label_estado";
            this.label_estado.Size = new System.Drawing.Size(90, 13);
            this.label_estado.TabIndex = 9;
            this.label_estado.Text = "SEM LIGAÇÂO";
            // 
            // button_fechar_ligacao
            // 
            this.button_fechar_ligacao.Location = new System.Drawing.Point(207, 33);
            this.button_fechar_ligacao.Name = "button_fechar_ligacao";
            this.button_fechar_ligacao.Size = new System.Drawing.Size(55, 22);
            this.button_fechar_ligacao.TabIndex = 10;
            this.button_fechar_ligacao.Text = "Fechar";
            this.button_fechar_ligacao.UseVisualStyleBackColor = true;
            this.button_fechar_ligacao.Click += new System.EventHandler(this.button_fechar_ligacao_Click);
            // 
            // pictureClube
            // 
            this.pictureClube.Image = ((System.Drawing.Image)(resources.GetObject("pictureClube.Image")));
            this.pictureClube.Location = new System.Drawing.Point(241, 358);
            this.pictureClube.Name = "pictureClube";
            this.pictureClube.Size = new System.Drawing.Size(321, 91);
            this.pictureClube.TabIndex = 11;
            this.pictureClube.TabStop = false;
            // 
            // groupBoxLigacao
            // 
            this.groupBoxLigacao.Controls.Add(this.comboBox_portas);
            this.groupBoxLigacao.Controls.Add(this.label_estado_ligacao);
            this.groupBoxLigacao.Controls.Add(this.button_fechar_ligacao);
            this.groupBoxLigacao.Controls.Add(this.label_porta);
            this.groupBoxLigacao.Controls.Add(this.button_abrir_com);
            this.groupBoxLigacao.Controls.Add(this.label_estado);
            this.groupBoxLigacao.Location = new System.Drawing.Point(447, 39);
            this.groupBoxLigacao.Name = "groupBoxLigacao";
            this.groupBoxLigacao.Size = new System.Drawing.Size(285, 101);
            this.groupBoxLigacao.TabIndex = 12;
            this.groupBoxLigacao.TabStop = false;
            this.groupBoxLigacao.Text = "Configuração da ligação";
            // 
            // groupBoxControlo
            // 
            this.groupBoxControlo.Controls.Add(this.button_stop);
            this.groupBoxControlo.Controls.Add(this.button_move_tras);
            this.groupBoxControlo.Controls.Add(this.button_move_frente);
            this.groupBoxControlo.Controls.Add(this.button_move_esquerda);
            this.groupBoxControlo.Controls.Add(this.button_move_direita);
            this.groupBoxControlo.Location = new System.Drawing.Point(21, 39);
            this.groupBoxControlo.Name = "groupBoxControlo";
            this.groupBoxControlo.Size = new System.Drawing.Size(357, 254);
            this.groupBoxControlo.TabIndex = 13;
            this.groupBoxControlo.TabStop = false;
            this.groupBoxControlo.Text = "Controlo remoto";
            // 
            // groupBoxSensores
            // 
            this.groupBoxSensores.Controls.Add(this.labelSensorBateria);
            this.groupBoxSensores.Controls.Add(this.buttonLerBateria);
            this.groupBoxSensores.Location = new System.Drawing.Point(447, 162);
            this.groupBoxSensores.Name = "groupBoxSensores";
            this.groupBoxSensores.Size = new System.Drawing.Size(285, 131);
            this.groupBoxSensores.TabIndex = 14;
            this.groupBoxSensores.TabStop = false;
            this.groupBoxSensores.Text = "Sensores";
            // 
            // buttonLerBateria
            // 
            this.buttonLerBateria.Location = new System.Drawing.Point(7, 20);
            this.buttonLerBateria.Name = "buttonLerBateria";
            this.buttonLerBateria.Size = new System.Drawing.Size(75, 23);
            this.buttonLerBateria.TabIndex = 0;
            this.buttonLerBateria.Text = "Bateria";
            this.buttonLerBateria.UseVisualStyleBackColor = true;
            this.buttonLerBateria.Click += new System.EventHandler(this.buttonLerBateria_Click);
            // 
            // labelSensorBateria
            // 
            this.labelSensorBateria.AutoSize = true;
            this.labelSensorBateria.Location = new System.Drawing.Point(95, 25);
            this.labelSensorBateria.Name = "labelSensorBateria";
            this.labelSensorBateria.Size = new System.Drawing.Size(0, 13);
            this.labelSensorBateria.TabIndex = 1;
            // 
            // formControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(825, 452);
            this.Controls.Add(this.groupBoxSensores);
            this.Controls.Add(this.groupBoxControlo);
            this.Controls.Add(this.groupBoxLigacao);
            this.Controls.Add(this.pictureClube);
            this.Name = "formControl";
            this.Text = "Botnroll One A Control v1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureClube)).EndInit();
            this.groupBoxLigacao.ResumeLayout(false);
            this.groupBoxLigacao.PerformLayout();
            this.groupBoxControlo.ResumeLayout(false);
            this.groupBoxSensores.ResumeLayout(false);
            this.groupBoxSensores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_move_frente;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button_move_direita;
        private System.Windows.Forms.Button button_move_esquerda;
        private System.Windows.Forms.Button button_move_tras;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.ComboBox comboBox_portas;
        private System.Windows.Forms.Label label_porta;
        private System.Windows.Forms.Button button_abrir_com;
        private System.Windows.Forms.Label label_estado_ligacao;
        private System.Windows.Forms.Label label_estado;
        private System.Windows.Forms.Button button_fechar_ligacao;
        private System.Windows.Forms.PictureBox pictureClube;
        private System.Windows.Forms.GroupBox groupBoxLigacao;
        private System.Windows.Forms.GroupBox groupBoxControlo;
        private System.Windows.Forms.GroupBox groupBoxSensores;
        private System.Windows.Forms.Label labelSensorBateria;
        private System.Windows.Forms.Button buttonLerBateria;
    }
}

