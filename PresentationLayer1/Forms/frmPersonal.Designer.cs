namespace PresentationLayer1.Forms
{
    partial class frmPersonal
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
            this.lblNamn = new System.Windows.Forms.Label();
            this.lblPersonnummer = new System.Windows.Forms.Label();
            this.btnRensa = new System.Windows.Forms.Button();
            this.btnSök = new System.Windows.Forms.Button();
            this.tbPersonal = new System.Windows.Forms.TextBox();
            this.tbPersonnummer = new System.Windows.Forms.TextBox();
            this.btnRegistreraNyPersonal = new System.Windows.Forms.Button();
            this.btnRedigeraPersonal = new System.Windows.Forms.Button();
            this.gvPersonal = new System.Windows.Forms.DataGridView();
            this.ucMeny = new PresentationLayer1.Forms.ucMeny();
            ((System.ComponentModel.ISupportInitialize)(this.gvPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Location = new System.Drawing.Point(397, 32);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(35, 13);
            this.lblNamn.TabIndex = 30;
            this.lblNamn.Text = "Namn";
            // 
            // lblPersonnummer
            // 
            this.lblPersonnummer.AutoSize = true;
            this.lblPersonnummer.Location = new System.Drawing.Point(243, 32);
            this.lblPersonnummer.Name = "lblPersonnummer";
            this.lblPersonnummer.Size = new System.Drawing.Size(77, 13);
            this.lblPersonnummer.TabIndex = 29;
            this.lblPersonnummer.Text = "Personnummer";
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(311, 83);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(60, 23);
            this.btnRensa.TabIndex = 28;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(244, 83);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(60, 23);
            this.btnSök.TabIndex = 27;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            // 
            // tbPersonal
            // 
            this.tbPersonal.Location = new System.Drawing.Point(400, 52);
            this.tbPersonal.Name = "tbPersonal";
            this.tbPersonal.Size = new System.Drawing.Size(128, 20);
            this.tbPersonal.TabIndex = 25;
            this.tbPersonal.TextChanged += new System.EventHandler(this.tbPersonal_TextChanged);
            // 
            // tbPersonnummer
            // 
            this.tbPersonnummer.Location = new System.Drawing.Point(243, 52);
            this.tbPersonnummer.Name = "tbPersonnummer";
            this.tbPersonnummer.Size = new System.Drawing.Size(128, 20);
            this.tbPersonnummer.TabIndex = 24;
            this.tbPersonnummer.TextChanged += new System.EventHandler(this.tbPersonnummer_TextChanged);
            // 
            // btnRegistreraNyPersonal
            // 
            this.btnRegistreraNyPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistreraNyPersonal.Location = new System.Drawing.Point(701, 398);
            this.btnRegistreraNyPersonal.Name = "btnRegistreraNyPersonal";
            this.btnRegistreraNyPersonal.Size = new System.Drawing.Size(112, 40);
            this.btnRegistreraNyPersonal.TabIndex = 23;
            this.btnRegistreraNyPersonal.Text = "Registrera ny personal";
            this.btnRegistreraNyPersonal.UseVisualStyleBackColor = true;
            this.btnRegistreraNyPersonal.Click += new System.EventHandler(this.btnRegistreraNyPersonal_Click);
            // 
            // btnRedigeraPersonal
            // 
            this.btnRedigeraPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRedigeraPersonal.Location = new System.Drawing.Point(575, 397);
            this.btnRedigeraPersonal.Name = "btnRedigeraPersonal";
            this.btnRedigeraPersonal.Size = new System.Drawing.Size(120, 41);
            this.btnRedigeraPersonal.TabIndex = 22;
            this.btnRedigeraPersonal.Text = "Redigera personal";
            this.btnRedigeraPersonal.UseVisualStyleBackColor = true;
            this.btnRedigeraPersonal.Click += new System.EventHandler(this.btnRedigeraPersonal_Click);
            // 
            // gvPersonal
            // 
            this.gvPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPersonal.Location = new System.Drawing.Point(244, 119);
            this.gvPersonal.Name = "gvPersonal";
            this.gvPersonal.ReadOnly = true;
            this.gvPersonal.RowHeadersWidth = 62;
            this.gvPersonal.Size = new System.Drawing.Size(569, 273);
            this.gvPersonal.TabIndex = 21;
            this.gvPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPersonal_CellContentClick);
            //
            // ucMeny
            //
            this.ucMeny.Location = new System.Drawing.Point(8, 8);
            this.ucMeny.Name = "ucMeny";
            this.ucMeny.Size = new System.Drawing.Size(194, 438);
            this.ucMeny.TabIndex = 5;
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.lblPersonnummer);
            this.Controls.Add(this.btnRensa);
            this.Controls.Add(this.btnSök);
            this.Controls.Add(this.tbPersonal);
            this.Controls.Add(this.tbPersonnummer);
            this.Controls.Add(this.btnRegistreraNyPersonal);
            this.Controls.Add(this.btnRedigeraPersonal);
            this.Controls.Add(this.gvPersonal);
            this.Controls.Add(this.ucMeny);
            this.Name = "frmPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal  | G4 Solutions Economy System";
            ((System.ComponentModel.ISupportInitialize)(this.gvPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label lblPersonnummer;
        private System.Windows.Forms.Button btnRensa;
        private System.Windows.Forms.Button btnSök;
        private System.Windows.Forms.TextBox tbPersonal;
        private System.Windows.Forms.TextBox tbPersonnummer;
        private System.Windows.Forms.Button btnRegistreraNyPersonal;
        private System.Windows.Forms.Button btnRedigeraPersonal;
        private System.Windows.Forms.DataGridView gvPersonal;
        private Forms.ucMeny ucMeny;
    }
}