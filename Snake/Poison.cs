using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Poison : PictureBox
    {
        public static int Méret = 20;
        public Poison()
        {
            Width = Poison.Méret;
            Height = Poison.Méret;
            BackColor = Color.Black;
        }
    }
}
