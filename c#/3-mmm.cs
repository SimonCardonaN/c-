using System;

class Program
{
    static void Main()
    {
        int num1, num2, num3, may, men, med;

        Console.WriteLine("Digite el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite el tercer número: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2 && num1 > num3){
            may = num1;
            if (num2 > num3){
                med = num2;
                men = num3;
            }
            else{
                med = num3;
                men = num2;
            }
        }
        else if (num2 > num1 && num2 > num3)
        {
            may = num2;
            if (num1 > num3)
            {
                med = num1;
                men = num3;
            }
            else
            {
                med = num3;
                men = num1;
            }
        }
        else
        {
            may = num3;
            if (num1 > num2)
            {
                med = num1;
                men = num2;
            }
            else
            {
                med = num2;
                men = num1;
            }
        }

        Console.WriteLine($"Mayor: {may}, Medio: {med}, Menor: {men}");
    }
}