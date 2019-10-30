namespace PresentationLayer1.Forms
{
    partial class frmRegistreraNyProduktGrupp
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
            this.tbNyProduktGrupp = new System.Windows.Forms.TextBox();
            this.lbNyProduktgrupp = new System.Windows.Forms.Label();
            this.btnSparaNyProduktGrupp = new System.Windows.Forms.Button();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNyProduktGrupp
            // 
            this.tbNyProduktGrupp.Location = new System.Drawing.Point(76, 58);
            this.tbNyProduktGrupp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNyProduktGrupp.Name = "tbNyProduktGrupp";
            this.tbNyProduktGrupp.Size = new System.Drawing.Size(242, 20);
            this.tbNyProduktGrupp.TabIndex = 0;
            this.tbNyProduktGrupp.TextChanged += new System.EventHandler(this.tbNyProduktGrupp_TextChanged);
            // 
            // lbNyProduktgrupp
            // 
            this.lbNyProduktgrupp.AutoSize = true;
            this.lbNyProduktgrupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNyProduktgrupp.Location = new System.Drawing.Point(20, 54);
            this.lbNyProduktgrupp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNyProduktgrupp.Name = "lbNyProduktgrupp";
            this.lbNyProduktgrupp.Size = new System.Drawing.Size(55, 20);
            this.lbNyProduktgrupp.TabIndex = 1;
            this.lbNyProduktgrupp.Text = "Namn:";
            // 
            // btnSparaNyProduktGrupp
            // 
            this.btnSparaNyProduktGrupp.Location = new System.Drawing.Point(233, 110);
            this.btnSparaNyProduktGrupp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSparaNyProduktGrupp.Name = "btnSparaNyProduktGrupp";
            this.btnSparaNyProduktGrupp.Size = new System.Drawing.Size(75, 29);
            this.btnSparaNyProduktGrupp.TabIndex = 2;
            this.btnSparaNyProduktGrupp.Text = "Spara";
            this.btnSparaNyProduktGrupp.UseVisualStyleBackColor = true;
            this.btnSparaNyProduktGrupp.Click += new System.EventHandler(this.btnSparaNyProduktGrupp_Click);
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(152, 110);
            this.btnAvbryt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(64, 29);
            this.btnAvbryt.TabIndex = 3;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // frmRegistreraNyProduktGrupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(339, 167);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.btnSparaNyProduktGrupp);
            this.Controls.Add(this.lbNyProduktgrupp);
            this.Controls.Add(this.tbNyProduktGrupp);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRegistreraNyProduktGrupp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrera ny Produktgrupp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNyProduktGrupp;
        private System.Windows.Forms.Label lbNyProduktgrupp;
        private System.Windows.Forms.Button btnSparaNyProduktGrupp;
        private System.Windows.Forms.Button btnAvbryt;
    }
}