namespace PresentationLayer1.Forms
{
    partial class frmAddNewProdukt
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
            this.newProduktNametxt = new System.Windows.Forms.TextBox();
            this.newProduktIDtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newProduktNametxt
            // 
            this.newProduktNametxt.Location = new System.Drawing.Point(12, 113);
            this.newProduktNametxt.Name = "newProduktNametxt";
            this.newProduktNametxt.Size = new System.Drawing.Size(100, 20);
            this.newProduktNametxt.TabIndex = 0;
            this.newProduktNametxt.TextChanged += new System.EventHandler(this.newProduktNametxt_TextChanged);
            // 
            // newProduktIDtxt
            // 
            this.newProduktIDtxt.Location = new System.Drawing.Point(12, 73);
            this.newProduktIDtxt.Name = "newProduktIDtxt";
            this.newProduktIDtxt.Size = new System.Drawing.Size(100, 20);
            this.newProduktIDtxt.TabIndex = 1;
            this.newProduktIDtxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrera ny Produkt";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmAddNewProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newProduktIDtxt);
            this.Controls.Add(this.newProduktNametxt);
            this.Name = "frmAddNewProdukt";
            this.Text = "frmAddNewProdukt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newProduktNametxt;
        private System.Windows.Forms.TextBox newProduktIDtxt;
        private System.Windows.Forms.Label label1;
    }
}