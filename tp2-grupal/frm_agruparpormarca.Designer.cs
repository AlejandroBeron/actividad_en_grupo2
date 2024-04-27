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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agruparmarca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_agruparmarca
            // 
            this.dgv_agruparmarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_agruparmarca.Location = new System.Drawing.Point(97, 60);
            this.dgv_agruparmarca.Name = "dgv_agruparmarca";
            this.dgv_agruparmarca.Size = new System.Drawing.Size(485, 236);
            this.dgv_agruparmarca.TabIndex = 0;
            this.dgv_agruparmarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_agruparmarca_CellContentClick);
            // 
            // frm_agruparpormarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_agruparmarca);
            this.Name = "frm_agruparpormarca";
            this.Text = "frm_agruparpormarca";
            this.Load += new System.EventHandler(this.frm_agruparpormarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agruparmarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_agruparmarca;
    }
}