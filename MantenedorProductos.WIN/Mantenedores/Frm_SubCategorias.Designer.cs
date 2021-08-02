
namespace MantenedorProductos.WIN.Mantenedores
{
    partial class Frm_SubCategorias
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
            this.pnlSubCategorias = new System.Windows.Forms.Panel();
            this.tblSubCategorias = new System.Windows.Forms.TableLayoutPanel();
            this.gpxSubCategorias = new System.Windows.Forms.GroupBox();
            this.btnSubCategoriasAgregar = new System.Windows.Forms.Button();
            this.txtSubCategoriasNombre = new System.Windows.Forms.TextBox();
            this.lblSubCategoriaNombre = new System.Windows.Forms.Label();
            this.dgvSubCategorias = new System.Windows.Forms.DataGridView();
            this.dgvSubCategoriasIdSubCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubCategoriasNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubCategoriasEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvSubCategoriasEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlSubCategorias.SuspendLayout();
            this.tblSubCategorias.SuspendLayout();
            this.gpxSubCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSubCategorias
            // 
            this.pnlSubCategorias.Controls.Add(this.tblSubCategorias);
            this.pnlSubCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSubCategorias.Location = new System.Drawing.Point(0, 0);
            this.pnlSubCategorias.Name = "pnlSubCategorias";
            this.pnlSubCategorias.Size = new System.Drawing.Size(584, 501);
            this.pnlSubCategorias.TabIndex = 0;
            // 
            // tblSubCategorias
            // 
            this.tblSubCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblSubCategorias.ColumnCount = 1;
            this.tblSubCategorias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSubCategorias.Controls.Add(this.gpxSubCategorias, 0, 0);
            this.tblSubCategorias.Controls.Add(this.dgvSubCategorias, 0, 1);
            this.tblSubCategorias.Location = new System.Drawing.Point(12, 12);
            this.tblSubCategorias.Name = "tblSubCategorias";
            this.tblSubCategorias.RowCount = 2;
            this.tblSubCategorias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblSubCategorias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSubCategorias.Size = new System.Drawing.Size(560, 477);
            this.tblSubCategorias.TabIndex = 0;
            // 
            // gpxSubCategorias
            // 
            this.gpxSubCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxSubCategorias.Controls.Add(this.btnSubCategoriasAgregar);
            this.gpxSubCategorias.Controls.Add(this.txtSubCategoriasNombre);
            this.gpxSubCategorias.Controls.Add(this.lblSubCategoriaNombre);
            this.gpxSubCategorias.Location = new System.Drawing.Point(3, 3);
            this.gpxSubCategorias.Name = "gpxSubCategorias";
            this.gpxSubCategorias.Size = new System.Drawing.Size(554, 54);
            this.gpxSubCategorias.TabIndex = 0;
            this.gpxSubCategorias.TabStop = false;
            this.gpxSubCategorias.Text = "Agregar Sub Categoría";
            // 
            // btnSubCategoriasAgregar
            // 
            this.btnSubCategoriasAgregar.Location = new System.Drawing.Point(444, 19);
            this.btnSubCategoriasAgregar.Name = "btnSubCategoriasAgregar";
            this.btnSubCategoriasAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnSubCategoriasAgregar.TabIndex = 2;
            this.btnSubCategoriasAgregar.Text = "Agregar";
            this.btnSubCategoriasAgregar.UseVisualStyleBackColor = true;
            this.btnSubCategoriasAgregar.Click += new System.EventHandler(this.btnSubCategoriasAgregar_Click);
            // 
            // txtSubCategoriasNombre
            // 
            this.txtSubCategoriasNombre.Location = new System.Drawing.Point(67, 20);
            this.txtSubCategoriasNombre.Name = "txtSubCategoriasNombre";
            this.txtSubCategoriasNombre.Size = new System.Drawing.Size(361, 23);
            this.txtSubCategoriasNombre.TabIndex = 1;
            // 
            // lblSubCategoriaNombre
            // 
            this.lblSubCategoriaNombre.AutoSize = true;
            this.lblSubCategoriaNombre.Location = new System.Drawing.Point(10, 23);
            this.lblSubCategoriaNombre.Name = "lblSubCategoriaNombre";
            this.lblSubCategoriaNombre.Size = new System.Drawing.Size(51, 15);
            this.lblSubCategoriaNombre.TabIndex = 0;
            this.lblSubCategoriaNombre.Text = "Nombre";
            // 
            // dgvSubCategorias
            // 
            this.dgvSubCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSubCategoriasIdSubCategoria,
            this.dgvSubCategoriasNombre,
            this.dgvSubCategoriasEditar,
            this.dgvSubCategoriasEliminar});
            this.dgvSubCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubCategorias.Location = new System.Drawing.Point(3, 63);
            this.dgvSubCategorias.Name = "dgvSubCategorias";
            this.dgvSubCategorias.RowTemplate.Height = 25;
            this.dgvSubCategorias.Size = new System.Drawing.Size(554, 411);
            this.dgvSubCategorias.TabIndex = 1;
            this.dgvSubCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubCategorias_CellClick);
            // 
            // dgvSubCategoriasIdSubCategoria
            // 
            this.dgvSubCategoriasIdSubCategoria.DataPropertyName = "Id";
            this.dgvSubCategoriasIdSubCategoria.HeaderText = "IdSubCategoria";
            this.dgvSubCategoriasIdSubCategoria.Name = "dgvSubCategoriasIdSubCategoria";
            this.dgvSubCategoriasIdSubCategoria.Visible = false;
            // 
            // dgvSubCategoriasNombre
            // 
            this.dgvSubCategoriasNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSubCategoriasNombre.DataPropertyName = "Nombre";
            this.dgvSubCategoriasNombre.HeaderText = "Sub Categoría";
            this.dgvSubCategoriasNombre.Name = "dgvSubCategoriasNombre";
            // 
            // dgvSubCategoriasEditar
            // 
            this.dgvSubCategoriasEditar.HeaderText = "Editar";
            this.dgvSubCategoriasEditar.MinimumWidth = 64;
            this.dgvSubCategoriasEditar.Name = "dgvSubCategoriasEditar";
            this.dgvSubCategoriasEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubCategoriasEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvSubCategoriasEliminar
            // 
            this.dgvSubCategoriasEliminar.HeaderText = "Eliminar";
            this.dgvSubCategoriasEliminar.MinimumWidth = 64;
            this.dgvSubCategoriasEliminar.Name = "dgvSubCategoriasEliminar";
            this.dgvSubCategoriasEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubCategoriasEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Frm_SubCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 501);
            this.Controls.Add(this.pnlSubCategorias);
            this.Name = "Frm_SubCategorias";
            this.Text = "Mantenedor de Sub Categorías";
            this.Load += new System.EventHandler(this.Frm_SubCategorias_Load);
            this.pnlSubCategorias.ResumeLayout(false);
            this.tblSubCategorias.ResumeLayout(false);
            this.gpxSubCategorias.ResumeLayout(false);
            this.gpxSubCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSubCategorias;
        private System.Windows.Forms.TableLayoutPanel tblSubCategorias;
        private System.Windows.Forms.GroupBox gpxSubCategorias;
        private System.Windows.Forms.Label lblSubCategoriaNombre;
        private System.Windows.Forms.Button btnSubCategoriasAgregar;
        private System.Windows.Forms.TextBox txtSubCategoriasNombre;
        private System.Windows.Forms.DataGridView dgvSubCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoriasIdSubCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoriasNombre;
        private System.Windows.Forms.DataGridViewImageColumn dgvSubCategoriasEditar;
        private System.Windows.Forms.DataGridViewImageColumn dgvSubCategoriasEliminar;
    }
}