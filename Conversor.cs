using System;

public static class Conversor
{
    public static float CotacaoDolar = 5.25f;

    public static float CotacaoEuro= 5.91f;

    public static float RealtoDolar(float valor )
    {
        return valor / CotacaoDolar;
    }


    public static float DolartoReal(float valorDolar)
    {
        return valorDolar * CotacaoDolar;
    }

    public static float RealtoEuro(float valor)
    {
        return valor / CotacaoEuro;
    }

    public static float EurotoReal(float ValorEuro)
    {
        return ValorEuro*CotacaoEuro;
    }
}