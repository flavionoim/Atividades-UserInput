class Program
{
    static void Main()
    {
        Usuario user = new Usuario();

        Console.WriteLine("Crie um nome de usuário:");
        user.NomeUsuario = Console.ReadLine();

        Console.WriteLine("Crie uma senha:");
        user.Senha = Console.ReadLine();

        Console.WriteLine("\nDigite a senha para login:");
        string senhaDigitada = Console.ReadLine();

        user.Autenticar(senhaDigitada);
    }
}
