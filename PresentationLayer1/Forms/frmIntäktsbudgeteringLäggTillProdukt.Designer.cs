namespace PresentationLayer1.Forms
{
    partial class frmIntäktsbudgeteringLäggTillProdukt
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
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSpara = new System.Windows.Forms.Button();
            this.lblLäggTillProdulktFör = new System.Windows.Forms.Label();
            this.lblKund = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.tbBudget = new System.Windows.Forms.TextBox();
            this.lblAvtal = new System.Windows.Forms.Label();
            this.tbAvtal = new System.Windows.Forms.TextBox();
            this.cmbGradA = new System.Windows.Forms.ComboBox();
            this.lblGradA = new System.Windows.Forms.Label();
            this.lblGradT = new System.Windows.Forms.Label();
            this.cmbGradT = new System.Windows.Forms.ComboBox();
            this.lblTillägg = new System.Windows.Forms.Label();
            this.tbTilägg = new System.Windows.Forms.TextBox();
            this.lblTimmar = new System.Windows.Forms.Label();
            this.tbTimmar = new System.Windows.Forms.TextBox();
            this.rtbKommentar = new System.Windows.Forms.RichTextBox();
            this.lblKommentar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbProduktgrupp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRensa = new System.Windows.Forms.Button();
            this.btnSök = new System.Windows.Forms.Button();
            this.cmbVäljAvdelning = new System.Windows.Forms.ComboBox();
            this.tbProdukt = new System.Windows.Forms.TextBox();
            this.tbProduktID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.BackColor = System.Drawing.Color.White;
            this.btnAvbryt.Location = new System.Drawing.Point(598, 595);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(61, 58);
            this.btnAvbryt.TabIndex = 39;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(396, 584);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 3);
            this.label6.TabIndex = 38;
            // 
            // btnSpara
            // 
            this.btnSpara.BackColor = System.Drawing.Color.Yellow;
            this.btnSpara.Location = new System.Drawing.Point(665, 595);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(123, 58);
            this.btnSpara.TabIndex = 37;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = false;
            // 
            // lblLäggTillProdulktFör
            // 
            this.lblLäggTillProdulktFör.AutoSize = true;
            this.lblLäggTillProdulktFör.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLäggTillProdulktFör.Location = new System.Drawing.Point(12, 9);
            this.lblLäggTillProdulktFör.Name = "lblLäggTillProdulktFör";
            this.lblLäggTillProdulktFör.Size = new System.Drawing.Size(192, 22);
            this.lblLäggTillProdulktFör.TabIndex = 32;
            this.lblLäggTillProdulktFör.Text = "Lägg till produkt för";
            // 
            // lblKund
            // 
            this.lblKund.AutoSize = true;
            this.lblKund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKund.Location = new System.Drawing.Point(210, 11);
            this.lblKund.Name = "lblKund";
            this.lblKund.Size = new System.Drawing.Size(46, 20);
            this.lblKund.TabIndex = 41;
            this.lblKund.Text = "Kund";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.Location = new System.Drawing.Point(22, 613);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(51, 16);
            this.lblBudget.TabIndex = 43;
            this.lblBudget.Text = "Budget";
            // 
            // tbBudget
            // 
            this.tbBudget.Location = new System.Drawing.Point(21, 633);
            this.tbBudget.Name = "tbBudget";
            this.tbBudget.Size = new System.Drawing.Size(188, 20);
            this.tbBudget.TabIndex = 42;
            // 
            // lblAvtal
            // 
            this.lblAvtal.AutoSize = true;
            this.lblAvtal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvtal.Location = new System.Drawing.Point(22, 569);
            this.lblAvtal.Name = "lblAvtal";
            this.lblAvtal.Size = new System.Drawing.Size(38, 16);
            this.lblAvtal.TabIndex = 45;
            this.lblAvtal.Text = "Avtal";
            // 
            // tbAvtal
            // 
            this.tbAvtal.Location = new System.Drawing.Point(22, 588);
            this.tbAvtal.Name = "tbAvtal";
            this.tbAvtal.Size = new System.Drawing.Size(188, 20);
            this.tbAvtal.TabIndex = 44;
            // 
            // cmbGradA
            // 
            this.cmbGradA.FormattingEnabled = true;
            this.cmbGradA.Location = new System.Drawing.Point(21, 540);
            this.cmbGradA.Name = "cmbGradA";
            this.cmbGradA.Size = new System.Drawing.Size(188, 21);
            this.cmbGradA.TabIndex = 46;
            // 
            // lblGradA
            // 
            this.lblGradA.AutoSize = true;
            this.lblGradA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradA.Location = new System.Drawing.Point(22, 521);
            this.lblGradA.Name = "lblGradA";
            this.lblGradA.Size = new System.Drawing.Size(50, 16);
            this.lblGradA.TabIndex = 47;
            this.lblGradA.Text = "Grad A";
            // 
            // lblGradT
            // 
            this.lblGradT.AutoSize = true;
            this.lblGradT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradT.Location = new System.Drawing.Point(18, 435);
            this.lblGradT.Name = "lblGradT";
            this.lblGradT.Size = new System.Drawing.Size(50, 16);
            this.lblGradT.TabIndex = 49;
            this.lblGradT.Text = "Grad T";
            // 
            // cmbGradT
            // 
            this.cmbGradT.FormattingEnabled = true;
            this.cmbGradT.Location = new System.Drawing.Point(21, 454);
            this.cmbGradT.Name = "cmbGradT";
            this.cmbGradT.Size = new System.Drawing.Size(188, 21);
            this.cmbGradT.TabIndex = 48;
            // 
            // lblTillägg
            // 
            this.lblTillägg.AutoSize = true;
            this.lblTillägg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTillägg.Location = new System.Drawing.Point(18, 393);
            this.lblTillägg.Name = "lblTillägg";
            this.lblTillägg.Size = new System.Drawing.Size(50, 16);
            this.lblTillägg.TabIndex = 51;
            this.lblTillägg.Text = "Tillägg";
            // 
            // tbTilägg
            // 
            this.tbTilägg.Location = new System.Drawing.Point(22, 412);
            this.tbTilägg.Name = "tbTilägg";
            this.tbTilägg.Size = new System.Drawing.Size(188, 20);
            this.tbTilägg.TabIndex = 50;
            // 
            // lblTimmar
            // 
            this.lblTimmar.AutoSize = true;
            this.lblTimmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimmar.Location = new System.Drawing.Point(18, 478);
            this.lblTimmar.Name = "lblTimmar";
            this.lblTimmar.Size = new System.Drawing.Size(54, 16);
            this.lblTimmar.TabIndex = 53;
            this.lblTimmar.Text = "Timmar";
            // 
            // tbTimmar
            // 
            this.tbTimmar.Location = new System.Drawing.Point(22, 497);
            this.tbTimmar.Name = "tbTimmar";
            this.tbTimmar.Size = new System.Drawing.Size(188, 20);
            this.tbTimmar.TabIndex = 52;
            // 
            // rtbKommentar
            // 
            this.rtbKommentar.Location = new System.Drawing.Point(490, 391);
            this.rtbKommentar.Name = "rtbKommentar";
            this.rtbKommentar.Size = new System.Drawing.Size(304, 185);
            this.rtbKommentar.TabIndex = 54;
            this.rtbKommentar.Text = "";
            // 
            // lblKommentar
            // 
            this.lblKommentar.AutoSize = true;
            this.lblKommentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKommentar.Location = new System.Drawing.Point(408, 392);
            this.lblKommentar.Name = "lblKommentar";
            this.lblKommentar.Size = new System.Drawing.Size(76, 16);
            this.lblKommentar.TabIndex = 55;
            this.lblKommentar.Text = "Kommentar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(773, 281);
            this.dataGridView1.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Produktgrupp";
            // 
            // tbProduktgrupp
            // 
            this.tbProduktgrupp.Location = new System.Drawing.Point(268, 68);
            this.tbProduktgrupp.Name = "tbProduktgrupp";
            this.tbProduktgrupp.Size = new System.Drawing.Size(94, 20);
            this.tbProduktgrupp.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Avdelning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Produkt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "ProduktID";
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(728, 68);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(60, 23);
            this.btnRensa.TabIndex = 61;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(661, 68);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(60, 23);
            this.btnSök.TabIndex = 60;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            // 
            // cmbVäljAvdelning
            // 
            this.cmbVäljAvdelning.FormattingEnabled = true;
            this.cmbVäljAvdelning.Location = new System.Drawing.Point(397, 67);
            this.cmbVäljAvdelning.Name = "cmbVäljAvdelning";
            this.cmbVäljAvdelning.Size = new System.Drawing.Size(192, 21);
            this.cmbVäljAvdelning.TabIndex = 59;
            this.cmbVäljAvdelning.Text = "Välj avdelning";
            // 
            // tbProdukt
            // 
            this.tbProdukt.Location = new System.Drawing.Point(137, 68);
            this.tbProdukt.Name = "tbProdukt";
            this.tbProdukt.Size = new System.Drawing.Size(94, 20);
            this.tbProdukt.TabIndex = 58;
            // 
            // tbProduktID
            // 
            this.tbProduktID.Location = new System.Drawing.Point(22, 68);
            this.tbProduktID.Name = "tbProduktID";
            this.tbProduktID.Size = new System.Drawing.Size(94, 20);
            this.tbProduktID.TabIndex = 57;
            // 
            // frmIntäktsbudgeteringLäggTillProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbProduktgrupp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRensa);
            this.Controls.Add(this.btnSök);
            this.Controls.Add(this.cmbVäljAvdelning);
            this.Controls.Add(this.tbProdukt);
            this.Controls.Add(this.tbProduktID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblKommentar);
            this.Controls.Add(this.rtbKommentar);
            this.Controls.Add(this.lblTimmar);
            this.Controls.Add(this.tbTimmar);
            this.Controls.Add(this.lblTillägg);
            this.Controls.Add(this.tbTilägg);
            this.Controls.Add(this.lblGradT);
            this.Controls.Add(this.cmbGradT);
            this.Controls.Add(this.lblGradA);
            this.Controls.Add(this.cmbGradA);
            this.Controls.Add(this.lblAvtal);
            this.Controls.Add(this.tbAvtal);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.tbBudget);
            this.Controls.Add(this.lblKund);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.lblLäggTillProdulktFör);
            this.Name = "frmIntäktsbudgeteringLäggTillProdukt";
            this.Text = "frmIntäktsbudgeteringLäggTillProdukt";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Label lblLäggTillProdulktFör;
        private System.Windows.Forms.Label lblKund;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.TextBox tbBudget;
        private System.Windows.Forms.Label lblAvtal;
        private System.Windows.Forms.TextBox tbAvtal;
        private System.Windows.Forms.ComboBox cmbGradA;
        private System.Windows.Forms.Label lblGradA;
        private System.Windows.Forms.Label lblGradT;
        private System.Windows.Forms.ComboBox cmbGradT;
        private System.Windows.Forms.Label lblTillägg;
        private System.Windows.Forms.TextBox tbTilägg;
        private System.Windows.Forms.Label lblTimmar;
        private System.Windows.Forms.TextBox tbTimmar;
        private System.Windows.Forms.RichTextBox rtbKommentar;
        private System.Windows.Forms.Label lblKommentar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbProduktgrupp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRensa;
        private System.Windows.Forms.Button btnSök;
        private System.Windows.Forms.ComboBox cmbVäljAvdelning;
        private System.Windows.Forms.TextBox tbProdukt;
        private System.Windows.Forms.TextBox tbProduktID;
    }
}