using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screenshot
{
    public partial class Form1 : Form
    {
        public static Bitmap BM = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height); 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.BackColor = System.Drawing.Color.Lime;
            Graphics GH = Graphics.FromImage(BM as Image);
            GH.CopyFromScreen(0, 0, 0, 0, BM.Size);
            
            ScreenShot SI = new ScreenShot();
            
            SI.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int iFormX, iFormY, iMouseX, iMouseY;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }
    }
}
