using System;

class Celular
{
    public string Marca;
    public string Modelo;
    public int Bateria;

    public void EnviarMensagem()
    {
        if (Bateria > 0)
        {
            Console.WriteLine("Mensagem enviada!");
            Bateria--;
        }
        else
        {
            Console.WriteLine("Sem bateria. Não foi possível enviar.");
        }
    }
}

