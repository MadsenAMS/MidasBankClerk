using UnityEngine;

/// <summary>
/// Est�gios do saque: 1- Informar que quer sacar; 2- Informa valor do saque; 3- Reage a saldo insuficiente.
/// </summary>
public static class DialogosDoSaque
{
    private static string[] EstagioUmQueroSacar =
    {
        "Quero sacar meu dinheiro, por favor.",
        "Isso n�o � um banco? Vim pegar dinheiro. Oras.",
        "Me d� dinheiro.",
        "Estou com dificuldade de sacar no caixa eletr�nico. Preciso de ajuda."
    };

    private static string[] EstagioDoisValorDoSaque =
    {
        "Hmmm, deixa eu pensar... dez pra mim... dez pra minha filha... Quero sacar $",
        "Eu quero sacar $",
        "Hmmm... Talvez seja melhor eu sacar logo $",
        "Adivinha! Brincadeira. Quero sacar $",
        "O de sempre! Que careta � essa? Voc� nunca lembra. Quero $"
    };

    private static string[] EstagioTresSaldoInsuficiente =
{
        "Que coisa... Achei que estava rico.",
        "Hmmm... suspeito. Muito suspeito.",
        "MEU DINHEIRO! O QUE ACONTECEU COM MEU AMADO DINHEIRO?",
        "Macacos me mordam!",
        "Hahaha, eu sei... Mas n�o custava tentar."
    };

    public static string GetDialogue(int estagioDaDemanda)
    {
        if (estagioDaDemanda == 1)
        {
            return EstagioUmQueroSacar[Random.Range(0, EstagioUmQueroSacar.Length - 1)];
        }
        if (estagioDaDemanda == 2)
        {
            return EstagioDoisValorDoSaque[Random.Range(0, EstagioDoisValorDoSaque.Length - 1)];
        }
        if (estagioDaDemanda == 3)
        {
            return EstagioTresSaldoInsuficiente[Random.Range(0, EstagioTresSaldoInsuficiente.Length - 1)];
        }

        return "� n�o! Algum bug no sistema de di�logo! Melhor falar com o programador...";
    }
}
