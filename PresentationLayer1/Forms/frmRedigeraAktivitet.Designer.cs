namespace PresentationLayer1.Forms
{
    partial class frmRedigeraAktivitet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRedigeraAktivitet));
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSpara = new System.Windows.Forms.Button();
            this.cmbAvdelning = new System.Windows.Forms.ComboBox();
            this.lblAvdelning = new System.Windows.Forms.Label();
            this.lblAktivitetsID = new System.Windows.Forms.Label();
            this.lblBenämning = new System.Windows.Forms.Label();
            this.lblRedigeraAktivitet = new System.Windows.Forms.Label();
            this.tbBenämning = new System.Windows.Forms.TextBox();
            this.tbAktivitetsID = new System.Windows.Forms.TextBox();
            this.btnTaBortAktivitet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.BackColor = System.Drawing.Color.White;
            this.btnAvbryt.Location = new System.Drawing.Point(12, 467);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(61, 58);
            this.btnAvbryt.TabIndex = 28;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = false;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(-8, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 3);
            this.label6.TabIndex = 25;
            // 
            // btnSpara
            // 
            this.btnSpara.BackColor = System.Drawing.Color.Yellow;
            this.btnSpara.Location = new System.Drawing.Point(133, 467);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(123, 58);
            this.btnSpara.TabIndex = 22;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = false;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // cmbAvdelning
            // 
            this.cmbAvdelning.FormattingEnabled = true;
            this.cmbAvdelning.Items.AddRange(new object[] {
            "Administrativa avdelningen",
            "Försäljnings- och marknadsavdelningen"});
            this.cmbAvdelning.Location = new System.Drawing.Point(12, 225);
            this.cmbAvdelning.Name = "cmbAvdelning";
            this.cmbAvdelning.Size = new System.Drawing.Size(239, 21);
            this.cmbAvdelning.TabIndex = 21;
            // 
            // lblAvdelning
            // 
            this.lblAvdelning.AutoSize = true;
            this.lblAvdelning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvdelning.Location = new System.Drawing.Point(9, 206);
            this.lblAvdelning.Name = "lblAvdelning";
            this.lblAvdelning.Size = new System.Drawing.Size(68, 16);
            this.lblAvdelning.TabIndex = 20;
            this.lblAvdelning.Text = "Avdelning";
            // 
            // lblAktivitetsID
            // 
            this.lblAktivitetsID.AutoSize = true;
            this.lblAktivitetsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAktivitetsID.Location = new System.Drawing.Point(9, 59);
            this.lblAktivitetsID.Name = "lblAktivitetsID";
            this.lblAktivitetsID.Size = new System.Drawing.Size(74, 16);
            this.lblAktivitetsID.TabIndex = 19;
            this.lblAktivitetsID.Text = "AktivitetsID";
            // 
            // lblBenämning
            // 
            this.lblBenämning.AutoSize = true;
            this.lblBenämning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenämning.Location = new System.Drawing.Point(9, 118);
            this.lblBenämning.Name = "lblBenämning";
            this.lblBenämning.Size = new System.Drawing.Size(76, 16);
            this.lblBenämning.TabIndex = 18;
            this.lblBenämning.Text = "Benämning";
            // 
            // lblRedigeraAktivitet
            // 
            this.lblRedigeraAktivitet.AutoSize = true;
            this.lblRedigeraAktivitet.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedigeraAktivitet.Location = new System.Drawing.Point(8, 15);
            this.lblRedigeraAktivitet.Name = "lblRedigeraAktivitet";
            this.lblRedigeraAktivitet.Size = new System.Drawing.Size(155, 22);
            this.lblRedigeraAktivitet.TabIndex = 17;
            this.lblRedigeraAktivitet.Text = "Redigera aktivitet";
            // 
            // tbBenämning
            // 
            this.tbBenämning.Location = new System.Drawing.Point(12, 137);
            this.tbBenämning.Name = "tbBenämning";
            this.tbBenämning.Size = new System.Drawing.Size(239, 20);
            this.tbBenämning.TabIndex = 16;
            // 
            // tbAktivitetsID
            // 
            this.tbAktivitetsID.Location = new System.Drawing.Point(12, 78);
            this.tbAktivitetsID.Name = "tbAktivitetsID";
            this.tbAktivitetsID.Size = new System.Drawing.Size(239, 20);
            this.tbAktivitetsID.TabIndex = 15;
            // 
            // btnTaBortAktivitet
            // 
            this.btnTaBortAktivitet.BackColor = System.Drawing.Color.DarkRed;
            this.btnTaBortAktivitet.Location = new System.Drawing.Point(12, 388);
            this.btnTaBortAktivitet.Name = "btnTaBortAktivitet";
            this.btnTaBortAktivitet.Size = new System.Drawing.Size(239, 41);
            this.btnTaBortAktivitet.TabIndex = 29;
            this.btnTaBortAktivitet.Text = "Ta bort aktivitet";
            this.btnTaBortAktivitet.UseVisualStyleBackColor = false;
            this.btnTaBortAktivitet.Click += new System.EventHandler(this.btnTaBortAktivitet_Click);
            // 
            // frmRedigeraAktivitet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(272, 543);
            this.Controls.Add(this.btnTaBortAktivitet);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.cmbAvdelning);
            this.Controls.Add(this.lblAvdelning);
            this.Controls.Add(this.lblAktivitetsID);
            this.Controls.Add(this.lblBenämning);
            this.Controls.Add(this.lblRedigeraAktivitet);
            this.Controls.Add(this.tbBenämning);
            this.Controls.Add(this.tbAktivitetsID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRedigeraAktivitet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redigera Aktivitet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.ComboBox cmbAvdelning;
        private System.Windows.Forms.Label lblAvdelning;
        private System.Windows.Forms.Label lblAktivitetsID;
        private System.Windows.Forms.Label lblBenämning;
        private System.Windows.Forms.Label lblRedigeraAktivitet;
        private System.Windows.Forms.TextBox tbBenämning;
        private System.Windows.Forms.TextBox tbAktivitetsID;
        private System.Windows.Forms.Button btnTaBortAktivitet;
    }
}