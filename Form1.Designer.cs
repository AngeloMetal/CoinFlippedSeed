
namespace CoinFlippedSeed
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.header = new System.Windows.Forms.Label();
            this.heads = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timesLabel = new System.Windows.Forms.Label();
            this.tails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.the_one = new System.Windows.Forms.Button();
            this.the_two = new System.Windows.Forms.Button();
            this.the_three = new System.Windows.Forms.Button();
            this.the_six = new System.Windows.Forms.Button();
            this.the_five = new System.Windows.Forms.Button();
            this.the_four = new System.Windows.Forms.Button();
            this.cube2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.cube3 = new System.Windows.Forms.Button();
            this.cube2_ = new System.Windows.Forms.Button();
            this.cube1 = new System.Windows.Forms.Button();
            this.cube6 = new System.Windows.Forms.Button();
            this.cube5 = new System.Windows.Forms.Button();
            this.cube4 = new System.Windows.Forms.Button();
            this.cube9 = new System.Windows.Forms.Button();
            this.cube8 = new System.Windows.Forms.Button();
            this.cube7 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(12, 43);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(175, 75);
            this.header.TabIndex = 0;
            this.header.Text = "No random number generators.\r\nJust flip a coin 128 times.\r\nThis will be your entr" +
    "opy.\r\nHeads = 1\r\nTails = 0";
            // 
            // heads
            // 
            this.heads.Location = new System.Drawing.Point(257, 57);
            this.heads.Name = "heads";
            this.heads.Size = new System.Drawing.Size(80, 33);
            this.heads.TabIndex = 1;
            this.heads.Text = "Heads";
            this.heads.UseVisualStyleBackColor = true;
            this.heads.Click += new System.EventHandler(this.heads_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 357);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(745, 122);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 290);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(745, 23);
            this.textBox1.TabIndex = 3;
            // 
            // timesLabel
            // 
            this.timesLabel.AutoSize = true;
            this.timesLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timesLabel.Location = new System.Drawing.Point(362, 23);
            this.timesLabel.Name = "timesLabel";
            this.timesLabel.Size = new System.Drawing.Size(101, 28);
            this.timesLabel.TabIndex = 4;
            this.timesLabel.Text = "0/128 bits";
            // 
            // tails
            // 
            this.tails.Location = new System.Drawing.Point(483, 57);
            this.tails.Name = "tails";
            this.tails.Size = new System.Drawing.Size(80, 33);
            this.tails.TabIndex = 5;
            this.tails.Text = "Tails";
            this.tails.UseVisualStyleBackColor = true;
            this.tails.Click += new System.EventHandler(this.tails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mnemonic:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Derived addresses:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(30, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 19);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Legacy";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(30, 76);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(100, 19);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "Nested Segwit";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(30, 51);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(97, 19);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.Text = "Native Segwit";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(629, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 233);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(97, 157);
            this.numericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(41, 23);
            this.numericUpDown.TabIndex = 19;
            this.numericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Addresses:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 25);
            this.button2.TabIndex = 14;
            this.button2.Text = "Dice";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 25);
            this.button1.TabIndex = 13;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(30, 127);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(99, 19);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Show entropy";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(30, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 19);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Show private keys";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 11);
            this.label3.TabIndex = 12;
            // 
            // the_one
            // 
            this.the_one.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.the_one.Location = new System.Drawing.Point(324, 73);
            this.the_one.Name = "the_one";
            this.the_one.Size = new System.Drawing.Size(43, 45);
            this.the_one.TabIndex = 13;
            this.the_one.Text = "1";
            this.the_one.UseVisualStyleBackColor = true;
            this.the_one.Click += new System.EventHandler(this.the_one_Click);
            // 
            // the_two
            // 
            this.the_two.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.the_two.Location = new System.Drawing.Point(386, 73);
            this.the_two.Name = "the_two";
            this.the_two.Size = new System.Drawing.Size(43, 45);
            this.the_two.TabIndex = 14;
            this.the_two.Text = "2";
            this.the_two.UseVisualStyleBackColor = true;
            this.the_two.Click += new System.EventHandler(this.the_two_Click);
            // 
            // the_three
            // 
            this.the_three.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.the_three.Location = new System.Drawing.Point(448, 73);
            this.the_three.Name = "the_three";
            this.the_three.Size = new System.Drawing.Size(43, 45);
            this.the_three.TabIndex = 15;
            this.the_three.Text = "3";
            this.the_three.UseVisualStyleBackColor = true;
            this.the_three.Click += new System.EventHandler(this.the_three_Click);
            // 
            // the_six
            // 
            this.the_six.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.the_six.Location = new System.Drawing.Point(448, 127);
            this.the_six.Name = "the_six";
            this.the_six.Size = new System.Drawing.Size(43, 45);
            this.the_six.TabIndex = 18;
            this.the_six.Text = "6";
            this.the_six.UseVisualStyleBackColor = true;
            this.the_six.Click += new System.EventHandler(this.the_six_Click);
            // 
            // the_five
            // 
            this.the_five.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.the_five.Location = new System.Drawing.Point(386, 127);
            this.the_five.Name = "the_five";
            this.the_five.Size = new System.Drawing.Size(43, 45);
            this.the_five.TabIndex = 17;
            this.the_five.Text = "5";
            this.the_five.UseVisualStyleBackColor = true;
            this.the_five.Click += new System.EventHandler(this.the_five_Click);
            // 
            // the_four
            // 
            this.the_four.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.the_four.Location = new System.Drawing.Point(324, 127);
            this.the_four.Name = "the_four";
            this.the_four.Size = new System.Drawing.Size(43, 45);
            this.the_four.TabIndex = 16;
            this.the_four.Text = "4";
            this.the_four.UseVisualStyleBackColor = true;
            this.the_four.Click += new System.EventHandler(this.the_four_Click);
            // 
            // cube2
            // 
            this.cube2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cube2.BackgroundImage")));
            this.cube2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cube2.Location = new System.Drawing.Point(386, 132);
            this.cube2.Name = "cube2";
            this.cube2.Size = new System.Drawing.Size(43, 45);
            this.cube2.TabIndex = 23;
            this.cube2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(470, 241);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 45);
            this.button5.TabIndex = 27;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(408, 241);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(43, 45);
            this.button6.TabIndex = 26;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(346, 241);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(43, 45);
            this.button7.TabIndex = 25;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // cube3
            // 
            this.cube3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cube3.BackgroundImage")));
            this.cube3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cube3.Location = new System.Drawing.Point(434, 73);
            this.cube3.Name = "cube3";
            this.cube3.Size = new System.Drawing.Size(43, 45);
            this.cube3.TabIndex = 27;
            this.cube3.UseVisualStyleBackColor = true;
            this.cube3.Click += new System.EventHandler(this.cube3_Click);
            // 
            // cube2_
            // 
            this.cube2_.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cube2_.BackgroundImage")));
            this.cube2_.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cube2_.Location = new System.Drawing.Point(387, 73);
            this.cube2_.Name = "cube2_";
            this.cube2_.Size = new System.Drawing.Size(43, 45);
            this.cube2_.TabIndex = 26;
            this.cube2_.UseVisualStyleBackColor = true;
            this.cube2_.Click += new System.EventHandler(this.cube2__Click);
            // 
            // cube1
            // 
            this.cube1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cube1.BackgroundImage")));
            this.cube1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cube1.Location = new System.Drawing.Point(341, 73);
            this.cube1.Name = "cube1";
            this.cube1.Size = new System.Drawing.Size(43, 45);
            this.cube1.TabIndex = 25;
            this.cube1.UseVisualStyleBackColor = true;
            this.cube1.Click += new System.EventHandler(this.cube1_Click);
            // 
            // cube6
            // 
            this.cube6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cube6.BackgroundImage")));
            this.cube6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cube6.Location = new System.Drawing.Point(434, 124);
            this.cube6.Name = "cube6";
            this.cube6.Size = new System.Drawing.Size(43, 45);
            this.cube6.TabIndex = 30;
            this.cube6.UseVisualStyleBackColor = true;
            this.cube6.Click += new System.EventHandler(this.cube6_Click);
            // 
            // cube5
            // 
            this.cube5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cube5.BackgroundImage")));
            this.cube5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cube5.Location = new System.Drawing.Point(387, 124);
            this.cube5.Name = "cube5";
            this.cube5.Size = new System.Drawing.Size(43, 45);
            this.cube5.TabIndex = 29;
            this.cube5.UseVisualStyleBackColor = true;
            this.cube5.Click += new System.EventHandler(this.cube5_Click);
            // 
            // cube4
            // 
            this.cube4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cube4.BackgroundImage")));
            this.cube4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cube4.Location = new System.Drawing.Point(341, 124);
            this.cube4.Name = "cube4";
            this.cube4.Size = new System.Drawing.Size(43, 45);
            this.cube4.TabIndex = 28;
            this.cube4.UseVisualStyleBackColor = true;
            this.cube4.Click += new System.EventHandler(this.cube4_Click);
            // 
            // cube9
            // 
            this.cube9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cube9.BackgroundImage")));
            this.cube9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cube9.Location = new System.Drawing.Point(434, 175);
            this.cube9.Name = "cube9";
            this.cube9.Size = new System.Drawing.Size(43, 45);
            this.cube9.TabIndex = 33;
            this.cube9.UseVisualStyleBackColor = true;
            this.cube9.Click += new System.EventHandler(this.cube9_Click);
            // 
            // cube8
            // 
            this.cube8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cube8.BackgroundImage")));
            this.cube8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cube8.Location = new System.Drawing.Point(387, 175);
            this.cube8.Name = "cube8";
            this.cube8.Size = new System.Drawing.Size(43, 45);
            this.cube8.TabIndex = 32;
            this.cube8.UseVisualStyleBackColor = true;
            this.cube8.Click += new System.EventHandler(this.cube8_Click);
            // 
            // cube7
            // 
            this.cube7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cube7.BackgroundImage")));
            this.cube7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cube7.Location = new System.Drawing.Point(341, 173);
            this.cube7.Name = "cube7";
            this.cube7.Size = new System.Drawing.Size(43, 45);
            this.cube7.TabIndex = 31;
            this.cube7.UseVisualStyleBackColor = true;
            this.cube7.Click += new System.EventHandler(this.cube7_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(511, 134);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(80, 33);
            this.button16.TabIndex = 34;
            this.button16.Text = "Submit";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 526);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.cube9);
            this.Controls.Add(this.cube8);
            this.Controls.Add(this.cube7);
            this.Controls.Add(this.cube6);
            this.Controls.Add(this.cube5);
            this.Controls.Add(this.cube4);
            this.Controls.Add(this.cube3);
            this.Controls.Add(this.cube2_);
            this.Controls.Add(this.cube1);
            this.Controls.Add(this.the_six);
            this.Controls.Add(this.the_five);
            this.Controls.Add(this.the_four);
            this.Controls.Add(this.the_three);
            this.Controls.Add(this.the_two);
            this.Controls.Add(this.the_one);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tails);
            this.Controls.Add(this.timesLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.heads);
            this.Controls.Add(this.header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Coin Flipped Seed";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button heads;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tails;
        private System.Windows.Forms.Label timesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button the_one;
        private System.Windows.Forms.Button the_two;
        private System.Windows.Forms.Button the_three;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button the_five;
        private System.Windows.Forms.Button the_four;
        private System.Windows.Forms.Button the;
        private System.Windows.Forms.Button hre;
        private System.Windows.Forms.Button the_six;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cube2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button cube3;
        private System.Windows.Forms.Button cube;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button cube1;
        private System.Windows.Forms.Button cube6;
        private System.Windows.Forms.Button cube5;
        private System.Windows.Forms.Button cube4;
        private System.Windows.Forms.Button cube9;
        private System.Windows.Forms.Button cube8;
        private System.Windows.Forms.Button cube7;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button cube2_;
    }
}

