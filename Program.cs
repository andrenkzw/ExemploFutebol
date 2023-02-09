using System;
using System.Collections.Generic;
using System.Linq;

namespace ExemploFutebol;
class Program
{
    static void Main(string[] args)
    {
        List<Time> times = new List<Time>()
        {
            new Time
            (
                "Gremio",
                new List<Jogador>()
                {
                    new Jogador("Gabriel Granco", Tipo.GOLEIRO),
                    new Jogador("Rafinha", Tipo.LATERAL),
                    new Jogador("Bruno Cortez", Tipo.LATERAL),
                    new Jogador("Pedro Geromel", Tipo.ZAGUEIRO),
                    new Jogador("Ruan", Tipo.ZAGUEIRO),
                    new Jogador("Tiago Santos", Tipo.VOLANTE),
                    new Jogador("Lucas Silva", Tipo.VOLANTE),
                    new Jogador("Ferreira", Tipo.MEIA),
                    new Jogador("Jaminton Campaz", Tipo.MEIA),
                    new Jogador("Jhonata Robert", Tipo.MEIA),
                    new Jogador("Diego Souza", Tipo.ATACANTE),
                }
            ),
            new Time
            (
                "Flamengo",
                new List<Jogador>()
                {
                    new Jogador("Hugo Souza", Tipo.GOLEIRO),
                    new Jogador("Rodinel", Tipo.LATERAL),
                    new Jogador("Renê", Tipo.LATERAL),
                    new Jogador("Gustavo Henrique", Tipo.ZAGUEIRO),
                    new Jogador("Léo Pereira", Tipo.ZAGUEIRO),
                    new Jogador("Thiago Maia", Tipo.VOLANTE),
                    new Jogador("João Gomes", Tipo.VOLANTE),
                    new Jogador("Kenedy", Tipo.MEIA),
                    new Jogador("Diego", Tipo.MEIA),
                    new Jogador("Vitinho", Tipo.MEIA),
                    new Jogador("Vitor Gabriel", Tipo.ATACANTE),
                }
            ),
        };

        // Console.WriteLine(
        //     string.Join(Environment.NewLine,
        //         from t in times 
        //         from j in t.Meias()
        //         select new { Time = t.Nome, Jogador = j.Nome}
        //     )
        // );

        Console.WriteLine(
            string.Join(Environment.NewLine,
                from t in times 
                from j in t.Jogadores
                where j.Posicao == Tipo.MEIA
                select j.Nome + ", " + t.Nome
            )
        );
    }
}
