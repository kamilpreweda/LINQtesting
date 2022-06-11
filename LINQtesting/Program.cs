﻿namespace LINQtesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfObjects = new List<PrintWhenGetting>();
            for (int i = 0; i < 5; i++)
            {
                listOfObjects.Add(new PrintWhenGetting() { InsantceNumber = i });
            }

            Console.WriteLine("Przygotowywanie kwerendy");
            var result =
                from o in listOfObjects
                select o.InsantceNumber;

            Console.WriteLine("Uruchamianie pętli foreach");
            foreach (var number in result)
            {
                Console.WriteLine($"Zapis nr {number}");
            }
        }


    }
}