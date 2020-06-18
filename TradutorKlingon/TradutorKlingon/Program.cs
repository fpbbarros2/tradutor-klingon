using System;

namespace TradutorKlingon
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader textReader = new TextReader();

            Console.WriteLine("-----------Início " + DateTime.Now);

            Console.WriteLine("----------- Contador de Preposições");
            textReader.CountPreposition();

            Console.WriteLine("----------- Contador de Verbos");
            textReader.CountVerbs();

            Console.WriteLine("----------- Contador de Ordenar Palavras");
            textReader.SortText();

            Console.WriteLine("----------- Contador de Contador de Números");
            textReader.CountNumbers();

            Console.WriteLine("-----------Final " + DateTime.Now);

            Console.ReadLine();


        }
    }
}
