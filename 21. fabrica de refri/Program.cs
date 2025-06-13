
Console.Write("Quantidade de latas de 350 ml: ");
int qtdLata350 = Convert.ToInt32(Console.ReadLine());

Console.Write("Quantidade de garrafas de 600 ml: ");
int qtdGarrafa600 = Convert.ToInt32(Console.ReadLine());

Console.Write("Quantidade de garrafas de 2 litros: ");
int qtdGarrafa2000 = Convert.ToInt32(Console.ReadLine());

     
decimal totalLitros = qtdLata350 * (350m / 1000m)
                            + qtdGarrafa600 * (600m / 1000m)
                            + qtdGarrafa2000 * 2m;


Console.WriteLine(" Total comprado: " + totalLitros + " litros");
 