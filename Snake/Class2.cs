using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Alma : PictureBox
    {
        int méret = 20;
        public Alma()
        {
            Width = KígyóElem.Méret;
            Height = KígyóElem.Méret;
            BackColor = Color.Fuchsia;

            Random rnd = new Random();
            int x = méret * rnd.Next();
            int y = méret * rnd.Next();

            Top = y;
            Left = x;
            //nem tudom
        }
    }
}
