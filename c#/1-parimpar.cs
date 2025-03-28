using System;
class Program{
    static void Main(){
        int num;
        Console.WriteLine("Digite um número: ");
        num =(Console.ReadLine());
        if(num.TryParse(num, out numero)){
            if(numero % 2 == 0){
            Console.WriteLine("el número es par");
        }else{
            Console.WriteLine("el número es ímpar");
        }
        }else{
            return 0;
        }
        
    }
    
}