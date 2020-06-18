using System;

namespace TradutorKlingon
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader textReader = new TextReader();

            Console.WriteLine("Início" + DateTime.Now);
            Console.WriteLine("----------- Contador de Preposições");
            textReader.CountPreposition();

            Console.ReadLine();


        }
    }
}
