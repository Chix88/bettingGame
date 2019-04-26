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
        private Betters _john;
        private Betters _mike;
        private Betters _kim;
        public StartingCash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _mike = new Betters(mikeCash.Text);
            _john = new Betters(johnCash.Text);
            _kim = new Betters(kimCash.Text);

            var trans = new BettingScreen(_mike,_john,_kim);
            trans.Show();
            
           
        }


    }
}
