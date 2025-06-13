decimal preço;

Console.WriteLine(" qual o preço do produto que comprou?: ");
preço = Convert.ToDecimal(Console.ReadLine());

decimal desconto = preço * 0.10m;
decimal descontin = preço - desconto;
Console.WriteLine(" seu produto pos descontou ficou: " + descontin);