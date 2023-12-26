using System;
using System.Collections.Generic;

namespace ApiMysqlRedesEletricasInteligentes.Models;

public partial class Nivel1
{
    public int Id { get; set; }

    public int Projeto { get; set; }

    public string Descricao { get; set; } = null!;

    public virtual ICollection<Nivel2> Nivel2s { get; set; } = new List<Nivel2>();

    public virtual Projeto ProjetoNavigation { get; set; } = null!;
}
