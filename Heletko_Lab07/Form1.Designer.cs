namespace Heletko_Lab07
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.decodeButton = new System.Windows.Forms.Button();
            this.encodeButton = new System.Windows.Forms.Button();
            this.generateVectorCheckBox = new System.Windows.Forms.CheckBox();
            this.generateVectorButton = new System.Windows.Forms.Button();
            this.generateKeyButton = new System.Windows.Forms.Button();
            this.saveSettingsBtn = new System.Windows.Forms.Button();
            this.openSettingsBtn = new System.Windows.Forms.Button();
            this.kLengthComboBox = new System.Windows.Forms.ComboBox();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.outELabel = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.inELabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rc2RadioButton = new System.Windows.Forms.RadioButton();
            this.trDESRadioButton = new System.Windows.Forms.RadioButton();
            this.desRadioButton = new System.Windows.Forms.RadioButton();
            this.rijndaelRadioButton = new System.Windows.Forms.RadioButton();
            this.aesRadioButton = new System.Windows.Forms.RadioButton();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vTextBox = new System.Windows.Forms.TextBox();
            this.kTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.saveFilePathBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.openFilePathBox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(269, 375);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(105, 23);
            this.decodeButton.TabIndex = 14;
            this.decodeButton.Text = "Розшифрувати";
            this.toolTip1.SetToolTip(this.decodeButton, "Розшифрувати файл");
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // encodeButton
            // 
            this.encodeButton.Location = new System.Drawing.Point(173, 375);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(90, 23);
            this.encodeButton.TabIndex = 13;
            this.encodeButton.Text = "Зашифрувати";
            this.toolTip1.SetToolTip(this.encodeButton, "Зашифрувати файл");
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // generateVectorCheckBox
            // 
            this.generateVectorCheckBox.AutoSize = true;
            this.generateVectorCheckBox.Checked = true;
            this.generateVectorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.generateVectorCheckBox.Location = new System.Drawing.Point(392, 90);
            this.generateVectorCheckBox.Name = "generateVectorCheckBox";
            this.generateVectorCheckBox.Size = new System.Drawing.Size(54, 17);
            this.generateVectorCheckBox.TabIndex = 19;
            this.generateVectorCheckBox.Text = "BI = 0";
            this.toolTip1.SetToolTip(this.generateVectorCheckBox, "Заповнити вектор нулями");
            this.generateVectorCheckBox.UseVisualStyleBackColor = true;
            this.generateVectorCheckBox.CheckedChanged += new System.EventHandler(this.generateVectorCheckBox_CheckedChanged);
            // 
            // generateVectorButton
            // 
            this.generateVectorButton.BackgroundImage = global::Heletko_Lab07.Properties.Resources.hand;
            this.generateVectorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.generateVectorButton.Enabled = false;
            this.generateVectorButton.Location = new System.Drawing.Point(335, 83);
            this.generateVectorButton.Name = "generateVectorButton";
            this.generateVectorButton.Size = new System.Drawing.Size(51, 27);
            this.generateVectorButton.TabIndex = 17;
            this.toolTip1.SetToolTip(this.generateVectorButton, "Створити новий вектор ініціалізації");
            this.generateVectorButton.UseVisualStyleBackColor = true;
            this.generateVectorButton.Click += new System.EventHandler(this.generateVectorButton_Click);
            // 
            // generateKeyButton
            // 
            this.generateKeyButton.BackgroundImage = global::Heletko_Lab07.Properties.Resources.key_s1;
            this.generateKeyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.generateKeyButton.Location = new System.Drawing.Point(335, 42);
            this.generateKeyButton.Name = "generateKeyButton";
            this.generateKeyButton.Size = new System.Drawing.Size(51, 27);
            this.generateKeyButton.TabIndex = 13;
            this.toolTip1.SetToolTip(this.generateKeyButton, "Створити новий ключ");
            this.generateKeyButton.UseVisualStyleBackColor = true;
            this.generateKeyButton.Click += new System.EventHandler(this.generateKeyButton_Click);
            // 
            // saveSettingsBtn
            // 
            this.saveSettingsBtn.BackgroundImage = global::Heletko_Lab07.Properties.Resources.Download_Folder_icon;
            this.saveSettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveSettingsBtn.Location = new System.Drawing.Point(454, 35);
            this.saveSettingsBtn.Name = "saveSettingsBtn";
            this.saveSettingsBtn.Size = new System.Drawing.Size(51, 40);
            this.saveSettingsBtn.TabIndex = 12;
            this.toolTip1.SetToolTip(this.saveSettingsBtn, "Зберегти налаштування");
            this.saveSettingsBtn.UseVisualStyleBackColor = true;
            this.saveSettingsBtn.Click += new System.EventHandler(this.saveSettingsBtn_Click);
            // 
            // openSettingsBtn
            // 
            this.openSettingsBtn.BackgroundImage = global::Heletko_Lab07.Properties.Resources.Folder_Heart_icon;
            this.openSettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openSettingsBtn.Location = new System.Drawing.Point(517, 35);
            this.openSettingsBtn.Name = "openSettingsBtn";
            this.openSettingsBtn.Size = new System.Drawing.Size(51, 40);
            this.openSettingsBtn.TabIndex = 11;
            this.toolTip1.SetToolTip(this.openSettingsBtn, "Відновити налаштування");
            this.openSettingsBtn.UseVisualStyleBackColor = true;
            this.openSettingsBtn.Click += new System.EventHandler(this.openSettingsBtn_Click);
            // 
            // kLengthComboBox
            // 
            this.kLengthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kLengthComboBox.FormattingEnabled = true;
            this.kLengthComboBox.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.kLengthComboBox.Location = new System.Drawing.Point(123, 19);
            this.kLengthComboBox.Name = "kLengthComboBox";
            this.kLengthComboBox.Size = new System.Drawing.Size(60, 21);
            this.kLengthComboBox.TabIndex = 10;
            this.toolTip1.SetToolTip(this.kLengthComboBox, "Змінити довжину ключа шифрування");
            this.kLengthComboBox.SelectedIndexChanged += new System.EventHandler(this.kLengthComboBox_SelectedIndexChanged);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(568, 17);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(42, 23);
            this.saveFileButton.TabIndex = 14;
            this.saveFileButton.Text = "...";
            this.toolTip1.SetToolTip(this.saveFileButton, "Обрати вихідний файл");
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // outELabel
            // 
            this.outELabel.AutoSize = true;
            this.outELabel.Location = new System.Drawing.Point(58, 46);
            this.outELabel.Name = "outELabel";
            this.outELabel.Size = new System.Drawing.Size(25, 13);
            this.outELabel.TabIndex = 12;
            this.outELabel.Text = "???";
            this.toolTip1.SetToolTip(this.outELabel, "Скопіювати ентропію у буфер обміну");
            this.outELabel.Click += new System.EventHandler(this.outELabel_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(568, 17);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(42, 23);
            this.openFileButton.TabIndex = 11;
            this.openFileButton.Text = "...";
            this.toolTip1.SetToolTip(this.openFileButton, "Обрати вхідний файл");
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // inELabel
            // 
            this.inELabel.AutoSize = true;
            this.inELabel.Location = new System.Drawing.Point(58, 46);
            this.inELabel.Name = "inELabel";
            this.inELabel.Size = new System.Drawing.Size(25, 13);
            this.inELabel.TabIndex = 11;
            this.inELabel.Text = "???";
            this.toolTip1.SetToolTip(this.inELabel, "Скопіювати ентропію у буфер обміну");
            this.inELabel.Click += new System.EventHandler(this.inELabel_Click);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(386, 46);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(25, 13);
            this.sizeLabel.TabIndex = 10;
            this.sizeLabel.Text = "???";
            this.toolTip1.SetToolTip(this.sizeLabel, "Розмір вхідного файлу");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Час шифрування (год : хв : сек):";
            // 
            // rc2RadioButton
            // 
            this.rc2RadioButton.AutoSize = true;
            this.rc2RadioButton.Location = new System.Drawing.Point(262, 19);
            this.rc2RadioButton.Name = "rc2RadioButton";
            this.rc2RadioButton.Size = new System.Drawing.Size(46, 17);
            this.rc2RadioButton.TabIndex = 4;
            this.rc2RadioButton.Text = "RC2";
            this.rc2RadioButton.UseVisualStyleBackColor = true;
            this.rc2RadioButton.CheckedChanged += new System.EventHandler(this.rc2RadioButton_CheckedChanged);
            // 
            // trDESRadioButton
            // 
            this.trDESRadioButton.AutoSize = true;
            this.trDESRadioButton.Location = new System.Drawing.Point(183, 19);
            this.trDESRadioButton.Name = "trDESRadioButton";
            this.trDESRadioButton.Size = new System.Drawing.Size(73, 17);
            this.trDESRadioButton.TabIndex = 3;
            this.trDESRadioButton.Text = "TripleDES";
            this.trDESRadioButton.UseVisualStyleBackColor = true;
            this.trDESRadioButton.CheckedChanged += new System.EventHandler(this.trDESRadioButton_CheckedChanged);
            // 
            // desRadioButton
            // 
            this.desRadioButton.AutoSize = true;
            this.desRadioButton.Location = new System.Drawing.Point(130, 19);
            this.desRadioButton.Name = "desRadioButton";
            this.desRadioButton.Size = new System.Drawing.Size(47, 17);
            this.desRadioButton.TabIndex = 2;
            this.desRadioButton.Text = "DES";
            this.desRadioButton.UseVisualStyleBackColor = true;
            this.desRadioButton.CheckedChanged += new System.EventHandler(this.desRadioButton_CheckedChanged);
            // 
            // rijndaelRadioButton
            // 
            this.rijndaelRadioButton.AutoSize = true;
            this.rijndaelRadioButton.Location = new System.Drawing.Point(61, 19);
            this.rijndaelRadioButton.Name = "rijndaelRadioButton";
            this.rijndaelRadioButton.Size = new System.Drawing.Size(63, 17);
            this.rijndaelRadioButton.TabIndex = 1;
            this.rijndaelRadioButton.Text = "Rijndael";
            this.rijndaelRadioButton.UseVisualStyleBackColor = true;
            this.rijndaelRadioButton.CheckedChanged += new System.EventHandler(this.rijndaelRadioButton_CheckedChanged);
            // 
            // aesRadioButton
            // 
            this.aesRadioButton.AutoSize = true;
            this.aesRadioButton.Checked = true;
            this.aesRadioButton.Location = new System.Drawing.Point(9, 20);
            this.aesRadioButton.Name = "aesRadioButton";
            this.aesRadioButton.Size = new System.Drawing.Size(46, 17);
            this.aesRadioButton.TabIndex = 0;
            this.aesRadioButton.TabStop = true;
            this.aesRadioButton.Text = "AES";
            this.aesRadioButton.UseVisualStyleBackColor = true;
            this.aesRadioButton.CheckedChanged += new System.EventHandler(this.aesRadioButton_CheckedChanged);
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Location = new System.Drawing.Point(555, 380);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(70, 13);
            this.totalTimeLabel.TabIndex = 17;
            this.totalTimeLabel.Text = "00:00:00.000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.generateVectorCheckBox);
            this.groupBox2.Controls.Add(this.vTextBox);
            this.groupBox2.Controls.Add(this.generateVectorButton);
            this.groupBox2.Controls.Add(this.kTextBox);
            this.groupBox2.Controls.Add(this.generateKeyButton);
            this.groupBox2.Controls.Add(this.saveSettingsBtn);
            this.groupBox2.Controls.Add(this.openSettingsBtn);
            this.groupBox2.Controls.Add(this.kLengthComboBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 174);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Налаштування шифрування";
            // 
            // vTextBox
            // 
            this.vTextBox.Enabled = false;
            this.vTextBox.Location = new System.Drawing.Point(15, 87);
            this.vTextBox.Name = "vTextBox";
            this.vTextBox.Size = new System.Drawing.Size(314, 20);
            this.vTextBox.TabIndex = 18;
            this.vTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vTextBox_KeyPress);
            // 
            // kTextBox
            // 
            this.kTextBox.Location = new System.Drawing.Point(15, 46);
            this.kTextBox.Name = "kTextBox";
            this.kTextBox.Size = new System.Drawing.Size(314, 20);
            this.kTextBox.TabIndex = 16;
            this.kTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Довжина ключа (біт):";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rc2RadioButton);
            this.groupBox5.Controls.Add(this.trDESRadioButton);
            this.groupBox5.Controls.Add(this.desRadioButton);
            this.groupBox5.Controls.Add(this.rijndaelRadioButton);
            this.groupBox5.Controls.Add(this.aesRadioButton);
            this.groupBox5.Location = new System.Drawing.Point(6, 113);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(616, 55);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Тип шифрування";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Розмір";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ентропія";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(658, 24);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.helpToolStripMenuItem.Text = "Довідка";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aboutProgramToolStripMenuItem.Text = "Про програму";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 162);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файл";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.saveFileButton);
            this.groupBox4.Controls.Add(this.saveFilePathBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.outELabel);
            this.groupBox4.Location = new System.Drawing.Point(6, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(616, 62);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Вихідний файл";
            // 
            // saveFilePathBox
            // 
            this.saveFilePathBox.Location = new System.Drawing.Point(9, 19);
            this.saveFilePathBox.Name = "saveFilePathBox";
            this.saveFilePathBox.Size = new System.Drawing.Size(553, 20);
            this.saveFilePathBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ентропія";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.openFileButton);
            this.groupBox3.Controls.Add(this.openFilePathBox);
            this.groupBox3.Controls.Add(this.inELabel);
            this.groupBox3.Controls.Add(this.sizeLabel);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(616, 62);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вхідний файл";
            // 
            // openFilePathBox
            // 
            this.openFilePathBox.Location = new System.Drawing.Point(9, 19);
            this.openFilePathBox.Name = "openFilePathBox";
            this.openFilePathBox.Size = new System.Drawing.Size(553, 20);
            this.openFilePathBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.totalTimeLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.CheckBox generateVectorCheckBox;
        private System.Windows.Forms.Button generateVectorButton;
        private System.Windows.Forms.Button generateKeyButton;
        private System.Windows.Forms.Button saveSettingsBtn;
        private System.Windows.Forms.Button openSettingsBtn;
        private System.Windows.Forms.ComboBox kLengthComboBox;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Label outELabel;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label inELabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rc2RadioButton;
        private System.Windows.Forms.RadioButton trDESRadioButton;
        private System.Windows.Forms.RadioButton desRadioButton;
        private System.Windows.Forms.RadioButton rijndaelRadioButton;
        private System.Windows.Forms.RadioButton aesRadioButton;
        private System.Windows.Forms.Label totalTimeLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox vTextBox;
        private System.Windows.Forms.TextBox kTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox saveFilePathBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox openFilePathBox;
    }
}

