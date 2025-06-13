
        Console.Write("Informe o valor total da conta: R$ ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal total) || total < 0)
        {
            Console.WriteLine("Valor inválido.");
            return;
        }

     
        decimal dividido = total / 3m;


        int parteCarlos = (int)Math.Floor(dividido);
        int parteAndre = (int)Math.Floor(dividido);

        decimal parteFelipe = total - parteCarlos - parteAndre;

        Console.WriteLine("Carlos deve pagar: R$ " + parteCarlos);
        Console.WriteLine("André deve pagar:   R$ " + parteAndre);
        Console.WriteLine("Felipe deve pagar: R$ " + parteFelipe);
        Console.WriteLine("Soma total:        R$ " + (parteCarlos + parteAndre + parteFelipe));
    