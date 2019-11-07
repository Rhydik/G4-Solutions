namespace PresentationLayer1
{
    partial class frmKunder
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
            this.dgvKunder = new System.Windows.Forms.DataGridView();
            this.btnRegistreraNyKund = new System.Windows.Forms.Button();
            this.btnRedigeraKund = new System.Windows.Forms.Button();
            this.ucMeny = new PresentationLayer1.Forms.ucMeny();
            this.ucSökFältKund = new PresentationLayer1.Forms.ucSökFältKund();
            this.lblSök = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKunder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKunder
            // 
            this.dgvKunder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKunder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKunder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKunder.Location = new System.Drawing.Point(212, 98);
            this.dgvKunder.Name = "dgvKunder";
            this.dgvKunder.ReadOnly = true;
            this.dgvKunder.RowHeadersWidth = 62;
            this.dgvKunder.Size = new System.Drawing.Size(576, 293);
            this.dgvKunder.TabIndex = 7;
            // 
            // btnRegistreraNyKund
            // 
            this.btnRegistreraNyKund.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistreraNyKund.Location = new System.Drawing.Point(676, 398);
            this.btnRegistreraNyKund.Name = "btnRegistreraNyKund";
            this.btnRegistreraNyKund.Size = new System.Drawing.Size(112, 40);
            this.btnRegistreraNyKund.TabIndex = 11;
            this.btnRegistreraNyKund.Text = "Registrera ny kund";
            this.btnRegistreraNyKund.UseVisualStyleBackColor = true;
            this.btnRegistreraNyKund.Click += new System.EventHandler(this.btnRegistreraNyKund_Click);
            // 
            // btnRedigeraKund
            // 
            this.btnRedigeraKund.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRedigeraKund.Location = new System.Drawing.Point(550, 397);
            this.btnRedigeraKund.Name = "btnRedigeraKund";
            this.btnRedigeraKund.Size = new System.Drawing.Size(120, 41);
            this.btnRedigeraKund.TabIndex = 10;
            this.btnRedigeraKund.Text = "Redigera kund";
            this.btnRedigeraKund.UseVisualStyleBackColor = true;
            this.btnRedigeraKund.Click += new System.EventHandler(this.btnRedigeraKund_Click);
            // 
            // ucMeny
            // 
            this.ucMeny.Location = new System.Drawing.Point(12, 12);
            this.ucMeny.Name = "ucMeny";
            this.ucMeny.Size = new System.Drawing.Size(194, 438);
            this.ucMeny.TabIndex = 20;
            // 
            // ucSökFältKund
            // 
            this.ucSökFältKund.Location = new System.Drawing.Point(212, 39);
            this.ucSökFältKund.Name = "ucSökFältKund";
            this.ucSökFältKund.Size = new System.Drawing.Size(545, 53);
            this.ucSökFältKund.TabIndex = 21;
            // 
            // lblSök
            // 
            this.lblSök.AutoSize = true;
            this.lblSök.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSök.Location = new System.Drawing.Point(212, 12);
            this.lblSök.Name = "lblSök";
            this.lblSök.Size = new System.Drawing.Size(45, 24);
            this.lblSök.TabIndex = 49;
            this.lblSök.Text = "Sök";
            // 
            // frmKunder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSök);
            this.Controls.Add(this.ucSökFältKund);
            this.Controls.Add(this.ucMeny);
            this.Controls.Add(this.btnRegistreraNyKund);
            this.Controls.Add(this.btnRedigeraKund);
            this.Controls.Add(this.dgvKunder);
            this.Name = "frmKunder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kunder | G4 Solutions Economy System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKunder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKunder;
        private System.Windows.Forms.Button btnRegistreraNyKund;
        private System.Windows.Forms.Button btnRedigeraKund;
        private Forms.ucMeny ucMeny;
        private Forms.ucSökFältKund ucSökFältKund;
        private System.Windows.Forms.Label lblSök;
    }
}