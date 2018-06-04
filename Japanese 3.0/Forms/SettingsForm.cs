using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Japanese.Forms
{
    public partial class settingsForm : Form
    {
        private Settings settings;
        private Settings originalSettings;
        private bool safeClose;

        public settingsForm(Settings mainSettings)
        {
            safeClose = false;
            InitializeComponent();
            settings = new Settings();
            originalSettings = mainSettings;
            importSettings(mainSettings);
        }

        public Settings returnSettings()
        {
            return this.settings;
        }

        public bool getSafeClose()
        {
            return safeClose;
        }

        private void importSettings(Settings settings)
        {
            // Hiragana settings
            this.hiraganaC.Checked = settings.getHiraganaC();
            this.hiraganaGC.Checked = settings.getHiraganaG();
            this.hiraganaDC.Checked = settings.getHiraganaD();
            this.hiraganaHC.Checked = settings.getHiraganaH();
            this.hiraganaYC.Checked = settings.getHiraganaY();

            this.hiraganaRS.Value = settings.getHiraganaR();
            this.hiraganaGRS.Value = settings.getHiraganaGR();
            this.hiraganaDRS.Value = settings.getHiraganaDR();
            this.hiraganaHRS.Value = settings.getHiraganaHR();
            this.hiraganaYRS.Value = settings.getHiraganaYR();

            // Katakana Settings
            this.katakanaC.Checked = settings.getKatakanaC();
            this.katakanaGC.Checked = settings.getKatakanaG();
            this.katakanaDC.Checked = settings.getKatakanaD();
            this.katakanaHC.Checked = settings.getKatakanaH();
            this.katakanaYC.Checked = settings.getKatakanaY();

            this.katakanaRS.Value = settings.getKatakanaR();
            this.katakanaGRS.Value = settings.getKatakanaGR();
            this.katakanaDRS.Value = settings.getKatakanaDR();
            this.katakanaHRS.Value = settings.getKatakanaHR();
            this.katakanaYRS.Value = settings.getKatakanaYR();

            // Kanji Settings
            this.kanjiC.Checked = settings.getKanjiC();
            this.kanjiRS.Value = settings.getKanjiR();

            updateChecks();
            updateSlidersText();
        }

        private void updateChecks()
        {
            /**
             *  C - Check
             *  R - Ratio
             *  S - Slider
             *  D - Gojūon
             *  G - Dakuon
             *  H - Handakuon
             *  Y - Yōon
             **/

            // Hiragana States
            if (this.hiraganaC.Checked == true)
            {
                // Slider
                this.hiraganaRS.Enabled = true;
                // CheckBoxes
                this.hiraganaDC.Enabled = true;
                this.hiraganaGC.Enabled = true;
                this.hiraganaHC.Enabled = true;
                this.hiraganaYC.Enabled = true;

                // Checks if hiragana boxes are ticked
                if (this.hiraganaDC.Checked == true) { hiraganaDRS.Enabled = true; }
                else { hiraganaDRS.Enabled = false; }

                if (this.hiraganaGC.Checked == true) { hiraganaGRS.Enabled = true; }
                else { hiraganaGRS.Enabled = false; }

                if (this.hiraganaHC.Checked == true) { hiraganaHRS.Enabled = true; }
                else { hiraganaHRS.Enabled = false; }

                if (this.hiraganaYC.Checked == true) { hiraganaYRS.Enabled = true; }
                else { hiraganaYRS.Enabled = false; }

            }
            else
            {
                // Turns off everything in hiragana
                this.hiraganaDC.Enabled = false;
                this.hiraganaGC.Enabled = false;
                this.hiraganaHC.Enabled = false;
                this.hiraganaYC.Enabled = false;
                this.hiraganaRS.Enabled = false;
                this.hiraganaDRS.Enabled = false;
                this.hiraganaGRS.Enabled = false;
                this.hiraganaHRS.Enabled = false;
                this.hiraganaYRS.Enabled = false;
            }


            // Katakana States
            if (this.katakanaC.Checked == true)
            {
                // Slider
                this.katakanaRS.Enabled = true;
                // CheckBoxes
                this.katakanaDC.Enabled = true;
                this.katakanaGC.Enabled = true;
                this.katakanaHC.Enabled = true;
                this.katakanaYC.Enabled = true;

                // Checks if katakana boxes are ticked
                if (this.katakanaDC.Checked == true) { katakanaDRS.Enabled = true; }
                else { katakanaDRS.Enabled = false; }

                if (this.katakanaGC.Checked == true) { katakanaGRS.Enabled = true; }
                else { katakanaGRS.Enabled = false; }

                if (this.katakanaHC.Checked == true) { katakanaHRS.Enabled = true; }
                else { katakanaHRS.Enabled = false; }

                if (this.katakanaYC.Checked == true) { katakanaYRS.Enabled = true; }
                else { katakanaYRS.Enabled = false; }

            }
            else
            {
                // Turns off everything in katakana
                this.katakanaDC.Enabled = false;
                this.katakanaGC.Enabled = false;
                this.katakanaHC.Enabled = false;
                this.katakanaYC.Enabled = false;
                this.katakanaRS.Enabled = false;
                this.katakanaDRS.Enabled = false;
                this.katakanaGRS.Enabled = false;
                this.katakanaHRS.Enabled = false;
                this.katakanaYRS.Enabled = false;
            }

            // kanji States
            if (this.kanjiC.Checked == true)
            {
                // Slider
                this.kanjiRS.Enabled = true;
            }
            else
            {
                // Turns off everything in kanji
                this.kanjiRS.Enabled = false;
            }
        }

        private void updateSlidersText()
        {
            this.hiraganaRT.Text = this.hiraganaRS.Value.ToString(); ;
            this.hiraganaGRT.Text = this.hiraganaGRS.Value.ToString();
            this.hiraganaDRT.Text = this.hiraganaDRS.Value.ToString();
            this.hiraganaHRT.Text = this.hiraganaHRS.Value.ToString();
            this.hiraganaYRT.Text = this.hiraganaYRS.Value.ToString();

            this.katakanaRT.Text = this.katakanaRS.Value.ToString();
            this.katakanaGRT.Text = this.katakanaGRS.Value.ToString();
            this.katakanaDRT.Text = this.katakanaDRS.Value.ToString();
            this.katakanaHRT.Text = this.katakanaHRS.Value.ToString();
            this.katakanaYRT.Text = this.katakanaYRS.Value.ToString();

            this.kanjiRT.Text = this.kanjiRS.Value.ToString();
        }


        // method to change the text value of sliders
        private void setRSliderText(Label label, TrackBar slider)
        {
            label.Text = slider.Value.ToString();
        }

        // All sliders _Scroll methods
        private void hiraganaRSlider_Scroll(object sender, EventArgs e)
        {
            settings.setHiraganaR(hiraganaRS.Value);
            setRSliderText(hiraganaRT, hiraganaRS);
        }

        private void hiraganaGRS_Scroll(object sender, EventArgs e)
        {
            settings.setHiraganaGR(hiraganaGRS.Value);
            setRSliderText(hiraganaGRT, hiraganaGRS);
        }

        private void hiraganaDRS_Scroll(object sender, EventArgs e)
        {
            settings.setHiraganaDR(hiraganaDRS.Value);
            setRSliderText(hiraganaDRT, hiraganaDRS);
        }

        private void hiraganaHRS_Scroll(object sender, EventArgs e)
        {
            settings.setHiraganaHR(hiraganaHRS.Value);
            setRSliderText(hiraganaHRT, hiraganaHRS);
        }

        private void hiraganaYRS_Scroll(object sender, EventArgs e)
        {
            settings.setHiraganaYR(hiraganaYRS.Value);
            setRSliderText(hiraganaYRT, hiraganaYRS);
        }

        private void katakanaRS_Scroll(object sender, EventArgs e)
        {
            settings.setKatakanaR(katakanaRS.Value);
            setRSliderText(katakanaRT, katakanaRS);
        }

        private void katakanaGRS_Scroll(object sender, EventArgs e)
        {
            settings.setKatakanaGR(katakanaGRS.Value);
            setRSliderText(katakanaGRT, katakanaGRS);
        }

        private void katakanaDRS_Scroll(object sender, EventArgs e)
        {
            settings.setKatakanaGR(katakanaGRS.Value);
            setRSliderText(katakanaDRT, katakanaDRS);
        }

        private void katakanaHRS_Scroll(object sender, EventArgs e)
        {
            settings.setKatakanaHR(katakanaHRS.Value);
            setRSliderText(katakanaHRT, katakanaHRS);
        }

        private void katakanaYRS_Scroll(object sender, EventArgs e)
        {
            settings.setKatakanaYR(katakanaYRS.Value);
            setRSliderText(katakanaYRT, katakanaYRS);
        }

        private void kanjiRS_Scroll(object sender, EventArgs e)
        {
            settings.setKanjiR(kanjiRS.Value);
            setRSliderText(kanjiRT, kanjiRS);
        }

        private void hiraganaC_CheckedChanged(object sender, EventArgs e)
        {
            updateChecks();
        }

        private void hiraganaGC_CheckStateChanged(object sender, EventArgs e)
        {
            updateChecks();
        }

        private void hiraganaDC_CheckStateChanged(object sender, EventArgs e)
        {
            updateChecks();
        }

        private void hiraganaHC_CheckStateChanged(object sender, EventArgs e)
        {
            updateChecks();
        }

        private void hiraganaYC_CheckStateChanged(object sender, EventArgs e)
        {
            updateChecks();
        }

        private void katakanaC_CheckStateChanged(object sender, EventArgs e)
        {
            updateChecks();
        }

        private void katakanaGC_CheckStateChanged(object sender, EventArgs e)
        {
            updateChecks();
        }

        private void katakanaDC_CheckStateChanged(object sender, EventArgs e)
        {
            updateChecks();
        }

        private void katakanaHC_CheckStateChanged(object sender, EventArgs e)
        {
            updateChecks();
        }

        private void katakanaYC_CheckStateChanged(object sender, EventArgs e)
        {
            updateChecks();
        }

        private void kanjiC_CheckStateChanged(object sender, EventArgs e)
        {
            updateChecks();
        }

        private void saveSettings_Click(object sender, EventArgs e)
        {
            // Hiragana settings
            settings.setHiraganaC(this.hiraganaC.Checked);
            settings.setHiraganaG(this.hiraganaGC.Checked);
            settings.setHiraganaD(this.hiraganaDC.Checked);
            settings.setHiraganaH(this.hiraganaHC.Checked);
            settings.setHiraganaY(this.hiraganaYC.Checked);

            settings.setHiraganaR(this.hiraganaRS.Value);
            settings.setHiraganaGR(this.hiraganaGRS.Value);
            settings.setHiraganaDR(this.hiraganaDRS.Value);
            settings.setHiraganaHR(this.hiraganaHRS.Value);
            settings.setHiraganaYR(this.hiraganaYRS.Value);

            // Katakana Settings
            settings.setKatakanaC(this.katakanaC.Checked);
            settings.setKatakanaG(this.katakanaGC.Checked);
            settings.setKatakanaD(this.katakanaDC.Checked);
            settings.setKatakanaH(this.katakanaHC.Checked);
            settings.setKatakanaY(this.katakanaYC.Checked);

            settings.setKatakanaR(this.katakanaRS.Value);
            settings.setKatakanaGR(this.katakanaGRS.Value);
            settings.setKatakanaDR(this.katakanaDRS.Value);
            settings.setKatakanaHR(this.katakanaHRS.Value);
            settings.setKatakanaYR(this.katakanaYRS.Value);

            // Kanji Settings
            settings.setKanjiC(this.kanjiC.Checked);
            settings.setKanjiR(this.kanjiRS.Value);

            safeClose = true;
            this.Close();
        }

        private void resetSettings_Click(object sender, EventArgs e)
        {
            importSettings(originalSettings);
            updateChecks();
            updateSlidersText();
        }

        private void cancelSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
