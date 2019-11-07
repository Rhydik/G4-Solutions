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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistreraNyKund));
            this.lblKund2 = new System.Windows.Forms.Label();
            this.lblKundkategori = new System.Windows.Forms.Label();
            this.tbKundNamn = new System.Windows.Forms.TextBox();
            this.cmbKundkategori = new System.Windows.Forms.ComboBox();
            this.btnSpara = new System.Windows.Forms.Button();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.btnSkapaNyKundkategori = new System.Windows.Forms.Button();
            this.lblRegistreraNyKund = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKund2
            // 
            this.lblKund2.AutoSize = true;
            this.lblKund2.Location = new System.Drawing.Point(12, 66);
            this.lblKund2.Name = "lblKund2";
            this.lblKund2.Size = new System.Drawing.Size(38, 16);
            this.lblKund2.TabIndex = 7;
            this.lblKund2.Text = "Kund";
            // 
            // lblKundkategori
            // 
            this.lblKundkategori.AutoSize = true;
            this.lblKundkategori.Location = new System.Drawing.Point(12, 138);
            this.lblKundkategori.Name = "lblKundkategori";
            this.lblKundkategori.Size = new System.Drawing.Size(87, 16);
            this.lblKundkategori.TabIndex = 8;
            this.lblKundkategori.Text = "Kundkategori";
            // 
            // tbKundNamn
            // 
            this.tbKundNamn.Location = new System.Drawing.Point(15, 95);
            this.tbKundNamn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKundNamn.Name = "tbKundNamn";
            this.tbKundNamn.Size = new System.Drawing.Size(315, 22);
            this.tbKundNamn.TabIndex = 10;
            // 
            // cmbKundkategori
            // 
            this.cmbKundkategori.FormattingEnabled = true;
            this.cmbKundkategori.Location = new System.Drawing.Point(15, 166);
            this.cmbKundkategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKundkategori.Name = "cmbKundkategori";
            this.cmbKundkategori.Size = new System.Drawing.Size(204, 24);
            this.cmbKundkategori.TabIndex = 11;
            // 
            // btnSpara
            // 
            this.btnSpara.BackColor = System.Drawing.Color.Yellow;
            this.btnSpara.Location = new System.Drawing.Point(184, 583);
            this.btnSpara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(164, 71);
            this.btnSpara.TabIndex = 12;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = false;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(27, 583);
            this.btnAvbryt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(81, 71);
            this.btnAvbryt.TabIndex = 13;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // btnSkapaNyKundkategori
            // 
            this.btnSkapaNyKundkategori.Location = new System.Drawing.Point(225, 156);
            this.btnSkapaNyKundkategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSkapaNyKundkategori.Name = "btnSkapaNyKundkategori";
            this.btnSkapaNyKundkategori.Size = new System.Drawing.Size(105, 42);
            this.btnSkapaNyKundkategori.TabIndex = 14;
            this.btnSkapaNyKundkategori.Text = "Skapa ny kundkategori";
            this.btnSkapaNyKundkategori.UseVisualStyleBackColor = true;
            this.btnSkapaNyKundkategori.Click += new System.EventHandler(this.btnSkapaNyKundkategori_Click);
            // 
            // lblRegistreraNyKund
            // 
            this.lblRegistreraNyKund.AutoSize = true;
            this.lblRegistreraNyKund.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistreraNyKund.Location = new System.Drawing.Point(16, 11);
            this.lblRegistreraNyKund.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistreraNyKund.Name = "lblRegistreraNyKund";
            this.lblRegistreraNyKund.Size = new System.Drawing.Size(171, 22);
            this.lblRegistreraNyKund.TabIndex = 33;
            this.lblRegistreraNyKund.Text = "Registrera ny Kund";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(-95, 561);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(531, 4);
            this.label6.TabIndex = 65;
            // 
            // frmRegistreraNyKund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(363, 668);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRegistreraNyKund);
            this.Controls.Add(this.btnSkapaNyKundkategori);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.cmbKundkategori);
            this.Controls.Add(this.tbKundNamn);
            this.Controls.Add(this.lblKundkategori);
            this.Controls.Add(this.lblKund2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRegistreraNyKund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrera Ny Kund";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKund2;
        private System.Windows.Forms.Label lblKundkategori;
        private System.Windows.Forms.TextBox tbKundNamn;
        private System.Windows.Forms.ComboBox cmbKundkategori;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Button btnSkapaNyKundkategori;
        private System.Windows.Forms.Label lblRegistreraNyKund;
        private System.Windows.Forms.Label label6;
    }
}