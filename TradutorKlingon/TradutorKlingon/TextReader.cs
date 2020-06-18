using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        List<Words> listOfWords = new List<Words>();
        StreamWriter x;
        int cont = 0;

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

        public void SortText()
        {
            try
            {
                string path =
                    @"C:\Users\fabio\Documents\Visual Studio 2019\Project\tradutor-klingon\TradutorKlingon\TradutorKlingon\Files\klingon-textoB-ordenado.txt";
                x = File.CreateText(path);

                List<string> resultK = new List<string>();
                List<string> resultB = new List<string>();
                List<string> resultW = new List<string>();
                List<string> resultR = new List<string>();
                List<string> resultQ = new List<string>();
                List<string> resultD = new List<string>();
                List<string> resultN = new List<string>();
                List<string> resultF = new List<string>();
                List<string> resultX = new List<string>();
                List<string> resultJ = new List<string>();
                List<string> resultM = new List<string>();
                List<string> resultL = new List<string>();
                List<string> resultV = new List<string>();
                List<string> resultH = new List<string>();
                List<string> resultT = new List<string>();
                List<string> resultC = new List<string>();
                List<string> resultG = new List<string>();
                List<string> resultZ = new List<string>();
                List<string> resultP = new List<string>();
                List<string> resultS = new List<string>();

                for (int i = 0; i < text.Length; i++)
                {
                    text.ToString().ToLower();

                    switch (text[i][0].ToString())
                    {
                        case "k":
                            resultK.Add(text[i]);
                            break;
                        case "b":
                            resultB.Add(text[i]);
                            break;
                        case "w":
                            resultW.Add(text[i]);
                            break;
                        case "r":
                            resultR.Add(text[i]);
                            break;
                        case "q":
                            resultQ.Add(text[i]);
                            break;
                        case "d":
                            resultD.Add(text[i]);
                            break;
                        case "n":
                            resultN.Add(text[i]);
                            break;
                        case "f":
                            resultF.Add(text[i]);
                            break;
                        case "x":
                            resultX.Add(text[i]);
                            break;
                        case "j":
                            resultJ.Add(text[i]);
                            break;
                        case "m":
                            resultM.Add(text[i]);
                            break;
                        case "l":
                            resultL.Add(text[i]);
                            break;
                        case "v":
                            resultV.Add(text[i]);
                            break;
                        case "h":
                            resultH.Add(text[i]);
                            break;
                        case "t":
                            resultT.Add(text[i]);
                            break;
                        case "c":
                            resultC.Add(text[i]);
                            break;
                        case "g":
                            resultG.Add(text[i]);
                            break;
                        case "z":
                            resultZ.Add(text[i]);
                            break;
                        case "p":
                            resultP.Add(text[i]);
                            break;
                        case "s":
                            resultS.Add(text[i]);
                            break;
                        default:
                            break;
                    }
                }

                //k
                foreach (string item in resultK)
                {
                    listOfWords.Add(_orderWords(item));
                }
                //b
                foreach (string item in resultB)
                {
                    listOfWords.Add(_orderWords(item));
                }
                //w
                foreach (string item in resultW)
                {
                    listOfWords.Add(_orderWords(item));
                }

                //r
                foreach (string item in resultR)
                {
                    listOfWords.Add(_orderWords(item));
                }
                //q
                foreach (string item in resultQ)
                {
                    listOfWords.Add(_orderWords(item));
                }
                //n
                foreach (string item in resultN)
                {
                    listOfWords.Add(_orderWords(item));
                }
                //f
                foreach (string item in resultF)
                {
                    listOfWords.Add(_orderWords(item));
                }
                //x
                foreach (string item in resultX)
                {
                    listOfWords.Add(_orderWords(item));
                }
                //j
                foreach (string item in resultJ)
                {
                    listOfWords.Add(_orderWords(item));
                }
                //m
                foreach (string item in resultM)
                {
                    listOfWords.Add(_orderWords(item));
                }
                //l
                foreach (string item in resultL)
                {
                    listOfWords.Add(_orderWords(item));
                }
                //v
                foreach (string item in resultV)
                {
                    listOfWords.Add(_orderWords(item));
                }
                //h
                foreach (string item in resultH)
                {
                    listOfWords.Add(_orderWords(item));
                }
                //t
                foreach (string item in resultT)
                {
                    listOfWords.Add(_orderWords(item));
                }
                //c
                foreach (string item in resultC)
                {
                    listOfWords.Add(_orderWords(item));
                }
                //g
                foreach (string item in resultG)
                {
                    listOfWords.Add(_orderWords(item));
                }
                //z
                foreach (string item in resultZ)
                {
                    listOfWords.Add(_orderWords(item));
                }
                //p
                foreach (string item in resultP)
                {
                    listOfWords.Add(_orderWords(item));
                }
                //s
                foreach (string item in resultS)
                {
                    listOfWords.Add(_orderWords(item));
                }

                _writeTxt(listOfWords);
                x.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error SortText" + ex.Message);
            }
        }

        public void CountNumbers()
        {

            try
            {
                listString.AddRange(text);
                foreach (string item in listString)
                {
                    ulong al = _changeNumber(item);
                }
                Console.WriteLine(cont);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error CountNumbers" + ex.Message);
            }
        }

        private ulong _changeNumber(string item)
        {
            try
            {
                int weightLetter = 0;
                List<int> li = new List<int>();
                ulong soma = 0;

                for (int i = (item.Length - 1); i >= 0; i--)
                {
                    weightLetter = 0;
                    switch (item[i].ToString())
                    {
                        case "k":
                            weightLetter = 0;
                            break;
                        case "b":
                            weightLetter = 1;
                            break;
                        case "w":
                            weightLetter = 2;
                            break;
                        case "r":
                            weightLetter = 3;
                            break;
                        case "q":
                            weightLetter = 4;
                            break;
                        case "d":
                            weightLetter = 5;
                            break;
                        case "n":
                            weightLetter = 6;
                            break;
                        case "f":
                            weightLetter = 7;
                            break;
                        case "x":
                            weightLetter = 8;
                            break;
                        case "j":
                            weightLetter = 9;
                            break;
                        case "m":
                            weightLetter = 10;
                            break;
                        case "l":
                            weightLetter = 11;
                            break;
                        case "v":
                            weightLetter = 12;
                            break;
                        case "h":
                            weightLetter = 13;
                            break;
                        case "t":
                            weightLetter = 14;
                            break;
                        case "c":
                            weightLetter = 15;
                            break;
                        case "g":
                            weightLetter = 16;
                            break;
                        case "z":
                            weightLetter = 17;
                            break;
                        case "p":
                            weightLetter = 18;
                            break;
                        case "s":
                            weightLetter = 19;
                            break;
                        default:
                            break;
                    }


                    li.Add(weightLetter);

                }

                for (int i = 1; i <= li.Count; i++)
                {
                    var resultPow = (ulong)li[i - 1] * Math.Pow(20, i - 1);
                    soma += (ulong)resultPow;
                }

                int porra = 440566;
                if (soma >= (ulong)porra && (soma % 3) == 0)
                {
                    cont++;
                }

                return soma;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void _writeTxt(List<Words> listOfWords)
        {
            string strTemp = string.Empty;

            try
            {
                listOfWords = listOfWords.OrderBy(l => l.WeightName).ToList();
                for (int i = 0; i < listOfWords.Count; i++)
                {
                    //verifica se tem palavas repetidas
                    if (strTemp != listOfWords[i].ToString())
                    {
                        Console.WriteLine(listOfWords[i]);
                        x.Write(listOfWords[i] + " ");
                        strTemp = listOfWords[i].ToString();
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private Words _orderWords(string item)
        {
            try
            {
                string result = string.Empty;

                for (int i = 0; i < item.Length; i++)
                {
                    switch (item[i].ToString())
                    {
                        case "k":
                            result += "a";
                            break;
                        case "b":
                            result += "b";
                            break;
                        case "w":
                            result += "c";
                            break;
                        case "r":
                            result += "d";
                            break;
                        case "q":
                            result += "e";
                            break;
                        case "d":
                            result += "f";
                            break;
                        case "n":
                            result += "g";
                            break;
                        case "f":
                            result += "h";
                            break;
                        case "x":
                            result += "i";
                            break;
                        case "j":
                            result += "j";
                            break;
                        case "m":
                            result += "k";
                            break;
                        case "l":
                            result += "l";
                            break;
                        case "v":
                            result += "m";
                            break;
                        case "h":
                            result += "n";
                            break;
                        case "t":
                            result += "o";
                            break;
                        case "c":
                            result += "p";
                            break;
                        case "g":
                            result += "q";
                            break;
                        case "z":
                            result += "r";
                            break;
                        case "p":
                            result += "s";
                            break;
                        case "s":
                            result += "t";
                            break;
                        default:
                            break;
                    }
                }

                Words words = new Words();
                words.Name = item;

                words.WeightName = result;
                return words;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}


