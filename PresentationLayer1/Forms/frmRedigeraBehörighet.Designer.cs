namespace PresentationLayer1.Forms
{
    partial class frmRedigeraBehörighet
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
            this.Namn = new System.Windows.Forms.Label();
            this.Pnr = new System.Windows.Forms.Label();
            this.lblNamn = new System.Windows.Forms.Label();
            this.lblPnr = new System.Windows.Forms.Label();
            this.dgvBehörighet = new System.Windows.Forms.DataGridView();
            this.lblBehörighet = new System.Windows.Forms.Label();
            this.cmbBehörighet = new System.Windows.Forms.ComboBox();
            this.btnTillsätt = new System.Windows.Forms.Button();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.lblRedigeraBehörighet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBehörighet)).BeginInit();
            this.SuspendLayout();
            // 
            // Namn
            // 
            this.Namn.AutoSize = true;
            this.Namn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namn.Location = new System.Drawing.Point(128, 128);
            this.Namn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Namn.Name = "Namn";
            this.Namn.Size = new System.Drawing.Size(57, 20);
            this.Namn.TabIndex = 0;
            this.Namn.Text = "Namn";
            // 
            // Pnr
            // 
            this.Pnr.AutoSize = true;
            this.Pnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnr.Location = new System.Drawing.Point(128, 166);
            this.Pnr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pnr.Name = "Pnr";
            this.Pnr.Size = new System.Drawing.Size(38, 20);
            this.Pnr.TabIndex = 1;
            this.Pnr.Text = "Pnr";
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Location = new System.Drawing.Point(231, 128);
            this.lblNamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(51, 20);
            this.lblNamn.TabIndex = 3;
            this.lblNamn.Text = "label1";
            // 
            // lblPnr
            // 
            this.lblPnr.AutoSize = true;
            this.lblPnr.Location = new System.Drawing.Point(231, 166);
            this.lblPnr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPnr.Name = "lblPnr";
            this.lblPnr.Size = new System.Drawing.Size(51, 20);
            this.lblPnr.TabIndex = 4;
            this.lblPnr.Text = "label2";
            // 
            // dgvBehörighet
            // 
            this.dgvBehörighet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBehörighet.Location = new System.Drawing.Point(426, 128);
            this.dgvBehörighet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBehörighet.Name = "dgvBehörighet";
            this.dgvBehörighet.RowHeadersWidth = 62;
            this.dgvBehörighet.Size = new System.Drawing.Size(360, 231);
            this.dgvBehörighet.TabIndex = 6;
            // 
            // lblBehörighet
            // 
            this.lblBehörighet.AutoSize = true;
            this.lblBehörighet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBehörighet.Location = new System.Drawing.Point(422, 97);
            this.lblBehörighet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBehörighet.Name = "lblBehörighet";
            this.lblBehörighet.Size = new System.Drawing.Size(100, 20);
            this.lblBehörighet.TabIndex = 7;
            this.lblBehörighet.Text = "Behörighet";
            // 
            // cmbBehörighet
            // 
            this.cmbBehörighet.FormattingEnabled = true;
            this.cmbBehörighet.Items.AddRange(new object[] {
            "Ekonomichef",
            "Driftavdelningschef",
            "Utvecklingsavdelningsschef",
            "Marknadsavdelningsschef",
            "Kundavdelningschef",
            "Försäljningsavdelningschef"});
            this.cmbBehörighet.Location = new System.Drawing.Point(426, 362);
            this.cmbBehörighet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBehörighet.Name = "cmbBehörighet";
            this.cmbBehörighet.Size = new System.Drawing.Size(236, 28);
            this.cmbBehörighet.TabIndex = 8;
            // 
            // btnTillsätt
            // 
            this.btnTillsätt.Location = new System.Drawing.Point(674, 362);
            this.btnTillsätt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTillsätt.Name = "btnTillsätt";
            this.btnTillsätt.Size = new System.Drawing.Size(112, 35);
            this.btnTillsätt.TabIndex = 9;
            this.btnTillsätt.Text = "Tillsätt";
            this.btnTillsätt.UseVisualStyleBackColor = true;
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.BackColor = System.Drawing.Color.White;
            this.btnAvbryt.Location = new System.Drawing.Point(426, 462);
            this.btnAvbryt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(92, 89);
            this.btnAvbryt.TabIndex = 30;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = false;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // btnSpara
            // 
            this.btnSpara.BackColor = System.Drawing.Color.Yellow;
            this.btnSpara.Location = new System.Drawing.Point(602, 462);
            this.btnSpara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(184, 89);
            this.btnSpara.TabIndex = 29;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = false;
            // 
            // lblRedigeraBehörighet
            // 
            this.lblRedigeraBehörighet.AutoSize = true;
            this.lblRedigeraBehörighet.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedigeraBehörighet.Location = new System.Drawing.Point(39, 32);
            this.lblRedigeraBehörighet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRedigeraBehörighet.Name = "lblRedigeraBehörighet";
            this.lblRedigeraBehörighet.Size = new System.Drawing.Size(278, 33);
            this.lblRedigeraBehörighet.TabIndex = 33;
            this.lblRedigeraBehörighet.Text = "Redigera behörighet";
            // 
            // frmRedigeraBehörighet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(962, 594);
            this.Controls.Add(this.lblRedigeraBehörighet);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.btnTillsätt);
            this.Controls.Add(this.cmbBehörighet);
            this.Controls.Add(this.lblBehörighet);
            this.Controls.Add(this.dgvBehörighet);
            this.Controls.Add(this.lblPnr);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.Pnr);
            this.Controls.Add(this.Namn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRedigeraBehörighet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRedigeraBehörighet";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBehörighet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namn;
        private System.Windows.Forms.Label Pnr;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label lblPnr;
        private System.Windows.Forms.DataGridView dgvBehörighet;
        private System.Windows.Forms.Label lblBehörighet;
        private System.Windows.Forms.ComboBox cmbBehörighet;
        private System.Windows.Forms.Button btnTillsätt;
        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Label lblRedigeraBehörighet;
    }
}