
namespace tp2_grupal
{
    partial class F_agregar_i
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
            this.b_cancel_ai = new System.Windows.Forms.Button();
            this.b_acep_ai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idarticulo = new System.Windows.Forms.TextBox();
            this.txt_imagen = new System.Windows.Forms.TextBox();
            this.pb_imagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // b_cancel_ai
            // 
            this.b_cancel_ai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.b_cancel_ai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_cancel_ai.FlatAppearance.BorderSize = 3;
            this.b_cancel_ai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.b_cancel_ai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(58)))));
            this.b_cancel_ai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_cancel_ai.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_cancel_ai.Location = new System.Drawing.Point(318, 226);
            this.b_cancel_ai.MaximumSize = new System.Drawing.Size(150, 44);
            this.b_cancel_ai.MinimumSize = new System.Drawing.Size(150, 44);
            this.b_cancel_ai.Name = "b_cancel_ai";
            this.b_cancel_ai.Size = new System.Drawing.Size(150, 44);
            this.b_cancel_ai.TabIndex = 0;
            this.b_cancel_ai.Text = "&Cancelar";
            this.b_cancel_ai.UseVisualStyleBackColor = false;
            this.b_cancel_ai.Click += new System.EventHandler(this.b_cancel_ai_Click);
            // 
            // b_acep_ai
            // 
            this.b_acep_ai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.b_acep_ai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_acep_ai.FlatAppearance.BorderSize = 3;
            this.b_acep_ai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.b_acep_ai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(58)))));
            this.b_acep_ai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_acep_ai.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_acep_ai.Location = new System.Drawing.Point(45, 226);
            this.b_acep_ai.MaximumSize = new System.Drawing.Size(150, 44);
            this.b_acep_ai.MinimumSize = new System.Drawing.Size(150, 44);
            this.b_acep_ai.Name = "b_acep_ai";
            this.b_acep_ai.Size = new System.Drawing.Size(150, 44);
            this.b_acep_ai.TabIndex = 1;
            this.b_acep_ai.Text = "&Aceptar";
            this.b_acep_ai.UseVisualStyleBackColor = false;
            this.b_acep_ai.Click += new System.EventHandler(this.b_acep_ai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Articulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = " Url Imagen";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_idarticulo
            // 
            this.txt_idarticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_idarticulo.Location = new System.Drawing.Point(151, 138);
            this.txt_idarticulo.Name = "txt_idarticulo";
            this.txt_idarticulo.Size = new System.Drawing.Size(174, 30);
            this.txt_idarticulo.TabIndex = 5;
            this.txt_idarticulo.TextChanged += new System.EventHandler(this.txt_idarticulo_TextChanged);
            // 
            // txt_imagen
            // 
            this.txt_imagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_imagen.Location = new System.Drawing.Point(151, 81);
            this.txt_imagen.Name = "txt_imagen";
            this.txt_imagen.Size = new System.Drawing.Size(174, 30);
            this.txt_imagen.TabIndex = 7;
            this.txt_imagen.Leave += new System.EventHandler(this.txt_imagen_Leave);
            // 
            // pb_imagen
            // 
            this.pb_imagen.Location = new System.Drawing.Point(362, 50);
            this.pb_imagen.Name = "pb_imagen";
            this.pb_imagen.Size = new System.Drawing.Size(177, 140);
            this.pb_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imagen.TabIndex = 8;
            this.pb_imagen.TabStop = false;
            // 
            // F_agregar_i
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pb_imagen);
            this.Controls.Add(this.txt_imagen);
            this.Controls.Add(this.txt_idarticulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_acep_ai);
            this.Controls.Add(this.b_cancel_ai);
            this.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "F_agregar_i";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Imagen";
            this.Load += new System.EventHandler(this.F_agregar_i_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_cancel_ai;
        private System.Windows.Forms.Button b_acep_ai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_idarticulo;
        private System.Windows.Forms.TextBox txt_imagen;
        private System.Windows.Forms.PictureBox pb_imagen;
    }
}