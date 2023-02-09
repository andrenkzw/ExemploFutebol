using System.Collections.Generic;
using System.Linq;

class Time
{
    public string Nome { get; init; }
    public List<Jogador> Jogadores { get; }

    public Time(string nome) 
    {
        Nome = nome;
        Jogadores = new List<Jogador>();
    }

    public Time(string nome, List<Jogador> jogadores) 
    {
        Nome = nome;
        Jogadores = jogadores;
    }

    public Time(string nome, IEnumerable<Jogador> jogadores) 
    {
        Nome = nome;
        Jogadores = jogadores.ToList<Jogador>();
    }

    public IEnumerable<Jogador> Meias()
        => from j in Jogadores where j.Posicao == Tipo.MEIA select j;
}