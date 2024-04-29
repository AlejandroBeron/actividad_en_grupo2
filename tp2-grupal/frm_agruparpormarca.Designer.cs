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
            this.cb_categorias = new System.Windows.Forms.ComboBox();
            this.b_lcate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agruparmarca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_agruparmarca
            // 
            this.dgv_agruparmarca.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_agruparmarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_agruparmarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_agruparmarca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_agruparmarca.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgv_agruparmarca.Location = new System.Drawing.Point(30, 118);
            this.dgv_agruparmarca.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_agruparmarca.Name = "dgv_agruparmarca";
            this.dgv_agruparmarca.RowHeadersWidth = 72;
            this.dgv_agruparmarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_agruparmarca.Size = new System.Drawing.Size(681, 118);
            this.dgv_agruparmarca.TabIndex = 0;
            this.dgv_agruparmarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_agruparmarca_CellContentClick);
            // 
            // cb_marcas
            // 
            this.cb_marcas.FormattingEnabled = true;
            this.cb_marcas.Location = new System.Drawing.Point(67, 85);
            this.cb_marcas.Name = "cb_marcas";
            this.cb_marcas.Size = new System.Drawing.Size(248, 26);
            this.cb_marcas.TabIndex = 1;
            // 
            // b_lmarca
            // 
            this.b_lmarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.b_lmarca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_lmarca.FlatAppearance.BorderSize = 5;
            this.b_lmarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.b_lmarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_lmarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_lmarca.Location = new System.Drawing.Point(109, 24);
            this.b_lmarca.Name = "b_lmarca";
            this.b_lmarca.Size = new System.Drawing.Size(152, 40);
            this.b_lmarca.TabIndex = 2;
            this.b_lmarca.Text = "Por Marca";
            this.b_lmarca.UseVisualStyleBackColor = false;
            this.b_lmarca.Click += new System.EventHandler(this.b_lmarca_Click);
            // 
            // cb_categorias
            // 
            this.cb_categorias.FormattingEnabled = true;
            this.cb_categorias.Location = new System.Drawing.Point(422, 85);
            this.cb_categorias.Name = "cb_categorias";
            this.cb_categorias.Size = new System.Drawing.Size(248, 26);
            this.cb_categorias.TabIndex = 3;
            this.cb_categorias.SelectedIndexChanged += new System.EventHandler(this.cb_categorias_SelectedIndexChanged);
            // 
            // b_lcate
            // 
            this.b_lcate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.b_lcate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_lcate.FlatAppearance.BorderSize = 5;
            this.b_lcate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.b_lcate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_lcate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_lcate.Location = new System.Drawing.Point(470, 24);
            this.b_lcate.Name = "b_lcate";
            this.b_lcate.Size = new System.Drawing.Size(152, 40);
            this.b_lcate.TabIndex = 4;
            this.b_lcate.Text = "Por categoria";
            this.b_lcate.UseVisualStyleBackColor = false;
            this.b_lcate.Click += new System.EventHandler(this.b_lcate_Click);
            // 
            // frm_agruparpormarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(737, 268);
            this.Controls.Add(this.b_lcate);
            this.Controls.Add(this.cb_categorias);
            this.Controls.Add(this.b_lmarca);
            this.Controls.Add(this.cb_marcas);
            this.Controls.Add(this.dgv_agruparmarca);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(753, 307);
            this.MinimumSize = new System.Drawing.Size(753, 307);
            this.Name = "frm_agruparpormarca";
            this.Text = "Agrupar por Marca o Categoria";
            this.Load += new System.EventHandler(this.frm_agruparpormarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agruparmarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_agruparmarca;
        private System.Windows.Forms.ComboBox cb_marcas;
        private System.Windows.Forms.Button b_lmarca;
        private System.Windows.Forms.ComboBox cb_categorias;
        private System.Windows.Forms.Button b_lcate;
    }
}