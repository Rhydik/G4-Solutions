namespace PresentationLayer1.Forms
{
    partial class frmKostnadAktivitet
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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cmbVäljKonto = new System.Windows.Forms.Label();
            this.cmbVäljAktivitet = new System.Windows.Forms.ComboBox();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.btnExportera = new System.Windows.Forms.Button();
            this.btnLåsBudget = new System.Windows.Forms.Button();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBelopp = new System.Windows.Forms.TextBox();
            this.lblVäljAktivitet = new System.Windows.Forms.Label();
            this.dgvNedre = new System.Windows.Forms.DataGridView();
            this.ucMeny1 = new PresentationLayer1.Forms.ucMeny();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNedre)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(368, 37);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 126;
            // 
            // cmbVäljKonto
            // 
            this.cmbVäljKonto.AutoSize = true;
            this.cmbVäljKonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVäljKonto.Location = new System.Drawing.Point(364, 7);
            this.cmbVäljKonto.Name = "cmbVäljKonto";
            this.cmbVäljKonto.Size = new System.Drawing.Size(105, 24);
            this.cmbVäljKonto.TabIndex = 125;
            this.cmbVäljKonto.Text = "Välj Konto";
            // 
            // cmbVäljAktivitet
            // 
            this.cmbVäljAktivitet.FormattingEnabled = true;
            this.cmbVäljAktivitet.Location = new System.Drawing.Point(220, 40);
            this.cmbVäljAktivitet.Name = "cmbVäljAktivitet";
            this.cmbVäljAktivitet.Size = new System.Drawing.Size(121, 21);
            this.cmbVäljAktivitet.TabIndex = 124;
            // 
            // btnTaBort
            // 
            this.btnTaBort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaBort.Location = new System.Drawing.Point(1073, 497);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(120, 41);
            this.btnTaBort.TabIndex = 123;
            this.btnTaBort.Text = "Ta bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            // 
            // btnExportera
            // 
            this.btnExportera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportera.Location = new System.Drawing.Point(221, 497);
            this.btnExportera.Name = "btnExportera";
            this.btnExportera.Size = new System.Drawing.Size(120, 41);
            this.btnExportera.TabIndex = 122;
            this.btnExportera.Text = "Exportera";
            this.btnExportera.UseVisualStyleBackColor = true;
            // 
            // btnLåsBudget
            // 
            this.btnLåsBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLåsBudget.Location = new System.Drawing.Point(934, 497);
            this.btnLåsBudget.Name = "btnLåsBudget";
            this.btnLåsBudget.Size = new System.Drawing.Size(120, 41);
            this.btnLåsBudget.TabIndex = 121;
            this.btnLåsBudget.Text = "Lås Budget";
            this.btnLåsBudget.UseVisualStyleBackColor = true;
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(668, 33);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(75, 23);
            this.btnLäggTill.TabIndex = 120;
            this.btnLäggTill.Text = "Lägg till";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 119;
            this.label1.Text = "Ange belopp";
            // 
            // tbBelopp
            // 
            this.tbBelopp.Location = new System.Drawing.Point(534, 36);
            this.tbBelopp.Name = "tbBelopp";
            this.tbBelopp.Size = new System.Drawing.Size(128, 20);
            this.tbBelopp.TabIndex = 118;
            // 
            // lblVäljAktivitet
            // 
            this.lblVäljAktivitet.AutoSize = true;
            this.lblVäljAktivitet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVäljAktivitet.Location = new System.Drawing.Point(216, 10);
            this.lblVäljAktivitet.Name = "lblVäljAktivitet";
            this.lblVäljAktivitet.Size = new System.Drawing.Size(122, 24);
            this.lblVäljAktivitet.TabIndex = 117;
            this.lblVäljAktivitet.Text = "Välj Aktivitet";
            // 
            // dgvNedre
            // 
            this.dgvNedre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvNedre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNedre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNedre.Location = new System.Drawing.Point(220, 98);
            this.dgvNedre.Name = "dgvNedre";
            this.dgvNedre.ReadOnly = true;
            this.dgvNedre.RowHeadersWidth = 62;
            this.dgvNedre.Size = new System.Drawing.Size(973, 377);
            this.dgvNedre.TabIndex = 116;
            // 
            // ucMeny1
            // 
            this.ucMeny1.Location = new System.Drawing.Point(12, 15);
            this.ucMeny1.Name = "ucMeny1";
            this.ucMeny1.Size = new System.Drawing.Size(194, 438);
            this.ucMeny1.TabIndex = 127;
            // 
            // frmKostnadAktivitet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 584);
            this.Controls.Add(this.ucMeny1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.cmbVäljKonto);
            this.Controls.Add(this.cmbVäljAktivitet);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnExportera);
            this.Controls.Add(this.btnLåsBudget);
            this.Controls.Add(this.btnLäggTill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBelopp);
            this.Controls.Add(this.lblVäljAktivitet);
            this.Controls.Add(this.dgvNedre);
            this.Name = "frmKostnadAktivitet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Direkta kostnader - Aktivitet  | G4 Solutions Economy System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNedre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label cmbVäljKonto;
        private System.Windows.Forms.ComboBox cmbVäljAktivitet;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Button btnExportera;
        private System.Windows.Forms.Button btnLåsBudget;
        private System.Windows.Forms.Button btnLäggTill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBelopp;
        private System.Windows.Forms.Label lblVäljAktivitet;
        private System.Windows.Forms.DataGridView dgvNedre;
        private ucMeny ucMeny1;
    }
}