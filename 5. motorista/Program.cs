decimal reais, litro;

Console.WriteLine(" digite o preço do litro ");
litro = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine(" digite quantos gostaria de pagar: ");
reais = Convert.ToDecimal(Console.ReadLine());


decimal lucro = reais / litro;

Console.WriteLine(" voce consegue colocar " + lucro + " litros no tanque ");

