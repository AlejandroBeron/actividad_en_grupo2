namespace tp2_grupal
{
    partial class frm_agruparpormarca
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
            this.dgv_agruparmarca = new System.Windows.Forms.DataGridView();
            this.cb_marcas = new System.Windows.Forms.ComboBox();
            this.b_lmarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agruparmarca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_agruparmarca
            // 
            this.dgv_agruparmarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_agruparmarca.Location = new System.Drawing.Point(34, 152);
            this.dgv_agruparmarca.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_agruparmarca.Name = "dgv_agruparmarca";
            this.dgv_agruparmarca.RowHeadersWidth = 72;
            this.dgv_agruparmarca.Size = new System.Drawing.Size(1113, 359);
            this.dgv_agruparmarca.TabIndex = 0;
            this.dgv_agruparmarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_agruparmarca_CellContentClick);
            // 
            // cb_marcas
            // 
            this.cb_marcas.FormattingEnabled = true;
            this.cb_marcas.Location = new System.Drawing.Point(224, 54);
            this.cb_marcas.Name = "cb_marcas";
            this.cb_marcas.Size = new System.Drawing.Size(303, 32);
            this.cb_marcas.TabIndex = 1;
            // 
            // b_lmarca
            // 
            this.b_lmarca.Location = new System.Drawing.Point(693, 38);
            this.b_lmarca.Name = "b_lmarca";
            this.b_lmarca.Size = new System.Drawing.Size(185, 48);
            this.b_lmarca.TabIndex = 2;
            this.b_lmarca.Text = "Por Marca";
            this.b_lmarca.UseVisualStyleBackColor = true;
            this.b_lmarca.Click += new System.EventHandler(this.b_lmarca_Click);
            // 
            // frm_agruparpormarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.b_lmarca);
            this.Controls.Add(this.cb_marcas);
            this.Controls.Add(this.dgv_agruparmarca);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_agruparpormarca";
            this.Text = "frm_agruparpormarca";
            this.Load += new System.EventHandler(this.frm_agruparpormarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agruparmarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_agruparmarca;
        private System.Windows.Forms.ComboBox cb_marcas;
        private System.Windows.Forms.Button b_lmarca;
    }
}