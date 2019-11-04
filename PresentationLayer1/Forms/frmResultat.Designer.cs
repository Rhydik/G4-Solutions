namespace PresentationLayer1.Forms
{
    partial class frmResultat
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
            this.btnExportera = new System.Windows.Forms.Button();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblSök = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.btnRensa = new System.Windows.Forms.Button();
            this.btnSök = new System.Windows.Forms.Button();
            this.tbSök = new System.Windows.Forms.TextBox();
            this.dgvBudgeteratResultat = new System.Windows.Forms.DataGridView();
            this.ucMeny = new PresentationLayer1.Forms.ucMeny();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgeteratResultat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportera
            // 
            this.btnExportera.Location = new System.Drawing.Point(208, 397);
            this.btnExportera.Name = "btnExportera";
            this.btnExportera.Size = new System.Drawing.Size(120, 41);
            this.btnExportera.TabIndex = 92;
            this.btnExportera.Text = "Exportera";
            this.btnExportera.UseVisualStyleBackColor = true;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(207, 80);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 91;
            // 
            // lblSök
            // 
            this.lblSök.AutoSize = true;
            this.lblSök.Location = new System.Drawing.Point(360, 64);
            this.lblSök.Name = "lblSök";
            this.lblSök.Size = new System.Drawing.Size(26, 13);
            this.lblSök.TabIndex = 90;
            this.lblSök.Text = "Sök";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(206, 64);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(46, 13);
            this.lblKategori.TabIndex = 89;
            this.lblKategori.Text = "Kategori";
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(509, 80);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(60, 23);
            this.btnRensa.TabIndex = 88;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(762, 8);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(60, 23);
            this.btnSök.TabIndex = 87;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            // 
            // tbSök
            // 
            this.tbSök.Location = new System.Drawing.Point(363, 80);
            this.tbSök.Name = "tbSök";
            this.tbSök.Size = new System.Drawing.Size(128, 20);
            this.tbSök.TabIndex = 86;
            // 
            // dgvBudgeteratResultat
            // 
            this.dgvBudgeteratResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBudgeteratResultat.Location = new System.Drawing.Point(208, 119);
            this.dgvBudgeteratResultat.Name = "dgvBudgeteratResultat";
            this.dgvBudgeteratResultat.ReadOnly = true;
            this.dgvBudgeteratResultat.RowHeadersWidth = 62;
            this.dgvBudgeteratResultat.Size = new System.Drawing.Size(614, 268);
            this.dgvBudgeteratResultat.TabIndex = 85;
            // 
            // ucMeny
            // 
            this.ucMeny.Location = new System.Drawing.Point(8, 8);
            this.ucMeny.Name = "ucMeny";
            this.ucMeny.Size = new System.Drawing.Size(194, 438);
            this.ucMeny.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 93;
            this.label1.Text = "Sök";
            // 
            // frmResultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportera);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.lblSök);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.btnRensa);
            this.Controls.Add(this.btnSök);
            this.Controls.Add(this.tbSök);
            this.Controls.Add(this.dgvBudgeteratResultat);
            this.Controls.Add(this.ucMeny);
            this.Name = "frmResultat";
            this.Text = "Resultat  | G4 Solutions Economy System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgeteratResultat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportera;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label lblSök;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Button btnRensa;
        private System.Windows.Forms.Button btnSök;
        private System.Windows.Forms.TextBox tbSök;
        private System.Windows.Forms.DataGridView dgvBudgeteratResultat;
        private Forms.ucMeny ucMeny;
        private System.Windows.Forms.Label label1;
    }
}