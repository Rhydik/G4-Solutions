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
            this.btnExportera = new System.Windows.Forms.Button();
            this.cmbMånad = new System.Windows.Forms.ComboBox();
            this.lblMånad = new System.Windows.Forms.Label();
            this.dgvPrognostiseringIntäkter = new System.Windows.Forms.DataGridView();
            this.btnLås = new System.Windows.Forms.Button();
            this.ucMeny = new PresentationLayer1.Forms.ucMeny();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrognostiseringIntäkter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportera
            // 
            this.btnExportera.Location = new System.Drawing.Point(246, 393);
            this.btnExportera.Name = "btnExportera";
            this.btnExportera.Size = new System.Drawing.Size(120, 41);
            this.btnExportera.TabIndex = 92;
            this.btnExportera.Text = "Exportera";
            this.btnExportera.UseVisualStyleBackColor = true;
            // 
            // cmbMånad
            // 
            this.cmbMånad.FormattingEnabled = true;
            this.cmbMånad.Location = new System.Drawing.Point(245, 43);
            this.cmbMånad.Name = "cmbMånad";
            this.cmbMånad.Size = new System.Drawing.Size(121, 21);
            this.cmbMånad.TabIndex = 91;
            this.cmbMånad.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // lblMånad
            // 
            this.lblMånad.AutoSize = true;
            this.lblMånad.Location = new System.Drawing.Point(243, 27);
            this.lblMånad.Name = "lblMånad";
            this.lblMånad.Size = new System.Drawing.Size(40, 13);
            this.lblMånad.TabIndex = 89;
            this.lblMånad.Text = "Månad";
            this.lblMånad.Click += new System.EventHandler(this.lblKategori_Click);
            // 
            // dgvPrognostiseringIntäkter
            // 
            this.dgvPrognostiseringIntäkter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrognostiseringIntäkter.Location = new System.Drawing.Point(247, 94);
            this.dgvPrognostiseringIntäkter.Name = "dgvPrognostiseringIntäkter";
            this.dgvPrognostiseringIntäkter.ReadOnly = true;
            this.dgvPrognostiseringIntäkter.RowHeadersWidth = 62;
            this.dgvPrognostiseringIntäkter.Size = new System.Drawing.Size(524, 284);
            this.dgvPrognostiseringIntäkter.TabIndex = 85;
            this.dgvPrognostiseringIntäkter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrognostiseringIntäkter_CellContentClick);
            // 
            // btnLås
            // 
            this.btnLås.Location = new System.Drawing.Point(651, 384);
            this.btnLås.Name = "btnLås";
            this.btnLås.Size = new System.Drawing.Size(120, 41);
            this.btnLås.TabIndex = 93;
            this.btnLås.Text = "Lås";
            this.btnLås.UseVisualStyleBackColor = true;
            //
            // ucMeny
            //
            this.ucMeny.Location = new System.Drawing.Point(8, 8);
            this.ucMeny.Name = "ucMeny";
            this.ucMeny.Size = new System.Drawing.Size(194, 438);
            this.ucMeny.TabIndex = 5;
            // 
            // frmPrognostiseringIntäkter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLås);
            this.Controls.Add(this.btnExportera);
            this.Controls.Add(this.cmbMånad);
            this.Controls.Add(this.lblMånad);
            this.Controls.Add(this.dgvPrognostiseringIntäkter);
            this.Controls.Add(this.ucMeny);
            this.Name = "frmPrognostiseringIntäkter";
            this.Text = "frmPrognostiseringIntäkter";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrognostiseringIntäkter)).EndInit();
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
    }
}