namespace tp2_grupal
{
    partial class F_Listar_M
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
            this.l_listarmarca = new System.Windows.Forms.Label();
            this.btn_salir_listarmarcas = new System.Windows.Forms.Button();
            this.dgv_marcas = new System.Windows.Forms.DataGridView();
            this.btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marcas)).BeginInit();
            this.SuspendLayout();
            // 
            // l_listarmarca
            // 
            this.l_listarmarca.AutoSize = true;
            this.l_listarmarca.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_listarmarca.ForeColor = System.Drawing.Color.White;
            this.l_listarmarca.Location = new System.Drawing.Point(194, 28);
            this.l_listarmarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_listarmarca.Name = "l_listarmarca";
            this.l_listarmarca.Size = new System.Drawing.Size(83, 24);
            this.l_listarmarca.TabIndex = 1;
            this.l_listarmarca.Text = "Marcas";
            this.l_listarmarca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_listarmarca.Click += new System.EventHandler(this.l_listarmarca_Click);
            // 
            // btn_salir_listarmarcas
            // 
            this.btn_salir_listarmarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_salir_listarmarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir_listarmarcas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_salir_listarmarcas.FlatAppearance.BorderSize = 5;
            this.btn_salir_listarmarcas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_salir_listarmarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_salir_listarmarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir_listarmarcas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir_listarmarcas.Location = new System.Drawing.Point(77, 278);
            this.btn_salir_listarmarcas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_salir_listarmarcas.Name = "btn_salir_listarmarcas";
            this.btn_salir_listarmarcas.Size = new System.Drawing.Size(126, 43);
            this.btn_salir_listarmarcas.TabIndex = 2;
            this.btn_salir_listarmarcas.Text = "Salir";
            this.btn_salir_listarmarcas.UseVisualStyleBackColor = false;
            this.btn_salir_listarmarcas.Click += new System.EventHandler(this.btn_salir_listarmarcas_Click);
            // 
            // dgv_marcas
            // 
            this.dgv_marcas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_marcas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_marcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_marcas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgv_marcas.Location = new System.Drawing.Point(83, 80);
            this.dgv_marcas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_marcas.Name = "dgv_marcas";
            this.dgv_marcas.RowHeadersWidth = 72;
            this.dgv_marcas.Size = new System.Drawing.Size(318, 160);
            this.dgv_marcas.TabIndex = 3;
            this.dgv_marcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_marcas_CellContentClick);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_eliminar.FlatAppearance.BorderSize = 5;
            this.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(275, 278);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(126, 43);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // F_Listar_M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.dgv_marcas);
            this.Controls.Add(this.btn_salir_listarmarcas);
            this.Controls.Add(this.l_listarmarca);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "F_Listar_M";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Marcas";
            this.Load += new System.EventHandler(this.F_Listar_M_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l_listarmarca;
        private System.Windows.Forms.Button btn_salir_listarmarcas;
        private System.Windows.Forms.DataGridView dgv_marcas;
        private System.Windows.Forms.Button btn_eliminar;
    }
}