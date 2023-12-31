using Google.Protobuf.WellKnownTypes;
using ImplementacaoRedesEletricasInteligentes.Models;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.Crmf;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Method = RestSharp.Method;

namespace ImplementacaoRedesEletricasInteligentes.Classes
{
    public class ProjetoServices
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string inicio { get; set; }
        public string termino { get; set; }
        public double custo { get; set; }
        string ProjetoUrl = "https://localhost:7034/api/Projetos";

        //Método para consultar os projetos cadastrados
        public async Task<List<ProjetoUI>> ObterProjetosAsync()
        {
            var client = new RestClient();
            var request = new RestRequest(ProjetoUrl, Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<List<ProjetoUI>>
                    (response.Content);
            else
                return null;
        }

        //Método para consultar um projeto específico com o ID
        public async Task<List<ProjetoUI>> ObterProjetoIDAsync(int id)
        {
            var client = new RestClient();
            var request = new RestRequest(ProjetoUrl + "/" + id, Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<List<ProjetoUI>>
                    (response.Content);
            else
                return null;
        }

        //Método para cadastrar os projetos
        public async Task<ProjetoUI> CadastrarProjetoAsync(ProjetoUI projeto)
        {
            var client = new RestClient();
            var request = new RestRequest(ProjetoUrl, Method.Post);

            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(projeto);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessStatusCode)
                MessageBox.Show("Projeto adicionado com sucesso!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Falha ao adicionar o projeto!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return projeto;
        }

        //Método para editar os projetos
        public async Task<bool> EditarProjetoAsync(ProjetoUI projeto)
        {
            var client = new RestClient();
            var request = new RestRequest(ProjetoUrl + "/" + id, Method.Put);

            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(projeto);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Projeto editado com sucesso!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Falha ao editar o projeto!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        //Método para excluir os projetos
        public async Task<bool> DeletarProjetoAsync(ProjetoUI projeto)
        {
            var client = new RestClient();
            var request = new RestRequest(ProjetoUrl + "/" + id, Method.Delete);

            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(projeto);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Projeto excluido com sucesso!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Falha ao excluir o projeto!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }
    }
}
