namespace PresentationLayer1.Forms
{
    partial class frmRegistreraNyttKonto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistreraNyttKonto));
            this.tbSchablonkostnad = new System.Windows.Forms.TextBox();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSpara = new System.Windows.Forms.Button();
            this.lblSchablonkostnad = new System.Windows.Forms.Label();
            this.lblKontobenämning = new System.Windows.Forms.Label();
            this.lblKonto = new System.Windows.Forms.Label();
            this.lblRegistreraNyttKonto = new System.Windows.Forms.Label();
            this.tbKonto = new System.Windows.Forms.TextBox();
            this.tbKontobenämning = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbSchablonkostnad
            // 
            this.tbSchablonkostnad.Location = new System.Drawing.Point(16, 284);
            this.tbSchablonkostnad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSchablonkostnad.Name = "tbSchablonkostnad";
            this.tbSchablonkostnad.Size = new System.Drawing.Size(317, 22);
            this.tbSchablonkostnad.TabIndex = 52;
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.BackColor = System.Drawing.Color.White;
            this.btnAvbryt.Location = new System.Drawing.Point(28, 582);
            this.btnAvbryt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(81, 71);
            this.btnAvbryt.TabIndex = 50;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = false;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(1, 539);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(531, 4);
            this.label6.TabIndex = 49;
            // 
            // btnSpara
            // 
            this.btnSpara.BackColor = System.Drawing.Color.Yellow;
            this.btnSpara.Location = new System.Drawing.Point(189, 582);
            this.btnSpara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(164, 71);
            this.btnSpara.TabIndex = 48;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = false;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // lblSchablonkostnad
            // 
            this.lblSchablonkostnad.AutoSize = true;
            this.lblSchablonkostnad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchablonkostnad.Location = new System.Drawing.Point(12, 261);
            this.lblSchablonkostnad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSchablonkostnad.Name = "lblSchablonkostnad";
            this.lblSchablonkostnad.Size = new System.Drawing.Size(52, 16);
            this.lblSchablonkostnad.TabIndex = 47;
            this.lblSchablonkostnad.Text = "Belopp";
            // 
            // lblKontobenämning
            // 
            this.lblKontobenämning.AutoSize = true;
            this.lblKontobenämning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKontobenämning.Location = new System.Drawing.Point(12, 158);
            this.lblKontobenämning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKontobenämning.Name = "lblKontobenämning";
            this.lblKontobenämning.Size = new System.Drawing.Size(109, 16);
            this.lblKontobenämning.TabIndex = 46;
            this.lblKontobenämning.Text = "Kontobenämning";
            // 
            // lblKonto
            // 
            this.lblKonto.AutoSize = true;
            this.lblKonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKonto.Location = new System.Drawing.Point(12, 91);
            this.lblKonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKonto.Name = "lblKonto";
            this.lblKonto.Size = new System.Drawing.Size(42, 16);
            this.lblKonto.TabIndex = 45;
            this.lblKonto.Text = "Konto";
            // 
            // lblRegistreraNyttKonto
            // 
            this.lblRegistreraNyttKonto.AutoSize = true;
            this.lblRegistreraNyttKonto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistreraNyttKonto.Location = new System.Drawing.Point(16, 26);
            this.lblRegistreraNyttKonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistreraNyttKonto.Name = "lblRegistreraNyttKonto";
            this.lblRegistreraNyttKonto.Size = new System.Drawing.Size(183, 22);
            this.lblRegistreraNyttKonto.TabIndex = 44;
            this.lblRegistreraNyttKonto.Text = "Registrera nytt konto";
            // 
            // tbKonto
            // 
            this.tbKonto.Location = new System.Drawing.Point(16, 114);
            this.tbKonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKonto.Name = "tbKonto";
            this.tbKonto.Size = new System.Drawing.Size(317, 22);
            this.tbKonto.TabIndex = 43;
            // 
            // tbKontobenämning
            // 
            this.tbKontobenämning.Location = new System.Drawing.Point(16, 181);
            this.tbKontobenämning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKontobenämning.Name = "tbKontobenämning";
            this.tbKontobenämning.Size = new System.Drawing.Size(317, 22);
            this.tbKontobenämning.TabIndex = 42;
            // 
            // frmRegistreraNyttKonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(363, 668);
            this.Controls.Add(this.tbSchablonkostnad);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.lblSchablonkostnad);
            this.Controls.Add(this.lblKontobenämning);
            this.Controls.Add(this.lblKonto);
            this.Controls.Add(this.lblRegistreraNyttKonto);
            this.Controls.Add(this.tbKonto);
            this.Controls.Add(this.tbKontobenämning);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRegistreraNyttKonto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrera Nytt Konto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSchablonkostnad;
        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Label lblSchablonkostnad;
        private System.Windows.Forms.Label lblKontobenämning;
        private System.Windows.Forms.Label lblKonto;
        private System.Windows.Forms.Label lblRegistreraNyttKonto;
        private System.Windows.Forms.TextBox tbKonto;
        private System.Windows.Forms.TextBox tbKontobenämning;
    }
}