using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Japanese
{
    public partial class AddKanjiWord : Form
    {
        Kanji kanji;
        List<string> kanjiWords;

        public AddKanjiWord()
        {
            InitializeComponent();
            kanji = new Kanji();
            kanjiWords = new List<string>();
            generateKanjiList(kanji, kanjiWords);
            wordListUI.DataSource = kanjiWords;
        }

        private void generateKanjiList(Kanji kanji, List<string> kanjiList)
        {
            int kanjiLength = kanji.getLength();
            kanjiList = new List<string>();
            for (int index = 0; index < kanjiLength; index++)
            {
                kanjiList.Add(kanji.getWord(index).getKanji());
            }

        }
        private void setTextBoxes(KanjiWord word)
        {
            kanjiBox.Text = word.getKanji();
            furiganaBox.Text = word.getFurigana();
            romajiBox.Text = word.getRomaji();
            englishBox.Text = word.getEnglish();
        }

        private void wordListUI_SelectedIndexChanged(object sender, EventArgs e)
        {
            KanjiWord word = kanji.getWord(wordListUI.SelectedIndex);
            setTextBoxes(word);
        }

        private void clearFields_Click(object sender, EventArgs e)
        {
            kanjiBox.Text = "";
            furiganaBox.Text = "";
            romajiBox.Text = "";
            englishBox.Text = "";
        }

        private void saveWord_Click(object sender, EventArgs e)
        {
            String kanjiBoxTxt = kanjiBox.Text;
            String furiganaBoxTxt = furiganaBox.Text;
            String romajiBoxTxt = romajiBox.Text.ToLower();
            String englishBoxTxt = englishBox.Text.ToLower();

            bool kanCheck = kanji.matchKanji(kanjiBoxTxt);
            bool furCheck = kanji.matchFurigana(furiganaBoxTxt);
            bool romCheck = kanji.matchRomaji(romajiBoxTxt);
            bool engCheck = kanji.matchEnglish(englishBoxTxt);

            if (kanCheck)
            {
                kanjiBox.BackColor = Color.LightGreen;
            }
            else
            {
                kanjiBox.BackColor = Color.LightPink;
            }

            if (furCheck)
            {
                furiganaBox.BackColor = Color.LightGreen;
            }
            else
            {
                furiganaBox.BackColor = Color.LightPink;
            }

            if (romCheck)
            {
                romajiBox.BackColor = Color.LightGreen;
            }
            else
            {
                romajiBox.BackColor = Color.LightPink;
            }
            if (engCheck)
            {
                englishBox.BackColor = Color.LightGreen;
            }
            else
            {
                englishBox.BackColor = Color.LightPink;
            }
        }

        private void saveWord_Click_1(object sender, EventArgs e)
        {
            KanjiWord newWord = new KanjiWord();
            newWord.setKanji(kanjiBox.Text);
            newWord.setFurigana(furiganaBox.Text);
            newWord.setRomaji(romajiBox.Text);
            newWord.setEnglish(englishBox.Text);

            kanji.addWord(newWord);
        }

        private void AddKanjiWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            kanji.writeWords();
            kanji.updateList();
            generateKanjiList(kanji, kanjiWords);
            wordListUI.DataSource = null;
            wordListUI.DataSource = kanjiWords;
            wordListUI.Update();

            Console.WriteLine(kanjiWords.Count);
        }

        private void deleteWord_Click(object sender, EventArgs e)
        {
            int index = wordListUI.SelectedIndex;
            Console.WriteLine(index);
            kanji.deleteWord(index);
            kanji.updateList();
            generateKanjiList(kanji, kanjiWords);
            wordListUI.Update();

            Console.WriteLine("KanjiWords Length: " + kanjiWords.Count);
        }
    }
}
