namespace PresentationLayer1.Forms
{
    partial class frmPrognostiseringIntäkter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrognostiseringIntäkter));
            this.btnExportera = new System.Windows.Forms.Button();
            this.cmbMånad = new System.Windows.Forms.ComboBox();
            this.lblMånad = new System.Windows.Forms.Label();
            this.dgvPrognostiseringIntäkter = new System.Windows.Forms.DataGridView();
            this.btnLås = new System.Windows.Forms.Button();
            this.lblSök = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ucMeny = new PresentationLayer1.Forms.ucMeny();
            this.shadowDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrognostiseringIntäkter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportera
            // 
            this.btnExportera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportera.Location = new System.Drawing.Point(208, 408);
            this.btnExportera.Name = "btnExportera";
            this.btnExportera.Size = new System.Drawing.Size(120, 41);
            this.btnExportera.TabIndex = 92;
            this.btnExportera.Text = "Exportera";
            this.btnExportera.UseVisualStyleBackColor = true;
            this.btnExportera.Click += new System.EventHandler(this.btnExportera_Click);
            // 
            // cmbMånad
            // 
            this.cmbMånad.FormattingEnabled = true;
            this.cmbMånad.Location = new System.Drawing.Point(208, 84);
            this.cmbMånad.Name = "cmbMånad";
            this.cmbMånad.Size = new System.Drawing.Size(121, 21);
            this.cmbMånad.TabIndex = 91;
            // 
            // lblMånad
            // 
            this.lblMånad.AutoSize = true;
            this.lblMånad.Location = new System.Drawing.Point(206, 68);
            this.lblMånad.Name = "lblMånad";
            this.lblMånad.Size = new System.Drawing.Size(40, 13);
            this.lblMånad.TabIndex = 89;
            this.lblMånad.Text = "Månad";
            // 
            // dgvPrognostiseringIntäkter
            // 
            this.dgvPrognostiseringIntäkter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrognostiseringIntäkter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrognostiseringIntäkter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrognostiseringIntäkter.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPrognostiseringIntäkter.Location = new System.Drawing.Point(208, 111);
            this.dgvPrognostiseringIntäkter.Name = "dgvPrognostiseringIntäkter";
            this.dgvPrognostiseringIntäkter.RowHeadersVisible = false;
            this.dgvPrognostiseringIntäkter.RowHeadersWidth = 62;
            this.dgvPrognostiseringIntäkter.Size = new System.Drawing.Size(615, 207);
            this.dgvPrognostiseringIntäkter.TabIndex = 85;
            // 
            // btnLås
            // 
            this.btnLås.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLås.Location = new System.Drawing.Point(447, 408);
            this.btnLås.Name = "btnLås";
            this.btnLås.Size = new System.Drawing.Size(120, 41);
            this.btnLås.TabIndex = 93;
            this.btnLås.Text = "Lås";
            this.btnLås.UseVisualStyleBackColor = true;
            this.btnLås.Click += new System.EventHandler(this.btnLås_Click);
            // 
            // lblSök
            // 
            this.lblSök.AutoSize = true;
            this.lblSök.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSök.Location = new System.Drawing.Point(205, 37);
            this.lblSök.Name = "lblSök";
            this.lblSök.Size = new System.Drawing.Size(45, 24);
            this.lblSök.TabIndex = 94;
            this.lblSök.Text = "Sök";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 41);
            this.button1.TabIndex = 95;
            this.button1.Text = "Räkna Ut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 96;
            this.button2.Text = "Visa månad";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(208, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(614, 60);
            this.dataGridView1.TabIndex = 97;
            // 
            // ucMeny
            // 
            this.ucMeny.Location = new System.Drawing.Point(8, 8);
            this.ucMeny.Margin = new System.Windows.Forms.Padding(4);
            this.ucMeny.Name = "ucMeny";
            this.ucMeny.Size = new System.Drawing.Size(194, 438);
            this.ucMeny.TabIndex = 5;
            this.ucMeny.Enter += new System.EventHandler(this.ucMeny_Enter);
            // 
            // shadowDataGridView
            // 
            this.shadowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shadowDataGridView.Location = new System.Drawing.Point(787, 12);
            this.shadowDataGridView.Name = "shadowDataGridView";
            this.shadowDataGridView.Size = new System.Drawing.Size(15, 13);
            this.shadowDataGridView.TabIndex = 98;
            this.shadowDataGridView.Visible = false;
            // 
            // frmPrognostiseringIntäkter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.shadowDataGridView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSök);
            this.Controls.Add(this.btnLås);
            this.Controls.Add(this.btnExportera);
            this.Controls.Add(this.cmbMånad);
            this.Controls.Add(this.lblMånad);
            this.Controls.Add(this.dgvPrognostiseringIntäkter);
            this.Controls.Add(this.ucMeny);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrognostiseringIntäkter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prognostisering intäkter | G4 Solutions Economy System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrognostiseringIntäkter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadowDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportera;
        private System.Windows.Forms.ComboBox cmbMånad;
        private System.Windows.Forms.Label lblMånad;
        private System.Windows.Forms.DataGridView dgvPrognostiseringIntäkter;
        private System.Windows.Forms.Button btnLås;
        private Forms.ucMeny ucMeny;
        private System.Windows.Forms.Label lblSök;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView shadowDataGridView;
    }
}