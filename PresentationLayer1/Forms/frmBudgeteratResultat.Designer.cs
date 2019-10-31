namespace PresentationLayer1.Forms
{
    partial class frmBudgeteratResultat
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
            this.lblSök = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.btnRensa = new System.Windows.Forms.Button();
            this.btnSök = new System.Windows.Forms.Button();
            this.tbSök = new System.Windows.Forms.TextBox();
            this.dgvBudgeteratResultat = new System.Windows.Forms.DataGridView();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnExportera = new System.Windows.Forms.Button();
            this.ucMeny = new PresentationLayer1.Forms.ucMeny();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgeteratResultat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSök
            // 
            this.lblSök.AutoSize = true;
            this.lblSök.Location = new System.Drawing.Point(399, 29);
            this.lblSök.Name = "lblSök";
            this.lblSök.Size = new System.Drawing.Size(26, 13);
            this.lblSök.TabIndex = 40;
            this.lblSök.Text = "Sök";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(245, 29);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(46, 13);
            this.lblKategori.TabIndex = 39;
            this.lblKategori.Text = "Kategori";
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(313, 80);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(60, 23);
            this.btnRensa.TabIndex = 38;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(246, 80);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(60, 23);
            this.btnSök.TabIndex = 37;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            // 
            // tbSök
            // 
            this.tbSök.Location = new System.Drawing.Point(402, 45);
            this.tbSök.Name = "tbSök";
            this.tbSök.Size = new System.Drawing.Size(128, 20);
            this.tbSök.TabIndex = 36;
            // 
            // dgvBudgeteratResultat
            // 
            this.dgvBudgeteratResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBudgeteratResultat.Location = new System.Drawing.Point(246, 116);
            this.dgvBudgeteratResultat.Name = "dgvBudgeteratResultat";
            this.dgvBudgeteratResultat.ReadOnly = true;
            this.dgvBudgeteratResultat.RowHeadersWidth = 62;
            this.dgvBudgeteratResultat.Size = new System.Drawing.Size(525, 265);
            this.dgvBudgeteratResultat.TabIndex = 32;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(246, 45);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 41;
            // 
            // btnExportera
            // 
            this.btnExportera.Location = new System.Drawing.Point(246, 387);
            this.btnExportera.Name = "btnExportera";
            this.btnExportera.Size = new System.Drawing.Size(120, 41);
            this.btnExportera.TabIndex = 83;
            this.btnExportera.Text = "Exportera";
            this.btnExportera.UseVisualStyleBackColor = true;
            //
            // ucMeny
            //
            this.ucMeny.Location = new System.Drawing.Point(8, 8);
            this.ucMeny.Name = "ucMeny";
            this.ucMeny.Size = new System.Drawing.Size(194, 438);
            this.ucMeny.TabIndex = 5;
            // 
            // frmBudgeteratResultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExportera);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.lblSök);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.btnRensa);
            this.Controls.Add(this.btnSök);
            this.Controls.Add(this.tbSök);
            this.Controls.Add(this.dgvBudgeteratResultat);
            this.Controls.Add(this.ucMeny);
            this.Name = "frmBudgeteratResultat";
            this.Text = "Budgeterat Resultat | G4 Solutions Economy System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgeteratResultat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSök;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Button btnRensa;
        private System.Windows.Forms.Button btnSök;
        private System.Windows.Forms.TextBox tbSök;
        private System.Windows.Forms.DataGridView dgvBudgeteratResultat;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnExportera;
        private Forms.ucMeny ucMeny;
    }
}