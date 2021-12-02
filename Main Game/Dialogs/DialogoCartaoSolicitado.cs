using UnityEngine;

public static class DialogoCartaoSolicitado
{
    private static string[] TenhoCartao =
    {
        "Aqui est� (PLACEHOLDER 1)",
        "Aqui est� (PLACEHOLDER 2)"
    };

    private static string[] CartaoInvalido =
    {
        "Ok, cart�o inv�lido (PLACEHOLDER 1)",
        "Ok, cart�o inv�lido (PLACEHOLDER 2)"
    };

    private static string[] NaoTenhoCartao =
    {
        "Estou sem cart�o (PLACEHOLDER 1)",
        "Estou sem cart�o (PLACEHOLDER 2)"

    };

    /// <summary>
    /// Tipo 1 - Aqui Est� Meu Cart�o, Tipo 2- Cart�o Inv�lido, Tipo 3 - Esqueci Meu Cart�o
    /// </summary>
    /// <param name="tipoDeDialogo"></param>
    /// <returns></returns>
    static public string GetDialogue(int tipoDeDialogo)
    {
        switch (tipoDeDialogo)
        {
            case 1:
                return TenhoCartao[Random.Range(0, TenhoCartao.Length - 1)];
            case 2:
                return CartaoInvalido[Random.Range(0, CartaoInvalido.Length - 1)];
            case 3:
                return NaoTenhoCartao[Random.Range(0, NaoTenhoCartao.Length - 1)];
            default:
                Debug.LogError("Solicitado Di�logo Inv�lido!");
                return "Di�logo Inv�lido";
        }

    }
}