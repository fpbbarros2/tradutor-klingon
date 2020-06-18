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

                Console.WriteLine("Error CountPreposition" + ex.Message);
            }
        }

        public void CountVerbs()
        {
            try
            {
                int verboCont = 0;
                int verboContP = 0;
                string[] letterFOO = lettersFOO.Split(",");

                foreach (var word in text)
                {
                    if (word.Length >= 8)
                    {
                        bool lfoo = false;

                        for (int i = 0; i < letterFOO.Length; i++)
                        {
                            if (!lfoo)
                            {
                                if (word[(int)word.Length - 1].ToString() == letterFOO[i])
                                {
                                    lfoo = true;

                                }
                                else
                                {
                                    lfoo = false;
                                }
                            }
                        }
                        if (lfoo)
                        {
                            verboCont++;
                            Console.WriteLine(word);
                            bool vPrimeiraPessoa = false;

                            for (int i = 0; i < letterFOO.Length; i++)
                            {
                                if (!vPrimeiraPessoa)
                                {
                                    if (word[0].ToString() == letterFOO[i])
                                    {
                                        vPrimeiraPessoa = true;
                                    }
                                    else
                                    {
                                        vPrimeiraPessoa = false;
                                    }
                                }
                            }

                            if (!vPrimeiraPessoa)
                            {
                                verboContP++;
                            }
                        }
                    }
                }
                Console.WriteLine(verboCont);
                Console.WriteLine(verboContP);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error CountVerbs" + ex.Message);
            }
        }



    }
}
