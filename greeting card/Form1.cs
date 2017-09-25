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
            Pen drawPen = new Pen(Color.Black, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Graphics fg = this.CreateGraphics();
            horoscope.Dispose();
            nameTag.Dispose();
            BackgroundImage = null;
            Refresh();

            this.BackColor = Color.Red;
            Font drawFont = new Font("Georgia", 10, FontStyle.Bold);
            Font = new Font("Georgia", 10, FontStyle.Bold);
            fg.DrawString("The pisces horoscope lasts from Febuary 19 - March 20.", drawFont, drawBrush, 5,400);

            formGraphics.DrawEllipse(drawPen, 150, 250, 10, 10);
            formGraphics.FillEllipse(drawBrush, 150, 250, 10, 10);

            formGraphics.DrawEllipse(drawPen, 190, 300, 10, 10);
            formGraphics.FillEllipse(drawBrush, 190, 300, 10, 10);

            formGraphics.DrawEllipse(drawPen, 230, 250, 10, 10);
            formGraphics.FillEllipse(drawBrush, 230, 250, 10, 10);

            formGraphics.DrawEllipse(drawPen, 300, 250, 10, 10);
            formGraphics.FillEllipse(drawBrush, 300, 250, 10, 10);

            formGraphics.DrawEllipse(drawPen, 350, 250, 10, 10);
            formGraphics.FillEllipse(drawBrush, 350, 250, 10, 10);

            formGraphics.DrawEllipse(drawPen, 400, 280, 10, 10);
            formGraphics.FillEllipse(drawBrush, 400, 280, 10, 10);

            formGraphics.DrawEllipse(drawPen, 370, 200, 10, 10);
            formGraphics.FillEllipse(drawBrush, 370, 200, 10, 10);

            formGraphics.DrawEllipse(drawPen, 340, 180, 10, 10);
            formGraphics.FillEllipse(drawBrush, 340, 180, 10, 10);

            formGraphics.DrawEllipse(drawPen, 300, 100, 10, 10);
            formGraphics.FillEllipse(drawBrush, 300, 100, 10, 10);

            formGraphics.DrawEllipse(drawPen, 280, 80, 10, 10);
            formGraphics.FillEllipse(drawBrush, 280, 80, 10, 10);

            formGraphics.DrawEllipse(drawPen, 295, 120, 10, 10);
            formGraphics.FillEllipse(drawBrush, 295, 120, 10, 10);

            formGraphics.DrawEllipse(drawPen, 295, 120, 10, 10);
            formGraphics.FillEllipse(drawBrush, 295, 120, 10, 10);
        }
    }
}
