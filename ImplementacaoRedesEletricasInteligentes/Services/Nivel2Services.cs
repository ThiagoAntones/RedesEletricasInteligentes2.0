using ImplementacaoRedesEletricasInteligentes.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementacaoRedesEletricasInteligentes.Classes
{
    public class Nivel2Services
    {
        public int id { get; set; }
        public int projeto { get; set; }
        public int nivel1 { get; set; }
        public string descricao { get; set; }
        string Nivel2Url = "https://localhost:7034/api/Nivel2";

        //Método para consultar todos os nível 2 cadastrados
        public async Task<List<Nivel2UI>> ObterNivel2Async()
        {
            var client = new RestClient();
            var request = new RestRequest(Nivel2Url, Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<List<Nivel2UI>>
                    (response.Content);
            else
                return null;
        }

        //Método para consultar um nível 2 específico com o ID
        public async Task<List<Nivel2UI>> ObterNivel2IDAsync(int id)
        {
            var client = new RestClient();
            var request = new RestRequest(Nivel2Url + "/" + id, Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<List<Nivel2UI>>
                    (response.Content);
            else
                return null;
        }

        //Método para cadastrar o nível 2
        public async Task<Nivel2UI> CadastrarNivel2Async(Nivel2UI nivel2)
        {
            var client = new RestClient();
            var request = new RestRequest(Nivel2Url, Method.Post);

            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(nivel2);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessStatusCode)
                MessageBox.Show("Nível 2 adicionado com sucesso!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Falha ao adicionar o nível 2!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return nivel2;
        }

        //Método para editar o nível 2
        public async Task<bool> EditarNivel2Async(Nivel2UI nivel2)
        {
            var client = new RestClient();
            var request = new RestRequest(Nivel2Url + "/" + nivel2.id, Method.Put);

            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(nivel2);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Nível 2 editado com sucesso!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Falha ao editar o nível 2!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        //Método para excluir o nível 2
        public async Task<bool> DeletarNivel2Async(Nivel2UI nivel2)
        {
            var client = new RestClient();
            var request = new RestRequest(Nivel2Url + "/" + nivel2.id, Method.Delete);

            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(nivel2);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Nível 2 excluido com sucesso!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Falha ao excluir o nível 2!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }
    }

}
