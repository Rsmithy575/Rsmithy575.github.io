using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HANGMAN
{
    public partial class Form1 : Form
    {
        int wordnumber;
        string userinput;
        //create variable for all the characters
        string cr1 = "_", cr2 = "_", cr3 = "_", cr4 = "_", cr5 = "_", cr6 = "_", cr7 = "_", cr8 = "_", cr9 = "_", cr10 = "_", cr11 = "_", cr12 = "_", cr13 = "_", cr14 = "_";
        //create variable for a player word
        bool custom = false;
        string pr1 = "_", pr2 = "_", pr3 = "_", pr4 = "_", pr5 = "_", pr6 = "_", pr7 = "_", pr8 = "_", pr9 = "_", pr10 = "_";
        static string testing = "0";
        int wordcount;
        string customword;
        //declare player guesses until failure
        int lives = 8;
        //Create an array with words
        private string[] words = { "yes", "no", "die", "elephant", "cactus", "caligynephobia" };
        public Form1()
        {
            InitializeComponent();
            if (custom == false)
            {
                //pick a random word
                Random wordpick = new Random();
                wordnumber = wordpick.Next(1, words.Length);
                //display the "word"
                DisplayWord();
            }
            else
            {
                WordWriteCustom();
                wordnumber = 0;
            }
        }
        //create a void to display the "word"
        private void DisplayWord()
        {
            if (custom == false)
            {
                if (wordnumber == 1)
                {
                    label11.Text = cr1 + " " + cr2 + " " + cr3.ToString();

                }
                if (wordnumber == 2)
                {
                    label11.Text = cr1 + " " + cr2.ToString();
                }
                if (wordnumber == 3)
                {
                    label11.Text = cr1 + " " + cr2 + " " + cr3.ToString();
                }
                if (wordnumber == 4)
                {
                    label11.Text = cr1 + " " + cr2 + " " + cr3 + " " + cr4 + " " + cr5 + " " + cr6 + " " + cr7 + " " + cr8.ToString();
                }
                if (wordnumber == 5)
                {
                    label11.Text = cr1 + " " + cr2 + " " + cr3 + " " + cr4 + " " + cr5 + " " + cr6.ToString();
                }
                if (wordnumber == 6)
                {
                    label11.Text = cr1 + " " + cr2 + " " + cr3 + " " + cr4 + " " + cr5 + " " + cr6 + " " + cr7 + " " + cr8 + " " + cr9 + " " + cr10 + " " + cr11 + " " + cr12 + " " + cr13 + " " + cr14.ToString();
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //put the user input in a variable
            userinput = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //when clicking the button check if the userinput is correct or incorrect
            if (wordnumber == 1)
            {
                //if the userinput is correct set the letter into the "word"
                if (userinput == "y")
                    cr1 = "y";
                else if (userinput == "e")
                    cr2 = "e";
                else if (userinput == "s")
                    cr3 = "s";
                else if (userinput == "yes")
                {
                    MessageBox.Show("YOU WIN");
                    Close();
                }
                else
                    //if the userinput is incorrect decrease lives by 1
                    lives--;
                //display the "word"
                LetterShow();
                DisplayWord();
                //if every letter is guessed correctly send a message to say you win
                if (cr1 == "y" && cr2 == "e" && cr3 == "s")
                {
                    MessageBox.Show("YOU WIN");
                    Close();
                }
            }
            if (wordnumber == 2)
            {
                //if the userinput is correct set the letter into the "word"
                if (userinput == "n")
                    cr1 = "n";
                else if (userinput == "o")
                    cr2 = "o";
                else if (userinput == "no")
                {
                    MessageBox.Show("YOU WIN");
                    Close();
                }
                else
                    //if the userinput is incorrect decrease lives by 1
                    lives--;
                //display the "word"
                LetterShow();
                DisplayWord();
                //if every letter is guessed correctly send a message to say you win
                if (cr1 == "n" && cr2 == "o")
                {
                    MessageBox.Show("YOU WIN");
                    Close();
                }
            }
            if (wordnumber == 3)
            {
                //if the userinput is correct set the letter into the "word"
                if (userinput == "d")
                    cr1 = "d";
                else if (userinput == "i")
                    cr2 = "i";
                else if (userinput == "e")
                    cr3 = "e";
                else if (userinput == "die")
                {
                    MessageBox.Show("YOU WIN");
                    Close();
                }
                else
                    //if the userinput is incorrect decrease lives by 1
                    lives--;
                //display the "word"
                LetterShow();
                DisplayWord();
                //if every letter is guessed correctly send a message to say you win
                if (cr1 == "d" && cr2 == "i" && cr3 == "e")
                {
                    MessageBox.Show("YOU WIN");
                    Close();
                }
            }
            if (wordnumber == 4)
            {
                //if the userinput is correct set the letter into the "word"
                if (userinput == "e")
                {
                    cr1 = "e";
                    cr3 = "e";
                }
                else if (userinput == "l")
                    cr2 = "l";
                else if (userinput == "p")
                    cr4 = "p";
                else if (userinput == "h")
                    cr5 = "h";
                else if (userinput == "a")
                    cr6 = "a";
                else if (userinput == "n")
                    cr7 = "n";
                else if (userinput == "t")
                    cr8 = "t";
                else if (userinput == "elephant")
                {
                    MessageBox.Show("YOU WIN");
                    Close();
                }
                else
                    //if the userinput is incorrect decrease lives by 1
                    lives--;

                //display the "word"
                LetterShow();
                DisplayWord();
                //if every letter is guessed correctly send a message to say you win
                if (cr1 == "e" && cr2 == "l" && cr3 == "e" && cr4 == "p" && cr5 == "h" && cr6 == "a" && cr7 == "n" && cr8 == "t")
                {
                    MessageBox.Show("YOU WIN");
                    Close();
                }
            }
            if (wordnumber == 5)
            {
                //if the userinput is correct set the letter into the "word"
                if (userinput == "c")
                {
                    cr1 = "c";
                    cr3 = "c";
                }
                else if (userinput == "a")
                    cr2 = "a";
                else if (userinput == "t")
                    cr4 = "t";
                else if (userinput == "u")
                    cr5 = "u";
                else if (userinput == "s")
                    cr6 = "s";
                else if (userinput == "cactus")
                {
                    MessageBox.Show("YOU WIN");
                    Close();
                }
                else
                    //if the userinput is incorrect decrease lives by 1
                    lives--;
                //display the "word"
                LetterShow();
                DisplayWord();
                //if every letter is guessed correctly send a message to say you win
                if (cr1 == "c" && cr2 == "a" && cr3 == "c" && cr4 == "t" && cr5 == "u" && cr6 == "s")
                {
                    MessageBox.Show("YOU WIN");
                    Close();
                }
            }
            if (wordnumber == 6)
            {
                //if the userinput is correct set the letter into the "word"
                if (userinput == "c")
                    cr1 = "c";
                else if (userinput == "a")
                {
                    cr2 = "a";
                    cr14 = "a";
                }
                else if (userinput == "l")
                    cr3 = "l";
                else if (userinput == "i")
                {
                    cr4 = "i";
                    cr13 = "i";
                }
                else if (userinput == "g")
                    cr5 = "g";
                else if (userinput == "y")
                    cr6 = "y";
                else if (userinput == "n")
                    cr7 = "n";
                else if (userinput == "e")
                    cr8 = "e";
                else if (userinput == "p")
                    cr9 = "p";
                else if (userinput == "h")
                    cr10 = "h";
                else if (userinput == "o")
                    cr11 = "o";
                else if (userinput == "b")
                    cr12 = "b";
                else if (userinput == "caligynephobia")
                {
                    MessageBox.Show("YOU WIN");
                    Close();
                }
                else
                    //if the userinput is incorrect decrease lives by 1
                    lives--;
                //display the "word"
                LetterShow();
                DisplayWord();
                //if every letter is guessed correctly send a message to say you win
                if (cr1 == "c" && cr2 == "a" && cr3 == "l" && cr4 == "i" && cr5 == "g" && cr6 == "y" && cr7 == "n" && cr8 == "e" && cr9 == "p" && cr10 == "h" && cr11 == "o" && cr12 == "b" && cr13 == "i" && cr14 == "a")
                {
                    MessageBox.Show("YOU WIN");
                    Close();
                }
            }

            if (custom == true)
            {
                
                if (userinput == pr1) cr1 = pr1;
                if (userinput == pr2) cr2 = pr2;
                if (userinput == pr3) cr3 = pr3;
                if (userinput == pr4) cr4 = pr4;
                if (userinput == pr5) cr5 = pr5;
                if (userinput == pr6) cr6 = pr6;
                if (userinput == pr7) cr7 = pr7;
                if (userinput == pr8) cr8 = pr8;
                if (userinput == pr9) cr9 = pr9;
                if (userinput == pr10) cr10 = pr10;
                if (userinput != pr1 && userinput != pr2 && userinput != pr3 && userinput != pr4 && userinput != pr5 && userinput != pr6 && userinput != pr7 && userinput != pr8 && userinput != pr9 && userinput != pr10)
                    lives--;
                LetterShow();
                WordWriteCustom();
                if (cr1 == pr1 && cr2 == pr2 && cr3 == pr3 && cr4 == pr4 && cr5 == pr5 && cr6 == pr6 && cr7 == pr7 && cr8 == pr8 && cr9 == pr9 && cr10 == pr10)
                {
                    MessageBox.Show("YOU WIN");
                    Close();
                }
                



            }
            else
            {
                //if (userinput == pr1)
                //    cr1 = pr1;
                //if (userinput == pr2)
                //    cr2 = pr2;
                //if (userinput == pr3)
                //    cr3 = pr3;
                //if (userinput == pr4)
                //    cr4 = pr4;
                //if (userinput == pr5)
                //    cr5 = pr5;
                //if (userinput == pr6)
                //    cr6 = pr6;
                //if (userinput == pr7)
                //    cr7 = pr7;
                //if (userinput == pr8)
                //    cr8 = pr8;
                //if (userinput == pr9)
                //    cr9 = pr9;
                //if (userinput == pr10)
                //    cr10 = pr10;
                //if (userinput != pr1 && userinput != pr2 && userinput != pr3 && userinput != pr4 && userinput != pr5 && userinput != pr6 && userinput != pr7 && userinput != pr8 && userinput != pr9 && userinput != pr10)
                //    lives--;


                //display the "word"
                //LetterShow();
                //WordWriteCustom();
                //if every letter is guessed correctly send a message to say you win
                //if (cr1 == pr1 && cr2 == pr2 && cr3 == pr3 && cr4 == pr4 && cr5 == pr5 && cr6 == pr6 && cr7 == pr7 && cr8 == pr8 && cr9 == pr9 && cr10 == pr10)
                //{
                //    MessageBox.Show("YOU WIN");
                //    Close();
                //}
            }
            textBox1.Clear();
            //if the player runs out of lives then send a message to say you lose
            if (lives == 7)
                label30.Text = "|";
            if (lives == 6)
                label33.Text = "___";
            if (lives == 5)
                label39.Text = "|";
            if (lives == 4)
                label34.Text = "O";
            if (lives == 3)
                label35.Text = "I";
            if (lives == 2)
                label38.Text = "/";
            if (lives == 1)
                label37.Text = @"\";
            if (lives == 0)
                label36.Text = @"/\";
            if (lives == 0)
            { 
                MessageBox.Show("YOU LOSE");
                Close();
            }
        }

        private void LetterShow()
        {

            switch (userinput)
            {
                case "a": label1.Text = ""; break;
                case "b": label2.Text = ""; break;
                case "c": label3.Text = ""; break;
                case "d": label4.Text = ""; break;
                case "e": label5.Text = ""; break;
                case "f": label6.Text = ""; break;
                case "g": label13.Text = ""; break;
                case "h": label12.Text = ""; break;
                case "i": label10.Text = ""; break;
                case "j": label9.Text = ""; break;
                case "k": label8.Text = ""; break;
                case "l": label7.Text = ""; break;
                case "m": label25.Text = ""; break;
                case "n": label24.Text = ""; break;
                case "o": label23.Text = ""; break;
                case "p": label22.Text = ""; break;
                case "q": label21.Text = ""; break;
                case "r": label20.Text = ""; break;
                case "s": label19.Text = ""; break;
                case "t": label18.Text = ""; break;
                case "u": label17.Text = ""; break;
                case "v": label16.Text = ""; break;
                case "w": label15.Text = ""; break;
                case "x": label14.Text = ""; break;
                case "y": label27.Text = ""; break;
                case "z": label26.Text = ""; break;
                
            }


        }



        private void button2_Click(object sender, EventArgs e)
        {

            custom = true;
            wordnumber = 0;
            MessageBox.Show("Word Accepted");
            WordWriteCustom();
            label40.Text = "                                                                                      ";
            char[] characters = customword.ToCharArray();
            if (customword.Length ==1 || customword.Length > 1)
                pr1 = characters[0].ToString();
            if (customword.Length == 2 || customword.Length > 2)
                pr2 = characters[1].ToString();
            if (customword.Length == 3 || customword.Length > 3)
                pr3 = characters[2].ToString();
            if (customword.Length == 4 || customword.Length > 4)
                pr4 = characters[3].ToString();
            if (customword.Length == 5 || customword.Length > 5)
                pr5 = characters[4].ToString();
            if (customword.Length == 6 || customword.Length > 6)
                pr6 = characters[5].ToString();
            if (customword.Length == 7 || customword.Length > 7)
                pr7 = characters[6].ToString();
            if (customword.Length == 8 || customword.Length > 8)
                pr8 = characters[7].ToString();
            if (customword.Length == 9 || customword.Length > 9)
                pr9 = characters[8].ToString();
            if (customword.Length == 10 || customword.Length > 10)
                pr10 = characters[9].ToString();
            CustomWordBox.Hide();
        }
       

        private void WordWriteCustom()
        {
            switch (customword.Length)
            {
                case 1: label11.Text = $"{cr1}"; break;
                case 2: label11.Text = $"{cr1} {cr2}"; break;
                case 3: label11.Text = $"{cr1} {cr2} {cr3}"; break;
                case 4: label11.Text = $"{cr1} {cr2} {cr3} {cr4}"; break;
                case 5: label11.Text = $"{cr1} {cr2} {cr3} {cr4} {cr5}"; break;
                case 6: label11.Text = $"{cr1} {cr2} {cr3} {cr4} {cr5} {cr6}"; break;
                case 7: label11.Text = $"{cr1} {cr2} {cr3} {cr4} {cr5} {cr6} {cr7}"; break;
                case 8: label11.Text = $"{cr1} {cr2} {cr3} {cr4} {cr5} {cr6} {cr7} {cr8}"; break;
                case 9: label11.Text = $"{cr1} {cr2} {cr3} {cr4} {cr5} {cr6} {cr7} {cr8} {cr9}"; break;
                case 10: label11.Text = $"{cr1} {cr2} {cr3} {cr4} {cr5} {cr6} {cr7} {cr8} {cr9} {cr10}"; break;
                // Add more cases as needed
                default: label11.Text = ""; break; // Handle cases where customword.Length > 10 or < 1
            }

        }
        #region
        private void label40_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {
        }
        private void label39_Click(object sender, EventArgs e)
        {
        }
        private void label34_Click(object sender, EventArgs e)
        {
        }
        private void label35_Click(object sender, EventArgs e)
        {
        }
        private void label38_Click(object sender, EventArgs e)
        {
        }
        private void label37_Click(object sender, EventArgs e)
        {
        }
        private void label36_Click(object sender, EventArgs e)
        {
        }
        private void label30_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CustomWordBox_TextChanged(object sender, EventArgs e)
        {
            customword = CustomWordBox.Text;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
//private static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void bananaprivate static void banana