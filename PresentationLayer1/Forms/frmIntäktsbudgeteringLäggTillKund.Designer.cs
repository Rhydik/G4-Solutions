namespace PresentationLayer1.Forms
{
    partial class frmIntäktsbudgeteringLäggTillKund
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
            this.lblKommentar = new System.Windows.Forms.Label();
            this.rtbKommentar = new System.Windows.Forms.RichTextBox();
            this.lblTimmar = new System.Windows.Forms.Label();
            this.tbTimmar = new System.Windows.Forms.TextBox();
            this.lblTillägg = new System.Windows.Forms.Label();
            this.tbTillägg = new System.Windows.Forms.TextBox();
            this.lblGradT = new System.Windows.Forms.Label();
            this.cmbGradT = new System.Windows.Forms.ComboBox();
            this.lblGradA = new System.Windows.Forms.Label();
            this.cmbGradA = new System.Windows.Forms.ComboBox();
            this.lblAvtal = new System.Windows.Forms.Label();
            this.tbAvtal = new System.Windows.Forms.TextBox();
            this.lblIntäktProdukt = new System.Windows.Forms.Label();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSpara = new System.Windows.Forms.Button();
            this.lblLäggTillKundFör = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ucSökFältKund = new PresentationLayer1.Forms.ucSökFältKund();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKommentar
            // 
            this.lblKommentar.AutoSize = true;
            this.lblKommentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKommentar.Location = new System.Drawing.Point(405, 401);
            this.lblKommentar.Name = "lblKommentar";
            this.lblKommentar.Size = new System.Drawing.Size(76, 16);
            this.lblKommentar.TabIndex = 76;
            this.lblKommentar.Text = "Kommentar";
            // 
            // rtbKommentar
            // 
            this.rtbKommentar.Location = new System.Drawing.Point(487, 401);
            this.rtbKommentar.Name = "rtbKommentar";
            this.rtbKommentar.Size = new System.Drawing.Size(304, 185);
            this.rtbKommentar.TabIndex = 75;
            this.rtbKommentar.Text = "";
            // 
            // lblTimmar
            // 
            this.lblTimmar.AutoSize = true;
            this.lblTimmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimmar.Location = new System.Drawing.Point(18, 489);
            this.lblTimmar.Name = "lblTimmar";
            this.lblTimmar.Size = new System.Drawing.Size(54, 16);
            this.lblTimmar.TabIndex = 74;
            this.lblTimmar.Text = "Timmar";
            // 
            // tbTimmar
            // 
            this.tbTimmar.Location = new System.Drawing.Point(21, 508);
            this.tbTimmar.Name = "tbTimmar";
            this.tbTimmar.Size = new System.Drawing.Size(188, 20);
            this.tbTimmar.TabIndex = 73;
            // 
            // lblTillägg
            // 
            this.lblTillägg.AutoSize = true;
            this.lblTillägg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTillägg.Location = new System.Drawing.Point(18, 401);
            this.lblTillägg.Name = "lblTillägg";
            this.lblTillägg.Size = new System.Drawing.Size(50, 16);
            this.lblTillägg.TabIndex = 72;
            this.lblTillägg.Text = "Tillägg";
            // 
            // tbTillägg
            // 
            this.tbTillägg.Location = new System.Drawing.Point(21, 420);
            this.tbTillägg.Name = "tbTillägg";
            this.tbTillägg.Size = new System.Drawing.Size(188, 20);
            this.tbTillägg.TabIndex = 71;
            // 
            // lblGradT
            // 
            this.lblGradT.AutoSize = true;
            this.lblGradT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradT.Location = new System.Drawing.Point(18, 443);
            this.lblGradT.Name = "lblGradT";
            this.lblGradT.Size = new System.Drawing.Size(50, 16);
            this.lblGradT.TabIndex = 70;
            this.lblGradT.Text = "Grad T";
            // 
            // cmbGradT
            // 
            this.cmbGradT.FormattingEnabled = true;
            this.cmbGradT.Items.AddRange(new object[] {
            "Säker",
            "Osäker"});
            this.cmbGradT.Location = new System.Drawing.Point(21, 462);
            this.cmbGradT.Name = "cmbGradT";
            this.cmbGradT.Size = new System.Drawing.Size(188, 21);
            this.cmbGradT.TabIndex = 69;
            // 
            // lblGradA
            // 
            this.lblGradA.AutoSize = true;
            this.lblGradA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradA.Location = new System.Drawing.Point(18, 531);
            this.lblGradA.Name = "lblGradA";
            this.lblGradA.Size = new System.Drawing.Size(50, 16);
            this.lblGradA.TabIndex = 68;
            this.lblGradA.Text = "Grad A";
            // 
            // cmbGradA
            // 
            this.cmbGradA.FormattingEnabled = true;
            this.cmbGradA.Items.AddRange(new object[] {
            "Säker",
            "Osäker"});
            this.cmbGradA.Location = new System.Drawing.Point(21, 550);
            this.cmbGradA.Name = "cmbGradA";
            this.cmbGradA.Size = new System.Drawing.Size(188, 21);
            this.cmbGradA.TabIndex = 67;
            // 
            // lblAvtal
            // 
            this.lblAvtal.AutoSize = true;
            this.lblAvtal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvtal.Location = new System.Drawing.Point(18, 576);
            this.lblAvtal.Name = "lblAvtal";
            this.lblAvtal.Size = new System.Drawing.Size(38, 16);
            this.lblAvtal.TabIndex = 66;
            this.lblAvtal.Text = "Avtal";
            // 
            // tbAvtal
            // 
            this.tbAvtal.Location = new System.Drawing.Point(21, 595);
            this.tbAvtal.Name = "tbAvtal";
            this.tbAvtal.Size = new System.Drawing.Size(188, 20);
            this.tbAvtal.TabIndex = 65;
            // 
            // lblIntäktProdukt
            // 
            this.lblIntäktProdukt.AutoSize = true;
            this.lblIntäktProdukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntäktProdukt.Location = new System.Drawing.Point(186, 18);
            this.lblIntäktProdukt.Name = "lblIntäktProdukt";
            this.lblIntäktProdukt.Size = new System.Drawing.Size(64, 20);
            this.lblIntäktProdukt.TabIndex = 62;
            this.lblIntäktProdukt.Text = "Produkt";
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.BackColor = System.Drawing.Color.White;
            this.btnAvbryt.Location = new System.Drawing.Point(601, 595);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(61, 58);
            this.btnAvbryt.TabIndex = 61;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = false;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(393, 589);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 3);
            this.label6.TabIndex = 60;
            // 
            // btnSpara
            // 
            this.btnSpara.BackColor = System.Drawing.Color.Yellow;
            this.btnSpara.Location = new System.Drawing.Point(668, 595);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(123, 58);
            this.btnSpara.TabIndex = 59;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = false;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // lblLäggTillKundFör
            // 
            this.lblLäggTillKundFör.AutoSize = true;
            this.lblLäggTillKundFör.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLäggTillKundFör.Location = new System.Drawing.Point(14, 16);
            this.lblLäggTillKundFör.Name = "lblLäggTillKundFör";
            this.lblLäggTillKundFör.Size = new System.Drawing.Size(166, 22);
            this.lblLäggTillKundFör.TabIndex = 57;
            this.lblLäggTillKundFör.Text = "Lägg till kund för";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(18, 114);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(773, 281);
            this.dgv.TabIndex = 77;
            // 
            // ucSökFältKund
            // 
            this.ucSökFältKund.Location = new System.Drawing.Point(18, 55);
            this.ucSökFältKund.Name = "ucSökFältKund";
            this.ucSökFältKund.Size = new System.Drawing.Size(534, 53);
            this.ucSökFältKund.TabIndex = 86;
            // 
            // frmIntäktsbudgeteringLäggTillKund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.ucSökFältKund);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblKommentar);
            this.Controls.Add(this.rtbKommentar);
            this.Controls.Add(this.lblTimmar);
            this.Controls.Add(this.tbTimmar);
            this.Controls.Add(this.lblTillägg);
            this.Controls.Add(this.tbTillägg);
            this.Controls.Add(this.lblGradT);
            this.Controls.Add(this.cmbGradT);
            this.Controls.Add(this.lblGradA);
            this.Controls.Add(this.cmbGradA);
            this.Controls.Add(this.lblAvtal);
            this.Controls.Add(this.tbAvtal);
            this.Controls.Add(this.lblIntäktProdukt);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.lblLäggTillKundFör);
            this.Name = "frmIntäktsbudgeteringLäggTillKund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intäktsbudgetering: Lägg till Kund  | G4 Solutions Economy System";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKommentar;
        private System.Windows.Forms.RichTextBox rtbKommentar;
        private System.Windows.Forms.Label lblTimmar;
        private System.Windows.Forms.TextBox tbTimmar;
        private System.Windows.Forms.Label lblTillägg;
        private System.Windows.Forms.TextBox tbTillägg;
        private System.Windows.Forms.Label lblGradT;
        private System.Windows.Forms.ComboBox cmbGradT;
        private System.Windows.Forms.Label lblGradA;
        private System.Windows.Forms.ComboBox cmbGradA;
        private System.Windows.Forms.Label lblAvtal;
        private System.Windows.Forms.TextBox tbAvtal;
        private System.Windows.Forms.Label lblIntäktProdukt;
        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Label lblLäggTillKundFör;
        private System.Windows.Forms.DataGridView dgv;
        private ucSökFältKund ucSökFältKund;
    }
}