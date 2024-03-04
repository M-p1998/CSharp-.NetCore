// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
namespace Basic
{
    public class Program
    {
        // Print 1-255
        public static void PrintNumbers()
        {
            for(int i=1; i<=255; i++){
                Console.Write(i + " ");
                
            }
        }
        // Print odd numbers between 1-255
        public static void PrintOdds()
        {
            for(int i=1; i<=255; i++){
                if(i % 2 != 0){
                    Console.Write(i + " ");
                }
                
            }
        }

        // Print Sum
        static int sum = 0;
        public static void PrintSum()
        {
            for(int i=1; i<=255; i++){
                sum += i;
                Console.WriteLine(sum + " ");
                
            }
        }
        public static void Main(string[] args)
        {
            PrintNumbers();
            Console.WriteLine();
            PrintOdds();
            PrintSum();
        }
    
}
}