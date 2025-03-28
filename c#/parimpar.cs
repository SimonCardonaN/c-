using system;
class Program{
    static void Main(){
        int num;
        Console.WriteLine("Digite um número: ");
        num = int.ConvertToInt32(Console.ReadLine());
        if(num % 2 == 0){
            Console.WriteLine("el número es par");
        }else{
            Console.WriteLine("el número es ímpar");
        }
    }
    
}