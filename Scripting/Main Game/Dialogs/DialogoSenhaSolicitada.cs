using UnityEngine;

public static class DialogoSenhaSolicitada
{
    private static string[] AquiEstaMinhaSenha =
    {
        "Hmmm... Suspeito. Olhe pro lado!",
        "Claro! Adoro digitar senha!",
        "Ai ai... Cada dia uma burocracia nova."
    };

    private static string[] ErreiMinhaSenha =
    {
        "Uai... Eu podia jurar que era essa.",
        "Eu sei, tava s� testando.",
        "Hmmm... E agora?"
    };

    private static string[] NaoSeiMinhaSenha =
    {
        "Xiiiiiiii... Acho que comi minha senha.",
        "A senha n�o era esse n�mero no cart�o? Ent�o n�o sei.",
        "Se eu soubesse a senha eu n�o ia vir no caixa pra isso."
    };

    /// <summary>
    /// Devolve um di�logo conforme a circunst�ncia. 1 - Aqui est� minha senha; 2- Errei a senha; 3 - Esqueci a senha.
    /// </summary>
    /// <param name="typeOfDialogue">1 - Aqui est� minha senha; 2- Errei a senha; 3 - Esqueci a senha.</param>
    /// <returns></returns>
    public static string GetDialogue(int typeOfDialogue)
    {
        if (typeOfDialogue == 1)
        {
            return AquiEstaMinhaSenha[Random.Range(0, AquiEstaMinhaSenha.Length)];
        }
        else if (typeOfDialogue == 2)
        {
            return ErreiMinhaSenha[Random.Range(0, ErreiMinhaSenha.Length)];
        }
        else if (typeOfDialogue == 3)
        {
            return NaoSeiMinhaSenha[Random.Range(0, NaoSeiMinhaSenha.Length)];
        }

        return "ERROR: Dialogue option not avialble.";
    }
}
