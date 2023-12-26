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
    public class Nivel2
    {
        public int id { get; set; }
        public int projeto { get; set; }
        public int nivel1 { get; set; }
        public string descricao { get; set; }

        //Método para consultar todos os nível 2 cadastrados
        public async Task<List<Nivel2>> ObterNivel2Async()
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7034/api/Nivel2", RestSharp.Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<List<Nivel2>>
                    (response.Content);
            else
                return null;
        }

        //Método para consultar um nível 2 específico com o ID
        public async Task<Nivel2> ObterNivel2IDAsync(int id)
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7034/api/Nivel2/" + id, Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<Nivel2>
                    (response.Content);
            else
                return null;
        }

        //Método para cadastrar o nível 2
        public async Task<Nivel2> CadastrarNivel2Async(Nivel2 nivel2)
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7034/api/Nivel2", Method.Post);

            request.RequestFormat = DataFormat.Json;
            /*JsonConvert.SerializeObject(request, Formatting.Indented,
                            new JsonSerializerSettings
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                            });
            */
            request.AddJsonBody(nivel2);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessStatusCode)
                MessageBox.Show("Nível 2 adicionado com sucesso!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Falha ao adicionar o nível 2!", "Redes elétricas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return nivel2;
        }
    }

}
