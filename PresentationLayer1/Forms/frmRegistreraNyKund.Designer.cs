namespace PresentationLayer1.Forms
{
    partial class frmRegistreraNyKund
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
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSpara = new System.Windows.Forms.Button();
            this.cmbKundkategori = new System.Windows.Forms.ComboBox();
            this.lblKundkategori = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistreraNyKund = new System.Windows.Forms.Label();
            this.tbKundID = new System.Windows.Forms.TextBox();
            this.tbKundNamn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.BackColor = System.Drawing.Color.White;
            this.btnAvbryt.Location = new System.Drawing.Point(12, 463);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(61, 58);
            this.btnAvbryt.TabIndex = 50;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(-8, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 3);
            this.label6.TabIndex = 49;
            // 
            // btnSpara
            // 
            this.btnSpara.BackColor = System.Drawing.Color.Yellow;
            this.btnSpara.Location = new System.Drawing.Point(133, 463);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(123, 58);
            this.btnSpara.TabIndex = 48;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = false;
            // 
            // cmbKundkategori
            // 
            this.cmbKundkategori.FormattingEnabled = true;
            this.cmbKundkategori.Items.AddRange(new object[] {
            "dwwd"});
            this.cmbKundkategori.Location = new System.Drawing.Point(12, 221);
            this.cmbKundkategori.Name = "cmbKundkategori";
            this.cmbKundkategori.Size = new System.Drawing.Size(239, 21);
            this.cmbKundkategori.TabIndex = 47;
            // 
            // lblKundkategori
            // 
            this.lblKundkategori.AutoSize = true;
            this.lblKundkategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKundkategori.Location = new System.Drawing.Point(9, 202);
            this.lblKundkategori.Name = "lblKundkategori";
            this.lblKundkategori.Size = new System.Drawing.Size(87, 16);
            this.lblKundkategori.TabIndex = 46;
            this.lblKundkategori.Text = "Kundkategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Kund";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "KundID";
            // 
            // lblRegistreraNyKund
            // 
            this.lblRegistreraNyKund.AutoSize = true;
            this.lblRegistreraNyKund.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistreraNyKund.Location = new System.Drawing.Point(8, 11);
            this.lblRegistreraNyKund.Name = "lblRegistreraNyKund";
            this.lblRegistreraNyKund.Size = new System.Drawing.Size(167, 22);
            this.lblRegistreraNyKund.TabIndex = 43;
            this.lblRegistreraNyKund.Text = "Registrera ny kund";
            // 
            // tbKundID
            // 
            this.tbKundID.Location = new System.Drawing.Point(12, 83);
            this.tbKundID.Name = "tbKundID";
            this.tbKundID.Size = new System.Drawing.Size(239, 20);
            this.tbKundID.TabIndex = 42;
            // 
            // tbKundNamn
            // 
            this.tbKundNamn.Location = new System.Drawing.Point(12, 137);
            this.tbKundNamn.Name = "tbKundNamn";
            this.tbKundNamn.Size = new System.Drawing.Size(239, 20);
            this.tbKundNamn.TabIndex = 41;
            // 
            // frmRegistreraNyKund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(272, 543);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.cmbKundkategori);
            this.Controls.Add(this.lblKundkategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRegistreraNyKund);
            this.Controls.Add(this.tbKundID);
            this.Controls.Add(this.tbKundNamn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRegistreraNyKund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistreraNyKund";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.ComboBox cmbKundkategori;
        private System.Windows.Forms.Label lblKundkategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegistreraNyKund;
        private System.Windows.Forms.TextBox tbKundID;
        private System.Windows.Forms.TextBox tbKundNamn;
    }
}