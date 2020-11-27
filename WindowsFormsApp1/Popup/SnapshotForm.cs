using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using StudyCafe.Data;

namespace WindowsFormsApp1.Popup
{
    public partial class SnapshotForm : Form
    {
        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        bool isCameraRunning = false;

        public SnapshotForm()
        {
            InitializeComponent();
        }
        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }
        private void CaptureCameraCallback()
        {

            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);

            if (capture.IsOpened())
            {
                while (isCameraRunning)
                {

                    capture.Read(frame);
                    image = BitmapConverter.ToBitmap(frame);
                    if (UserImage.Image != null)
                    {
                        UserImage.Image.Dispose();
                    }
                    UserImage.Image = image;
                }
            }
        }
        private void btnTakeSnapshot_Click(object sender, EventArgs e)
        {

            if (isCameraRunning)
            {
                Bitmap snapshot = new Bitmap(UserImage.Image);
                byte[] dst = imageToByteArray(snapshot);
                Picture picture = new Picture
                {
                    value = dst
                };

                btnSwitch.PerformClick();

                if (MessageBox.Show
                    ("선택하신 정보가 저장됩니다", "YesOrNo",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Dao.Picture.Insert(picture);
                    DialogResult = DialogResult.OK;
                    Close();
                }

                else
                {
                    btnSwitch.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("카메라를 먼저 실행시켜주세요");
            }
        }
        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (btnSwitch.Text.Equals("Start"))
            {
                CaptureCamera();
                btnSwitch.Text = "Stop";
                isCameraRunning = true;
            }
            else
            {
                capture.Release();
                btnSwitch.Text = "Start";
                isCameraRunning = false;
            }
        }


    }
}
