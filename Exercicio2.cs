using System;

public class Carro
{
    private string modelo;
    private int velocidadeAtual;

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public int VelocidadeAtual
    {
        get { return velocidadeAtual; }
        private set
        {
            if (value < 0)
            {
                velocidadeAtual = 0;
            }
            else
            {
                velocidadeAtual = value;
            }
        }
    }
    public Carro(string modelo)
    {
        Modelo = modelo;
        VelocidadeAtual = 0;
    }
    public void Acelerar(int valor)
    {
        VelocidadeAtual += valor;
    }
    public void Frear(int valor)
    {
        VelocidadeAtual -= valor;
    }
}
class Program
{
    static void Main()
    {
        Carro c = new Carro("Ferrari");

        c.Acelerar(50);
        Console.WriteLine(c.VelocidadeAtual);
        c.Frear(30);
        Console.WriteLine(c.VelocidadeAtual);
        c.Frear(50);
        Console.WriteLine(c.VelocidadeAtual); 
    }
}
