decimal pi = 3.14m;

Console.WriteLine("digite o raio da pizza: ");
decimal raio = Convert.ToDecimal(Console.ReadLine());

decimal area = pi * (raio * raio);

Console.WriteLine(" a area da pizza é: " + area);
