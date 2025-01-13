namespace Exercicios;

public class Exercicio3
{
    //Listar as categorias que têm mais de 50 itens no estoque, ordenadas pela quantidade total de itens.
    public static void GetMore50ItensOnStockOrderByTotalItens (List<Produto> produtos)
    {
        var itens = produtos.GroupBy(p => p.Categoria).Select(g => new { Categoria = g.Key, Quantidade = g.Sum(x => x.Quantidade) }).Where(x => x.Quantidade > 50).OrderByDescending(x => x.Quantidade); 
        
        foreach (var itensOrdernados in itens)
        {
            Console.WriteLine($"{itensOrdernados.Categoria} - {itensOrdernados.Quantidade}");
        }
    }
    //Obter o produto mais caro em cada categoria.
    public static void GetMoreExpensiveProductOnEachCategory(List<Produto> produtos)
    {
        var itens = produtos.GroupBy(x => x.Categoria).Select(g => new { Categoria = g.Key, ProdutoMaisCaro = g.OrderByDescending(x => x.ValorUnitario).FirstOrDefault()});

        foreach (var itensOrdernados in itens)
        {
            Console.WriteLine($"{itensOrdernados.Categoria} - {itensOrdernados.ProdutoMaisCaro.Nome}");
        }
    } 
    //Calcular o valor total do estoque (soma de todos os produtos: quantidade × valor unitário).
    public static void GetTotalInStock(List<Produto> produtos)
    {
        var valorTotalEstoque = produtos.Sum(x => x.Quantidade * x.ValorUnitario);
        Console.WriteLine($"O valor total do estoque é: {valorTotalEstoque:C}");
  
    } 
    
    
}