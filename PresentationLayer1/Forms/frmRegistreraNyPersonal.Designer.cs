﻿namespace PresentationLayer1.Forms
{
    partial class frmRegistreraNyPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistreraNyPersonal));
            this.lblVakansavdrag = new System.Windows.Forms.Label();
            this.tbVakansavdrag = new System.Windows.Forms.TextBox();
            this.lblSysselsättningsgrad = new System.Windows.Forms.Label();
            this.tbSysselsättningsgrad = new System.Windows.Forms.TextBox();
            this.lblMånadslön = new System.Windows.Forms.Label();
            this.tbMånadslön = new System.Windows.Forms.TextBox();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSpara = new System.Windows.Forms.Button();
            this.lblPersonnummer = new System.Windows.Forms.Label();
            this.lblNamn = new System.Windows.Forms.Label();
            this.lblRegistreraNyPersonal = new System.Windows.Forms.Label();
            this.tbNamn = new System.Windows.Forms.TextBox();
            this.tbPersonnummer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLösenord = new System.Windows.Forms.TextBox();
            this.cbRoll = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPlacering = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblÖverbelaggd = new System.Windows.Forms.Label();
            this.tbÅrsarbetare = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacering)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVakansavdrag
            // 
            this.lblVakansavdrag.AutoSize = true;
            this.lblVakansavdrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVakansavdrag.Location = new System.Drawing.Point(12, 291);
            this.lblVakansavdrag.Name = "lblVakansavdrag";
            this.lblVakansavdrag.Size = new System.Drawing.Size(154, 16);
            this.lblVakansavdrag.TabIndex = 72;
            this.lblVakansavdrag.Text = "Vakansavdrag (0 till 100)";
            // 
            // tbVakansavdrag
            // 
            this.tbVakansavdrag.Location = new System.Drawing.Point(15, 310);
            this.tbVakansavdrag.Name = "tbVakansavdrag";
            this.tbVakansavdrag.Size = new System.Drawing.Size(239, 20);
            this.tbVakansavdrag.TabIndex = 71;
            this.tbVakansavdrag.TextChanged += new System.EventHandler(this.tbVakansavdrag_TextChanged);
            this.tbVakansavdrag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVakansavdrag_KeyPress);
            // 
            // lblSysselsättningsgrad
            // 
            this.lblSysselsättningsgrad.AutoSize = true;
            this.lblSysselsättningsgrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysselsättningsgrad.Location = new System.Drawing.Point(12, 238);
            this.lblSysselsättningsgrad.Name = "lblSysselsättningsgrad";
            this.lblSysselsättningsgrad.Size = new System.Drawing.Size(187, 16);
            this.lblSysselsättningsgrad.TabIndex = 70;
            this.lblSysselsättningsgrad.Text = "Sysselsättningsgrad (0 till 100)";
            // 
            // tbSysselsättningsgrad
            // 
            this.tbSysselsättningsgrad.Location = new System.Drawing.Point(15, 257);
            this.tbSysselsättningsgrad.Name = "tbSysselsättningsgrad";
            this.tbSysselsättningsgrad.Size = new System.Drawing.Size(239, 20);
            this.tbSysselsättningsgrad.TabIndex = 69;
            this.tbSysselsättningsgrad.TextChanged += new System.EventHandler(this.tbSysselsättningsgrad_TextChanged);
            this.tbSysselsättningsgrad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSysselsättningsgrad_KeyPress);
            // 
            // lblMånadslön
            // 
            this.lblMånadslön.AutoSize = true;
            this.lblMånadslön.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMånadslön.Location = new System.Drawing.Point(12, 185);
            this.lblMånadslön.Name = "lblMånadslön";
            this.lblMånadslön.Size = new System.Drawing.Size(75, 16);
            this.lblMånadslön.TabIndex = 68;
            this.lblMånadslön.Text = "Månadslön";
            // 
            // tbMånadslön
            // 
            this.tbMånadslön.Location = new System.Drawing.Point(15, 204);
            this.tbMånadslön.Name = "tbMånadslön";
            this.tbMånadslön.Size = new System.Drawing.Size(239, 20);
            this.tbMånadslön.TabIndex = 67;
            this.tbMånadslön.TextChanged += new System.EventHandler(this.tbMånadslön_TextChanged);
            this.tbMånadslön.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMånadslön_KeyPress);
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.BackColor = System.Drawing.Color.White;
            this.btnAvbryt.Location = new System.Drawing.Point(15, 475);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(61, 58);
            this.btnAvbryt.TabIndex = 65;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = false;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(-5, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(800, 3);
            this.label6.TabIndex = 64;
            // 
            // btnSpara
            // 
            this.btnSpara.BackColor = System.Drawing.Color.Yellow;
            this.btnSpara.Location = new System.Drawing.Point(136, 475);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(123, 58);
            this.btnSpara.TabIndex = 63;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = false;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // lblPersonnummer
            // 
            this.lblPersonnummer.AutoSize = true;
            this.lblPersonnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonnummer.Location = new System.Drawing.Point(12, 130);
            this.lblPersonnummer.Name = "lblPersonnummer";
            this.lblPersonnummer.Size = new System.Drawing.Size(99, 16);
            this.lblPersonnummer.TabIndex = 62;
            this.lblPersonnummer.Text = "Personnummer";
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamn.Location = new System.Drawing.Point(12, 76);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(44, 16);
            this.lblNamn.TabIndex = 61;
            this.lblNamn.Text = "Namn";
            // 
            // lblRegistreraNyPersonal
            // 
            this.lblRegistreraNyPersonal.AutoSize = true;
            this.lblRegistreraNyPersonal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistreraNyPersonal.Location = new System.Drawing.Point(11, 23);
            this.lblRegistreraNyPersonal.Name = "lblRegistreraNyPersonal";
            this.lblRegistreraNyPersonal.Size = new System.Drawing.Size(200, 22);
            this.lblRegistreraNyPersonal.TabIndex = 60;
            this.lblRegistreraNyPersonal.Text = "Registrera ny personal";
            // 
            // tbNamn
            // 
            this.tbNamn.Location = new System.Drawing.Point(15, 95);
            this.tbNamn.Name = "tbNamn";
            this.tbNamn.Size = new System.Drawing.Size(239, 20);
            this.tbNamn.TabIndex = 59;
            // 
            // tbPersonnummer
            // 
            this.tbPersonnummer.Location = new System.Drawing.Point(15, 149);
            this.tbPersonnummer.Name = "tbPersonnummer";
            this.tbPersonnummer.Size = new System.Drawing.Size(239, 20);
            this.tbPersonnummer.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Lösenord";
            // 
            // tbLösenord
            // 
            this.tbLösenord.Location = new System.Drawing.Point(15, 366);
            this.tbLösenord.Name = "tbLösenord";
            this.tbLösenord.Size = new System.Drawing.Size(239, 20);
            this.tbLösenord.TabIndex = 73;
            this.tbLösenord.TextChanged += new System.EventHandler(this.tbLösenord_TextChanged);
            // 
            // cbRoll
            // 
            this.cbRoll.FormattingEnabled = true;
            this.cbRoll.Items.AddRange(new object[] {
            "Ekonomichef",
            "Systemansvarig",
            "Försäljning- och marknadsavdelningschef",
            "Driftavdelningschef",
            "Utvecklingsavdelningsschef",
            "Kundavdelningschef",
            "Personalchef",
            "Administrativaavdelningschef",
            "Basanvändare"});
            this.cbRoll.Location = new System.Drawing.Point(337, 95);
            this.cbRoll.Name = "cbRoll";
            this.cbRoll.Size = new System.Drawing.Size(239, 21);
            this.cbRoll.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 76;
            this.label2.Text = "Roll";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 78;
            this.label3.Text = "Årsarbetare resultat";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvPlacering
            // 
            this.dgvPlacering.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlacering.Location = new System.Drawing.Point(337, 233);
            this.dgvPlacering.Name = "dgvPlacering";
            this.dgvPlacering.RowHeadersWidth = 51;
            this.dgvPlacering.Size = new System.Drawing.Size(240, 150);
            this.dgvPlacering.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 80;
            this.label4.Text = "Avdelning";
            // 
            // lblÖverbelaggd
            // 
            this.lblÖverbelaggd.AutoSize = true;
            this.lblÖverbelaggd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblÖverbelaggd.ForeColor = System.Drawing.Color.Red;
            this.lblÖverbelaggd.Location = new System.Drawing.Point(594, 292);
            this.lblÖverbelaggd.Name = "lblÖverbelaggd";
            this.lblÖverbelaggd.Size = new System.Drawing.Size(178, 18);
            this.lblÖverbelaggd.TabIndex = 81;
            this.lblÖverbelaggd.Text = "Placering överbelaggd!";
            // 
            // tbÅrsarbetare
            // 
            this.tbÅrsarbetare.Location = new System.Drawing.Point(337, 149);
            this.tbÅrsarbetare.Name = "tbÅrsarbetare";
            this.tbÅrsarbetare.ReadOnly = true;
            this.tbÅrsarbetare.Size = new System.Drawing.Size(48, 20);
            this.tbÅrsarbetare.TabIndex = 77;
            // 
            // frmRegistreraNyPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(767, 543);
            this.Controls.Add(this.tbÅrsarbetare);
            this.Controls.Add(this.lblÖverbelaggd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPlacering);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRoll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLösenord);
            this.Controls.Add(this.lblVakansavdrag);
            this.Controls.Add(this.tbVakansavdrag);
            this.Controls.Add(this.lblSysselsättningsgrad);
            this.Controls.Add(this.tbSysselsättningsgrad);
            this.Controls.Add(this.lblMånadslön);
            this.Controls.Add(this.tbMånadslön);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.lblPersonnummer);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.lblRegistreraNyPersonal);
            this.Controls.Add(this.tbNamn);
            this.Controls.Add(this.tbPersonnummer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistreraNyPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrera Ny Personal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacering)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVakansavdrag;
        private System.Windows.Forms.TextBox tbVakansavdrag;
        private System.Windows.Forms.Label lblSysselsättningsgrad;
        private System.Windows.Forms.TextBox tbSysselsättningsgrad;
        private System.Windows.Forms.Label lblMånadslön;
        private System.Windows.Forms.TextBox tbMånadslön;
        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Label lblPersonnummer;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label lblRegistreraNyPersonal;
        private System.Windows.Forms.TextBox tbNamn;
        private System.Windows.Forms.TextBox tbPersonnummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLösenord;
        private System.Windows.Forms.ComboBox cbRoll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPlacering;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblÖverbelaggd;
        private System.Windows.Forms.TextBox tbÅrsarbetare;
    }
}