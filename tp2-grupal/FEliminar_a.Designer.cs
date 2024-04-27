
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eliminara)).BeginInit();
            this.SuspendLayout();
            // 
            // l_codelim_a
            // 
            this.l_codelim_a.AutoSize = true;
            this.l_codelim_a.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_codelim_a.ForeColor = System.Drawing.Color.White;
            this.l_codelim_a.Location = new System.Drawing.Point(32, 56);
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
            this.b_eliminar.Location = new System.Drawing.Point(126, 393);
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
            this.button2.Location = new System.Drawing.Point(382, 393);
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
            this.dgv_eliminara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_eliminara.Location = new System.Drawing.Point(67, 112);
            this.dgv_eliminara.Name = "dgv_eliminara";
            this.dgv_eliminara.RowHeadersWidth = 72;
            this.dgv_eliminara.Size = new System.Drawing.Size(513, 201);
            this.dgv_eliminara.TabIndex = 4;
            // 
            // FEliminar_a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(676, 536);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_codelim_a;
        private System.Windows.Forms.Button b_eliminar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv_eliminara;
    }
}