using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc_project.Model;
using mvc_project.View;

namespace mvc_project.Controller
{
    public class ProdutoController
    {
        //instnciar objeto produto e ProdutoView

        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();

        //Metodo controlador para acessar a listagem de produto
        public void ListarProdutos()
        {
            //Lista de produtos chamada pela MODEL
            List<Produto> produtos = produto.Ler();

            //Chamada do metodo de exibicao (VIEW) rebendo lista de argumento
            produtoView.Listar(produtos);
        }

        public void CadastrarProduto()
        {
            Produto produtoCadastrado = produtoView.Cadastrar();

            produto.Inserir(produtoCadastrado);
        }

        
}
}