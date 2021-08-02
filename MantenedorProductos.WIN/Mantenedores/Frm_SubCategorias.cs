using MantenedorProductos.WIN.VModels;
using Newtonsoft.Json;
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
    public partial class Frm_SubCategorias : Form
    {        
        private readonly RestClient _client = new RestClient("http://localhost:55295");
        public Frm_SubCategorias()
        {
            InitializeComponent();
            dgvSubCategorias.AutoGenerateColumns = false;
        }
        #region CRUD
        public void Agregar(SubCategoriaVM subCategoria)
        {
            var request = new RestRequest($"api/subcategorias", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            var body = JsonConvert.SerializeObject(subCategoria);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = _client.Execute(request);
            if (response.StatusCode.Equals(System.Net.HttpStatusCode.OK))
            {
                Nombre = string.Empty;
                Buscar();

                MessageBox.Show("La Sub Categoría se ha agregado correctamente.",
                                          "Mantenedor de Sub Categorías",
                                          MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(response.Content,
                                          "Mantenedor de Sub Categorías",
                                          MessageBoxButtons.OK);
            }
        }
        public void Eliminar(Guid? idSubCategoria)
        {
            if (_client != null && (idSubCategoria != null && idSubCategoria != Guid.Empty))
            {
                var request = new RestRequest($"api/subcategorias/" + idSubCategoria, Method.DELETE);
                var response = _client.Execute(request);
                if (response.StatusCode.Equals(System.Net.HttpStatusCode.OK))
                {
                    Buscar();
                }
                else
                {
                    MessageBox.Show(response.Content,
                                       "Mantenedor de Sub Categorías",
                                       MessageBoxButtons.OK);
                }
            }
        }
        public void Buscar()
        {
            var request = new RestRequest($"api/subcategorias", Method.GET);
            var response = _client.Execute(request);
            SubCategorias = JsonConvert.DeserializeObject<List<SubCategoriaVM>>(response.Content);
        }
        #endregion

        #region PROPERTIES
        public string Nombre { get => txtSubCategoriasNombre.Text; set { txtSubCategoriasNombre.Text = value; } }
        public List<SubCategoriaVM> SubCategorias
        {
            get => dgvSubCategorias.DataSource != null ? (List<SubCategoriaVM>)dgvSubCategorias.DataSource : new List<SubCategoriaVM>();
            set => dgvSubCategorias.DataSource = value;
        }
        #endregion

        private void btnSubCategoriasAgregar_Click(object sender, EventArgs e)
        {
            Agregar(new SubCategoriaVM() { Id = null, Nombre = Nombre });
        }

        private void dgvSubCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSubCategorias.DataSource == null)
                return;
            if (e.RowIndex != -1)
            {
                var item = (SubCategoriaVM)dgvSubCategorias.Rows[e.RowIndex].DataBoundItem;
                switch (e.ColumnIndex)
                {
                    case 2:
                        //var frm = Application.OpenForms.OfType<Frm_Principal>().FirstOrDefault();
                        Frm_SubCategorias_Editar f = new Frm_SubCategorias_Editar(item);
                        //f.MdiParent = this.MdiParent;
                        switch (f.ShowDialog())
                        {
                            case DialogResult.OK:
                                Buscar();
                                break;
                            case DialogResult.Cancel:
                                break;
                        }
                        break;
                    case 3:
                        DialogResult confirmar = MessageBox.Show("¿Desea eliminar la Sub Categoría seleccionada? " + item.Nombre + ".",
                                       "Mantenedor de Sub Categorías",
                                       MessageBoxButtons.YesNo);
                        if (confirmar.Equals(DialogResult.Yes))
                        {
                            Eliminar(item.Id);
                        }
                        break;
                    default: break;
                }
            }
        }

        private void Frm_SubCategorias_Load(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
