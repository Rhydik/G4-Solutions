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
            this.lblKunden = new System.Windows.Forms.Label();
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
            this.dgvProdukter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.BackColor = System.Drawing.Color.White;
            this.btnAvbryt.Location = new System.Drawing.Point(598, 538);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(61, 58);
            this.btnAvbryt.TabIndex = 39;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = false;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click_1);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(390, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 3);
            this.label6.TabIndex = 38;
            // 
            // btnSpara
            // 
            this.btnSpara.BackColor = System.Drawing.Color.Yellow;
            this.btnSpara.Location = new System.Drawing.Point(665, 538);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(123, 58);
            this.btnSpara.TabIndex = 37;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = false;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click_1);
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
            // lblKunden
            // 
            this.lblKunden.AutoSize = true;
            this.lblKunden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKunden.Location = new System.Drawing.Point(242, 11);
            this.lblKunden.Name = "lblKunden";
            this.lblKunden.Size = new System.Drawing.Size(46, 20);
            this.lblKunden.TabIndex = 41;
            this.lblKunden.Text = "Kund";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.Location = new System.Drawing.Point(16, 551);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(51, 16);
            this.lblBudget.TabIndex = 43;
            this.lblBudget.Text = "Budget";
            // 
            // tbBudget
            // 
            this.tbBudget.Location = new System.Drawing.Point(15, 571);
            this.tbBudget.Name = "tbBudget";
            this.tbBudget.Size = new System.Drawing.Size(188, 20);
            this.tbBudget.TabIndex = 42;
            // 
            // lblAvtal
            // 
            this.lblAvtal.AutoSize = true;
            this.lblAvtal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvtal.Location = new System.Drawing.Point(16, 507);
            this.lblAvtal.Name = "lblAvtal";
            this.lblAvtal.Size = new System.Drawing.Size(38, 16);
            this.lblAvtal.TabIndex = 45;
            this.lblAvtal.Text = "Avtal";
            // 
            // tbAvtal
            // 
            this.tbAvtal.Location = new System.Drawing.Point(16, 526);
            this.tbAvtal.Name = "tbAvtal";
            this.tbAvtal.Size = new System.Drawing.Size(188, 20);
            this.tbAvtal.TabIndex = 44;
            // 
            // cmbGradA
            // 
            this.cmbGradA.FormattingEnabled = true;
            this.cmbGradA.Items.AddRange(new object[] {
            "Säker",
            "Osäker"});
            this.cmbGradA.Location = new System.Drawing.Point(15, 478);
            this.cmbGradA.Name = "cmbGradA";
            this.cmbGradA.Size = new System.Drawing.Size(188, 21);
            this.cmbGradA.TabIndex = 46;
            // 
            // lblGradA
            // 
            this.lblGradA.AutoSize = true;
            this.lblGradA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradA.Location = new System.Drawing.Point(16, 459);
            this.lblGradA.Name = "lblGradA";
            this.lblGradA.Size = new System.Drawing.Size(50, 16);
            this.lblGradA.TabIndex = 47;
            this.lblGradA.Text = "Grad A";
            // 
            // lblGradT
            // 
            this.lblGradT.AutoSize = true;
            this.lblGradT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradT.Location = new System.Drawing.Point(12, 373);
            this.lblGradT.Name = "lblGradT";
            this.lblGradT.Size = new System.Drawing.Size(50, 16);
            this.lblGradT.TabIndex = 49;
            this.lblGradT.Text = "Grad T";
            // 
            // cmbGradT
            // 
            this.cmbGradT.FormattingEnabled = true;
            this.cmbGradT.Items.AddRange(new object[] {
            "Säker",
            "Osäker"});
            this.cmbGradT.Location = new System.Drawing.Point(15, 392);
            this.cmbGradT.Name = "cmbGradT";
            this.cmbGradT.Size = new System.Drawing.Size(188, 21);
            this.cmbGradT.TabIndex = 48;
            // 
            // lblTillägg
            // 
            this.lblTillägg.AutoSize = true;
            this.lblTillägg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTillägg.Location = new System.Drawing.Point(12, 331);
            this.lblTillägg.Name = "lblTillägg";
            this.lblTillägg.Size = new System.Drawing.Size(50, 16);
            this.lblTillägg.TabIndex = 51;
            this.lblTillägg.Text = "Tillägg";
            // 
            // tbTilägg
            // 
            this.tbTilägg.Location = new System.Drawing.Point(16, 350);
            this.tbTilägg.Name = "tbTilägg";
            this.tbTilägg.Size = new System.Drawing.Size(188, 20);
            this.tbTilägg.TabIndex = 50;
            // 
            // lblTimmar
            // 
            this.lblTimmar.AutoSize = true;
            this.lblTimmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimmar.Location = new System.Drawing.Point(12, 416);
            this.lblTimmar.Name = "lblTimmar";
            this.lblTimmar.Size = new System.Drawing.Size(54, 16);
            this.lblTimmar.TabIndex = 53;
            this.lblTimmar.Text = "Timmar";
            // 
            // tbTimmar
            // 
            this.tbTimmar.Location = new System.Drawing.Point(16, 435);
            this.tbTimmar.Name = "tbTimmar";
            this.tbTimmar.Size = new System.Drawing.Size(188, 20);
            this.tbTimmar.TabIndex = 52;
            // 
            // rtbKommentar
            // 
            this.rtbKommentar.Location = new System.Drawing.Point(484, 337);
            this.rtbKommentar.Name = "rtbKommentar";
            this.rtbKommentar.Size = new System.Drawing.Size(304, 185);
            this.rtbKommentar.TabIndex = 54;
            this.rtbKommentar.Text = "";
            // 
            // lblKommentar
            // 
            this.lblKommentar.AutoSize = true;
            this.lblKommentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKommentar.Location = new System.Drawing.Point(402, 338);
            this.lblKommentar.Name = "lblKommentar";
            this.lblKommentar.Size = new System.Drawing.Size(76, 16);
            this.lblKommentar.TabIndex = 55;
            this.lblKommentar.Text = "Kommentar";
            // 
            // dgvProdukter
            // 
            this.dgvProdukter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukter.Location = new System.Drawing.Point(15, 34);
            this.dgvProdukter.Name = "dgvProdukter";
            this.dgvProdukter.Size = new System.Drawing.Size(773, 281);
            this.dgvProdukter.TabIndex = 56;
            // 
            // frmIntäktsbudgeteringLäggTillProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.dgvProdukter);
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
            this.Controls.Add(this.lblKunden);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.lblLäggTillProdulktFör);
            this.Name = "frmIntäktsbudgeteringLäggTillProdukt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIntäktsbudgeteringLäggTillProdukt";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Label lblLäggTillProdulktFör;
        private System.Windows.Forms.Label lblKunden;
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
        private System.Windows.Forms.DataGridView dgvProdukter;
    }
}