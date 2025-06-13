Console.WriteLine(" digite aum numero inteiro de 3 digitos: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero < 100 || numero > 1000)
{

    Console.WriteLine("por favor digite um numero de 3 digitos ");
    return;
}
int centena = numero / 100;
int dezena = (numero % 100) / 10;
int unidade = numero % 10;

Console.WriteLine(" CENTENA = " + centena);
Console.WriteLine(" DEZENA = " + dezena);
Console.WriteLine(" UNIDADE = " + unidade);
