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
    public partial class StartingCash : Form
    {
        private Betters _mike;
        public StartingCash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _john = new Betters(mikeCash.Text);
            var trans = new Form1(_mike);
            trans.Show();
            
           
        }


    }
}
