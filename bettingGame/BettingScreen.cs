using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bettingGame
{
    public partial class BettingScreen : Form
    {
        private Betters _mike;
        private Betters _john;
        private Betters _kim;
        private bool _timerIsRunning;
        private int _WiningCat;


        public BettingScreen(Betters mike, Betters john, Betters kim)
        {
            _mike = mike;
            _john = john;
            _kim = kim;
            InitializeComponent();

            mikeMoney.Text = _mike.Money; // get the 
            johnMoney.Text = _john.Money;
            kimMoney.Text = _kim.Money;

        }

        ImageRuning[] cats = new ImageRuning[3];

        private void ToggleRace(int index, PictureBox catBox)
        {
            if (cats[index] == null)
            {
                cats[index] = new ImageRuning();
                cats[index].NewPicture = catBox;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleRace(0, cat1);
            ToggleRace(1, cat2);
            ToggleRace(2, cat3);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (cats[i] != null)
                {
                    cats[i].Move();
                    if (cats[i].racing == false)
                    {
                        timer1.Stop();
                        _timerIsRunning = false;
                        CheckWiningCat();
                        WinnerBet();

                    }
                }

            }

            _timerIsRunning = true;

        }


        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                panel1.Enabled = true;
            }
            else
            {
                panel1.Enabled = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void BettingScreen_Load(object sender, EventArgs e)
        {

        }

        public void CheckWiningCat()
        {
            if (_timerIsRunning == false)

                //ToDo : i have to try to reduce this code cause it is to long , just too lazy to think of a better solution ,as long as this one work for now
                if (cat1.Left > cat2.Left)
                {
                    if (cat1.Left > cat3.Left)
                    {
                        
                        MessageBox.Show("Cat1 Win");
                        _WiningCat = 1;
                    }
                    else
                    {
                        //cat3 win
                        MessageBox.Show("Cat3 Win");
                        _WiningCat = 3;
                    }
                }
                else if (cat2.Left > cat1.Left)
                {
                    if (cat2.Left > cat3.Left)
                    {
                        //cat2 win
                        MessageBox.Show("Cat2 Win");
                        _WiningCat = 2;
                    }
                    else
                    {
                        //cat3 win
                        MessageBox.Show("Cat3 Win");
                        _WiningCat = 3;
                    }
                }
                else if (cat1.Left > cat3.Left)
                {
                    if (cat1.Left > cat2.Left)
                    {
                        //cat1 win  
                        MessageBox.Show("Cat1 Win");
                        _WiningCat = 1;
                    }
                    else
                    {
                        //cat2 win
                        MessageBox.Show("Cat2 Win");
                        _WiningCat = 2;
                    }
                }

        }

        public void WinnerBet()
        {
            if (radioButton1.Checked && radioButton1.Text == _WiningCat.ToString())
            {
                _john.Win((int)numericUpDown1.Value);
                johnMoney.Text = _john.Money;
            }
            else if (radioButton2.Checked && radioButton2.Text == _WiningCat.ToString())
            {
                _john.Win((int)numericUpDown1.Value);
                johnMoney.Text = _john.Money;
            }
            else if (radioButton3.Checked && radioButton3.Text == _WiningCat.ToString())
            {
                _john.Win((int)numericUpDown1.Value);
                johnMoney.Text = _john.Money;
            }
            else
            {
                //_john.loose();
            }

        }
    }
}
