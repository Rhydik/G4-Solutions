namespace PresentationLayer1.Forms
{
    partial class frmBehörighet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBehörighet));
            this.lblNamn = new System.Windows.Forms.Label();
            this.lblPersonnummer = new System.Windows.Forms.Label();
            this.btnRensa = new System.Windows.Forms.Button();
            this.tbNamn = new System.Windows.Forms.TextBox();
            this.tbPersonNr = new System.Windows.Forms.TextBox();
            this.btnRedigeraBehörighet = new System.Windows.Forms.Button();
            this.dgvBehörighet = new System.Windows.Forms.DataGridView();
            this.ucMeny = new PresentationLayer1.Forms.ucMeny();
            this.lblSök = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBehörighet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Location = new System.Drawing.Point(360, 59);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(35, 13);
            this.lblNamn.TabIndex = 29;
            this.lblNamn.Text = "Namn";
            // 
            // lblPersonnummer
            // 
            this.lblPersonnummer.AutoSize = true;
            this.lblPersonnummer.Location = new System.Drawing.Point(206, 59);
            this.lblPersonnummer.Name = "lblPersonnummer";
            this.lblPersonnummer.Size = new System.Drawing.Size(77, 13);
            this.lblPersonnummer.TabIndex = 28;
            this.lblPersonnummer.Text = "Personnummer";
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(518, 79);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(60, 20);
            this.btnRensa.TabIndex = 27;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            this.btnRensa.Click += new System.EventHandler(this.btnRensa_Click);
            // 
            // tbNamn
            // 
            this.tbNamn.Location = new System.Drawing.Point(362, 80);
            this.tbNamn.Name = "tbNamn";
            this.tbNamn.Size = new System.Drawing.Size(128, 20);
            this.tbNamn.TabIndex = 24;
            this.tbNamn.TextChanged += new System.EventHandler(this.tbNamn_TextChanged);
            // 
            // tbPersonNr
            // 
            this.tbPersonNr.Location = new System.Drawing.Point(206, 80);
            this.tbPersonNr.Name = "tbPersonNr";
            this.tbPersonNr.Size = new System.Drawing.Size(128, 20);
            this.tbPersonNr.TabIndex = 23;
            this.tbPersonNr.TextChanged += new System.EventHandler(this.tbPersonNr_TextChanged);
            // 
            // btnRedigeraBehörighet
            // 
            this.btnRedigeraBehörighet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRedigeraBehörighet.Location = new System.Drawing.Point(702, 397);
            this.btnRedigeraBehörighet.Name = "btnRedigeraBehörighet";
            this.btnRedigeraBehörighet.Size = new System.Drawing.Size(120, 41);
            this.btnRedigeraBehörighet.TabIndex = 21;
            this.btnRedigeraBehörighet.Text = "Redigera behörighet";
            this.btnRedigeraBehörighet.UseVisualStyleBackColor = true;
            this.btnRedigeraBehörighet.Click += new System.EventHandler(this.btnRedigeraBehörighet_Click);
            // 
            // dgvBehörighet
            // 
            this.dgvBehörighet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBehörighet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBehörighet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBehörighet.Location = new System.Drawing.Point(209, 123);
            this.dgvBehörighet.Name = "dgvBehörighet";
            this.dgvBehörighet.ReadOnly = true;
            this.dgvBehörighet.RowHeadersWidth = 62;
            this.dgvBehörighet.Size = new System.Drawing.Size(614, 268);
            this.dgvBehörighet.TabIndex = 20;
            // 
            // ucMeny
            // 
            this.ucMeny.Location = new System.Drawing.Point(8, 8);
            this.ucMeny.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucMeny.Name = "ucMeny";
            this.ucMeny.Size = new System.Drawing.Size(194, 438);
            this.ucMeny.TabIndex = 5;
            // 
            // lblSök
            // 
            this.lblSök.AutoSize = true;
            this.lblSök.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSök.Location = new System.Drawing.Point(205, 28);
            this.lblSök.Name = "lblSök";
            this.lblSök.Size = new System.Drawing.Size(45, 24);
            this.lblSök.TabIndex = 48;
            this.lblSök.Text = "Sök";
            // 
            // frmBehörighet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.lblSök);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.lblPersonnummer);
            this.Controls.Add(this.btnRensa);
            this.Controls.Add(this.tbNamn);
            this.Controls.Add(this.tbPersonNr);
            this.Controls.Add(this.btnRedigeraBehörighet);
            this.Controls.Add(this.dgvBehörighet);
            this.Controls.Add(this.ucMeny);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBehörighet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Behörighet  | G4 Solutions Economy System";
            this.Activated += new System.EventHandler(this.frmBehörighet_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBehörighet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label lblPersonnummer;
        private System.Windows.Forms.Button btnRensa;
        private System.Windows.Forms.TextBox tbNamn;
        private System.Windows.Forms.TextBox tbPersonNr;
        private System.Windows.Forms.Button btnRedigeraBehörighet;
        private System.Windows.Forms.DataGridView dgvBehörighet;
        private Forms.ucMeny ucMeny;
        private System.Windows.Forms.Label lblSök;
    }
}