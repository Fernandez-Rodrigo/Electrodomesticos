
namespace Electro
{
    partial class Form1
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
            this.lvlTipo = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnPrecio = new System.Windows.Forms.Button();
            this.lblTítulo = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.txtPrecioB = new System.Windows.Forms.TextBox();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.txtAgregar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSacar = new System.Windows.Forms.TextBox();
            this.btnSacar = new System.Windows.Forms.Button();
            this.lblCarga = new System.Windows.Forms.Label();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.rdF = new System.Windows.Forms.RadioButton();
            this.grpConsumo = new System.Windows.Forms.GroupBox();
            this.rdA = new System.Windows.Forms.RadioButton();
            this.rdE = new System.Windows.Forms.RadioButton();
            this.rdD = new System.Windows.Forms.RadioButton();
            this.rdB = new System.Windows.Forms.RadioButton();
            this.rdC = new System.Windows.Forms.RadioButton();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.rdNegro = new System.Windows.Forms.RadioButton();
            this.rdRojo = new System.Windows.Forms.RadioButton();
            this.rdGris = new System.Windows.Forms.RadioButton();
            this.rdAzul = new System.Windows.Forms.RadioButton();
            this.rdBlanco = new System.Windows.Forms.RadioButton();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.radTv = new System.Windows.Forms.RadioButton();
            this.radLava = new System.Windows.Forms.RadioButton();
            this.rdSi = new System.Windows.Forms.RadioButton();
            this.rdNo = new System.Windows.Forms.RadioButton();
            this.grpSint = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResol = new System.Windows.Forms.TextBox();
            this.grpConsumo.SuspendLayout();
            this.grpColor.SuspendLayout();
            this.grpTipo.SuspendLayout();
            this.grpSint.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvlTipo
            // 
            this.lvlTipo.AutoSize = true;
            this.lvlTipo.Location = new System.Drawing.Point(12, 52);
            this.lvlTipo.Name = "lvlTipo";
            this.lvlTipo.Size = new System.Drawing.Size(141, 15);
            this.lvlTipo.TabIndex = 0;
            this.lvlTipo.Text = "Tipo de electrodoméstico";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(204, 131);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 23);
            this.txtPeso.TabIndex = 1;
            // 
            // btnPrecio
            // 
            this.btnPrecio.Location = new System.Drawing.Point(588, 323);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(124, 48);
            this.btnPrecio.TabIndex = 2;
            this.btnPrecio.Text = "Calcular Precio";
            this.btnPrecio.UseVisualStyleBackColor = true;
            this.btnPrecio.Click += new System.EventHandler(this.btnPrecio_Click);
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTítulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTítulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTítulo.Location = new System.Drawing.Point(12, 9);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(366, 23);
            this.lblTítulo.TabIndex = 3;
            this.lblTítulo.Text = "CÁLCULO DE PRECIO DE ELECTRODOMESTICOS";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(204, 113);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(32, 15);
            this.lblPeso.TabIndex = 9;
            this.lblPeso.Text = "Peso";
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Location = new System.Drawing.Point(204, 164);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(67, 15);
            this.lblPrecioBase.TabIndex = 10;
            this.lblPrecioBase.Text = "Precio base";
            // 
            // txtPrecioB
            // 
            this.txtPrecioB.Location = new System.Drawing.Point(204, 181);
            this.txtPrecioB.Name = "txtPrecioB";
            this.txtPrecioB.Size = new System.Drawing.Size(100, 23);
            this.txtPrecioB.TabIndex = 11;
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Location = new System.Drawing.Point(204, 52);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(144, 15);
            this.lblAgregar.TabIndex = 15;
            this.lblAgregar.Text = "Agregar Electrodoméstico";
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(204, 70);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(144, 23);
            this.txtAgregar.TabIndex = 16;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(354, 69);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 23);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar al listado";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quitar Electrodoméstico";
            // 
            // txtSacar
            // 
            this.txtSacar.Location = new System.Drawing.Point(488, 70);
            this.txtSacar.Name = "txtSacar";
            this.txtSacar.Size = new System.Drawing.Size(144, 23);
            this.txtSacar.TabIndex = 19;
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(638, 70);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(117, 23);
            this.btnSacar.TabIndex = 20;
            this.btnSacar.Text = "Sacar de listado";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // lblCarga
            // 
            this.lblCarga.AutoSize = true;
            this.lblCarga.Location = new System.Drawing.Point(204, 214);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(38, 15);
            this.lblCarga.TabIndex = 21;
            this.lblCarga.Text = "Carga";
            // 
            // txtCarga
            // 
            this.txtCarga.Enabled = false;
            this.txtCarga.Location = new System.Drawing.Point(204, 231);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(100, 23);
            this.txtCarga.TabIndex = 22;
            // 
            // rdF
            // 
            this.rdF.AutoSize = true;
            this.rdF.Checked = true;
            this.rdF.Location = new System.Drawing.Point(12, 22);
            this.rdF.Name = "rdF";
            this.rdF.Size = new System.Drawing.Size(31, 19);
            this.rdF.TabIndex = 24;
            this.rdF.TabStop = true;
            this.rdF.Text = "F";
            this.rdF.UseVisualStyleBackColor = true;
            // 
            // grpConsumo
            // 
            this.grpConsumo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpConsumo.Controls.Add(this.rdA);
            this.grpConsumo.Controls.Add(this.rdE);
            this.grpConsumo.Controls.Add(this.rdD);
            this.grpConsumo.Controls.Add(this.rdB);
            this.grpConsumo.Controls.Add(this.rdC);
            this.grpConsumo.Controls.Add(this.rdF);
            this.grpConsumo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpConsumo.Location = new System.Drawing.Point(527, 113);
            this.grpConsumo.Name = "grpConsumo";
            this.grpConsumo.Size = new System.Drawing.Size(105, 177);
            this.grpConsumo.TabIndex = 25;
            this.grpConsumo.TabStop = false;
            this.grpConsumo.Text = "Consumo";
            // 
            // rdA
            // 
            this.rdA.AutoSize = true;
            this.rdA.Location = new System.Drawing.Point(12, 147);
            this.rdA.Name = "rdA";
            this.rdA.Size = new System.Drawing.Size(33, 19);
            this.rdA.TabIndex = 29;
            this.rdA.Text = "A";
            this.rdA.UseVisualStyleBackColor = true;
            // 
            // rdE
            // 
            this.rdE.AutoSize = true;
            this.rdE.Location = new System.Drawing.Point(12, 47);
            this.rdE.Name = "rdE";
            this.rdE.Size = new System.Drawing.Size(31, 19);
            this.rdE.TabIndex = 28;
            this.rdE.Text = "E";
            this.rdE.UseVisualStyleBackColor = true;
            // 
            // rdD
            // 
            this.rdD.AutoSize = true;
            this.rdD.Location = new System.Drawing.Point(12, 72);
            this.rdD.Name = "rdD";
            this.rdD.Size = new System.Drawing.Size(34, 19);
            this.rdD.TabIndex = 27;
            this.rdD.Text = "D";
            this.rdD.UseVisualStyleBackColor = true;
            // 
            // rdB
            // 
            this.rdB.AutoSize = true;
            this.rdB.Location = new System.Drawing.Point(12, 122);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(33, 19);
            this.rdB.TabIndex = 26;
            this.rdB.Text = "B";
            this.rdB.UseVisualStyleBackColor = true;
            // 
            // rdC
            // 
            this.rdC.AutoSize = true;
            this.rdC.Location = new System.Drawing.Point(12, 97);
            this.rdC.Name = "rdC";
            this.rdC.Size = new System.Drawing.Size(32, 19);
            this.rdC.TabIndex = 25;
            this.rdC.Text = "C";
            this.rdC.UseVisualStyleBackColor = true;
            // 
            // grpColor
            // 
            this.grpColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpColor.Controls.Add(this.rdNegro);
            this.grpColor.Controls.Add(this.rdRojo);
            this.grpColor.Controls.Add(this.rdGris);
            this.grpColor.Controls.Add(this.rdAzul);
            this.grpColor.Controls.Add(this.rdBlanco);
            this.grpColor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpColor.Location = new System.Drawing.Point(650, 113);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(105, 143);
            this.grpColor.TabIndex = 30;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color";
            // 
            // rdNegro
            // 
            this.rdNegro.AutoSize = true;
            this.rdNegro.Location = new System.Drawing.Point(12, 47);
            this.rdNegro.Name = "rdNegro";
            this.rdNegro.Size = new System.Drawing.Size(60, 19);
            this.rdNegro.TabIndex = 28;
            this.rdNegro.Text = "Negro";
            this.rdNegro.UseVisualStyleBackColor = true;
            // 
            // rdRojo
            // 
            this.rdRojo.AutoSize = true;
            this.rdRojo.Location = new System.Drawing.Point(12, 72);
            this.rdRojo.Name = "rdRojo";
            this.rdRojo.Size = new System.Drawing.Size(50, 19);
            this.rdRojo.TabIndex = 27;
            this.rdRojo.Text = "Rojo";
            this.rdRojo.UseVisualStyleBackColor = true;
            // 
            // rdGris
            // 
            this.rdGris.AutoSize = true;
            this.rdGris.Location = new System.Drawing.Point(12, 122);
            this.rdGris.Name = "rdGris";
            this.rdGris.Size = new System.Drawing.Size(47, 19);
            this.rdGris.TabIndex = 26;
            this.rdGris.Text = "Gris";
            this.rdGris.UseVisualStyleBackColor = true;
            // 
            // rdAzul
            // 
            this.rdAzul.AutoSize = true;
            this.rdAzul.Location = new System.Drawing.Point(12, 97);
            this.rdAzul.Name = "rdAzul";
            this.rdAzul.Size = new System.Drawing.Size(49, 19);
            this.rdAzul.TabIndex = 25;
            this.rdAzul.Text = "Azul";
            this.rdAzul.UseVisualStyleBackColor = true;
            // 
            // rdBlanco
            // 
            this.rdBlanco.AutoSize = true;
            this.rdBlanco.Checked = true;
            this.rdBlanco.Location = new System.Drawing.Point(12, 22);
            this.rdBlanco.Name = "rdBlanco";
            this.rdBlanco.Size = new System.Drawing.Size(62, 19);
            this.rdBlanco.TabIndex = 24;
            this.rdBlanco.TabStop = true;
            this.rdBlanco.Text = "Blanco";
            this.rdBlanco.UseVisualStyleBackColor = true;
            // 
            // grpTipo
            // 
            this.grpTipo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpTipo.Controls.Add(this.radTv);
            this.grpTipo.Controls.Add(this.radLava);
            this.grpTipo.Location = new System.Drawing.Point(12, 75);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(163, 215);
            this.grpTipo.TabIndex = 31;
            this.grpTipo.TabStop = false;
            // 
            // radTv
            // 
            this.radTv.AutoSize = true;
            this.radTv.Location = new System.Drawing.Point(6, 12);
            this.radTv.Name = "radTv";
            this.radTv.Size = new System.Drawing.Size(76, 19);
            this.radTv.TabIndex = 32;
            this.radTv.TabStop = true;
            this.radTv.Text = "Television";
            this.radTv.UseVisualStyleBackColor = true;
            this.radTv.CheckedChanged += new System.EventHandler(this.radTv_CheckedChanged);
            // 
            // radLava
            // 
            this.radLava.AutoSize = true;
            this.radLava.Location = new System.Drawing.Point(6, 37);
            this.radLava.Name = "radLava";
            this.radLava.Size = new System.Drawing.Size(73, 19);
            this.radLava.TabIndex = 32;
            this.radLava.TabStop = true;
            this.radLava.Text = "Lavadora";
            this.radLava.UseVisualStyleBackColor = true;
            this.radLava.CheckedChanged += new System.EventHandler(this.radLava_CheckedChanged);
            // 
            // rdSi
            // 
            this.rdSi.AutoSize = true;
            this.rdSi.Checked = true;
            this.rdSi.Location = new System.Drawing.Point(12, 22);
            this.rdSi.Name = "rdSi";
            this.rdSi.Size = new System.Drawing.Size(58, 19);
            this.rdSi.TabIndex = 24;
            this.rdSi.TabStop = true;
            this.rdSi.Text = "Posee";
            this.rdSi.UseVisualStyleBackColor = true;
            // 
            // rdNo
            // 
            this.rdNo.AutoSize = true;
            this.rdNo.Location = new System.Drawing.Point(76, 22);
            this.rdNo.Name = "rdNo";
            this.rdNo.Size = new System.Drawing.Size(77, 19);
            this.rdNo.TabIndex = 28;
            this.rdNo.Text = "No posee";
            this.rdNo.UseVisualStyleBackColor = true;
            // 
            // grpSint
            // 
            this.grpSint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpSint.Controls.Add(this.rdNo);
            this.grpSint.Controls.Add(this.rdSi);
            this.grpSint.Enabled = false;
            this.grpSint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpSint.Location = new System.Drawing.Point(204, 323);
            this.grpSint.Name = "grpSint";
            this.grpSint.Size = new System.Drawing.Size(201, 47);
            this.grpSint.TabIndex = 31;
            this.grpSint.TabStop = false;
            this.grpSint.Text = "Sintonizador TDT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Resolución";
            // 
            // txtResol
            // 
            this.txtResol.Enabled = false;
            this.txtResol.Location = new System.Drawing.Point(204, 293);
            this.txtResol.Name = "txtResol";
            this.txtResol.Size = new System.Drawing.Size(100, 23);
            this.txtResol.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpSint);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.grpConsumo);
            this.Controls.Add(this.txtCarga);
            this.Controls.Add(this.lblCarga);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.txtSacar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtAgregar);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.txtPrecioB);
            this.Controls.Add(this.lblPrecioBase);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblTítulo);
            this.Controls.Add(this.btnPrecio);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lvlTipo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpConsumo.ResumeLayout(false);
            this.grpConsumo.PerformLayout();
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.grpSint.ResumeLayout(false);
            this.grpSint.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvlTipo;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnPrecio;
        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblPrecioBase;
        private System.Windows.Forms.TextBox txtPrecioB;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.TextBox txtAgregar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSacar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Label lblCarga;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.RadioButton rdF;
        private System.Windows.Forms.GroupBox grpConsumo;
        private System.Windows.Forms.RadioButton rdA;
        private System.Windows.Forms.RadioButton rdE;
        private System.Windows.Forms.RadioButton rdD;
        private System.Windows.Forms.RadioButton rdB;
        private System.Windows.Forms.RadioButton rdC;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.RadioButton rdNegro;
        private System.Windows.Forms.RadioButton rdRojo;
        private System.Windows.Forms.RadioButton rdGris;
        private System.Windows.Forms.RadioButton rdAzul;
        private System.Windows.Forms.RadioButton rdBlanco;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton radTv;
        private System.Windows.Forms.RadioButton radLava;
        private System.Windows.Forms.RadioButton rdSi;
        private System.Windows.Forms.RadioButton rdNo;
        private System.Windows.Forms.GroupBox grpSint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResol;
    }
}

