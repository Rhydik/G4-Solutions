﻿namespace PresentationLayer1.Forms
{
    partial class frmKostnadProdukt
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
            this.dgvNedre = new System.Windows.Forms.DataGridView();
            this.lblSök = new System.Windows.Forms.Label();
            this.tbKonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.btnExportera = new System.Windows.Forms.Button();
            this.btnLåsBudget = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.cmbVäljProdukt = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cmbVäljKonto = new System.Windows.Forms.Label();
            this.ucMeny1 = new PresentationLayer1.Forms.ucMeny();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNedre)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNedre
            // 
            this.dgvNedre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvNedre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNedre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNedre.Location = new System.Drawing.Point(210, 100);
            this.dgvNedre.Name = "dgvNedre";
            this.dgvNedre.ReadOnly = true;
            this.dgvNedre.RowHeadersWidth = 62;
            this.dgvNedre.Size = new System.Drawing.Size(973, 377);
            this.dgvNedre.TabIndex = 79;
            // 
            // lblSök
            // 
            this.lblSök.AutoSize = true;
            this.lblSök.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSök.Location = new System.Drawing.Point(206, 12);
            this.lblSök.Name = "lblSök";
            this.lblSök.Size = new System.Drawing.Size(122, 24);
            this.lblSök.TabIndex = 88;
            this.lblSök.Text = "Välj Produkt";
            // 
            // tbKonto
            // 
            this.tbKonto.Location = new System.Drawing.Point(524, 38);
            this.tbKonto.Name = "tbKonto";
            this.tbKonto.Size = new System.Drawing.Size(128, 20);
            this.tbKonto.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Ange belopp";
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(658, 35);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(75, 23);
            this.btnLäggTill.TabIndex = 109;
            this.btnLäggTill.Text = "Lägg till";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            // 
            // btnExportera
            // 
            this.btnExportera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportera.Location = new System.Drawing.Point(211, 499);
            this.btnExportera.Name = "btnExportera";
            this.btnExportera.Size = new System.Drawing.Size(120, 41);
            this.btnExportera.TabIndex = 111;
            this.btnExportera.Text = "Exportera";
            this.btnExportera.UseVisualStyleBackColor = true;
            // 
            // btnLåsBudget
            // 
            this.btnLåsBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLåsBudget.Location = new System.Drawing.Point(924, 499);
            this.btnLåsBudget.Name = "btnLåsBudget";
            this.btnLåsBudget.Size = new System.Drawing.Size(120, 41);
            this.btnLåsBudget.TabIndex = 110;
            this.btnLåsBudget.Text = "Lås Budget";
            this.btnLåsBudget.UseVisualStyleBackColor = true;
            // 
            // btnTaBort
            // 
            this.btnTaBort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaBort.Location = new System.Drawing.Point(1063, 499);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(120, 41);
            this.btnTaBort.TabIndex = 112;
            this.btnTaBort.Text = "Ta bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            // 
            // cmbVäljProdukt
            // 
            this.cmbVäljProdukt.FormattingEnabled = true;
            this.cmbVäljProdukt.Location = new System.Drawing.Point(210, 42);
            this.cmbVäljProdukt.Name = "cmbVäljProdukt";
            this.cmbVäljProdukt.Size = new System.Drawing.Size(121, 21);
            this.cmbVäljProdukt.TabIndex = 113;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(358, 39);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 115;
            // 
            // cmbVäljKonto
            // 
            this.cmbVäljKonto.AutoSize = true;
            this.cmbVäljKonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVäljKonto.Location = new System.Drawing.Point(354, 9);
            this.cmbVäljKonto.Name = "cmbVäljKonto";
            this.cmbVäljKonto.Size = new System.Drawing.Size(105, 24);
            this.cmbVäljKonto.TabIndex = 114;
            this.cmbVäljKonto.Text = "Välj Konto";
            // 
            // ucMeny1
            // 
            this.ucMeny1.Location = new System.Drawing.Point(6, 17);
            this.ucMeny1.Name = "ucMeny1";
            this.ucMeny1.Size = new System.Drawing.Size(194, 438);
            this.ucMeny1.TabIndex = 116;
            // 
            // frmKostnadProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 595);
            this.Controls.Add(this.ucMeny1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.cmbVäljKonto);
            this.Controls.Add(this.cmbVäljProdukt);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnExportera);
            this.Controls.Add(this.btnLåsBudget);
            this.Controls.Add(this.btnLäggTill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKonto);
            this.Controls.Add(this.lblSök);
            this.Controls.Add(this.dgvNedre);
            this.Name = "frmKostnadProdukt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Direkta kostnader - Produkt  | G4 Solutions Economy System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNedre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNedre;
        private System.Windows.Forms.Label lblSök;
        private System.Windows.Forms.TextBox tbKonto;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnLäggTill;
        private System.Windows.Forms.Button btnExportera;
        private System.Windows.Forms.Button btnLåsBudget;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.ComboBox cmbVäljProdukt;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label cmbVäljKonto;
        private ucMeny ucMeny1;
    }
}