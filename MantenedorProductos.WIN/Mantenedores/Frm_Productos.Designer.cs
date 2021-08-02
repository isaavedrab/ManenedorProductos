
namespace MantenedorProductos.WIN.Mantenedores
{
    partial class Frm_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Productos));
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.tlpProductos = new System.Windows.Forms.TableLayoutPanel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.dgvProductosId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductosNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductosCodBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductosPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductosIdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductosCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductosIdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductosMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductosEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvProductosEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbxProductos = new System.Windows.Forms.GroupBox();
            this.nupProductos = new System.Windows.Forms.NumericUpDown();
            this.lblProductosPrecio = new System.Windows.Forms.Label();
            this.btnProductosLimpiar = new System.Windows.Forms.Button();
            this.btnProductosAgregar = new System.Windows.Forms.Button();
            this.cmbProductosCategoria = new System.Windows.Forms.ComboBox();
            this.lblProductosCategoria = new System.Windows.Forms.Label();
            this.cmbProductosMarca = new System.Windows.Forms.ComboBox();
            this.lblProductosMarca = new System.Windows.Forms.Label();
            this.txtProductosCodBar = new System.Windows.Forms.TextBox();
            this.lblProductosCodBar = new System.Windows.Forms.Label();
            this.txtProductosNombre = new System.Windows.Forms.TextBox();
            this.lblProductosNombre = new System.Windows.Forms.Label();
            this.pnlProductos.SuspendLayout();
            this.tlpProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gbxProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProductos
            // 
            this.pnlProductos.Controls.Add(this.tlpProductos);
            this.pnlProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductos.Location = new System.Drawing.Point(0, 0);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(944, 501);
            this.pnlProductos.TabIndex = 1;
            // 
            // tlpProductos
            // 
            this.tlpProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpProductos.ColumnCount = 1;
            this.tlpProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpProductos.Controls.Add(this.dgvProductos, 0, 1);
            this.tlpProductos.Controls.Add(this.gbxProductos, 0, 0);
            this.tlpProductos.Location = new System.Drawing.Point(12, 12);
            this.tlpProductos.Name = "tlpProductos";
            this.tlpProductos.RowCount = 2;
            this.tlpProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpProductos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpProductos.Size = new System.Drawing.Size(920, 477);
            this.tlpProductos.TabIndex = 0;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProductosId,
            this.dgvProductosNombre,
            this.dgvProductosCodBarra,
            this.dgvProductosPrecio,
            this.dgvProductosIdCategoria,
            this.dgvProductosCategoria,
            this.dgvProductosIdMarca,
            this.dgvProductosMarca,
            this.dgvProductosEditar,
            this.dgvProductosEliminar});
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(3, 133);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.Size = new System.Drawing.Size(914, 341);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // dgvProductosId
            // 
            this.dgvProductosId.DataPropertyName = "Id";
            this.dgvProductosId.HeaderText = "Id";
            this.dgvProductosId.Name = "dgvProductosId";
            this.dgvProductosId.Visible = false;
            // 
            // dgvProductosNombre
            // 
            this.dgvProductosNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductosNombre.DataPropertyName = "Nombre";
            this.dgvProductosNombre.HeaderText = "Nombre";
            this.dgvProductosNombre.Name = "dgvProductosNombre";
            // 
            // dgvProductosCodBarra
            // 
            this.dgvProductosCodBarra.DataPropertyName = "CodBarra";
            this.dgvProductosCodBarra.HeaderText = "Cód. Barra";
            this.dgvProductosCodBarra.Name = "dgvProductosCodBarra";
            // 
            // dgvProductosPrecio
            // 
            this.dgvProductosPrecio.DataPropertyName = "Precio";
            this.dgvProductosPrecio.HeaderText = "Precio";
            this.dgvProductosPrecio.Name = "dgvProductosPrecio";
            // 
            // dgvProductosIdCategoria
            // 
            this.dgvProductosIdCategoria.DataPropertyName = "IdCategoria";
            this.dgvProductosIdCategoria.HeaderText = "IdCategoria";
            this.dgvProductosIdCategoria.Name = "dgvProductosIdCategoria";
            this.dgvProductosIdCategoria.Visible = false;
            // 
            // dgvProductosCategoria
            // 
            this.dgvProductosCategoria.DataPropertyName = "Categoria";
            this.dgvProductosCategoria.HeaderText = "Categoria";
            this.dgvProductosCategoria.Name = "dgvProductosCategoria";
            // 
            // dgvProductosIdMarca
            // 
            this.dgvProductosIdMarca.DataPropertyName = "IdMarca";
            this.dgvProductosIdMarca.HeaderText = "IdMarca";
            this.dgvProductosIdMarca.Name = "dgvProductosIdMarca";
            this.dgvProductosIdMarca.Visible = false;
            // 
            // dgvProductosMarca
            // 
            this.dgvProductosMarca.DataPropertyName = "Marca";
            this.dgvProductosMarca.HeaderText = "Marca";
            this.dgvProductosMarca.Name = "dgvProductosMarca";
            // 
            // dgvProductosEditar
            // 
            this.dgvProductosEditar.HeaderText = "Editar";
            this.dgvProductosEditar.Image = ((System.Drawing.Image)(resources.GetObject("dgvProductosEditar.Image")));
            this.dgvProductosEditar.Name = "dgvProductosEditar";
            this.dgvProductosEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvProductosEditar.Width = 64;
            // 
            // dgvProductosEliminar
            // 
            this.dgvProductosEliminar.HeaderText = "Eliminar";
            this.dgvProductosEliminar.Image = ((System.Drawing.Image)(resources.GetObject("dgvProductosEliminar.Image")));
            this.dgvProductosEliminar.Name = "dgvProductosEliminar";
            this.dgvProductosEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvProductosEliminar.Width = 64;
            // 
            // gbxProductos
            // 
            this.gbxProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxProductos.Controls.Add(this.nupProductos);
            this.gbxProductos.Controls.Add(this.lblProductosPrecio);
            this.gbxProductos.Controls.Add(this.btnProductosLimpiar);
            this.gbxProductos.Controls.Add(this.btnProductosAgregar);
            this.gbxProductos.Controls.Add(this.cmbProductosCategoria);
            this.gbxProductos.Controls.Add(this.lblProductosCategoria);
            this.gbxProductos.Controls.Add(this.cmbProductosMarca);
            this.gbxProductos.Controls.Add(this.lblProductosMarca);
            this.gbxProductos.Controls.Add(this.txtProductosCodBar);
            this.gbxProductos.Controls.Add(this.lblProductosCodBar);
            this.gbxProductos.Controls.Add(this.txtProductosNombre);
            this.gbxProductos.Controls.Add(this.lblProductosNombre);
            this.gbxProductos.Location = new System.Drawing.Point(3, 3);
            this.gbxProductos.Name = "gbxProductos";
            this.gbxProductos.Size = new System.Drawing.Size(914, 124);
            this.gbxProductos.TabIndex = 1;
            this.gbxProductos.TabStop = false;
            this.gbxProductos.Text = "Agregar Nuevo Producto";
            // 
            // nupProductos
            // 
            this.nupProductos.InterceptArrowKeys = false;
            this.nupProductos.Location = new System.Drawing.Point(77, 86);
            this.nupProductos.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nupProductos.Name = "nupProductos";
            this.nupProductos.Size = new System.Drawing.Size(200, 23);
            this.nupProductos.TabIndex = 12;
            this.nupProductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblProductosPrecio
            // 
            this.lblProductosPrecio.AutoSize = true;
            this.lblProductosPrecio.Location = new System.Drawing.Point(10, 88);
            this.lblProductosPrecio.Name = "lblProductosPrecio";
            this.lblProductosPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblProductosPrecio.TabIndex = 10;
            this.lblProductosPrecio.Text = "Precio";
            // 
            // btnProductosLimpiar
            // 
            this.btnProductosLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductosLimpiar.Location = new System.Drawing.Point(804, 55);
            this.btnProductosLimpiar.Name = "btnProductosLimpiar";
            this.btnProductosLimpiar.Size = new System.Drawing.Size(100, 23);
            this.btnProductosLimpiar.TabIndex = 9;
            this.btnProductosLimpiar.Text = "Limpiar";
            this.btnProductosLimpiar.UseVisualStyleBackColor = true;
            this.btnProductosLimpiar.Click += new System.EventHandler(this.btnProductosLimpiar_Click);
            // 
            // btnProductosAgregar
            // 
            this.btnProductosAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductosAgregar.Location = new System.Drawing.Point(804, 26);
            this.btnProductosAgregar.Name = "btnProductosAgregar";
            this.btnProductosAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnProductosAgregar.TabIndex = 8;
            this.btnProductosAgregar.Text = "Agregar";
            this.btnProductosAgregar.UseVisualStyleBackColor = true;
            this.btnProductosAgregar.Click += new System.EventHandler(this.btnProductosAgregar_Click);
            // 
            // cmbProductosCategoria
            // 
            this.cmbProductosCategoria.FormattingEnabled = true;
            this.cmbProductosCategoria.Location = new System.Drawing.Point(357, 83);
            this.cmbProductosCategoria.Name = "cmbProductosCategoria";
            this.cmbProductosCategoria.Size = new System.Drawing.Size(200, 23);
            this.cmbProductosCategoria.TabIndex = 7;
            // 
            // lblProductosCategoria
            // 
            this.lblProductosCategoria.AutoSize = true;
            this.lblProductosCategoria.Location = new System.Drawing.Point(293, 86);
            this.lblProductosCategoria.Name = "lblProductosCategoria";
            this.lblProductosCategoria.Size = new System.Drawing.Size(58, 15);
            this.lblProductosCategoria.TabIndex = 6;
            this.lblProductosCategoria.Text = "Categoría";
            // 
            // cmbProductosMarca
            // 
            this.cmbProductosMarca.FormattingEnabled = true;
            this.cmbProductosMarca.Location = new System.Drawing.Point(357, 54);
            this.cmbProductosMarca.Name = "cmbProductosMarca";
            this.cmbProductosMarca.Size = new System.Drawing.Size(200, 23);
            this.cmbProductosMarca.TabIndex = 5;
            // 
            // lblProductosMarca
            // 
            this.lblProductosMarca.AutoSize = true;
            this.lblProductosMarca.Location = new System.Drawing.Point(293, 57);
            this.lblProductosMarca.Name = "lblProductosMarca";
            this.lblProductosMarca.Size = new System.Drawing.Size(40, 15);
            this.lblProductosMarca.TabIndex = 4;
            this.lblProductosMarca.Text = "Marca";
            // 
            // txtProductosCodBar
            // 
            this.txtProductosCodBar.Location = new System.Drawing.Point(77, 54);
            this.txtProductosCodBar.Name = "txtProductosCodBar";
            this.txtProductosCodBar.Size = new System.Drawing.Size(200, 23);
            this.txtProductosCodBar.TabIndex = 3;
            // 
            // lblProductosCodBar
            // 
            this.lblProductosCodBar.AutoSize = true;
            this.lblProductosCodBar.Location = new System.Drawing.Point(10, 59);
            this.lblProductosCodBar.Name = "lblProductosCodBar";
            this.lblProductosCodBar.Size = new System.Drawing.Size(62, 15);
            this.lblProductosCodBar.TabIndex = 2;
            this.lblProductosCodBar.Text = "Cód. Barra";
            // 
            // txtProductosNombre
            // 
            this.txtProductosNombre.Location = new System.Drawing.Point(77, 25);
            this.txtProductosNombre.Name = "txtProductosNombre";
            this.txtProductosNombre.Size = new System.Drawing.Size(711, 23);
            this.txtProductosNombre.TabIndex = 1;
            // 
            // lblProductosNombre
            // 
            this.lblProductosNombre.AutoSize = true;
            this.lblProductosNombre.Location = new System.Drawing.Point(10, 30);
            this.lblProductosNombre.Name = "lblProductosNombre";
            this.lblProductosNombre.Size = new System.Drawing.Size(51, 15);
            this.lblProductosNombre.TabIndex = 0;
            this.lblProductosNombre.Text = "Nombre";
            // 
            // Frm_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.pnlProductos);
            this.Name = "Frm_Productos";
            this.Text = "Mantenedor de Productos";
            this.Load += new System.EventHandler(this.Frm_Productos_Load);
            this.pnlProductos.ResumeLayout(false);
            this.tlpProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gbxProductos.ResumeLayout(false);
            this.gbxProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.TableLayoutPanel tlpProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox gbxProductos;
        private System.Windows.Forms.Label lblProductosNombre;
        private System.Windows.Forms.TextBox txtProductosCodBar;
        private System.Windows.Forms.Label lblProductosCodBar;
        private System.Windows.Forms.TextBox txtProductosNombre;
        private System.Windows.Forms.ComboBox cmbProductosMarca;
        private System.Windows.Forms.Label lblProductosMarca;
        private System.Windows.Forms.ComboBox cmbProductosCategoria;
        private System.Windows.Forms.Label lblProductosCategoria;
        private System.Windows.Forms.Button btnProductosAgregar;
        private System.Windows.Forms.Button btnProductosLimpiar;
        private System.Windows.Forms.Label lblProductosPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductosId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductosNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductosCodBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductosPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductosIdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductosCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductosIdMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductosMarca;
        private System.Windows.Forms.DataGridViewImageColumn dgvProductosEditar;
        private System.Windows.Forms.DataGridViewImageColumn dgvProductosEliminar;
        private System.Windows.Forms.NumericUpDown nupProductos;
    }
}