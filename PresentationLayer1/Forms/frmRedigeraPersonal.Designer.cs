namespace PresentationLayer1.Forms
{
    partial class frmRedigeraPersonal
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
            this.tbPersNr = new System.Windows.Forms.TextBox();
            this.tbNamn = new System.Windows.Forms.TextBox();
            this.lblMånadslön = new System.Windows.Forms.Label();
            this.lblPersonnummer = new System.Windows.Forms.Label();
            this.lblNamn = new System.Windows.Forms.Label();
            this.btnTaBortPersonal = new System.Windows.Forms.Button();
            this.btnAvbrytPersonal = new System.Windows.Forms.Button();
            this.btnSparaPersonal = new System.Windows.Forms.Button();
            this.tbMånadslön = new System.Windows.Forms.TextBox();
            this.tbSysselsättningsgrad = new System.Windows.Forms.TextBox();
            this.lblSysselsättningsgrad = new System.Windows.Forms.Label();
            this.tbVakansavdrag = new System.Windows.Forms.TextBox();
            this.lblVakansavdrag = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRedigeraPersonal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPersNr
            // 
            this.tbPersNr.Location = new System.Drawing.Point(10, 141);
            this.tbPersNr.Margin = new System.Windows.Forms.Padding(2);
            this.tbPersNr.Name = "tbPersNr";
            this.tbPersNr.Size = new System.Drawing.Size(239, 20);
            this.tbPersNr.TabIndex = 43;
            // 
            // tbNamn
            // 
            this.tbNamn.Location = new System.Drawing.Point(10, 95);
            this.tbNamn.Margin = new System.Windows.Forms.Padding(2);
            this.tbNamn.Name = "tbNamn";
            this.tbNamn.Size = new System.Drawing.Size(239, 20);
            this.tbNamn.TabIndex = 42;
            // 
            // lblMånadslön
            // 
            this.lblMånadslön.AutoSize = true;
            this.lblMånadslön.Location = new System.Drawing.Point(8, 170);
            this.lblMånadslön.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMånadslön.Name = "lblMånadslön";
            this.lblMånadslön.Size = new System.Drawing.Size(59, 13);
            this.lblMånadslön.TabIndex = 41;
            this.lblMånadslön.Text = "Månadslön";
            // 
            // lblPersonnummer
            // 
            this.lblPersonnummer.AutoSize = true;
            this.lblPersonnummer.Location = new System.Drawing.Point(8, 126);
            this.lblPersonnummer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonnummer.Name = "lblPersonnummer";
            this.lblPersonnummer.Size = new System.Drawing.Size(77, 13);
            this.lblPersonnummer.TabIndex = 40;
            this.lblPersonnummer.Text = "Personnummer";
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Location = new System.Drawing.Point(8, 80);
            this.lblNamn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(35, 13);
            this.lblNamn.TabIndex = 39;
            this.lblNamn.Text = "Namn";
            // 
            // btnTaBortPersonal
            // 
            this.btnTaBortPersonal.BackColor = System.Drawing.Color.DarkRed;
            this.btnTaBortPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaBortPersonal.Location = new System.Drawing.Point(10, 420);
            this.btnTaBortPersonal.Name = "btnTaBortPersonal";
            this.btnTaBortPersonal.Size = new System.Drawing.Size(239, 41);
            this.btnTaBortPersonal.TabIndex = 37;
            this.btnTaBortPersonal.Text = "Ta bort Personal";
            this.btnTaBortPersonal.UseVisualStyleBackColor = false;
            this.btnTaBortPersonal.Click += new System.EventHandler(this.btnTaBortPersonal_Click);
            // 
            // btnAvbrytPersonal
            // 
            this.btnAvbrytPersonal.Location = new System.Drawing.Point(12, 481);
            this.btnAvbrytPersonal.Name = "btnAvbrytPersonal";
            this.btnAvbrytPersonal.Size = new System.Drawing.Size(61, 58);
            this.btnAvbrytPersonal.TabIndex = 36;
            this.btnAvbrytPersonal.Text = "Avbryt";
            this.btnAvbrytPersonal.UseVisualStyleBackColor = true;
            this.btnAvbrytPersonal.Click += new System.EventHandler(this.btnAvbrytPersonal_Click);
            // 
            // btnSparaPersonal
            // 
            this.btnSparaPersonal.BackColor = System.Drawing.Color.Yellow;
            this.btnSparaPersonal.Location = new System.Drawing.Point(137, 481);
            this.btnSparaPersonal.Name = "btnSparaPersonal";
            this.btnSparaPersonal.Size = new System.Drawing.Size(123, 58);
            this.btnSparaPersonal.TabIndex = 35;
            this.btnSparaPersonal.Text = "Spara";
            this.btnSparaPersonal.UseVisualStyleBackColor = false;
            this.btnSparaPersonal.Click += new System.EventHandler(this.btnSparaPersonal_Click);
            // 
            // tbMånadslön
            // 
            this.tbMånadslön.Location = new System.Drawing.Point(10, 185);
            this.tbMånadslön.Margin = new System.Windows.Forms.Padding(2);
            this.tbMånadslön.Name = "tbMånadslön";
            this.tbMånadslön.Size = new System.Drawing.Size(239, 20);
            this.tbMånadslön.TabIndex = 44;
            // 
            // tbSysselsättningsgrad
            // 
            this.tbSysselsättningsgrad.Location = new System.Drawing.Point(10, 229);
            this.tbSysselsättningsgrad.Margin = new System.Windows.Forms.Padding(2);
            this.tbSysselsättningsgrad.Name = "tbSysselsättningsgrad";
            this.tbSysselsättningsgrad.Size = new System.Drawing.Size(239, 20);
            this.tbSysselsättningsgrad.TabIndex = 46;
            // 
            // lblSysselsättningsgrad
            // 
            this.lblSysselsättningsgrad.AutoSize = true;
            this.lblSysselsättningsgrad.Location = new System.Drawing.Point(8, 214);
            this.lblSysselsättningsgrad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSysselsättningsgrad.Name = "lblSysselsättningsgrad";
            this.lblSysselsättningsgrad.Size = new System.Drawing.Size(111, 13);
            this.lblSysselsättningsgrad.TabIndex = 45;
            this.lblSysselsättningsgrad.Text = "Sysselsättningsgrad %";
            // 
            // tbVakansavdrag
            // 
            this.tbVakansavdrag.Location = new System.Drawing.Point(11, 276);
            this.tbVakansavdrag.Margin = new System.Windows.Forms.Padding(2);
            this.tbVakansavdrag.Name = "tbVakansavdrag";
            this.tbVakansavdrag.Size = new System.Drawing.Size(239, 20);
            this.tbVakansavdrag.TabIndex = 48;
            // 
            // lblVakansavdrag
            // 
            this.lblVakansavdrag.AutoSize = true;
            this.lblVakansavdrag.Location = new System.Drawing.Point(9, 261);
            this.lblVakansavdrag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVakansavdrag.Name = "lblVakansavdrag";
            this.lblVakansavdrag.Size = new System.Drawing.Size(87, 13);
            this.lblVakansavdrag.TabIndex = 47;
            this.lblVakansavdrag.Text = "Vakansavdrag %";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(-68, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 3);
            this.label6.TabIndex = 65;
            // 
            // lblRedigeraPersonal
            // 
            this.lblRedigeraPersonal.AutoSize = true;
            this.lblRedigeraPersonal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedigeraPersonal.Location = new System.Drawing.Point(12, 28);
            this.lblRedigeraPersonal.Name = "lblRedigeraPersonal";
            this.lblRedigeraPersonal.Size = new System.Drawing.Size(168, 22);
            this.lblRedigeraPersonal.TabIndex = 66;
            this.lblRedigeraPersonal.Text = "Redigera Personal";
            // 
            // frmRedigeraPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(272, 543);
            this.Controls.Add(this.lblRedigeraPersonal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbVakansavdrag);
            this.Controls.Add(this.lblVakansavdrag);
            this.Controls.Add(this.tbSysselsättningsgrad);
            this.Controls.Add(this.lblSysselsättningsgrad);
            this.Controls.Add(this.tbMånadslön);
            this.Controls.Add(this.tbPersNr);
            this.Controls.Add(this.tbNamn);
            this.Controls.Add(this.lblMånadslön);
            this.Controls.Add(this.lblPersonnummer);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.btnTaBortPersonal);
            this.Controls.Add(this.btnAvbrytPersonal);
            this.Controls.Add(this.btnSparaPersonal);
            this.Name = "frmRedigeraPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRedigeraPersonal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPersNr;
        private System.Windows.Forms.TextBox tbNamn;
        private System.Windows.Forms.Label lblMånadslön;
        private System.Windows.Forms.Label lblPersonnummer;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Button btnTaBortPersonal;
        private System.Windows.Forms.Button btnAvbrytPersonal;
        private System.Windows.Forms.Button btnSparaPersonal;
        private System.Windows.Forms.TextBox tbMånadslön;
        private System.Windows.Forms.TextBox tbSysselsättningsgrad;
        private System.Windows.Forms.Label lblSysselsättningsgrad;
        private System.Windows.Forms.TextBox tbVakansavdrag;
        private System.Windows.Forms.Label lblVakansavdrag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRedigeraPersonal;
    }
}