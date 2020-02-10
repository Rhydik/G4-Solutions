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
            this.label1 = new System.Windows.Forms.Label();
            this.lblprodukt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAndel = new System.Windows.Forms.TextBox();
            this.ucMeny = new PresentationLayer1.Forms.ucMeny();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
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
            this.dgvÖvre.Location = new System.Drawing.Point(208, 68);
            this.dgvÖvre.Name = "dgvÖvre";
            this.dgvÖvre.ReadOnly = true;
            this.dgvÖvre.RowHeadersWidth = 62;
            this.dgvÖvre.Size = new System.Drawing.Size(530, 457);
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
            this.cmbAvdelning.Items.AddRange(new object[] {
            "Driftavdelning",
            "Försäljnings- och marknadsavdelningen"});
            this.cmbAvdelning.Location = new System.Drawing.Point(209, 41);
            this.cmbAvdelning.Name = "cmbAvdelning";
            this.cmbAvdelning.Size = new System.Drawing.Size(121, 21);
            this.cmbAvdelning.TabIndex = 70;
            // 
            // lblAvdelning
            // 
            this.lblAvdelning.AutoSize = true;
            this.lblAvdelning.Location = new System.Drawing.Point(206, 25);
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
            this.buttonVäljAvdelning.Location = new System.Drawing.Point(336, 40);
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
            this.cbProdukt.Location = new System.Drawing.Point(744, 84);
            this.cbProdukt.Name = "cbProdukt";
            this.cbProdukt.Size = new System.Drawing.Size(225, 21);
            this.cbProdukt.TabIndex = 77;
            this.cbProdukt.SelectedIndexChanged += new System.EventHandler(this.cbProdukt_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(741, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Välj Produkt";
            // 
            // lblprodukt
            // 
            this.lblprodukt.AutoSize = true;
            this.lblprodukt.Location = new System.Drawing.Point(741, 128);
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
            // ucMeny
            // 
            this.ucMeny.Location = new System.Drawing.Point(8, 8);
            this.ucMeny.Margin = new System.Windows.Forms.Padding(4);
            this.ucMeny.Name = "ucMeny";
            this.ucMeny.Size = new System.Drawing.Size(194, 438);
            this.ucMeny.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(741, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Vald produkt";
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
            // frmKostnadsbudgetering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 584);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnLäggTill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAndel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblprodukt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProdukt);
            this.Controls.Add(this.buttonVäljAvdelning);
            this.Controls.Add(this.dgvNedre);
            this.Controls.Add(this.lblAvdelning);
            this.Controls.Add(this.cmbAvdelning);
            this.Controls.Add(this.dgvÖvre);
            this.Controls.Add(this.btnExportera);
            this.Controls.Add(this.btnLåsBudget);
            this.Controls.Add(this.ucMeny);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKostnadsbudgetering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kostnadsbudgetering  | G4 Solutions Economy System";
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
        private Forms.ucMeny ucMeny;
        private System.Windows.Forms.DataGridView dgvNedre;
        private System.Windows.Forms.Button buttonVäljAvdelning;
        private System.Windows.Forms.ComboBox cbProdukt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblprodukt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAndel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLäggTill;
        private System.Windows.Forms.Button btnTaBort;
    }
}