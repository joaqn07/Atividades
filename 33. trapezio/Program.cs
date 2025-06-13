decimal basemaior;


Console.WriteLine(" digite a base maior do trapezio: ");
basemaior = Convert.ToDecimal(Console.ReadLine());

decimal basemenor;

Console.WriteLine(" digite a base menor: ");
basemenor = Convert.ToDecimal(Console.ReadLine());


decimal altura;

Console.WriteLine(" digite a altura do trapezio: ");
altura = Convert.ToDecimal(Console.ReadLine());

if (basemaior == basemenor || basemenor >= basemaior) 
{

    Console.WriteLine(" as medidas informadas são iguais, logo isso não forma um trapezio");
   
}
        decimal area = ((basemaior + basemenor) * altura) / 2;

Console.WriteLine(" a area do trapezio é " + area);

