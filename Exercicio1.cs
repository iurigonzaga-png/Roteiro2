using System;

public class Produto
{
    private string nome;
    private decimal preco;
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    public decimal Preco
    {
        get { return preco; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("preço não pode ser negativo.");
            }
            else
            {
                preco = value;
            }
        }
    }

    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {Nome} Preço: {Preco:C}");
    }
}

class Program
{
    static void Main()
    {
        Produto p = new Produto("Celular", 1500);
        p.ExibirDetalhes();
        p.Preco = -200;
        p.ExibirDetalhes();
    }
}
