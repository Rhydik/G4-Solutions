namespace PresentationLayer1.Forms
{
    partial class frmProdukter
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRensa = new System.Windows.Forms.Button();
            this.btnSök = new System.Windows.Forms.Button();
            this.cmbVäljAvdelning = new System.Windows.Forms.ComboBox();
            this.tbProdukt = new System.Windows.Forms.TextBox();
            this.tbProduktID = new System.Windows.Forms.TextBox();
            this.btnRegistreraNyProdukt = new System.Windows.Forms.Button();
            this.btnRedigeraProdukt = new System.Windows.Forms.Button();
            this.dgvProdukter = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResultat = new System.Windows.Forms.Button();
            this.btnPrognostiseringIntäkter = new System.Windows.Forms.Button();
            this.btnBudgeteratResultat = new System.Windows.Forms.Button();
            this.btnKostnadsbudgetering = new System.Windows.Forms.Button();
            this.btnIntäktsbudgeteringProdukt = new System.Windows.Forms.Button();
            this.btnIntäktsbudgeteringKund = new System.Windows.Forms.Button();
            this.btnBehörighet = new System.Windows.Forms.Button();
            this.btnSchablonkostnad = new System.Windows.Forms.Button();
            this.btnAktiviteter = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnProdukter = new System.Windows.Forms.Button();
            this.btnKunder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProduktgrupp = new System.Windows.Forms.ComboBox();
            this.cmbProduktKategori = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukter)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(873, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Avdelning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Produkt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "ProduktID";
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(417, 101);
            this.btnRensa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(80, 28);
            this.btnRensa.TabIndex = 29;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            this.btnRensa.Click += new System.EventHandler(this.btnRensa_Click);
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(328, 101);
            this.btnSök.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(80, 28);
            this.btnSök.TabIndex = 28;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            this.btnSök.Click += new System.EventHandler(this.btnSök_Click);
            // 
            // cmbVäljAvdelning
            // 
            this.cmbVäljAvdelning.FormattingEnabled = true;
            this.cmbVäljAvdelning.Location = new System.Drawing.Point(889, 60);
            this.cmbVäljAvdelning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbVäljAvdelning.Name = "cmbVäljAvdelning";
            this.cmbVäljAvdelning.Size = new System.Drawing.Size(236, 24);
            this.cmbVäljAvdelning.TabIndex = 27;
            this.cmbVäljAvdelning.Text = "Välj avdelning";
            // 
            // tbProdukt
            // 
            this.tbProdukt.Location = new System.Drawing.Point(460, 63);
            this.tbProdukt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbProdukt.Name = "tbProdukt";
            this.tbProdukt.Size = new System.Drawing.Size(124, 22);
            this.tbProdukt.TabIndex = 26;
            // 
            // tbProduktID
            // 
            this.tbProduktID.Location = new System.Drawing.Point(327, 63);
            this.tbProduktID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbProduktID.Name = "tbProduktID";
            this.tbProduktID.Size = new System.Drawing.Size(124, 22);
            this.tbProduktID.TabIndex = 25;
            // 
            // btnRegistreraNyProdukt
            // 
            this.btnRegistreraNyProdukt.Location = new System.Drawing.Point(847, 444);
            this.btnRegistreraNyProdukt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistreraNyProdukt.Name = "btnRegistreraNyProdukt";
            this.btnRegistreraNyProdukt.Size = new System.Drawing.Size(149, 49);
            this.btnRegistreraNyProdukt.TabIndex = 24;
            this.btnRegistreraNyProdukt.Text = "Registrera ny produkt";
            this.btnRegistreraNyProdukt.UseVisualStyleBackColor = true;
            this.btnRegistreraNyProdukt.Click += new System.EventHandler(this.btnRegistreraNyProdukt_Click);
            // 
            // btnRedigeraProdukt
            // 
            this.btnRedigeraProdukt.Location = new System.Drawing.Point(679, 444);
            this.btnRedigeraProdukt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRedigeraProdukt.Name = "btnRedigeraProdukt";
            this.btnRedigeraProdukt.Size = new System.Drawing.Size(160, 50);
            this.btnRedigeraProdukt.TabIndex = 23;
            this.btnRedigeraProdukt.Text = "Redigera produkt";
            this.btnRedigeraProdukt.UseVisualStyleBackColor = true;
            this.btnRedigeraProdukt.Click += new System.EventHandler(this.btnRedigeraProdukt_Click);
            // 
            // dgvProdukter
            // 
            this.dgvProdukter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukter.Location = new System.Drawing.Point(328, 145);
            this.dgvProdukter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProdukter.Name = "dgvProdukter";
            this.dgvProdukter.RowHeadersWidth = 62;
            this.dgvProdukter.Size = new System.Drawing.Size(752, 292);
            this.dgvProdukter.TabIndex = 20;
            this.dgvProdukter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdukter_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResultat);
            this.panel1.Controls.Add(this.btnPrognostiseringIntäkter);
            this.panel1.Controls.Add(this.btnBudgeteratResultat);
            this.panel1.Controls.Add(this.btnKostnadsbudgetering);
            this.panel1.Controls.Add(this.btnIntäktsbudgeteringProdukt);
            this.panel1.Controls.Add(this.btnIntäktsbudgeteringKund);
            this.panel1.Controls.Add(this.btnBehörighet);
            this.panel1.Controls.Add(this.btnSchablonkostnad);
            this.panel1.Controls.Add(this.btnAktiviteter);
            this.panel1.Controls.Add(this.btnPersonal);
            this.panel1.Controls.Add(this.btnProdukter);
            this.panel1.Controls.Add(this.btnKunder);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 532);
            this.panel1.TabIndex = 33;
            // 
            // btnResultat
            // 
            this.btnResultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultat.Location = new System.Drawing.Point(20, 469);
            this.btnResultat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResultat.Name = "btnResultat";
            this.btnResultat.Size = new System.Drawing.Size(100, 28);
            this.btnResultat.TabIndex = 2;
            this.btnResultat.Text = "Resultat";
            this.btnResultat.UseVisualStyleBackColor = true;
            // 
            // btnPrognostiseringIntäkter
            // 
            this.btnPrognostiseringIntäkter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrognostiseringIntäkter.Location = new System.Drawing.Point(20, 433);
            this.btnPrognostiseringIntäkter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrognostiseringIntäkter.Name = "btnPrognostiseringIntäkter";
            this.btnPrognostiseringIntäkter.Size = new System.Drawing.Size(188, 28);
            this.btnPrognostiseringIntäkter.TabIndex = 2;
            this.btnPrognostiseringIntäkter.Text = "Prognostisering intäkter";
            this.btnPrognostiseringIntäkter.UseVisualStyleBackColor = true;
            // 
            // btnBudgeteratResultat
            // 
            this.btnBudgeteratResultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBudgeteratResultat.Location = new System.Drawing.Point(20, 396);
            this.btnBudgeteratResultat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBudgeteratResultat.Name = "btnBudgeteratResultat";
            this.btnBudgeteratResultat.Size = new System.Drawing.Size(164, 28);
            this.btnBudgeteratResultat.TabIndex = 2;
            this.btnBudgeteratResultat.Text = "Budgeterat Resultat";
            this.btnBudgeteratResultat.UseVisualStyleBackColor = true;
            // 
            // btnKostnadsbudgetering
            // 
            this.btnKostnadsbudgetering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKostnadsbudgetering.Location = new System.Drawing.Point(20, 337);
            this.btnKostnadsbudgetering.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKostnadsbudgetering.Name = "btnKostnadsbudgetering";
            this.btnKostnadsbudgetering.Size = new System.Drawing.Size(211, 28);
            this.btnKostnadsbudgetering.TabIndex = 2;
            this.btnKostnadsbudgetering.Text = "Kostnadsbudgetering";
            this.btnKostnadsbudgetering.UseVisualStyleBackColor = true;
            // 
            // btnIntäktsbudgeteringProdukt
            // 
            this.btnIntäktsbudgeteringProdukt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntäktsbudgeteringProdukt.Location = new System.Drawing.Point(20, 302);
            this.btnIntäktsbudgeteringProdukt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIntäktsbudgeteringProdukt.Name = "btnIntäktsbudgeteringProdukt";
            this.btnIntäktsbudgeteringProdukt.Size = new System.Drawing.Size(211, 28);
            this.btnIntäktsbudgeteringProdukt.TabIndex = 2;
            this.btnIntäktsbudgeteringProdukt.Text = "Intäktsbudgetering Produkt";
            this.btnIntäktsbudgeteringProdukt.UseVisualStyleBackColor = true;
            // 
            // btnIntäktsbudgeteringKund
            // 
            this.btnIntäktsbudgeteringKund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntäktsbudgeteringKund.Location = new System.Drawing.Point(20, 266);
            this.btnIntäktsbudgeteringKund.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIntäktsbudgeteringKund.Name = "btnIntäktsbudgeteringKund";
            this.btnIntäktsbudgeteringKund.Size = new System.Drawing.Size(211, 28);
            this.btnIntäktsbudgeteringKund.TabIndex = 3;
            this.btnIntäktsbudgeteringKund.Text = "Intäktsbudgetering Kund";
            this.btnIntäktsbudgeteringKund.UseVisualStyleBackColor = true;
            // 
            // btnBehörighet
            // 
            this.btnBehörighet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBehörighet.Location = new System.Drawing.Point(20, 208);
            this.btnBehörighet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBehörighet.Name = "btnBehörighet";
            this.btnBehörighet.Size = new System.Drawing.Size(143, 28);
            this.btnBehörighet.TabIndex = 2;
            this.btnBehörighet.Text = "Behörighet";
            this.btnBehörighet.UseVisualStyleBackColor = true;
            // 
            // btnSchablonkostnad
            // 
            this.btnSchablonkostnad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchablonkostnad.Location = new System.Drawing.Point(20, 172);
            this.btnSchablonkostnad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSchablonkostnad.Name = "btnSchablonkostnad";
            this.btnSchablonkostnad.Size = new System.Drawing.Size(143, 28);
            this.btnSchablonkostnad.TabIndex = 2;
            this.btnSchablonkostnad.Text = "Schablonkostnad";
            this.btnSchablonkostnad.UseVisualStyleBackColor = true;
            // 
            // btnAktiviteter
            // 
            this.btnAktiviteter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktiviteter.Location = new System.Drawing.Point(20, 135);
            this.btnAktiviteter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAktiviteter.Name = "btnAktiviteter";
            this.btnAktiviteter.Size = new System.Drawing.Size(143, 28);
            this.btnAktiviteter.TabIndex = 2;
            this.btnAktiviteter.Text = "Aktiviteter";
            this.btnAktiviteter.UseVisualStyleBackColor = true;
            // 
            // btnPersonal
            // 
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.Location = new System.Drawing.Point(20, 101);
            this.btnPersonal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(143, 28);
            this.btnPersonal.TabIndex = 2;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.UseVisualStyleBackColor = true;
            // 
            // btnProdukter
            // 
            this.btnProdukter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdukter.Location = new System.Drawing.Point(20, 65);
            this.btnProdukter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProdukter.Name = "btnProdukter";
            this.btnProdukter.Size = new System.Drawing.Size(143, 28);
            this.btnProdukter.TabIndex = 2;
            this.btnProdukter.Text = "Produkter";
            this.btnProdukter.UseVisualStyleBackColor = true;
            this.btnProdukter.Click += new System.EventHandler(this.btnProdukter_Click);
            // 
            // btnKunder
            // 
            this.btnKunder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKunder.Location = new System.Drawing.Point(20, 28);
            this.btnKunder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKunder.Name = "btnKunder";
            this.btnKunder.Size = new System.Drawing.Size(143, 28);
            this.btnKunder.TabIndex = 2;
            this.btnKunder.Text = "Kunder";
            this.btnKunder.UseVisualStyleBackColor = true;
            this.btnKunder.Click += new System.EventHandler(this.btnKunder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Produktgrupp";
            // 
            // cmbProduktgrupp
            // 
            this.cmbProduktgrupp.FormattingEnabled = true;
            this.cmbProduktgrupp.Location = new System.Drawing.Point(592, 61);
            this.cmbProduktgrupp.Name = "cmbProduktgrupp";
            this.cmbProduktgrupp.Size = new System.Drawing.Size(121, 24);
            this.cmbProduktgrupp.TabIndex = 36;
            // 
            // cmbProduktKategori
            // 
            this.cmbProduktKategori.FormattingEnabled = true;
            this.cmbProduktKategori.Items.AddRange(new object[] {
            "Kundspecifik",
            "Generell"});
            this.cmbProduktKategori.Location = new System.Drawing.Point(719, 61);
            this.cmbProduktKategori.Name = "cmbProduktKategori";
            this.cmbProduktKategori.Size = new System.Drawing.Size(163, 24);
            this.cmbProduktKategori.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(716, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Produktkategori";
            // 
            // frmProdukter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbProduktKategori);
            this.Controls.Add(this.cmbProduktgrupp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRensa);
            this.Controls.Add(this.btnSök);
            this.Controls.Add(this.cmbVäljAvdelning);
            this.Controls.Add(this.tbProdukt);
            this.Controls.Add(this.tbProduktID);
            this.Controls.Add(this.btnRegistreraNyProdukt);
            this.Controls.Add(this.btnRedigeraProdukt);
            this.Controls.Add(this.dgvProdukter);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProdukter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkter || G4 Solutions Economy System";
            this.Load += new System.EventHandler(this.frmProdukter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRensa;
        private System.Windows.Forms.Button btnSök;
        private System.Windows.Forms.ComboBox cmbVäljAvdelning;
        private System.Windows.Forms.TextBox tbProdukt;
        private System.Windows.Forms.TextBox tbProduktID;
        private System.Windows.Forms.Button btnRegistreraNyProdukt;
        private System.Windows.Forms.Button btnRedigeraProdukt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResultat;
        private System.Windows.Forms.Button btnPrognostiseringIntäkter;
        private System.Windows.Forms.Button btnBudgeteratResultat;
        private System.Windows.Forms.Button btnKostnadsbudgetering;
        private System.Windows.Forms.Button btnIntäktsbudgeteringProdukt;
        private System.Windows.Forms.Button btnIntäktsbudgeteringKund;
        private System.Windows.Forms.Button btnBehörighet;
        private System.Windows.Forms.Button btnSchablonkostnad;
        private System.Windows.Forms.Button btnAktiviteter;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnProdukter;
        private System.Windows.Forms.Button btnKunder;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dgvProdukter;
        private System.Windows.Forms.ComboBox cmbProduktgrupp;
        private System.Windows.Forms.ComboBox cmbProduktKategori;
        private System.Windows.Forms.Label label5;
    }
}