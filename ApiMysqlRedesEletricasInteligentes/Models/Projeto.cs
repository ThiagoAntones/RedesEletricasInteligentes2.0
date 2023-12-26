using System;
using System.Collections.Generic;

namespace ApiMysqlRedesEletricasInteligentes.Models;

public partial class Projeto
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public DateOnly Inicio { get; set; }

    public DateOnly Termino { get; set; }

    public double Custo { get; set; }

    public virtual ICollection<Nivel1> Nivel1s { get; set; } = new List<Nivel1>();

    public virtual ICollection<Nivel2> Nivel2s { get; set; } = new List<Nivel2>();
}
