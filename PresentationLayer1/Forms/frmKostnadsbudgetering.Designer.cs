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
            this.dgvPlacering = new System.Windows.Forms.DataGridView();
            this.btnExportera = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.btnLåsBudget = new System.Windows.Forms.Button();
            this.cmbAvdelning = new System.Windows.Forms.ComboBox();
            this.lblAvdelning = new System.Windows.Forms.Label();
            this.btnPlacering = new System.Windows.Forms.Button();
            this.btnDirektaKostnaderProdukt = new System.Windows.Forms.Button();
            this.btnDirektaKostnaderAktivitet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ucMeny = new PresentationLayer1.Forms.ucMeny();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacering)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlacering
            // 
            this.dgvPlacering.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlacering.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlacering.Location = new System.Drawing.Point(354, 94);
            this.dgvPlacering.Name = "dgvPlacering";
            this.dgvPlacering.ReadOnly = true;
            this.dgvPlacering.RowHeadersWidth = 62;
            this.dgvPlacering.Size = new System.Drawing.Size(407, 266);
            this.dgvPlacering.TabIndex = 59;
            // 
            // btnExportera
            // 
            this.btnExportera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportera.Location = new System.Drawing.Point(244, 375);
            this.btnExportera.Name = "btnExportera";
            this.btnExportera.Size = new System.Drawing.Size(120, 41);
            this.btnExportera.TabIndex = 69;
            this.btnExportera.Text = "Exportera";
            this.btnExportera.UseVisualStyleBackColor = true;
            // 
            // btnSpara
            // 
            this.btnSpara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpara.Location = new System.Drawing.Point(642, 375);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(120, 41);
            this.btnSpara.TabIndex = 60;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            // 
            // btnLåsBudget
            // 
            this.btnLåsBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLåsBudget.Location = new System.Drawing.Point(516, 375);
            this.btnLåsBudget.Name = "btnLåsBudget";
            this.btnLåsBudget.Size = new System.Drawing.Size(120, 41);
            this.btnLåsBudget.TabIndex = 68;
            this.btnLåsBudget.Text = "Lås Budget";
            this.btnLåsBudget.UseVisualStyleBackColor = true;
            // 
            // cmbAvdelning
            // 
            this.cmbAvdelning.FormattingEnabled = true;
            this.cmbAvdelning.Location = new System.Drawing.Point(227, 94);
            this.cmbAvdelning.Name = "cmbAvdelning";
            this.cmbAvdelning.Size = new System.Drawing.Size(121, 21);
            this.cmbAvdelning.TabIndex = 70;
            // 
            // lblAvdelning
            // 
            this.lblAvdelning.AutoSize = true;
            this.lblAvdelning.Location = new System.Drawing.Point(225, 78);
            this.lblAvdelning.Name = "lblAvdelning";
            this.lblAvdelning.Size = new System.Drawing.Size(54, 13);
            this.lblAvdelning.TabIndex = 71;
            this.lblAvdelning.Text = "Avdelning";
            // 
            // btnPlacering
            // 
            this.btnPlacering.Location = new System.Drawing.Point(227, 12);
            this.btnPlacering.Name = "btnPlacering";
            this.btnPlacering.Size = new System.Drawing.Size(120, 41);
            this.btnPlacering.TabIndex = 72;
            this.btnPlacering.Text = "Placering";
            this.btnPlacering.UseVisualStyleBackColor = true;
            // 
            // btnDirektaKostnaderProdukt
            // 
            this.btnDirektaKostnaderProdukt.Location = new System.Drawing.Point(354, 12);
            this.btnDirektaKostnaderProdukt.Name = "btnDirektaKostnaderProdukt";
            this.btnDirektaKostnaderProdukt.Size = new System.Drawing.Size(120, 41);
            this.btnDirektaKostnaderProdukt.TabIndex = 73;
            this.btnDirektaKostnaderProdukt.Text = "Direkta kostnader produkt";
            this.btnDirektaKostnaderProdukt.UseVisualStyleBackColor = true;
            // 
            // btnDirektaKostnaderAktivitet
            // 
            this.btnDirektaKostnaderAktivitet.Location = new System.Drawing.Point(480, 12);
            this.btnDirektaKostnaderAktivitet.Name = "btnDirektaKostnaderAktivitet";
            this.btnDirektaKostnaderAktivitet.Size = new System.Drawing.Size(120, 41);
            this.btnDirektaKostnaderAktivitet.TabIndex = 74;
            this.btnDirektaKostnaderAktivitet.Text = "Direkta kostnader aktivitet";
            this.btnDirektaKostnaderAktivitet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "label1";
            //
            // ucMeny
            //
            this.ucMeny.Location = new System.Drawing.Point(8, 8);
            this.ucMeny.Name = "ucMeny";
            this.ucMeny.Size = new System.Drawing.Size(194, 438);
            this.ucMeny.TabIndex = 5;
            // 
            // frmKostnadsbudgetering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDirektaKostnaderAktivitet);
            this.Controls.Add(this.btnDirektaKostnaderProdukt);
            this.Controls.Add(this.btnPlacering);
            this.Controls.Add(this.lblAvdelning);
            this.Controls.Add(this.cmbAvdelning);
            this.Controls.Add(this.dgvPlacering);
            this.Controls.Add(this.btnExportera);
            this.Controls.Add(this.btnLåsBudget);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.ucMeny);
            this.Name = "frmKostnadsbudgetering";
            this.Text = "Kostnadsbudgetering  | G4 Solutions Economy System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacering)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlacering;
        private System.Windows.Forms.Button btnExportera;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Button btnLåsBudget;
        private System.Windows.Forms.ComboBox cmbAvdelning;
        private System.Windows.Forms.Label lblAvdelning;
        private System.Windows.Forms.Button btnPlacering;
        private System.Windows.Forms.Button btnDirektaKostnaderProdukt;
        private System.Windows.Forms.Button btnDirektaKostnaderAktivitet;
        private System.Windows.Forms.Label label1;
        private Forms.ucMeny ucMeny;
    }
}