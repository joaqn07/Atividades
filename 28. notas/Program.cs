
decimal nota1, nota2, media;

      
Console.Write("Digite a primeira nota (peso 2): ");
nota1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a segunda nota (peso 3): ");
nota2 = Convert.ToDecimal(Console.ReadLine());

media = ((nota1 * 2) + (nota2 * 3)) / 5;

Console.WriteLine("A média ponderada é: " + media);
   

