namespace PresentationLayer1.Forms
{
    partial class frmRedigeraKund
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
            this.btnTaBortKund = new System.Windows.Forms.Button();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSpara = new System.Windows.Forms.Button();
            this.cmbKundkategori = new System.Windows.Forms.ComboBox();
            this.lblKundkategori = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRedigeraKund = new System.Windows.Forms.Label();
            this.tbKundID2 = new System.Windows.Forms.TextBox();
            this.tbKund2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTaBortKund
            // 
            this.btnTaBortKund.BackColor = System.Drawing.Color.DarkRed;
            this.btnTaBortKund.Location = new System.Drawing.Point(12, 393);
            this.btnTaBortKund.Name = "btnTaBortKund";
            this.btnTaBortKund.Size = new System.Drawing.Size(239, 41);
            this.btnTaBortKund.TabIndex = 40;
            this.btnTaBortKund.Text = "Ta bort kund";
            this.btnTaBortKund.UseVisualStyleBackColor = false;
            this.btnTaBortKund.Click += new System.EventHandler(this.btnTaBortKund_Click);
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.BackColor = System.Drawing.Color.White;
            this.btnAvbryt.Location = new System.Drawing.Point(12, 472);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(61, 58);
            this.btnAvbryt.TabIndex = 39;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = false;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(-8, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 3);
            this.label6.TabIndex = 38;
            // 
            // btnSpara
            // 
            this.btnSpara.BackColor = System.Drawing.Color.Yellow;
            this.btnSpara.Location = new System.Drawing.Point(133, 472);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(123, 58);
            this.btnSpara.TabIndex = 37;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = false;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // cmbKundkategori
            // 
            this.cmbKundkategori.FormattingEnabled = true;
            this.cmbKundkategori.Items.AddRange(new object[] {
            "dwwd"});
            this.cmbKundkategori.Location = new System.Drawing.Point(12, 230);
            this.cmbKundkategori.Name = "cmbKundkategori";
            this.cmbKundkategori.Size = new System.Drawing.Size(239, 21);
            this.cmbKundkategori.TabIndex = 36;
            // 
            // lblKundkategori
            // 
            this.lblKundkategori.AutoSize = true;
            this.lblKundkategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKundkategori.Location = new System.Drawing.Point(9, 211);
            this.lblKundkategori.Name = "lblKundkategori";
            this.lblKundkategori.Size = new System.Drawing.Size(87, 16);
            this.lblKundkategori.TabIndex = 35;
            this.lblKundkategori.Text = "Kundkategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Kund";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "KundID";
            // 
            // lblRedigeraKund
            // 
            this.lblRedigeraKund.AutoSize = true;
            this.lblRedigeraKund.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedigeraKund.Location = new System.Drawing.Point(8, 20);
            this.lblRedigeraKund.Name = "lblRedigeraKund";
            this.lblRedigeraKund.Size = new System.Drawing.Size(133, 22);
            this.lblRedigeraKund.TabIndex = 32;
            this.lblRedigeraKund.Text = "Redigera kund";
            // 
            // tbKundID2
            // 
            this.tbKundID2.Location = new System.Drawing.Point(12, 92);
            this.tbKundID2.Name = "tbKundID2";
            this.tbKundID2.Size = new System.Drawing.Size(239, 20);
            this.tbKundID2.TabIndex = 31;
            // 
            // tbKund2
            // 
            this.tbKund2.Location = new System.Drawing.Point(12, 146);
            this.tbKund2.Name = "tbKund2";
            this.tbKund2.Size = new System.Drawing.Size(239, 20);
            this.tbKund2.TabIndex = 30;
            // 
            // frmRedigeraKund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(272, 543);
            this.Controls.Add(this.btnTaBortKund);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.cmbKundkategori);
            this.Controls.Add(this.lblKundkategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRedigeraKund);
            this.Controls.Add(this.tbKundID2);
            this.Controls.Add(this.tbKund2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRedigeraKund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRedigeraKund";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaBortKund;
        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.ComboBox cmbKundkategori;
        private System.Windows.Forms.Label lblKundkategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRedigeraKund;
        private System.Windows.Forms.TextBox tbKundID2;
        private System.Windows.Forms.TextBox tbKund2;
    }
}