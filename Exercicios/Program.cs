using System;
using System.Collections.Generic;
using Exercicios;

class Program
{
    static void Main()
    {
        // Dados de exemplo
        List<Venda> vendas = new List<Venda>
        {
            new Venda { IdProduto = 1, NomeProduto = "Notebook", Categoria = "Eletrônicos", Quantidade = 2, ValorTotal = 4000 },
            new Venda { IdProduto = 2, NomeProduto = "Mouse", Categoria = "Eletrônicos", Quantidade = 5, ValorTotal = 500 },
            new Venda { IdProduto = 3, NomeProduto = "Camiseta", Categoria = "Vestuário", Quantidade = 10, ValorTotal = 300 },
            new Venda { IdProduto = 4, NomeProduto = "Tênis", Categoria = "Vestuário", Quantidade = 3, ValorTotal = 600 },
            new Venda { IdProduto = 5, NomeProduto = "Smartphone", Categoria = "Eletrônicos", Quantidade = 1, ValorTotal = 3000 },
            new Venda { IdProduto = 6, NomeProduto = "Livro", Categoria = "Educação", Quantidade = 8, ValorTotal = 160 },
            new Venda { IdProduto = 7, NomeProduto = "Caneta", Categoria = "Educação", Quantidade = 20, ValorTotal = 100 }
        };
        
        // Chamando as soluções do exercício 1
        Exercicio1.TotalVendasPorCategoria(vendas);
        Exercicio1.Top3CategoriasMaisLucrativas(vendas);
        Exercicio1.ProdutosComMenosDe5Vendas(vendas);
        
        List<Funcionario> funcionarios = new List<Funcionario>
        {
            new Funcionario { Id = 1, Nome = "João", Cargo = "Desenvolvedor", DataAdmissao = new DateTime(2022, 1, 15), DiasFeriasUsados = 10 },
            new Funcionario { Id = 2, Nome = "Maria", Cargo = "Gerente", DataAdmissao = new DateTime(2019, 3, 10), DiasFeriasUsados = 20 },
            new Funcionario { Id = 3, Nome = "Pedro", Cargo = "Analista", DataAdmissao = new DateTime(2023, 2, 1), DiasFeriasUsados = 5 },
            new Funcionario { Id = 4, Nome = "Ana", Cargo = "Desenvolvedor", DataAdmissao = new DateTime(2020, 10, 25), DiasFeriasUsados = 0 },
            new Funcionario { Id = 5, Nome = "Lucas", Cargo = "Gerente", DataAdmissao = new DateTime(2021, 6, 5), DiasFeriasUsados = 15 }
        };
        
        Exercicio2.getListWorkersExpiredVacation(funcionarios);
        Exercicio2.getListWorkersByRole(funcionarios);
        
    }
}