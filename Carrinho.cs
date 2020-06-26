using System.Collections.Generic;
using System;
namespace Interfaces
{
    public class Carrinho : ICarrinho
    {
        public float ValorTotal { get; set; }
        List<Produto> carrinho = new List<Produto>();

        public void Add(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Remove(Produto produto)
        {
            carrinho.Remove(produto);
        }
        public void Read()
        {
            foreach(Produto x in carrinho)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                System.Console.WriteLine($"{x.Nome} - R${x.Preco}");
            }
        }

        public void MostrarValorTotal(){

            if(carrinho != null){

                Console.ForegroundColor = ConsoleColor.Green;

                foreach(Produto z in carrinho){
                    
                    ValorTotal += z.Preco;

                }
            Console.WriteLine($"\nO valor total dos produtos é igual a: R${ValorTotal}.");
            Console.ResetColor();
            }else{
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O seu carrinho ainda está vazio, uai!");

            }

        }

        public void Update(int _codigo, Produto produto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = produto.Preco;
        }
    }
}