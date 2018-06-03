using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Text.RegularExpressions;
using System.Threading;


namespace Forms_Example
{
    public partial class Form2 : Form
    {
        private static string ANote = "C.WAV";
        private static string TNote = "D.WAV";
        private static string GNote = "E.WAV";
        private static string CNote = "F.WAV";
        public Form2()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Audio Files (.wav)|*.wav";


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                playsound(path, 250);
            }

        }



        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = @"H:\HINDI songs\raavan02(www.songs.pk) - Copy.mp3";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            StringToMusic(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
           // axWindowsMediaPlayer1.URL = @"H:\HINDI songs\raavan02(www.songs.pk) - Copy.mp3";
        }
        private void StringToMusic(string StringToConvert)
        {
            string words = StringToConvert.ToUpper();
            for (int i = 0; i < words.Length; i = i + 1)
            {
                if (words[i] == 'A')
                {
                    selectNote(i, textBox1);
                    playsound(ANote, 1100);
                }
                else if (words[i] == 'T')
                {
                    selectNote(i, textBox1);
                    playsound(TNote, 1100);

                }
                else if (words[i] == 'G')
                {
                    selectNote(i, textBox1);
                    playsound(GNote, 1100);

                }
                else if (words[i] == 'C')
                {
                    selectNote(i, textBox1);
                    playsound(CNote, 1100);
                }
            }
        }
        private void selectNote(int CharPositionInTextBox, TextBox TextBoxName)
        {
            TextBoxName.Select();
            TextBoxName.Select(CharPositionInTextBox, 1);
        }
        private void playsound(string WavFileName, int RateOfPlayInMilliSeconds)
        {
            SoundPlayer sound = new SoundPlayer(WavFileName);
            sound.Play();
            Thread.Sleep(RateOfPlayInMilliSeconds);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(mp3,wav,mp4,mov,wmv,mpg)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpg|all files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;

        }
    }
}