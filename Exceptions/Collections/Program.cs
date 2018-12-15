using System;
using System.Collections.Generic;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            List <string> myStringList = new List<string>();
            myStringList.Add("C#");
            myStringList.Add("java");
            myStringList.Add("javascript");
            myStringList.Add("python");
            foreach (string item in myStringList)
            {
                Console.WriteLine(item);
            }
            if(myStringList.Contains("java"))
            {
                myStringList.Remove("java");

            }
            foreach (string item in myStringList)
            {
                Console.WriteLine(item);
            }
            Zoo myZoo = new Zoo();
            foreach (var animal in myZoo.Animals)
            {
                Console.WriteLine($"This is a {animal.Name} and it's a {animal.Gender}");
            }
            Console.WriteLine("____________________________Stack");
            Stack<string> myStack = new Stack<string>();

            myStack.Push("C#");
            myStack.Push("python");
            myStack.Push("java");
            int count = myStack.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(myStack.Pop());
            }
            Console.WriteLine("____________________________Queue");
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("lapte");
            myQueue.Enqueue("oua");
            myQueue.Enqueue("paine");
            int contor = myQueue.Count;
            for(int i = 0; i < contor; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
            Console.WriteLine("____________________________Dictionary");
            Dictionary<string, decimal> dict = new Dictionary<string, decimal>();
            dict.Add("Mos Craciun", 30.23M);
            dict.Add("Gina", 5m);
            dict.Add("Gigi", 0m);
            foreach(var record in dict)
            {
                Console.WriteLine($"{record.Key} : {record.Value}");
            }
            Dictionary<string, List<string>> keyListDictionary = new Dictionary<string, List<string>>();
            List<ILandBound> landAnimals = new List<ILandBound>();


        }
    }
}
