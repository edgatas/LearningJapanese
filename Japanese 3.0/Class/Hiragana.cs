using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Japanese
{
    class Hiragana
    {
        private List<string> hiraganas;
        private List<string> romajis;
        
        //*****GETTERS*****//
        public string getCharacterK(int index) { return hiraganas.ElementAt<string>(index); }
        public string getCharacterR(int index) { return romajis.ElementAt<string>(index); }

        public Hiragana()
        {
            hiraganas = new List<string>();
            romajis = new List<string>();
            
            string hirPath = @"data\hiragana.txt";
            string romPath = @"data\hirKatRomaji.txt";

            StreamReader reader;
            string line;

            // Hiragana reading
            reader = new StreamReader(hirPath);
            while ((line = reader.ReadLine()) != null)
            {
                hiraganas.Add(line);
            }

            // Romaji Reading
            reader = new StreamReader(romPath);
            while ((line = reader.ReadLine()) != null)
            {
                romajis.Add(line);
            }
        }

        public int getLength()
        {
            return hiraganas.Count;
        }

        public void print()
        {
            int length = hiraganas.Count;
            int length2 = romajis.Count;
            Console.WriteLine(length + " " + length2);
            for (int i = 0; i < length; i++)
            {
                Console.Write(hiraganas.ElementAt<string>(i));
            }
            for (int i = 0; i < length2; i++)
            {
                Console.Write(romajis.ElementAt<string>(i));
            }
        }

    }
}
