namespace PresentationLayer1.Forms
{
    partial class ucSökFältKund
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKundkategori = new System.Windows.Forms.Label();
            this.lblKund = new System.Windows.Forms.Label();
            this.lblKundID = new System.Windows.Forms.Label();
            this.btnRensa = new System.Windows.Forms.Button();
            this.cmbKundkategori = new System.Windows.Forms.ComboBox();
            this.tbNamn = new System.Windows.Forms.TextBox();
            this.tbKundID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblKundkategori
            // 
            this.lblKundkategori.AutoSize = true;
            this.lblKundkategori.Location = new System.Drawing.Point(270, 0);
            this.lblKundkategori.Name = "lblKundkategori";
            this.lblKundkategori.Size = new System.Drawing.Size(70, 13);
            this.lblKundkategori.TabIndex = 47;
            this.lblKundkategori.Text = "Kundkategori";
            // 
            // lblKund
            // 
            this.lblKund.AutoSize = true;
            this.lblKund.Location = new System.Drawing.Point(134, 0);
            this.lblKund.Name = "lblKund";
            this.lblKund.Size = new System.Drawing.Size(32, 13);
            this.lblKund.TabIndex = 46;
            this.lblKund.Text = "Kund";
            // 
            // lblKundID
            // 
            this.lblKundID.AutoSize = true;
            this.lblKundID.Location = new System.Drawing.Point(3, 0);
            this.lblKundID.Name = "lblKundID";
            this.lblKundID.Size = new System.Drawing.Size(43, 13);
            this.lblKundID.TabIndex = 45;
            this.lblKundID.Text = "KundID";
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(471, 21);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(60, 23);
            this.btnRensa.TabIndex = 44;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            // 
            // cmbKundkategori
            // 
            this.cmbKundkategori.BackColor = System.Drawing.SystemColors.Window;
            this.cmbKundkategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKundkategori.FormattingEnabled = true;
            this.cmbKundkategori.Items.AddRange(new object[] {
            "Alla",
            "Offentlig",
            "Näringsliv"});
            this.cmbKundkategori.Location = new System.Drawing.Point(273, 21);
            this.cmbKundkategori.Name = "cmbKundkategori";
            this.cmbKundkategori.Size = new System.Drawing.Size(192, 21);
            this.cmbKundkategori.TabIndex = 43;
            // 
            // tbNamn
            // 
            this.tbNamn.Location = new System.Drawing.Point(137, 21);
            this.tbNamn.Name = "tbNamn";
            this.tbNamn.Size = new System.Drawing.Size(128, 20);
            this.tbNamn.TabIndex = 42;
            // 
            // tbKundID
            // 
            this.tbKundID.Location = new System.Drawing.Point(3, 21);
            this.tbKundID.Name = "tbKundID";
            this.tbKundID.Size = new System.Drawing.Size(128, 20);
            this.tbKundID.TabIndex = 41;
            // 
            // ucSökFältKund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblKundkategori);
            this.Controls.Add(this.lblKund);
            this.Controls.Add(this.lblKundID);
            this.Controls.Add(this.btnRensa);
            this.Controls.Add(this.cmbKundkategori);
            this.Controls.Add(this.tbNamn);
            this.Controls.Add(this.tbKundID);
            this.Name = "ucSökFältKund";
            this.Size = new System.Drawing.Size(539, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKundkategori;
        private System.Windows.Forms.Label lblKund;
        private System.Windows.Forms.Label lblKundID;
        private System.Windows.Forms.Button btnRensa;
        private System.Windows.Forms.ComboBox cmbKundkategori;
        private System.Windows.Forms.TextBox tbNamn;
        private System.Windows.Forms.TextBox tbKundID;
    }
}
