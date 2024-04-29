
namespace tp2_grupal
{
    partial class FEliminar_a
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
            this.l_codelim_a = new System.Windows.Forms.Label();
            this.b_eliminar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_eliminara = new System.Windows.Forms.DataGridView();
            this.pb_Eliminar = new System.Windows.Forms.PictureBox();
            this.text_imagen = new System.Windows.Forms.TextBox();
            this.b_siguiente = new System.Windows.Forms.Button();
            this.b_atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eliminara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Eliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // l_codelim_a
            // 
            this.l_codelim_a.AutoSize = true;
            this.l_codelim_a.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_codelim_a.ForeColor = System.Drawing.Color.White;
            this.l_codelim_a.Location = new System.Drawing.Point(63, 56);
            this.l_codelim_a.Name = "l_codelim_a";
            this.l_codelim_a.Size = new System.Drawing.Size(576, 33);
            this.l_codelim_a.TabIndex = 0;
            this.l_codelim_a.Text = "seleccione el articulo que desea eliminar:";
            // 
            // b_eliminar
            // 
            this.b_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.b_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_eliminar.FlatAppearance.BorderSize = 3;
            this.b_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.b_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(58)))));
            this.b_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_eliminar.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_eliminar.Location = new System.Drawing.Point(460, 371);
            this.b_eliminar.MaximumSize = new System.Drawing.Size(150, 44);
            this.b_eliminar.MinimumSize = new System.Drawing.Size(150, 44);
            this.b_eliminar.Name = "b_eliminar";
            this.b_eliminar.Size = new System.Drawing.Size(150, 44);
            this.b_eliminar.TabIndex = 2;
            this.b_eliminar.Text = "&Eliminar";
            this.b_eliminar.UseVisualStyleBackColor = false;
            this.b_eliminar.Click += new System.EventHandler(this.b_eliminar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(58)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(460, 445);
            this.button2.MaximumSize = new System.Drawing.Size(150, 44);
            this.button2.MinimumSize = new System.Drawing.Size(150, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv_eliminara
            // 
            this.dgv_eliminara.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_eliminara.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_eliminara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_eliminara.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgv_eliminara.Location = new System.Drawing.Point(77, 98);
            this.dgv_eliminara.Name = "dgv_eliminara";
            this.dgv_eliminara.RowHeadersWidth = 72;
            this.dgv_eliminara.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_eliminara.Size = new System.Drawing.Size(513, 201);
            this.dgv_eliminara.TabIndex = 4;
            this.dgv_eliminara.SelectionChanged += new System.EventHandler(this.dgv_eliminara_SelectionChanged);
            // 
            // pb_Eliminar
            // 
            this.pb_Eliminar.Location = new System.Drawing.Point(98, 324);
            this.pb_Eliminar.Name = "pb_Eliminar";
            this.pb_Eliminar.Size = new System.Drawing.Size(148, 121);
            this.pb_Eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Eliminar.TabIndex = 5;
            this.pb_Eliminar.TabStop = false;
            this.pb_Eliminar.Click += new System.EventHandler(this.PBox_A_Eliminar_Click);
            // 
            // text_imagen
            // 
            this.text_imagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.text_imagen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_imagen.Location = new System.Drawing.Point(274, 398);
            this.text_imagen.Name = "text_imagen";
            this.text_imagen.Size = new System.Drawing.Size(100, 40);
            this.text_imagen.TabIndex = 6;
            // 
            // b_siguiente
            // 
            this.b_siguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.b_siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_siguiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_siguiente.FlatAppearance.BorderSize = 3;
            this.b_siguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.b_siguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(58)))));
            this.b_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_siguiente.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_siguiente.Location = new System.Drawing.Point(178, 469);
            this.b_siguiente.MaximumSize = new System.Drawing.Size(150, 44);
            this.b_siguiente.MinimumSize = new System.Drawing.Size(150, 44);
            this.b_siguiente.Name = "b_siguiente";
            this.b_siguiente.Size = new System.Drawing.Size(150, 44);
            this.b_siguiente.TabIndex = 8;
            this.b_siguiente.Text = "&Siguiente";
            this.b_siguiente.UseVisualStyleBackColor = false;
            this.b_siguiente.Click += new System.EventHandler(this.b_siguiente_Click);
            // 
            // b_atras
            // 
            this.b_atras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.b_atras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_atras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_atras.FlatAppearance.BorderSize = 3;
            this.b_atras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.b_atras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(58)))));
            this.b_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_atras.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_atras.Location = new System.Drawing.Point(12, 469);
            this.b_atras.MaximumSize = new System.Drawing.Size(150, 44);
            this.b_atras.MinimumSize = new System.Drawing.Size(150, 44);
            this.b_atras.Name = "b_atras";
            this.b_atras.Size = new System.Drawing.Size(150, 44);
            this.b_atras.TabIndex = 7;
            this.b_atras.Text = "&Anterior";
            this.b_atras.UseVisualStyleBackColor = false;
            this.b_atras.Click += new System.EventHandler(this.b_atras_Click);
            // 
            // FEliminar_a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(676, 536);
            this.Controls.Add(this.b_siguiente);
            this.Controls.Add(this.b_atras);
            this.Controls.Add(this.text_imagen);
            this.Controls.Add(this.pb_Eliminar);
            this.Controls.Add(this.dgv_eliminara);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.b_eliminar);
            this.Controls.Add(this.l_codelim_a);
            this.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 600);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "FEliminar_a";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Articulos";
            this.Load += new System.EventHandler(this.FEliminar_a_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eliminara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Eliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_codelim_a;
        private System.Windows.Forms.Button b_eliminar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv_eliminara;
        private System.Windows.Forms.PictureBox pb_Eliminar;
        private System.Windows.Forms.TextBox text_imagen;
        private System.Windows.Forms.Button b_siguiente;
        private System.Windows.Forms.Button b_atras;
    }
}