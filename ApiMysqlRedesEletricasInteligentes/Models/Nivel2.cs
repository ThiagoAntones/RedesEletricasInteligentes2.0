using System;
using System.Collections.Generic;

namespace ApiMysqlRedesEletricasInteligentes.Models;

public partial class Nivel2
{
    public int Id { get; set; }

    public int Projeto { get; set; }

    public int Nivel1 { get; set; }

    public string Descricao { get; set; } = null!;

    public virtual Nivel1 Nivel1Navigation { get; set; } = null!;

    public virtual Projeto ProjetoNavigation { get; set; } = null!;
}
