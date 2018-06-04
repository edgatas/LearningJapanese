using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Japanese.Forms; 
 
namespace Japanese
{
    public partial class MainUI : Form
    {
        WordsForm wordsForm;
        Settings settings;
        AddKanjiWord addKanjiForm;


        public MainUI()
        {
            settings = new Settings();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addKanjiForm = new AddKanjiWord();
            addKanjiForm.Show();
        }

        private void wordsButton_Click(object sender, EventArgs e)
        {
            if (wordsForm != null)
            {
                wordsForm.BringToFront();
            }
            else
            {
                this.Hide();
                wordsForm = new WordsForm(settings);
                wordsForm.FormClosed += delegate { wordsForm = null; this.Show(); };
                wordsForm.Show();
            }
        }
    }
}
