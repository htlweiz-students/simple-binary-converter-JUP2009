using System;
using Binary_converter;

namespace Program00{
    public class Program00{
        public static int Main(string[] argv){
            Console.WriteLine("Enter Type");
            Converter Converter = new Converter(int.Parse(Console.ReadLine()));
            string binary = Converter.Convert_to_binary();
            Console.WriteLine($"Your number: {binary}");
            return 0;
        }
    }
}