namespace tp2_grupal
{
    partial class Frm_marcas
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
            this.b_agregar_m = new System.Windows.Forms.Button();
            this.b_listar_m = new System.Windows.Forms.Button();
            this.b_volve_m = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_agregar_m
            // 
            this.b_agregar_m.AccessibleName = "b_agregar_m";
            this.b_agregar_m.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.b_agregar_m.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.b_agregar_m.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_agregar_m.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_agregar_m.FlatAppearance.BorderSize = 5;
            this.b_agregar_m.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.b_agregar_m.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(58)))));
            this.b_agregar_m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_agregar_m.Location = new System.Drawing.Point(309, 35);
            this.b_agregar_m.Name = "b_agregar_m";
            this.b_agregar_m.Size = new System.Drawing.Size(122, 45);
            this.b_agregar_m.TabIndex = 1;
            this.b_agregar_m.Text = "Agregar marca";
            this.b_agregar_m.UseVisualStyleBackColor = false;
            this.b_agregar_m.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_listar_m
            // 
            this.b_listar_m.AccessibleName = "b_listar_m";
            this.b_listar_m.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.b_listar_m.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.b_listar_m.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_listar_m.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_listar_m.FlatAppearance.BorderSize = 5;
            this.b_listar_m.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.b_listar_m.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(58)))));
            this.b_listar_m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_listar_m.Location = new System.Drawing.Point(167, 35);
            this.b_listar_m.Name = "b_listar_m";
            this.b_listar_m.Size = new System.Drawing.Size(122, 45);
            this.b_listar_m.TabIndex = 2;
            this.b_listar_m.Text = "List/Elim";
            this.b_listar_m.UseVisualStyleBackColor = false;
            this.b_listar_m.Click += new System.EventHandler(this.b_listar_m_Click_1);
            // 
            // b_volve_m
            // 
            this.b_volve_m.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.b_volve_m.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.b_volve_m.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_volve_m.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_volve_m.FlatAppearance.BorderSize = 5;
            this.b_volve_m.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.b_volve_m.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(58)))));
            this.b_volve_m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_volve_m.Location = new System.Drawing.Point(23, 35);
            this.b_volve_m.Name = "b_volve_m";
            this.b_volve_m.Size = new System.Drawing.Size(122, 45);
            this.b_volve_m.TabIndex = 3;
            this.b_volve_m.Text = "Volver ";
            this.b_volve_m.UseVisualStyleBackColor = false;
            this.b_volve_m.Click += new System.EventHandler(this.b_volve_m_Click);
            // 
            // Frm_marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(464, 114);
            this.Controls.Add(this.b_volve_m);
            this.Controls.Add(this.b_listar_m);
            this.Controls.Add(this.b_agregar_m);
            this.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 153);
            this.MinimumSize = new System.Drawing.Size(480, 153);
            this.Name = "Frm_marcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Marcas";
            this.Load += new System.EventHandler(this.Frm_marcas_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button b_agregar_m;
        private System.Windows.Forms.Button b_listar_m;
        private System.Windows.Forms.Button b_volve_m;
    }
}