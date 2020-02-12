namespace PresentationLayer1.Forms
{
    partial class frmKostnadsbudgetering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKostnadsbudgetering));
            this.dgvÖvre = new System.Windows.Forms.DataGridView();
            this.btnExportera = new System.Windows.Forms.Button();
            this.btnLåsBudget = new System.Windows.Forms.Button();
            this.cmbAvdelning = new System.Windows.Forms.ComboBox();
            this.lblAvdelning = new System.Windows.Forms.Label();
            this.dgvNedre = new System.Windows.Forms.DataGridView();
            this.buttonVäljAvdelning = new System.Windows.Forms.Button();
            this.cbProdukt = new System.Windows.Forms.ComboBox();
            this.lblprodukt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAndel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.ucMeny1 = new PresentationLayer1.Forms.ucMeny();
            this.lblSök = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvÖvre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNedre)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvÖvre
            // 
            this.dgvÖvre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvÖvre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvÖvre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvÖvre.Location = new System.Drawing.Point(208, 84);
            this.dgvÖvre.Name = "dgvÖvre";
            this.dgvÖvre.ReadOnly = true;
            this.dgvÖvre.RowHeadersWidth = 62;
            this.dgvÖvre.Size = new System.Drawing.Size(530, 441);
            this.dgvÖvre.TabIndex = 59;
            // 
            // btnExportera
            // 
            this.btnExportera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportera.Location = new System.Drawing.Point(208, 531);
            this.btnExportera.Name = "btnExportera";
            this.btnExportera.Size = new System.Drawing.Size(120, 41);
            this.btnExportera.TabIndex = 69;
            this.btnExportera.Text = "Exportera";
            this.btnExportera.UseVisualStyleBackColor = true;
            // 
            // btnLåsBudget
            // 
            this.btnLåsBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLåsBudget.Location = new System.Drawing.Point(1016, 531);
            this.btnLåsBudget.Name = "btnLåsBudget";
            this.btnLåsBudget.Size = new System.Drawing.Size(120, 41);
            this.btnLåsBudget.TabIndex = 68;
            this.btnLåsBudget.Text = "Lås Budget";
            this.btnLåsBudget.UseVisualStyleBackColor = true;
            // 
            // cmbAvdelning
            // 
            this.cmbAvdelning.FormattingEnabled = true;
            this.cmbAvdelning.Location = new System.Drawing.Point(207, 55);
            this.cmbAvdelning.Name = "cmbAvdelning";
            this.cmbAvdelning.Size = new System.Drawing.Size(121, 21);
            this.cmbAvdelning.TabIndex = 70;
            // 
            // lblAvdelning
            // 
            this.lblAvdelning.AutoSize = true;
            this.lblAvdelning.Location = new System.Drawing.Point(206, 39);
            this.lblAvdelning.Name = "lblAvdelning";
            this.lblAvdelning.Size = new System.Drawing.Size(54, 13);
            this.lblAvdelning.TabIndex = 71;
            this.lblAvdelning.Text = "Avdelning";
            // 
            // dgvNedre
            // 
            this.dgvNedre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNedre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNedre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNedre.Location = new System.Drawing.Point(744, 236);
            this.dgvNedre.Name = "dgvNedre";
            this.dgvNedre.Size = new System.Drawing.Size(518, 289);
            this.dgvNedre.TabIndex = 75;
            // 
            // buttonVäljAvdelning
            // 
            this.buttonVäljAvdelning.Location = new System.Drawing.Point(336, 55);
            this.buttonVäljAvdelning.Name = "buttonVäljAvdelning";
            this.buttonVäljAvdelning.Size = new System.Drawing.Size(75, 23);
            this.buttonVäljAvdelning.TabIndex = 76;
            this.buttonVäljAvdelning.Text = "Välj Avdelning";
            this.buttonVäljAvdelning.UseVisualStyleBackColor = true;
            this.buttonVäljAvdelning.Click += new System.EventHandler(this.buttonVäljAvdelning_Click);
            // 
            // cbProdukt
            // 
            this.cbProdukt.FormattingEnabled = true;
            this.cbProdukt.Location = new System.Drawing.Point(743, 42);
            this.cbProdukt.Name = "cbProdukt";
            this.cbProdukt.Size = new System.Drawing.Size(225, 21);
            this.cbProdukt.TabIndex = 77;
            this.cbProdukt.SelectedIndexChanged += new System.EventHandler(this.cbProdukt_SelectedIndexChanged);
            // 
            // lblprodukt
            // 
            this.lblprodukt.AutoSize = true;
            this.lblprodukt.Location = new System.Drawing.Point(817, 121);
            this.lblprodukt.Name = "lblprodukt";
            this.lblprodukt.Size = new System.Drawing.Size(44, 13);
            this.lblprodukt.TabIndex = 79;
            this.lblprodukt.Text = "Produkt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(740, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Arbetsandel";
            // 
            // tbAndel
            // 
            this.tbAndel.Location = new System.Drawing.Point(744, 173);
            this.tbAndel.Name = "tbAndel";
            this.tbAndel.Size = new System.Drawing.Size(225, 20);
            this.tbAndel.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(744, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Vald produkt:";
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(893, 200);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(75, 23);
            this.btnLäggTill.TabIndex = 84;
            this.btnLäggTill.Text = "Lägg till";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            this.btnLäggTill.Click += new System.EventHandler(this.btnLäggTill_Click);
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(1187, 531);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(75, 23);
            this.btnTaBort.TabIndex = 85;
            this.btnTaBort.Text = "Ta bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // ucMeny1
            // 
            this.ucMeny1.Location = new System.Drawing.Point(6, 25);
            this.ucMeny1.Name = "ucMeny1";
            this.ucMeny1.Size = new System.Drawing.Size(194, 438);
            this.ucMeny1.TabIndex = 86;
            // 
            // lblSök
            // 
            this.lblSök.AutoSize = true;
            this.lblSök.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSök.Location = new System.Drawing.Point(205, 15);
            this.lblSök.Name = "lblSök";
            this.lblSök.Size = new System.Drawing.Size(133, 24);
            this.lblSök.TabIndex = 89;
            this.lblSök.Text = "Välj Personal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(739, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 90;
            this.label4.Text = "Välj Produkt";
            // 
            // frmKostnadsbudgetering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 584);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSök);
            this.Controls.Add(this.ucMeny1);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnLäggTill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAndel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblprodukt);
            this.Controls.Add(this.cbProdukt);
            this.Controls.Add(this.buttonVäljAvdelning);
            this.Controls.Add(this.dgvNedre);
            this.Controls.Add(this.lblAvdelning);
            this.Controls.Add(this.cmbAvdelning);
            this.Controls.Add(this.dgvÖvre);
            this.Controls.Add(this.btnExportera);
            this.Controls.Add(this.btnLåsBudget);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKostnadsbudgetering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personalfördelning - Produkt  | G4 Solutions Economy System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvÖvre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNedre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvÖvre;
        private System.Windows.Forms.Button btnExportera;
        private System.Windows.Forms.Button btnLåsBudget;
        private System.Windows.Forms.ComboBox cmbAvdelning;
        private System.Windows.Forms.Label lblAvdelning;
        private System.Windows.Forms.DataGridView dgvNedre;
        private System.Windows.Forms.Button buttonVäljAvdelning;
        private System.Windows.Forms.ComboBox cbProdukt;
        private System.Windows.Forms.Label lblprodukt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAndel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLäggTill;
        private System.Windows.Forms.Button btnTaBort;
        private ucMeny ucMeny1;
        private System.Windows.Forms.Label lblSök;
        private System.Windows.Forms.Label label4;
    }
}