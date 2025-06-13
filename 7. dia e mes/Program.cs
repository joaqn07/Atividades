
        Console.Write("Informe o mês (1–12): ");
        int mes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o dia (1–30): ");
        int dia = Convert.ToInt32(Console.ReadLine());

    
        if (mes < 1 || mes > 12 || dia < 1 || dia > 30)
        {
            Console.WriteLine("Mês deve estar entre 1 e 12, dia entre 1 e 30.");
            return;
        }

        int diasPassados = (mes - 1) * 30 + dia;

        Console.WriteLine(" Já se passaram " + diasPassados + " dias desde o início do ano.");
    

