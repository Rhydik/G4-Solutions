﻿namespace PresentationLayer1
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
            this.ucSökFältKund = new PresentationLayer1.Forms.ucSökFältKund(this.dgvKunder);
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
            this.dgvKunder.Location = new System.Drawing.Point(243, 119);
            this.dgvKunder.Name = "dgvKunder";
            this.dgvKunder.ReadOnly = true;
            this.dgvKunder.RowHeadersWidth = 62;
            this.dgvKunder.Size = new System.Drawing.Size(501, 237);
            this.dgvKunder.TabIndex = 7;
            // 
            // btnRegistreraNyKund
            // 
            this.btnRegistreraNyKund.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistreraNyKund.Location = new System.Drawing.Point(632, 362);
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
            this.btnRedigeraKund.Location = new System.Drawing.Point(506, 361);
            this.btnRedigeraKund.Name = "btnRedigeraKund";
            this.btnRedigeraKund.Size = new System.Drawing.Size(120, 41);
            this.btnRedigeraKund.TabIndex = 10;
            this.btnRedigeraKund.Text = "Redigera kund";
            this.btnRedigeraKund.UseVisualStyleBackColor = true;
            this.btnRedigeraKund.Click += new System.EventHandler(this.btnRedigeraKund_Click);
            // 
            // ucMeny1
            // 
            this.ucMeny.Location = new System.Drawing.Point(12, 12);
            this.ucMeny.Name = "ucMeny1";
            this.ucMeny.Size = new System.Drawing.Size(194, 438);
            this.ucMeny.TabIndex = 20;
            // 
            // ucSökFältKund1
            // 
            this.ucSökFältKund.Location = new System.Drawing.Point(243, 39);
            this.ucSökFältKund.Name = "ucSökFältKund";
            this.ucSökFältKund.Size = new System.Drawing.Size(545, 53);
            this.ucSökFältKund.TabIndex = 21;
            // 
            // frmKunder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKunder;
        private System.Windows.Forms.Button btnRegistreraNyKund;
        private System.Windows.Forms.Button btnRedigeraKund;
        private Forms.ucMeny ucMeny;
        private Forms.ucSökFältKund ucSökFältKund;
    }
}