decimal salariom;

Console.WriteLine(" digite o valor do salario minimo: ");
salariom = Convert.ToDecimal(Console.ReadLine());

decimal salariof;

Console.WriteLine(" digite o valor do salario do funcionario: ");
salariof = Convert.ToDecimal(Console.ReadLine());

decimal quantidade = salariom / salariof;

Console.WriteLine(" esse funcionario ganha " + quantidade + " de salario minimo");

//nao entendi bem, mas tentei.