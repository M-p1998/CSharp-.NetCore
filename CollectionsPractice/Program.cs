// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
namespace CollectionsPractice
{
    class Program{
        static void Main(String[] args){
            int[] arr = new int[] {0,1,2,3,4,5,6,7,8,9};
            string[] str =  { "Tim", "Martin", "Nikki", "Sara"};
            bool[] booleanArray = new bool[10];
            for(int i=0; i< booleanArray.Length; i++){
                // if(i % 2 == 0){
                //     booleanArray[i] = true;
                // }
                // else{
                //     booleanArray[i] = false;
                // }
                booleanArray[i] = i % 2 == 0;
            }
            Console.Write("Integer arr: ");
            foreach(int num in arr){
                Console.Write(num + " ");
            }

            Console.Write("\nString array: ");
            foreach(string small in str){
                Console.Write(small + " ");
            }

            Console.Write("\nBoolean array: ");
            foreach(bool tOrF in booleanArray){
                Console.Write(tOrF + " ");
            }

            // List of flavors
            List<string> sr = new List<string>();
            sr.Add("choco");
            sr.Add("mint");
            sr.Add("strawberry");
            sr.Add("coffee");
            sr.Add("rocknroll");

            Console.WriteLine("\nList of flavors: ");
            Console.WriteLine(sr.Count);
            Console.Write(sr[2]);
            sr.RemoveAt(2);
            Console.Write(sr.Count);

            string[] names = { "Alice", "Bob", "Charlie", "David", "Eve" };
            string[] flavors = { "Vanilla", "Chocolate", "Strawberry", "Mint", "Cookie Dough" };

            Dictionary<string,string> dict = new Dictionary<string, string>();
            
            // Add key/value pairs to the dictionary
            Random random = new Random();
            foreach (string name in names)
            {
                int index = random.Next(flavors.Length);
                string flavor = flavors[index];
                dict[name] = flavor;
            }
            Console.WriteLine();
            foreach(KeyValuePair<string,string> entry in dict){
                Console.WriteLine("\n" + entry.Key + " - " + entry.Value);
            }
        }
    }
}