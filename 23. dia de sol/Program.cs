decimal altura;
Console.WriteLine("me informe sua a sua altura: ");
altura = Convert.ToDecimal(Console.ReadLine());

decimal medida;
Console.WriteLine(" agora por favor me informe a medida de sua sombra: ");
medida = Convert.ToDecimal(Console.ReadLine());

decimal medidapredio;
Console.WriteLine(" agora me informe a medida da sombra do predio: ");
medidapredio = Convert.ToDecimal(Console.ReadLine());


decimal alturapredio = (altura * medidapredio) / medida;

Console.WriteLine(" a altura do predio é " + alturapredio);

