namespace PresentationLayer1
{
    partial class frmHemmeny
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed;
     
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
            System.ComponentModel.ComponentResourceManager resources = new
           System.ComponentModel.ComponentResourceManager(typeof(frmHemmeny));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.splitter = new System.Windows.Forms.Splitter();
            this.ucMeny = new PresentationLayer1.Forms.ucMeny();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            //
            // pictureBox1
            //
            this.pictureBox.Anchor =
           ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top |
           System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Image =
           ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox.Location = new System.Drawing.Point(277, 91);
            this.pictureBox.Name = "pictureBox1";
            this.pictureBox.Size = new System.Drawing.Size(454, 221);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            //
            // splitter1
            //
            this.splitter.Location = new System.Drawing.Point(0, 0);
            this.splitter.Margin = new System.Windows.Forms.Padding(2);
            this.splitter.Name = "splitter1";
            this.splitter.Size = new System.Drawing.Size(2, 450);
            this.splitter.TabIndex = 4;
            this.splitter.TabStop = false;
            //
            // ucMeny1
            //
            this.ucMeny.Location = new System.Drawing.Point(8, 8);
            this.ucMeny.Name = "ucMeny1";
            this.ucMeny.Size = new System.Drawing.Size(194, 438);
            this.ucMeny.TabIndex = 5;
            //
            // frmHemmeny
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucMeny);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.pictureBox);
            this.Name = "frmHemmeny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "G4 Solutions Economy System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Splitter splitter;
        private Forms.ucMeny ucMeny;
    }
}