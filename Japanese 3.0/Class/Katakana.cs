using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Japanese
{
    class Katakana
    {
        private List<string> katakanas;
        private List<string> romajis;

        //*****GETTERS*****//
        public string  getCharacterK(int index) { return katakanas.ElementAt<string>(index); }
        public string getCharacterR(int index) { return romajis.ElementAt<string>(index); }

        public Katakana()
        {
            katakanas = new List<string>();
            romajis = new List<string>();
            
            string kataPath = @"data\katakana.txt";
            string romPath = @"data\hirKatRomaji.txt";

            StreamReader reader;
            string line;

            // Katakana Reading
            reader = new StreamReader(kataPath);
            while ((line = reader.ReadLine()) != null)
            {
                katakanas.Add(line);
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
            return katakanas.Count;
        }

        public void print()
        {
            int length = katakanas.Count;
            int length2 = romajis.Count;
            Console.WriteLine(length + " " + length2);
            for (int i = 0; i < length; i++)
            {
                Console.Write(katakanas.ElementAt<string>(i));
            }
            for (int i = 0; i < length2; i++)
            {
                Console.Write(romajis.ElementAt<string>(i));
            }
        }

    }
}
