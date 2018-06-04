namespace Japanese
{
    partial class AddKanjiWord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uiWords = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wordListUI = new System.Windows.Forms.ListBox();
            this.kanjiBox = new System.Windows.Forms.TextBox();
            this.furiganaBox = new System.Windows.Forms.TextBox();
            this.romajiBox = new System.Windows.Forms.TextBox();
            this.englishBox = new System.Windows.Forms.TextBox();
            this.kanjiText = new System.Windows.Forms.Label();
            this.furiganaText = new System.Windows.Forms.Label();
            this.romajiText = new System.Windows.Forms.Label();
            this.englishText = new System.Windows.Forms.Label();
            this.clearFields = new System.Windows.Forms.Button();
            this.checkWord = new System.Windows.Forms.Button();
            this.saveWord = new System.Windows.Forms.Button();
            this.deleteWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiWords
            // 
            this.uiWords.Name = "uiWords";
            this.uiWords.Size = new System.Drawing.Size(61, 4);
            this.uiWords.Text = "Just Checking";
            // 
            // wordListUI
            // 
            this.wordListUI.FormattingEnabled = true;
            this.wordListUI.Location = new System.Drawing.Point(346, 12);
            this.wordListUI.Name = "wordListUI";
            this.wordListUI.Size = new System.Drawing.Size(120, 251);
            this.wordListUI.TabIndex = 1;
            this.wordListUI.SelectedIndexChanged += new System.EventHandler(this.wordListUI_SelectedIndexChanged);
            // 
            // kanjiBox
            // 
            this.kanjiBox.Location = new System.Drawing.Point(240, 12);
            this.kanjiBox.Name = "kanjiBox";
            this.kanjiBox.Size = new System.Drawing.Size(100, 20);
            this.kanjiBox.TabIndex = 2;
            // 
            // furiganaBox
            // 
            this.furiganaBox.Location = new System.Drawing.Point(240, 38);
            this.furiganaBox.Name = "furiganaBox";
            this.furiganaBox.Size = new System.Drawing.Size(100, 20);
            this.furiganaBox.TabIndex = 3;
            // 
            // romajiBox
            // 
            this.romajiBox.Location = new System.Drawing.Point(240, 64);
            this.romajiBox.Name = "romajiBox";
            this.romajiBox.Size = new System.Drawing.Size(100, 20);
            this.romajiBox.TabIndex = 4;
            // 
            // englishBox
            // 
            this.englishBox.Location = new System.Drawing.Point(240, 90);
            this.englishBox.Name = "englishBox";
            this.englishBox.Size = new System.Drawing.Size(100, 20);
            this.englishBox.TabIndex = 5;
            // 
            // kanjiText
            // 
            this.kanjiText.AutoSize = true;
            this.kanjiText.Location = new System.Drawing.Point(150, 15);
            this.kanjiText.Name = "kanjiText";
            this.kanjiText.Size = new System.Drawing.Size(30, 13);
            this.kanjiText.TabIndex = 6;
            this.kanjiText.Text = "Kanji";
            // 
            // furiganaText
            // 
            this.furiganaText.AutoSize = true;
            this.furiganaText.Location = new System.Drawing.Point(150, 41);
            this.furiganaText.Name = "furiganaText";
            this.furiganaText.Size = new System.Drawing.Size(48, 13);
            this.furiganaText.TabIndex = 7;
            this.furiganaText.Text = "Furigana";
            // 
            // romajiText
            // 
            this.romajiText.AutoSize = true;
            this.romajiText.Location = new System.Drawing.Point(150, 71);
            this.romajiText.Name = "romajiText";
            this.romajiText.Size = new System.Drawing.Size(39, 13);
            this.romajiText.TabIndex = 8;
            this.romajiText.Text = "Romaji";
            // 
            // englishText
            // 
            this.englishText.AutoSize = true;
            this.englishText.Location = new System.Drawing.Point(150, 97);
            this.englishText.Name = "englishText";
            this.englishText.Size = new System.Drawing.Size(41, 13);
            this.englishText.TabIndex = 9;
            this.englishText.Text = "English";
            // 
            // clearFields
            // 
            this.clearFields.Location = new System.Drawing.Point(264, 116);
            this.clearFields.Name = "clearFields";
            this.clearFields.Size = new System.Drawing.Size(76, 23);
            this.clearFields.TabIndex = 10;
            this.clearFields.Text = "Clear";
            this.clearFields.UseVisualStyleBackColor = true;
            this.clearFields.Click += new System.EventHandler(this.clearFields_Click);
            // 
            // checkWord
            // 
            this.checkWord.Location = new System.Drawing.Point(183, 116);
            this.checkWord.Name = "checkWord";
            this.checkWord.Size = new System.Drawing.Size(75, 23);
            this.checkWord.TabIndex = 11;
            this.checkWord.Text = "Check";
            this.checkWord.UseVisualStyleBackColor = true;
            this.checkWord.Click += new System.EventHandler(this.saveWord_Click);
            // 
            // saveWord
            // 
            this.saveWord.Location = new System.Drawing.Point(95, 116);
            this.saveWord.Name = "saveWord";
            this.saveWord.Size = new System.Drawing.Size(82, 24);
            this.saveWord.TabIndex = 12;
            this.saveWord.Text = "Save";
            this.saveWord.UseVisualStyleBackColor = true;
            this.saveWord.Click += new System.EventHandler(this.saveWord_Click_1);
            // 
            // deleteWord
            // 
            this.deleteWord.Location = new System.Drawing.Point(211, 170);
            this.deleteWord.Name = "deleteWord";
            this.deleteWord.Size = new System.Drawing.Size(77, 30);
            this.deleteWord.TabIndex = 13;
            this.deleteWord.Text = "Delete";
            this.deleteWord.UseVisualStyleBackColor = true;
            this.deleteWord.Click += new System.EventHandler(this.deleteWord_Click);
            // 
            // AddKanjiWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 320);
            this.Controls.Add(this.deleteWord);
            this.Controls.Add(this.saveWord);
            this.Controls.Add(this.checkWord);
            this.Controls.Add(this.clearFields);
            this.Controls.Add(this.englishText);
            this.Controls.Add(this.romajiText);
            this.Controls.Add(this.furiganaText);
            this.Controls.Add(this.kanjiText);
            this.Controls.Add(this.englishBox);
            this.Controls.Add(this.romajiBox);
            this.Controls.Add(this.furiganaBox);
            this.Controls.Add(this.kanjiBox);
            this.Controls.Add(this.wordListUI);
            this.Name = "AddKanjiWord";
            this.Text = "AddKanjiWord";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddKanjiWord_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip uiWords;
        private System.Windows.Forms.ListBox wordListUI;
        private System.Windows.Forms.TextBox kanjiBox;
        private System.Windows.Forms.TextBox furiganaBox;
        private System.Windows.Forms.TextBox romajiBox;
        private System.Windows.Forms.TextBox englishBox;
        private System.Windows.Forms.Label kanjiText;
        private System.Windows.Forms.Label furiganaText;
        private System.Windows.Forms.Label romajiText;
        private System.Windows.Forms.Label englishText;
        private System.Windows.Forms.Button clearFields;
        private System.Windows.Forms.Button checkWord;
        private System.Windows.Forms.Button saveWord;
        private System.Windows.Forms.Button deleteWord;
    }
}