namespace PresentationLayer1.Forms
{
    partial class frmKostnadProdukt
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKostnadAktivitet = new System.Windows.Forms.Button();
            this.lblKostnadProdukt = new System.Windows.Forms.Button();
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
            this.dgvNedre = new System.Windows.Forms.DataGridView();
            this.lblSök = new System.Windows.Forms.Label();
            this.tbKonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.btnExportera = new System.Windows.Forms.Button();
            this.btnLåsBudget = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.cmbVäljProdukt = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cmbVäljKonto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNedre)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblKostnadAktivitet);
            this.panel1.Controls.Add(this.lblKostnadProdukt);
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 432);
            this.panel1.TabIndex = 5;
            // 
            // lblKostnadAktivitet
            // 
            this.lblKostnadAktivitet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblKostnadAktivitet.Location = new System.Drawing.Point(15, 332);
            this.lblKostnadAktivitet.Name = "lblKostnadAktivitet";
            this.lblKostnadAktivitet.Size = new System.Drawing.Size(158, 23);
            this.lblKostnadAktivitet.TabIndex = 5;
            this.lblKostnadAktivitet.Text = "Direkta kostnader - Aktivitet";
            this.lblKostnadAktivitet.UseVisualStyleBackColor = true;
            // 
            // lblKostnadProdukt
            // 
            this.lblKostnadProdukt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblKostnadProdukt.Location = new System.Drawing.Point(15, 303);
            this.lblKostnadProdukt.Name = "lblKostnadProdukt";
            this.lblKostnadProdukt.Size = new System.Drawing.Size(158, 23);
            this.lblKostnadProdukt.TabIndex = 4;
            this.lblKostnadProdukt.Text = "Direkta kostnader - Produkt";
            this.lblKostnadProdukt.UseVisualStyleBackColor = true;
            // 
            // btnPrognostiseringIntäkter
            // 
            this.btnPrognostiseringIntäkter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrognostiseringIntäkter.Location = new System.Drawing.Point(15, 406);
            this.btnPrognostiseringIntäkter.Name = "btnPrognostiseringIntäkter";
            this.btnPrognostiseringIntäkter.Size = new System.Drawing.Size(158, 23);
            this.btnPrognostiseringIntäkter.TabIndex = 2;
            this.btnPrognostiseringIntäkter.Text = "Prognostisering intäkter";
            this.btnPrognostiseringIntäkter.UseVisualStyleBackColor = true;
            // 
            // btnBudgeteratResultat
            // 
            this.btnBudgeteratResultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBudgeteratResultat.Location = new System.Drawing.Point(15, 376);
            this.btnBudgeteratResultat.Name = "btnBudgeteratResultat";
            this.btnBudgeteratResultat.Size = new System.Drawing.Size(158, 23);
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
            this.btnBehörighet.Size = new System.Drawing.Size(158, 23);
            this.btnBehörighet.TabIndex = 2;
            this.btnBehörighet.Text = "Behörighet";
            this.btnBehörighet.UseVisualStyleBackColor = true;
            // 
            // btnSchablonkostnad
            // 
            this.btnSchablonkostnad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchablonkostnad.Location = new System.Drawing.Point(15, 140);
            this.btnSchablonkostnad.Name = "btnSchablonkostnad";
            this.btnSchablonkostnad.Size = new System.Drawing.Size(158, 23);
            this.btnSchablonkostnad.TabIndex = 2;
            this.btnSchablonkostnad.Text = "Schablonkostnad";
            this.btnSchablonkostnad.UseVisualStyleBackColor = true;
            // 
            // btnAktiviteter
            // 
            this.btnAktiviteter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktiviteter.Location = new System.Drawing.Point(15, 110);
            this.btnAktiviteter.Name = "btnAktiviteter";
            this.btnAktiviteter.Size = new System.Drawing.Size(158, 23);
            this.btnAktiviteter.TabIndex = 2;
            this.btnAktiviteter.Text = "Aktiviteter";
            this.btnAktiviteter.UseVisualStyleBackColor = true;
            // 
            // btnPersonal
            // 
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.Location = new System.Drawing.Point(15, 82);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(158, 23);
            this.btnPersonal.TabIndex = 2;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.UseVisualStyleBackColor = true;
            // 
            // btnProdukter
            // 
            this.btnProdukter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdukter.Location = new System.Drawing.Point(15, 53);
            this.btnProdukter.Name = "btnProdukter";
            this.btnProdukter.Size = new System.Drawing.Size(158, 23);
            this.btnProdukter.TabIndex = 2;
            this.btnProdukter.Text = "Produkter";
            this.btnProdukter.UseVisualStyleBackColor = true;
            // 
            // btnKunder
            // 
            this.btnKunder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKunder.Location = new System.Drawing.Point(15, 23);
            this.btnKunder.Name = "btnKunder";
            this.btnKunder.Size = new System.Drawing.Size(158, 23);
            this.btnKunder.TabIndex = 2;
            this.btnKunder.Text = "Kunder";
            this.btnKunder.UseVisualStyleBackColor = true;
            // 
            // dgvNedre
            // 
            this.dgvNedre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvNedre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNedre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNedre.Location = new System.Drawing.Point(210, 100);
            this.dgvNedre.Name = "dgvNedre";
            this.dgvNedre.ReadOnly = true;
            this.dgvNedre.RowHeadersWidth = 62;
            this.dgvNedre.Size = new System.Drawing.Size(973, 377);
            this.dgvNedre.TabIndex = 79;
            // 
            // lblSök
            // 
            this.lblSök.AutoSize = true;
            this.lblSök.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSök.Location = new System.Drawing.Point(206, 12);
            this.lblSök.Name = "lblSök";
            this.lblSök.Size = new System.Drawing.Size(122, 24);
            this.lblSök.TabIndex = 88;
            this.lblSök.Text = "Välj Produkt";
            // 
            // tbKonto
            // 
            this.tbKonto.Location = new System.Drawing.Point(524, 38);
            this.tbKonto.Name = "tbKonto";
            this.tbKonto.Size = new System.Drawing.Size(128, 20);
            this.tbKonto.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Ange belopp";
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(658, 35);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(75, 23);
            this.btnLäggTill.TabIndex = 109;
            this.btnLäggTill.Text = "Lägg till";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            // 
            // btnExportera
            // 
            this.btnExportera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportera.Location = new System.Drawing.Point(211, 499);
            this.btnExportera.Name = "btnExportera";
            this.btnExportera.Size = new System.Drawing.Size(120, 41);
            this.btnExportera.TabIndex = 111;
            this.btnExportera.Text = "Exportera";
            this.btnExportera.UseVisualStyleBackColor = true;
            // 
            // btnLåsBudget
            // 
            this.btnLåsBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLåsBudget.Location = new System.Drawing.Point(924, 499);
            this.btnLåsBudget.Name = "btnLåsBudget";
            this.btnLåsBudget.Size = new System.Drawing.Size(120, 41);
            this.btnLåsBudget.TabIndex = 110;
            this.btnLåsBudget.Text = "Lås Budget";
            this.btnLåsBudget.UseVisualStyleBackColor = true;
            // 
            // btnTaBort
            // 
            this.btnTaBort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaBort.Location = new System.Drawing.Point(1063, 499);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(120, 41);
            this.btnTaBort.TabIndex = 112;
            this.btnTaBort.Text = "Ta bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            // 
            // cmbVäljProdukt
            // 
            this.cmbVäljProdukt.FormattingEnabled = true;
            this.cmbVäljProdukt.Location = new System.Drawing.Point(210, 42);
            this.cmbVäljProdukt.Name = "cmbVäljProdukt";
            this.cmbVäljProdukt.Size = new System.Drawing.Size(121, 21);
            this.cmbVäljProdukt.TabIndex = 113;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(358, 39);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 115;
            // 
            // cmbVäljKonto
            // 
            this.cmbVäljKonto.AutoSize = true;
            this.cmbVäljKonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVäljKonto.Location = new System.Drawing.Point(354, 9);
            this.cmbVäljKonto.Name = "cmbVäljKonto";
            this.cmbVäljKonto.Size = new System.Drawing.Size(105, 24);
            this.cmbVäljKonto.TabIndex = 114;
            this.cmbVäljKonto.Text = "Välj Konto";
            // 
            // frmKostnadProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 595);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.cmbVäljKonto);
            this.Controls.Add(this.cmbVäljProdukt);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnExportera);
            this.Controls.Add(this.btnLåsBudget);
            this.Controls.Add(this.btnLäggTill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKonto);
            this.Controls.Add(this.lblSök);
            this.Controls.Add(this.dgvNedre);
            this.Controls.Add(this.panel1);
            this.Name = "frmKostnadProdukt";
            this.Text = "Direkta kostnader - Produkt  | G4 Solutions Economy System";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNedre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lblKostnadAktivitet;
        private System.Windows.Forms.Button lblKostnadProdukt;
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
        private System.Windows.Forms.DataGridView dgvNedre;
        private System.Windows.Forms.Label lblSök;
        private System.Windows.Forms.TextBox tbKonto;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnLäggTill;
        private System.Windows.Forms.Button btnExportera;
        private System.Windows.Forms.Button btnLåsBudget;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.ComboBox cmbVäljProdukt;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label cmbVäljKonto;
    }
}