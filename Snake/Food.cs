using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Food : PictureBox
    {
        public static int Méret = 20;
        public Food()
        {
            Width = Food.Méret;
            Height = Food.Méret;
            BackColor = Color.Green;
        }
    }
}
