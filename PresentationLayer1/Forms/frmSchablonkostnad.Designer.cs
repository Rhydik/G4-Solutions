namespace PresentationLayer1.Forms
{
    partial class frmSchablonkostnad
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
            this.lblKontobenämning = new System.Windows.Forms.Label();
            this.lblKonto = new System.Windows.Forms.Label();
            this.btnRensa = new System.Windows.Forms.Button();
            this.btnSök = new System.Windows.Forms.Button();
            this.tbKontobenämning = new System.Windows.Forms.TextBox();
            this.tbKonto = new System.Windows.Forms.TextBox();
            this.btnRegistreraNyttKonto = new System.Windows.Forms.Button();
            this.btnRedigeraKonto = new System.Windows.Forms.Button();
            this.gvSchablonkostnad = new System.Windows.Forms.DataGridView();
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
            this.tbAvkastningskrav = new System.Windows.Forms.TextBox();
            this.lblAvkastningskrav = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvSchablonkostnad)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKontobenämning
            // 
            this.lblKontobenämning.AutoSize = true;
            this.lblKontobenämning.Location = new System.Drawing.Point(399, 35);
            this.lblKontobenämning.Name = "lblKontobenämning";
            this.lblKontobenämning.Size = new System.Drawing.Size(87, 13);
            this.lblKontobenämning.TabIndex = 40;
            this.lblKontobenämning.Text = "Kontobenämning";
            // 
            // lblKonto
            // 
            this.lblKonto.AutoSize = true;
            this.lblKonto.Location = new System.Drawing.Point(245, 35);
            this.lblKonto.Name = "lblKonto";
            this.lblKonto.Size = new System.Drawing.Size(35, 13);
            this.lblKonto.TabIndex = 39;
            this.lblKonto.Text = "Konto";
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(313, 86);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(60, 23);
            this.btnRensa.TabIndex = 38;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(246, 86);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(60, 23);
            this.btnSök.TabIndex = 37;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            // 
            // tbKontobenämning
            // 
            this.tbKontobenämning.Location = new System.Drawing.Point(402, 55);
            this.tbKontobenämning.Name = "tbKontobenämning";
            this.tbKontobenämning.Size = new System.Drawing.Size(128, 20);
            this.tbKontobenämning.TabIndex = 36;
            this.tbKontobenämning.TextChanged += new System.EventHandler(this.tbKontobenämning_TextChanged);
            // 
            // tbKonto
            // 
            this.tbKonto.Location = new System.Drawing.Point(245, 55);
            this.tbKonto.Name = "tbKonto";
            this.tbKonto.Size = new System.Drawing.Size(128, 20);
            this.tbKonto.TabIndex = 35;
            this.tbKonto.TextChanged += new System.EventHandler(this.tbKonto_TextChanged);
            // 
            // btnRegistreraNyttKonto
            // 
            this.btnRegistreraNyttKonto.Location = new System.Drawing.Point(635, 366);
            this.btnRegistreraNyttKonto.Name = "btnRegistreraNyttKonto";
            this.btnRegistreraNyttKonto.Size = new System.Drawing.Size(112, 40);
            this.btnRegistreraNyttKonto.TabIndex = 34;
            this.btnRegistreraNyttKonto.Text = "Registrera nytt konto";
            this.btnRegistreraNyttKonto.UseVisualStyleBackColor = true;
            this.btnRegistreraNyttKonto.Click += new System.EventHandler(this.btnRegistreraNyttKonto_Click);
            // 
            // btnRedigeraKonto
            // 
            this.btnRedigeraKonto.Location = new System.Drawing.Point(509, 365);
            this.btnRedigeraKonto.Name = "btnRedigeraKonto";
            this.btnRedigeraKonto.Size = new System.Drawing.Size(120, 41);
            this.btnRedigeraKonto.TabIndex = 33;
            this.btnRedigeraKonto.Text = "Redigera konto";
            this.btnRedigeraKonto.UseVisualStyleBackColor = true;
            this.btnRedigeraKonto.Click += new System.EventHandler(this.btnRedigeraKonto_Click);
            // 
            // gvSchablonkostnad
            // 
            this.gvSchablonkostnad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSchablonkostnad.Location = new System.Drawing.Point(246, 122);
            this.gvSchablonkostnad.Name = "gvSchablonkostnad";
            this.gvSchablonkostnad.ReadOnly = true;
            this.gvSchablonkostnad.RowHeadersWidth = 62;
            this.gvSchablonkostnad.Size = new System.Drawing.Size(383, 237);
            this.gvSchablonkostnad.TabIndex = 32;
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 432);
            this.panel1.TabIndex = 31;
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
            // 
            // tbAvkastningskrav
            // 
            this.tbAvkastningskrav.Location = new System.Drawing.Point(635, 273);
            this.tbAvkastningskrav.Name = "tbAvkastningskrav";
            this.tbAvkastningskrav.Size = new System.Drawing.Size(112, 20);
            this.tbAvkastningskrav.TabIndex = 41;
            // 
            // lblAvkastningskrav
            // 
            this.lblAvkastningskrav.AutoSize = true;
            this.lblAvkastningskrav.Location = new System.Drawing.Point(635, 257);
            this.lblAvkastningskrav.Name = "lblAvkastningskrav";
            this.lblAvkastningskrav.Size = new System.Drawing.Size(86, 13);
            this.lblAvkastningskrav.TabIndex = 42;
            this.lblAvkastningskrav.Text = "Avkastningskrav";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(753, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Spara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSchablonkostnad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAvkastningskrav);
            this.Controls.Add(this.tbAvkastningskrav);
            this.Controls.Add(this.lblKontobenämning);
            this.Controls.Add(this.lblKonto);
            this.Controls.Add(this.btnRensa);
            this.Controls.Add(this.btnSök);
            this.Controls.Add(this.tbKontobenämning);
            this.Controls.Add(this.tbKonto);
            this.Controls.Add(this.btnRegistreraNyttKonto);
            this.Controls.Add(this.btnRedigeraKonto);
            this.Controls.Add(this.gvSchablonkostnad);
            this.Controls.Add(this.panel1);
            this.Name = "frmSchablonkostnad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSchablonkostnad";
            ((System.ComponentModel.ISupportInitialize)(this.gvSchablonkostnad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKontobenämning;
        private System.Windows.Forms.Label lblKonto;
        private System.Windows.Forms.Button btnRensa;
        private System.Windows.Forms.Button btnSök;
        private System.Windows.Forms.TextBox tbKontobenämning;
        private System.Windows.Forms.TextBox tbKonto;
        private System.Windows.Forms.Button btnRegistreraNyttKonto;
        private System.Windows.Forms.Button btnRedigeraKonto;
        private System.Windows.Forms.DataGridView gvSchablonkostnad;
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
        private System.Windows.Forms.TextBox tbAvkastningskrav;
        private System.Windows.Forms.Label lblAvkastningskrav;
        private System.Windows.Forms.Button button1;
    }
}