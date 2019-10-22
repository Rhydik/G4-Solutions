namespace PresentationLayer1.Forms
{
    partial class frmRegistreraNyAktivitet
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
            this.cmbAvdelning = new System.Windows.Forms.ComboBox();
            this.lblAvdelning = new System.Windows.Forms.Label();
            this.lblAktivitetsID = new System.Windows.Forms.Label();
            this.lblAktivi = new System.Windows.Forms.Label();
            this.lblRegistreraNyAktivitet = new System.Windows.Forms.Label();
            this.tbBenämning = new System.Windows.Forms.TextBox();
            this.tbAktivitetsID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // cmbAvdelning
            // 
            this.cmbAvdelning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvdelning.FormattingEnabled = true;
            this.cmbAvdelning.Location = new System.Drawing.Point(12, 279);
            this.cmbAvdelning.Name = "cmbAvdelning";
            this.cmbAvdelning.Size = new System.Drawing.Size(164, 21);
            this.cmbAvdelning.TabIndex = 36;
            // 
            // lblAvdelning
            // 
            this.lblAvdelning.AutoSize = true;
            this.lblAvdelning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvdelning.Location = new System.Drawing.Point(9, 260);
            this.lblAvdelning.Name = "lblAvdelning";
            this.lblAvdelning.Size = new System.Drawing.Size(68, 16);
            this.lblAvdelning.TabIndex = 35;
            this.lblAvdelning.Text = "Avdelning";
            // 
            // lblAktivitetsID
            // 
            this.lblAktivitetsID.AutoSize = true;
            this.lblAktivitetsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAktivitetsID.Location = new System.Drawing.Point(9, 82);
            this.lblAktivitetsID.Name = "lblAktivitetsID";
            this.lblAktivitetsID.Size = new System.Drawing.Size(74, 16);
            this.lblAktivitetsID.TabIndex = 34;
            this.lblAktivitetsID.Text = "AktivitetsID";
            // 
            // lblAktivi
            // 
            this.lblAktivi.AutoSize = true;
            this.lblAktivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAktivi.Location = new System.Drawing.Point(9, 143);
            this.lblAktivi.Name = "lblAktivi";
            this.lblAktivi.Size = new System.Drawing.Size(76, 16);
            this.lblAktivi.TabIndex = 33;
            this.lblAktivi.Text = "Benämning";
            // 
            // lblRegistreraNyAktivitet
            // 
            this.lblRegistreraNyAktivitet.AutoSize = true;
            this.lblRegistreraNyAktivitet.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistreraNyAktivitet.Location = new System.Drawing.Point(8, 20);
            this.lblRegistreraNyAktivitet.Name = "lblRegistreraNyAktivitet";
            this.lblRegistreraNyAktivitet.Size = new System.Drawing.Size(189, 22);
            this.lblRegistreraNyAktivitet.TabIndex = 32;
            this.lblRegistreraNyAktivitet.Text = "Registrera ny aktivitet";
            // 
            // tbBenämning
            // 
            this.tbBenämning.Location = new System.Drawing.Point(12, 162);
            this.tbBenämning.Name = "tbBenämning";
            this.tbBenämning.Size = new System.Drawing.Size(239, 20);
            this.tbBenämning.TabIndex = 31;
            // 
            // tbAktivitetsID
            // 
            this.tbAktivitetsID.Location = new System.Drawing.Point(12, 101);
            this.tbAktivitetsID.Name = "tbAktivitetsID";
            this.tbAktivitetsID.Size = new System.Drawing.Size(239, 20);
            this.tbAktivitetsID.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 40;
            this.button1.Text = "Spara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSparaAvdelning_Click);
            // 
            // frmRegistreraNyAktivitet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(272, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.cmbAvdelning);
            this.Controls.Add(this.lblAvdelning);
            this.Controls.Add(this.lblAktivitetsID);
            this.Controls.Add(this.lblAktivi);
            this.Controls.Add(this.lblRegistreraNyAktivitet);
            this.Controls.Add(this.tbBenämning);
            this.Controls.Add(this.tbAktivitetsID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRegistreraNyAktivitet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistreraNyAktivitet";
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
        private System.Windows.Forms.Label lblAktivi;
        private System.Windows.Forms.Label lblRegistreraNyAktivitet;
        private System.Windows.Forms.TextBox tbBenämning;
        private System.Windows.Forms.TextBox tbAktivitetsID;
        private System.Windows.Forms.Button button1;
    }
}