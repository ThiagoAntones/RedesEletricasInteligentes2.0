using ImplementacaoRedesEletricasInteligentes.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementacaoRedesEletricasInteligentes.Classes
{
    public class Nivel1Services
    {
        public int id { get; set; }
        public int projeto { get; set; }
        public string descricao { get; set; }
        string Nivel1Url = "https://localhost:7034/api/Nivel1";

        //Método para consultar o nível 1 cadastrado
        public async Task<List<Nivel1UI>> ObterNivel1Async()
        {
            var client = new RestClient();
            var request = new RestRequest(Nivel1Url, Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<List<Nivel1UI>>
                    (response.Content);
            else
                return null;
        }

        //Método para consultar um nível 1 específico com o ID
        public async Task<List<Nivel1UI>> ObterNivel1IDAsync(int id)
        {
            var client = new RestClient();
            var request = new RestRequest(Nivel1Url + "/" + id, Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<List<Nivel1UI>>
                    (response.Content);
            else
                return null;
        }

        //Método para cadastrar o nível 1
        public async Task<Nivel1UI> CadastrarNivel1Async(Nivel1UI nivel1)
        {
            var client = new RestClient();
            var request = new RestRequest(Nivel1Url, Method.Post);

            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(nivel1);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessStatusCode)
                MessageBox.Show("Nível 1 adicionado com sucesso!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Falha ao adicionar o nível 1!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return nivel1;
        }

        //Método para editar o nível 1
        public async Task<bool> EditarNivel1Async(Nivel1UI nivel1)
        {
            var client = new RestClient();
            var request = new RestRequest(Nivel1Url + "/" + nivel1.id, Method.Put);

            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(nivel1);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Nível 1 editado com sucesso!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Falha ao editar o nível 1!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        //Método para excluir o nível 1
        public async Task<bool> DeletarNivel1Async(Nivel1UI nivel1)
        {
            var client = new RestClient();
            var request = new RestRequest(Nivel1Url + "/" + nivel1.id, Method.Delete);

            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(nivel1);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Nível 1 excluido com sucesso!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Falha ao excluir o nível 1!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }
    }
}
