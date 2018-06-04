namespace Japanese.Forms
{
    partial class settingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.hiraganaC = new System.Windows.Forms.CheckBox();
            this.hiraganaGC = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hiraganaRS = new System.Windows.Forms.TrackBar();
            this.hiraganaDC = new System.Windows.Forms.CheckBox();
            this.hiraganaHC = new System.Windows.Forms.CheckBox();
            this.hiraganaYC = new System.Windows.Forms.CheckBox();
            this.katakanaYC = new System.Windows.Forms.CheckBox();
            this.katakanaHC = new System.Windows.Forms.CheckBox();
            this.katakanaDC = new System.Windows.Forms.CheckBox();
            this.katakanaGC = new System.Windows.Forms.CheckBox();
            this.katakanaC = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kanjiC = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hiraganaGRS = new System.Windows.Forms.TrackBar();
            this.hiraganaDRS = new System.Windows.Forms.TrackBar();
            this.hiraganaHRS = new System.Windows.Forms.TrackBar();
            this.hiraganaYRS = new System.Windows.Forms.TrackBar();
            this.katakanaRS = new System.Windows.Forms.TrackBar();
            this.katakanaGRS = new System.Windows.Forms.TrackBar();
            this.katakanaDRS = new System.Windows.Forms.TrackBar();
            this.katakanaHRS = new System.Windows.Forms.TrackBar();
            this.katakanaYRS = new System.Windows.Forms.TrackBar();
            this.kanjiRS = new System.Windows.Forms.TrackBar();
            this.hiraganaRT = new System.Windows.Forms.Label();
            this.hiraganaGRT = new System.Windows.Forms.Label();
            this.hiraganaDRT = new System.Windows.Forms.Label();
            this.hiraganaHRT = new System.Windows.Forms.Label();
            this.hiraganaYRT = new System.Windows.Forms.Label();
            this.katakanaRT = new System.Windows.Forms.Label();
            this.katakanaGRT = new System.Windows.Forms.Label();
            this.katakanaDRT = new System.Windows.Forms.Label();
            this.katakanaHRT = new System.Windows.Forms.Label();
            this.katakanaYRT = new System.Windows.Forms.Label();
            this.kanjiRT = new System.Windows.Forms.Label();
            this.saveSettings = new System.Windows.Forms.Button();
            this.resetSettings = new System.Windows.Forms.Button();
            this.cancelSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hiraganaRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiraganaGRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiraganaDRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiraganaHRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiraganaYRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katakanaRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katakanaGRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katakanaDRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katakanaHRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katakanaYRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanjiRS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hiragana Settings";
            // 
            // hiraganaC
            // 
            this.hiraganaC.AutoSize = true;
            this.hiraganaC.Location = new System.Drawing.Point(16, 25);
            this.hiraganaC.Name = "hiraganaC";
            this.hiraganaC.Size = new System.Drawing.Size(69, 17);
            this.hiraganaC.TabIndex = 1;
            this.hiraganaC.Text = "Hiragana";
            this.hiraganaC.UseVisualStyleBackColor = true;
            this.hiraganaC.CheckedChanged += new System.EventHandler(this.hiraganaC_CheckedChanged);
            // 
            // hiraganaGC
            // 
            this.hiraganaGC.AutoSize = true;
            this.hiraganaGC.Location = new System.Drawing.Point(29, 48);
            this.hiraganaGC.Name = "hiraganaGC";
            this.hiraganaGC.Size = new System.Drawing.Size(79, 17);
            this.hiraganaGC.TabIndex = 2;
            this.hiraganaGC.Text = "Gojūon (あ)";
            this.hiraganaGC.UseVisualStyleBackColor = true;
            this.hiraganaGC.CheckStateChanged += new System.EventHandler(this.hiraganaGC_CheckStateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Less <- Chanse of appearing -> More";
            // 
            // hiraganaRS
            // 
            this.hiraganaRS.LargeChange = 1;
            this.hiraganaRS.Location = new System.Drawing.Point(189, 25);
            this.hiraganaRS.Maximum = 100;
            this.hiraganaRS.Name = "hiraganaRS";
            this.hiraganaRS.Size = new System.Drawing.Size(189, 45);
            this.hiraganaRS.TabIndex = 5;
            this.hiraganaRS.TickFrequency = 5;
            this.hiraganaRS.Scroll += new System.EventHandler(this.hiraganaRSlider_Scroll);
            // 
            // hiraganaDC
            // 
            this.hiraganaDC.AutoSize = true;
            this.hiraganaDC.Location = new System.Drawing.Point(29, 71);
            this.hiraganaDC.Name = "hiraganaDC";
            this.hiraganaDC.Size = new System.Drawing.Size(83, 17);
            this.hiraganaDC.TabIndex = 6;
            this.hiraganaDC.Text = "Dakuon (が)";
            this.hiraganaDC.UseVisualStyleBackColor = true;
            this.hiraganaDC.CheckStateChanged += new System.EventHandler(this.hiraganaDC_CheckStateChanged);
            // 
            // hiraganaHC
            // 
            this.hiraganaHC.AutoSize = true;
            this.hiraganaHC.Location = new System.Drawing.Point(29, 94);
            this.hiraganaHC.Name = "hiraganaHC";
            this.hiraganaHC.Size = new System.Drawing.Size(101, 17);
            this.hiraganaHC.TabIndex = 7;
            this.hiraganaHC.Text = "Handakuon (ぱ)";
            this.hiraganaHC.UseVisualStyleBackColor = true;
            this.hiraganaHC.CheckStateChanged += new System.EventHandler(this.hiraganaHC_CheckStateChanged);
            // 
            // hiraganaYC
            // 
            this.hiraganaYC.AutoSize = true;
            this.hiraganaYC.Location = new System.Drawing.Point(29, 117);
            this.hiraganaYC.Name = "hiraganaYC";
            this.hiraganaYC.Size = new System.Drawing.Size(77, 17);
            this.hiraganaYC.TabIndex = 8;
            this.hiraganaYC.Text = "Yōon (きゃ)";
            this.hiraganaYC.UseVisualStyleBackColor = true;
            this.hiraganaYC.CheckStateChanged += new System.EventHandler(this.hiraganaYC_CheckStateChanged);
            // 
            // katakanaYC
            // 
            this.katakanaYC.AutoSize = true;
            this.katakanaYC.Location = new System.Drawing.Point(29, 257);
            this.katakanaYC.Name = "katakanaYC";
            this.katakanaYC.Size = new System.Drawing.Size(78, 17);
            this.katakanaYC.TabIndex = 14;
            this.katakanaYC.Text = "Yōon (キャ)";
            this.katakanaYC.UseVisualStyleBackColor = true;
            this.katakanaYC.CheckStateChanged += new System.EventHandler(this.katakanaYC_CheckStateChanged);
            // 
            // katakanaHC
            // 
            this.katakanaHC.AutoSize = true;
            this.katakanaHC.Location = new System.Drawing.Point(29, 234);
            this.katakanaHC.Name = "katakanaHC";
            this.katakanaHC.Size = new System.Drawing.Size(101, 17);
            this.katakanaHC.TabIndex = 13;
            this.katakanaHC.Text = "Handakuon (パ)";
            this.katakanaHC.UseVisualStyleBackColor = true;
            this.katakanaHC.CheckStateChanged += new System.EventHandler(this.katakanaHC_CheckStateChanged);
            // 
            // katakanaDC
            // 
            this.katakanaDC.AutoSize = true;
            this.katakanaDC.Location = new System.Drawing.Point(29, 211);
            this.katakanaDC.Name = "katakanaDC";
            this.katakanaDC.Size = new System.Drawing.Size(82, 17);
            this.katakanaDC.TabIndex = 12;
            this.katakanaDC.Text = "Dakuon (カ)";
            this.katakanaDC.UseVisualStyleBackColor = true;
            this.katakanaDC.CheckStateChanged += new System.EventHandler(this.katakanaDC_CheckStateChanged);
            // 
            // katakanaGC
            // 
            this.katakanaGC.AutoSize = true;
            this.katakanaGC.Location = new System.Drawing.Point(29, 188);
            this.katakanaGC.Name = "katakanaGC";
            this.katakanaGC.Size = new System.Drawing.Size(78, 17);
            this.katakanaGC.TabIndex = 11;
            this.katakanaGC.Text = "Gojūon (ア)";
            this.katakanaGC.UseVisualStyleBackColor = true;
            this.katakanaGC.CheckStateChanged += new System.EventHandler(this.katakanaGC_CheckStateChanged);
            // 
            // katakanaC
            // 
            this.katakanaC.AutoSize = true;
            this.katakanaC.Location = new System.Drawing.Point(16, 165);
            this.katakanaC.Name = "katakanaC";
            this.katakanaC.Size = new System.Drawing.Size(72, 17);
            this.katakanaC.TabIndex = 10;
            this.katakanaC.Text = "Katakana";
            this.katakanaC.UseVisualStyleBackColor = true;
            this.katakanaC.CheckStateChanged += new System.EventHandler(this.katakanaC_CheckStateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Katakana Settings";
            // 
            // kanjiC
            // 
            this.kanjiC.AutoSize = true;
            this.kanjiC.Location = new System.Drawing.Point(16, 293);
            this.kanjiC.Name = "kanjiC";
            this.kanjiC.Size = new System.Drawing.Size(49, 17);
            this.kanjiC.TabIndex = 16;
            this.kanjiC.Text = "Kanji";
            this.kanjiC.UseVisualStyleBackColor = true;
            this.kanjiC.CheckStateChanged += new System.EventHandler(this.kanjiC_CheckStateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kanji Settings";
            // 
            // hiraganaGRS
            // 
            this.hiraganaGRS.LargeChange = 1;
            this.hiraganaGRS.Location = new System.Drawing.Point(189, 48);
            this.hiraganaGRS.Maximum = 100;
            this.hiraganaGRS.Name = "hiraganaGRS";
            this.hiraganaGRS.Size = new System.Drawing.Size(189, 45);
            this.hiraganaGRS.TabIndex = 17;
            this.hiraganaGRS.TickFrequency = 5;
            this.hiraganaGRS.Scroll += new System.EventHandler(this.hiraganaGRS_Scroll);
            // 
            // hiraganaDRS
            // 
            this.hiraganaDRS.LargeChange = 1;
            this.hiraganaDRS.Location = new System.Drawing.Point(189, 71);
            this.hiraganaDRS.Maximum = 100;
            this.hiraganaDRS.Name = "hiraganaDRS";
            this.hiraganaDRS.Size = new System.Drawing.Size(189, 45);
            this.hiraganaDRS.TabIndex = 18;
            this.hiraganaDRS.TickFrequency = 5;
            this.hiraganaDRS.Scroll += new System.EventHandler(this.hiraganaDRS_Scroll);
            // 
            // hiraganaHRS
            // 
            this.hiraganaHRS.LargeChange = 1;
            this.hiraganaHRS.Location = new System.Drawing.Point(189, 94);
            this.hiraganaHRS.Maximum = 100;
            this.hiraganaHRS.Name = "hiraganaHRS";
            this.hiraganaHRS.Size = new System.Drawing.Size(189, 45);
            this.hiraganaHRS.TabIndex = 19;
            this.hiraganaHRS.TickFrequency = 5;
            this.hiraganaHRS.Scroll += new System.EventHandler(this.hiraganaHRS_Scroll);
            // 
            // hiraganaYRS
            // 
            this.hiraganaYRS.LargeChange = 1;
            this.hiraganaYRS.Location = new System.Drawing.Point(189, 117);
            this.hiraganaYRS.Maximum = 100;
            this.hiraganaYRS.Name = "hiraganaYRS";
            this.hiraganaYRS.Size = new System.Drawing.Size(189, 45);
            this.hiraganaYRS.TabIndex = 20;
            this.hiraganaYRS.TickFrequency = 5;
            this.hiraganaYRS.Scroll += new System.EventHandler(this.hiraganaYRS_Scroll);
            // 
            // katakanaRS
            // 
            this.katakanaRS.LargeChange = 1;
            this.katakanaRS.Location = new System.Drawing.Point(189, 165);
            this.katakanaRS.Maximum = 100;
            this.katakanaRS.Name = "katakanaRS";
            this.katakanaRS.Size = new System.Drawing.Size(189, 45);
            this.katakanaRS.TabIndex = 21;
            this.katakanaRS.TickFrequency = 5;
            this.katakanaRS.Scroll += new System.EventHandler(this.katakanaRS_Scroll);
            // 
            // katakanaGRS
            // 
            this.katakanaGRS.LargeChange = 1;
            this.katakanaGRS.Location = new System.Drawing.Point(189, 188);
            this.katakanaGRS.Maximum = 100;
            this.katakanaGRS.Name = "katakanaGRS";
            this.katakanaGRS.Size = new System.Drawing.Size(189, 45);
            this.katakanaGRS.TabIndex = 22;
            this.katakanaGRS.TickFrequency = 5;
            this.katakanaGRS.Scroll += new System.EventHandler(this.katakanaGRS_Scroll);
            // 
            // katakanaDRS
            // 
            this.katakanaDRS.LargeChange = 1;
            this.katakanaDRS.Location = new System.Drawing.Point(189, 211);
            this.katakanaDRS.Maximum = 100;
            this.katakanaDRS.Name = "katakanaDRS";
            this.katakanaDRS.Size = new System.Drawing.Size(189, 45);
            this.katakanaDRS.TabIndex = 23;
            this.katakanaDRS.TickFrequency = 5;
            this.katakanaDRS.Scroll += new System.EventHandler(this.katakanaDRS_Scroll);
            // 
            // katakanaHRS
            // 
            this.katakanaHRS.LargeChange = 1;
            this.katakanaHRS.Location = new System.Drawing.Point(189, 234);
            this.katakanaHRS.Maximum = 100;
            this.katakanaHRS.Name = "katakanaHRS";
            this.katakanaHRS.Size = new System.Drawing.Size(189, 45);
            this.katakanaHRS.TabIndex = 24;
            this.katakanaHRS.TickFrequency = 5;
            this.katakanaHRS.Scroll += new System.EventHandler(this.katakanaHRS_Scroll);
            // 
            // katakanaYRS
            // 
            this.katakanaYRS.LargeChange = 1;
            this.katakanaYRS.Location = new System.Drawing.Point(189, 257);
            this.katakanaYRS.Maximum = 100;
            this.katakanaYRS.Name = "katakanaYRS";
            this.katakanaYRS.Size = new System.Drawing.Size(189, 45);
            this.katakanaYRS.TabIndex = 25;
            this.katakanaYRS.TickFrequency = 5;
            this.katakanaYRS.Scroll += new System.EventHandler(this.katakanaYRS_Scroll);
            // 
            // kanjiRS
            // 
            this.kanjiRS.LargeChange = 1;
            this.kanjiRS.Location = new System.Drawing.Point(189, 293);
            this.kanjiRS.Maximum = 100;
            this.kanjiRS.Name = "kanjiRS";
            this.kanjiRS.Size = new System.Drawing.Size(189, 45);
            this.kanjiRS.TabIndex = 26;
            this.kanjiRS.TickFrequency = 5;
            this.kanjiRS.Scroll += new System.EventHandler(this.kanjiRS_Scroll);
            // 
            // hiraganaRT
            // 
            this.hiraganaRT.AutoSize = true;
            this.hiraganaRT.Location = new System.Drawing.Point(384, 26);
            this.hiraganaRT.Name = "hiraganaRT";
            this.hiraganaRT.Size = new System.Drawing.Size(13, 13);
            this.hiraganaRT.TabIndex = 27;
            this.hiraganaRT.Text = "0";
            // 
            // hiraganaGRT
            // 
            this.hiraganaGRT.AutoSize = true;
            this.hiraganaGRT.Location = new System.Drawing.Point(384, 49);
            this.hiraganaGRT.Name = "hiraganaGRT";
            this.hiraganaGRT.Size = new System.Drawing.Size(13, 13);
            this.hiraganaGRT.TabIndex = 28;
            this.hiraganaGRT.Text = "0";
            // 
            // hiraganaDRT
            // 
            this.hiraganaDRT.AutoSize = true;
            this.hiraganaDRT.Location = new System.Drawing.Point(384, 72);
            this.hiraganaDRT.Name = "hiraganaDRT";
            this.hiraganaDRT.Size = new System.Drawing.Size(13, 13);
            this.hiraganaDRT.TabIndex = 29;
            this.hiraganaDRT.Text = "0";
            // 
            // hiraganaHRT
            // 
            this.hiraganaHRT.AutoSize = true;
            this.hiraganaHRT.Location = new System.Drawing.Point(384, 95);
            this.hiraganaHRT.Name = "hiraganaHRT";
            this.hiraganaHRT.Size = new System.Drawing.Size(13, 13);
            this.hiraganaHRT.TabIndex = 30;
            this.hiraganaHRT.Text = "0";
            // 
            // hiraganaYRT
            // 
            this.hiraganaYRT.AutoSize = true;
            this.hiraganaYRT.Location = new System.Drawing.Point(384, 118);
            this.hiraganaYRT.Name = "hiraganaYRT";
            this.hiraganaYRT.Size = new System.Drawing.Size(13, 13);
            this.hiraganaYRT.TabIndex = 31;
            this.hiraganaYRT.Text = "0";
            // 
            // katakanaRT
            // 
            this.katakanaRT.AutoSize = true;
            this.katakanaRT.Location = new System.Drawing.Point(384, 166);
            this.katakanaRT.Name = "katakanaRT";
            this.katakanaRT.Size = new System.Drawing.Size(13, 13);
            this.katakanaRT.TabIndex = 32;
            this.katakanaRT.Text = "0";
            // 
            // katakanaGRT
            // 
            this.katakanaGRT.AutoSize = true;
            this.katakanaGRT.Location = new System.Drawing.Point(384, 189);
            this.katakanaGRT.Name = "katakanaGRT";
            this.katakanaGRT.Size = new System.Drawing.Size(13, 13);
            this.katakanaGRT.TabIndex = 33;
            this.katakanaGRT.Text = "0";
            // 
            // katakanaDRT
            // 
            this.katakanaDRT.AutoSize = true;
            this.katakanaDRT.Location = new System.Drawing.Point(384, 212);
            this.katakanaDRT.Name = "katakanaDRT";
            this.katakanaDRT.Size = new System.Drawing.Size(13, 13);
            this.katakanaDRT.TabIndex = 34;
            this.katakanaDRT.Text = "0";
            // 
            // katakanaHRT
            // 
            this.katakanaHRT.AutoSize = true;
            this.katakanaHRT.Location = new System.Drawing.Point(384, 235);
            this.katakanaHRT.Name = "katakanaHRT";
            this.katakanaHRT.Size = new System.Drawing.Size(13, 13);
            this.katakanaHRT.TabIndex = 35;
            this.katakanaHRT.Text = "0";
            // 
            // katakanaYRT
            // 
            this.katakanaYRT.AutoSize = true;
            this.katakanaYRT.Location = new System.Drawing.Point(384, 258);
            this.katakanaYRT.Name = "katakanaYRT";
            this.katakanaYRT.Size = new System.Drawing.Size(13, 13);
            this.katakanaYRT.TabIndex = 36;
            this.katakanaYRT.Text = "0";
            // 
            // kanjiRT
            // 
            this.kanjiRT.AutoSize = true;
            this.kanjiRT.Location = new System.Drawing.Point(384, 294);
            this.kanjiRT.Name = "kanjiRT";
            this.kanjiRT.Size = new System.Drawing.Size(13, 13);
            this.kanjiRT.TabIndex = 37;
            this.kanjiRT.Text = "0";
            // 
            // saveSettings
            // 
            this.saveSettings.Location = new System.Drawing.Point(196, 330);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(71, 24);
            this.saveSettings.TabIndex = 38;
            this.saveSettings.Text = "Save";
            this.saveSettings.UseVisualStyleBackColor = true;
            this.saveSettings.Click += new System.EventHandler(this.saveSettings_Click);
            // 
            // resetSettings
            // 
            this.resetSettings.Location = new System.Drawing.Point(273, 330);
            this.resetSettings.Name = "resetSettings";
            this.resetSettings.Size = new System.Drawing.Size(71, 24);
            this.resetSettings.TabIndex = 39;
            this.resetSettings.Text = "Reset";
            this.resetSettings.UseVisualStyleBackColor = true;
            this.resetSettings.Click += new System.EventHandler(this.resetSettings_Click);
            // 
            // cancelSettings
            // 
            this.cancelSettings.Location = new System.Drawing.Point(350, 330);
            this.cancelSettings.Name = "cancelSettings";
            this.cancelSettings.Size = new System.Drawing.Size(71, 24);
            this.cancelSettings.TabIndex = 40;
            this.cancelSettings.Text = "Cancel";
            this.cancelSettings.UseVisualStyleBackColor = true;
            this.cancelSettings.Click += new System.EventHandler(this.cancelSettings_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 366);
            this.Controls.Add(this.cancelSettings);
            this.Controls.Add(this.resetSettings);
            this.Controls.Add(this.saveSettings);
            this.Controls.Add(this.kanjiRT);
            this.Controls.Add(this.katakanaYRT);
            this.Controls.Add(this.katakanaHRT);
            this.Controls.Add(this.katakanaDRT);
            this.Controls.Add(this.katakanaGRT);
            this.Controls.Add(this.katakanaRT);
            this.Controls.Add(this.hiraganaYRT);
            this.Controls.Add(this.hiraganaHRT);
            this.Controls.Add(this.hiraganaDRT);
            this.Controls.Add(this.hiraganaGRT);
            this.Controls.Add(this.hiraganaRT);
            this.Controls.Add(this.kanjiRS);
            this.Controls.Add(this.katakanaYRS);
            this.Controls.Add(this.katakanaHRS);
            this.Controls.Add(this.katakanaDRS);
            this.Controls.Add(this.katakanaGRS);
            this.Controls.Add(this.katakanaRS);
            this.Controls.Add(this.hiraganaYRS);
            this.Controls.Add(this.hiraganaHRS);
            this.Controls.Add(this.hiraganaDRS);
            this.Controls.Add(this.hiraganaGRS);
            this.Controls.Add(this.kanjiC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.katakanaYC);
            this.Controls.Add(this.katakanaHC);
            this.Controls.Add(this.katakanaDC);
            this.Controls.Add(this.katakanaGC);
            this.Controls.Add(this.katakanaC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hiraganaYC);
            this.Controls.Add(this.hiraganaHC);
            this.Controls.Add(this.hiraganaDC);
            this.Controls.Add(this.hiraganaRS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hiraganaGC);
            this.Controls.Add(this.hiraganaC);
            this.Controls.Add(this.label1);
            this.Name = "settingsForm";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.hiraganaRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiraganaGRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiraganaDRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiraganaHRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiraganaYRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katakanaRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katakanaGRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katakanaDRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katakanaHRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katakanaYRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanjiRS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox hiraganaC;
        private System.Windows.Forms.CheckBox hiraganaGC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar hiraganaRS;
        private System.Windows.Forms.CheckBox hiraganaDC;
        private System.Windows.Forms.CheckBox hiraganaHC;
        private System.Windows.Forms.CheckBox hiraganaYC;
        private System.Windows.Forms.CheckBox katakanaYC;
        private System.Windows.Forms.CheckBox katakanaHC;
        private System.Windows.Forms.CheckBox katakanaDC;
        private System.Windows.Forms.CheckBox katakanaGC;
        private System.Windows.Forms.CheckBox katakanaC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox kanjiC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar hiraganaGRS;
        private System.Windows.Forms.TrackBar hiraganaDRS;
        private System.Windows.Forms.TrackBar hiraganaHRS;
        private System.Windows.Forms.TrackBar hiraganaYRS;
        private System.Windows.Forms.TrackBar katakanaRS;
        private System.Windows.Forms.TrackBar katakanaGRS;
        private System.Windows.Forms.TrackBar katakanaDRS;
        private System.Windows.Forms.TrackBar katakanaHRS;
        private System.Windows.Forms.TrackBar katakanaYRS;
        private System.Windows.Forms.TrackBar kanjiRS;
        private System.Windows.Forms.Label hiraganaRT;
        private System.Windows.Forms.Label hiraganaGRT;
        private System.Windows.Forms.Label hiraganaDRT;
        private System.Windows.Forms.Label hiraganaHRT;
        private System.Windows.Forms.Label hiraganaYRT;
        private System.Windows.Forms.Label katakanaRT;
        private System.Windows.Forms.Label katakanaGRT;
        private System.Windows.Forms.Label katakanaDRT;
        private System.Windows.Forms.Label katakanaHRT;
        private System.Windows.Forms.Label katakanaYRT;
        private System.Windows.Forms.Label kanjiRT;
        private System.Windows.Forms.Button saveSettings;
        private System.Windows.Forms.Button resetSettings;
        private System.Windows.Forms.Button cancelSettings;
    }
}