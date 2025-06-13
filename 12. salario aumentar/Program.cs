decimal salario;

Console.WriteLine(" me informe qual foi seu salario ");
salario = Convert.ToDecimal(Console.ReadLine());

decimal aumento = salario * 0.15m;
decimal salarioAu = salario + aumento;

decimal ahlula = salarioAu * 0.08m;
decimal imposto = salarioAu - ahlula;


Console.WriteLine(" o seu salario foi " + salario + " ,pos o aumento ficou " + salarioAu + " e por fim descontando os impostos ficou " + imposto);

