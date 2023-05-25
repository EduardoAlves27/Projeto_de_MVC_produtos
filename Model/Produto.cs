using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_project.Model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        //Caminho da pasta e do arquivo especificado 
        private const string PATH = "Database/Produto.csv";

        //Criar um construtor 

        public Produto()
        {
            // obter o caminho da pasta 
            string pasta = PATH.Split("/")[0]; //Database

            //se nao existir uma pasta database, entao cria-se uma 
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //se nao existir um arquivo csv no caminho, ele cria uma

            if (!File.Exists(PATH))
            {
                File.Create(PATH);

            }

        }

        public List<Produto> Ler()
        {
            //instanciar uma lista de produto

            List<Produto> produtos = new List<Produto>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                string[] atributos = item.Split(";");

                Produto p = new Produto();

                p.Codigo = int.Parse(atributos[0]); //001 CODIGO 
                p.Nome = atributos[1];// COCA 
                p.Preco = float.Parse(atributos[2]);

                produtos.Add(p);

            }

            return produtos;
        }

        // Metodo Para Preparar a Linha do CSV

        public string PrepararLinhaCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";
        }

        //Metodo para inserir um produto no arquivo CSV

        public void Inserir(Produto p)
        {
            //Array que vai Armazenar  As linhas (Cada "Objeto")
            string[] linhas = { PrepararLinhaCSV(p) };

            //Vai ate or arquivo e insere todas as linhas 
            File.AppendAllLines(PATH, linhas);
        }
    }
}