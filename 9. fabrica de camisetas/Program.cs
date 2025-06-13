decimal precoPequena = 10m;
decimal precoMedia = 12m;
decimal precoGrande = 15m;

    
Console.Write("Informe a quantidade de camisetas pequenas: ");
 int qtdPequena = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe a quantidade de camisetas médias: ");
 int qtdMedia = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe a quantidade de camisetas grandes: ");
  int qtdGrande = Convert.ToInt32(Console.ReadLine());

   
if (qtdPequena < 0 || qtdMedia < 0 || qtdGrande < 0)
{
   Console.WriteLine("A quantidade de camisetas não pode ser negativa.");
   return;
}

decimal totalPequena = qtdPequena * precoPequena;
decimal totalMedia = qtdMedia * precoMedia;
decimal totalGrande = qtdGrande * precoGrande;

 decimal valorTotal = totalPequena + totalMedia + totalGrande;


        Console.WriteLine("Resumo da venda:");
        Console.WriteLine(" Pequenas: " + qtdPequena + " x R$" + precoPequena + " = R$ " + totalPequena);
        Console.WriteLine(" Médias: " + + qtdMedia+  " x R$ " + precoMedia + " = R$ " +totalMedia);
        Console.WriteLine(" Grandes: " + qtdGrande + " x R$ " + precoGrande + " = R$ " + totalGrande);
        Console.WriteLine("-------------------------------");
        Console.WriteLine(" Valor total arrecadado: R$" + valorTotal);
   