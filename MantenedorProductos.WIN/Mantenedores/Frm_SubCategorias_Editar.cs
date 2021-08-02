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
    public partial class Frm_SubCategorias_Editar : Form
    {
        private readonly RestClient _client = new RestClient("http://localhost:55295");
        public Frm_SubCategorias_Editar(SubCategoriaVM subCategoria)
        {
            InitializeComponent();
            Cargar(subCategoria);
        }
        public void Cargar(SubCategoriaVM subCategoria)
        {
            if (subCategoria != null)
            {
                IdSubCategoria = subCategoria.Id;
                txtSubCategoriasEditarNombre.Text = subCategoria.Nombre;
            }
        }

        public Guid? IdSubCategoria { get; set; }
        private void btnSubCategoriasEditarActualizar_Click(object sender, EventArgs e)
        {
            var request = new RestRequest($"api/subcategorias/" + IdSubCategoria.Value.ToString(), Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            var body = JsonConvert.SerializeObject(new
            {
                Nombre = txtSubCategoriasEditarNombre.Text,
            });
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = _client.Execute(request);

            if (response.StatusCode.Equals(System.Net.HttpStatusCode.OK))
            {
                MessageBox.Show("La Sub Categoría se ha actualizado correctamente.",
                                              "Mantenedor de Sub Categorías",
                                              MessageBoxButtons.OK);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(response.Content,
                                              "Mantenedor de Sub Categorías",
                                              MessageBoxButtons.OK);
            }
        }

        private void btnSubCategoriasEditarCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
