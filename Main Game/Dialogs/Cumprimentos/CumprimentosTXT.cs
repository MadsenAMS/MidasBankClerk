using UnityEngine;

public static class CumprimentosTXT
{
    private static string[] Cumprimentos =
        {
        "Ol�!","Bom dia!",
        "Oi, tudo bem?",
        "Ol�, tudo bom?",
        "Ol�, como vai?",
        "Oi...", 
        "E aqui estou eu novamente...",
        "Esse lugar tem um cheiro estranho, voc� est� sentindo?",
        "Estava atravessando a rua e vi um cachorro fazendo bananeira. O qu�o estranho � isso?",
        "Nossa, o �timo atendimento foi muito demorado. Seja r�pido.",
        "As vezes sinto que voc� n�o se importa comigo.",
        "Voc� � o atendente novo, certo?",
    };

    public static string getCumprimentos()
    {
        return Cumprimentos[Random.Range(0, Cumprimentos.Length - 1)];
    }
}
