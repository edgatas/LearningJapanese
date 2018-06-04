using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Japanese
{
    public class Settings
    {
        bool hiraganaC;
        bool hiraganaG;
        bool hiraganaD;
        bool hiraganaH;
        bool hiraganaY;
        int hiraganaR;
        int hiraganaGR;
        int hiraganaDR;
        int hiraganaHR;
        int hiraganaYR;

        bool katakanaC;
        bool katakanaG;
        bool katakanaD;
        bool katakanaH;
        bool katakanaY;
        int katakanaR;
        int katakanaGR;
        int katakanaDR;
        int katakanaHR;
        int katakanaYR;

        bool kanjiC;
        int kanjiR;

        //Default Constructor
        public Settings()
        {
            //Condition here with reading default settings
            hiraganaC = true;
            hiraganaG = true;
            hiraganaD = true;
            hiraganaH = true;
            hiraganaY = true;
            hiraganaR = 100;
            hiraganaGR = 100;
            hiraganaDR = 100;
            hiraganaHR = 100;
            hiraganaYR = 100;

            katakanaC = true;
            katakanaG = true;
            katakanaD = true;
            katakanaH = true;
            katakanaY = true;
            katakanaR = 100;
            katakanaGR = 100;
            katakanaDR = 100;
            katakanaHR = 100;
            katakanaYR = 100;

            kanjiC = true;
            kanjiR = 100;
        }

        //***GETTERS***//
        public bool getHiraganaC() { return hiraganaC; }
        public bool getHiraganaG() { return hiraganaG; }
        public bool getHiraganaD() { return hiraganaD; }
        public bool getHiraganaH() { return hiraganaH; }
        public bool getHiraganaY() { return hiraganaY; }
        public int getHiraganaR() { return hiraganaR; }
        public int getHiraganaGR() { return hiraganaGR; }
        public int getHiraganaDR() { return hiraganaDR; }
        public int getHiraganaHR() { return hiraganaHR; }
        public int getHiraganaYR() { return hiraganaYR; }

        public bool getKatakanaC() { return katakanaC; }
        public bool getKatakanaG() { return katakanaG; }
        public bool getKatakanaD() { return katakanaD; }
        public bool getKatakanaH() { return katakanaH; }
        public bool getKatakanaY() { return katakanaY; }
        public int getKatakanaR() { return katakanaR; }
        public int getKatakanaGR() { return katakanaGR; }
        public int getKatakanaDR() { return katakanaDR; }
        public int getKatakanaHR() { return katakanaHR; }
        public int getKatakanaYR() { return katakanaYR; }

        public bool getKanjiC() { return kanjiC; }
        public int getKanjiR() { return kanjiR; }

        //**SETTERS***//
        public void setHiraganaC(bool state) { this.hiraganaC = state; }
        public void setHiraganaG(bool state) { this.hiraganaG = state; }
        public void setHiraganaD(bool state) { this.hiraganaD = state; }
        public void setHiraganaH(bool state) { this.hiraganaH = state; }
        public void setHiraganaY(bool state) { this.hiraganaY = state; }
        public void setHiraganaR(int value) { this.hiraganaR = value; }
        public void setHiraganaGR(int value) { this.hiraganaGR = value; }
        public void setHiraganaDR(int value) { this.hiraganaDR = value; }
        public void setHiraganaHR(int value) { this.hiraganaHR = value; }
        public void setHiraganaYR(int value) { this.hiraganaYR = value; }

        public void setKatakanaC(bool state) { this.katakanaC = state; }
        public void setKatakanaG(bool state) { this.katakanaG = state; }
        public void setKatakanaD(bool state) { this.katakanaD = state; }
        public void setKatakanaH(bool state) { this.katakanaH = state; }
        public void setKatakanaY(bool state) { this.katakanaY = state; }
        public void setKatakanaR(int value) { this.katakanaR = value; }
        public void setKatakanaGR(int value) { this.katakanaGR = value; }
        public void setKatakanaDR(int value) { this.katakanaDR = value; }
        public void setKatakanaHR(int value) { this.katakanaHR = value; }
        public void setKatakanaYR(int value) { this.katakanaYR = value; }

        public void setKanjiC(bool state) { this.kanjiC = state; }
        public void setKanjiR(int value) { this.kanjiR = value; }

        public void printToConsole()
        {
            Console.WriteLine("Test");
            Console.WriteLine(hiraganaC.ToString());
            Console.WriteLine(hiraganaG.ToString());
        }
    }
}
