class Program
{
    static void Main()
    {
        Celular celular1 = new Celular();
        Celular celular2 = new Celular();

        Console.WriteLine("Cadastro do primeiro celular");
        Console.WriteLine("Marca:");
        celular1.Marca = Console.ReadLine();

        Console.WriteLine("Modelo:");
        celular1.Modelo = Console.ReadLine();

        Console.WriteLine("Bateria (0 a 100):");
        celular1.Bateria = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nCadastro do segundo celular");
        Console.WriteLine("Marca:");
        celular2.Marca = Console.ReadLine();

        Console.WriteLine("Modelo:");
        celular2.Modelo = Console.ReadLine();

        Console.WriteLine("Bateria (0 a 100):");
        celular2.Bateria = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nTentando enviar mensagem com o celular 1:");
        celular1.EnviarMensagem();

        Console.WriteLine("\nTentando enviar mensagem com o celular 2:");
        celular2.EnviarMensagem();
    }
}