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
            timesLabel.Text = times + "/128";

            if(bins.Length == 128)
            {
                heads.Enabled = false;
                tails.Enabled = false;
                Finalize(bins);
            }
        }

        public void Finalize(string input)
        {
            //Finalize("01101101011100100001010101101000101010010100000010010001001001110000100111100010101000101010010101000000001010110110001001010011");
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
            if (bins.Length == 128)
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
            textBox1.Text = "";
            richTextBox1.Text = "";
            bins = "";
            timesLabel.Text = "0/128";
            label3.Text = "Entropy: ";
            times = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            if(bins.Length == 128)
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
    }
}
