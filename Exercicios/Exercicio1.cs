using System;
using System.Collections.Generic;
using System.Linq;

public static class Exercicio1
{
    // Resolução 1: Total de vendas por categoria
    public static void TotalVendasPorCategoria(List<Venda> vendas)
    {
        var total = vendas
            .GroupBy(v => v.Categoria)
            .Select(g => new { Categoria = g.Key, TotalDeVendas = g.Sum(v => v.ValorTotal) });

        Console.WriteLine("Total de Vendas por Categoria:");
        foreach (var vendaCategoria in total)
        {
            Console.WriteLine($"Categoria: {vendaCategoria.Categoria}, Total de Vendas: {vendaCategoria.TotalDeVendas:C}");
        }
    }

    // Resolução 2: Top 3 categorias mais lucrativas
    public static void Top3CategoriasMaisLucrativas(List<Venda> vendas)
    {
        var top3 = vendas
            .GroupBy(v => v.Categoria)
            .Select(g => new { Categoria = g.Key, TotalDeVendas = g.Sum(v => v.ValorTotal) })
            .OrderByDescending(c => c.TotalDeVendas)
            .Take(3);

        Console.WriteLine("\nTop 3 Categorias Mais Lucrativas:");
        foreach (var categoria in top3)
        {
            Console.WriteLine($"Categoria: {categoria.Categoria}, Total de Vendas: {categoria.TotalDeVendas:C}");
        }
    }

    // Resolução 3: Produtos com menos de 5 vendas
    public static void ProdutosComMenosDe5Vendas(List<Venda> vendas)
    {
        var produtos = vendas
            .Where(v => v.Quantidade < 5)
            .Select(v => new { v.NomeProduto, v.Quantidade });

        Console.WriteLine("\nProdutos com Menos de 5 Vendas:");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"Produto: {produto.NomeProduto}, Quantidade Vendida: {produto.Quantidade}");
        }
    }
}