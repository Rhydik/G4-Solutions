namespace PresentationLayer1
{
    partial class frmRegistreraNySchablon
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
            this.tbSchablonkostnad = new System.Windows.Forms.TextBox();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSpara = new System.Windows.Forms.Button();
            this.lblSchablonkostnad = new System.Windows.Forms.Label();
            this.lblKonto = new System.Windows.Forms.Label();
            this.lblRegistreraNyttKonto = new System.Windows.Forms.Label();
            this.lblValtKonto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSchablonkostnad
            // 
            this.tbSchablonkostnad.Location = new System.Drawing.Point(17, 129);
            this.tbSchablonkostnad.Name = "tbSchablonkostnad";
            this.tbSchablonkostnad.Size = new System.Drawing.Size(239, 20);
            this.tbSchablonkostnad.TabIndex = 62;
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.BackColor = System.Drawing.Color.White;
            this.btnAvbryt.Location = new System.Drawing.Point(26, 460);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(61, 58);
            this.btnAvbryt.TabIndex = 61;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = false;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(6, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 3);
            this.label6.TabIndex = 60;
            // 
            // btnSpara
            // 
            this.btnSpara.BackColor = System.Drawing.Color.Yellow;
            this.btnSpara.Location = new System.Drawing.Point(147, 460);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(123, 58);
            this.btnSpara.TabIndex = 59;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = false;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // lblSchablonkostnad
            // 
            this.lblSchablonkostnad.AutoSize = true;
            this.lblSchablonkostnad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchablonkostnad.Location = new System.Drawing.Point(14, 110);
            this.lblSchablonkostnad.Name = "lblSchablonkostnad";
            this.lblSchablonkostnad.Size = new System.Drawing.Size(52, 16);
            this.lblSchablonkostnad.TabIndex = 58;
            this.lblSchablonkostnad.Text = "Belopp";
            // 
            // lblKonto
            // 
            this.lblKonto.AutoSize = true;
            this.lblKonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKonto.Location = new System.Drawing.Point(14, 61);
            this.lblKonto.Name = "lblKonto";
            this.lblKonto.Size = new System.Drawing.Size(45, 16);
            this.lblKonto.TabIndex = 56;
            this.lblKonto.Text = "Konto:";
            // 
            // lblRegistreraNyttKonto
            // 
            this.lblRegistreraNyttKonto.AutoSize = true;
            this.lblRegistreraNyttKonto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistreraNyttKonto.Location = new System.Drawing.Point(-42, -27);
            this.lblRegistreraNyttKonto.Name = "lblRegistreraNyttKonto";
            this.lblRegistreraNyttKonto.Size = new System.Drawing.Size(183, 22);
            this.lblRegistreraNyttKonto.TabIndex = 55;
            this.lblRegistreraNyttKonto.Text = "Registrera nytt konto";
            // 
            // lblValtKonto
            // 
            this.lblValtKonto.AutoSize = true;
            this.lblValtKonto.Location = new System.Drawing.Point(62, 63);
            this.lblValtKonto.Name = "lblValtKonto";
            this.lblValtKonto.Size = new System.Drawing.Size(35, 13);
            this.lblValtKonto.TabIndex = 63;
            this.lblValtKonto.Text = "label1";
            // 
            // frmRegistreraNySchablon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(292, 553);
            this.Controls.Add(this.lblValtKonto);
            this.Controls.Add(this.tbSchablonkostnad);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.lblSchablonkostnad);
            this.Controls.Add(this.lblKonto);
            this.Controls.Add(this.lblRegistreraNyttKonto);
            this.Name = "frmRegistreraNySchablon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistreraNySchablon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSchablonkostnad;
        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Label lblSchablonkostnad;
        private System.Windows.Forms.Label lblKonto;
        private System.Windows.Forms.Label lblRegistreraNyttKonto;
        private System.Windows.Forms.Label lblValtKonto;
    }
}