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
    public partial class Form1 : Form
    {
        private Betters _mike;
        

        public Form1(Betters mike)
        {
            _mike = mike;
            InitializeComponent();
            moneyVar.Text = _mike._money;
        }
        ImageRuning[] cats = new ImageRuning[3];

        private void ToggleRace(int index, PictureBox catBox)
        {
            if (cats[index] == null)
            {
                cats[index]= new ImageRuning();
                cats[index].NewPicture = catBox;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleRace(0, pictureBox1);
            
            ToggleRace(1, pictureBox2);
            
            ToggleRace(2, pictureBox3);
            
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
                    }
                }
                
            }
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


    }
}
