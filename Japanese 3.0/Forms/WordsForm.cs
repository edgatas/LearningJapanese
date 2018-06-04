using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Japanese.Forms
{
    public partial class WordsForm : Form
    {
        Hiragana hiragana;
        Katakana katakana;
        Kanji kanji;
        Settings settings;
        settingsForm settingsForm;
        string currentEnglish;
        string currentRomaji;
        bool error;
        bool debug;

        private int category1;
        private int category2;
        private int category3;
        private int category4;


        public WordsForm(Settings settings)
        {
            error = false;
            debug = true;
            hiragana = new Hiragana();
            katakana = new Katakana();
            kanji = new Kanji();
            if (debug) { Console.WriteLine("Kanji List Length at initialization: " + kanji.getLength()); }

            InitializeComponent();
            this.settings = settings;

            category1 = 45;
            category2 = 20;
            category3 = 4;
            category4 = 32;
        }

        private void wordGenerator()
        {
            cleanFields();
            furiganaText.Hide();
            englishText.Hide();
            int wordType = calculateType();
            int wordSubType;

            switch(wordType)
            {
                case 1:
                    wordSubType = calculateHiraganaSubType();
                    if (debug) { Console.WriteLine("Hiragana subtype: " + wordSubType); }
                    generateHiraganaWord(wordSubType);
                    break;
                case 2:
                    wordSubType = calculateKatakanaSubType();
                    if (debug) { Console.WriteLine("Katakana subtype: " + wordSubType); }
                    generateKatakanaWord(wordSubType);
                    break;
                case 3:
                    generateKanjiWord();
                    break;
                default:
                    status.Text = "Nothing to display for Kana/Kanji. Please check your settings. ";
                    error = true;
                    break;
            }
            if (debug) { Console.WriteLine("1 - Hiragana, 2 -Katakana 3 - Kanji, Error1: " + wordType); }


        }



        /**
         * Returns:
         * 1 hiragana
         * 2 katakana
         * 3 kanji
         **/
        private int calculateType()
        {
            int hiraganaR;
            int katakanaR;
            int kanjiR;

            showFurigana.Enabled = false;
            answerFurigana.Enabled = false;
            this.ActiveControl = answerEnglish;

            if (settings.getHiraganaC() == true)
            {
                hiraganaR = settings.getHiraganaR();
            }
            else
            {
                hiraganaR = 0;
            }

            if (settings.getKatakanaC() == true)
            {
                katakanaR = settings.getKatakanaR();
            }
            else
            {
                katakanaR = 0;
            }
                
            if (settings.getKanjiC() == true)
            {
                kanjiR = settings.getKanjiR();
            }
            else
            {
                kanjiR = 0;
            }
             
            int ratioSum = hiraganaR + katakanaR + kanjiR;

            if (debug)
            {
                Console.WriteLine("Hiragana, Katakana, Kanji, RatioSum: " +
                                hiraganaR + " " + katakanaR + " " + kanjiR + " " + ratioSum);
            }            
             
            // If all types are disabled, fast quit
            if (ratioSum == 0)
            {
                return 0;
            }

            int genNumber = numberGenerator(1,ratioSum);
            if (debug) {  Console.WriteLine("Generated Number from type: From " + "1 " + "to " + ratioSum + " = " + genNumber); }
            if (genNumber <= hiraganaR)
            {
                return 1;
            }
            else
            {
                genNumber = genNumber - hiraganaR;
                if (genNumber < katakanaR)
                {
                    return 2;
                }
                else
                {
                    showFurigana.Enabled = true;
                    answerFurigana.Enabled = true;
                    this.ActiveControl = answerFurigana;
                    return 3;
                }
            }
        }


        /**
         * 1 - Gojūon
         * 2 - Dakuon
         * 3 - Handakuon
         * 4 - Yōon
         */
        public int calculateHiraganaSubType()
        {
            // Ratios
            int hiraganaG;
            int hiraganaD;
            int hiraganaH;
            int hiraganaY;

            // Checks if enabled
            if (settings.getHiraganaG() == true)
            {
                hiraganaG = settings.getHiraganaGR() * category1;
            }
            else
            {
                hiraganaG = 0;
            }

            if (settings.getHiraganaD() == true)
            {
                hiraganaD = settings.getHiraganaDR() * category2;
            }
            else
            {
                hiraganaD = 0;
            }

            if (settings.getHiraganaH() == true)
            {
                hiraganaH = settings.getHiraganaHR() * category3;
            }
            else
            {
                hiraganaH = 0;
            }

            if (settings.getHiraganaY() == true)
            {
                hiraganaY = settings.getHiraganaYR() * category4;
            }
            else
            {
                hiraganaY = 0;
            }

            int ratioSum = hiraganaG + hiraganaD + hiraganaH + hiraganaY;

            if (debug)
            {
                Console.WriteLine("HiraganaG, HiraganaD, HiraganaH, HiraganaY, RatioSum" +
                                hiraganaG + " " + hiraganaD + " " + hiraganaH + " " + hiraganaY + " " + ratioSum);
            }

            if (ratioSum == 0)
            {
                status.Text = "Nothing to display in Hiragana. Please check your settings.";
                error = true;
                return 0;
            }

            int genNumber = numberGenerator(0,ratioSum);

            if (debug)
            {
                Console.WriteLine("Number generated for Hiragana subtype: " + genNumber);
            }

            if (genNumber < hiraganaG)
            {
                return 1;
            }
            else
            {
                genNumber = genNumber - hiraganaG;
                if (genNumber < hiraganaD)
                {
                    return 2;
                }
                else
                {
                    genNumber = genNumber - hiraganaD;
                    if (genNumber <= hiraganaH)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

         /**
         * 1 - Gojūon
         * 2 - Dakuon
         * 3 - Handakuon
         * 4 - Yōon
         */
        public int calculateKatakanaSubType()
        {
            // Ratios
            int katakanaG;
            int katakanaD;
            int katakanaH;
            int katakanaY;

            // Checks if enabled
            if (settings.getKatakanaG() == true)
            {
                katakanaG = settings.getKatakanaGR() * category1;
            }
            else
            {
                katakanaG = 0;
            }

            if (settings.getKatakanaD() == true)
            {
                katakanaD = settings.getKatakanaDR() * category2;
            }
            else
            {
                katakanaD = 0;
            }

            if (settings.getKatakanaH() == true)
            {
                katakanaH = settings.getKatakanaHR() * category3;
            }
            else
            {
                katakanaH = 0;
            }

            if (settings.getKatakanaY() == true)
            {
                katakanaY = settings.getKatakanaYR() * category4;
            }
            else
            {
                katakanaY = 0;
            }

            int ratioSum = katakanaG + katakanaD + katakanaH + katakanaY;

            if (debug)
            {
                Console.WriteLine("KatakanaG, KatakanaD, KatakanaH, KatakanaY, RatioSum" +
                            katakanaG + " " + katakanaD + " " + katakanaH + " " + katakanaY + " " + ratioSum);
            }

            if (ratioSum == 0)
            {
                status.Text = "Nothing to display in Katakana. Please check your settings.";
                error = true;
                return 0;
            }

            int genNumber = numberGenerator(0, ratioSum);

            if (genNumber <= katakanaG)
            {
                return 1;
            }
            else
            {
                genNumber = genNumber - katakanaG;
                if (genNumber <= katakanaD)
                {
                    return 2;
                }
                else
                {
                    genNumber = genNumber - katakanaD;
                    if (genNumber <= katakanaH)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        public void generateHiraganaWord(int subType)
        {
            int position;
            switch(subType)
            {
                case 1:
                    position = numberGenerator(0, 45);
                    break;
                case 2:
                    position = numberGenerator(46, 65);
                    break;
                case 3:
                    position = numberGenerator(66, 70);
                    break;
                case 4:
                    position = numberGenerator(71, 103);
                    break;
                default:
                    position = -1;
                    break;
            }
            if (debug) { Console.WriteLine("Hiragana index in file: " + position); }
            if (position >= 0)
            {
                japaneseText.Text = hiragana.getCharacterK(position);
                englishText.Text = hiragana.getCharacterR(position);
                englishText.Hide();
                currentEnglish = englishText.Text;
        }
            else
            {
                status.Text = "Error. Please check your Hiragana settings";
                error = true;
            }
}

        public void generateKatakanaWord(int subType)
        {
            int position;

            switch (subType)
            {
                case 1:
                    position = numberGenerator(0, 45);
                    break;
                case 2:
                    position = numberGenerator(46, 65);
                    break;
                case 3:
                    position = numberGenerator(66, 70);
                    break;
                case 4:
                    position = numberGenerator(71, 103);
                    Console.WriteLine("!!!");
                    break;
                default:
                    position = -1;
                    break;
            }
            if (debug) { Console.WriteLine("Katakana index in file: " + position); }
            if (position >= 0)
            {
                japaneseText.Text = katakana.getCharacterK(position);
                englishText.Text = katakana.getCharacterR(position);
                englishText.Hide();
                currentEnglish = japaneseText.Text;
            }
            else
            {
                status.Text = "Error. Please check your Katakana Settings";
                error = true;
            }

        }

        private void generateKanjiWord()
        {
            if (debug) { Console.WriteLine("Kanji List Length: " + kanji.getLength()); }
            int index = numberGenerator(0, kanji.getLength());
            KanjiWord word = kanji.getWord(index);
            japaneseText.Text = word.getKanji();
            furiganaText.Text = word.getFurigana();
            englishText.Text = word.getEnglish();
            currentEnglish = englishText.Text;
            currentRomaji = word.getRomaji();
        }


        private void generateNext_Click(object sender, EventArgs e)
        {
            wordGenerator();         
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsForm = new settingsForm(settings);
            settingsForm.ShowDialog();
            if (settingsForm.getSafeClose())
            {
                settings = settingsForm.returnSettings();
            }
            settingsForm.Dispose();
        }

        // Reveals 
        private void showEnglish_Click(object sender, EventArgs e)
        {
            englishText.Show();
        }
        private void showFurigana_Click(object sender, EventArgs e)
        {
            furiganaText.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                while (!error)
                {
                    wordGenerator();
                }
                error = false;

            }).Start();

        }

        private int numberGenerator(int from, int to)
        {
            Random generator = new Random();
            return generator.Next(from, to);
        }

        private void answerFurigana_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Int32)Keys.Enter)
            {
                e.Handled = true;
                this.ActiveControl = answerEnglish;
            }
        }
        private void answerEnglish_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Int32)Keys.Enter)
            {
                e.Handled = true;
                checkAnswer();
            }
        }

        private void submitAnswer_Click(object sender, EventArgs e)
        {
            checkAnswer();
        }

        private void checkAnswer()
        {
            bool furiganaCorrect = false;
            bool englishCorrect = false;
            string furigana = answerFurigana.Text.ToLower();
            string english = answerEnglish.Text.ToLower();

            if (debug) { Console.WriteLine("Written Furigana: " + furigana + " Answer: " + currentRomaji +
                                           "Written English: " + english + " Answer: " + currentEnglish); }

            // Checking if Kanji word was generated
            if (answerFurigana.Enabled == true)
            {
                // Answer check when both Kanas and Kanji are active
                // Furigana answer check
                if (furigana.Equals(currentRomaji.ToLower()))
                {
                    answerFurigana.BackColor = Color.Green;
                    furiganaCorrect = true;

                }
                else
                {
                    this.ActiveControl = answerFurigana;
                    answerFurigana.BackColor = Color.Red;
                    answerFurigana.SelectAll();
                }

                // English answer check
                if (english.Equals(currentEnglish.ToLower()))
                {
                    answerEnglish.BackColor = Color.Green;
                    englishCorrect = true;
                }
                else
                {

                    this.ActiveControl = answerEnglish;
                    answerEnglish.BackColor = Color.Red;
                    answerEnglish.SelectAll();
                }


                if (furiganaCorrect && englishCorrect)
                {
                    if (fastModeButton.Checked)
                    {
                        wordGenerator();
                    }
                    else
                    {
                        this.ActiveControl = generateNext;
                    }
                    
                }

                if (!furiganaCorrect && !englishCorrect)
                {
                    this.ActiveControl = answerFurigana;
                }
            }
            else
            {
                // English answer check
                if (english.Equals(currentEnglish.ToLower()))
                {
                    if (fastModeButton.Checked)
                    {
                        wordGenerator();
                    }
                    else
                    {
                        answerEnglish.BackColor = Color.Green;
                        this.ActiveControl = generateNext;
                    }

                }
                else
                {
                    this.ActiveControl = answerEnglish;
                    answerEnglish.BackColor = Color.Red;
                }
            }



        }

        private void cleanFields()
        {
            answerEnglish.Clear();
            answerEnglish.BackColor = Color.White;
            answerFurigana.Clear();
            answerFurigana.BackColor = Color.White;
            status.Text = "";
        }

        private void writeKanji_Click(object sender, EventArgs e)
        {
            kanji.writeWords();
        }
    }
}
