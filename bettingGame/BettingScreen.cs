using System;
using System.Windows.Forms;

namespace bettingGame
{
    public partial class BettingScreen : Form
    {
        private readonly Betters _mike;
        private readonly Betters _john;
        private readonly Betters _kim;
        private bool _timerIsRunning;
        private int _winingCat;


        public BettingScreen(Betters mike, Betters john, Betters kim)
        {
            _mike = mike;
            _john = john;
            _kim = kim;
            InitializeComponent();

            mikeMoney.Text = _mike.Money.ToString(); // get the 
            johnMoney.Text = _john.Money.ToString();
            kimMoney.Text = _kim.Money.ToString();

        }

        readonly ImageRuning[] _cats = new ImageRuning[3];

        private void ToggleRace(int index, PictureBox catBox)
        {
            if (_cats[index] == null)
            {
                _cats[index] = new ImageRuning();
                _cats[index].NewPicture = catBox;
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
                if (_cats[i] != null)
                {
                    _cats[i].Move();
                    if (_cats[i].racing == false)
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


        public void CheckWiningCat()
        {
            if (_timerIsRunning == false)

                //ToDo : i have to try to reduce this code cause it is to long , just too lazy to think of a better solution ,as long as this one work for now
                if (cat1.Left > cat2.Left)
                {
                    if (cat1.Left > cat3.Left)
                    {

                        MessageBox.Show(@"Cat1 Win");
                        _winingCat = 1;
                    }
                    else
                    {
                        //cat3 win
                        MessageBox.Show(@"Cat3 Win");
                        _winingCat = 3;
                    }
                }
                else if (cat2.Left > cat1.Left)
                {
                    if (cat2.Left > cat3.Left)
                    {
                        //cat2 win
                        MessageBox.Show(@"Cat2 Win");
                        _winingCat = 2;
                    }
                    else
                    {
                        //cat3 win
                        MessageBox.Show(@"Cat3 Win");
                        _winingCat = 3;
                    }
                }
                else if (cat1.Left > cat3.Left)
                {
                    if (cat1.Left > cat2.Left)
                    {
                        //cat1 win  
                        MessageBox.Show(@"Cat1 Win");
                        _winingCat = 1;
                    }
                    else
                    {
                        //cat2 win
                        MessageBox.Show(@"Cat2 Win");
                        _winingCat = 2;
                    }
                }

        }

        public void WinnerBet()
        {
            if (checkBox1.Checked)
            {

                if (radioButton1.Checked && radioButton1.Text == _winingCat.ToString())
                {
                    _john.Win((int)numericUpDown1.Value);
                    johnMoney.Text = _john.Money.ToString();
                }
                else if (radioButton2.Checked && radioButton2.Text == _winingCat.ToString())
                {
                    _john.Win((int)numericUpDown1.Value);
                    johnMoney.Text = _john.Money.ToString();
                }
                else if (radioButton3.Checked && radioButton3.Text == _winingCat.ToString())
                {
                    _john.Win((int)numericUpDown1.Value);
                    johnMoney.Text = _john.Money.ToString();
                }
                else
                {
                    _john.Loose((int)numericUpDown1.Value);
                    johnMoney.Text = _john.Money.ToString();//_john.loose();
                }
            }

        }
    }
}
