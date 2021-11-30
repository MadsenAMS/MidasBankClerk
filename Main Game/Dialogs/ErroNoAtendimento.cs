using UnityEngine;

public static class ErroNoAtendimento
{
    private static string[] reclamacao =
          {
        "Foi isso que eu pedi? FOI ISSO QUE EU PEDI?",
        "Hmmm... vamos come�ar de novo? Prestando aten��o dessa vez?",
        "Aiaiai, que saco. Vou falar mais uma vez. Mais uma vez!",
        "Me parece que algu�m n�o vai receber boa nota no atendimento.",
        "Que poxa. Ser� que algu�m melhor pode me atender?",
        "Perd�o... Acho que fiz confus�o..."
    };


    public static string GetDialogue(string extraInput = "")
    {
        return extraInput + " " +  reclamacao[Random.Range(0, reclamacao.Length - 1)];
    }
}
