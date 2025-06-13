decimal salario = 1200.00m;
decimal conta1 = 200.00m;
decimal conta2 = 120.00m;

decimal multac1 = conta1 * 0.02m;
decimal multac2 = conta2 * 0.02m;

decimal totalcontas = conta1 + multac1 + conta2 + multac2;

decimal resto = salario - totalcontas;


Console.WriteLine(" o valor restante do João: " + resto);