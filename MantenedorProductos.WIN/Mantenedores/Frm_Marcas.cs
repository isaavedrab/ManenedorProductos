using MantenedorProductos.WIN.VModels;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
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
        private void Frm_Marcas_Load(object sender, EventArgs e)
        {
            Buscar();
        }
        #region CRUD
        public void Agregar(MarcaVM marca)
        {
            var request = new RestRequest($"api/marcas", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            var body = JsonConvert.SerializeObject(marca);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = _client.Execute(request);
            if (response.StatusCode.Equals(System.Net.HttpStatusCode.OK))
            {
                Nombre = string.Empty;                
                Buscar();

                MessageBox.Show("La Categoría se ha agregado correctamente.",
                                          "Mantenedor de Categorías",
                                          MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(response.Content,
                                          "Mantenedor de Categorías",
                                          MessageBoxButtons.OK);
            }
        }
        public void Eliminar(Guid? idMarca)
        {
            if (_client != null && (idMarca != null && idMarca != Guid.Empty))
            {
                var request = new RestRequest($"api/marcas/" + idMarca, Method.DELETE);
                var response = _client.Execute(request);
                if (response.StatusCode.Equals(System.Net.HttpStatusCode.OK))
                {
                    Buscar();
                }
                else
                {
                    MessageBox.Show(response.Content,
                                       "Mantenedor de Marcas",
                                       MessageBoxButtons.OK);
                }
            }
        }
        public void Buscar()
        {
            var request = new RestRequest($"api/marcas", Method.GET);
            var response = _client.Execute(request);
            Marcas = JsonConvert.DeserializeObject<List<MarcaVM>>(response.Content);
        }
        #endregion

        #region PROPERTIES
        public string Nombre { get => txtMarcasNombre.Text; set { txtMarcasNombre.Text = value; } }
        public List<MarcaVM> Marcas
        {
            get => dgvMarcas.DataSource != null ? (List<MarcaVM>)dgvMarcas.DataSource : new List<MarcaVM>();
            set => dgvMarcas.DataSource = value;
        }
        #endregion

        #region HANDLERS
        private void dgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMarcas.DataSource == null)
                return;
            if (e.RowIndex != -1)
            {
                var item = (MarcaVM)dgvMarcas.Rows[e.RowIndex].DataBoundItem;
                switch (e.ColumnIndex)
                {
                    case 2:
                        //var frm = Application.OpenForms.OfType<Frm_Principal>().FirstOrDefault();
                        Frm_Marcas_Editar f = new Frm_Marcas_Editar(item);
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
                        DialogResult confirmar = MessageBox.Show("¿Desea eliminar la Marca seleccionada? " + item.Nombre + ".",
                                       "Mantenedor de Marcas",
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

        private void btnMarcasAgregar_Click(object sender, EventArgs e)
        {
            Agregar(new MarcaVM() { Id = null, Nombre = Nombre });
        }
        #endregion
    }
}

