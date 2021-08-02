using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MantenedorProductos.WIN.Mantenedores
{
    public partial class Frm_Marcas : Form
    {
        private readonly RestClient _client = new RestClient("http://localhost:55295");
        public Frm_Marcas()
        {
            InitializeComponent();
            dgvMarcas.AutoGenerateColumns = false;
        }
    }
}
