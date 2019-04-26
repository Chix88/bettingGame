using System;
using System.Collections.Generic;
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
            if (NewPicture != null)
            {
                if (racing)
                {
                    NewPicture.Left += speedFactor.Next(1, 15);
                    if (NewPicture.Left >= NewPicture.Parent.Width - NewPicture.Width - 50)
                    {
                        racing = false;
                    }
                }
            }
        }
    }
}
