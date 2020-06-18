using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TradutorKlingon
{
    public class TextReader
    {
        string[] text = File.ReadAllText
            (@"C:\Users\fabio\Documents\Visual Studio 2019\Project\tradutor-klingon\TradutorKlingon\TradutorKlingon\Files\klingon-textoB.txt")
            .Split(" ");
        List<string> listString = new List<string>();
        string lettersFOO = "s,l,f,w,k";

        public void CountPreposition()
        {
            try
            {
                int prepositionsCont = 0;
                string[] letrasFoo = lettersFOO.Split(",");

                foreach (var word in text)
                {
                    if (word.Length == 3 && !word.Contains("d"))
                    {
                        bool lbar = false;

                        for (int i = 0; i < letrasFoo.Length; i++)
                        {
                            if (!lbar)
                            {
                                if (word[2].ToString() != letrasFoo[i])
                                {
                                    lbar = false;
                                }
                                else
                                {
                                    lbar = true;
                                }
                            }
                        }
                        if (!lbar)
                        {
                            prepositionsCont++;
                            Console.WriteLine(word);
                        }
                    }
                }
                Console.WriteLine(prepositionsCont);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error" + ex.Message);
            }
        }




    }
}
