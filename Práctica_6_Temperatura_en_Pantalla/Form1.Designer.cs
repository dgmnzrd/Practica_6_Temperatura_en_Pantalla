namespace Práctica_6_Temperatura_en_Pantalla
{
    partial class frmSerie
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelPuertoSerie = new Label();
            cmbPuertos = new ComboBox();
            btnConectar = new Button();
            btnActualizar = new Button();
            rtbLog = new RichTextBox();
            label1 = new Label();
            labelLectura = new Label();
            btnDesconectar = new Button();
            labelTemperatura = new Label();
            groupBox1 = new GroupBox();
            panelTemperatura = new Panel();
            labelClima = new Label();
            groupBox1.SuspendLayout();
            panelTemperatura.SuspendLayout();
            SuspendLayout();
            // 
            // labelPuertoSerie
            // 
            labelPuertoSerie.AutoSize = true;
            labelPuertoSerie.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPuertoSerie.ForeColor = Color.White;
            labelPuertoSerie.Location = new Point(169, 9);
            labelPuertoSerie.Name = "labelPuertoSerie";
            labelPuertoSerie.Size = new Size(261, 37);
            labelPuertoSerie.TabIndex = 0;
            labelPuertoSerie.Text = "Temperatura LM35";
            // 
            // cmbPuertos
            // 
            cmbPuertos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPuertos.FormattingEnabled = true;
            cmbPuertos.Location = new Point(12, 74);
            cmbPuertos.Name = "cmbPuertos";
            cmbPuertos.Size = new Size(223, 33);
            cmbPuertos.TabIndex = 1;
            // 
            // btnConectar
            // 
            btnConectar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConectar.Location = new Point(242, 74);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(96, 33);
            btnConectar.TabIndex = 2;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(475, 74);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(107, 33);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // rtbLog
            // 
            rtbLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbLog.Location = new Point(12, 147);
            rtbLog.Name = "rtbLog";
            rtbLog.ReadOnly = true;
            rtbLog.Size = new Size(83, 521);
            rtbLog.TabIndex = 5;
            rtbLog.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 46);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 7;
            label1.Text = "Puerto Serie";
            // 
            // labelLectura
            // 
            labelLectura.AutoSize = true;
            labelLectura.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLectura.ForeColor = SystemColors.ButtonHighlight;
            labelLectura.Location = new Point(12, 119);
            labelLectura.Name = "labelLectura";
            labelLectura.Size = new Size(83, 25);
            labelLectura.TabIndex = 8;
            labelLectura.Text = "Lectura:";
            // 
            // btnDesconectar
            // 
            btnDesconectar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDesconectar.Location = new Point(344, 73);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(125, 33);
            btnDesconectar.TabIndex = 9;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // labelTemperatura
            // 
            labelTemperatura.AutoSize = true;
            labelTemperatura.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTemperatura.ForeColor = SystemColors.ButtonHighlight;
            labelTemperatura.Location = new Point(12, 17);
            labelTemperatura.Name = "labelTemperatura";
            labelTemperatura.Size = new Size(226, 86);
            labelTemperatura.TabIndex = 10;
            labelTemperatura.Text = "00.00°";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panelTemperatura);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(107, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(475, 549);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "LM35⚲";
            // 
            // panelTemperatura
            // 
            panelTemperatura.Controls.Add(labelClima);
            panelTemperatura.Controls.Add(labelTemperatura);
            panelTemperatura.Location = new Point(6, 32);
            panelTemperatura.Name = "panelTemperatura";
            panelTemperatura.Size = new Size(463, 511);
            panelTemperatura.TabIndex = 0;
            // 
            // labelClima
            // 
            labelClima.AutoSize = true;
            labelClima.Font = new Font("Segoe UI", 144F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelClima.ForeColor = SystemColors.ButtonHighlight;
            labelClima.Location = new Point(94, 151);
            labelClima.Name = "labelClima";
            labelClima.Size = new Size(223, 254);
            labelClima.TabIndex = 11;
            labelClima.Text = "●";
            // 
            // frmSerie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(595, 680);
            Controls.Add(groupBox1);
            Controls.Add(btnDesconectar);
            Controls.Add(labelLectura);
            Controls.Add(label1);
            Controls.Add(rtbLog);
            Controls.Add(btnActualizar);
            Controls.Add(btnConectar);
            Controls.Add(cmbPuertos);
            Controls.Add(labelPuertoSerie);
            Name = "frmSerie";
            Text = "Práctica 6 Temperatura en Pantalla";
            Load += frmSerie_Load;
            groupBox1.ResumeLayout(false);
            panelTemperatura.ResumeLayout(false);
            panelTemperatura.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPuertoSerie;
        private ComboBox cmbPuertos;
        private Button btnConectar;
        private Button btnActualizar;
        private RichTextBox rtbLog;
        private Label label1;
        private Label labelLectura;
        private Button btnDesconectar;
        private Label labelTemperatura;
        private GroupBox groupBox1;
        private Panel panelTemperatura;
        private Label labelClima;
    }
}
