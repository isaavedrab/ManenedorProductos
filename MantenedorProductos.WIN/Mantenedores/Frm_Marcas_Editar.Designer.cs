
namespace MantenedorProductos.WIN.Mantenedores
{
    partial class Frm_Marcas_Editar
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
            this.pnlMarcasEditar = new System.Windows.Forms.Panel();
            this.btnMarcasEditarActualizar = new System.Windows.Forms.Button();
            this.btnMarcasEditarCancelar = new System.Windows.Forms.Button();
            this.txtMarcasEditarNombre = new System.Windows.Forms.TextBox();
            this.lblMarcasEditarNombre = new System.Windows.Forms.Label();
            this.pnlMarcasEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMarcasEditar
            // 
            this.pnlMarcasEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMarcasEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMarcasEditar.Controls.Add(this.btnMarcasEditarActualizar);
            this.pnlMarcasEditar.Controls.Add(this.btnMarcasEditarCancelar);
            this.pnlMarcasEditar.Controls.Add(this.txtMarcasEditarNombre);
            this.pnlMarcasEditar.Controls.Add(this.lblMarcasEditarNombre);
            this.pnlMarcasEditar.Location = new System.Drawing.Point(12, 12);
            this.pnlMarcasEditar.Name = "pnlMarcasEditar";
            this.pnlMarcasEditar.Size = new System.Drawing.Size(410, 97);
            this.pnlMarcasEditar.TabIndex = 2;
            // 
            // btnMarcasEditarActualizar
            // 
            this.btnMarcasEditarActualizar.Location = new System.Drawing.Point(299, 63);
            this.btnMarcasEditarActualizar.Name = "btnMarcasEditarActualizar";
            this.btnMarcasEditarActualizar.Size = new System.Drawing.Size(100, 23);
            this.btnMarcasEditarActualizar.TabIndex = 11;
            this.btnMarcasEditarActualizar.Text = "Actualizar";
            this.btnMarcasEditarActualizar.UseVisualStyleBackColor = true;
            this.btnMarcasEditarActualizar.Click += new System.EventHandler(this.btnMarcasEditarActualizar_Click);
            // 
            // btnMarcasEditarCancelar
            // 
            this.btnMarcasEditarCancelar.Location = new System.Drawing.Point(193, 63);
            this.btnMarcasEditarCancelar.Name = "btnMarcasEditarCancelar";
            this.btnMarcasEditarCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnMarcasEditarCancelar.TabIndex = 10;
            this.btnMarcasEditarCancelar.Text = "Cancelar";
            this.btnMarcasEditarCancelar.UseVisualStyleBackColor = true;
            this.btnMarcasEditarCancelar.Click += new System.EventHandler(this.btnMarcasEditarCancelar_Click);
            // 
            // txtMarcasEditarNombre
            // 
            this.txtMarcasEditarNombre.Location = new System.Drawing.Point(98, 25);
            this.txtMarcasEditarNombre.Name = "txtMarcasEditarNombre";
            this.txtMarcasEditarNombre.Size = new System.Drawing.Size(300, 23);
            this.txtMarcasEditarNombre.TabIndex = 1;
            // 
            // lblMarcasEditarNombre
            // 
            this.lblMarcasEditarNombre.AutoSize = true;
            this.lblMarcasEditarNombre.Location = new System.Drawing.Point(10, 28);
            this.lblMarcasEditarNombre.Name = "lblMarcasEditarNombre";
            this.lblMarcasEditarNombre.Size = new System.Drawing.Size(51, 15);
            this.lblMarcasEditarNombre.TabIndex = 0;
            this.lblMarcasEditarNombre.Text = "Nombre";
            // 
            // Frm_Marcas_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 121);
            this.Controls.Add(this.pnlMarcasEditar);
            this.MaximizeBox = false;
            this.Name = "Frm_Marcas_Editar";
            this.Text = "Editar Marca";
            this.pnlMarcasEditar.ResumeLayout(false);
            this.pnlMarcasEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMarcasEditar;
        private System.Windows.Forms.Button btnMarcasEditarActualizar;
        private System.Windows.Forms.Button btnMarcasEditarCancelar;
        private System.Windows.Forms.TextBox txtMarcasEditarNombre;
        private System.Windows.Forms.Label lblMarcasEditarNombre;
    }
}