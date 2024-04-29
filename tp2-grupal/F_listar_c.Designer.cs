
namespace tp2_grupal
{
    partial class F_listar_c
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
            this.dgv_Categoria = new System.Windows.Forms.DataGridView();
            this.btn_salir_LC = new System.Windows.Forms.Button();
            this.M_categoria = new System.Windows.Forms.Button();
            this.Eliminar_c = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Categoria
            // 
            this.dgv_Categoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_Categoria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_Categoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Categoria.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgv_Categoria.Location = new System.Drawing.Point(149, 72);
            this.dgv_Categoria.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Categoria.Name = "dgv_Categoria";
            this.dgv_Categoria.Size = new System.Drawing.Size(204, 114);
            this.dgv_Categoria.TabIndex = 0;
            this.dgv_Categoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_salir_LC
            // 
            this.btn_salir_LC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_salir_LC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir_LC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_salir_LC.FlatAppearance.BorderSize = 5;
            this.btn_salir_LC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_salir_LC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(58)))));
            this.btn_salir_LC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir_LC.Location = new System.Drawing.Point(330, 238);
            this.btn_salir_LC.Name = "btn_salir_LC";
            this.btn_salir_LC.Size = new System.Drawing.Size(95, 36);
            this.btn_salir_LC.TabIndex = 1;
            this.btn_salir_LC.Text = "Salir";
            this.btn_salir_LC.UseVisualStyleBackColor = false;
            this.btn_salir_LC.Click += new System.EventHandler(this.btn_salir_LC_Click);
            // 
            // M_categoria
            // 
            this.M_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.M_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.M_categoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.M_categoria.FlatAppearance.BorderSize = 5;
            this.M_categoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.M_categoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(58)))));
            this.M_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.M_categoria.Location = new System.Drawing.Point(87, 238);
            this.M_categoria.Name = "M_categoria";
            this.M_categoria.Size = new System.Drawing.Size(95, 36);
            this.M_categoria.TabIndex = 2;
            this.M_categoria.Text = "Modificar";
            this.M_categoria.UseVisualStyleBackColor = false;
            this.M_categoria.Click += new System.EventHandler(this.M_categoria_Click);
            // 
            // Eliminar_c
            // 
            this.Eliminar_c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Eliminar_c.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Eliminar_c.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Eliminar_c.FlatAppearance.BorderSize = 5;
            this.Eliminar_c.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Eliminar_c.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(58)))));
            this.Eliminar_c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar_c.Location = new System.Drawing.Point(212, 238);
            this.Eliminar_c.Name = "Eliminar_c";
            this.Eliminar_c.Size = new System.Drawing.Size(95, 36);
            this.Eliminar_c.TabIndex = 3;
            this.Eliminar_c.Text = "Eliminar";
            this.Eliminar_c.UseVisualStyleBackColor = false;
            this.Eliminar_c.Click += new System.EventHandler(this.Eliminar_c_Click);
            // 
            // F_listar_c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.Eliminar_c);
            this.Controls.Add(this.M_categoria);
            this.Controls.Add(this.btn_salir_LC);
            this.Controls.Add(this.dgv_Categoria);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "F_listar_c";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Categorias";
            this.Load += new System.EventHandler(this.F_listar_c_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Categoria;
        private System.Windows.Forms.Button btn_salir_LC;
        private System.Windows.Forms.Button M_categoria;
        private System.Windows.Forms.Button Eliminar_c;
    }
}