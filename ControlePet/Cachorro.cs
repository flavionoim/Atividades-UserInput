using System;

class Cachorro
{
    public string Nome;
    public int Fome;

    public void Caminhar()
    {
        Fome++;
        Console.WriteLine("O cachorro caminhou. Fome: " + Fome);
    }

    public void Comer()
    {
        Fome--;
        Console.WriteLine("O cachorro comeu. Fome: " + Fome);
    }

    public void Latir()
    {
        if (Fome > 8)
        {
            Console.WriteLine("AUUUUU! Estou com muita fome!");
        }
        else
        {
            Console.WriteLine("Au au!");
        }
    }
}