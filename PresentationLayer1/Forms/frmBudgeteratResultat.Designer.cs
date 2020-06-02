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
            this.btnExportAllt = new System.Windows.Forms.Button();
            this.shadowGridBudget = new System.Windows.Forms.DataGridView();
            this.ucMeny = new PresentationLayer1.Forms.ucMeny();
            this.btnExportera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgeteratResultat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowGridBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSök
            // 
            this.lblSök.AutoSize = true;
            this.lblSök.Location = new System.Drawing.Point(361, 41);
            this.lblSök.Name = "lblSök";
            this.lblSök.Size = new System.Drawing.Size(100, 13);
            this.lblSök.TabIndex = 40;
            this.lblSök.Text = "Sök på produktnam";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(207, 41);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(46, 13);
            this.lblKategori.TabIndex = 39;
            this.lblKategori.Text = "Kategori";
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(528, 57);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(60, 23);
            this.btnRensa.TabIndex = 38;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            this.btnRensa.Click += new System.EventHandler(this.btnRensa_Click);
            // 
            // tbSök
            // 
            this.tbSök.Location = new System.Drawing.Point(364, 57);
            this.tbSök.Name = "tbSök";
            this.tbSök.Size = new System.Drawing.Size(128, 20);
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
            this.dgvBudgeteratResultat.Location = new System.Drawing.Point(209, 86);
            this.dgvBudgeteratResultat.Name = "dgvBudgeteratResultat";
            this.dgvBudgeteratResultat.ReadOnly = true;
            this.dgvBudgeteratResultat.RowHeadersWidth = 62;
            this.dgvBudgeteratResultat.Size = new System.Drawing.Size(614, 265);
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
            this.cmbKategori.Location = new System.Drawing.Point(208, 57);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 41;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 84;
            this.label1.Text = "Sök";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Budgeterade Intäkter";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "Budgeterade Kostnader";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Budgeterat Resultat";
            // 
            // lblBudgeteradeIntäkter
            // 
            this.lblBudgeteradeIntäkter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBudgeteradeIntäkter.AutoSize = true;
            this.lblBudgeteradeIntäkter.Location = new System.Drawing.Point(361, 362);
            this.lblBudgeteradeIntäkter.Name = "lblBudgeteradeIntäkter";
            this.lblBudgeteradeIntäkter.Size = new System.Drawing.Size(13, 13);
            this.lblBudgeteradeIntäkter.TabIndex = 88;
            this.lblBudgeteradeIntäkter.Text = "0";
            // 
            // lblBudgetKostnader
            // 
            this.lblBudgetKostnader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBudgetKostnader.AutoSize = true;
            this.lblBudgetKostnader.Location = new System.Drawing.Point(361, 384);
            this.lblBudgetKostnader.Name = "lblBudgetKostnader";
            this.lblBudgetKostnader.Size = new System.Drawing.Size(13, 13);
            this.lblBudgetKostnader.TabIndex = 89;
            this.lblBudgetKostnader.Text = "0";
            // 
            // lblResultat
            // 
            this.lblResultat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(361, 419);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(13, 13);
            this.lblResultat.TabIndex = 90;
            this.lblResultat.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(214, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 10);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            // 
            // btnExportAllt
            // 
            this.btnExportAllt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportAllt.Location = new System.Drawing.Point(680, 378);
            this.btnExportAllt.Name = "btnExportAllt";
            this.btnExportAllt.Size = new System.Drawing.Size(143, 56);
            this.btnExportAllt.TabIndex = 92;
            this.btnExportAllt.Text = "Exporta alla poster";
            this.btnExportAllt.UseVisualStyleBackColor = true;
            this.btnExportAllt.Click += new System.EventHandler(this.btnExporteraAllt);
            // 
            // shadowGridBudget
            // 
            this.shadowGridBudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shadowGridBudget.Location = new System.Drawing.Point(785, 41);
            this.shadowGridBudget.Name = "shadowGridBudget";
            this.shadowGridBudget.RowHeadersWidth = 51;
            this.shadowGridBudget.Size = new System.Drawing.Size(27, 26);
            this.shadowGridBudget.TabIndex = 93;
            this.shadowGridBudget.Visible = false;
            // 
            // ucMeny
            // 
            this.ucMeny.Location = new System.Drawing.Point(8, 8);
            this.ucMeny.Margin = new System.Windows.Forms.Padding(4);
            this.ucMeny.Name = "ucMeny";
            this.ucMeny.Size = new System.Drawing.Size(194, 438);
            this.ucMeny.TabIndex = 5;
            // 
            // btnExportera
            // 
            this.btnExportera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportera.Location = new System.Drawing.Point(455, 408);
            this.btnExportera.Name = "btnExportera";
            this.btnExportera.Size = new System.Drawing.Size(219, 26);
            this.btnExportera.TabIndex = 83;
            this.btnExportera.Text = "Exportera markerad produkt";
            this.btnExportera.UseVisualStyleBackColor = true;
            this.btnExportera.Click += new System.EventHandler(this.btnExportera_Click);
            // 
            // frmBudgeteratResultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
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
            this.Controls.Add(this.btnExportera);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.lblSök);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.btnRensa);
            this.Controls.Add(this.tbSök);
            this.Controls.Add(this.dgvBudgeteratResultat);
            this.Controls.Add(this.ucMeny);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnExportera;
    }
}