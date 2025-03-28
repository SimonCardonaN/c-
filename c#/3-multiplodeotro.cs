using System;
class Main{
    static void Main(){
        int num1,num2:
        Console.WriteLine("Digite el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        if(num1 % num2 == 0){
            Console.WriteLine($"El primer número {num1}es múltiplo del segundo numero{num2}");
        }else if(num2 % num1 == 0){
            Console.WriteLine($"El segundo número {num2} es múltiplo del primero {num1}");
        }
    }
}