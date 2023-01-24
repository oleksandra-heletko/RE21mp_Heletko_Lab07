using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Collections;

namespace Heletko_Lab07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kLengthComboBox.SelectedIndex = 0;
            vTextBox.Text = "00-00-00-00-00-00-00-00";
        }

        byte[] fArray = new byte[0];
        byte[] rArray = new byte[0];
        byte[] key = new byte[0];
        byte[] iv = new byte[0];
        string fString = "";

        private void openFileButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Всі файли (*.*)|*.*|Текстові файли (*.txt)|*.txt";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;

                if (path == "")
                {
                    MessageBox.Show("Невірний шлях до файлу!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    openFileButton.Focus();
                    this.Cursor = Cursors.Default;
                    return;
                }
                if (!File.Exists(path))
                {
                    MessageBox.Show("Файл не існує!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    openFileButton.Focus();
                    this.Cursor = Cursors.Default;
                    return;
                }
                openFilePathBox.Text = path;
                this.fArray = File.ReadAllBytes(path);
                inELabel.Text = String.Format("{0:0.000}", CalculateEntropy(this.fArray));
                this.fString = File.ReadAllText(path);
                sizeLabel.Text = String.Format("- {0:0.000} Mb ({1} байт)", (double)this.fArray.Length / (1024.0 * 1024.0), fArray.Length);
            }
            this.Cursor = Cursors.Default;
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Всы файли (*.*)|*.*|Текстовы файли (*.txt)|*.txt";
            fileDialog.FilterIndex = 2;
            fileDialog.CreatePrompt = true;
            fileDialog.OverwritePrompt = true;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;

                if (path == "")
                {
                    MessageBox.Show("Невірний шлях до файлу ключа!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    saveFileButton.Focus();
                    return;
                }
                saveFilePathBox.Text = path;
            }
        }

        private void inELabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(inELabel.Text);
        }

        private void outELabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outELabel.Text);
        }

        private void kLengthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lRadioButton != cRadioButton)
            {
                lRadioButton = cRadioButton;
                return;
            }
            this.key = GenerateKey();
            this.iv = GenerateIV();
            kTextBox.Text = StringHEX(this.key);
            vTextBox.Text = StringHEX(this.iv);
        }

        private void generateKeyButton_Click(object sender, EventArgs e)
        {
            this.key = GenerateKey();
            kTextBox.Text = StringHEX(this.key);
        }

        private void generateVectorButton_Click(object sender, EventArgs e)
        {
            this.iv = GenerateIV();
            vTextBox.Text = StringHEX(this.iv);
        }

        private void generateVectorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (generateVectorCheckBox.Checked)
            {
                vTextBox.Text = "00-00-00-00-00-00-00-00";
                vTextBox.Enabled = false;
                generateVectorButton.Enabled = false;
            }
            else
            {
                vTextBox.Enabled = true;
                vTextBox.Text = StringHEX(iv);
                generateVectorButton.Enabled = true;
            }
        }

        private void saveSettingsBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Всі файли (*.*)|*.*|Текстові файли (*.txt)|*.txt";
            fileDialog.FilterIndex = 2;
            fileDialog.CreatePrompt = true;
            fileDialog.OverwritePrompt = true;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;

                if (path == "")
                {
                    MessageBox.Show("Пустий шлях до файлу!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    saveSettingsBtn.Focus();
                    return;
                }
                this.Cursor = Cursors.WaitCursor;
                Application.DoEvents();
                string settings = "";
                if (aesRadioButton.Checked) settings += "aes" + "|";
                if (rijndaelRadioButton.Checked) settings += "rijndael" +"|";
                if (desRadioButton.Checked) settings += "des" + "|";
                if (trDESRadioButton.Checked) settings += "trDES" + "|";
                if (rc2RadioButton.Checked) settings += "(rc2" + "|";
                settings += generateVectorCheckBox.Checked ? "true" + "|" : "false" + "|";
                settings += kLengthComboBox.Text + "|";
                settings += kTextBox.Text + "|";
                settings += vTextBox.Text;
                File.WriteAllText(path, settings);
            }
            this.Cursor = Cursors.Default;
        }

        private void openSettingsBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Всі файли (*.*)|*.*|Текстові файли (*.txt)|*.txt";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;

                if (path == "")
                {
                    MessageBox.Show("Шлях до файлу налаштувань не існує!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    openSettingsBtn.Focus();
                    this.Cursor = Cursors.Default;
                    return;
                }
                if (!File.Exists(path))
                {
                    MessageBox.Show("Файл не існує!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    openSettingsBtn.Focus();
                    this.Cursor = Cursors.Default;
                    return;
                }
                string all_settings = File.ReadAllText(path);
                string[] settings = all_settings.Split('|');
                switch (settings[0])
                {
                    case "aes":
                        aesRadioButton.Checked = true;
                        break;
                    case "rijndael":
                        rijndaelRadioButton.Checked = true;
                        break;
                    case "des":
                        desRadioButton.Checked = true;
                        break;
                    case "trDES":
                        trDESRadioButton.Checked = true;
                        break;
                    case "rc2":
                        rc2RadioButton.Checked = true;
                        break;
                    default:
                        aesRadioButton.Checked = true;
                        break;
                }
                if (settings[1] == "true") generateVectorCheckBox.Checked = true;
                if (settings[1] == "false") generateVectorCheckBox.Checked = false;
                kLengthComboBox.SelectedItem = settings[2];
                kTextBox.Text = settings[3];
                this.key = StringToByteArr(settings[3]);
                if (settings[1] == "false") { vTextBox.Text = settings[4]; this.iv = StringToByteArr(settings[4]); }
            }
            this.Cursor = Cursors.Default;
        }

        private void aesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (aesRadioButton.Checked)
            {
                cRadioButton = aesRadioButton;
                kLengthComboBox.Items.Clear();
                kLengthComboBox.Items.AddRange(new string[] { "128", "192", "256" });
                kLengthComboBox.Enabled = true;
                kLengthComboBox.SelectedIndex = 0;
                this.key = GenerateKey();
                this.iv = GenerateIV();
                kTextBox.Text = StringHEX(this.key);
                if (vTextBox.Enabled) vTextBox.Text = StringHEX(this.iv);
            }
        }

        private void rijndaelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rijndaelRadioButton.Checked)
            {
                cRadioButton = rijndaelRadioButton;
                kLengthComboBox.Items.Clear();
                kLengthComboBox.Items.AddRange(new string[] { "128", "192", "256" });
                kLengthComboBox.Enabled = true;
                kLengthComboBox.SelectedIndex = 0;
                this.key = GenerateKey();
                this.iv = GenerateIV();
                kTextBox.Text = StringHEX(this.key);
                if (vTextBox.Enabled) vTextBox.Text = StringHEX(this.iv);
            }
        }

        private void desRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (desRadioButton.Checked)
            {
                cRadioButton = desRadioButton;
                kLengthComboBox.Items.Clear();
                kLengthComboBox.Items.Add("64");
                kLengthComboBox.Enabled = false;
                kLengthComboBox.SelectedIndex = 0;
                this.key = GenerateKey();
                this.iv = GenerateIV();
                kTextBox.Text = StringHEX(this.key);
                if (vTextBox.Enabled) vTextBox.Text = StringHEX(this.iv);
            }
        }

        private void trDESRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (trDESRadioButton.Checked)
            {
                cRadioButton = trDESRadioButton;
                kLengthComboBox.Items.Clear();
                kLengthComboBox.Items.AddRange(new string[] { "128", "192" });
                kLengthComboBox.Enabled = true;
                kLengthComboBox.SelectedIndex = 0;
                this.key = GenerateKey();
                this.iv = GenerateIV();
                kTextBox.Text = StringHEX(this.key);
                if (vTextBox.Enabled) vTextBox.Text = StringHEX(this.iv);
            }
        }

        private void rc2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rc2RadioButton.Checked)
            {
                cRadioButton = rc2RadioButton;
                kLengthComboBox.Items.Clear();
                kLengthComboBox.Items.AddRange(new string[] { "40", "48", "56", "64", "72", "80", "88", "96", "104", "112", "120", "128" });
                kLengthComboBox.Enabled = true;
                kLengthComboBox.SelectedIndex = 0;
                this.key = GenerateKey();
                this.iv = GenerateIV();
                kTextBox.Text = StringHEX(this.key);
                if (vTextBox.Enabled) vTextBox.Text = StringHEX(this.iv);
            }
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            string path = saveFilePathBox.Text;
            DateTime startTime;
            DateTime finishTime;
            TimeSpan allTime;
            totalTimeLabel.Text = "0:00:00:00.000";

            if (path == "")
            {
                MessageBox.Show("Неправильний шлях до вихідного файлу!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saveFilePathBox.Focus();
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            startTime = DateTime.Now;
            this.rArray = MyEncoding(fString);
            File.WriteAllBytes(path, this.rArray);
            finishTime = DateTime.Now;
            allTime = finishTime - startTime;
            totalTimeLabel.Text = allTime.ToString(@"d\:hh\:mm\:ss\.fff");
            outELabel.Text = String.Format("{0:0.000}", CalculateEntropy(this.rArray));
            this.Cursor = Cursors.Default;
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            string path = saveFilePathBox.Text;
            DateTime startTime;
            DateTime finishTime;
            TimeSpan allTime;
            totalTimeLabel.Text = "0:00:00:00.000";

            if (path == "")
            {
                MessageBox.Show("Неправильний шлях до файлу!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saveFilePathBox.Focus();
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            startTime = DateTime.Now;
            try
            {
                this.rArray = Encoding.ASCII.GetBytes(MyDecoding(this.fArray));
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильний ключ або вектор ініціалізації!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                openSettingsBtn.Focus();
                this.Cursor = Cursors.Default;
                return;
            }
            File.WriteAllBytes(path, this.rArray);
            finishTime = DateTime.Now;
            allTime = finishTime - startTime;
            totalTimeLabel.Text = allTime.ToString(@"d\:hh\:mm\:ss\.fff");

            this.Cursor = Cursors.Default;
        }

        private void kTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            if (!chars.Contains(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '-')
            {
                if (chars.Contains(e.KeyChar.ToString().ToUpper().ToCharArray()[0]))
                {
                    e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
                    string result = "";
                    foreach (string stByte in kTextBox.Text.Split('-'))
                    {
                        if (stByte.Length == 2)
                        {
                            result += stByte;
                        }
                    }
                    this.key = StringToByteArr(result);
                    return;
                }
                e.Handled = true;
                return;
            }
            else
            {
                string result = "";
                foreach (string stByte in kTextBox.Text.Split('-'))
                {
                    if (stByte.Length == 2)
                    {
                        result += stByte;
                    }
                }
                this.key = StringToByteArr(result);
            }
        }

        private void vTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            if (!chars.Contains(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '-')
            {
                if (chars.Contains(e.KeyChar.ToString().ToUpper().ToCharArray()[0]))
                {
                    e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
                    string result = "";
                    foreach (string stByte in vTextBox.Text.Split('-'))
                    {
                        if (stByte.Length == 2)
                        {
                            result += stByte;
                        }
                    }
                    this.iv = StringToByteArr(result);
                    return;
                }
                e.Handled = true;
                return;
            }
            else
            {
                string result = "";
                foreach (string stByte in vTextBox.Text.Split('-'))
                {
                    if (stByte.Length == 2)
                    {
                        result += stByte;
                    }
                }
                this.iv = StringToByteArr(result);
            }
        }

        byte[] GenerateKey()
        {
            if (aesRadioButton.Checked)
            {
                AesCryptoServiceProvider provider = new AesCryptoServiceProvider();
                provider.KeySize = Int32.Parse(kLengthComboBox.Text);
                provider.GenerateKey();
                return provider.Key;
            }
            if (rijndaelRadioButton.Checked)
            {
                RijndaelManaged provider = new RijndaelManaged();
                provider.KeySize = Int32.Parse(kLengthComboBox.Text);
                provider.GenerateKey();
                return provider.Key;
            }
            if (desRadioButton.Checked)
            {
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                provider.KeySize = Int32.Parse(kLengthComboBox.Text);
                provider.GenerateKey();
                return provider.Key;
            }
            if (trDESRadioButton.Checked)
            {
                TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
                provider.KeySize = Int32.Parse(kLengthComboBox.Text);
                provider.GenerateKey();
                return provider.Key;
            }
            if (rc2RadioButton.Checked)
            {
                RC2CryptoServiceProvider provider = new RC2CryptoServiceProvider();
                provider.KeySize = Int32.Parse(kLengthComboBox.Text);
                provider.GenerateKey();
                return provider.Key;
            }
            return new byte[0];
        }

        byte[] GenerateIV()
        {
            if (aesRadioButton.Checked)
            {
                AesCryptoServiceProvider provider = new AesCryptoServiceProvider();
                provider.KeySize = Int32.Parse(kLengthComboBox.Text);
                provider.GenerateIV();
                return provider.IV;
            }
            if (rijndaelRadioButton.Checked)
            {
                RijndaelManaged provider = new RijndaelManaged();
                provider.KeySize = Int32.Parse(kLengthComboBox.Text);
                provider.GenerateIV();
                return provider.IV;
            }
            if (desRadioButton.Checked)
            {
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                provider.KeySize = Int32.Parse(kLengthComboBox.Text);
                provider.GenerateIV();
                return provider.IV;
            }
            if (trDESRadioButton.Checked)
            {
                TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
                provider.KeySize = Int32.Parse(kLengthComboBox.Text);
                provider.GenerateIV();
                return provider.IV;
            }
            if (rc2RadioButton.Checked)
            {
                RC2CryptoServiceProvider provider = new RC2CryptoServiceProvider();
                provider.KeySize = Int32.Parse(kLengthComboBox.Text);
                provider.GenerateIV();
                return provider.IV;
            }
            return new byte[0];
        }

        byte[] StringToByteArr(string hex)
        {
            string tmp = hex.Replace("-", "");
            int length = tmp.Length;
            if (length % 2 == 1)
            {
                tmp = "0" + tmp;
                length++;
            }

            int halfLength = length / 2;
            byte[] bs = new byte[halfLength];

            for (int i = 0; i != halfLength; i++)
            {
                bs[i] = (byte)Int32.Parse(tmp.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            return bs;
        }

        private double CalculateEntropy(byte[] arr)
        {
            double entropy = 0.0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    entropy += -((double)arr[i] / (double)arr.Length) * Math.Log((double)arr[i] / (double)arr.Length, 2.0);
                }
            }
            return entropy;
        }

        string StringHEX(byte[] randomArr)
        {
            string hexText = BitConverter.ToString(randomArr);
            return hexText;
        }

        private byte[] MyEncoding(string inStr)
        {
            byte[] result = { 0 };
            if (aesRadioButton.Checked == true)
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = this.key;
                    if (generateVectorCheckBox.Checked)
                    {
                        try
                        {
                            aes.IV = this.key;
                        }
                        catch (Exception)
                        {
                            aes.IV = (byte[])this.key.Take(this.key.Length / 2);
                        }
                    }
                    else
                    {
                        aes.IV = this.iv;
                    }
                    result = Encryption.encryptAes(inStr, aes.Key, aes.IV);
                }
            }
            if (rijndaelRadioButton.Checked == true)
            {
                using (Rijndael rijndael = Rijndael.Create())
                {
                    rijndael.Key = this.key;
                    if (generateVectorCheckBox.Checked)
                    {
                        rijndael.IV = this.key;
                    }
                    else
                    {
                        rijndael.IV = this.iv;
                    }
                    result = Encryption.encryptRijndael(inStr, rijndael.Key, rijndael.IV);
                }
            }
            if (desRadioButton.Checked == true)
            {
                using (DES des = DES.Create())
                {
                    des.Key = this.key;
                    if (generateVectorCheckBox.Checked)
                    {
                        des.IV = this.key;
                    }
                    else
                    {
                        des.IV = this.iv;
                    }
                    result = Encryption.encryptDES(inStr, des.Key, des.IV);
                }
            }
            if (trDESRadioButton.Checked == true)
            {
                using (TripleDES trDES = TripleDES.Create())
                {
                    trDES.Key = this.key;
                    if (generateVectorCheckBox.Checked)
                    {
                        try
                        {
                            trDES.IV = this.key;
                        }
                        catch (Exception)
                        {
                            trDES.IV = this.key.Take(this.key.Length / 2).ToArray();
                        }
                    }
                    else
                    {
                        trDES.IV = this.iv;
                    }
                    result = Encryption.encryptTrDES(inStr, trDES.Key, trDES.IV);
                }
            }
            if (rc2RadioButton.Checked == true)
            {
                using (RC2 rc2 = RC2.Create())
                {
                    rc2.Key = this.key;
                    if (generateVectorCheckBox.Checked)
                    {
                        try
                        {
                            rc2.IV = this.key;
                        }
                        catch (Exception)
                        {
                            rc2.IV = this.key.Take(5).Union(this.key.Take(3)).ToArray();
                        }
                    }
                    else
                    {
                        rc2.IV = this.iv;
                    }
                    result = Encryption.encryptRC2(inStr, rc2.Key, rc2.IV);
                }
            }
            return result;
        }

        private string MyDecoding(byte[] arr)
        {

            string result = "";
            if (aesRadioButton.Checked == true)
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = this.key;
                    if (generateVectorCheckBox.Checked)
                    {
                        aes.IV = this.key;
                    }
                    else
                    {
                        aes.IV = this.iv;
                    }

                    result = Encryption.decryptAes(arr, aes.Key, aes.IV);
                }
            }
            if (rijndaelRadioButton.Checked == true)
            {
                using (Rijndael rijndael = Rijndael.Create())
                {
                    rijndael.Key = this.key;
                    if (generateVectorCheckBox.Checked)
                    {
                        rijndael.IV = this.key;
                    }
                    else
                    {
                        rijndael.IV = this.iv;
                    }

                    result = Encryption.decryptRijndael(arr, rijndael.Key, rijndael.IV);
                }
            }
            if (desRadioButton.Checked == true)
            {
                using (DES des = DES.Create())
                {
                    des.Key = this.key;
                    if (generateVectorCheckBox.Checked)
                    {
                        des.IV = this.key;
                    }
                    else
                    {
                        des.IV = this.iv;
                    }

                    result = Encryption.decryptDES(arr, des.Key, des.IV);
                }
            }
            if (trDESRadioButton.Checked == true)
            {
                using (TripleDES trDES = TripleDES.Create())
                {
                    trDES.Key = this.key;
                    if (generateVectorCheckBox.Checked)
                    {
                        trDES.IV = this.key;
                    }
                    else
                    {
                        trDES.IV = this.iv;
                    }

                    result = Encryption.decrypTrDES(arr, trDES.Key, trDES.IV);
                }
            }
            if (rc2RadioButton.Checked == true)
            {
                using (RC2 rc2 = RC2.Create())
                {
                    rc2.Key = this.key;
                    if (generateVectorCheckBox.Checked)
                    {
                        rc2.IV = this.key;
                    }
                    else
                    {
                        rc2.IV = this.iv;
                    }

                    result = Encryption.decryptRC2(arr, rc2.Key, rc2.IV);
                }
            }
            return result;
        }

        RadioButton lRadioButton = null;
        RadioButton cRadioButton = null;
    }
}
