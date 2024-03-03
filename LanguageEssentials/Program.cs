// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace LanguageEssentials
{
    class Program
    {
        static void Main(string[] args){
            for(int i=1; i<=255; i++){
                Console.WriteLine(i + " ");
            }
            for(int i=1; i<=100; i++){
                if(i % 3 ==0 && i % 5 ==0){
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0){
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0){
                    Console.WriteLine("Buzz");
                }else{
                    Console.WriteLine(i);
                }
                
            }
            
        }
    }
}

