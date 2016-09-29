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
//Sept 2016
//Program: Press button, zodiac constellation shows up, the horoscope

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
            SolidBrush secondBrush = new SolidBrush(Color.LightCoral);
            SolidBrush thirdBrush = new SolidBrush(Color.LavenderBlush);
            SoundPlayer player = new SoundPlayer(Properties.Resources.chime);
            SoundPlayer playerTwo = new SoundPlayer(Properties.Resources.shootingstar);
            Graphics fg = this.CreateGraphics(); // set variables
            Font drawFont = new Font("Arial", 09, FontStyle.Bold);

            //Play Sound
            player.Play();

            //Hide butons and label
            openButton.Hide();
            notificationLabel.Hide();
            nameTitle.Hide();
            //Form Elipses/stars
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 246, 55, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(drawBrush, 226, 45, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(drawBrush, 206, 112, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(drawBrush, 236, 123, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(drawBrush, 249, 155, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(drawBrush, 134, 183, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(drawBrush, 77, 210, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(drawBrush, 117, 146, 6, 6);
            player.Play();
            Thread.Sleep(1000);

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

            player.Play();
            //Change Elipse Colour
            Thread.Sleep(1000);
            formGraphics.FillEllipse(secondBrush, 246, 55, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(secondBrush, 226, 45, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(secondBrush, 206, 112, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(secondBrush, 236, 123, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(secondBrush, 249, 155, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(secondBrush, 134, 183, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(secondBrush, 77, 210, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(secondBrush, 117, 146, 6, 6);
            player.Play();
            Thread.Sleep(1000);

            //Play sound
            player.Play();

            //Change Elipse Colour
            Thread.Sleep(1000);
            formGraphics.FillEllipse(thirdBrush, 246, 55, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(thirdBrush, 226, 45, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(thirdBrush, 206, 112, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(thirdBrush, 236, 123, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(thirdBrush, 249, 155, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(thirdBrush, 134, 183, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(thirdBrush, 77, 210, 6, 6);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(thirdBrush, 117, 146, 6, 6);
            player.Play();
            Thread.Sleep(1000);

            //Clear Screen
            formGraphics.Clear(Color.Coral);

            //Bring in Text
            playerTwo.Play();
            fg.DrawString("Your naturally warm personality is going to", drawFont, thirdBrush, 0, 10);
            fg.DrawString("melt any icy personalities you encounter today", drawFont, thirdBrush, 0, 40);
            fg.DrawString("so it's going to be a very social day whether you", drawFont, thirdBrush, 0, 70);
            fg.DrawString("had planned on it or not.", drawFont, thirdBrush, 0, 100);





        }
    }
}

