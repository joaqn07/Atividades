decimal peso;

Console.WriteLine(" me informe seu peso por favor: ");
peso = Convert.ToDecimal(Console.ReadLine());


decimal gordo = peso * 1.15m;
decimal palito = peso * 0.80m;


Console.WriteLine(" o novo peso se voce engordar 15% sobre o peso atual fica: " + gordo);
Console.WriteLine(" o novo peso se voce emagrecer 20% sobre o peso atual fica " + palito);
