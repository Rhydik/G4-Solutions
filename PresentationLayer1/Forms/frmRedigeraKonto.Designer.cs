namespace PresentationLayer1.Forms
{
    partial class frmRedigeraKonto
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
            this.btnTaBortAktivitet = new System.Windows.Forms.Button();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSpara = new System.Windows.Forms.Button();
            this.lblSchablonkostnad = new System.Windows.Forms.Label();
            this.lblKontobenämning = new System.Windows.Forms.Label();
            this.lblKonto = new System.Windows.Forms.Label();
            this.lblRedigeraKonto = new System.Windows.Forms.Label();
            this.tbKonto = new System.Windows.Forms.TextBox();
            this.tbKontobenämning = new System.Windows.Forms.TextBox();
            this.tbSchablonkostnad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTaBortAktivitet
            // 
            this.btnTaBortAktivitet.BackColor = System.Drawing.Color.DarkRed;
            this.btnTaBortAktivitet.Location = new System.Drawing.Point(12, 393);
            this.btnTaBortAktivitet.Name = "btnTaBortAktivitet";
            this.btnTaBortAktivitet.Size = new System.Drawing.Size(239, 41);
            this.btnTaBortAktivitet.TabIndex = 40;
            this.btnTaBortAktivitet.Text = "Ta bort Konto";
            this.btnTaBortAktivitet.UseVisualStyleBackColor = false;
            this.btnTaBortAktivitet.Click += new System.EventHandler(this.btnTaBortAktivitet_Click_1);
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
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click_1);
            // 
            // lblSchablonkostnad
            // 
            this.lblSchablonkostnad.AutoSize = true;
            this.lblSchablonkostnad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchablonkostnad.Location = new System.Drawing.Point(9, 211);
            this.lblSchablonkostnad.Name = "lblSchablonkostnad";
            this.lblSchablonkostnad.Size = new System.Drawing.Size(113, 16);
            this.lblSchablonkostnad.TabIndex = 35;
            this.lblSchablonkostnad.Text = "Schablonkostnad";
            // 
            // lblKontobenämning
            // 
            this.lblKontobenämning.AutoSize = true;
            this.lblKontobenämning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKontobenämning.Location = new System.Drawing.Point(9, 127);
            this.lblKontobenämning.Name = "lblKontobenämning";
            this.lblKontobenämning.Size = new System.Drawing.Size(78, 16);
            this.lblKontobenämning.TabIndex = 34;
            this.lblKontobenämning.Text = "Beskrivning";
            // 
            // lblKonto
            // 
            this.lblKonto.AutoSize = true;
            this.lblKonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKonto.Location = new System.Drawing.Point(9, 73);
            this.lblKonto.Name = "lblKonto";
            this.lblKonto.Size = new System.Drawing.Size(44, 16);
            this.lblKonto.TabIndex = 33;
            this.lblKonto.Text = "Namn";
            // 
            // lblRedigeraKonto
            // 
            this.lblRedigeraKonto.AutoSize = true;
            this.lblRedigeraKonto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedigeraKonto.Location = new System.Drawing.Point(8, 20);
            this.lblRedigeraKonto.Name = "lblRedigeraKonto";
            this.lblRedigeraKonto.Size = new System.Drawing.Size(139, 22);
            this.lblRedigeraKonto.TabIndex = 32;
            this.lblRedigeraKonto.Text = "Redigera konto";
            // 
            // tbKonto
            // 
            this.tbKonto.Location = new System.Drawing.Point(12, 92);
            this.tbKonto.Name = "tbKonto";
            this.tbKonto.Size = new System.Drawing.Size(239, 20);
            this.tbKonto.TabIndex = 31;
            // 
            // tbKontobenämning
            // 
            this.tbKontobenämning.Location = new System.Drawing.Point(12, 146);
            this.tbKontobenämning.Name = "tbKontobenämning";
            this.tbKontobenämning.Size = new System.Drawing.Size(239, 20);
            this.tbKontobenämning.TabIndex = 30;
            // 
            // tbSchablonkostnad
            // 
            this.tbSchablonkostnad.Location = new System.Drawing.Point(12, 230);
            this.tbSchablonkostnad.Name = "tbSchablonkostnad";
            this.tbSchablonkostnad.Size = new System.Drawing.Size(239, 20);
            this.tbSchablonkostnad.TabIndex = 41;
            // 
            // frmRedigeraKonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(272, 543);
            this.Controls.Add(this.tbSchablonkostnad);
            this.Controls.Add(this.btnTaBortAktivitet);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.lblSchablonkostnad);
            this.Controls.Add(this.lblKontobenämning);
            this.Controls.Add(this.lblKonto);
            this.Controls.Add(this.lblRedigeraKonto);
            this.Controls.Add(this.tbKonto);
            this.Controls.Add(this.tbKontobenämning);
            this.Name = "frmRedigeraKonto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRedigeraKonto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaBortAktivitet;
        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Label lblSchablonkostnad;
        private System.Windows.Forms.Label lblKontobenämning;
        private System.Windows.Forms.Label lblKonto;
        private System.Windows.Forms.Label lblRedigeraKonto;
        private System.Windows.Forms.TextBox tbKonto;
        private System.Windows.Forms.TextBox tbKontobenämning;
        private System.Windows.Forms.TextBox tbSchablonkostnad;
    }
}