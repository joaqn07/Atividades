Console.WriteLine(" d9igite o valor do primeiro cateto: ");
decimal cateto1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine(" digite o valor do segundo cateto: ");
decimal cateto2 = Convert.ToDecimal(Console.ReadLine());

decimal somaquadrados = (cateto1 * cateto1) + (cateto2 * cateto2);

decimal hipotenusa;

if (somaquadrados  == 25)
{
    hipotenusa = 5;
}

else if (somaquadrados == 100)
{
    hipotenusa = 10;
}
else if (somaquadrados == 169)
{
    hipotenusa = 13;
}

else if (somaquadrados  == 200)
{
    hipotenusa = 14;
}

else
{
    Console.WriteLine("Hipotenusa não estimada com precisão. Valor ao quadrado: " + somaquadrados );
    return;
}


Console.WriteLine("A hipotenusa é aproximadamente: " + hipotenusa);