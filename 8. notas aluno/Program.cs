decimal nota1, nota2, nota3;

Console.WriteLine(" informe sua primeira nota: ");
nota1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine(" informe sua segunda nota: ");
nota2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine(" por fim, me imforme sua terceira nota: ");
nota3 = Convert.ToDecimal(Console.ReadLine());


decimal resultado = (nota1 * 1 + nota2 * 2 + nota3 * 3) / 6;

Console.WriteLine(" a sua media ponderada foi " + resultado + " parabens ");
