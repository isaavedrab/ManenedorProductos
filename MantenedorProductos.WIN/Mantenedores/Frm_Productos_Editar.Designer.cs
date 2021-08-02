
namespace MantenedorProductos.WIN.Mantenedores
{
    partial class Frm_Productos_Editar
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
            this.pnlProductosEditar = new System.Windows.Forms.Panel();
            this.nupProductosEditarPrecio = new System.Windows.Forms.NumericUpDown();
            this.btnProductosEditarActualizar = new System.Windows.Forms.Button();
            this.btnProductosEditarCancelar = new System.Windows.Forms.Button();
            this.lblProductosEditarPrecio = new System.Windows.Forms.Label();
            this.lblProductosEditarMarca = new System.Windows.Forms.Label();
            this.cmbProductosEditarCategoria = new System.Windows.Forms.ComboBox();
            this.cmbProductosEditarMarca = new System.Windows.Forms.ComboBox();
            this.lblProductosEditarCategoria = new System.Windows.Forms.Label();
            this.txtProductosEditarCodBarra = new System.Windows.Forms.TextBox();
            this.lblProductosEditarCodBarra = new System.Windows.Forms.Label();
            this.txtProductosEditarNombre = new System.Windows.Forms.TextBox();
            this.lblProductosEditarNombre = new System.Windows.Forms.Label();
            this.pnlProductosEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupProductosEditarPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProductosEditar
            // 
            this.pnlProductosEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProductosEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProductosEditar.Controls.Add(this.nupProductosEditarPrecio);
            this.pnlProductosEditar.Controls.Add(this.btnProductosEditarActualizar);
            this.pnlProductosEditar.Controls.Add(this.btnProductosEditarCancelar);
            this.pnlProductosEditar.Controls.Add(this.lblProductosEditarPrecio);
            this.pnlProductosEditar.Controls.Add(this.lblProductosEditarMarca);
            this.pnlProductosEditar.Controls.Add(this.cmbProductosEditarCategoria);
            this.pnlProductosEditar.Controls.Add(this.cmbProductosEditarMarca);
            this.pnlProductosEditar.Controls.Add(this.lblProductosEditarCategoria);
            this.pnlProductosEditar.Controls.Add(this.txtProductosEditarCodBarra);
            this.pnlProductosEditar.Controls.Add(this.lblProductosEditarCodBarra);
            this.pnlProductosEditar.Controls.Add(this.txtProductosEditarNombre);
            this.pnlProductosEditar.Controls.Add(this.lblProductosEditarNombre);
            this.pnlProductosEditar.Location = new System.Drawing.Point(12, 12);
            this.pnlProductosEditar.Name = "pnlProductosEditar";
            this.pnlProductosEditar.Size = new System.Drawing.Size(310, 237);
            this.pnlProductosEditar.TabIndex = 0;
            // 
            // nupProductosEditarPrecio
            // 
            this.nupProductosEditarPrecio.InterceptArrowKeys = false;
            this.nupProductosEditarPrecio.Location = new System.Drawing.Point(93, 84);
            this.nupProductosEditarPrecio.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nupProductosEditarPrecio.Name = "nupProductosEditarPrecio";
            this.nupProductosEditarPrecio.Size = new System.Drawing.Size(200, 23);
            this.nupProductosEditarPrecio.TabIndex = 13;
            this.nupProductosEditarPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnProductosEditarActualizar
            // 
            this.btnProductosEditarActualizar.Location = new System.Drawing.Point(199, 203);
            this.btnProductosEditarActualizar.Name = "btnProductosEditarActualizar";
            this.btnProductosEditarActualizar.Size = new System.Drawing.Size(100, 23);
            this.btnProductosEditarActualizar.TabIndex = 11;
            this.btnProductosEditarActualizar.Text = "Actualizar";
            this.btnProductosEditarActualizar.UseVisualStyleBackColor = true;
            this.btnProductosEditarActualizar.Click += new System.EventHandler(this.BtnProductosEditarActualizarClick);
            // 
            // btnProductosEditarCancelar
            // 
            this.btnProductosEditarCancelar.Location = new System.Drawing.Point(93, 203);
            this.btnProductosEditarCancelar.Name = "btnProductosEditarCancelar";
            this.btnProductosEditarCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnProductosEditarCancelar.TabIndex = 10;
            this.btnProductosEditarCancelar.Text = "Cancelar";
            this.btnProductosEditarCancelar.UseVisualStyleBackColor = true;
            this.btnProductosEditarCancelar.Click += new System.EventHandler(this.BtnProductosEditarCancelarClick);
            // 
            // lblProductosEditarPrecio
            // 
            this.lblProductosEditarPrecio.AutoSize = true;
            this.lblProductosEditarPrecio.Location = new System.Drawing.Point(10, 86);
            this.lblProductosEditarPrecio.Name = "lblProductosEditarPrecio";
            this.lblProductosEditarPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblProductosEditarPrecio.TabIndex = 9;
            this.lblProductosEditarPrecio.Text = "Precio";
            // 
            // lblProductosEditarMarca
            // 
            this.lblProductosEditarMarca.AutoSize = true;
            this.lblProductosEditarMarca.Location = new System.Drawing.Point(10, 115);
            this.lblProductosEditarMarca.Name = "lblProductosEditarMarca";
            this.lblProductosEditarMarca.Size = new System.Drawing.Size(40, 15);
            this.lblProductosEditarMarca.TabIndex = 7;
            this.lblProductosEditarMarca.Text = "Marca";
            // 
            // cmbProductosEditarCategoria
            // 
            this.cmbProductosEditarCategoria.FormattingEnabled = true;
            this.cmbProductosEditarCategoria.Location = new System.Drawing.Point(93, 141);
            this.cmbProductosEditarCategoria.Name = "cmbProductosEditarCategoria";
            this.cmbProductosEditarCategoria.Size = new System.Drawing.Size(200, 23);
            this.cmbProductosEditarCategoria.TabIndex = 6;
            // 
            // cmbProductosEditarMarca
            // 
            this.cmbProductosEditarMarca.FormattingEnabled = true;
            this.cmbProductosEditarMarca.Location = new System.Drawing.Point(93, 112);
            this.cmbProductosEditarMarca.Name = "cmbProductosEditarMarca";
            this.cmbProductosEditarMarca.Size = new System.Drawing.Size(200, 23);
            this.cmbProductosEditarMarca.TabIndex = 5;
            // 
            // lblProductosEditarCategoria
            // 
            this.lblProductosEditarCategoria.AutoSize = true;
            this.lblProductosEditarCategoria.Location = new System.Drawing.Point(10, 144);
            this.lblProductosEditarCategoria.Name = "lblProductosEditarCategoria";
            this.lblProductosEditarCategoria.Size = new System.Drawing.Size(58, 15);
            this.lblProductosEditarCategoria.TabIndex = 4;
            this.lblProductosEditarCategoria.Text = "Categoría";
            // 
            // txtProductosEditarCodBarra
            // 
            this.txtProductosEditarCodBarra.Location = new System.Drawing.Point(93, 54);
            this.txtProductosEditarCodBarra.Name = "txtProductosEditarCodBarra";
            this.txtProductosEditarCodBarra.Size = new System.Drawing.Size(200, 23);
            this.txtProductosEditarCodBarra.TabIndex = 3;
            // 
            // lblProductosEditarCodBarra
            // 
            this.lblProductosEditarCodBarra.AutoSize = true;
            this.lblProductosEditarCodBarra.Location = new System.Drawing.Point(10, 57);
            this.lblProductosEditarCodBarra.Name = "lblProductosEditarCodBarra";
            this.lblProductosEditarCodBarra.Size = new System.Drawing.Size(62, 15);
            this.lblProductosEditarCodBarra.TabIndex = 2;
            this.lblProductosEditarCodBarra.Text = "Cód. Barra";
            // 
            // txtProductosEditarNombre
            // 
            this.txtProductosEditarNombre.Location = new System.Drawing.Point(93, 25);
            this.txtProductosEditarNombre.Name = "txtProductosEditarNombre";
            this.txtProductosEditarNombre.Size = new System.Drawing.Size(200, 23);
            this.txtProductosEditarNombre.TabIndex = 1;
            // 
            // lblProductosEditarNombre
            // 
            this.lblProductosEditarNombre.AutoSize = true;
            this.lblProductosEditarNombre.Location = new System.Drawing.Point(10, 28);
            this.lblProductosEditarNombre.Name = "lblProductosEditarNombre";
            this.lblProductosEditarNombre.Size = new System.Drawing.Size(51, 15);
            this.lblProductosEditarNombre.TabIndex = 0;
            this.lblProductosEditarNombre.Text = "Nombre";
            // 
            // Frm_Productos_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.pnlProductosEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_Productos_Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Producto";            
            this.pnlProductosEditar.ResumeLayout(false);
            this.pnlProductosEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupProductosEditarPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProductosEditar;
        private System.Windows.Forms.TextBox txtProductosEditarCodBarra;
        private System.Windows.Forms.Label lblProductosEditarCodBarra;
        private System.Windows.Forms.TextBox txtProductosEditarNombre;
        private System.Windows.Forms.Label lblProductosEditarNombre;
        private System.Windows.Forms.Label lblProductosEditarMarca;
        private System.Windows.Forms.ComboBox cmbProductosEditarCategoria;
        private System.Windows.Forms.ComboBox cmbProductosEditarMarca;
        private System.Windows.Forms.Label lblProductosEditarCategoria;
        private System.Windows.Forms.Label lblProductosEditarPrecio;
        private System.Windows.Forms.Button btnProductosEditarCancelar;
        private System.Windows.Forms.Button btnProductosEditarActualizar;
        private System.Windows.Forms.NumericUpDown nupProductosEditarPrecio;
    }
}