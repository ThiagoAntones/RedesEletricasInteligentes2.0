using Google.Protobuf.WellKnownTypes;
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
    public class Projeto
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string inicio { get; set; }
        public string termino { get; set; }
        public double custo { get; set; }

        //Método para consultar os projetos cadastrados
        public async Task<List<Projeto>> ObterProjetosAsync()
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7034/api/Projetos", Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<List<Projeto>>
                    (response.Content);
            else
                return null;
        }

        //Método para consultar um projeto específico com o ID
        public async Task<Projeto> ObterProjetoIDAsync(int id)
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7034/api/Projetos/"+id, Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<Projeto>
                    (response.Content);
            else
                return null;
        }

        //Método para cadastrar os projetos
        public async Task<Projeto> CadastrarProjetoAsync(Projeto projeto)
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7034/api/Projetos", Method.Post);

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
        public async Task<bool> EditarProjetoAsync(int id, Projeto projeto)
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7034/api/Projetos/"+id, Method.Put);

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
        public async Task<bool> DeletarProjetoAsync(int id)
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7034/api/Projetos/" + id, Method.Delete);

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
