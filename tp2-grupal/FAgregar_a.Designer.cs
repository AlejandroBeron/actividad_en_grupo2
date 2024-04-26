
namespace tp2_grupal
{
    partial class FAgregar_a
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
            this.l_nom_art = new System.Windows.Forms.Label();
            this.tb_nombrea = new System.Windows.Forms.TextBox();
            this.l_marca_a = new System.Windows.Forms.Label();
            this.lcate_a = new System.Windows.Forms.Label();
            this.ldetalle_a = new System.Windows.Forms.Label();
            this.r_detalle_a = new System.Windows.Forms.RichTextBox();
            this.A_agregar_A = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_marcas_a = new System.Windows.Forms.ComboBox();
            this.cb_categorias_a = new System.Windows.Forms.ComboBox();
            this.l_precioa = new System.Windows.Forms.Label();
            this.tb_precioa = new System.Windows.Forms.TextBox();
            this.tb_codigoa = new System.Windows.Forms.TextBox();
            this.l_codigoa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_nom_art
            // 
            this.l_nom_art.AutoSize = true;
            this.l_nom_art.Font = new System.Drawing.Font("Arial", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_nom_art.ForeColor = System.Drawing.Color.White;
            this.l_nom_art.Location = new System.Drawing.Point(34, 10);
            this.l_nom_art.MaximumSize = new System.Drawing.Size(288, 33);
            this.l_nom_art.MinimumSize = new System.Drawing.Size(288, 33);
            this.l_nom_art.Name = "l_nom_art";
            this.l_nom_art.Size = new System.Drawing.Size(288, 33);
            this.l_nom_art.TabIndex = 0;
            this.l_nom_art.Text = "Nombre del Articulo:";
            this.l_nom_art.Click += new System.EventHandler(this.l_nom_art_Click);
            // 
            // tb_nombrea
            // 
            this.tb_nombrea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tb_nombrea.Font = new System.Drawing.Font("Arial", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombrea.Location = new System.Drawing.Point(226, 6);
            this.tb_nombrea.Name = "tb_nombrea";
            this.tb_nombrea.Size = new System.Drawing.Size(223, 34);
            this.tb_nombrea.TabIndex = 0;
            this.tb_nombrea.TextChanged += new System.EventHandler(this.tb_nombrea_TextChanged);
            // 
            // l_marca_a
            // 
            this.l_marca_a.AutoSize = true;
            this.l_marca_a.Font = new System.Drawing.Font("Arial", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_marca_a.ForeColor = System.Drawing.SystemColors.Control;
            this.l_marca_a.Location = new System.Drawing.Point(129, 101);
            this.l_marca_a.MaximumSize = new System.Drawing.Size(105, 33);
            this.l_marca_a.MinimumSize = new System.Drawing.Size(105, 33);
            this.l_marca_a.Name = "l_marca_a";
            this.l_marca_a.Size = new System.Drawing.Size(105, 33);
            this.l_marca_a.TabIndex = 2;
            this.l_marca_a.Text = "Marca:";
            // 
            // lcate_a
            // 
            this.lcate_a.AutoSize = true;
            this.lcate_a.Font = new System.Drawing.Font("Arial", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcate_a.ForeColor = System.Drawing.Color.White;
            this.lcate_a.Location = new System.Drawing.Point(90, 150);
            this.lcate_a.MaximumSize = new System.Drawing.Size(168, 33);
            this.lcate_a.MinimumSize = new System.Drawing.Size(168, 33);
            this.lcate_a.Name = "lcate_a";
            this.lcate_a.Size = new System.Drawing.Size(168, 33);
            this.lcate_a.TabIndex = 3;
            this.lcate_a.Text = "Categorias:";
            // 
            // ldetalle_a
            // 
            this.ldetalle_a.AutoSize = true;
            this.ldetalle_a.Font = new System.Drawing.Font("Arial", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldetalle_a.ForeColor = System.Drawing.SystemColors.Control;
            this.ldetalle_a.Location = new System.Drawing.Point(50, 247);
            this.ldetalle_a.MaximumSize = new System.Drawing.Size(132, 33);
            this.ldetalle_a.MinimumSize = new System.Drawing.Size(132, 33);
            this.ldetalle_a.Name = "ldetalle_a";
            this.ldetalle_a.Size = new System.Drawing.Size(132, 33);
            this.ldetalle_a.TabIndex = 4;
            this.ldetalle_a.Text = "Detalles:";
            // 
            // r_detalle_a
            // 
            this.r_detalle_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.r_detalle_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.r_detalle_a.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_detalle_a.Location = new System.Drawing.Point(161, 245);
            this.r_detalle_a.MaximumSize = new System.Drawing.Size(288, 156);
            this.r_detalle_a.MinimumSize = new System.Drawing.Size(288, 156);
            this.r_detalle_a.Name = "r_detalle_a";
            this.r_detalle_a.Size = new System.Drawing.Size(288, 156);
            this.r_detalle_a.TabIndex = 5;
            this.r_detalle_a.Text = "";
            // 
            // A_agregar_A
            // 
            this.A_agregar_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.A_agregar_A.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A_agregar_A.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.A_agregar_A.FlatAppearance.BorderSize = 5;
            this.A_agregar_A.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.A_agregar_A.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.A_agregar_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A_agregar_A.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_agregar_A.Location = new System.Drawing.Point(176, 407);
            this.A_agregar_A.Name = "A_agregar_A";
            this.A_agregar_A.Size = new System.Drawing.Size(94, 37);
            this.A_agregar_A.TabIndex = 6;
            this.A_agregar_A.Text = "Aceptar";
            this.A_agregar_A.UseVisualStyleBackColor = false;
            this.A_agregar_A.Click += new System.EventHandler(this.A_agregar_A_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(308, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_marcas_a
            // 
            this.cb_marcas_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cb_marcas_a.Cursor = System.Windows.Forms.Cursors.Default;
            this.cb_marcas_a.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_marcas_a.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_marcas_a.FormattingEnabled = true;
            this.cb_marcas_a.Location = new System.Drawing.Point(227, 96);
            this.cb_marcas_a.Name = "cb_marcas_a";
            this.cb_marcas_a.Size = new System.Drawing.Size(222, 38);
            this.cb_marcas_a.TabIndex = 2;
            // 
            // cb_categorias_a
            // 
            this.cb_categorias_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cb_categorias_a.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categorias_a.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_categorias_a.FormattingEnabled = true;
            this.cb_categorias_a.Location = new System.Drawing.Point(226, 147);
            this.cb_categorias_a.Name = "cb_categorias_a";
            this.cb_categorias_a.Size = new System.Drawing.Size(223, 38);
            this.cb_categorias_a.TabIndex = 3;
            // 
            // l_precioa
            // 
            this.l_precioa.AutoSize = true;
            this.l_precioa.Font = new System.Drawing.Font("Arial", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_precioa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_precioa.Location = new System.Drawing.Point(125, 202);
            this.l_precioa.Name = "l_precioa";
            this.l_precioa.Size = new System.Drawing.Size(109, 32);
            this.l_precioa.TabIndex = 10;
            this.l_precioa.Text = "Precio:";
            // 
            // tb_precioa
            // 
            this.tb_precioa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tb_precioa.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_precioa.Location = new System.Drawing.Point(227, 202);
            this.tb_precioa.Name = "tb_precioa";
            this.tb_precioa.Size = new System.Drawing.Size(223, 37);
            this.tb_precioa.TabIndex = 4;
            // 
            // tb_codigoa
            // 
            this.tb_codigoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tb_codigoa.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigoa.Location = new System.Drawing.Point(226, 46);
            this.tb_codigoa.Name = "tb_codigoa";
            this.tb_codigoa.Size = new System.Drawing.Size(223, 37);
            this.tb_codigoa.TabIndex = 1;
            // 
            // l_codigoa
            // 
            this.l_codigoa.AutoSize = true;
            this.l_codigoa.Font = new System.Drawing.Font("Arial", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_codigoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_codigoa.Location = new System.Drawing.Point(34, 51);
            this.l_codigoa.Name = "l_codigoa";
            this.l_codigoa.Size = new System.Drawing.Size(280, 32);
            this.l_codigoa.TabIndex = 13;
            this.l_codigoa.Text = "Codigo del Articulo:";
            // 
            // FAgregar_a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(576, 436);
            this.Controls.Add(this.l_codigoa);
            this.Controls.Add(this.tb_codigoa);
            this.Controls.Add(this.tb_precioa);
            this.Controls.Add(this.l_precioa);
            this.Controls.Add(this.cb_categorias_a);
            this.Controls.Add(this.cb_marcas_a);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.A_agregar_A);
            this.Controls.Add(this.r_detalle_a);
            this.Controls.Add(this.ldetalle_a);
            this.Controls.Add(this.lcate_a);
            this.Controls.Add(this.l_marca_a);
            this.Controls.Add(this.tb_nombrea);
            this.Controls.Add(this.l_nom_art);
            this.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "FAgregar_a";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Articulo";
            this.Load += new System.EventHandler(this.FAgregar_a_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_nombrea;
        private System.Windows.Forms.Label l_marca_a;
        private System.Windows.Forms.Label lcate_a;
        private System.Windows.Forms.Label ldetalle_a;
        private System.Windows.Forms.RichTextBox r_detalle_a;
        private System.Windows.Forms.Label l_nom_art;
        private System.Windows.Forms.Button A_agregar_A;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_marcas_a;
        private System.Windows.Forms.ComboBox cb_categorias_a;
        private System.Windows.Forms.Label l_precioa;
        private System.Windows.Forms.TextBox tb_precioa;
        private System.Windows.Forms.TextBox tb_codigoa;
        private System.Windows.Forms.Label l_codigoa;
    }
}