using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media.TextFormatting;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        VideoCapture capture;
        Mat frame;
        Mat frameUpdated;
        Bitmap image;
        private Thread camera;
        bool isCameraRunning = false;

        double mainZoom;
        double tempZoom;
        System.Drawing.Point startPos;

        bool isMove_L = false;
        bool isMove_R = false;

        int rullerX;
        int rullerY;
        double pixelSize = 0.0088;
        double block = 10;
        int textScale = 2;
        int sizeOsnDel = 15;
        int valueView = 1;
        

        private void CaptureCamera()
        {
            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);

            if (capture.IsOpened())
            {
                capture.Read(frame);
                frameUpdated = frame.Clone();
                PrepairPB();
                Threating();
            }
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }

        private void CaptureCameraCallback()
        {
                while (isCameraRunning)
                {
                    capture.Read(frame);
                    Threating();
                }
            capture.Release();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(pictureBox_MouseWheel);
            comboBox_valueView.SelectedIndex = 0;
            comboBox_theme.SelectedIndex = 0;
            buttonSFD.Enabled = false;
            comboBox_valueView.SelectedIndex = valueView;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if(button1.Text.Equals("Запустить камеру"))
            {
                CaptureCamera();
                button1.Text = "Остановить камеру";
                isCameraRunning = true;
                buttonSFD.Enabled = true;
            }
            else
            {
                button1.Text = "Запустить камеру";
                isCameraRunning = false;
                buttonSFD.Enabled = false;
            }
        }

        private void buttonUpld_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    frame = new Mat(ofd.FileName);
                    frameUpdated = frame.Clone();
                    PrepairPB();
                    Threating();
                    buttonSFD.Enabled = true;
                }
            }
        }

        private void Threating()
        {
            Mat frameCopy = frameUpdated.Clone();

            Cv2.Line(frameCopy, new OpenCvSharp.Point(0, rullerY), new OpenCvSharp.Point(frame.Width, rullerY), Scalar.Red, 1, LineTypes.AntiAlias);
            Cv2.Line(frameCopy, new OpenCvSharp.Point(rullerX, 0), new OpenCvSharp.Point(rullerX, frame.Height), Scalar.Red, 1, LineTypes.AntiAlias);

            int i = 1;
            bool drawFlag = false;
            double interval;

            while (true)
            {
                

                interval = ((block / pixelSize) / 10) * i;


                string text;
                if (valueView == 0) text = $"{block * i / 10}";
                else text = $"{block * i / 10 / 10}";
                OpenCvSharp.Size textSize = Cv2.GetTextSize(text, HersheyFonts.HersheyPlain, textScale, 1, out int baseline);
                

                if ((rullerX + interval) <= frame.Width)
                {
                    drawFlag = true;

                    if (i % 10 == 0)
                    {
                        Cv2.Line(frameCopy, new OpenCvSharp.Point(rullerX + interval, rullerY + sizeOsnDel), new OpenCvSharp.Point(rullerX + interval, rullerY - sizeOsnDel), Scalar.Red, 1, LineTypes.AntiAlias);
                        Cv2.PutText(frameCopy, text, new OpenCvSharp.Point((rullerX + interval) - (textSize.Width / 2), rullerY - (sizeOsnDel + 5)), HersheyFonts.HersheyPlain, textScale, Scalar.Red, 1, LineTypes.AntiAlias);
                    }

                    else
                    {
                        Cv2.Line(frameCopy, new OpenCvSharp.Point(rullerX + interval, rullerY + 5), new OpenCvSharp.Point(rullerX + interval, rullerY - 5), Scalar.Red, 1, LineTypes.AntiAlias);
                    }
                }

                if ((rullerY + interval) <= frame.Height)
                {
                    drawFlag = true;

                    if (i % 10 == 0)
                    {
                        Cv2.Line(frameCopy, new OpenCvSharp.Point(rullerX + sizeOsnDel, rullerY + interval), new OpenCvSharp.Point(rullerX - sizeOsnDel, rullerY + interval), Scalar.Red, 1, LineTypes.AntiAlias);
                        Cv2.PutText(frameCopy, text, new OpenCvSharp.Point(rullerX + (sizeOsnDel + 5), (rullerY + interval) + (textSize.Height / 2)), HersheyFonts.HersheyPlain, textScale, Scalar.Red, 1, LineTypes.AntiAlias);
                    }

                    else
                    {
                        Cv2.Line(frameCopy, new OpenCvSharp.Point(rullerX + 5, rullerY + interval), new OpenCvSharp.Point(rullerX - 5, rullerY + interval), Scalar.Red, 1, LineTypes.AntiAlias);
                    }
                }

                if ((rullerX - interval) >= 0)
                {
                    drawFlag = true;

                    if (i % 10 == 0)
                    {
                        Cv2.Line(frameCopy, new OpenCvSharp.Point(rullerX - interval, rullerY + sizeOsnDel), new OpenCvSharp.Point(rullerX - interval, rullerY - sizeOsnDel), Scalar.Red, 1, LineTypes.AntiAlias);
                        Cv2.PutText(frameCopy, text, new OpenCvSharp.Point((rullerX - interval) - (textSize.Width / 2), rullerY + (sizeOsnDel + 5) + textSize.Height), HersheyFonts.HersheyPlain, textScale, Scalar.Red, 1, LineTypes.AntiAlias);
                    }

                    else
                    {
                        Cv2.Line(frameCopy, new OpenCvSharp.Point(rullerX - interval, rullerY + 5), new OpenCvSharp.Point(rullerX - interval, rullerY - 5), Scalar.Red, 1, LineTypes.AntiAlias);
                    }
                }

                if ((rullerY - interval) >= 0)
                {
                    drawFlag = true;

                    if (i % 10 == 0)
                    {
                        Cv2.Line(frameCopy, new OpenCvSharp.Point(rullerX + sizeOsnDel, rullerY - interval), new OpenCvSharp.Point(rullerX - sizeOsnDel, rullerY - interval), Scalar.Red, 1, LineTypes.AntiAlias);
                        Cv2.PutText(frameCopy, text, new OpenCvSharp.Point(rullerX - (sizeOsnDel + 5) - textSize.Width, (rullerY - interval) + (textSize.Height / 2)), HersheyFonts.HersheyPlain, textScale, Scalar.Red, 1, LineTypes.AntiAlias);
                    }

                    else
                    {
                        Cv2.Line(frameCopy, new OpenCvSharp.Point(rullerX + 5, rullerY - interval), new OpenCvSharp.Point(rullerX - 5, rullerY - interval), Scalar.Red, 1, LineTypes.AntiAlias);
                    }
                }

                if (drawFlag == false) break;

                i++;
                drawFlag = false;
            }

            image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(frameCopy);
            var saveimg = pictureBox.Image;
            pictureBox.Image = image;
            if (saveimg != null) saveimg.Dispose();
            frameCopy.Dispose();
        }

        private void PrepairPB()
        {
            double kfWidth = (double)panelPB.Width / frame.Width;
            double kfHeight = (double)panelPB.Height / frame.Height;

            if (kfWidth > kfHeight) mainZoom = kfHeight;
            else mainZoom = kfWidth;

            pictureBox.Width = (int)(frame.Width * mainZoom);
            pictureBox.Height = (int)(frame.Height * mainZoom);

            pictureBox.Left = (panelPB.Width - pictureBox.Width) / 2;
            pictureBox.Top = (panelPB.Height - pictureBox.Height) / 2;

            rullerX = frame.Width / 2;
            rullerY = frame.Height / 2;

            resizeOsnDel();
        }

        private void panelPB_Resize(object sender, EventArgs e)
        {
            System.Drawing.Point temp = new System.Drawing.Point(0, 0);
            setZoom(mainZoom, false, temp); 
        }

        private void setZoom(double newZoom, bool moveFlag, System.Drawing.Point movePoint)
        {
            if(frame != null)
            {
                double kfWidth = (double)panelPB.Width / frame.Width;
                double kfHeight = (double)panelPB.Height / frame.Height;

                if (kfWidth > kfHeight) tempZoom = kfHeight;
                else tempZoom = kfWidth;

                if (tempZoom > newZoom)
                {
                    newZoom = tempZoom;
                }
                pictureBox.Width = (int)(frame.Width * newZoom);
                pictureBox.Height = (int)(frame.Height * newZoom);

                if (moveFlag)
                {
                    checkPos(pictureBox.Left - (int)((movePoint.X / mainZoom * newZoom - movePoint.X)), pictureBox.Top - (int)((movePoint.Y / mainZoom * newZoom - movePoint.Y)));
                }
                else checkPos(pictureBox.Left, pictureBox.Top);
                mainZoom = newZoom;
            }
        }

        private void pictureBox_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (mainZoom * 1.3 > 8)
                {
                    setZoom(8, true, e.Location);
                }
                else
                {
                    setZoom(mainZoom * 1.3, true, e.Location);
                }
            }
            else
            {
                setZoom(mainZoom / 1.3, true, e.Location);
            }
        }

        private void pictureBox_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)  isMove_L = false;

            if (e.Button == MouseButtons.Right)  isMove_R = false;
        }

        private void pictureBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMove_L = true;
                startPos.X = e.X;
                startPos.Y = e.Y;
                pictureBox.Focus();
            }

            if (e.Button == MouseButtons.Right)
            {
                isMove_R = true;
                rullerX = (int)(e.X / mainZoom);
                rullerY = (int)(e.Y / mainZoom);
                Threating();
                pictureBox.Focus();
            }
        }

        private void pictureBox_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (isMove_L == true)
            {
                checkPos(pictureBox.Left + e.X - startPos.X, pictureBox.Top + e.Y - startPos.Y);
            }

            if (isMove_R == true)
            {
                rullerX = (int)(e.X / mainZoom);
                rullerY = (int)(e.Y / mainZoom);
                Threating();
            }
        }

        private void checkPos(int pl, int pt)
        {
            if (pictureBox.Width <= panelPB.Width) pl = (panelPB.Width - pictureBox.Width) / 2;
            else
            {
                if (pl > 0) pl = 0;
                if ((pl + pictureBox.Width) < panelPB.Width) pl = panelPB.Width - pictureBox.Width;
            }


            if (pictureBox.Height <= panelPB.Height) pt = (panelPB.Height - pictureBox.Height) / 2;
            else
            {
                if (pt > 0) pt = 0;
                if ((pt + pictureBox.Height) < panelPB.Height) pt = panelPB.Height - pictureBox.Height;
            }

            pictureBox.Left = pl;
            pictureBox.Top = pt;
        }

        private void pictureBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Shift)
            {
                System.Drawing.Point temp = new System.Drawing.Point(0, 0);
                setZoom(0, false, temp);
            }
        }

        private void resizeOsnDel()
        {
            if (string.IsNullOrEmpty(textBox_sizeOsnDel.Text)) textBox_sizeOsnDel.Text = "0";
            else block = Convert.ToDouble(textBox_sizeOsnDel.Text);
        }

        private void textBox_sizeOsnDel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) resizeOsnDel(); Threating();
        }

        private void changePixelSize()
        {
            string pixelSize_temp = textBox_pixelSize.Text;
            if (Double.TryParse(pixelSize_temp, out pixelSize)) textBox_pixelSize.BackColor = Color.White;
            else textBox_pixelSize.BackColor = Color.Red;
        }

        private void textBox_pixelSize_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) changePixelSize();
        }

        private void comboBox_theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_theme.SelectedIndex == 0)
            {
                this.BackColor = Color.LightGray;
                panelPB.BackColor = Color.LightGray;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
            }

            else
            {
                this.BackColor = Color.FromArgb(9, 10, 20);
                panelPB.BackColor = Color.DimGray;
                label1.ForeColor = Color.LightGray;
                label2.ForeColor = Color.LightGray;
                label3.ForeColor = Color.LightGray;
                label4.ForeColor = Color.LightGray;
            }
        }

        private void buttonSFD_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                savedialog.FileName = "Безымянный";
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    }
                    catch
                    {
                        System.Windows.Forms.MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void comboBox_valueView_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueView = comboBox_valueView.SelectedIndex;
            //Threating();
        }

        private void blockDetected()
        {
            frameUpdated = frame.Clone();
            using (Mat gray = new Mat())
            using (Mat binary = new Mat())
            {
                Cv2.CvtColor(frameUpdated, gray, ColorConversionCodes.BGR2GRAY); //перевод в серый
                Cv2.AdaptiveThreshold(gray, binary, 255, AdaptiveThresholdTypes.GaussianC, ThresholdTypes.Binary, 81, 10);    //бинаризация


                OpenCvSharp.Point[][] contours; //поиск контуров
                HierarchyIndex[] hierarchyIndexes;
                Cv2.FindContours(binary, out contours, out hierarchyIndexes, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);

                double minArea = 15;
                double maxArea = 250000;

                for (int i = 0; i < contours.Length; i++)    //отрисовка контуров на изображении
                {
                    double area = Cv2.ContourArea(contours[i]);

                    if (area > minArea && area < maxArea)
                    {
                        OpenCvSharp.Rect rect = Cv2.BoundingRect(contours[i]);
                        Cv2.Rectangle(frameUpdated, rect, Scalar.Red, 2);
                    }
                }

                Threating();
            }
        }
    }
}
