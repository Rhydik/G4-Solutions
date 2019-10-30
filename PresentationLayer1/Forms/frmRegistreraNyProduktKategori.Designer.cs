namespace PresentationLayer1.Forms
{
    partial class frmRegistreraNyProduktKategori
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
            this.btnSparaNyProduktKategori = new System.Windows.Forms.Button();
            this.lbNyProduktgrupp = new System.Windows.Forms.Label();
            this.tbNyProduktKategori = new System.Windows.Forms.TextBox();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSparaNyProduktKategori
            // 
            this.btnSparaNyProduktKategori.Location = new System.Drawing.Point(230, 110);
            this.btnSparaNyProduktKategori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSparaNyProduktKategori.Name = "btnSparaNyProduktKategori";
            this.btnSparaNyProduktKategori.Size = new System.Drawing.Size(82, 29);
            this.btnSparaNyProduktKategori.TabIndex = 5;
            this.btnSparaNyProduktKategori.Text = "Spara";
            this.btnSparaNyProduktKategori.UseVisualStyleBackColor = true;
            this.btnSparaNyProduktKategori.Click += new System.EventHandler(this.btnSparaNyProduktKategori_Click);
            // 
            // lbNyProduktgrupp
            // 
            this.lbNyProduktgrupp.AutoSize = true;
            this.lbNyProduktgrupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNyProduktgrupp.Location = new System.Drawing.Point(18, 54);
            this.lbNyProduktgrupp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNyProduktgrupp.Name = "lbNyProduktgrupp";
            this.lbNyProduktgrupp.Size = new System.Drawing.Size(55, 20);
            this.lbNyProduktgrupp.TabIndex = 4;
            this.lbNyProduktgrupp.Text = "Namn:";
            // 
            // tbNyProduktKategori
            // 
            this.tbNyProduktKategori.Location = new System.Drawing.Point(75, 58);
            this.tbNyProduktKategori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNyProduktKategori.Name = "tbNyProduktKategori";
            this.tbNyProduktKategori.Size = new System.Drawing.Size(238, 20);
            this.tbNyProduktKategori.TabIndex = 3;
            this.tbNyProduktKategori.TextChanged += new System.EventHandler(this.tbNyProduktKategori_TextChanged);
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(148, 110);
            this.btnAvbryt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(64, 29);
            this.btnAvbryt.TabIndex = 6;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // frmRegistreraNyProduktKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 167);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.btnSparaNyProduktKategori);
            this.Controls.Add(this.lbNyProduktgrupp);
            this.Controls.Add(this.tbNyProduktKategori);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRegistreraNyProduktKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrera ny Produktkategori";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSparaNyProduktKategori;
        private System.Windows.Forms.Label lbNyProduktgrupp;
        private System.Windows.Forms.TextBox tbNyProduktKategori;
        private System.Windows.Forms.Button btnAvbryt;
    }
}