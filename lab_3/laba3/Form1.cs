using System;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace laba3
{
    public partial class Form1 : Form
    {
        private Emgu.CV.VideoCapture capture = null;

        public Form1()
        {
            InitializeComponent();
            capture = new VideoCapture(0);
            capture.ImageGrabbed += ProcessFrame;
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            Mat frame = new Mat();
            Mat frame1 = new Mat();
            capture.Retrieve(frame);
            capture.Retrieve(frame1);
            CvInvoke.MedianBlur(frame1, frame, 5);
            if (RGB.Checked)
            {
                pictureBox1.Image = frame.ToImage<Rgba, byte>().ToBitmap();
            }
            if (Sobel.Checked)
            {
                CvInvoke.Sobel(frame, frame, Emgu.CV.CvEnum.DepthType.Default, 1, 1);
                pictureBox1.Image = frame.ToImage<Gray, byte>().ThresholdBinary(new Gray(10), new Gray(255)).ToBitmap();
            }
            if (Laplas.Checked)
            {
                CvInvoke.Laplacian(frame, frame, Emgu.CV.CvEnum.DepthType.Default);
                pictureBox1.Image = frame.ToImage<Rgba, byte>().ToBitmap();
            }
            if (Canny.Checked)
            {
                CvInvoke.Canny(frame1, frame, 70, 160, apertureSize: 3);
                pictureBox1.Image = frame.ToImage<Gray, byte>().ToBitmap();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (capture != null)
                capture.Start();
            else
                Form1_Load(null, null);
        }
    }
}
