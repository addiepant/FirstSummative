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
using System.Media;

//Addie Pant's Graphics Summative

namespace FirstSummative
{
    public partial class greetingCard : Form
    {
        public greetingCard()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            //Set up brushes and Pens, define variables
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Gold, 2);
            SolidBrush drawBrush = new SolidBrush(Color.Gold);
            SoundPlayer player = new SoundPlayer(Properties.Resources.chime);

            //Hide butons and label
            openButton.Hide();
            notificationLabel.Hide();

            //Form Elipses/stars
            formGraphics.FillEllipse(drawBrush, 246, 55, 5, 5);
            player.Play();
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 226, 45, 5, 5);
            player.Play();
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 206, 112, 5, 5);
            player.Play();
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 236, 123, 5, 5);
            player.Play();
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 249, 155, 5, 5);
            player.Play();
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 134, 183, 5, 5);
            player.Play();
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 77, 210, 5, 5);
            player.Play();
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 117, 146, 5, 5);
            player.Play();
            Thread.Sleep(500);

            //Form Lines
            formGraphics.DrawLine(drawPen, 246, 55, 226, 45);
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 226, 45, 206, 112);
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 206, 112, 236, 123);
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 236, 123, 249, 155);
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 249, 155, 134, 183);
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 134, 183, 77, 210);
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 77, 210, 117, 146);
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 117, 146, 134, 183);

            














        }
    }
}
