using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;
using System.IO;

namespace Japanese
{
    class Kanji
    {
        private List<KanjiWord> kanji;

        // Constructor
        public Kanji()
        {
            kanji = new List<KanjiWord>();
            readWords();
        }

        // Add new Kanji word to the list
        public void addWord(KanjiWord newWord)
        {
            kanji.Add(newWord);
        }

        // Get the list length
        public int getLength()
        {
            return kanji.Count();
        }

        // Get word at specified index
        public KanjiWord getWord(int index)
        {
            return kanji.ElementAt<KanjiWord>(index);
        }

        // Removes an element from the list with specified index
        public void deleteWord(int index)
        {
            kanji.RemoveAt(index);
        }

        // Saves the list tofile and reads it back again
        public void updateList()
        {
            writeWords();
            kanji = new List<KanjiWord>();
            readWords();
        }

        // Reading kanji words form a text file. The text file has a specific format
        private void readWords()
        {

            string kanjiPath = @"data\kanji.txt";

            StreamReader reader;
            string line;

            // Hiragana reading
            reader = new StreamReader(kanjiPath);
            while ((line = reader.ReadLine()) != null)
            {
                // Author Ahmad Mageed
                // From here ***
                var delimiters = new List<string> { "#k#", "#f#", "#r#", "#m#", "#e#" };
                    string pattern = "(" + String.Join("|", delimiters.Select(d => Regex.Escape(d))
                                                                  .ToArray())
                                  + ")";

                string[] result = Regex.Split(line, pattern);
                // To here ***

                KanjiWord kanjiWord = new KanjiWord();
                int stringLength = result.Length;

                for (int index = 0; index < stringLength; index++)
                {
                    switch(result[index])
                    {
                        case "#k#":
                            kanjiWord.setKanji(result[index + 1]);
                            index++;
                            break;
                        case "#f#":
                            kanjiWord.setFurigana(result[index + 1]);
                            index++;
                            break;
                        case "#r#":
                            kanjiWord.setRomaji(result[index + 1]);
                            index++;
                            break;
                        case "#m#":
                            kanjiWord.setEnglish(result[index + 1]);
                            index++;
                            break;
                        case "#e#":
                            break;
                    }
                }
                kanji.Add(kanjiWord);
            }
            reader.Close();
        }

        public void writeWords()
        {
            StreamWriter writer = new StreamWriter(@"data\kanji.txt", false);

            for (int i = 0; i < kanji.Count;i++)
            {
                KanjiWord word = kanji.ElementAt<KanjiWord>(i);
                StringBuilder line = new StringBuilder();
                line.Append("#k#");
                line.Append(word.getKanji());
                line.Append("#f#");
                line.Append(word.getFurigana());
                line.Append("#r#");
                line.Append(word.getRomaji());
                line.Append("#m#");
                line.Append(word.getEnglish());
                line.Append("#e#");
                writer.WriteLine(line.ToString());
            }
            writer.Close();
        }

        public bool matchKanji(string word)
        {
            for (int index = 0; index < kanji.Count; index++)
            {
                if (kanji.ElementAt<KanjiWord>(index).getKanji().Equals(word))
                {
                    return true;
                }
            }
            return false;
        }
        public bool matchFurigana(string word)
        {
            for (int index = 0; index < kanji.Count; index++)
            {
                if (kanji.ElementAt<KanjiWord>(index).getFurigana().Equals(word))
                {
                    return true;
                }
            }
            return false;
        }
        public bool matchRomaji(string word)
        {
            for (int index = 0; index < kanji.Count; index++)
            {
                if (kanji.ElementAt<KanjiWord>(index).getRomaji().ToLower().Equals(word.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }
        public bool matchEnglish(string word)
        {
            for (int index = 0; index < kanji.Count; index++)
            {
                if (kanji.ElementAt<KanjiWord>(index).getEnglish().ToLower().Equals(word.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }



        
    }
}
