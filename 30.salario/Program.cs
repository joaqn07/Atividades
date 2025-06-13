decimal salariofixo;

Console.WriteLine(" me informe seu salario: ");
salariofixo = Convert.ToDecimal(Console.ReadLine());

decimal vendas;
Console.WriteLine(" agora me informe o valor total das vendas: ");
vendas = Convert.ToDecimal(Console.ReadLine());

decimal comissao = vendas * 0.04m;
decimal salariofinal = salariofixo + comissao;

Console.WriteLine(" a comissao é " + comissao + " e o salario final é: " + salariofinal);

