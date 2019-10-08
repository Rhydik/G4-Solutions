namespace PresentationLayer1
{
    partial class frmLoggaIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoggaIn));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLösenord = new System.Windows.Forms.TextBox();
            this.txtAnvändarnamn = new System.Windows.Forms.TextBox();
            this.lblLösenord = new System.Windows.Forms.Label();
            this.lblAnvändarnamn = new System.Windows.Forms.Label();
            this.btnAvbrytLoggaIn = new System.Windows.Forms.Button();
            this.btnLoggaIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(267, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(666, 320);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtLösenord
            // 
            this.txtLösenord.Location = new System.Drawing.Point(572, 478);
            this.txtLösenord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLösenord.Name = "txtLösenord";
            this.txtLösenord.Size = new System.Drawing.Size(148, 26);
            this.txtLösenord.TabIndex = 12;
            // 
            // txtAnvändarnamn
            // 
            this.txtAnvändarnamn.Location = new System.Drawing.Point(573, 425);
            this.txtAnvändarnamn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnvändarnamn.Name = "txtAnvändarnamn";
            this.txtAnvändarnamn.Size = new System.Drawing.Size(148, 26);
            this.txtAnvändarnamn.TabIndex = 11;
            // 
            // lblLösenord
            // 
            this.lblLösenord.AutoSize = true;
            this.lblLösenord.Location = new System.Drawing.Point(446, 483);
            this.lblLösenord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLösenord.Name = "lblLösenord";
            this.lblLösenord.Size = new System.Drawing.Size(76, 20);
            this.lblLösenord.TabIndex = 10;
            this.lblLösenord.Text = "Lösenord";
            // 
            // lblAnvändarnamn
            // 
            this.lblAnvändarnamn.AutoSize = true;
            this.lblAnvändarnamn.Location = new System.Drawing.Point(446, 425);
            this.lblAnvändarnamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnvändarnamn.Name = "lblAnvändarnamn";
            this.lblAnvändarnamn.Size = new System.Drawing.Size(117, 20);
            this.lblAnvändarnamn.TabIndex = 9;
            this.lblAnvändarnamn.Text = "Avnändarnamn";
            // 
            // btnAvbrytLoggaIn
            // 
            this.btnAvbrytLoggaIn.BackColor = System.Drawing.Color.DarkRed;
            this.btnAvbrytLoggaIn.Location = new System.Drawing.Point(606, 614);
            this.btnAvbrytLoggaIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAvbrytLoggaIn.Name = "btnAvbrytLoggaIn";
            this.btnAvbrytLoggaIn.Size = new System.Drawing.Size(201, 60);
            this.btnAvbrytLoggaIn.TabIndex = 8;
            this.btnAvbrytLoggaIn.Text = "Avbryt";
            this.btnAvbrytLoggaIn.UseVisualStyleBackColor = false;
            // 
            // btnLoggaIn
            // 
            this.btnLoggaIn.Location = new System.Drawing.Point(381, 614);
            this.btnLoggaIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoggaIn.Name = "btnLoggaIn";
            this.btnLoggaIn.Size = new System.Drawing.Size(201, 60);
            this.btnLoggaIn.TabIndex = 7;
            this.btnLoggaIn.Text = "Logga in";
            this.btnLoggaIn.UseVisualStyleBackColor = true;
            // 
            // frmLoggaIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLösenord);
            this.Controls.Add(this.txtAnvändarnamn);
            this.Controls.Add(this.lblLösenord);
            this.Controls.Add(this.lblAnvändarnamn);
            this.Controls.Add(this.btnAvbrytLoggaIn);
            this.Controls.Add(this.btnLoggaIn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLoggaIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLösenord;
        private System.Windows.Forms.TextBox txtAnvändarnamn;
        private System.Windows.Forms.Label lblLösenord;
        private System.Windows.Forms.Label lblAnvändarnamn;
        private System.Windows.Forms.Button btnAvbrytLoggaIn;
        private System.Windows.Forms.Button btnLoggaIn;
    }
}

