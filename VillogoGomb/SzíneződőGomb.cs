using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class SzíneződőGomb : Button
    {
        public SzíneződőGomb()
        {
            Height = 20;
            Width = 20;
            MouseClick += SzíneződőGomb_MouseClick;
        }

        private void SzíneződőGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (BackColor == Color.Fuchsia)
            {
                BackColor = SystemColors.ButtonFace;
            }
            else
            {
                BackColor = Color.Fuchsia;
            }
        }
    }
}
