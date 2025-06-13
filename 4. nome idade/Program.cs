string nome;
int idade, dias;

Console.WriteLine(" por favor me diga seu nome: ");
nome = Console.ReadLine();

Console.WriteLine(" agora me diga sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

dias = idade * 365;

Console.WriteLine(" ola " + nome + "voce possui " + dias + " dias de vida");