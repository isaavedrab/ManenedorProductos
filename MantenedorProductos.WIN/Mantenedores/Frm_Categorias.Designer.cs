
namespace MantenedorProductos.WIN.Mantenedores
{
    partial class Frm_Categorias
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
            this.pnlCategorias = new System.Windows.Forms.Panel();
            this.tblCategorias = new System.Windows.Forms.TableLayoutPanel();
            this.gpxCategorias = new System.Windows.Forms.GroupBox();
            this.lblSubCategoria = new System.Windows.Forms.Label();
            this.cmbSubCategoria = new System.Windows.Forms.ComboBox();
            this.btnCategoriasAgregar = new System.Windows.Forms.Button();
            this.txtCategoriasNombre = new System.Windows.Forms.TextBox();
            this.lblCategoriaNombre = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.dgvCategoriasId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategoriasNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubCategoriasIdSubCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategoriasSubCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategoriasEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvCategoriasEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlCategorias.SuspendLayout();
            this.tblCategorias.SuspendLayout();
            this.gpxCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCategorias
            // 
            this.pnlCategorias.Controls.Add(this.tblCategorias);
            this.pnlCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategorias.Location = new System.Drawing.Point(0, 0);
            this.pnlCategorias.Name = "pnlCategorias";
            this.pnlCategorias.Size = new System.Drawing.Size(584, 501);
            this.pnlCategorias.TabIndex = 1;
            // 
            // tblCategorias
            // 
            this.tblCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblCategorias.ColumnCount = 1;
            this.tblCategorias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCategorias.Controls.Add(this.gpxCategorias, 0, 0);
            this.tblCategorias.Controls.Add(this.dgvCategorias, 0, 1);
            this.tblCategorias.Location = new System.Drawing.Point(12, 12);
            this.tblCategorias.Name = "tblCategorias";
            this.tblCategorias.RowCount = 2;
            this.tblCategorias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblCategorias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCategorias.Size = new System.Drawing.Size(560, 477);
            this.tblCategorias.TabIndex = 0;
            // 
            // gpxCategorias
            // 
            this.gpxCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxCategorias.Controls.Add(this.lblSubCategoria);
            this.gpxCategorias.Controls.Add(this.cmbSubCategoria);
            this.gpxCategorias.Controls.Add(this.btnCategoriasAgregar);
            this.gpxCategorias.Controls.Add(this.txtCategoriasNombre);
            this.gpxCategorias.Controls.Add(this.lblCategoriaNombre);
            this.gpxCategorias.Location = new System.Drawing.Point(3, 3);
            this.gpxCategorias.Name = "gpxCategorias";
            this.gpxCategorias.Size = new System.Drawing.Size(554, 94);
            this.gpxCategorias.TabIndex = 0;
            this.gpxCategorias.TabStop = false;
            this.gpxCategorias.Text = "Agregar Categoría";
            // 
            // lblSubCategoria
            // 
            this.lblSubCategoria.AutoSize = true;
            this.lblSubCategoria.Location = new System.Drawing.Point(10, 52);
            this.lblSubCategoria.Name = "lblSubCategoria";
            this.lblSubCategoria.Size = new System.Drawing.Size(81, 15);
            this.lblSubCategoria.TabIndex = 3;
            this.lblSubCategoria.Text = "Sub Categoría";
            // 
            // cmbSubCategoria
            // 
            this.cmbSubCategoria.FormattingEnabled = true;
            this.cmbSubCategoria.Location = new System.Drawing.Point(97, 49);
            this.cmbSubCategoria.Name = "cmbSubCategoria";
            this.cmbSubCategoria.Size = new System.Drawing.Size(200, 23);
            this.cmbSubCategoria.TabIndex = 4;
            // 
            // btnCategoriasAgregar
            // 
            this.btnCategoriasAgregar.Location = new System.Drawing.Point(444, 19);
            this.btnCategoriasAgregar.Name = "btnCategoriasAgregar";
            this.btnCategoriasAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnCategoriasAgregar.TabIndex = 2;
            this.btnCategoriasAgregar.Text = "Agregar";
            this.btnCategoriasAgregar.UseVisualStyleBackColor = true;
            this.btnCategoriasAgregar.Click += new System.EventHandler(this.btnCategoriasAgregar_Click);
            // 
            // txtCategoriasNombre
            // 
            this.txtCategoriasNombre.Location = new System.Drawing.Point(97, 20);
            this.txtCategoriasNombre.Name = "txtCategoriasNombre";
            this.txtCategoriasNombre.Size = new System.Drawing.Size(331, 23);
            this.txtCategoriasNombre.TabIndex = 1;
            // 
            // lblCategoriaNombre
            // 
            this.lblCategoriaNombre.AutoSize = true;
            this.lblCategoriaNombre.Location = new System.Drawing.Point(10, 23);
            this.lblCategoriaNombre.Name = "lblCategoriaNombre";
            this.lblCategoriaNombre.Size = new System.Drawing.Size(51, 15);
            this.lblCategoriaNombre.TabIndex = 0;
            this.lblCategoriaNombre.Text = "Nombre";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCategoriasId,
            this.dgvCategoriasNombre,
            this.dgvSubCategoriasIdSubCategoria,
            this.dgvCategoriasSubCategoria,
            this.dgvCategoriasEditar,
            this.dgvCategoriasEliminar});
            this.dgvCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategorias.Location = new System.Drawing.Point(3, 103);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowTemplate.Height = 25;
            this.dgvCategorias.Size = new System.Drawing.Size(554, 371);
            this.dgvCategorias.TabIndex = 1;
            this.dgvCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellClick);
            // 
            // dgvCategoriasId
            // 
            this.dgvCategoriasId.DataPropertyName = "Id";
            this.dgvCategoriasId.HeaderText = "IdCategoria";
            this.dgvCategoriasId.Name = "dgvCategoriasId";
            this.dgvCategoriasId.Visible = false;
            // 
            // dgvCategoriasNombre
            // 
            this.dgvCategoriasNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCategoriasNombre.DataPropertyName = "Nombre";
            this.dgvCategoriasNombre.HeaderText = "Nombre";
            this.dgvCategoriasNombre.Name = "dgvCategoriasNombre";
            // 
            // dgvSubCategoriasIdSubCategoria
            // 
            this.dgvSubCategoriasIdSubCategoria.DataPropertyName = "IdSubCategoria";
            this.dgvSubCategoriasIdSubCategoria.HeaderText = "IdSubCategoria";
            this.dgvSubCategoriasIdSubCategoria.Name = "dgvSubCategoriasIdSubCategoria";
            this.dgvSubCategoriasIdSubCategoria.Visible = false;
            // 
            // dgvCategoriasSubCategoria
            // 
            this.dgvCategoriasSubCategoria.DataPropertyName = "SubCategoria";
            this.dgvCategoriasSubCategoria.HeaderText = "Sub Categoria";
            this.dgvCategoriasSubCategoria.Name = "dgvCategoriasSubCategoria";
            // 
            // dgvCategoriasEditar
            // 
            this.dgvCategoriasEditar.HeaderText = "Editar";
            this.dgvCategoriasEditar.MinimumWidth = 64;
            this.dgvCategoriasEditar.Name = "dgvCategoriasEditar";
            // 
            // dgvCategoriasEliminar
            // 
            this.dgvCategoriasEliminar.HeaderText = "Eliminar";
            this.dgvCategoriasEliminar.MinimumWidth = 64;
            this.dgvCategoriasEliminar.Name = "dgvCategoriasEliminar";
            // 
            // Frm_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 501);
            this.Controls.Add(this.pnlCategorias);
            this.Name = "Frm_Categorias";
            this.Text = "Mantenedor de Categorías";
            this.Load += new System.EventHandler(this.Frm_Categorias_Load);
            this.pnlCategorias.ResumeLayout(false);
            this.tblCategorias.ResumeLayout(false);
            this.gpxCategorias.ResumeLayout(false);
            this.gpxCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCategorias;
        private System.Windows.Forms.TableLayoutPanel tblCategorias;
        private System.Windows.Forms.GroupBox gpxCategorias;
        private System.Windows.Forms.Button btnCategoriasAgregar;
        private System.Windows.Forms.TextBox txtCategoriasNombre;
        private System.Windows.Forms.Label lblCategoriaNombre;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.ComboBox cmbSubCategoria;
        private System.Windows.Forms.Label lblSubCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategoriasId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategoriasNombre;
        private System.Windows.Forms.DataGridViewImageColumn dgvCategoriasEditar;
        private System.Windows.Forms.DataGridViewImageColumn dgvCategoriasEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubCategoriasIdSubCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategoriasSubCategoria;
    }
}