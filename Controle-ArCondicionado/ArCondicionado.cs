using System;

class ArCondicionado
{
    public int Temperatura;

    public void AumentarTemp()
    {
        if (Temperatura < 30)
        {
            Temperatura++;
            Console.WriteLine("Temperatura agora: " + Temperatura);
        }
        else
        {
            Console.WriteLine("Temperatura máxima atingida.");
        }
    }

    public void DiminuirTemp()
    {
        if (Temperatura > 16)
        {
            Temperatura--;
            Console.WriteLine("Temperatura agora: " + Temperatura);
        }
        else
        {
            Console.WriteLine("Temperatura mínima atingida.");
        }
    }
}
