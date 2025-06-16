int quantidade;

Console.WriteLine(" digite a quantidade de sanduiches que vai pedir: ");
quantidade = Convert.ToInt32(Console.ReadLine());

int queijog = quantidade * 2 * 50; //queijog significa queijograma, o mesmo vale para os outros.
int presuntog = quantidade * 50;
int carneg = quantidade * 100;

decimal queijoKG = queijog / 1000.0m;
decimal presuntoKG = presuntog / 1000.0m;
decimal carneKG = carneg / 1000.0m;

Console.WriteLine(" igredientes necessarios: ");
Console.WriteLine(queijoKG + "Kg de queijo. ");
Console.WriteLine(presuntoKG + "Kg de presunto. ");
Console.WriteLine(" e " + carneKG + "Kg de carne. ");