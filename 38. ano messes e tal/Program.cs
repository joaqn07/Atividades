int ano, mes, dia,semanas, nascimentoano;

Console.WriteLine("me diga o seu ano de nascimento: ");
nascimentoano = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" me diga o ano atual: ");
ano = Convert.ToInt32(Console.ReadLine());

int idadeano = ano - nascimentoano;
mes = nascimentoano * 12;
dia = nascimentoano * 365;
semanas = dia / 7;


Console.WriteLine("a sua idade em anos é: " + idadeano + " ano(s) ");
Console.WriteLine("a sua idade em meses é: " + mes + " mes(es) ");
Console.WriteLine("a sua idade em dias é: " + dia + " dia(s) ");
Console.WriteLine("a sua idade em semanas é: " + semanas + " semanas ");