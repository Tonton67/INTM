using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_IV
{
    public class Morse
    {
        private const string Taah = "===";
        private const string Ti = "=";
        private const string Point = ".";
        private const string PointLetter = "...";
        private const string PointWord = ".....";

        private readonly Dictionary<string, char> _alphabet;

        public Morse()
        {
            _alphabet = new Dictionary<string, char>()
            {
                {$"{Ti}.{Taah}", 'A'},
                {$"{Taah}.{Ti}.{Ti}.{Ti}", 'B'},
                {$"{Taah}.{Ti}.{Taah}.{Ti}", 'C'},
                {$"{Taah}.{Ti}.{Ti}", 'D'},
                {$"{Ti}", 'E'},
                {$"{Ti}.{Ti}.{Taah}.{Ti}", 'F'},
                {$"{Taah}.{Taah}.{Ti}", 'G'},
                {$"{Ti}.{Ti}.{Ti}.{Ti}", 'H'},
                {$"{Ti}.{Ti}", 'I'},
                {$"{Ti}.{Taah}.{Taah}.{Taah}", 'J'},
                {$"{Taah}.{Ti}.{Taah}", 'K'},
                {$"{Ti}.{Taah}.{Ti}.{Ti}", 'L'},
                {$"{Taah}.{Taah}", 'M'},
                {$"{Taah}.{Ti}", 'N'},
                {$"{Taah}.{Taah}.{Taah}", 'O'},
                {$"{Ti}.{Taah}.{Taah}.{Ti}", 'P'},
                {$"{Taah}.{Taah}.{Ti}.{Taah}", 'Q'},
                {$"{Ti}.{Taah}.{Ti}", 'R'},
                {$"{Ti}.{Ti}.{Ti}", 'S'},
                {$"{Taah}", 'T'},
                {$"{Ti}.{Ti}.{Taah}", 'U'},
                {$"{Ti}.{Ti}.{Ti}.{Taah}", 'V'},
                {$"{Ti}.{Taah}.{Taah}", 'W'},
                {$"{Taah}.{Ti}.{Ti}.{Taah}", 'X'},
                {$"{Taah}.{Ti}.{Taah}.{Taah}", 'Y'},
                {$"{Taah}.{Taah}.{Ti}.{Ti}", 'Z'},
            };
        }

        public int LettersCount(string code)
        {
            //TODO
            string[] separator = new string[] { PointLetter };
            string[] stringSplit = code.Split(separator, StringSplitOptions.None);
            return stringSplit.Length;
        }

        public int WordsCount(string code)
        {
            //TODO
            string[] separator = new string[] { PointWord };
            string[] stringSplit = code.Split(separator, StringSplitOptions.None);
            return stringSplit.Length;

        }

        public string MorseTranslation(string code)
        {

            //TODO
            string translation = "";

            string[] wordSplit = code.Split(new string[] { PointWord }, StringSplitOptions.None);
            foreach (var word in wordSplit)
            {
                string[] letterSplit = word.Split(new string[] { PointLetter }, StringSplitOptions.None);

                foreach (var letter in letterSplit)
                {
                    translation += GetChar(letter);
                }
                translation += " ";
            }

            return translation;
        }

        private char GetChar(string letter)
        {
            if (_alphabet.ContainsKey(letter))
            {
                return _alphabet[letter];
            }
            return '+';
        }

        public string EfficientMorseTranslation(string code)
        {
            //TODO
            code = code.Trim('.');

            string res = string.Empty;
            int pointCount = 0;
            int startIndex = 0;
            int charLength = 0;

            for (int i = 0; i < code.Length; i++)
            {



                if (code[i] == '.')
                {
                    pointCount++;
                }
                else
                {
                    if (pointCount > 2)
                    {
                        //string letter = code.Substring(startIndex, charLength - pointCount).Replace("..",".");
                        string letter = code.Substring(startIndex, charLength - pointCount);
                        letter = letter.Replace("..", ".");
                        res += GetChar(letter);
                        startIndex = i;
                        charLength = 0;

                    }

                    //if (pointCount >= 3)
                    //{
                    //    res.Append(code, startIndex, charLength);
                    //}

                    if (pointCount >= 5)
                    {
                        res += " ";
                    }
                    pointCount = 0;
                }

                charLength++;

            }
            res += GetChar(code.Substring(startIndex, charLength).Replace("..", "."));


            return res;
        }

        public string MorseEncryption(string sentence)
        {
            //TODO

            StringBuilder sb = new StringBuilder();
            //foreach (var c in sentence)
            //{
            //    if (_alphabet.ContainsKey(c))
            //    {
            //        sb.Append(_alphabet.First(x => x.Value == c].Key + PointLetter))
            //    }
            //    else if (c == ' ')
            //    {
            //        sb.Append("..");
            //    }
            //}
            //return string.Empty;


            string code = "";
            foreach (char letter in sentence.ToUpper())
            {
                if (letter == ' ')
                {
                    code += "..";
                }
                var res = _alphabet.FirstOrDefault(x => x.Value == letter);
                if (!string.IsNullOrEmpty(res.Key))
                {
                    code += res.Key + "...";
                }
            }
            return code.Trim('.');



        }
    }
}
