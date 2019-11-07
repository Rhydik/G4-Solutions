namespace PresentationLayer1.Forms
{
    partial class frmKostnadsbudgetering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKostnadsbudgetering));
            this.dgvÖvre = new System.Windows.Forms.DataGridView();
            this.btnExportera = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.btnLåsBudget = new System.Windows.Forms.Button();
            this.cmbAvdelning = new System.Windows.Forms.ComboBox();
            this.lblAvdelning = new System.Windows.Forms.Label();
            this.btnPlacering = new System.Windows.Forms.Button();
            this.btnDirektaKostnaderProdukt = new System.Windows.Forms.Button();
            this.btnDirektaKostnaderAktivitet = new System.Windows.Forms.Button();
            this.dgvNedre = new System.Windows.Forms.DataGridView();
            this.ucMeny = new PresentationLayer1.Forms.ucMeny();
            ((System.ComponentModel.ISupportInitialize)(this.dgvÖvre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNedre)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvÖvre
            // 
            this.dgvÖvre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvÖvre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvÖvre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvÖvre.Location = new System.Drawing.Point(277, 84);
            this.dgvÖvre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvÖvre.Name = "dgvÖvre";
            this.dgvÖvre.ReadOnly = true;
            this.dgvÖvre.RowHeadersWidth = 62;
            this.dgvÖvre.Size = new System.Drawing.Size(707, 562);
            this.dgvÖvre.TabIndex = 59;
            // 
            // btnExportera
            // 
            this.btnExportera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportera.Location = new System.Drawing.Point(277, 654);
            this.btnExportera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportera.Name = "btnExportera";
            this.btnExportera.Size = new System.Drawing.Size(160, 50);
            this.btnExportera.TabIndex = 69;
            this.btnExportera.Text = "Exportera";
            this.btnExportera.UseVisualStyleBackColor = true;
            // 
            // btnSpara
            // 
            this.btnSpara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpara.Location = new System.Drawing.Point(1523, 654);
            this.btnSpara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(160, 50);
            this.btnSpara.TabIndex = 60;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            // 
            // btnLåsBudget
            // 
            this.btnLåsBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLåsBudget.Location = new System.Drawing.Point(1355, 654);
            this.btnLåsBudget.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLåsBudget.Name = "btnLåsBudget";
            this.btnLåsBudget.Size = new System.Drawing.Size(160, 50);
            this.btnLåsBudget.TabIndex = 68;
            this.btnLåsBudget.Text = "Lås Budget";
            this.btnLåsBudget.UseVisualStyleBackColor = true;
            // 
            // cmbAvdelning
            // 
            this.cmbAvdelning.FormattingEnabled = true;
            this.cmbAvdelning.Items.AddRange(new object[] {
            "Driftavdelning",
            "Utveckling- och förvaltning"});
            this.cmbAvdelning.Location = new System.Drawing.Point(1237, 50);
            this.cmbAvdelning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAvdelning.Name = "cmbAvdelning";
            this.cmbAvdelning.Size = new System.Drawing.Size(160, 24);
            this.cmbAvdelning.TabIndex = 70;
            // 
            // lblAvdelning
            // 
            this.lblAvdelning.AutoSize = true;
            this.lblAvdelning.Location = new System.Drawing.Point(1233, 31);
            this.lblAvdelning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvdelning.Name = "lblAvdelning";
            this.lblAvdelning.Size = new System.Drawing.Size(68, 16);
            this.lblAvdelning.TabIndex = 71;
            this.lblAvdelning.Text = "Avdelning";
            // 
            // btnPlacering
            // 
            this.btnPlacering.Location = new System.Drawing.Point(732, 26);
            this.btnPlacering.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlacering.Name = "btnPlacering";
            this.btnPlacering.Size = new System.Drawing.Size(160, 50);
            this.btnPlacering.TabIndex = 72;
            this.btnPlacering.Text = "Placering";
            this.btnPlacering.UseVisualStyleBackColor = true;
            // 
            // btnDirektaKostnaderProdukt
            // 
            this.btnDirektaKostnaderProdukt.Location = new System.Drawing.Point(901, 26);
            this.btnDirektaKostnaderProdukt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDirektaKostnaderProdukt.Name = "btnDirektaKostnaderProdukt";
            this.btnDirektaKostnaderProdukt.Size = new System.Drawing.Size(160, 50);
            this.btnDirektaKostnaderProdukt.TabIndex = 73;
            this.btnDirektaKostnaderProdukt.Text = "Direkta kostnader produkt";
            this.btnDirektaKostnaderProdukt.UseVisualStyleBackColor = true;
            // 
            // btnDirektaKostnaderAktivitet
            // 
            this.btnDirektaKostnaderAktivitet.Location = new System.Drawing.Point(1069, 26);
            this.btnDirektaKostnaderAktivitet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDirektaKostnaderAktivitet.Name = "btnDirektaKostnaderAktivitet";
            this.btnDirektaKostnaderAktivitet.Size = new System.Drawing.Size(160, 50);
            this.btnDirektaKostnaderAktivitet.TabIndex = 74;
            this.btnDirektaKostnaderAktivitet.Text = "Direkta kostnader aktivitet";
            this.btnDirektaKostnaderAktivitet.UseVisualStyleBackColor = true;
            // 
            // dgvNedre
            // 
            this.dgvNedre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNedre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNedre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNedre.Location = new System.Drawing.Point(992, 84);
            this.dgvNedre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNedre.Name = "dgvNedre";
            this.dgvNedre.Size = new System.Drawing.Size(691, 562);
            this.dgvNedre.TabIndex = 75;
            // 
            // ucMeny
            // 
            this.ucMeny.Location = new System.Drawing.Point(11, 10);
            this.ucMeny.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucMeny.Name = "ucMeny";
            this.ucMeny.Size = new System.Drawing.Size(259, 539);
            this.ucMeny.TabIndex = 5;
            // 
            // frmKostnadsbudgetering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1699, 719);
            this.Controls.Add(this.dgvNedre);
            this.Controls.Add(this.btnDirektaKostnaderAktivitet);
            this.Controls.Add(this.btnDirektaKostnaderProdukt);
            this.Controls.Add(this.btnPlacering);
            this.Controls.Add(this.lblAvdelning);
            this.Controls.Add(this.cmbAvdelning);
            this.Controls.Add(this.dgvÖvre);
            this.Controls.Add(this.btnExportera);
            this.Controls.Add(this.btnLåsBudget);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.ucMeny);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmKostnadsbudgetering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kostnadsbudgetering  | G4 Solutions Economy System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvÖvre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNedre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvÖvre;
        private System.Windows.Forms.Button btnExportera;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Button btnLåsBudget;
        private System.Windows.Forms.ComboBox cmbAvdelning;
        private System.Windows.Forms.Label lblAvdelning;
        private System.Windows.Forms.Button btnPlacering;
        private System.Windows.Forms.Button btnDirektaKostnaderProdukt;
        private System.Windows.Forms.Button btnDirektaKostnaderAktivitet;
        private Forms.ucMeny ucMeny;
        private System.Windows.Forms.DataGridView dgvNedre;
    }
}