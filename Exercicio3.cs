using System;

public class Elevador
{
    private int andarAtual;
    private int totalAndares;

    public int TotalAndares
    {
        get { return totalAndares; }
        private set { totalAndares = value; }
    }

    public int AndarAtual
    {
        get { return andarAtual; }
        private set
        {
            if (value < 0)
            {
                andarAtual = 0;
            }
            else if (value > TotalAndares)
            {
                andarAtual = TotalAndares;
            }
            else
            {
                andarAtual = value;
            }
        }
    }

    public Elevador(int totalAndares)
    {
        TotalAndares = totalAndares;
        AndarAtual = 0;
    }

    public void Subir()
    {
        AndarAtual++;
    }

    public void Descer()
    {
        AndarAtual--;
    }
}

class Program
{
    static void Main()
    {
        Elevador e = new Elevador(10);

        e.Subir();
        e.Subir();
        Console.WriteLine(e.AndarAtual); 
        e.Descer();
        Console.WriteLine(e.AndarAtual);
        e.Descer();
        e.Descer();
        Console.WriteLine(e.AndarAtual);
    }
}
