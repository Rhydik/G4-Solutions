namespace PresentationLayer1.Forms
{
    partial class frmSchablonkostnad
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
            this.lblKontobenämning = new System.Windows.Forms.Label();
            this.lblKonto = new System.Windows.Forms.Label();
            this.btnRensa = new System.Windows.Forms.Button();
            this.tbKontobenämning = new System.Windows.Forms.TextBox();
            this.tbKonto = new System.Windows.Forms.TextBox();
            this.btnRegistreraNyttKonto = new System.Windows.Forms.Button();
            this.btnRedigeraKonto = new System.Windows.Forms.Button();
            this.gvSchablonkostnad = new System.Windows.Forms.DataGridView();
            this.tbAvkastningskrav = new System.Windows.Forms.TextBox();
            this.lblAvkastningskrav = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSök = new System.Windows.Forms.Label();
            this.ucMeny = new PresentationLayer1.Forms.ucMeny();
            ((System.ComponentModel.ISupportInitialize)(this.gvSchablonkostnad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKontobenämning
            // 
            this.lblKontobenämning.AutoSize = true;
            this.lblKontobenämning.Location = new System.Drawing.Point(340, 58);
            this.lblKontobenämning.Name = "lblKontobenämning";
            this.lblKontobenämning.Size = new System.Drawing.Size(35, 13);
            this.lblKontobenämning.TabIndex = 40;
            this.lblKontobenämning.Text = "Namn";
            // 
            // lblKonto
            // 
            this.lblKonto.AutoSize = true;
            this.lblKonto.Location = new System.Drawing.Point(209, 58);
            this.lblKonto.Name = "lblKonto";
            this.lblKonto.Size = new System.Drawing.Size(35, 13);
            this.lblKonto.TabIndex = 39;
            this.lblKonto.Text = "Konto";
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(491, 72);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(60, 23);
            this.btnRensa.TabIndex = 38;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            this.btnRensa.Click += new System.EventHandler(this.btnRensa_Click_1);
            // 
            // tbKontobenämning
            // 
            this.tbKontobenämning.Location = new System.Drawing.Point(343, 74);
            this.tbKontobenämning.Name = "tbKontobenämning";
            this.tbKontobenämning.Size = new System.Drawing.Size(128, 20);
            this.tbKontobenämning.TabIndex = 36;
            this.tbKontobenämning.TextChanged += new System.EventHandler(this.tbKontobenämning_TextChanged);
            // 
            // tbKonto
            // 
            this.tbKonto.Location = new System.Drawing.Point(209, 74);
            this.tbKonto.Name = "tbKonto";
            this.tbKonto.Size = new System.Drawing.Size(128, 20);
            this.tbKonto.TabIndex = 35;
            this.tbKonto.TextChanged += new System.EventHandler(this.tbKonto_TextChanged);
            // 
            // btnRegistreraNyttKonto
            // 
            this.btnRegistreraNyttKonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistreraNyttKonto.Location = new System.Drawing.Point(711, 398);
            this.btnRegistreraNyttKonto.Name = "btnRegistreraNyttKonto";
            this.btnRegistreraNyttKonto.Size = new System.Drawing.Size(112, 40);
            this.btnRegistreraNyttKonto.TabIndex = 34;
            this.btnRegistreraNyttKonto.Text = "Registrera nytt konto";
            this.btnRegistreraNyttKonto.UseVisualStyleBackColor = true;
            this.btnRegistreraNyttKonto.Click += new System.EventHandler(this.btnRegistreraNyttKonto_Click);
            // 
            // btnRedigeraKonto
            // 
            this.btnRedigeraKonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRedigeraKonto.Location = new System.Drawing.Point(585, 398);
            this.btnRedigeraKonto.Name = "btnRedigeraKonto";
            this.btnRedigeraKonto.Size = new System.Drawing.Size(120, 41);
            this.btnRedigeraKonto.TabIndex = 33;
            this.btnRedigeraKonto.Text = "Redigera konto";
            this.btnRedigeraKonto.UseVisualStyleBackColor = true;
            this.btnRedigeraKonto.Click += new System.EventHandler(this.btnRedigeraKonto_Click);
            // 
            // gvSchablonkostnad
            // 
            this.gvSchablonkostnad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSchablonkostnad.Location = new System.Drawing.Point(209, 113);
            this.gvSchablonkostnad.Name = "gvSchablonkostnad";
            this.gvSchablonkostnad.ReadOnly = true;
            this.gvSchablonkostnad.RowHeadersWidth = 62;
            this.gvSchablonkostnad.Size = new System.Drawing.Size(614, 268);
            this.gvSchablonkostnad.TabIndex = 32;
            this.gvSchablonkostnad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSchablonkostnad_CellContentClick);
            // 
            // tbAvkastningskrav
            // 
            this.tbAvkastningskrav.Location = new System.Drawing.Point(209, 409);
            this.tbAvkastningskrav.Name = "tbAvkastningskrav";
            this.tbAvkastningskrav.Size = new System.Drawing.Size(112, 20);
            this.tbAvkastningskrav.TabIndex = 41;
            // 
            // lblAvkastningskrav
            // 
            this.lblAvkastningskrav.AutoSize = true;
            this.lblAvkastningskrav.Location = new System.Drawing.Point(206, 393);
            this.lblAvkastningskrav.Name = "lblAvkastningskrav";
            this.lblAvkastningskrav.Size = new System.Drawing.Size(86, 13);
            this.lblAvkastningskrav.TabIndex = 42;
            this.lblAvkastningskrav.Text = "Avkastningskrav";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Spara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSök
            // 
            this.lblSök.AutoSize = true;
            this.lblSök.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSök.Location = new System.Drawing.Point(204, 26);
            this.lblSök.Name = "lblSök";
            this.lblSök.Size = new System.Drawing.Size(45, 24);
            this.lblSök.TabIndex = 44;
            this.lblSök.Text = "Sök";
            // 
            // ucMeny
            // 
            this.ucMeny.Location = new System.Drawing.Point(8, 8);
            this.ucMeny.Name = "ucMeny";
            this.ucMeny.Size = new System.Drawing.Size(194, 438);
            this.ucMeny.TabIndex = 5;
            // 
            // frmSchablonkostnad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.lblSök);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAvkastningskrav);
            this.Controls.Add(this.tbAvkastningskrav);
            this.Controls.Add(this.lblKontobenämning);
            this.Controls.Add(this.lblKonto);
            this.Controls.Add(this.btnRensa);
            this.Controls.Add(this.tbKontobenämning);
            this.Controls.Add(this.tbKonto);
            this.Controls.Add(this.btnRegistreraNyttKonto);
            this.Controls.Add(this.btnRedigeraKonto);
            this.Controls.Add(this.gvSchablonkostnad);
            this.Controls.Add(this.ucMeny);
            this.Name = "frmSchablonkostnad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schablonkostnad  | G4 Solutions Economy System";
            ((System.ComponentModel.ISupportInitialize)(this.gvSchablonkostnad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKontobenämning;
        private System.Windows.Forms.Label lblKonto;
        private System.Windows.Forms.Button btnRensa;
        private System.Windows.Forms.TextBox tbKontobenämning;
        private System.Windows.Forms.TextBox tbKonto;
        private System.Windows.Forms.Button btnRegistreraNyttKonto;
        private System.Windows.Forms.Button btnRedigeraKonto;
        private System.Windows.Forms.DataGridView gvSchablonkostnad;
        private System.Windows.Forms.TextBox tbAvkastningskrav;
        private System.Windows.Forms.Label lblAvkastningskrav;
        private System.Windows.Forms.Button button1;
        private Forms.ucMeny ucMeny;
        private System.Windows.Forms.Label lblSök;
    }
}