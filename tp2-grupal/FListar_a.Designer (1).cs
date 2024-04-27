
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_articulos
            // 
            this.dgv_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_articulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_articulos.Location = new System.Drawing.Point(10, 20);
            this.dgv_articulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_articulos.MultiSelect = false;
            this.dgv_articulos.Name = "dgv_articulos";
            this.dgv_articulos.RowHeadersWidth = 72;
            this.dgv_articulos.RowTemplate.Height = 31;
            this.dgv_articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_articulos.Size = new System.Drawing.Size(780, 245);
            this.dgv_articulos.TabIndex = 0;
            this.dgv_articulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_articulos.SelectionChanged += new System.EventHandler(this.dgv_articulos_SelectionChanged);
            // 
            // pbx_articulos
            // 
            this.pbx_articulos.Location = new System.Drawing.Point(242, 280);
            this.pbx_articulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbx_articulos.Name = "pbx_articulos";
            this.pbx_articulos.Size = new System.Drawing.Size(273, 245);
            this.pbx_articulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_articulos.TabIndex = 1;
            this.pbx_articulos.TabStop = false;
            // 
            // FListar_a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(776, 536);
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

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_articulos;
        private System.Windows.Forms.PictureBox pbx_articulos;
    }
}