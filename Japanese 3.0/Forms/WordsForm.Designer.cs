namespace Japanese.Forms
{
    partial class WordsForm
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
            this.japaneseText = new System.Windows.Forms.Label();
            this.furiganaText = new System.Windows.Forms.Label();
            this.englishText = new System.Windows.Forms.Label();
            this.answerFurigana = new System.Windows.Forms.TextBox();
            this.submitAnswer = new System.Windows.Forms.Button();
            this.showEnglish = new System.Windows.Forms.Button();
            this.generateNext = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.showFurigana = new System.Windows.Forms.Button();
            this.answerEnglish = new System.Windows.Forms.TextBox();
            this.fastModeButton = new System.Windows.Forms.CheckBox();
            this.writeKanji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // japaneseText
            // 
            this.japaneseText.AutoSize = true;
            this.japaneseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.japaneseText.Location = new System.Drawing.Point(38, 17);
            this.japaneseText.Name = "japaneseText";
            this.japaneseText.Size = new System.Drawing.Size(227, 54);
            this.japaneseText.TabIndex = 0;
            this.japaneseText.Text = "Japanese";
            this.japaneseText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // furiganaText
            // 
            this.furiganaText.AutoSize = true;
            this.furiganaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furiganaText.Location = new System.Drawing.Point(38, 79);
            this.furiganaText.Name = "furiganaText";
            this.furiganaText.Size = new System.Drawing.Size(208, 54);
            this.furiganaText.TabIndex = 1;
            this.furiganaText.Text = "Furigana";
            this.furiganaText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // englishText
            // 
            this.englishText.AutoSize = true;
            this.englishText.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishText.Location = new System.Drawing.Point(38, 140);
            this.englishText.Name = "englishText";
            this.englishText.Size = new System.Drawing.Size(280, 54);
            this.englishText.TabIndex = 2;
            this.englishText.Text = "English Text";
            this.englishText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // answerFurigana
            // 
            this.answerFurigana.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerFurigana.Location = new System.Drawing.Point(353, 15);
            this.answerFurigana.Name = "answerFurigana";
            this.answerFurigana.Size = new System.Drawing.Size(198, 56);
            this.answerFurigana.TabIndex = 3;
            this.answerFurigana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.answerFurigana_KeyPress);
            // 
            // submitAnswer
            // 
            this.submitAnswer.Location = new System.Drawing.Point(353, 138);
            this.submitAnswer.Name = "submitAnswer";
            this.submitAnswer.Size = new System.Drawing.Size(198, 56);
            this.submitAnswer.TabIndex = 4;
            this.submitAnswer.Text = "Submit";
            this.submitAnswer.UseVisualStyleBackColor = true;
            this.submitAnswer.Click += new System.EventHandler(this.submitAnswer_Click);
            // 
            // showEnglish
            // 
            this.showEnglish.Location = new System.Drawing.Point(557, 77);
            this.showEnglish.Name = "showEnglish";
            this.showEnglish.Size = new System.Drawing.Size(106, 56);
            this.showEnglish.TabIndex = 5;
            this.showEnglish.Text = "Show English";
            this.showEnglish.UseVisualStyleBackColor = true;
            this.showEnglish.Click += new System.EventHandler(this.showEnglish_Click);
            // 
            // generateNext
            // 
            this.generateNext.Location = new System.Drawing.Point(557, 138);
            this.generateNext.Name = "generateNext";
            this.generateNext.Size = new System.Drawing.Size(106, 56);
            this.generateNext.TabIndex = 6;
            this.generateNext.Text = "Next Word/Kana";
            this.generateNext.UseVisualStyleBackColor = true;
            this.generateNext.Click += new System.EventHandler(this.generateNext_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(557, 211);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(106, 54);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Location = new System.Drawing.Point(12, 255);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 9;
            // 
            // showFurigana
            // 
            this.showFurigana.Location = new System.Drawing.Point(557, 14);
            this.showFurigana.Name = "showFurigana";
            this.showFurigana.Size = new System.Drawing.Size(106, 56);
            this.showFurigana.TabIndex = 10;
            this.showFurigana.Text = "Show Furigana";
            this.showFurigana.UseVisualStyleBackColor = true;
            this.showFurigana.Click += new System.EventHandler(this.showFurigana_Click);
            // 
            // answerEnglish
            // 
            this.answerEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerEnglish.Location = new System.Drawing.Point(353, 77);
            this.answerEnglish.Name = "answerEnglish";
            this.answerEnglish.Size = new System.Drawing.Size(198, 56);
            this.answerEnglish.TabIndex = 11;
            this.answerEnglish.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.answerEnglish_KeyPress);
            // 
            // fastModeButton
            // 
            this.fastModeButton.AutoSize = true;
            this.fastModeButton.Location = new System.Drawing.Point(395, 232);
            this.fastModeButton.Name = "fastModeButton";
            this.fastModeButton.Size = new System.Drawing.Size(76, 17);
            this.fastModeButton.TabIndex = 12;
            this.fastModeButton.Text = "Fast Mode";
            this.fastModeButton.UseVisualStyleBackColor = true;
            // 
            // writeKanji
            // 
            this.writeKanji.Location = new System.Drawing.Point(246, 232);
            this.writeKanji.Name = "writeKanji";
            this.writeKanji.Size = new System.Drawing.Size(107, 32);
            this.writeKanji.TabIndex = 13;
            this.writeKanji.Text = "Save Kanji";
            this.writeKanji.UseVisualStyleBackColor = true;
            this.writeKanji.Click += new System.EventHandler(this.writeKanji_Click);
            // 
            // WordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 277);
            this.Controls.Add(this.writeKanji);
            this.Controls.Add(this.fastModeButton);
            this.Controls.Add(this.answerEnglish);
            this.Controls.Add(this.showFurigana);
            this.Controls.Add(this.status);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.generateNext);
            this.Controls.Add(this.showEnglish);
            this.Controls.Add(this.submitAnswer);
            this.Controls.Add(this.answerFurigana);
            this.Controls.Add(this.englishText);
            this.Controls.Add(this.furiganaText);
            this.Controls.Add(this.japaneseText);
            this.Name = "WordsForm";
            this.Text = "Hiragana, Katakana and Kanji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label japaneseText;
        private System.Windows.Forms.Label furiganaText;
        private System.Windows.Forms.Label englishText;
        private System.Windows.Forms.TextBox answerFurigana;
        private System.Windows.Forms.Button submitAnswer;
        private System.Windows.Forms.Button showEnglish;
        private System.Windows.Forms.Button generateNext;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button showFurigana;
        private System.Windows.Forms.TextBox answerEnglish;
        private System.Windows.Forms.CheckBox fastModeButton;
        private System.Windows.Forms.Button writeKanji;
    }
}