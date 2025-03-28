using System;
class Program
{
    static void Main
    {
        int num1, num2, num3;
    Console.WriteLine("Digite el primer número: "); 
        num1 =(Console.ReadLine());

        Console.WriteLine("Digite el segundo número: ");
        num2 =(Console.ReadLine());

        Console.WriteLine("Digite el tercer número: ");
        num3 =(Console.ReadLine());
        }
if (num1.TryParse(num1, out numero1) && num2.TryParse(num2, out numero2) && num3.TryParse(num3, out numero3))
{
    
if (numero1 > numero2 && numero1 > numero3)
{
    may = numero1;
    if (numero2 > numero3)
    {
        med = numero2;
        men = numero3;
    }
    else
    {
        med = numero3;
        men = numero2;
    }
}
else if (numero2 > numero1 && numero2 > numero3)
{
    may = numero2;
    if (numero1 > numero3)
    {
        med = numero1;
        men = numero3;
    }
    else
    {
        med = numero3;
        men = numero1;
    }
}
else
{
    may = numero3;
    if (numero1 > numero2)
    {
        med = numero1;
        men = numero2;
    }
    else
    {
        med = numero2;
        men = numero1;
    }
}
Console.WriteLine($"Mayor: {may}, Medio: {med}, Menor: {men}");
}else{
    Console.WriteLine("Error, digite un número válido");
}

}
}