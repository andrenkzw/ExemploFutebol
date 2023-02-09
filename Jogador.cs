enum Tipo
{
    GOLEIRO,
    LATERAL,
    ZAGUEIRO,
    VOLANTE,
    MEIA,
    ATACANTE,
};

class Jogador {
    public string Nome { get; init; }
    public Tipo Posicao { get; set; }

    public Jogador(string nome, Tipo posicao)
    {
        Nome = nome;
        Posicao = posicao;
    }
}