int dmaior, dmenor;

Console.WriteLine(" me informe o valor da diagonal maior: ");
dmaior = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" por fim me informe o valor da diagonal menor: ");
dmenor = Convert.ToInt32(Console.ReadLine());

if (dmaior == dmenor || dmenor >= dmaior) 
{

    Console.WriteLine(" isso não é um losango");
    return;

}

int area = (dmaior * dmenor) / 2;

Console.WriteLine(" a area do losango é: " + area);