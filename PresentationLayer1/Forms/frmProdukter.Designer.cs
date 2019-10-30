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
            this.label3.Location = new System.Drawing.Point(684, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Avdelning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Produkt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "ProduktID";
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(313, 82);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(60, 23);
            this.btnRensa.TabIndex = 29;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            this.btnRensa.Click += new System.EventHandler(this.btnRensa_Click);
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(246, 82);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(60, 23);
            this.btnSök.TabIndex = 28;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            this.btnSök.Click += new System.EventHandler(this.btnSök_Click);
            // 
            // cmbVäljAvdelning
            // 
            this.cmbVäljAvdelning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVäljAvdelning.FormattingEnabled = true;
            this.cmbVäljAvdelning.Location = new System.Drawing.Point(543, 51);
            this.cmbVäljAvdelning.Name = "cmbVäljAvdelning";
            this.cmbVäljAvdelning.Size = new System.Drawing.Size(138, 21);
            this.cmbVäljAvdelning.TabIndex = 27;
            // 
            // tbProdukt
            // 
            this.tbProdukt.Location = new System.Drawing.Point(345, 51);
            this.tbProdukt.Name = "tbProdukt";
            this.tbProdukt.Size = new System.Drawing.Size(94, 20);
            this.tbProdukt.TabIndex = 26;
            // 
            // tbProduktID
            // 
            this.tbProduktID.Location = new System.Drawing.Point(245, 51);
            this.tbProduktID.Name = "tbProduktID";
            this.tbProduktID.Size = new System.Drawing.Size(94, 20);
            this.tbProduktID.TabIndex = 25;
            // 
            // btnRegistreraNyProdukt
            // 
            this.btnRegistreraNyProdukt.Location = new System.Drawing.Point(698, 374);
            this.btnRegistreraNyProdukt.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistreraNyProdukt.Name = "btnRegistreraNyProdukt";
            this.btnRegistreraNyProdukt.Size = new System.Drawing.Size(112, 40);
            this.btnRegistreraNyProdukt.TabIndex = 24;
            this.btnRegistreraNyProdukt.Text = "Registrera ny produkt";
            this.btnRegistreraNyProdukt.UseVisualStyleBackColor = true;
            this.btnRegistreraNyProdukt.Click += new System.EventHandler(this.btnRegistreraNyProdukt_Click);
            // 
            // btnRedigeraProdukt
            // 
            this.btnRedigeraProdukt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRedigeraProdukt.Location = new System.Drawing.Point(572, 373);
            this.btnRedigeraProdukt.Name = "btnRedigeraProdukt";
            this.btnRedigeraProdukt.Size = new System.Drawing.Size(120, 41);
            this.btnRedigeraProdukt.TabIndex = 23;
            this.btnRedigeraProdukt.Text = "Redigera produkt";
            this.btnRedigeraProdukt.UseVisualStyleBackColor = true;
            this.btnRedigeraProdukt.Click += new System.EventHandler(this.btnRedigeraProdukt_Click);
            // 
            // dgvProdukter
            // 
            this.dgvProdukter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdukter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdukter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukter.Location = new System.Drawing.Point(246, 118);
            this.dgvProdukter.Name = "dgvProdukter";
            this.dgvProdukter.RowHeadersWidth = 62;
            this.dgvProdukter.Size = new System.Drawing.Size(564, 237);
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
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 432);
            this.panel1.TabIndex = 33;
            // 
            // btnResultat
            // 
            this.btnResultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultat.Location = new System.Drawing.Point(15, 381);
            this.btnResultat.Name = "btnResultat";
            this.btnResultat.Size = new System.Drawing.Size(75, 23);
            this.btnResultat.TabIndex = 2;
            this.btnResultat.Text = "Resultat";
            this.btnResultat.UseVisualStyleBackColor = true;
            // 
            // btnPrognostiseringIntäkter
            // 
            this.btnPrognostiseringIntäkter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrognostiseringIntäkter.Location = new System.Drawing.Point(15, 352);
            this.btnPrognostiseringIntäkter.Name = "btnPrognostiseringIntäkter";
            this.btnPrognostiseringIntäkter.Size = new System.Drawing.Size(141, 23);
            this.btnPrognostiseringIntäkter.TabIndex = 2;
            this.btnPrognostiseringIntäkter.Text = "Prognostisering intäkter";
            this.btnPrognostiseringIntäkter.UseVisualStyleBackColor = true;
            // 
            // btnBudgeteratResultat
            // 
            this.btnBudgeteratResultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBudgeteratResultat.Location = new System.Drawing.Point(15, 322);
            this.btnBudgeteratResultat.Name = "btnBudgeteratResultat";
            this.btnBudgeteratResultat.Size = new System.Drawing.Size(123, 23);
            this.btnBudgeteratResultat.TabIndex = 2;
            this.btnBudgeteratResultat.Text = "Budgeterat Resultat";
            this.btnBudgeteratResultat.UseVisualStyleBackColor = true;
            // 
            // btnKostnadsbudgetering
            // 
            this.btnKostnadsbudgetering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKostnadsbudgetering.Location = new System.Drawing.Point(15, 274);
            this.btnKostnadsbudgetering.Name = "btnKostnadsbudgetering";
            this.btnKostnadsbudgetering.Size = new System.Drawing.Size(158, 23);
            this.btnKostnadsbudgetering.TabIndex = 2;
            this.btnKostnadsbudgetering.Text = "Kostnadsbudgetering";
            this.btnKostnadsbudgetering.UseVisualStyleBackColor = true;
            // 
            // btnIntäktsbudgeteringProdukt
            // 
            this.btnIntäktsbudgeteringProdukt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntäktsbudgeteringProdukt.Location = new System.Drawing.Point(15, 245);
            this.btnIntäktsbudgeteringProdukt.Name = "btnIntäktsbudgeteringProdukt";
            this.btnIntäktsbudgeteringProdukt.Size = new System.Drawing.Size(158, 23);
            this.btnIntäktsbudgeteringProdukt.TabIndex = 2;
            this.btnIntäktsbudgeteringProdukt.Text = "Intäktsbudgetering Produkt";
            this.btnIntäktsbudgeteringProdukt.UseVisualStyleBackColor = true;
            // 
            // btnIntäktsbudgeteringKund
            // 
            this.btnIntäktsbudgeteringKund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntäktsbudgeteringKund.Location = new System.Drawing.Point(15, 216);
            this.btnIntäktsbudgeteringKund.Name = "btnIntäktsbudgeteringKund";
            this.btnIntäktsbudgeteringKund.Size = new System.Drawing.Size(158, 23);
            this.btnIntäktsbudgeteringKund.TabIndex = 3;
            this.btnIntäktsbudgeteringKund.Text = "Intäktsbudgetering Kund";
            this.btnIntäktsbudgeteringKund.UseVisualStyleBackColor = true;
            // 
            // btnBehörighet
            // 
            this.btnBehörighet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBehörighet.Location = new System.Drawing.Point(15, 169);
            this.btnBehörighet.Name = "btnBehörighet";
            this.btnBehörighet.Size = new System.Drawing.Size(107, 23);
            this.btnBehörighet.TabIndex = 2;
            this.btnBehörighet.Text = "Behörighet";
            this.btnBehörighet.UseVisualStyleBackColor = true;
            // 
            // btnSchablonkostnad
            // 
            this.btnSchablonkostnad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchablonkostnad.Location = new System.Drawing.Point(15, 140);
            this.btnSchablonkostnad.Name = "btnSchablonkostnad";
            this.btnSchablonkostnad.Size = new System.Drawing.Size(107, 23);
            this.btnSchablonkostnad.TabIndex = 2;
            this.btnSchablonkostnad.Text = "Schablonkostnad";
            this.btnSchablonkostnad.UseVisualStyleBackColor = true;
            // 
            // btnAktiviteter
            // 
            this.btnAktiviteter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktiviteter.Location = new System.Drawing.Point(15, 110);
            this.btnAktiviteter.Name = "btnAktiviteter";
            this.btnAktiviteter.Size = new System.Drawing.Size(107, 23);
            this.btnAktiviteter.TabIndex = 2;
            this.btnAktiviteter.Text = "Aktiviteter";
            this.btnAktiviteter.UseVisualStyleBackColor = true;
            // 
            // btnPersonal
            // 
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.Location = new System.Drawing.Point(15, 82);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(107, 23);
            this.btnPersonal.TabIndex = 2;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.UseVisualStyleBackColor = true;
            // 
            // btnProdukter
            // 
            this.btnProdukter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdukter.Location = new System.Drawing.Point(15, 53);
            this.btnProdukter.Name = "btnProdukter";
            this.btnProdukter.Size = new System.Drawing.Size(107, 23);
            this.btnProdukter.TabIndex = 2;
            this.btnProdukter.Text = "Produkter";
            this.btnProdukter.UseVisualStyleBackColor = true;
            this.btnProdukter.Click += new System.EventHandler(this.btnProdukter_Click);
            // 
            // btnKunder
            // 
            this.btnKunder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKunder.Location = new System.Drawing.Point(15, 23);
            this.btnKunder.Name = "btnKunder";
            this.btnKunder.Size = new System.Drawing.Size(107, 23);
            this.btnKunder.TabIndex = 2;
            this.btnKunder.Text = "Kunder";
            this.btnKunder.UseVisualStyleBackColor = true;
            this.btnKunder.Click += new System.EventHandler(this.btnKunder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Produktgrupp";
            // 
            // cmbProduktgrupp
            // 
            this.cmbProduktgrupp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduktgrupp.FormattingEnabled = true;
            this.cmbProduktgrupp.Location = new System.Drawing.Point(445, 51);
            this.cmbProduktgrupp.Name = "cmbProduktgrupp";
            this.cmbProduktgrupp.Size = new System.Drawing.Size(92, 21);
            this.cmbProduktgrupp.TabIndex = 36;
            // 
            // cmbProduktKategori
            // 
            this.cmbProduktKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduktKategori.FormattingEnabled = true;
            this.cmbProduktKategori.Items.AddRange(new object[] {
            "Kundspecifik",
            "Generell"});
            this.cmbProduktKategori.Location = new System.Drawing.Point(687, 51);
            this.cmbProduktKategori.Name = "cmbProduktKategori";
            this.cmbProduktKategori.Size = new System.Drawing.Size(123, 21);
            this.cmbProduktKategori.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Produktkategori";
            // 
            // frmProdukter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 450);
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
            this.Name = "frmProdukter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkter | G4 Solutions Economy System";
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