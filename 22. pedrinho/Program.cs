
        int moeda1 = 0, moeda5 = 0, moeda10 = 0, moeda25 = 0, moeda50 = 0, moeda1R = 0;
        double total = 0;

        Console.WriteLine("Digite a quantidade de moedas de 1 centavo:");
        moeda1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de moedas de 5 centavos:");
        moeda5 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de moedas de 10 centavos:");
        moeda10 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de moedas de 25 centavos:");
        moeda25 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de moedas de 50 centavos:");
        moeda50 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de moedas de 1 real:");
        moeda1R = Convert.ToInt32(Console.ReadLine());

        total = (moeda1 * 0.01) + (moeda5 * 0.05) + (moeda10 * 0.10) +
                (moeda25 * 0.25) + (moeda50 * 0.50) + (moeda1R * 1.00);

        Console.WriteLine("Total economizado: R$"  + total);
    
