decimal broa, paes, lucro, poupança;

Console.WriteLine(" OlAAAAA, boa tarde quantos paes foram comprados hoje?");
paes = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine(" salve dnv, agora quantos broas foram compradas hoje? ");
broa = Convert.ToDecimal(Console.ReadLine());

lucro = paes * 0.12m + broa * 1.50m;

poupança = (broa * 1.50m + paes * 0.12m) * 0.100m;

Console.WriteLine(" voce arrecadou arrecadou " + lucro + " em lucro, e teve que guardar apenas " + poupança);


