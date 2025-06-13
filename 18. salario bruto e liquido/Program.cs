decimal horas;

Console.WriteLine(" Ola caro funcionario. somos da empresa hipotheticus, gostariamos de saber quantas horas voce trabalhu hoje!: ");
horas = Convert.ToDecimal(Console.ReadLine());

decimal horaextra;

Console.WriteLine(" INCRIVEL, agora me informe quantas horas extras vc fez: ");
horaextra = Convert.ToDecimal(Console.ReadLine());

decimal valorn = 10.0m;
decimal valorextra = 15.0m;

decimal salarioB = (horas * valorn) + (horaextra * valorextra);

decimal salarioL = salarioB * 0.90m;

Console.WriteLine(" o salario bruto foi " + salarioB + " entretanto com os impostos, o salario liquido acabou sendo " + salarioL);


