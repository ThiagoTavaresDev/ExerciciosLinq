namespace Exercicios;

public class Exercicio2
{
   public static void getListWorkersExpiredVacation(List<Funcionario> funcionarios)
   {
       var funcionariosVencidos = funcionarios.Select(f => new { f.Nome, f.DataAdmissao, f.DiasFeriasUsados })
           .Where(f => DateTime.Today.Subtract(f.DataAdmissao).Days > 365 && f.DiasFeriasUsados < 30);

       foreach (var x in funcionarios)
       {
           Console.WriteLine($"{x.Nome} {x.DiasFeriasUsados}");
       }
   }

   public static void getListWorkersByRole(List<Funcionario> funcionarios)
   {
       var funcionariosCargoMedia = funcionarios.GroupBy(x => x.Cargo).Select(x => new { Cargo = x.Key, Media = x.Average(d => d.DiasFeriasUsados) });
    
       foreach (var x in funcionariosCargoMedia)
       {
           Console.WriteLine($"Cargo : {x.Cargo} Media: {x.Media}");
       }
   }
   
    
}