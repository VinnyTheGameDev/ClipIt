using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Interop;

namespace ClipIt
{

    public partial class Window : Form
    {

        public Window()
        {

            InitializeComponent();

        }

        void Capture()
        {

            while (true)
            {

                Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
                ScreenCapture.Image = bitmap;

                Thread.Sleep(1000);

            }

        }

        private void ClipButton_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(() => Capture());
            thread.Start();

        }

    }

}