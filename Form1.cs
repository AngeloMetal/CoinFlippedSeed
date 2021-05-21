using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NBitcoin;
using Autarkysoft.Bitcoin.Cryptography;
using Autarkysoft.Bitcoin.Cryptography.Hashing;
using Autarkysoft.Bitcoin.Cryptography.KeyDerivationFunctions;

namespace CoinFlippedSeed
{
    public partial class Form1 : Form
    {
        public string bins = "";
        public int times = 0;
        public string c1 = "blue";
        public string c2 = "blue";
        public string c3 = "blue";
        public string c4 = "blue";
        public string c5 = "blue";
        public string c6 = "blue";
        public string c7 = "blue";
        public string c8 = "blue";
        public string c9 = "blue";

        public int bitsFromThisSide = 0;

        public string[] cubeBins = {"blue", "00", "white", "01", "yellow", "10", "red", "11", "orange", "0", "green", "1"}; 

        public Form1()
        {
            InitializeComponent();
            the_one.Width = 0;
            the_two.Width = 0;
            the_three.Width = 0;
            the_four.Width = 0;
            the_five.Width = 0;
            the_six.Width = 0;

            cube1.Width = 0;
            cube2_.Width = 0;
            cube3.Width = 0;
            cube4.Width = 0;
            cube5.Width = 0;
            cube6.Width = 0;
            cube7.Width = 0;
            cube8.Width = 0;
            cube9.Width = 0;
            button16.Width = 0;
        }


        private void heads_Click(object sender, EventArgs e)
        {
            Check("heads");

        }

        private void tails_Click(object sender, EventArgs e)
        {
            Check("tails");
        }

        public void Check(string t)
        {
            if(t == "heads")
            {
                bins += "1";
            }else if(t == "tails")
            {
                bins += "0";
            }

            if(checkBox2.Checked == true)
            {
                label3.Text = "Entropy: " + bins;
            }

            times += 1;
            timesLabel.Text = times + "/128 bits";

            if(bins.Length == 128)
            {
                heads.Enabled = false;
                tails.Enabled = false;
                Finalize(bins);
            }
        }

        public void CheckForDice(string t)
        {
            bins += t;

            if (checkBox2.Checked == true)
            {
                label3.Text = "Entropy: " + bins;
            }

            timesLabel.Text = bins.Length + "/128 bits";

            if (bins.Length >= 128)
            {
                the_one.Enabled = false;
                the_two.Enabled = false;
                the_three.Enabled = false;
                the_four.Enabled = false;
                the_five.Enabled = false;
                the_six.Enabled = false;
                timesLabel.Text = "128/128 bits";
                if(checkBox2.Checked == true)
                {
                    label3.Text = "Entropy: " + bins.Substring(0, 128);
                }
                else
                {
                    label3.Text = "";
                }
                
                
                Finalize(bins.Substring(0, 128));
            }

        }

