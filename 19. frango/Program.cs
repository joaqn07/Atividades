int frango;

Console.WriteLine(" quantos frangos existem na granja frangotech");
frango = Convert.ToInt32(Console.ReadLine());

decimal anelchip = 4.00m;
decimal anelalimento = 3.50m;

decimal gastototal = frango * (anelalimento + (2 * anelchip));

Console.WriteLine(" a quantidade de gasto foi " + gastototal);

