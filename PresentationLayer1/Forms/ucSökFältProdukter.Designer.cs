namespace PresentationLayer1.Forms
{
    partial class ucSökFältProdukter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProduktgrupp = new System.Windows.Forms.Label();
            this.lblProdukt = new System.Windows.Forms.Label();
            this.lblProduktID = new System.Windows.Forms.Label();
            this.btnRensa = new System.Windows.Forms.Button();
            this.cmbProduktgrupp = new System.Windows.Forms.ComboBox();
            this.tbNamn = new System.Windows.Forms.TextBox();
            this.tbProduktID = new System.Windows.Forms.TextBox();
            this.lblProduktkategori = new System.Windows.Forms.Label();
            this.lblAvdelning = new System.Windows.Forms.Label();
            this.cmbAvdelning = new System.Windows.Forms.ComboBox();
            this.cmbProduktkategori = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblProduktgrupp
            // 
            this.lblProduktgrupp.AutoSize = true;
            this.lblProduktgrupp.Location = new System.Drawing.Point(182, 3);
            this.lblProduktgrupp.Name = "lblProduktgrupp";
            this.lblProduktgrupp.Size = new System.Drawing.Size(71, 13);
            this.lblProduktgrupp.TabIndex = 54;
            this.lblProduktgrupp.Text = "Produktgrupp";
            // 
            // lblProdukt
            // 
            this.lblProdukt.AutoSize = true;
            this.lblProdukt.Location = new System.Drawing.Point(96, 5);
            this.lblProdukt.Name = "lblProdukt";
            this.lblProdukt.Size = new System.Drawing.Size(44, 13);
            this.lblProdukt.TabIndex = 53;
            this.lblProdukt.Text = "Produkt";
            // 
            // lblProduktID
            // 
            this.lblProduktID.AutoSize = true;
            this.lblProduktID.Location = new System.Drawing.Point(1, 3);
            this.lblProduktID.Name = "lblProduktID";
            this.lblProduktID.Size = new System.Drawing.Size(55, 13);
            this.lblProduktID.TabIndex = 52;
            this.lblProduktID.Text = "ProduktID";
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(471, 18);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(60, 23);
            this.btnRensa.TabIndex = 51;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            this.btnRensa.Click += new System.EventHandler(this.btnRensa_Click);
            // 
            // cmbProduktgrupp
            // 
            this.cmbProduktgrupp.BackColor = System.Drawing.SystemColors.Window;
            this.cmbProduktgrupp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduktgrupp.FormattingEnabled = true;
            this.cmbProduktgrupp.Location = new System.Drawing.Point(185, 20);
            this.cmbProduktgrupp.Name = "cmbProduktgrupp";
            this.cmbProduktgrupp.Size = new System.Drawing.Size(84, 21);
            this.cmbProduktgrupp.TabIndex = 50;
            // 
            // tbNamn
            // 
            this.tbNamn.Location = new System.Drawing.Point(99, 21);
            this.tbNamn.Name = "tbNamn";
            this.tbNamn.Size = new System.Drawing.Size(80, 20);
            this.tbNamn.TabIndex = 49;
            // 
            // tbProduktID
            // 
            this.tbProduktID.Location = new System.Drawing.Point(3, 20);
            this.tbProduktID.Name = "tbProduktID";
            this.tbProduktID.Size = new System.Drawing.Size(90, 20);
            this.tbProduktID.TabIndex = 48;
            // 
            // lblProduktkategori
            // 
            this.lblProduktkategori.AutoSize = true;
            this.lblProduktkategori.Location = new System.Drawing.Point(272, 5);
            this.lblProduktkategori.Name = "lblProduktkategori";
            this.lblProduktkategori.Size = new System.Drawing.Size(82, 13);
            this.lblProduktkategori.TabIndex = 55;
            this.lblProduktkategori.Text = "Produktkategori";
            // 
            // lblAvdelning
            // 
            this.lblAvdelning.AutoSize = true;
            this.lblAvdelning.Location = new System.Drawing.Point(370, 5);
            this.lblAvdelning.Name = "lblAvdelning";
            this.lblAvdelning.Size = new System.Drawing.Size(54, 13);
            this.lblAvdelning.TabIndex = 56;
            this.lblAvdelning.Text = "Avdelning";
            // 
            // cmbAvdelning
            // 
            this.cmbAvdelning.BackColor = System.Drawing.SystemColors.Window;
            this.cmbAvdelning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvdelning.FormattingEnabled = true;
            this.cmbAvdelning.Location = new System.Drawing.Point(373, 19);
            this.cmbAvdelning.Name = "cmbAvdelning";
            this.cmbAvdelning.Size = new System.Drawing.Size(92, 21);
            this.cmbAvdelning.TabIndex = 57;
            // 
            // cmbProduktkategori
            // 
            this.cmbProduktkategori.BackColor = System.Drawing.SystemColors.Window;
            this.cmbProduktkategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduktkategori.FormattingEnabled = true;
            this.cmbProduktkategori.Location = new System.Drawing.Point(275, 19);
            this.cmbProduktkategori.Name = "cmbProduktkategori";
            this.cmbProduktkategori.Size = new System.Drawing.Size(92, 21);
            this.cmbProduktkategori.TabIndex = 58;
            // 
            // ucSökFältProdukter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbProduktkategori);
            this.Controls.Add(this.cmbAvdelning);
            this.Controls.Add(this.lblAvdelning);
            this.Controls.Add(this.lblProduktkategori);
            this.Controls.Add(this.lblProduktgrupp);
            this.Controls.Add(this.lblProdukt);
            this.Controls.Add(this.lblProduktID);
            this.Controls.Add(this.btnRensa);
            this.Controls.Add(this.cmbProduktgrupp);
            this.Controls.Add(this.tbNamn);
            this.Controls.Add(this.tbProduktID);
            this.Name = "ucSökFältProdukter";
            this.Size = new System.Drawing.Size(534, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduktgrupp;
        private System.Windows.Forms.Label lblProdukt;
        private System.Windows.Forms.Label lblProduktID;
        private System.Windows.Forms.Button btnRensa;
        private System.Windows.Forms.ComboBox cmbProduktgrupp;
        private System.Windows.Forms.TextBox tbNamn;
        private System.Windows.Forms.TextBox tbProduktID;
        private System.Windows.Forms.Label lblProduktkategori;
        private System.Windows.Forms.Label lblAvdelning;
        private System.Windows.Forms.ComboBox cmbAvdelning;
        private System.Windows.Forms.ComboBox cmbProduktkategori;
    }
}
