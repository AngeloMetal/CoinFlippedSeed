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

namespace CoinFlippedSeed
{
    public partial class Form1 : Form
    {
        public string bins = "";
        public int times = 0;
      
        public Form1()
        {
            InitializeComponent();
            the_one.Width = 0;
            the_two.Width = 0;
            the_three.Width = 0;
            the_four.Width = 0;
            the_five.Width = 0;
            the_six.Width = 0;
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
            for (int i = 0; i < 20; i++)
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
                Finalize(bins);
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
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            if(bins.Length >= 128)
            {
                Finalize(bins);
            }
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            if (bins.Length == 128)
            {
                Finalize(bins);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            if (bins.Length == 128)
            {
                Finalize(bins);
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
            if (heads.Width != 0)
            {
                button2.Text = "Coin";
                heads.Width = 0;
                tails.Width = 0;
                the_one.Width = 43;
                the_two.Width = 43;
                the_three.Width = 43;
                the_four.Width = 43;
                the_five.Width = 43;
                the_six.Width = 43;
                header.Text = "No random number generators.\nJust roll a dice.\nThis will be your entropy.\n1 = 01\n2 = 10\n3 = 11\n4 = 0\n5 = 1\n6 = 00";
            }
            else
            {
                button2.Text = "Dice";
                heads.Width = 80;
                tails.Width = 80;
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
    }
}
