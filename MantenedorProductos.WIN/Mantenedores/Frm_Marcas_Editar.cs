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
    public partial class Frm_Marcas_Editar : Form
    {
        private readonly RestClient _client = new RestClient("http://localhost:55295");
        public Frm_Marcas_Editar(MarcaVM marca)
        {
            InitializeComponent();
            Cargar(marca);
        }
        public void Cargar(MarcaVM marca)
        {
            if (marca != null)
            {
                IdMarca = marca.Id;
                txtMarcasEditarNombre.Text = marca.Nombre;                
            }
        }

        public Guid? IdMarca { get; set; }

        private void btnMarcasEditarActualizar_Click(object sender, EventArgs e)
        {
            var request = new RestRequest($"api/marcas/" + IdMarca.Value.ToString(), Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            var body = JsonConvert.SerializeObject(new
            {
                Nombre = txtMarcasEditarNombre.Text,                
            });
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = _client.Execute(request);

            if (response.StatusCode.Equals(System.Net.HttpStatusCode.OK))
            {
                MessageBox.Show("La Marca se ha actualizado correctamente.",
                                              "Mantenedor de Marcas",
                                              MessageBoxButtons.OK);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(response.Content,
                                              "Mantenedor de Marcas",
                                              MessageBoxButtons.OK);
            }
        }

        private void btnMarcasEditarCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
