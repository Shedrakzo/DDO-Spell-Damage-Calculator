using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDOSpellDamage
{
    public partial class Form1 : Form
    {


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CMText_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void CMText_Click(object sender, EventArgs e)
        {
            //CMTextold.SelectionStart = 0;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            skullBox.SelectedIndex = 0;
            ActiveControl = SPText;
            //CMTextold.SelectionStart = 0;
            //CMTextold.SelectionLength = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void AveDamageText_TextChanged(object sender, EventArgs e)
        {

        }


        private void CalcButton_Click(object sender, EventArgs e)
        {
            int casterLevel = 0,
            dice1 = 0,
            dice2 = 0,
            dice3 = 0,
            iteration = 5000;

            double spellPower = 0, 
                spellPowerCalc,
                aveDamage = 0,
                critMult = 0,
                critDamage = 0,
                iterationNum = 0;
                
            if (this.SPText.Text == "")
            {
                spellPower = 0;
            }

            else
            {
                try
                {
                    spellPower = double.Parse(this.SPText.Text);
                }
                catch (Exception)
                {
                    spellPower = 0;
                }
            }

            if (this.CMText.Text == "")
            {
                critMult = 0;
            }

            else
            {
                try
                {
                    critMult = double.Parse(this.CMText.Text);
                }
                catch
                {
                    critMult = 0;
                }
            }

            if (this.CLText.Text == "")
            {
                casterLevel = 0;
            }

            else
            {
                try
                {
                    casterLevel = int.Parse(this.CLText.Text);
                }
                catch
                {
                    casterLevel = 0;
                }
            }

            if (this.DiceText1.Text == "")
            {
                dice1 = 0;
            }

            else
            {
                try
                {
                    dice1 = int.Parse(this.DiceText1.Text);
                }
                catch
                {
                    dice1 = 0;
                }
            }

            if (this.DiceText2.Text == "")
            {
                dice2 = 0;
            }

            else
            {
                try
                {
                    dice2 = int.Parse(this.DiceText2.Text);
                }
                catch
                {
                    dice2 = 0;
                }
            }

            if (this.DiceText3.Text == "")
            {
                dice3 = 0;
            }

            else
            {
                try
                {
                    dice3 = int.Parse(this.DiceText3.Text);
                }
                catch
                {
                    dice3 = 0;
                }
            }

            spellPowerCalc = spellPower / 100;

            if(MaxBox.Checked == true)
            {
                spellPowerCalc += 1.5;
            }

            if (EmpBox.Checked == true)
            {
                spellPowerCalc += 0.75;
            }

            if (IntBox.Checked == true)
            {
                spellPowerCalc += 0.75;
            }

            if (EmpHealBox.Checked == true)
            {
                spellPowerCalc += 0.75;
            }

            int[] spell = new int[casterLevel];
            int[] damage = new int[iteration];
            Random Rand = new Random();

            for (int i = 0; i < iteration; i++)
            {
                for (int j = 0; j < casterLevel; j++)
                {
                    iterationNum = 0;

                    for (int k = 0; k < dice1; k++)
                    {
                        iterationNum += Rand.Next(1, dice2);
                    }

                    iterationNum += dice3;
                    spell[j] = (int)iterationNum;

                }
                damage[i] = spell.Sum();
            }

            aveDamage = (Queryable.Average(damage.AsQueryable()) * (1 + spellPowerCalc));

            switch(skullBox.SelectedIndex)
            {
                case 1:
                    aveDamage = aveDamage * 0.769;
                    break;

                case 2:
                    aveDamage = aveDamage * 0.667;
                    break;

                case 3:
                    aveDamage = aveDamage * 0.556;
                    break;

                case 4:
                    aveDamage = aveDamage * 0.455;
                    break;

                case 5:
                    aveDamage = aveDamage * 0.37;
                    break;

                case 6:
                    aveDamage = aveDamage * 0.303;
                    break;

                case 7:
                    aveDamage = aveDamage * 0.25;
                    break;

                case 8:
                    aveDamage = aveDamage * 0.208;
                    break;

                case 9:
                    aveDamage = aveDamage * 0.179;
                    break;

                case 10:
                    aveDamage = aveDamage * 0.156;
                    break;

                default:
                    break;
            }



            critDamage = aveDamage * (2 + (critMult / 100));
            aveDamage = Math.Round(aveDamage, 0);
            critDamage = Math.Round(critDamage, 0);

            AveDamageText.Text = aveDamage.ToString();
            CritDmgText.Text = critDamage.ToString();

        }

        private void SPText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SPText_KeyDown(object sender, KeyEventArgs e)
        {
            if(!(e.KeyCode == Keys.V && e.Modifiers == Keys.Control))
            {
                if(!(e.KeyCode == Keys.C && e.Modifiers == Keys.Control))
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && e.Modifiers == Keys.Shift))
                        {
                            if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                            {
                                e.SuppressKeyPress = true;
                            }
                        }
                    }
                }

            }


        }

        private void CLText_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode == Keys.V && e.Modifiers == Keys.Control))
            {
                if (!(e.KeyCode == Keys.C && e.Modifiers == Keys.Control))
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && e.Modifiers == Keys.Shift))
                        {
                            if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                            {
                                e.SuppressKeyPress = true;
                            }
                        }
                    }
                }

            }
        }

        private void DiceText1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode == Keys.V && e.Modifiers == Keys.Control))
            {
                if (!(e.KeyCode == Keys.C && e.Modifiers == Keys.Control))
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && e.Modifiers == Keys.Shift))
                        {
                            if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                            {
                                e.SuppressKeyPress = true;
                            }
                        }
                    }
                }

            }
        }

        private void DiceText2_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode == Keys.V && e.Modifiers == Keys.Control))
            {
                if (!(e.KeyCode == Keys.C && e.Modifiers == Keys.Control))
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && e.Modifiers == Keys.Shift))
                        {
                            if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                            {
                                e.SuppressKeyPress = true;
                            }
                        }
                    }
                }

            }
        }

        private void DiceText3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiceText3_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode == Keys.V && e.Modifiers == Keys.Control))
            {
                if (!(e.KeyCode == Keys.C && e.Modifiers == Keys.Control))
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && e.Modifiers == Keys.Shift))
                        {
                            if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                            {
                                e.SuppressKeyPress = true;
                            }
                        }
                    }
                }

            }
        }

        private void CMText_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode == Keys.V && e.Modifiers == Keys.Control))
            {
                if (!(e.KeyCode == Keys.C && e.Modifiers == Keys.Control))
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && e.Modifiers == Keys.Shift))
                        {
                            if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                            {
                                e.SuppressKeyPress = true;
                            }
                        }
                    }
                }

            }
        }
    }
}
