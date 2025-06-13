Console.Write("Informe a temperatura em Celsius: ");
decimal celsius =Convert.ToDecimal(Console.ReadLine());
  
decimal fahrenheit = celsius * 1.8m + 32m;

Console.WriteLine(celsius + ": °C equivalem a " + fahrenheit + "°F");