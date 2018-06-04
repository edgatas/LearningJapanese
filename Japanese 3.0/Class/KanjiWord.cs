using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Japanese
{
    class KanjiWord
    {

        private string kanji;
        private string furigana;
        private string romaji;
        private string english;
        private string category;

        // Constractor
        public KanjiWord()
        {
            // Adding things only after building an object
        }
        public KanjiWord(string kanji,
                        string furigana,
                        string romaji,
                        string english,
                        string category)
        {
            this.kanji = kanji;
            this.furigana = furigana;
            this.romaji = romaji;
            this.english = english;
            this.category = category;
        }

        // ***Getters*** //
        //public string getKanji { get { return kanji; } set { kanji = value; } }
        //public string getRomaji { get { return romaji; } set { romaji = value; } }
        //public string getEnglish { get { return english; } set { english = value; } }
        //public string getCategory { get { return category; } set { category = value; } }
        // This works in interesting way
        // KanjiWord word = new KanjiWord(1,2,3,4);
        // SETTER word.getKanji = "kanji";
        // GETTER word.getKanji = word.Kanji;
        // Not going to use here to not get confused


        // Getters
        public string getKanji() { return kanji; }
        public string getFurigana() { return furigana; }
        public string getRomaji() { return romaji; }
        public string getEnglish() { return english; }
        public string getCategory() { return category; }

        // ***Setters*** //
        public void setKanji(string kanji) { this.kanji = kanji; }
        public void setFurigana(string furigana) { this.furigana = furigana; }
        public void setRomaji(string romaji) { this.romaji = romaji; }
        public void setEnglish(string english) { this.english = english; }
        public void setCategory(string category) { this.category = category; }

        public string print()
        {
            return kanji + " " + furigana + " " + romaji + " " + english;
        }
    }
}
