int dias, mês, ano, restodepoisano;

Console.WriteLine(" digite quantos dias esta sem acidentes: ");
dias = Convert.ToInt32(Console.ReadLine());

restodepoisano = dias / 360;
ano = restodepoisano % 360;

mês = restodepoisano / 30;
dias = restodepoisano % 30;


Console.WriteLine(" o tempo sem acidentes foi " + ano + " anos, " + mês + " meses e " + dias + " dias ");