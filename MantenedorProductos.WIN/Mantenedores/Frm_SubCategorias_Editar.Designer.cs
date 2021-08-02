
namespace MantenedorProductos.WIN.Mantenedores
{
    partial class Frm_SubCategorias_Editar
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
            this.pnlSubCategoriasEditar = new System.Windows.Forms.Panel();
            this.btnSubCategoriasEditarActualizar = new System.Windows.Forms.Button();
            this.btnSubCategoriasEditarCancelar = new System.Windows.Forms.Button();
            this.txtSubCategoriasEditarNombre = new System.Windows.Forms.TextBox();
            this.lblSubCategoriasEditarNombre = new System.Windows.Forms.Label();
            this.pnlSubCategoriasEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSubCategoriasEditar
            // 
            this.pnlSubCategoriasEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSubCategoriasEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSubCategoriasEditar.Controls.Add(this.btnSubCategoriasEditarActualizar);
            this.pnlSubCategoriasEditar.Controls.Add(this.btnSubCategoriasEditarCancelar);
            this.pnlSubCategoriasEditar.Controls.Add(this.txtSubCategoriasEditarNombre);
            this.pnlSubCategoriasEditar.Controls.Add(this.lblSubCategoriasEditarNombre);
            this.pnlSubCategoriasEditar.Location = new System.Drawing.Point(12, 12);
            this.pnlSubCategoriasEditar.Name = "pnlSubCategoriasEditar";
            this.pnlSubCategoriasEditar.Size = new System.Drawing.Size(410, 97);
            this.pnlSubCategoriasEditar.TabIndex = 3;
            // 
            // btnSubCategoriasEditarActualizar
            // 
            this.btnSubCategoriasEditarActualizar.Location = new System.Drawing.Point(299, 63);
            this.btnSubCategoriasEditarActualizar.Name = "btnSubCategoriasEditarActualizar";
            this.btnSubCategoriasEditarActualizar.Size = new System.Drawing.Size(100, 23);
            this.btnSubCategoriasEditarActualizar.TabIndex = 11;
            this.btnSubCategoriasEditarActualizar.Text = "Actualizar";
            this.btnSubCategoriasEditarActualizar.UseVisualStyleBackColor = true;
            this.btnSubCategoriasEditarActualizar.Click += new System.EventHandler(this.btnSubCategoriasEditarActualizar_Click);
            // 
            // btnSubCategoriasEditarCancelar
            // 
            this.btnSubCategoriasEditarCancelar.Location = new System.Drawing.Point(193, 63);
            this.btnSubCategoriasEditarCancelar.Name = "btnSubCategoriasEditarCancelar";
            this.btnSubCategoriasEditarCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnSubCategoriasEditarCancelar.TabIndex = 10;
            this.btnSubCategoriasEditarCancelar.Text = "Cancelar";
            this.btnSubCategoriasEditarCancelar.UseVisualStyleBackColor = true;
            this.btnSubCategoriasEditarCancelar.Click += new System.EventHandler(this.btnSubCategoriasEditarCancelar_Click);
            // 
            // txtSubCategoriasEditarNombre
            // 
            this.txtSubCategoriasEditarNombre.Location = new System.Drawing.Point(98, 25);
            this.txtSubCategoriasEditarNombre.Name = "txtSubCategoriasEditarNombre";
            this.txtSubCategoriasEditarNombre.Size = new System.Drawing.Size(300, 23);
            this.txtSubCategoriasEditarNombre.TabIndex = 1;
            // 
            // lblSubCategoriasEditarNombre
            // 
            this.lblSubCategoriasEditarNombre.AutoSize = true;
            this.lblSubCategoriasEditarNombre.Location = new System.Drawing.Point(10, 28);
            this.lblSubCategoriasEditarNombre.Name = "lblSubCategoriasEditarNombre";
            this.lblSubCategoriasEditarNombre.Size = new System.Drawing.Size(51, 15);
            this.lblSubCategoriasEditarNombre.TabIndex = 0;
            this.lblSubCategoriasEditarNombre.Text = "Nombre";
            // 
            // Frm_SubCategorias_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 121);
            this.Controls.Add(this.pnlSubCategoriasEditar);
            this.MaximizeBox = false;
            this.Name = "Frm_SubCategorias_Editar";
            this.Text = "Editar Sub Categorías ";
            this.pnlSubCategoriasEditar.ResumeLayout(false);
            this.pnlSubCategoriasEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSubCategoriasEditar;
        private System.Windows.Forms.Button btnSubCategoriasEditarActualizar;
        private System.Windows.Forms.Button btnSubCategoriasEditarCancelar;
        private System.Windows.Forms.TextBox txtSubCategoriasEditarNombre;
        private System.Windows.Forms.Label lblSubCategoriasEditarNombre;
    }
}