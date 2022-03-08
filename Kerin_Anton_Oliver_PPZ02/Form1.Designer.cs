namespace Kerin_Anton_Oliver_PPZ02
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
            this.rdbGazirano = new System.Windows.Forms.RadioButton();
            this.rdbNegazirano = new System.Windows.Forms.RadioButton();
            this.rdbAlkoholno = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKolicina = new System.Windows.Forms.ComboBox();
            this.cmbPakiranje = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trckPostotak = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.rtbIspis = new System.Windows.Forms.RichTextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.lblPostotak = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trckPostotak)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbGazirano
            // 
            this.rdbGazirano.AutoSize = true;
            this.rdbGazirano.Location = new System.Drawing.Point(23, 25);
            this.rdbGazirano.Name = "rdbGazirano";
            this.rdbGazirano.Size = new System.Drawing.Size(67, 17);
            this.rdbGazirano.TabIndex = 0;
            this.rdbGazirano.TabStop = true;
            this.rdbGazirano.Text = "Gazirano";
            this.rdbGazirano.UseVisualStyleBackColor = true;
            this.rdbGazirano.CheckedChanged += new System.EventHandler(this.rdbGazirano_CheckedChanged);
            // 
            // rdbNegazirano
            // 
            this.rdbNegazirano.AutoSize = true;
            this.rdbNegazirano.Location = new System.Drawing.Point(23, 48);
            this.rdbNegazirano.Name = "rdbNegazirano";
            this.rdbNegazirano.Size = new System.Drawing.Size(79, 17);
            this.rdbNegazirano.TabIndex = 1;
            this.rdbNegazirano.TabStop = true;
            this.rdbNegazirano.Text = "Negazirano";
            this.rdbNegazirano.UseVisualStyleBackColor = true;
            this.rdbNegazirano.CheckedChanged += new System.EventHandler(this.rdbNegazirano_CheckedChanged);
            // 
            // rdbAlkoholno
            // 
            this.rdbAlkoholno.AutoSize = true;
            this.rdbAlkoholno.Location = new System.Drawing.Point(23, 71);
            this.rdbAlkoholno.Name = "rdbAlkoholno";
            this.rdbAlkoholno.Size = new System.Drawing.Size(72, 17);
            this.rdbAlkoholno.TabIndex = 2;
            this.rdbAlkoholno.TabStop = true;
            this.rdbAlkoholno.Text = "Alkoholno";
            this.rdbAlkoholno.UseVisualStyleBackColor = true;
            this.rdbAlkoholno.CheckedChanged += new System.EventHandler(this.rdbAlkoholno_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vrsta pića:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(72, 105);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(121, 20);
            this.txtNaziv.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naziv:";
            // 
            // cmbKolicina
            // 
            this.cmbKolicina.FormattingEnabled = true;
            this.cmbKolicina.Items.AddRange(new object[] {
            "0.5L",
            "1L",
            "1.5L",
            "2L"});
            this.cmbKolicina.Location = new System.Drawing.Point(72, 131);
            this.cmbKolicina.Name = "cmbKolicina";
            this.cmbKolicina.Size = new System.Drawing.Size(121, 21);
            this.cmbKolicina.TabIndex = 6;
            // 
            // cmbPakiranje
            // 
            this.cmbPakiranje.FormattingEnabled = true;
            this.cmbPakiranje.Items.AddRange(new object[] {
            "staklo",
            "PET",
            "tetrapak"});
            this.cmbPakiranje.Location = new System.Drawing.Point(72, 158);
            this.cmbPakiranje.Name = "cmbPakiranje";
            this.cmbPakiranje.Size = new System.Drawing.Size(121, 21);
            this.cmbPakiranje.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Količina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pakiranje:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Alkoholni udio (%):";
            // 
            // trckPostotak
            // 
            this.trckPostotak.LargeChange = 1;
            this.trckPostotak.Location = new System.Drawing.Point(15, 219);
            this.trckPostotak.Maximum = 40;
            this.trckPostotak.Name = "trckPostotak";
            this.trckPostotak.Size = new System.Drawing.Size(178, 45);
            this.trckPostotak.TabIndex = 11;
            this.trckPostotak.Scroll += new System.EventHandler(this.trckPostotak_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cijena:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(57, 268);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(136, 20);
            this.txtCijena.TabIndex = 13;
            // 
            // rtbIspis
            // 
            this.rtbIspis.Location = new System.Drawing.Point(223, 9);
            this.rtbIspis.Name = "rtbIspis";
            this.rtbIspis.Size = new System.Drawing.Size(418, 279);
            this.rtbIspis.TabIndex = 14;
            this.rtbIspis.Text = "";
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(23, 315);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(237, 80);
            this.btnUnos.TabIndex = 15;
            this.btnUnos.Text = "Unesi";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(397, 315);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(231, 80);
            this.btnIspis.TabIndex = 16;
            this.btnIspis.Text = "Ispiši";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // lblPostotak
            // 
            this.lblPostotak.AutoSize = true;
            this.lblPostotak.Location = new System.Drawing.Point(113, 192);
            this.lblPostotak.Name = "lblPostotak";
            this.lblPostotak.Size = new System.Drawing.Size(0, 13);
            this.lblPostotak.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 418);
            this.Controls.Add(this.lblPostotak);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.rtbIspis);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trckPostotak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPakiranje);
            this.Controls.Add(this.cmbKolicina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbAlkoholno);
            this.Controls.Add(this.rdbNegazirano);
            this.Controls.Add(this.rdbGazirano);
            this.Name = "Form1";
            this.Text = "Pića";
            ((System.ComponentModel.ISupportInitialize)(this.trckPostotak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbGazirano;
        private System.Windows.Forms.RadioButton rdbNegazirano;
        private System.Windows.Forms.RadioButton rdbAlkoholno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKolicina;
        private System.Windows.Forms.ComboBox cmbPakiranje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trckPostotak;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.RichTextBox rtbIspis;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Label lblPostotak;
    }
}

