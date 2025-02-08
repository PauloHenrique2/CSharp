using CookiesCookbook.Receitas.Ingredientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook.Receitas;


public class Receita
{
    public IEnumerable<Ingrediente> Ingredientes { get; }

    public Receita(IEnumerable<Ingrediente> ingredientes)
    {
        Ingredientes = ingredientes;
    }

    public override string ToString()
    {
        var instrucoes = new List<string>();
        foreach (var ingrediente in Ingredientes)
        { 
          instrucoes.Add($"{ingrediente.Nome}. {ingrediente.InstrucoesDePreparo}");
        }

        return string.Join(Environment.NewLine, instrucoes);
    }
}
