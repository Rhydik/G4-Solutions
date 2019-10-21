namespace PresentationLayer1.Forms
{
    partial class frmRedigeraProdukt
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
            this.lblAvdelning = new System.Windows.Forms.Label();
            this.lblProduktkategori = new System.Windows.Forms.Label();
            this.lblProduktgrupp = new System.Windows.Forms.Label();
            this.btnTaBortProdukt = new System.Windows.Forms.Button();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSpara = new System.Windows.Forms.Button();
            this.lblProdukt = new System.Windows.Forms.Label();
            this.lblProduktID = new System.Windows.Forms.Label();
            this.lblRedigeraProdukt = new System.Windows.Forms.Label();
            this.tbProduktID = new System.Windows.Forms.TextBox();
            this.tbProduktNamn = new System.Windows.Forms.TextBox();
            this.cmbProduktgrupp = new System.Windows.Forms.ComboBox();
            this.cmbProduktkategori = new System.Windows.Forms.ComboBox();
            this.cmbAvdelning = new System.Windows.Forms.ComboBox();
            this.btnSkapaNyProdukGrupp = new System.Windows.Forms.Button();
            this.btnSkapaNyProduktKategori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAvdelning
            // 
            this.lblAvdelning.AutoSize = true;
            this.lblAvdelning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvdelning.Location = new System.Drawing.Point(8, 312);
            this.lblAvdelning.Name = "lblAvdelning";
            this.lblAvdelning.Size = new System.Drawing.Size(68, 16);
            this.lblAvdelning.TabIndex = 72;
            this.lblAvdelning.Text = "Avdelning";
            // 
            // lblProduktkategori
            // 
            this.lblProduktkategori.AutoSize = true;
            this.lblProduktkategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduktkategori.Location = new System.Drawing.Point(9, 246);
            this.lblProduktkategori.Name = "lblProduktkategori";
            this.lblProduktkategori.Size = new System.Drawing.Size(103, 16);
            this.lblProduktkategori.TabIndex = 70;
            this.lblProduktkategori.Text = "Produktkategori";
            // 
            // lblProduktgrupp
            // 
            this.lblProduktgrupp.AutoSize = true;
            this.lblProduktgrupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduktgrupp.Location = new System.Drawing.Point(9, 178);
            this.lblProduktgrupp.Name = "lblProduktgrupp";
            this.lblProduktgrupp.Size = new System.Drawing.Size(89, 16);
            this.lblProduktgrupp.TabIndex = 68;
            this.lblProduktgrupp.Text = "Produktgrupp";
            // 
            // btnTaBortProdukt
            // 
            this.btnTaBortProdukt.BackColor = System.Drawing.Color.DarkRed;
            this.btnTaBortProdukt.Location = new System.Drawing.Point(12, 391);
            this.btnTaBortProdukt.Name = "btnTaBortProdukt";
            this.btnTaBortProdukt.Size = new System.Drawing.Size(239, 41);
            this.btnTaBortProdukt.TabIndex = 66;
            this.btnTaBortProdukt.Text = "Ta bort produkt";
            this.btnTaBortProdukt.UseVisualStyleBackColor = false;
            this.btnTaBortProdukt.Click += new System.EventHandler(this.btnTaBortProdukt_Click_1);
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.BackColor = System.Drawing.Color.White;
            this.btnAvbryt.Location = new System.Drawing.Point(12, 470);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(61, 58);
            this.btnAvbryt.TabIndex = 65;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(-8, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 3);
            this.label6.TabIndex = 64;
            // 
            // btnSpara
            // 
            this.btnSpara.BackColor = System.Drawing.Color.Yellow;
            this.btnSpara.Location = new System.Drawing.Point(133, 470);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(123, 58);
            this.btnSpara.TabIndex = 63;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = false;
            // 
            // lblProdukt
            // 
            this.lblProdukt.AutoSize = true;
            this.lblProdukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdukt.Location = new System.Drawing.Point(9, 125);
            this.lblProdukt.Name = "lblProdukt";
            this.lblProdukt.Size = new System.Drawing.Size(54, 16);
            this.lblProdukt.TabIndex = 62;
            this.lblProdukt.Text = "Produkt";
            // 
            // lblProduktID
            // 
            this.lblProduktID.AutoSize = true;
            this.lblProduktID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduktID.Location = new System.Drawing.Point(9, 71);
            this.lblProduktID.Name = "lblProduktID";
            this.lblProduktID.Size = new System.Drawing.Size(67, 16);
            this.lblProduktID.TabIndex = 61;
            this.lblProduktID.Text = "ProduktID";
            // 
            // lblRedigeraProdukt
            // 
            this.lblRedigeraProdukt.AutoSize = true;
            this.lblRedigeraProdukt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedigeraProdukt.Location = new System.Drawing.Point(8, 18);
            this.lblRedigeraProdukt.Name = "lblRedigeraProdukt";
            this.lblRedigeraProdukt.Size = new System.Drawing.Size(158, 22);
            this.lblRedigeraProdukt.TabIndex = 60;
            this.lblRedigeraProdukt.Text = "Redigera Produkt";
            // 
            // tbProduktID
            // 
            this.tbProduktID.Location = new System.Drawing.Point(12, 90);
            this.tbProduktID.Name = "tbProduktID";
            this.tbProduktID.Size = new System.Drawing.Size(239, 20);
            this.tbProduktID.TabIndex = 59;
            this.tbProduktID.TextChanged += new System.EventHandler(this.tbProduktID_TextChanged);
            // 
            // tbProduktNamn
            // 
            this.tbProduktNamn.Location = new System.Drawing.Point(12, 144);
            this.tbProduktNamn.Name = "tbProduktNamn";
            this.tbProduktNamn.Size = new System.Drawing.Size(239, 20);
            this.tbProduktNamn.TabIndex = 58;
            this.tbProduktNamn.TextChanged += new System.EventHandler(this.tbProduktNamn_TextChanged);
            // 
            // cmbProduktgrupp
            // 
            this.cmbProduktgrupp.FormattingEnabled = true;
            this.cmbProduktgrupp.Location = new System.Drawing.Point(12, 197);
            this.cmbProduktgrupp.Name = "cmbProduktgrupp";
            this.cmbProduktgrupp.Size = new System.Drawing.Size(131, 21);
            this.cmbProduktgrupp.TabIndex = 73;
            this.cmbProduktgrupp.SelectedIndexChanged += new System.EventHandler(this.cmbProduktgrupp_SelectedIndexChanged);
            // 
            // cmbProduktkategori
            // 
            this.cmbProduktkategori.FormattingEnabled = true;
            this.cmbProduktkategori.Location = new System.Drawing.Point(12, 265);
            this.cmbProduktkategori.Name = "cmbProduktkategori";
            this.cmbProduktkategori.Size = new System.Drawing.Size(131, 21);
            this.cmbProduktkategori.TabIndex = 74;
            this.cmbProduktkategori.SelectedIndexChanged += new System.EventHandler(this.cmbProduktkategori_SelectedIndexChanged);
            // 
            // cmbAvdelning
            // 
            this.cmbAvdelning.FormattingEnabled = true;
            this.cmbAvdelning.Location = new System.Drawing.Point(11, 331);
            this.cmbAvdelning.Name = "cmbAvdelning";
            this.cmbAvdelning.Size = new System.Drawing.Size(239, 21);
            this.cmbAvdelning.TabIndex = 75;
            this.cmbAvdelning.SelectedIndexChanged += new System.EventHandler(this.cmbAvdelning_SelectedIndexChanged);
            // 
            // btnSkapaNyProdukGrupp
            // 
            this.btnSkapaNyProdukGrupp.Location = new System.Drawing.Point(149, 197);
            this.btnSkapaNyProdukGrupp.Name = "btnSkapaNyProdukGrupp";
            this.btnSkapaNyProdukGrupp.Size = new System.Drawing.Size(101, 51);
            this.btnSkapaNyProdukGrupp.TabIndex = 76;
            this.btnSkapaNyProdukGrupp.Text = "Skapa ny produktgrupp";
            this.btnSkapaNyProdukGrupp.UseVisualStyleBackColor = true;
            // 
            // btnSkapaNyProduktKategori
            // 
            this.btnSkapaNyProduktKategori.Location = new System.Drawing.Point(150, 265);
            this.btnSkapaNyProduktKategori.Name = "btnSkapaNyProduktKategori";
            this.btnSkapaNyProduktKategori.Size = new System.Drawing.Size(101, 51);
            this.btnSkapaNyProduktKategori.TabIndex = 77;
            this.btnSkapaNyProduktKategori.Text = "Skapa ny produktkategori";
            this.btnSkapaNyProduktKategori.UseVisualStyleBackColor = true;
            // 
            // frmRedigeraProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(272, 543);
            this.Controls.Add(this.btnSkapaNyProduktKategori);
            this.Controls.Add(this.btnSkapaNyProdukGrupp);
            this.Controls.Add(this.cmbAvdelning);
            this.Controls.Add(this.cmbProduktkategori);
            this.Controls.Add(this.cmbProduktgrupp);
            this.Controls.Add(this.lblAvdelning);
            this.Controls.Add(this.lblProduktkategori);
            this.Controls.Add(this.lblProduktgrupp);
            this.Controls.Add(this.btnTaBortProdukt);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.lblProdukt);
            this.Controls.Add(this.lblProduktID);
            this.Controls.Add(this.lblRedigeraProdukt);
            this.Controls.Add(this.tbProduktID);
            this.Controls.Add(this.tbProduktNamn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRedigeraProdukt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRedigeraProdukt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAvdelning;
        private System.Windows.Forms.Label lblProduktkategori;
        private System.Windows.Forms.Label lblProduktgrupp;
        private System.Windows.Forms.Button btnTaBortProdukt;
        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Label lblProdukt;
        private System.Windows.Forms.Label lblProduktID;
        private System.Windows.Forms.Label lblRedigeraProdukt;
        private System.Windows.Forms.TextBox tbProduktID;
        private System.Windows.Forms.TextBox tbProduktNamn;
        private System.Windows.Forms.ComboBox cmbProduktgrupp;
        private System.Windows.Forms.ComboBox cmbProduktkategori;
        private System.Windows.Forms.ComboBox cmbAvdelning;
        private System.Windows.Forms.Button btnSkapaNyProdukGrupp;
        private System.Windows.Forms.Button btnSkapaNyProduktKategori;
    }
}