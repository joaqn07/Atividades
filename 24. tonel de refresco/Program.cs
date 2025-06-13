decimal totalsuco;

Console.WriteLine(" quantos litros de refresco voce quer?: ");
totalsuco = Convert.ToDecimal(Console.ReadLine());

decimal agua = totalsuco * (8m / 10m);
decimal suco = totalsuco * (2m / 10m);

Console.WriteLine(" voce ira precisar de " + agua + " litros de àgua, e " + suco + " litros de suco ");


