
namespace MantenedorProductos.WIN.Mantenedores
{
    partial class Frm_Marcas
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
            this.tblSubMarcas = new System.Windows.Forms.TableLayoutPanel();
            this.gpxMarcas = new System.Windows.Forms.GroupBox();
            this.btnMarcasAgregar = new System.Windows.Forms.Button();
            this.txtMarcasNombre = new System.Windows.Forms.TextBox();
            this.lblMarcasNombre = new System.Windows.Forms.Label();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.pnlMarcas = new System.Windows.Forms.Panel();
            this.tblSubMarcas.SuspendLayout();
            this.gpxMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.pnlMarcas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblSubMarcas
            // 
            this.tblSubMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblSubMarcas.ColumnCount = 1;
            this.tblSubMarcas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSubMarcas.Controls.Add(this.gpxMarcas, 0, 0);
            this.tblSubMarcas.Controls.Add(this.dgvMarcas, 0, 1);
            this.tblSubMarcas.Location = new System.Drawing.Point(12, 12);
            this.tblSubMarcas.Name = "tblSubMarcas";
            this.tblSubMarcas.RowCount = 2;
            this.tblSubMarcas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblSubMarcas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSubMarcas.Size = new System.Drawing.Size(560, 477);
            this.tblSubMarcas.TabIndex = 1;
            // 
            // gpxMarcas
            // 
            this.gpxMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxMarcas.Controls.Add(this.btnMarcasAgregar);
            this.gpxMarcas.Controls.Add(this.txtMarcasNombre);
            this.gpxMarcas.Controls.Add(this.lblMarcasNombre);
            this.gpxMarcas.Location = new System.Drawing.Point(3, 3);
            this.gpxMarcas.Name = "gpxMarcas";
            this.gpxMarcas.Size = new System.Drawing.Size(554, 54);
            this.gpxMarcas.TabIndex = 0;
            this.gpxMarcas.TabStop = false;
            this.gpxMarcas.Text = "Agregar Sub Categoría";
            // 
            // btnMarcasAgregar
            // 
            this.btnMarcasAgregar.Location = new System.Drawing.Point(444, 19);
            this.btnMarcasAgregar.Name = "btnMarcasAgregar";
            this.btnMarcasAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnMarcasAgregar.TabIndex = 2;
            this.btnMarcasAgregar.Text = "Agregar";
            this.btnMarcasAgregar.UseVisualStyleBackColor = true;
            // 
            // txtMarcasNombre
            // 
            this.txtMarcasNombre.Location = new System.Drawing.Point(67, 20);
            this.txtMarcasNombre.Name = "txtMarcasNombre";
            this.txtMarcasNombre.Size = new System.Drawing.Size(361, 23);
            this.txtMarcasNombre.TabIndex = 1;
            // 
            // lblMarcasNombre
            // 
            this.lblMarcasNombre.AutoSize = true;
            this.lblMarcasNombre.Location = new System.Drawing.Point(10, 23);
            this.lblMarcasNombre.Name = "lblMarcasNombre";
            this.lblMarcasNombre.Size = new System.Drawing.Size(51, 15);
            this.lblMarcasNombre.TabIndex = 0;
            this.lblMarcasNombre.Text = "Nombre";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMarcas.Location = new System.Drawing.Point(3, 63);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowTemplate.Height = 25;
            this.dgvMarcas.Size = new System.Drawing.Size(554, 411);
            this.dgvMarcas.TabIndex = 1;
            // 
            // pnlMarcas
            // 
            this.pnlMarcas.Controls.Add(this.tblSubMarcas);
            this.pnlMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMarcas.Location = new System.Drawing.Point(0, 0);
            this.pnlMarcas.Name = "pnlMarcas";
            this.pnlMarcas.Size = new System.Drawing.Size(584, 501);
            this.pnlMarcas.TabIndex = 2;
            // 
            // Frm_Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 501);
            this.Controls.Add(this.pnlMarcas);
            this.MaximizeBox = false;
            this.Name = "Frm_Marcas";
            this.Text = "Mantendor de Marcas";
            this.tblSubMarcas.ResumeLayout(false);
            this.gpxMarcas.ResumeLayout(false);
            this.gpxMarcas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.pnlMarcas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblSubMarcas;
        private System.Windows.Forms.GroupBox gpxMarcas;
        private System.Windows.Forms.Button btnMarcasAgregar;
        private System.Windows.Forms.TextBox txtMarcasNombre;
        private System.Windows.Forms.Label lblMarcasNombre;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Panel pnlMarcas;
    }
}