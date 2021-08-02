using MantenedorProductos.WIN.Mantenedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenedorProductos.WIN
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }
        #region Menú Mantenedores
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Productos f = new Frm_Productos();
            f.MdiParent = this;            
            f.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Marcas f = new Frm_Marcas();
            f.MdiParent = this;            
            f.Show();
        }

        private void subCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_SubCategorias f = new Frm_SubCategorias();
            f.MdiParent = this;            
            f.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Categorias f = new Frm_Categorias();
            f.MdiParent = this;            
            f.Show();
        }
        #endregion
    }
}
