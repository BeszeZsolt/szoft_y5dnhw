using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class KígyóElem : PictureBox
    {
        public static int Méret = 30;
        public KígyóElem()
        {
            Width = KígyóElem.Méret;
            Height = KígyóElem.Méret;
            BackColor = Color.Fuchsia;
        }
    }
}
