namespace PresentationLayer1.Forms
{
    partial class frmProdukter
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRegistreraNyProdukt = new System.Windows.Forms.Button();
            this.btnRedigeraProdukt = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResultat = new System.Windows.Forms.Button();
            this.btnPrognostiseringIntäkter = new System.Windows.Forms.Button();
            this.btnBudgeteratResultat = new System.Windows.Forms.Button();
            this.btnKostnadsbudgetering = new System.Windows.Forms.Button();
            this.btnIntäktsbudgeteringProdukt = new System.Windows.Forms.Button();
            this.btnIntäktsbudgeteringKund = new System.Windows.Forms.Button();
            this.btnBehörighet = new System.Windows.Forms.Button();
            this.btnSchablonkostnad = new System.Windows.Forms.Button();
            this.btnAktiviteter = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnProdukter = new System.Windows.Forms.Button();
            this.btnKunder = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Avdelning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Produkt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "ProduktID";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(313, 82);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 23);
            this.button6.TabIndex = 29;
            this.button6.Text = "Rensa";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(246, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 23);
            this.button5.TabIndex = 28;
            this.button5.Text = "Sök";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(555, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.Text = "Välj avdelning";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(345, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 20);
            this.textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 20);
            this.textBox1.TabIndex = 25;
            // 
            // btnRegistreraNyProdukt
            // 
            this.btnRegistreraNyProdukt.Location = new System.Drawing.Point(635, 362);
            this.btnRegistreraNyProdukt.Name = "btnRegistreraNyProdukt";
            this.btnRegistreraNyProdukt.Size = new System.Drawing.Size(112, 40);
            this.btnRegistreraNyProdukt.TabIndex = 24;
            this.btnRegistreraNyProdukt.Text = "Registrera ny produkt";
            this.btnRegistreraNyProdukt.UseVisualStyleBackColor = true;
            this.btnRegistreraNyProdukt.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRedigeraProdukt
            // 
            this.btnRedigeraProdukt.Location = new System.Drawing.Point(509, 361);
            this.btnRedigeraProdukt.Name = "btnRedigeraProdukt";
            this.btnRedigeraProdukt.Size = new System.Drawing.Size(120, 41);
            this.btnRedigeraProdukt.TabIndex = 23;
            this.btnRedigeraProdukt.Text = "Redigera produkt";
            this.btnRedigeraProdukt.UseVisualStyleBackColor = true;
            this.btnRedigeraProdukt.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(246, 118);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(501, 237);
            this.dataGridView2.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResultat);
            this.panel1.Controls.Add(this.btnPrognostiseringIntäkter);
            this.panel1.Controls.Add(this.btnBudgeteratResultat);
            this.panel1.Controls.Add(this.btnKostnadsbudgetering);
            this.panel1.Controls.Add(this.btnIntäktsbudgeteringProdukt);
            this.panel1.Controls.Add(this.btnIntäktsbudgeteringKund);
            this.panel1.Controls.Add(this.btnBehörighet);
            this.panel1.Controls.Add(this.btnSchablonkostnad);
            this.panel1.Controls.Add(this.btnAktiviteter);
            this.panel1.Controls.Add(this.btnPersonal);
            this.panel1.Controls.Add(this.btnProdukter);
            this.panel1.Controls.Add(this.btnKunder);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 432);
            this.panel1.TabIndex = 33;
            // 
            // btnResultat
            // 
            this.btnResultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultat.Location = new System.Drawing.Point(15, 381);
            this.btnResultat.Name = "btnResultat";
            this.btnResultat.Size = new System.Drawing.Size(75, 23);
            this.btnResultat.TabIndex = 2;
            this.btnResultat.Text = "Resultat";
            this.btnResultat.UseVisualStyleBackColor = true;
            // 
            // btnPrognostiseringIntäkter
            // 
            this.btnPrognostiseringIntäkter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrognostiseringIntäkter.Location = new System.Drawing.Point(15, 352);
            this.btnPrognostiseringIntäkter.Name = "btnPrognostiseringIntäkter";
            this.btnPrognostiseringIntäkter.Size = new System.Drawing.Size(141, 23);
            this.btnPrognostiseringIntäkter.TabIndex = 2;
            this.btnPrognostiseringIntäkter.Text = "Prognostisering intäkter";
            this.btnPrognostiseringIntäkter.UseVisualStyleBackColor = true;
            // 
            // btnBudgeteratResultat
            // 
            this.btnBudgeteratResultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBudgeteratResultat.Location = new System.Drawing.Point(15, 322);
            this.btnBudgeteratResultat.Name = "btnBudgeteratResultat";
            this.btnBudgeteratResultat.Size = new System.Drawing.Size(123, 23);
            this.btnBudgeteratResultat.TabIndex = 2;
            this.btnBudgeteratResultat.Text = "Budgeterat Resultat";
            this.btnBudgeteratResultat.UseVisualStyleBackColor = true;
            // 
            // btnKostnadsbudgetering
            // 
            this.btnKostnadsbudgetering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKostnadsbudgetering.Location = new System.Drawing.Point(15, 274);
            this.btnKostnadsbudgetering.Name = "btnKostnadsbudgetering";
            this.btnKostnadsbudgetering.Size = new System.Drawing.Size(158, 23);
            this.btnKostnadsbudgetering.TabIndex = 2;
            this.btnKostnadsbudgetering.Text = "Kostnadsbudgetering";
            this.btnKostnadsbudgetering.UseVisualStyleBackColor = true;
            // 
            // btnIntäktsbudgeteringProdukt
            // 
            this.btnIntäktsbudgeteringProdukt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntäktsbudgeteringProdukt.Location = new System.Drawing.Point(15, 245);
            this.btnIntäktsbudgeteringProdukt.Name = "btnIntäktsbudgeteringProdukt";
            this.btnIntäktsbudgeteringProdukt.Size = new System.Drawing.Size(158, 23);
            this.btnIntäktsbudgeteringProdukt.TabIndex = 2;
            this.btnIntäktsbudgeteringProdukt.Text = "Intäktsbudgetering Produkt";
            this.btnIntäktsbudgeteringProdukt.UseVisualStyleBackColor = true;
            // 
            // btnIntäktsbudgeteringKund
            // 
            this.btnIntäktsbudgeteringKund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntäktsbudgeteringKund.Location = new System.Drawing.Point(15, 216);
            this.btnIntäktsbudgeteringKund.Name = "btnIntäktsbudgeteringKund";
            this.btnIntäktsbudgeteringKund.Size = new System.Drawing.Size(158, 23);
            this.btnIntäktsbudgeteringKund.TabIndex = 3;
            this.btnIntäktsbudgeteringKund.Text = "Intäktsbudgetering Kund";
            this.btnIntäktsbudgeteringKund.UseVisualStyleBackColor = true;
            // 
            // btnBehörighet
            // 
            this.btnBehörighet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBehörighet.Location = new System.Drawing.Point(15, 169);
            this.btnBehörighet.Name = "btnBehörighet";
            this.btnBehörighet.Size = new System.Drawing.Size(107, 23);
            this.btnBehörighet.TabIndex = 2;
            this.btnBehörighet.Text = "Behörighet";
            this.btnBehörighet.UseVisualStyleBackColor = true;
            // 
            // btnSchablonkostnad
            // 
            this.btnSchablonkostnad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchablonkostnad.Location = new System.Drawing.Point(15, 140);
            this.btnSchablonkostnad.Name = "btnSchablonkostnad";
            this.btnSchablonkostnad.Size = new System.Drawing.Size(107, 23);
            this.btnSchablonkostnad.TabIndex = 2;
            this.btnSchablonkostnad.Text = "Schablonkostnad";
            this.btnSchablonkostnad.UseVisualStyleBackColor = true;
            // 
            // btnAktiviteter
            // 
            this.btnAktiviteter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktiviteter.Location = new System.Drawing.Point(15, 110);
            this.btnAktiviteter.Name = "btnAktiviteter";
            this.btnAktiviteter.Size = new System.Drawing.Size(107, 23);
            this.btnAktiviteter.TabIndex = 2;
            this.btnAktiviteter.Text = "Aktiviteter";
            this.btnAktiviteter.UseVisualStyleBackColor = true;
            // 
            // btnPersonal
            // 
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.Location = new System.Drawing.Point(15, 82);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(107, 23);
            this.btnPersonal.TabIndex = 2;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.UseVisualStyleBackColor = true;
            // 
            // btnProdukter
            // 
            this.btnProdukter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdukter.Location = new System.Drawing.Point(15, 53);
            this.btnProdukter.Name = "btnProdukter";
            this.btnProdukter.Size = new System.Drawing.Size(107, 23);
            this.btnProdukter.TabIndex = 2;
            this.btnProdukter.Text = "Produkter";
            this.btnProdukter.UseVisualStyleBackColor = true;
            this.btnProdukter.Click += new System.EventHandler(this.btnProdukter_Click);
            // 
            // btnKunder
            // 
            this.btnKunder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKunder.Location = new System.Drawing.Point(15, 23);
            this.btnKunder.Name = "btnKunder";
            this.btnKunder.Size = new System.Drawing.Size(107, 23);
            this.btnKunder.TabIndex = 2;
            this.btnKunder.Text = "Kunder";
            this.btnKunder.UseVisualStyleBackColor = true;
            this.btnKunder.Click += new System.EventHandler(this.btnKunder_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(445, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(94, 20);
            this.textBox3.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Produktgrupp";
            // 
            // frmProdukter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRegistreraNyProdukt);
            this.Controls.Add(this.btnRedigeraProdukt);
            this.Controls.Add(this.dataGridView2);
            this.Name = "frmProdukter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProdukter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRegistreraNyProdukt;
        private System.Windows.Forms.Button btnRedigeraProdukt;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResultat;
        private System.Windows.Forms.Button btnPrognostiseringIntäkter;
        private System.Windows.Forms.Button btnBudgeteratResultat;
        private System.Windows.Forms.Button btnKostnadsbudgetering;
        private System.Windows.Forms.Button btnIntäktsbudgeteringProdukt;
        private System.Windows.Forms.Button btnIntäktsbudgeteringKund;
        private System.Windows.Forms.Button btnBehörighet;
        private System.Windows.Forms.Button btnSchablonkostnad;
        private System.Windows.Forms.Button btnAktiviteter;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnProdukter;
        private System.Windows.Forms.Button btnKunder;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
    }
}