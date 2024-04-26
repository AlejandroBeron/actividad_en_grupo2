
namespace tp2_grupal
{
    partial class FModificar_a
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
            this.label1 = new System.Windows.Forms.Label();
            this.b_modif_a = new System.Windows.Forms.Button();
            this.b_cancel_ma = new System.Windows.Forms.Button();
            this.dgv_modificar_a = new System.Windows.Forms.DataGridView();
            this.pb_modificar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modificar_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_modificar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el articulo que desea modificar:";
            // 
            // b_modif_a
            // 
            this.b_modif_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.b_modif_a.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_modif_a.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_modif_a.FlatAppearance.BorderSize = 3;
            this.b_modif_a.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.b_modif_a.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(58)))));
            this.b_modif_a.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_modif_a.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_modif_a.Location = new System.Drawing.Point(143, 464);
            this.b_modif_a.Name = "b_modif_a";
            this.b_modif_a.Size = new System.Drawing.Size(150, 44);
            this.b_modif_a.TabIndex = 2;
            this.b_modif_a.Text = "&Modificar";
            this.b_modif_a.UseVisualStyleBackColor = false;
            this.b_modif_a.Click += new System.EventHandler(this.b_modif_a_Click);
            // 
            // b_cancel_ma
            // 
            this.b_cancel_ma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.b_cancel_ma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_cancel_ma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_cancel_ma.FlatAppearance.BorderSize = 3;
            this.b_cancel_ma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.b_cancel_ma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(58)))));
            this.b_cancel_ma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_cancel_ma.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_cancel_ma.Location = new System.Drawing.Point(406, 464);
            this.b_cancel_ma.Name = "b_cancel_ma";
            this.b_cancel_ma.Size = new System.Drawing.Size(150, 44);
            this.b_cancel_ma.TabIndex = 3;
            this.b_cancel_ma.Text = "&Cancelar";
            this.b_cancel_ma.UseVisualStyleBackColor = false;
            this.b_cancel_ma.Click += new System.EventHandler(this.b_cancel_ma_Click);
            // 
            // dgv_modificar_a
            // 
            this.dgv_modificar_a.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modificar_a.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_modificar_a.Location = new System.Drawing.Point(51, 63);
            this.dgv_modificar_a.MultiSelect = false;
            this.dgv_modificar_a.Name = "dgv_modificar_a";
            this.dgv_modificar_a.RowHeadersWidth = 72;
            this.dgv_modificar_a.RowTemplate.Height = 31;
            this.dgv_modificar_a.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_modificar_a.Size = new System.Drawing.Size(647, 219);
            this.dgv_modificar_a.TabIndex = 4;
            this.dgv_modificar_a.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_modificar_a_CellContentClick);
            this.dgv_modificar_a.SelectionChanged += new System.EventHandler(this.dgv_modificar_SeleccionCanged);
            // 
            // pb_modificar
            // 
            this.pb_modificar.Location = new System.Drawing.Point(265, 288);
            this.pb_modificar.Name = "pb_modificar";
            this.pb_modificar.Size = new System.Drawing.Size(189, 170);
            this.pb_modificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_modificar.TabIndex = 5;
            this.pb_modificar.TabStop = false;
            this.pb_modificar.Click += new System.EventHandler(this.pb_modificar_Click);
            // 
            // FModificar_a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pb_modificar);
            this.Controls.Add(this.dgv_modificar_a);
            this.Controls.Add(this.b_cancel_ma);
            this.Controls.Add(this.b_modif_a);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FModificar_a";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Articulos";
            this.Load += new System.EventHandler(this.FModificar_a_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modificar_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_modificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_modif_a;
        private System.Windows.Forms.Button b_cancel_ma;
        private System.Windows.Forms.DataGridView dgv_modificar_a;
        private System.Windows.Forms.PictureBox pb_modificar;
    }
}