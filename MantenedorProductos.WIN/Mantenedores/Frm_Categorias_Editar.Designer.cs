
namespace MantenedorProductos.WIN.Mantenedores
{
    partial class Frm_Categorias_Editar
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
            this.pnlCategoriasEditar = new System.Windows.Forms.Panel();
            this.btnCategoriaEditarActualizar = new System.Windows.Forms.Button();
            this.btnCategoriasEditarCancelar = new System.Windows.Forms.Button();
            this.cmbCategoriasEditarSubCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoriasEditarSubCategoria = new System.Windows.Forms.Label();
            this.txtCategoriasEditarNombre = new System.Windows.Forms.TextBox();
            this.lblCategoriasEditarNombre = new System.Windows.Forms.Label();
            this.pnlCategoriasEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCategoriasEditar
            // 
            this.pnlCategoriasEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCategoriasEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCategoriasEditar.Controls.Add(this.btnCategoriaEditarActualizar);
            this.pnlCategoriasEditar.Controls.Add(this.btnCategoriasEditarCancelar);
            this.pnlCategoriasEditar.Controls.Add(this.cmbCategoriasEditarSubCategoria);
            this.pnlCategoriasEditar.Controls.Add(this.lblCategoriasEditarSubCategoria);
            this.pnlCategoriasEditar.Controls.Add(this.txtCategoriasEditarNombre);
            this.pnlCategoriasEditar.Controls.Add(this.lblCategoriasEditarNombre);
            this.pnlCategoriasEditar.Location = new System.Drawing.Point(12, 12);
            this.pnlCategoriasEditar.Name = "pnlCategoriasEditar";
            this.pnlCategoriasEditar.Size = new System.Drawing.Size(410, 137);
            this.pnlCategoriasEditar.TabIndex = 1;
            // 
            // btnCategoriaEditarActualizar
            // 
            this.btnCategoriaEditarActualizar.Location = new System.Drawing.Point(298, 103);
            this.btnCategoriaEditarActualizar.Name = "btnCategoriaEditarActualizar";
            this.btnCategoriaEditarActualizar.Size = new System.Drawing.Size(100, 23);
            this.btnCategoriaEditarActualizar.TabIndex = 11;
            this.btnCategoriaEditarActualizar.Text = "Actualizar";
            this.btnCategoriaEditarActualizar.UseVisualStyleBackColor = true;
            this.btnCategoriaEditarActualizar.Click += new System.EventHandler(this.btnCategoriaEditarActualizar_Click);
            // 
            // btnCategoriasEditarCancelar
            // 
            this.btnCategoriasEditarCancelar.Location = new System.Drawing.Point(192, 103);
            this.btnCategoriasEditarCancelar.Name = "btnCategoriasEditarCancelar";
            this.btnCategoriasEditarCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCategoriasEditarCancelar.TabIndex = 10;
            this.btnCategoriasEditarCancelar.Text = "Cancelar";
            this.btnCategoriasEditarCancelar.UseVisualStyleBackColor = true;
            this.btnCategoriasEditarCancelar.Click += new System.EventHandler(this.btnCategoriasEditarCancelar_Click);
            // 
            // cmbCategoriasEditarSubCategoria
            // 
            this.cmbCategoriasEditarSubCategoria.FormattingEnabled = true;
            this.cmbCategoriasEditarSubCategoria.Location = new System.Drawing.Point(98, 54);
            this.cmbCategoriasEditarSubCategoria.Name = "cmbCategoriasEditarSubCategoria";
            this.cmbCategoriasEditarSubCategoria.Size = new System.Drawing.Size(200, 23);
            this.cmbCategoriasEditarSubCategoria.TabIndex = 6;
            // 
            // lblCategoriasEditarSubCategoria
            // 
            this.lblCategoriasEditarSubCategoria.AutoSize = true;
            this.lblCategoriasEditarSubCategoria.Location = new System.Drawing.Point(10, 57);
            this.lblCategoriasEditarSubCategoria.Name = "lblCategoriasEditarSubCategoria";
            this.lblCategoriasEditarSubCategoria.Size = new System.Drawing.Size(81, 15);
            this.lblCategoriasEditarSubCategoria.TabIndex = 4;
            this.lblCategoriasEditarSubCategoria.Text = "Sub Categoría";
            // 
            // txtCategoriasEditarNombre
            // 
            this.txtCategoriasEditarNombre.Location = new System.Drawing.Point(98, 25);
            this.txtCategoriasEditarNombre.Name = "txtCategoriasEditarNombre";
            this.txtCategoriasEditarNombre.Size = new System.Drawing.Size(300, 23);
            this.txtCategoriasEditarNombre.TabIndex = 1;
            // 
            // lblCategoriasEditarNombre
            // 
            this.lblCategoriasEditarNombre.AutoSize = true;
            this.lblCategoriasEditarNombre.Location = new System.Drawing.Point(10, 28);
            this.lblCategoriasEditarNombre.Name = "lblCategoriasEditarNombre";
            this.lblCategoriasEditarNombre.Size = new System.Drawing.Size(51, 15);
            this.lblCategoriasEditarNombre.TabIndex = 0;
            this.lblCategoriasEditarNombre.Text = "Nombre";
            // 
            // Frm_Categorias_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 161);
            this.Controls.Add(this.pnlCategoriasEditar);
            this.MinimizeBox = false;
            this.Name = "Frm_Categorias_Editar";
            this.Text = "Editar Categoría";
            this.pnlCategoriasEditar.ResumeLayout(false);
            this.pnlCategoriasEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCategoriasEditar;
        private System.Windows.Forms.Button btnCategoriaEditarActualizar;
        private System.Windows.Forms.Button btnCategoriasEditarCancelar;
        private System.Windows.Forms.ComboBox cmbCategoriasEditarSubCategoria;
        private System.Windows.Forms.Label lblCategoriasEditarSubCategoria;
        private System.Windows.Forms.TextBox txtCategoriasEditarNombre;
        private System.Windows.Forms.Label lblCategoriasEditarNombre;
    }
}