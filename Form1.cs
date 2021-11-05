using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 255, 255); //белый
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (x == 0)
            {
                BackColor = Color.FromArgb(255, 0, 0); //красный
            }
            if (x == 1)
            {
                BackColor = Color.FromArgb(255, 127, 0); //оранжевый
            }
            if (x == 2)
            {
                BackColor = Color.FromArgb(255, 255, 0); //жёлтый
            }
            if (x == 3)
            {
                BackColor = Color.FromArgb(127, 255, 0); //салатовый
            }
            if (x == 4)
            {
                BackColor = Color.FromArgb(0, 127, 0); //зелёный
            }
            if (x == 5)
            {
                BackColor = Color.FromArgb(0, 255, 255); //голубой
            }
            if (x == 6)
            {
                BackColor = Color.FromArgb(0, 0, 255); //синий
            }
            if (x == 7)
            {
                BackColor = Color.FromArgb(255, 0, 255); //розовый
            }
            if (x == 8)
            {
                BackColor = Color.FromArgb(0, 0, 0); //чёрный
            }
            if (x == 9)
            {
                Close();
            }
            x++;
        }
    }
}
