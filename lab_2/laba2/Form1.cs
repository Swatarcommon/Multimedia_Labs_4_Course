using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace laba2 {
    public partial class Form1 : Form {
        Image<Bgr, byte> image = new Image<Bgr, byte>("C:/Disk D/Studying/Course_4/Multimedia/laba2/laba2/images/image.jpg");

        public Form1() {
            InitializeComponent();

            this.imageBox1.Image = image;


            // Task 1
            ConvolutionKernelF Kernel = new ConvolutionKernelF(
                new float[,] {
                                {-0.1f, -0.2f, -0.1f,
                                 -0.2f, 2.5f, -0.2f,
                                -0.1f, -0.2f, -0.1f,
                                           -0.1f, -0.2f, -0.1f,
                                                      -0.1f, -0.2f, -0.1f,
                                -0.1f, -0.2f, -0.1f}
                }
             );
            var img1 = image.Copy();
            CvInvoke.Filter2D(image, img1, Kernel, new Point() { X = -1, Y = -1 });
            this.imageBox2.Image = img1;


            // Task 2
            var img2 = image.Copy();
            CvInvoke.Blur(image, img2, new Size { Height = 10, Width = 10 }, new Point() { X = 1, Y = 1 });
            this.imageBox3.Image = img2;

            var img3 = image.Copy();
            CvInvoke.BoxFilter(image, img3, Emgu.CV.CvEnum.DepthType.Default, new Size { Height = 15, Width = 15 }, new Point() { X = 1, Y = 1 });
            this.imageBox4.Image = img3;

            var img4 = image.Copy();
            CvInvoke.GaussianBlur(image, img4, new Size { Height = 201, Width = 201 }, 4);
            this.imageBox5.Image = img4;

            var img5 = image.Copy();
            CvInvoke.MedianBlur(image, img5, 7);
            this.imageBox6.Image = img5;


            // Task 3
            var img6 = image.Copy();
            CvInvoke.Erode(image, img6, new Mat(), new Point() { X = -1, Y = -1 }, 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(1));
            this.imageBox7.Image = img6;

            var img7 = image.Copy();
            CvInvoke.Dilate(image, img7, new Mat(), new Point() { X = -1, Y = -1 }, 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(1));
            this.imageBox8.Image = img7;


            // Task 4
            var img_canny = new Image<Gray, byte>("C:/Disk D/Studying/Course_4/Multimedia/laba2/laba2/images/image.jpg");
            var img8 = img_canny.Copy();
            CvInvoke.Canny(image, img8, 10, 100);
            this.imageBox9.Image = img8;


            // Task 5
            var img = new Image<Gray, byte>("C:/Disk D/Studying/Course_4/Multimedia/laba2/laba2/images/image.jpg");
            var img9 = img.Copy();
            CvInvoke.EqualizeHist(img, img9);
            this.imageBox10.Image = img9;
        }
    }
}
