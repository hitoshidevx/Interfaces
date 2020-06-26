using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Produto p1 = new Produto(12, "PS5", 9999.9f);
            Produto p2 = new Produto(23, "Switch", 2299.9f);
            Produto p3 = new Produto(15, "PS4", 1599.9f);
            Produto p4 = new Produto(74, "PS2", 299.9f);

            Carrinho carrinho = new Carrinho();
            carrinho.Add(p1);
            carrinho.Add(p2);
            carrinho.Add(p3);
            carrinho.Add(p4);

            carrinho.Remove(p2);

            Produto p5 = new Produto(87, "Xbox One", 1899.79f);
            carrinho.Update(74, p5);

            carrinho.Read();

            carrinho.MostrarValorTotal();

        }
    }
}
