using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bettingGame
{
    class ImageRuning
    {
        public PictureBox NewPicture;
        

        public bool racing = true;
        private static Random speedFactor = new Random();
        

        public void Move()
        {
            NewPicture.BackColor = Color.Transparent;
            if (NewPicture != null)
            {
                if (racing)
                {
                    NewPicture.Left += speedFactor.Next(1, 15);
                    if (NewPicture.Left >= NewPicture.Parent.Width - 160)
                    {
                        racing = false;
                    }
                }
            }
        }
    }
}
