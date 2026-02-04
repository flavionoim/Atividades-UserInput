using System;

class Usuario
{
    public string NomeUsuario;
    public string Senha;
    public bool EstaLogado;

    public void Autenticar(string senhaDigitada)
    {
        if (senhaDigitada == Senha)
        {
            EstaLogado = true;
            Console.WriteLine("Login realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Senha incorreta.");
        }
    }
}