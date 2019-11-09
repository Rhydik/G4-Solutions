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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdukter));
            this.btnRegistreraNyProdukt = new System.Windows.Forms.Button();
            this.btnRedigeraProdukt = new System.Windows.Forms.Button();
            this.dgvProdukter = new System.Windows.Forms.DataGridView();
            this.lblSök = new System.Windows.Forms.Label();
            this.ucSökFältProdukt = new PresentationLayer1.Forms.ucSökFältProdukt();
            this.ucMeny = new PresentationLayer1.Forms.ucMeny();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistreraNyProdukt
            // 
            this.btnRegistreraNyProdukt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistreraNyProdukt.Location = new System.Drawing.Point(710, 397);
            this.btnRegistreraNyProdukt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnRedigeraProdukt.Location = new System.Drawing.Point(583, 396);
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
            this.dgvProdukter.Location = new System.Drawing.Point(208, 121);
            this.dgvProdukter.Name = "dgvProdukter";
            this.dgvProdukter.RowHeadersWidth = 62;
            this.dgvProdukter.Size = new System.Drawing.Size(614, 268);
            this.dgvProdukter.TabIndex = 20;
            this.dgvProdukter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdukter_CellContentClick);
            // 
            // lblSök
            // 
            this.lblSök.AutoSize = true;
            this.lblSök.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSök.Location = new System.Drawing.Point(204, 26);
            this.lblSök.Name = "lblSök";
            this.lblSök.Size = new System.Drawing.Size(45, 24);
            this.lblSök.TabIndex = 48;
            this.lblSök.Text = "Sök";
            // 
            // ucSökFältProdukt
            // 
            this.ucSökFältProdukt.Location = new System.Drawing.Point(208, 53);
            this.ucSökFältProdukt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucSökFältProdukt.Name = "ucSökFältProdukt";
            this.ucSökFältProdukt.Size = new System.Drawing.Size(534, 53);
            this.ucSökFältProdukt.TabIndex = 49;
            // 
            // ucMeny
            // 
            this.ucMeny.Location = new System.Drawing.Point(8, 8);
            this.ucMeny.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucMeny.Name = "ucMeny";
            this.ucMeny.Size = new System.Drawing.Size(194, 438);
            this.ucMeny.TabIndex = 5;
            // 
            // frmProdukter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.ucSökFältProdukt);
            this.Controls.Add(this.lblSök);
            this.Controls.Add(this.btnRegistreraNyProdukt);
            this.Controls.Add(this.btnRedigeraProdukt);
            this.Controls.Add(this.dgvProdukter);
            this.Controls.Add(this.ucMeny);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProdukter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkter | G4 Solutions Economy System";
            this.Load += new System.EventHandler(this.frmProdukter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegistreraNyProdukt;
        private System.Windows.Forms.Button btnRedigeraProdukt;
        public System.Windows.Forms.DataGridView dgvProdukter;
        private Forms.ucMeny ucMeny;
        private System.Windows.Forms.Label lblSök;
        private ucSökFältProdukt ucSökFältProdukt;
    }
}