using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamoloGomb
{
    internal class Szamolo : Button
    {
        int szam=1;
        public Szamolo() {
            Width = 20;
            Height = 20;
            MouseClick += Szamolo_MouseClick;
        }

        private void Szamolo_MouseClick(object? sender, MouseEventArgs e)
        {
            if(szam==5)
            {
                szam = 1;
            }
            else
            { 
                szam = szam + 1;
            }
            Text = szam.ToString();
        }
    }
}
