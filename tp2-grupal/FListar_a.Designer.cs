
namespace tp2_grupal
{
    partial class FListar_a
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
            this.dgv_articulos = new System.Windows.Forms.DataGridView();
            this.pbx_articulos = new System.Windows.Forms.PictureBox();
            this.B_atras = new System.Windows.Forms.Button();
            this.B_siguiente = new System.Windows.Forms.Button();
            this.text_imagen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_articulos
            // 
            this.dgv_articulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_articulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_articulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_articulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgv_articulos.Location = new System.Drawing.Point(22, 30);
            this.dgv_articulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_articulos.MultiSelect = false;
            this.dgv_articulos.Name = "dgv_articulos";
            this.dgv_articulos.RowHeadersWidth = 72;
            this.dgv_articulos.RowTemplate.Height = 31;
            this.dgv_articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_articulos.Size = new System.Drawing.Size(698, 216);
            this.dgv_articulos.TabIndex = 0;
            this.dgv_articulos.SelectionChanged += new System.EventHandler(this.dgv_articulos_SelectionChanged);
            // 
            // pbx_articulos
            // 
            this.pbx_articulos.Location = new System.Drawing.Point(258, 263);
            this.pbx_articulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbx_articulos.Name = "pbx_articulos";
            this.pbx_articulos.Size = new System.Drawing.Size(253, 213);
            this.pbx_articulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_articulos.TabIndex = 1;
            this.pbx_articulos.TabStop = false;
            // 
            // B_atras
            // 
            this.B_atras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.B_atras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.B_atras.FlatAppearance.BorderSize = 5;
            this.B_atras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.B_atras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(58)))));
            this.B_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_atras.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_atras.Location = new System.Drawing.Point(197, 481);
            this.B_atras.Name = "B_atras";
            this.B_atras.Size = new System.Drawing.Size(163, 43);
            this.B_atras.TabIndex = 2;
            this.B_atras.Text = "Anterior";
            this.B_atras.UseVisualStyleBackColor = false;
            this.B_atras.Click += new System.EventHandler(this.B_atras_Click);
            // 
            // B_siguiente
            // 
            this.B_siguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.B_siguiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.B_siguiente.FlatAppearance.BorderSize = 5;
            this.B_siguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.B_siguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(58)))));
            this.B_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_siguiente.Location = new System.Drawing.Point(414, 481);
            this.B_siguiente.Name = "B_siguiente";
            this.B_siguiente.Size = new System.Drawing.Size(163, 43);
            this.B_siguiente.TabIndex = 3;
            this.B_siguiente.Text = "Siguiente";
            this.B_siguiente.UseVisualStyleBackColor = false;
            this.B_siguiente.Click += new System.EventHandler(this.B_siguiente_Click);
            // 
            // text_imagen
            // 
            this.text_imagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.text_imagen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_imagen.Location = new System.Drawing.Point(531, 428);
            this.text_imagen.Name = "text_imagen";
            this.text_imagen.Size = new System.Drawing.Size(76, 30);
            this.text_imagen.TabIndex = 4;
            this.text_imagen.TextChanged += new System.EventHandler(this.text_imagen_TextChanged);
            // 
            // FListar_a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(776, 536);
            this.Controls.Add(this.text_imagen);
            this.Controls.Add(this.B_siguiente);
            this.Controls.Add(this.B_atras);
            this.Controls.Add(this.pbx_articulos);
            this.Controls.Add(this.dgv_articulos);
            this.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FListar_a";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Articulos";
            this.Load += new System.EventHandler(this.FListar_a_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_articulos;
        private System.Windows.Forms.PictureBox pbx_articulos;
        private System.Windows.Forms.Button B_atras;
        private System.Windows.Forms.Button B_siguiente;
        private System.Windows.Forms.TextBox text_imagen;
    }
}