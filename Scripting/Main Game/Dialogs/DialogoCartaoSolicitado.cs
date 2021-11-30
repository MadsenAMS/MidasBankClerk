using UnityEngine;

public static class DialogoCartaoSolicitado
{
    private static string[] TenhoCartao =
    {
        "T� aqui meu cart�o. Mas vou precisar dele de volta.",
        "Hmmm... Suspeito. Est� aqui. Mas estou de olho.",
        "Aiaiai, que saco. T� aqui meu cart�o.",
        "Meu cart�o � platinum plus. Oi� s�."
    };

    private static string[] NaoTenhoCartao =
    {
        "Xiii, meu cachorro comeu.",
        "Hmmm, eu jurava que estava na bolsa. N�o trouxe.",
        "Jamais daria meu cart�o para um desconhecido!",
        "Hmmm... e se eu n�o quiser dar meu cart�o?"
};

    static public string GetDialogue(bool haveCard)
    {
        if (haveCard)
        {
            return TenhoCartao[Random.Range(0, TenhoCartao.Length - 1)];
        }
        return NaoTenhoCartao[Random.Range(0, NaoTenhoCartao.Length - 1)];
    }
}