namespace CRUDIntec
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTiempoRestante = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpExamen = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResiduo = new System.Windows.Forms.TextBox();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.txtMultiplicacion = new System.Windows.Forms.TextBox();
            this.txtResta = new System.Windows.Forms.TextBox();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.lblDividendo = new System.Windows.Forms.Label();
            this.lblFactor2 = new System.Windows.Forms.Label();
            this.lblSustraendo = new System.Windows.Forms.Label();
            this.lblMinuendo = new System.Windows.Forms.Label();
            this.lblFactor1 = new System.Windows.Forms.Label();
            this.lblResta = new System.Windows.Forms.Label();
            this.lblMultiplicacion = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblSumando2 = new System.Windows.Forms.Label();
            this.lblSumando1 = new System.Windows.Forms.Label();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.tmrTiempoRestante = new System.Windows.Forms.Timer(this.components);
            this.grpExamen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.lblTitle.Location = new System.Drawing.Point(2, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(742, 63);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PRUEBA DE MATEMÁTICAS";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 72);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tiempo Restante";
            // 
            // txtTiempoRestante
            // 
            this.txtTiempoRestante.Location = new System.Drawing.Point(385, 113);
            this.txtTiempoRestante.Name = "txtTiempoRestante";
            this.txtTiempoRestante.ReadOnly = true;
            this.txtTiempoRestante.Size = new System.Drawing.Size(253, 20);
            this.txtTiempoRestante.TabIndex = 3;
            // 
            // btnIniciar
            // 
            this.btnIniciar.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnIniciar.Location = new System.Drawing.Point(385, 139);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnCancelar.Location = new System.Drawing.Point(563, 139);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpExamen
            // 
            this.grpExamen.Controls.Add(this.label3);
            this.grpExamen.Controls.Add(this.label2);
            this.grpExamen.Controls.Add(this.txtResiduo);
            this.grpExamen.Controls.Add(this.btnTerminar);
            this.grpExamen.Controls.Add(this.txtDivision);
            this.grpExamen.Controls.Add(this.txtMultiplicacion);
            this.grpExamen.Controls.Add(this.txtResta);
            this.grpExamen.Controls.Add(this.txtSuma);
            this.grpExamen.Controls.Add(this.label17);
            this.grpExamen.Controls.Add(this.label16);
            this.grpExamen.Controls.Add(this.label15);
            this.grpExamen.Controls.Add(this.label14);
            this.grpExamen.Controls.Add(this.lblDivisor);
            this.grpExamen.Controls.Add(this.lblDividendo);
            this.grpExamen.Controls.Add(this.lblFactor2);
            this.grpExamen.Controls.Add(this.lblSustraendo);
            this.grpExamen.Controls.Add(this.lblMinuendo);
            this.grpExamen.Controls.Add(this.lblFactor1);
            this.grpExamen.Controls.Add(this.lblResta);
            this.grpExamen.Controls.Add(this.lblMultiplicacion);
            this.grpExamen.Controls.Add(this.lblDivision);
            this.grpExamen.Controls.Add(this.lblSuma);
            this.grpExamen.Controls.Add(this.lblSumando2);
            this.grpExamen.Controls.Add(this.lblSumando1);
            this.grpExamen.Location = new System.Drawing.Point(12, 214);
            this.grpExamen.Name = "grpExamen";
            this.grpExamen.Size = new System.Drawing.Size(721, 378);
            this.grpExamen.TabIndex = 6;
            this.grpExamen.TabStop = false;
            this.grpExamen.Text = "Examen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cociente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Residuo";
            // 
            // txtResiduo
            // 
            this.txtResiduo.Enabled = false;
            this.txtResiduo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtResiduo.Location = new System.Drawing.Point(531, 254);
            this.txtResiduo.Name = "txtResiduo";
            this.txtResiduo.Size = new System.Drawing.Size(65, 35);
            this.txtResiduo.TabIndex = 21;
            // 
            // btnTerminar
            // 
            this.btnTerminar.Enabled = false;
            this.btnTerminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnTerminar.Location = new System.Drawing.Point(470, 330);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(243, 42);
            this.btnTerminar.TabIndex = 20;
            this.btnTerminar.Text = "Terminar Prueba";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // txtDivision
            // 
            this.txtDivision.Enabled = false;
            this.txtDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtDivision.Location = new System.Drawing.Point(447, 257);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(65, 35);
            this.txtDivision.TabIndex = 19;
            // 
            // txtMultiplicacion
            // 
            this.txtMultiplicacion.Enabled = false;
            this.txtMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtMultiplicacion.Location = new System.Drawing.Point(447, 197);
            this.txtMultiplicacion.Name = "txtMultiplicacion";
            this.txtMultiplicacion.Size = new System.Drawing.Size(65, 35);
            this.txtMultiplicacion.TabIndex = 18;
            // 
            // txtResta
            // 
            this.txtResta.Enabled = false;
            this.txtResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtResta.Location = new System.Drawing.Point(447, 134);
            this.txtResta.Name = "txtResta";
            this.txtResta.Size = new System.Drawing.Size(65, 35);
            this.txtResta.TabIndex = 17;
            // 
            // txtSuma
            // 
            this.txtSuma.Enabled = false;
            this.txtSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtSuma.Location = new System.Drawing.Point(447, 79);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(65, 35);
            this.txtSuma.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label17.Location = new System.Drawing.Point(347, 257);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 29);
            this.label17.TabIndex = 15;
            this.label17.Text = "=";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label16.Location = new System.Drawing.Point(347, 200);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 29);
            this.label16.TabIndex = 14;
            this.label16.Text = "=";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label15.Location = new System.Drawing.Point(347, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 29);
            this.label15.TabIndex = 13;
            this.label15.Text = "=";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label14.Location = new System.Drawing.Point(347, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 29);
            this.label14.TabIndex = 12;
            this.label14.Text = "=";
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblDivisor.Location = new System.Drawing.Point(220, 257);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(27, 29);
            this.lblDivisor.TabIndex = 11;
            this.lblDivisor.Text = "?";
            // 
            // lblDividendo
            // 
            this.lblDividendo.AutoSize = true;
            this.lblDividendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblDividendo.Location = new System.Drawing.Point(95, 257);
            this.lblDividendo.Name = "lblDividendo";
            this.lblDividendo.Size = new System.Drawing.Size(27, 29);
            this.lblDividendo.TabIndex = 10;
            this.lblDividendo.Text = "?";
            // 
            // lblFactor2
            // 
            this.lblFactor2.AutoSize = true;
            this.lblFactor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblFactor2.Location = new System.Drawing.Point(220, 200);
            this.lblFactor2.Name = "lblFactor2";
            this.lblFactor2.Size = new System.Drawing.Size(27, 29);
            this.lblFactor2.TabIndex = 9;
            this.lblFactor2.Text = "?";
            // 
            // lblSustraendo
            // 
            this.lblSustraendo.AutoSize = true;
            this.lblSustraendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblSustraendo.Location = new System.Drawing.Point(220, 140);
            this.lblSustraendo.Name = "lblSustraendo";
            this.lblSustraendo.Size = new System.Drawing.Size(27, 29);
            this.lblSustraendo.TabIndex = 8;
            this.lblSustraendo.Text = "?";
            // 
            // lblMinuendo
            // 
            this.lblMinuendo.AutoSize = true;
            this.lblMinuendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblMinuendo.Location = new System.Drawing.Point(95, 140);
            this.lblMinuendo.Name = "lblMinuendo";
            this.lblMinuendo.Size = new System.Drawing.Size(27, 29);
            this.lblMinuendo.TabIndex = 7;
            this.lblMinuendo.Text = "?";
            // 
            // lblFactor1
            // 
            this.lblFactor1.AutoSize = true;
            this.lblFactor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblFactor1.Location = new System.Drawing.Point(95, 200);
            this.lblFactor1.Name = "lblFactor1";
            this.lblFactor1.Size = new System.Drawing.Size(27, 29);
            this.lblFactor1.TabIndex = 6;
            this.lblFactor1.Text = "?";
            // 
            // lblResta
            // 
            this.lblResta.AutoSize = true;
            this.lblResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblResta.Location = new System.Drawing.Point(157, 140);
            this.lblResta.Name = "lblResta";
            this.lblResta.Size = new System.Drawing.Size(21, 29);
            this.lblResta.TabIndex = 5;
            this.lblResta.Text = "-";
            // 
            // lblMultiplicacion
            // 
            this.lblMultiplicacion.AutoSize = true;
            this.lblMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblMultiplicacion.Location = new System.Drawing.Point(155, 200);
            this.lblMultiplicacion.Name = "lblMultiplicacion";
            this.lblMultiplicacion.Size = new System.Drawing.Size(23, 29);
            this.lblMultiplicacion.TabIndex = 4;
            this.lblMultiplicacion.Text = "*";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblDivision.Location = new System.Drawing.Point(155, 257);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(20, 29);
            this.lblDivision.TabIndex = 3;
            this.lblDivision.Text = "/";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblSuma.Location = new System.Drawing.Point(155, 82);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(28, 29);
            this.lblSuma.TabIndex = 2;
            this.lblSuma.Text = "+";
            // 
            // lblSumando2
            // 
            this.lblSumando2.AutoSize = true;
            this.lblSumando2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblSumando2.Location = new System.Drawing.Point(220, 82);
            this.lblSumando2.Name = "lblSumando2";
            this.lblSumando2.Size = new System.Drawing.Size(27, 29);
            this.lblSumando2.TabIndex = 1;
            this.lblSumando2.Text = "?";
            // 
            // lblSumando1
            // 
            this.lblSumando1.AutoSize = true;
            this.lblSumando1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblSumando1.Location = new System.Drawing.Point(95, 82);
            this.lblSumando1.Name = "lblSumando1";
            this.lblSumando1.Size = new System.Drawing.Size(27, 29);
            this.lblSumando1.TabIndex = 0;
            this.lblSumando1.Text = "?";
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Interval = 1000;
            this.tmrHora.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrTiempoRestante
            // 
            this.tmrTiempoRestante.Interval = 1000;
            this.tmrTiempoRestante.Tick += new System.EventHandler(this.tmrTiempoRestante_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 604);
            this.Controls.Add(this.grpExamen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtTiempoRestante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpExamen.ResumeLayout(false);
            this.grpExamen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTiempoRestante;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpExamen;
        private System.Windows.Forms.TextBox txtDivision;
        private System.Windows.Forms.TextBox txtMultiplicacion;
        private System.Windows.Forms.TextBox txtResta;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.Label lblDividendo;
        private System.Windows.Forms.Label lblFactor2;
        private System.Windows.Forms.Label lblSustraendo;
        private System.Windows.Forms.Label lblMinuendo;
        private System.Windows.Forms.Label lblFactor1;
        private System.Windows.Forms.Label lblResta;
        private System.Windows.Forms.Label lblMultiplicacion;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblSumando2;
        private System.Windows.Forms.Label lblSumando1;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.Timer tmrTiempoRestante;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResiduo;
    }
}

