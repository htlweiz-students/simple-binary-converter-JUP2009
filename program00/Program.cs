using System;
using binary_converter;

namespace Program00{
    public class Program00{
        public static int Main(string[] argv){
            converter Converter = new converter("011031");
            if(Converter.binary_check()){
                Console.WriteLine("is Binary");
            }else{
                Console.WriteLine("Is not Binary");
            }
            return 0;
        }
    }
}