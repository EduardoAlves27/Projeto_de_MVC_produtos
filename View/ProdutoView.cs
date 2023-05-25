using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc_project.Model;

namespace mvc_project.View
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produto)
        {
            Console.Clear();

            foreach (var item in produto)
            {
                Console.WriteLine($"\nCodigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preco: {item.Preco:C}");

            }
        }


        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.Clear();
            Console.WriteLine($"Informe o Codigo: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o Nome :");
            novoProduto.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o Preco:");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            return novoProduto;


        }
    }
}