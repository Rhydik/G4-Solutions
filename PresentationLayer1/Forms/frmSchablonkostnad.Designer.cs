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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchablonkostnad));
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
            this.lblKontobenämning.Location = new System.Drawing.Point(453, 71);
            this.lblKontobenämning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKontobenämning.Name = "lblKontobenämning";
            this.lblKontobenämning.Size = new System.Drawing.Size(44, 16);
            this.lblKontobenämning.TabIndex = 40;
            this.lblKontobenämning.Text = "Namn";
            // 
            // lblKonto
            // 
            this.lblKonto.AutoSize = true;
            this.lblKonto.Location = new System.Drawing.Point(279, 71);
            this.lblKonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKonto.Name = "lblKonto";
            this.lblKonto.Size = new System.Drawing.Size(42, 16);
            this.lblKonto.TabIndex = 39;
            this.lblKonto.Text = "Konto";
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(655, 89);
            this.btnRensa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(80, 28);
            this.btnRensa.TabIndex = 38;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            this.btnRensa.Click += new System.EventHandler(this.btnRensa_Click_1);
            // 
            // tbKontobenämning
            // 
            this.tbKontobenämning.Location = new System.Drawing.Point(457, 91);
            this.tbKontobenämning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKontobenämning.Name = "tbKontobenämning";
            this.tbKontobenämning.Size = new System.Drawing.Size(169, 22);
            this.tbKontobenämning.TabIndex = 36;
            this.tbKontobenämning.TextChanged += new System.EventHandler(this.tbKontobenämning_TextChanged);
            // 
            // tbKonto
            // 
            this.tbKonto.Location = new System.Drawing.Point(279, 91);
            this.tbKonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKonto.Name = "tbKonto";
            this.tbKonto.Size = new System.Drawing.Size(169, 22);
            this.tbKonto.TabIndex = 35;
            this.tbKonto.TextChanged += new System.EventHandler(this.tbKonto_TextChanged);
            // 
            // btnRegistreraNyttKonto
            // 
            this.btnRegistreraNyttKonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistreraNyttKonto.Location = new System.Drawing.Point(948, 490);
            this.btnRegistreraNyttKonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistreraNyttKonto.Name = "btnRegistreraNyttKonto";
            this.btnRegistreraNyttKonto.Size = new System.Drawing.Size(149, 49);
            this.btnRegistreraNyttKonto.TabIndex = 34;
            this.btnRegistreraNyttKonto.Text = "Registrera nytt konto";
            this.btnRegistreraNyttKonto.UseVisualStyleBackColor = true;
            this.btnRegistreraNyttKonto.Click += new System.EventHandler(this.btnRegistreraNyttKonto_Click);
            // 
            // btnRedigeraKonto
            // 
            this.btnRedigeraKonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRedigeraKonto.Location = new System.Drawing.Point(780, 490);
            this.btnRedigeraKonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRedigeraKonto.Name = "btnRedigeraKonto";
            this.btnRedigeraKonto.Size = new System.Drawing.Size(160, 50);
            this.btnRedigeraKonto.TabIndex = 33;
            this.btnRedigeraKonto.Text = "Redigera konto";
            this.btnRedigeraKonto.UseVisualStyleBackColor = true;
            this.btnRedigeraKonto.Click += new System.EventHandler(this.btnRedigeraKonto_Click);
            // 
            // gvSchablonkostnad
            // 
            this.gvSchablonkostnad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvSchablonkostnad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSchablonkostnad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSchablonkostnad.Location = new System.Drawing.Point(279, 139);
            this.gvSchablonkostnad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvSchablonkostnad.Name = "gvSchablonkostnad";
            this.gvSchablonkostnad.ReadOnly = true;
            this.gvSchablonkostnad.RowHeadersWidth = 62;
            this.gvSchablonkostnad.Size = new System.Drawing.Size(819, 330);
            this.gvSchablonkostnad.TabIndex = 32;
            this.gvSchablonkostnad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSchablonkostnad_CellContentClick);
            // 
            // tbAvkastningskrav
            // 
            this.tbAvkastningskrav.Location = new System.Drawing.Point(279, 503);
            this.tbAvkastningskrav.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAvkastningskrav.Name = "tbAvkastningskrav";
            this.tbAvkastningskrav.Size = new System.Drawing.Size(148, 22);
            this.tbAvkastningskrav.TabIndex = 41;
            // 
            // lblAvkastningskrav
            // 
            this.lblAvkastningskrav.AutoSize = true;
            this.lblAvkastningskrav.Location = new System.Drawing.Point(275, 484);
            this.lblAvkastningskrav.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvkastningskrav.Name = "lblAvkastningskrav";
            this.lblAvkastningskrav.Size = new System.Drawing.Size(107, 16);
            this.lblAvkastningskrav.TabIndex = 42;
            this.lblAvkastningskrav.Text = "Avkastningskrav";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 501);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 28);
            this.button1.TabIndex = 43;
            this.button1.Text = "Spara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSök
            // 
            this.lblSök.AutoSize = true;
            this.lblSök.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSök.Location = new System.Drawing.Point(272, 32);
            this.lblSök.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSök.Name = "lblSök";
            this.lblSök.Size = new System.Drawing.Size(45, 24);
            this.lblSök.TabIndex = 44;
            this.lblSök.Text = "Sök";
            // 
            // ucMeny
            // 
            this.ucMeny.Location = new System.Drawing.Point(11, 10);
            this.ucMeny.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucMeny.Name = "ucMeny";
            this.ucMeny.Size = new System.Drawing.Size(259, 539);
            this.ucMeny.TabIndex = 5;
            // 
            // frmSchablonkostnad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 554);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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