using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private List<Color> labelColors = new List<Color>()
        {
            Color.Red,
            Color.Blue,
            Color.Green,
            Color.Orange,
            Color.Purple
        };

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            SoundPlayer player = new SoundPlayer(@"C:\Users\blubs\hinoestourado.wav");
            player.Play();

            while (true)
            {
                Label label = new Label();
                label.Text = "PASSA O ZAP KKKKKK";
                label.Size = new Size(200, 50);
                label.BackColor = labelColors[random.Next(labelColors.Count)];
                label.Location = new Point(random.Next(0, this.Width - label.Width), random.Next(0, this.Height - label.Height));
                this.Controls.Add(label);
                BackgroundImage = Properties.Resources.meudeus;

                await Task.Delay(2000);
            }
        }
    }
}