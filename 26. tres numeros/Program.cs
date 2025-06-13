decimal n1,n2, n3;

Console.WriteLine(" me diga o seu primeiro numero: ");
n1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine(" me diga seu segundo numero: ");
n2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine(" por fim, me diga o terceiro numero: ");
n3 = Convert.ToDecimal(Console.ReadLine());

decimal resultado = n1 * n2 * n3;

Console.WriteLine(" o resultado foi " + resultado);