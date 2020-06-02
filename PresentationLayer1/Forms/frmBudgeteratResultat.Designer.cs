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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBudgeteratResultat));
            this.lblSök = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.btnRensa = new System.Windows.Forms.Button();
            this.tbSök = new System.Windows.Forms.TextBox();
            this.dgvBudgeteratResultat = new System.Windows.Forms.DataGridView();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBudgeteradeIntäkter = new System.Windows.Forms.Label();
            this.lblBudgetKostnader = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucMeny = new PresentationLayer1.Forms.ucMeny();
            this.btnExportAllt = new System.Windows.Forms.Button();
            this.shadowGridBudget = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgeteratResultat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowGridBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSök
            // 
            this.lblSök.AutoSize = true;
            this.lblSök.Location = new System.Drawing.Point(962, 97);
            this.lblSök.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblSök.Name = "lblSök";
            this.lblSök.Size = new System.Drawing.Size(260, 32);
            this.lblSök.TabIndex = 40;
            this.lblSök.Text = "Sök på produktnam";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(552, 97);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(122, 32);
            this.lblKategori.TabIndex = 39;
            this.lblKategori.Text = "Kategori";
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(1408, 136);
            this.btnRensa.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(160, 54);
            this.btnRensa.TabIndex = 38;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            this.btnRensa.Click += new System.EventHandler(this.btnRensa_Click);
            // 
            // tbSök
            // 
            this.tbSök.Location = new System.Drawing.Point(970, 136);
            this.tbSök.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tbSök.Name = "tbSök";
            this.tbSök.Size = new System.Drawing.Size(334, 38);
            this.tbSök.TabIndex = 36;
            this.tbSök.TextChanged += new System.EventHandler(this.tbSök_TextChanged);
            // 
            // dgvBudgeteratResultat
            // 
            this.dgvBudgeteratResultat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBudgeteratResultat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBudgeteratResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBudgeteratResultat.Location = new System.Drawing.Point(558, 205);
            this.dgvBudgeteratResultat.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.dgvBudgeteratResultat.Name = "dgvBudgeteratResultat";
            this.dgvBudgeteratResultat.ReadOnly = true;
            this.dgvBudgeteratResultat.RowHeadersWidth = 62;
            this.dgvBudgeteratResultat.Size = new System.Drawing.Size(1638, 632);
            this.dgvBudgeteratResultat.TabIndex = 32;
            this.dgvBudgeteratResultat.SelectionChanged += new System.EventHandler(this.dgvBudgeteratResultat_SelectionChanged);
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Produkt",
            "Produktgrupp",
            "Produktionsavdelning",
            "Kontoret"});
            this.cmbKategori.Location = new System.Drawing.Point(554, 136);
            this.cmbKategori.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(316, 39);
            this.cmbKategori.TabIndex = 41;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 55);
            this.label1.TabIndex = 84;
            this.label1.Text = "Sök";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 864);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 32);
            this.label2.TabIndex = 85;
            this.label2.Text = "Budgeterade Intäkter";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 916);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 32);
            this.label3.TabIndex = 86;
            this.label3.Text = "Budgeterade Kostnader";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 1000);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 32);
            this.label4.TabIndex = 87;
            this.label4.Text = "Budgeterat Resultat";
            // 
            // lblBudgeteradeIntäkter
            // 
            this.lblBudgeteradeIntäkter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBudgeteradeIntäkter.AutoSize = true;
            this.lblBudgeteradeIntäkter.Location = new System.Drawing.Point(962, 864);
            this.lblBudgeteradeIntäkter.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblBudgeteradeIntäkter.Name = "lblBudgeteradeIntäkter";
            this.lblBudgeteradeIntäkter.Size = new System.Drawing.Size(31, 32);
            this.lblBudgeteradeIntäkter.TabIndex = 88;
            this.lblBudgeteradeIntäkter.Text = "0";
            // 
            // lblBudgetKostnader
            // 
            this.lblBudgetKostnader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBudgetKostnader.AutoSize = true;
            this.lblBudgetKostnader.Location = new System.Drawing.Point(962, 916);
            this.lblBudgetKostnader.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblBudgetKostnader.Name = "lblBudgetKostnader";
            this.lblBudgetKostnader.Size = new System.Drawing.Size(31, 32);
            this.lblBudgetKostnader.TabIndex = 89;
            this.lblBudgetKostnader.Text = "0";
            // 
            // lblResultat
            // 
            this.lblResultat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(962, 1000);
            this.lblResultat.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(31, 32);
            this.lblResultat.TabIndex = 90;
            this.lblResultat.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(570, 953);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox1.Size = new System.Drawing.Size(534, 23);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            // 
            // ucMeny
            // 
            this.ucMeny.Location = new System.Drawing.Point(22, 19);
            this.ucMeny.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.ucMeny.Name = "ucMeny";
            this.ucMeny.Size = new System.Drawing.Size(518, 1044);
            this.ucMeny.TabIndex = 5;
            // 
            // btnExportAllt
            // 
            this.btnExportAllt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportAllt.Location = new System.Drawing.Point(1799, 901);
            this.btnExportAllt.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnExportAllt.Name = "btnExportAllt";
            this.btnExportAllt.Size = new System.Drawing.Size(397, 134);
            this.btnExportAllt.TabIndex = 92;
            this.btnExportAllt.Text = "Exporta alla poster";
            this.btnExportAllt.UseVisualStyleBackColor = true;
            this.btnExportAllt.Click += new System.EventHandler(this.btnExporteraAllt);
            // 
            // shadowGridBudget
            // 
            this.shadowGridBudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shadowGridBudget.Location = new System.Drawing.Point(2094, 97);
            this.shadowGridBudget.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.shadowGridBudget.Name = "shadowGridBudget";
            this.shadowGridBudget.RowHeadersWidth = 51;
            this.shadowGridBudget.Size = new System.Drawing.Size(72, 62);
            this.shadowGridBudget.TabIndex = 93;
            this.shadowGridBudget.Visible = false;
            // 
            // frmBudgeteratResultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2226, 1073);
            this.Controls.Add(this.shadowGridBudget);
            this.Controls.Add(this.btnExportAllt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.lblBudgetKostnader);
            this.Controls.Add(this.lblBudgeteradeIntäkter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.lblSök);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.btnRensa);
            this.Controls.Add(this.tbSök);
            this.Controls.Add(this.dgvBudgeteratResultat);
            this.Controls.Add(this.ucMeny);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "frmBudgeteratResultat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budgeterat Resultat | G4 Solutions Economy System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgeteratResultat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowGridBudget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSök;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Button btnRensa;
        private System.Windows.Forms.TextBox tbSök;
        private System.Windows.Forms.DataGridView dgvBudgeteratResultat;
        private System.Windows.Forms.ComboBox cmbKategori;
        private Forms.ucMeny ucMeny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBudgeteradeIntäkter;
        private System.Windows.Forms.Label lblBudgetKostnader;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExportAllt;
        private System.Windows.Forms.DataGridView shadowGridBudget;
    }
}