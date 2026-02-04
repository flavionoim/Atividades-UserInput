class Program
{
    static void Main()
    {
        Cachorro dog = new Cachorro();

        Console.WriteLine("Nome do cachorro:");
        dog.Nome = Console.ReadLine();

        Console.WriteLine("Nível de fome (0 a 10):");
        dog.Fome = Convert.ToInt32(Console.ReadLine());

        dog.Latir();

        Console.WriteLine("\nO cachorro vai caminhar...");
        dog.Caminhar();
        dog.Latir();

        Console.WriteLine("\nO cachorro vai comer...");
        dog.Comer();
        dog.Latir();
    }
}
