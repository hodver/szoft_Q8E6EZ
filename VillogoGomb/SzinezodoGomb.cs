using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class SzinezodoGomb : Button
    {
        public SzinezodoGomb()
        {
            Height = 20;
            Width = 20;
            Click += SzinezodoGomb_Click;
            DoubleClick += SzinezodoGomb_DoubleClick;
        }

        private void SzinezodoGomb_DoubleClick(object? sender, EventArgs e)
        {
            BackColor = SystemColors.ButtonFace;
        }

        private void SzinezodoGomb_Click(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
