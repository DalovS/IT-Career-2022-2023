﻿namespace NamesList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(',').ToList();

            foreach (var item in list)
            {
                var parts = item.Trim().Split(' ').ToList();
                Console.WriteLine("{0} {1}", parts[1], parts[0]);
            }
        }
    }
}