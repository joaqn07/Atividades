decimal n1, n2;

Console.WriteLine(" me informe o primeiro numero");
n1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine(" me diga o segundo numero ");
n2 = Convert.ToDecimal(Console.ReadLine());

if ( n2 == 0)
{

    Console.WriteLine(" informe um numero maior que zero no segundo numero ");
    return;
}

decimal resultado = n1 / n2;

Console.WriteLine(" o resultado é " + resultado);
