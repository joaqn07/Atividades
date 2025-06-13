
Console.Write("Informe a quantidade total de blusas produzidas: ");
int quantidadeBlusas = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o total de novelos de lã utilizados: ");
int totalNovelos = Convert.ToInt32(Console.ReadLine());

if (quantidadeBlusas <= 0)
{
Console.WriteLine("A quantidade de blusas deve ser maior que zero.");
return;
}

decimal novelosPorBlusa = (decimal)totalNovelos / quantidadeBlusas;


Console.WriteLine("Cada blusa consumiu em média " + novelosPorBlusa + " novelos de lã.");
   