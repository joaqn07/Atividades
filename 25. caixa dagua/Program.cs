
decimal diametro, altura, raio, volumeCm3, volumeLitros;
decimal pi = 3.1416m;
      
        Console.Write("Informe o diâmetro da caixa d'água (em cm): ");
        diametro = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Informe a altura da caixa d'água (em cm): ");
        altura = Convert.ToDecimal(Console.ReadLine());

       
        raio = diametro / 2;


volumeCm3 = pi * raio * raio * altura;


volumeLitros = volumeCm3 / 1000;


Console.WriteLine("O volume da caixa d'água é de " + volumeLitros + "litros");
