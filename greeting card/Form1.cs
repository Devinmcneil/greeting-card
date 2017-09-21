using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace greeting_card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.SeaGreen);
            Graphics fg = this.CreateGraphics();

            Font drawFont = new Font("Georgia", 20, FontStyle.Bold);
            fg.DrawString("Devin McNeil", drawFont, drawBrush, 20, 200);
            fg.DrawString("Pieces greeting card", drawFont, drawBrush, 10, 10);
            Thread.Sleep(3000);
            BackgroundImage = null;

            fg.DrawString("The pisces horoscope in from Febuary 19 - March 20.", drawFont, drawBrush, 140, 160);


        }
    }
}
