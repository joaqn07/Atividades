decimal terreno = 0, comprimento, largura;

Console.WriteLine(" diga o comprimento do terreno que gostaria de comprar ");
comprimento = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("agora por favor me diga a largura");
largura = Convert.ToDecimal(Console.ReadLine());

if (comprimento != largura)
{
    terreno = comprimento * largura;
    Console.WriteLine(" a area do terreno é " + terreno + " parabens ");

}

if (comprimento == largura)
{

    Console.WriteLine(" me desculpe, apenas vendemos terrenos retangulares");
}
