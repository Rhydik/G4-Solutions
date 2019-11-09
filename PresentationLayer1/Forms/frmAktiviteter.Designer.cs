namespace PresentationLayer1.Forms
{
    partial class frmAktiviteter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAktiviteter));
            this.lblAvdelning = new System.Windows.Forms.Label();
            this.lblBenämning = new System.Windows.Forms.Label();
            this.lblAktivitetsID = new System.Windows.Forms.Label();
            this.btnRensa = new System.Windows.Forms.Button();
            this.cmbVäljAvdelning = new System.Windows.Forms.ComboBox();
            this.tbBenämning = new System.Windows.Forms.TextBox();
            this.tbAktivitetsID = new System.Windows.Forms.TextBox();
            this.btnRegistreraNyAktivitet = new System.Windows.Forms.Button();
            this.btnRedigeraAktivitet = new System.Windows.Forms.Button();
            this.dgvAktiviteter = new System.Windows.Forms.DataGridView();
            this.lblSök = new System.Windows.Forms.Label();
            this.ucMeny = new PresentationLayer1.Forms.ucMeny();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktiviteter)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAvdelning
            // 
            this.lblAvdelning.AutoSize = true;
            this.lblAvdelning.Location = new System.Drawing.Point(406, 55);
            this.lblAvdelning.Name = "lblAvdelning";
            this.lblAvdelning.Size = new System.Drawing.Size(54, 13);
            this.lblAvdelning.TabIndex = 46;
            this.lblAvdelning.Text = "Avdelning";
            // 
            // lblBenämning
            // 
            this.lblBenämning.AutoSize = true;
            this.lblBenämning.Location = new System.Drawing.Point(300, 55);
            this.lblBenämning.Name = "lblBenämning";
            this.lblBenämning.Size = new System.Drawing.Size(35, 13);
            this.lblBenämning.TabIndex = 45;
            this.lblBenämning.Text = "Namn";
            // 
            // lblAktivitetsID
            // 
            this.lblAktivitetsID.AutoSize = true;
            this.lblAktivitetsID.Location = new System.Drawing.Point(200, 55);
            this.lblAktivitetsID.Name = "lblAktivitetsID";
            this.lblAktivitetsID.Size = new System.Drawing.Size(61, 13);
            this.lblAktivitetsID.TabIndex = 44;
            this.lblAktivitetsID.Text = "AktivitetsID";
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(623, 73);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(60, 23);
            this.btnRensa.TabIndex = 43;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            this.btnRensa.Click += new System.EventHandler(this.btnRensa_Click);
            // 
            // cmbVäljAvdelning
            // 
            this.cmbVäljAvdelning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVäljAvdelning.FormattingEnabled = true;
            this.cmbVäljAvdelning.Items.AddRange(new object[] {
            "Alla",
            "Administrativa avdelningen",
            "Försäljnings- och marknadsavdelningen"});
            this.cmbVäljAvdelning.Location = new System.Drawing.Point(409, 75);
            this.cmbVäljAvdelning.Name = "cmbVäljAvdelning";
            this.cmbVäljAvdelning.Size = new System.Drawing.Size(192, 21);
            this.cmbVäljAvdelning.TabIndex = 41;
            this.cmbVäljAvdelning.TabStop = false;
            this.cmbVäljAvdelning.SelectedIndexChanged += new System.EventHandler(this.cmbVäljAvdelning_SelectedIndexChanged);
            // 
            // tbBenämning
            // 
            this.tbBenämning.Location = new System.Drawing.Point(304, 74);
            this.tbBenämning.Name = "tbBenämning";
            this.tbBenämning.Size = new System.Drawing.Size(94, 20);
            this.tbBenämning.TabIndex = 40;
            this.tbBenämning.TextChanged += new System.EventHandler(this.tbBenämning_TextChanged);
            // 
            // tbAktivitetsID
            // 
            this.tbAktivitetsID.Location = new System.Drawing.Point(204, 74);
            this.tbAktivitetsID.Name = "tbAktivitetsID";
            this.tbAktivitetsID.Size = new System.Drawing.Size(94, 20);
            this.tbAktivitetsID.TabIndex = 39;
            this.tbAktivitetsID.TextChanged += new System.EventHandler(this.tbAktivitetsID_TextChanged);
            // 
            // btnRegistreraNyAktivitet
            // 
            this.btnRegistreraNyAktivitet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistreraNyAktivitet.Location = new System.Drawing.Point(710, 398);
            this.btnRegistreraNyAktivitet.Name = "btnRegistreraNyAktivitet";
            this.btnRegistreraNyAktivitet.Size = new System.Drawing.Size(112, 40);
            this.btnRegistreraNyAktivitet.TabIndex = 38;
            this.btnRegistreraNyAktivitet.Text = "Registrera ny aktivitet";
            this.btnRegistreraNyAktivitet.UseVisualStyleBackColor = true;
            this.btnRegistreraNyAktivitet.Click += new System.EventHandler(this.btnRegistreraNyAktivitet_Click);
            // 
            // btnRedigeraAktivitet
            // 
            this.btnRedigeraAktivitet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRedigeraAktivitet.Location = new System.Drawing.Point(585, 396);
            this.btnRedigeraAktivitet.Name = "btnRedigeraAktivitet";
            this.btnRedigeraAktivitet.Size = new System.Drawing.Size(120, 41);
            this.btnRedigeraAktivitet.TabIndex = 37;
            this.btnRedigeraAktivitet.Text = "Redigera aktivitet";
            this.btnRedigeraAktivitet.UseVisualStyleBackColor = true;
            this.btnRedigeraAktivitet.Click += new System.EventHandler(this.btnRedigeraAktivitet_Click);
            // 
            // dgvAktiviteter
            // 
            this.dgvAktiviteter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAktiviteter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAktiviteter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktiviteter.Location = new System.Drawing.Point(205, 122);
            this.dgvAktiviteter.Name = "dgvAktiviteter";
            this.dgvAktiviteter.RowHeadersWidth = 62;
            this.dgvAktiviteter.Size = new System.Drawing.Size(614, 268);
            this.dgvAktiviteter.TabIndex = 36;
            // 
            // lblSök
            // 
            this.lblSök.AutoSize = true;
            this.lblSök.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSök.Location = new System.Drawing.Point(199, 27);
            this.lblSök.Name = "lblSök";
            this.lblSök.Size = new System.Drawing.Size(45, 24);
            this.lblSök.TabIndex = 47;
            this.lblSök.Text = "Sök";
            // 
            // ucMeny
            // 
            this.ucMeny.Location = new System.Drawing.Point(5, 12);
            this.ucMeny.Margin = new System.Windows.Forms.Padding(4);
            this.ucMeny.Name = "ucMeny";
            this.ucMeny.Size = new System.Drawing.Size(194, 438);
            this.ucMeny.TabIndex = 5;
            // 
            // frmAktiviteter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.lblSök);
            this.Controls.Add(this.lblAvdelning);
            this.Controls.Add(this.lblBenämning);
            this.Controls.Add(this.lblAktivitetsID);
            this.Controls.Add(this.btnRensa);
            this.Controls.Add(this.cmbVäljAvdelning);
            this.Controls.Add(this.tbBenämning);
            this.Controls.Add(this.tbAktivitetsID);
            this.Controls.Add(this.btnRegistreraNyAktivitet);
            this.Controls.Add(this.btnRedigeraAktivitet);
            this.Controls.Add(this.dgvAktiviteter);
            this.Controls.Add(this.ucMeny);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAktiviteter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aktiviteter  | G4 Solutions Economy System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktiviteter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAvdelning;
        private System.Windows.Forms.Label lblBenämning;
        private System.Windows.Forms.Label lblAktivitetsID;
        private System.Windows.Forms.Button btnRensa;
        private System.Windows.Forms.ComboBox cmbVäljAvdelning;
        private System.Windows.Forms.TextBox tbBenämning;
        private System.Windows.Forms.TextBox tbAktivitetsID;
        private System.Windows.Forms.Button btnRegistreraNyAktivitet;
        private System.Windows.Forms.Button btnRedigeraAktivitet;
        private System.Windows.Forms.DataGridView dgvAktiviteter;
        private Forms.ucMeny ucMeny;
        private System.Windows.Forms.Label lblSök;
    }
}