﻿namespace PresentationLayer1.Forms
{
    partial class frmRegistreraNyProdukt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistreraNyProdukt));
            this.newProduktNametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAddProdukt = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegistreraNyProduktKategori = new System.Windows.Forms.Button();
            this.btnRegistreraNyProduktgrupp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDelProduktID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // newProduktNametxt
            // 
            this.newProduktNametxt.Location = new System.Drawing.Point(16, 93);
            this.newProduktNametxt.Name = "newProduktNametxt";
            this.newProduktNametxt.Size = new System.Drawing.Size(239, 20);
            this.newProduktNametxt.TabIndex = 0;
            this.newProduktNametxt.TextChanged += new System.EventHandler(this.newProduktNametxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrera ny Produkt";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Produktnamn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Produktkategori";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kundspecifik",
            "Generell"});
            this.comboBox1.Location = new System.Drawing.Point(16, 229);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // btnAddProdukt
            // 
            this.btnAddProdukt.BackColor = System.Drawing.Color.Yellow;
            this.btnAddProdukt.Location = new System.Drawing.Point(273, 501);
            this.btnAddProdukt.Name = "btnAddProdukt";
            this.btnAddProdukt.Size = new System.Drawing.Size(123, 58);
            this.btnAddProdukt.TabIndex = 8;
            this.btnAddProdukt.Text = "Skapa Produkt";
            this.btnAddProdukt.UseVisualStyleBackColor = false;
            this.btnAddProdukt.Click += new System.EventHandler(this.btnAddProdukt_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ASP",
            "Domino",
            "IT-säkerhet"});
            this.comboBox2.Location = new System.Drawing.Point(16, 285);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(239, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Produktgrupp";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(-4, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 3);
            this.label6.TabIndex = 11;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(16, 343);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(239, 21);
            this.comboBox3.TabIndex = 12;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Produktionsavdelning";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 58);
            this.button1.TabIndex = 14;
            this.button1.Text = "Avbryt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistreraNyProduktKategori
            // 
            this.btnRegistreraNyProduktKategori.Location = new System.Drawing.Point(273, 224);
            this.btnRegistreraNyProduktKategori.Name = "btnRegistreraNyProduktKategori";
            this.btnRegistreraNyProduktKategori.Size = new System.Drawing.Size(161, 26);
            this.btnRegistreraNyProduktKategori.TabIndex = 15;
            this.btnRegistreraNyProduktKategori.Text = "Registrera ny Produktkategori";
            this.btnRegistreraNyProduktKategori.UseVisualStyleBackColor = true;
            this.btnRegistreraNyProduktKategori.Click += new System.EventHandler(this.btnRegistreraNyProduktKategori_Click);
            // 
            // btnRegistreraNyProduktgrupp
            // 
            this.btnRegistreraNyProduktgrupp.Location = new System.Drawing.Point(273, 278);
            this.btnRegistreraNyProduktgrupp.Name = "btnRegistreraNyProduktgrupp";
            this.btnRegistreraNyProduktgrupp.Size = new System.Drawing.Size(161, 26);
            this.btnRegistreraNyProduktgrupp.TabIndex = 16;
            this.btnRegistreraNyProduktgrupp.Text = "Registrera ny Produktgrupp";
            this.btnRegistreraNyProduktgrupp.UseVisualStyleBackColor = true;
            this.btnRegistreraNyProduktgrupp.Click += new System.EventHandler(this.btnRegistreraNyProduktGrupp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "DelproduktID";
            // 
            // tbDelProduktID
            // 
            this.tbDelProduktID.Location = new System.Drawing.Point(16, 147);
            this.tbDelProduktID.Name = "tbDelProduktID";
            this.tbDelProduktID.Size = new System.Drawing.Size(239, 20);
            this.tbDelProduktID.TabIndex = 17;
            // 
            // frmRegistreraNyProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(444, 582);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDelProduktID);
            this.Controls.Add(this.btnRegistreraNyProduktgrupp);
            this.Controls.Add(this.btnRegistreraNyProduktKategori);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnAddProdukt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newProduktNametxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistreraNyProdukt";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrera ny produkt";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAddNewProdukt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newProduktNametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAddProdukt;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegistreraNyProduktKategori;
        private System.Windows.Forms.Button btnRegistreraNyProduktgrupp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDelProduktID;
    }
}