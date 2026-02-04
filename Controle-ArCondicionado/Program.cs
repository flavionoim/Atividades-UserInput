class Program
{
    static void Main()
    {
        ArCondicionado ar = new ArCondicionado();

        Console.WriteLine("Temperatura inicial:");
        ar.Temperatura = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("1 - Aumentar temperatura");
        Console.WriteLine("2 - Diminuir temperatura");
        int opcao = Convert.ToInt32(Console.ReadLine());

        if (opcao == 1)
        {
            ar.AumentarTemp();
        }
        else if (opcao == 2)
        {
            ar.DiminuirTemp();
        }
    }
}

