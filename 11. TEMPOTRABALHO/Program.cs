int totalDias;
int anos, meses, dias;

Console.Write("Digite a quantidade de dias sem acidentes: ");
totalDias = Convert.ToInt32(Console.ReadLine());

anos = totalDias / 360;
totalDias = totalDias % 360;

meses = totalDias / 30;
dias = totalDias % 30;

Console.WriteLine("Tempo sem acidentes:");
Console.WriteLine( anos + *ano(s)," + meses + " mês(es)," + dias + "dia(s).");