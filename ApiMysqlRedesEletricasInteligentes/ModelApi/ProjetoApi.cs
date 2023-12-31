using System;

namespace ApiMysqlRedesEletricasInteligentes.ModelApi
{
    public class ProjetoApi
    {
        public int id { get; set; }
        public string? titulo { get; set; }
        public string? descricao { get; set; }
        public DateOnly inicio { get; set; }
        public DateOnly termino { get; set; }
        public double custo { get; set; }
    }
}