        public void Finalize(string input)
        {
            int numOfBytes = input.Length / 8;
            byte[] bytes = new byte[numOfBytes];
            for (int i = 0; i < numOfBytes; ++i)
            {
                bytes[i] = Convert.ToByte(input.Substring(8 * i, 8), 2);
            }
            Mnemonic mnem = new Mnemonic(Wordlist.English, bytes);
            
            textBox1.Text = mnem.ToString();
            ExtKey hdroot = mnem.DeriveExtKey();
            int addressType = 0;
            ScriptPubKeyType typeofAddress = ScriptPubKeyType.Segwit;
            if (radioButton1.Checked == true)
            {
                addressType = 44;
                typeofAddress = ScriptPubKeyType.Legacy;
            }
            else if(radioButton2.Checked == true)
            {
                addressType = 49;
                typeofAddress = ScriptPubKeyType.SegwitP2SH;
            }
            else if(radioButton3.Checked == true)
            {
                addressType = 84;
            }
            for (int i = 0; i < numericUpDown.Value; i++)
            {
                
                var pKey = hdroot.Derive(new KeyPath("m/" + addressType + "'/0'/0'/0/" + i));
                var address = pKey.PrivateKey.PubKey.GetAddress(typeofAddress, Network.Main);
                if(checkBox1.Checked == false)
                {
                    richTextBox1.Text += address.ToString() + "\n";
                }
                else
                {
                    richTextBox1.Text += address.ToString() + "," + pKey.PrivateKey.GetWif(Network.Main) + "\n";
                }
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //on change "Show private keys"
            richTextBox1.Text = "";
            if (bins.Length >= 128)
            {
                Finalize(bins.Substring(0, 128));
            }
           
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //on change "Show entropy"
            if(checkBox2.Checked == false)
            {
                label3.Text = "";
            }
            else
            {
                label3.Text = "Entropy: " + bins;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            heads.Enabled = true;
            tails.Enabled = true;
            the_one.Enabled = true;
            the_two.Enabled = true;
            the_three.Enabled = true;
            the_four.Enabled = true;
            the_five.Enabled = true;
            the_six.Enabled = true;
            textBox1.Text = "";
            richTextBox1.Text = "";
            bins = "";
            timesLabel.Text = "0/128 bits";
            label3.Text = "Entropy: ";
            times = 0;
            bitsFromThisSide = 0;

            cube1.Enabled = true;
            cube2_.Enabled = true;
            cube3.Enabled = true;
            cube4.Enabled = true;
            cube5.Enabled = true;
            cube6.Enabled = true;
            cube7.Enabled = true;
            cube8.Enabled = true;
            cube9.Enabled = true;
            button16.Enabled = true;

            this.cube1.BackgroundImage = CoinFlippedSeed.Properties.Resources.blue;
            this.cube2_.BackgroundImage = CoinFlippedSeed.Properties.Resources.blue;
            this.cube3.BackgroundImage = CoinFlippedSeed.Properties.Resources.blue;
            this.cube4.BackgroundImage = CoinFlippedSeed.Properties.Resources.blue;
            this.cube5.BackgroundImage = CoinFlippedSeed.Properties.Resources.blue;
            this.cube6.BackgroundImage = CoinFlippedSeed.Properties.Resources.blue;
            this.cube7.BackgroundImage = CoinFlippedSeed.Properties.Resources.blue;
            this.cube8.BackgroundImage = CoinFlippedSeed.Properties.Resources.blue;
            this.cube9.BackgroundImage = CoinFlippedSeed.Properties.Resources.blue;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            if(bins.Length >= 128)
            {
                Finalize(bins.Substring(0, 128));
            }
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            if (bins.Length == 128)
            {
                Finalize(bins.Substring(0, 128));
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            if (bins.Length == 128)
            {
                Finalize(bins.Substring(0, 128));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            heads.Enabled = true;
            tails.Enabled = true;
            the_one.Enabled = true;
            the_two.Enabled = true;
            the_three.Enabled = true;
            the_four.Enabled = true;
            the_five.Enabled = true;
            the_six.Enabled = true;

            //if its coin
            if (heads.Width != 0)
            {
                button2.Text = "Cube";
                heads.Width = 0;
                tails.Width = 0;
                the_one.Width = 43;
                the_two.Width = 43;
                the_three.Width = 43;
                the_four.Width = 43;
                the_five.Width = 43;
                the_six.Width = 43;
                header.Text = "No random number generators.\nJust roll a dice.\nThis will be your entropy.\n1 = 01\n2 = 10\n3 = 11\n4 = 0\n5 = 1\n6 = 00";
            }//if its dice
            else if(the_one.Width != 0)
            {
                heads.Width = 0;
                tails.Width = 0;
                cube1.Width = 43;
                cube2_.Width = 43;
                cube3.Width = 43;
                cube4.Width = 43;
                cube5.Width = 43;
                cube6.Width = 43;
                cube7.Width = 43;
                cube8.Width = 43;
                cube9.Width = 43;
                button16.Width = 80;

                button2.Text = "Coin";
                header.Text = "No random number generators.\nJust mix a rubik's cube.\nThis will be your entropy.\nBlue = 00\nWhite = 01\nYellow = 10\nRed = 11\nOrange = 0\nGreen = 1";
                the_one.Width = 0;
                the_two.Width = 0;
                the_three.Width = 0;
                the_four.Width = 0;
                the_five.Width = 0;
                the_six.Width = 0;
            }//if its cube
            else
            {
                heads.Width = 80;
                tails.Width = 80;

                button2.Text = "Dice";

                cube1.Width = 0;
                cube2_.Width = 0;
                cube3.Width = 0;
                cube4.Width = 0;
                cube5.Width = 0;
                cube6.Width = 0;
                cube7.Width = 0;
                cube8.Width = 0;
                cube9.Width = 0;
                button16.Width = 0;

                the_one.Width = 0;
                the_two.Width = 0;
                the_three.Width = 0;
                the_four.Width = 0;
                the_five.Width = 0;
                the_six.Width = 0;
                header.Text = "No random number generators.\nJust flip a coin 128 times.\nThis will be your entropy.\nHeads = 1\nTails = 0";


            }

            textBox1.Text = "";
            richTextBox1.Text = "";
            bins = "";
            timesLabel.Text = "0/128 bits";
            if(checkBox2.Checked == true)
            {
                label3.Text = "Entropy: ";
            }
            else
            {
                label3.Text = "";
            }
            
            times = 0;


        }

        private void the_one_Click(object sender, EventArgs e)
        {
            CheckForDice("01");
        }

        private void the_two_Click(object sender, EventArgs e)
        {
            CheckForDice("10");
        }

        private void the_three_Click(object sender, EventArgs e)
        {
            CheckForDice("11");
        }

        private void the_four_Click(object sender, EventArgs e)
        {
            CheckForDice("0");
        }

        private void the_five_Click(object sender, EventArgs e)
        {
            CheckForDice("1");
        }

        private void the_six_Click(object sender, EventArgs e)
        {
            CheckForDice("00");
        }

        private void cube1_Click(object sender, EventArgs e)
        {
            if(c1 == "blue")
            {
                this.cube1.BackgroundImage = CoinFlippedSeed.Properties.Resources.white;
                c1 = "white";
            }
            else if(c1 == "white")
            {
                this.cube1.BackgroundImage = CoinFlippedSeed.Properties.Resources.yellow;
                c1 = "yellow";
            }
            else if (c1 == "yellow")
            {
                this.cube1.BackgroundImage = CoinFlippedSeed.Properties.Resources.red;
                c1 = "red";
            }
            else if (c1 == "red")
            {
                this.cube1.BackgroundImage = CoinFlippedSeed.Properties.Resources.orange;
                c1 = "orange";
            }
            else if (c1 == "orange")
            {
                this.cube1.BackgroundImage = CoinFlippedSeed.Properties.Resources.green;
                c1 = "green";
            }
            else if (c1 == "green")
            {
                this.cube1.BackgroundImage = CoinFlippedSeed.Properties.Resources.blue;
                c1 = "blue";
            }
        }

        private void cube2__Click(object sender, EventArgs e)
        {
            if (c2 == "blue")
            {
                this.cube2_.BackgroundImage = CoinFlippedSeed.Properties.Resources.white;
                c2 = "white";
            }
            else if (c2 == "white")
            {
                this.cube2_.BackgroundImage = CoinFlippedSeed.Properties.Resources.yellow;
                c2 = "yellow";
            }
            else if (c2 == "yellow")
            {
                this.cube2_.BackgroundImage = CoinFlippedSeed.Properties.Resources.red;
                c2 = "red";
            }
            else if (c2 == "red")
            {
                this.cube2_.BackgroundImage = CoinFlippedSeed.Properties.Resources.orange;
                c2 = "orange";
            }
            else if (c2 == "orange")
            {
                this.cube2_.BackgroundImage = CoinFlippedSeed.Properties.Resources.green;
                c2 = "green";
            }
            else if (c2 == "green")
            {
                this.cube2_.BackgroundImage = CoinFlippedSeed.Properties.Resources.blue;
                c2 = "blue";
            }
        }

        private void cube3_Click(object sender, EventArgs e)
        {
            if (c3 == "blue")
            {
                this.cube3.BackgroundImage = CoinFlippedSeed.Properties.Resources.white;
                c3 = "white";
            }
            else if (c3 == "white")
            {
                this.cube3.BackgroundImage = CoinFlippedSeed.Properties.Resources.yellow;
                c3 = "yellow";
            }
            else if (c3 == "yellow")
            {
                this.cube3.BackgroundImage = CoinFlippedSeed.Properties.Resources.red;
                c3 = "red";
            }
            else if (c3 == "red")
            {
                this.cube3.BackgroundImage = CoinFlippedSeed.Properties.Resources.orange;
                c3 = "orange";
            }
            else if (c3 == "orange")
            {
                this.cube3.BackgroundImage = CoinFlippedSeed.Properties.Resources.green;
                c3 = "green";
            }
            else if (c3 == "green")
            {
                this.cube3.BackgroundImage = CoinFlippedSeed.Properties.Resources.blue;
                c3 = "blue";
            }
        }

        private void cube4_Click(object sender, EventArgs e)
        {
            if (c4 == "blue")
            {
                this.cube4.BackgroundImage = CoinFlippedSeed.Properties.Resources.white;
                c4 = "white";
            }
            else if (c4 == "white")
            {
                this.cube4.BackgroundImage = CoinFlippedSeed.Properties.Resources.yellow;
                c4 = "yellow";
            }
            else if (c4 == "yellow")
            {
                this.cube4.BackgroundImage = CoinFlippedSeed.Properties.Resources.red;
                c4 = "red";
            }
            else if (c4 == "red")
            {
                this.cube4.BackgroundImage = CoinFlippedSeed.Properties.Resources.orange;
                c4 = "orange";
            }
            else if (c4 == "orange")
            {
                this.cube4.BackgroundImage = CoinFlippedSeed.Properties.Resources.green;
                c4 = "green";
            }
            else if (c4 == "green")
            {
                this.cube4.BackgroundImage = CoinFlippedSeed.Properties.Resources.blue;
                c4 = "blue";
            }
        }

        private void cube5_Click(object sender, EventArgs e)
        {
            if (c5 == "blue")
            {
                this.cube5.BackgroundImage = CoinFlippedSeed.Properties.Resources.white;
                c5 = "white";
            }
            else if (c5 == "white")
            {
                this.cube5.BackgroundImage = CoinFlippedSeed.Properties.Resources.yellow;
                c5 = "yellow";
            }
            else if (c5 == "yellow")
            {
                this.cube5.BackgroundImage = CoinFlippedSeed.Properties.Resources.red;
                c5 = "red";
            }
            else if (c5 == "red")
            {
                this.cube5.BackgroundImage = CoinFlippedSeed.Properties.Resources.orange;
                c5 = "orange";
            }
            else if (c5 == "orange")
            {
                this.cube5.BackgroundImage = CoinFlippedSeed.Properties.Resources.green;
                c5 = "green";
            }
            else if (c5 == "green")
            {
                this.cube5.BackgroundImage = CoinFlippedSeed.Properties.Resources.blue;
                c5 = "blue";
            }
        }

        private void cube6_Click(object sender, EventArgs e)
        {
            if (c6 == "blue")
            {
                this.cube6.BackgroundImage = CoinFlippedSeed.Properties.Resources.white;
                c6 = "white";
            }
            else if (c6 == "white")
            {
                this.cube6.BackgroundImage = CoinFlippedSeed.Properties.Resources.yellow;
                c6 = "yellow";
            }
            else if (c6 == "yellow")
            {
                this.cube6.BackgroundImage = CoinFlippedSeed.Properties.Resources.red;
                c6 = "red";
            }
            else if (c6 == "red")
            {
                this.cube6.BackgroundImage = CoinFlippedSeed.Properties.Resources.orange;
                c6 = "orange";
            }
            else if (c6 == "orange")
            {
                this.cube6.BackgroundImage = CoinFlippedSeed.Properties.Resources.green;
                c6 = "green";
            }
            else if (c6 == "green")
            {
                this.cube6.BackgroundImage = CoinFlippedSeed.Properties.Resources.blue;
                c6 = "blue";
            }
        }

        private void cube7_Click(object sender, EventArgs e)
        {
            if (c7 == "blue")
            {
                this.cube7.BackgroundImage = CoinFlippedSeed.Properties.Resources.white;
                c7 = "white";
            }
            else if (c7 == "white")
            {
                this.cube7.BackgroundImage = CoinFlippedSeed.Properties.Resources.yellow;
                c7 = "yellow";
            }
            else if (c7 == "yellow")
            {
                this.cube7.BackgroundImage = CoinFlippedSeed.Properties.Resources.red;
                c7 = "red";
            }
            else if (c7 == "red")
            {
                this.cube7.BackgroundImage = CoinFlippedSeed.Properties.Resources.orange;
                c7 = "orange";
            }
            else if (c7 == "orange")
            {
                this.cube7.BackgroundImage = CoinFlippedSeed.Properties.Resources.green;
                c7 = "green";
            }
            else if (c7 == "green")
            {
                this.cube7.BackgroundImage = CoinFlippedSeed.Properties.Resources.blue;
                c7 = "blue";
            }
        }

        private void cube8_Click(object sender, EventArgs e)
        {
            if (c8 == "blue")
            {
                this.cube8.BackgroundImage = CoinFlippedSeed.Properties.Resources.white;
                c8 = "white";
            }
            else if (c8 == "white")
            {
                this.cube8.BackgroundImage = CoinFlippedSeed.Properties.Resources.yellow;
                c8 = "yellow";
            }
            else if (c8 == "yellow")
            {
                this.cube8.BackgroundImage = CoinFlippedSeed.Properties.Resources.red;
                c8 = "red";
            }
            else if (c8 == "red")
            {
                this.cube8.BackgroundImage = CoinFlippedSeed.Properties.Resources.orange;
                c8 = "orange";
            }
            else if (c8 == "orange")
            {
                this.cube8.BackgroundImage = CoinFlippedSeed.Properties.Resources.green;
                c8 = "green";
            }
            else if (c8 == "green")
            {
                this.cube8.BackgroundImage = CoinFlippedSeed.Properties.Resources.blue;
                c8 = "blue";
            }
        }

        private void cube9_Click(object sender, EventArgs e)
        {
            if (c9 == "blue")
            {
                this.cube9.BackgroundImage = CoinFlippedSeed.Properties.Resources.white;
                c9 = "white";
            }
            else if (c9 == "white")
            {
                this.cube9.BackgroundImage = CoinFlippedSeed.Properties.Resources.yellow;
                c9 = "yellow";
            }
            else if (c9 == "yellow")
            {
                this.cube9.BackgroundImage = CoinFlippedSeed.Properties.Resources.red;
                c9 = "red";
            }
            else if (c9 == "red")
            {
                this.cube9.BackgroundImage = CoinFlippedSeed.Properties.Resources.orange;
                c9 = "orange";
            }
            else if (c9 == "orange")
            {
                this.cube9.BackgroundImage = CoinFlippedSeed.Properties.Resources.green;
                c9 = "green";
            }
            else if (c9 == "green")
            {
                this.cube9.BackgroundImage = CoinFlippedSeed.Properties.Resources.blue;
                c9 = "blue";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            for(int i = 0; i < 12; i++)
            {
                if(cubeBins[i] == c1)
                {
                    bins += cubeBins[i + 1];
                    bitsFromThisSide += cubeBins[i + 1].Length;
                }
            }

            for (int i = 0; i < 12; i++)
            {
                if (cubeBins[i] == c2)
                {
                    bins += cubeBins[i + 1];
                    bitsFromThisSide += cubeBins[i + 1].Length;
                }
            }

            for (int i = 0; i < 12; i++)
            {
                if (cubeBins[i] == c3)
                {
                    bins += cubeBins[i + 1];
                    bitsFromThisSide += cubeBins[i + 1].Length;
                }
            }

            for (int i = 0; i < 12; i++)
            {
                if (cubeBins[i] == c4)
                {
                    bins += cubeBins[i + 1];
                    bitsFromThisSide += cubeBins[i + 1].Length;
                }
            }

            for (int i = 0; i < 12; i++)
            {
                if (cubeBins[i] == c5)
                {
                    bins += cubeBins[i + 1];
                    bitsFromThisSide += cubeBins[i + 1].Length;
                }
            }

            for (int i = 0; i < 12; i++)
            {
                if (cubeBins[i] == c6)
                {
                    bins += cubeBins[i + 1];
                    bitsFromThisSide += cubeBins[i + 1].Length;
                }
            }

            for (int i = 0; i < 12; i++)
            {
                if (cubeBins[i] == c7)
                {
                    bins += cubeBins[i + 1];
                    bitsFromThisSide += cubeBins[i + 1].Length;
                }
            }

            for (int i = 0; i < 12; i++)
            {
                if (cubeBins[i] == c8)
                {
                    bins += cubeBins[i + 1];
                    bitsFromThisSide += cubeBins[i + 1].Length;
                }
            }

            for (int i = 0; i < 12; i++)
            {
                if (cubeBins[i] == c9)
                {
                    bins += cubeBins[i + 1];
                    bitsFromThisSide += cubeBins[i + 1].Length;
                }
            }

            if (checkBox2.Checked == true)
            {
                label3.Text = "Entropy: " + bins;
            }
            
            timesLabel.Text = bitsFromThisSide + "/128 bits";
            if (bins.Length >= 128)
            {
                cube1.Enabled = false;
                cube2_.Enabled = false;
                cube3.Enabled = false;
                cube4.Enabled = false;
                cube5.Enabled = false;
                cube6.Enabled = false;
                cube7.Enabled = false;
                cube8.Enabled = false;
                cube9.Enabled = false;
                button16.Enabled = false;
                timesLabel.Text = "128/128 bits";
                if (checkBox2.Checked == true)
                {
                    label3.Text = "Entropy: " + bins.Substring(0, 128);
                }
                Finalize(bins.Substring(0, 128));
            }
        }
    }
}
