using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DialogoRGSolicitado
{
    public enum estadoDoRg
    {
        tenhoRG,
        naoTenhoRG,
        jaEntregueiRG
    }

    private static string[] TenhoRG =
        {
        "Aqui est� minha RG (PLACEHOLDER1)",
        "Aqui est� minha RG (PLACEHOLDER2)"
    };

    private static string[] NaoTenhoRG =
    {
        "N�o tenho RG (PLACEHOLDER1)",
        "N�o tenho RG (PLACEHOLDER2)"
    };

    public static string GetDialogue(estadoDoRg rg)
    {
        if (rg == estadoDoRg.tenhoRG)        
            return TenhoRG[Random.Range(0, TenhoRG.Length - 1)];

        return NaoTenhoRG[Random.Range(0, NaoTenhoRG.Length - 1)];

    }
}
