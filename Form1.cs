﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Suprema;

namespace FingerPrint
{
    public partial class Form1 : Form
    {
        //مقداردهی اولیه
        UFScannerManager m_ScannerManager;
        string m_strError;
        byte[][] m_template1;
        int[] m_template_size1;
        byte[][] m_template2;
        int[] m_template_size2;
        int m_template_num;
        string[] m_UserID;
        int m_quality;
        int m_nType;
        //
        byte[] m_pUFTemplateBuf;
        int[] m_pUFTemplateBufSize;
        byte[] m_pISOTemplateBuf;
        int[] m_pISOTemplateBufSize;
        //
        const int MAX_TEMPLATE_SIZE = 1024;
        const int MAX_TEMPLATE_NUM = 50;

        const int MAX_USERID_SIZE = 10;
        const int MAX_TEMPLATE_INPUT_NUM = 4;
        const int MAX_TEMPLATE_OUTPUT_NUM = 2;

        const int FINGERDATA_COL_SERIAL = 0;
        const int FINGERDATA_COL_USERID = 1;
        const int FINGERDATA_COL_TEMPLATE1 = 2;
        const int FINGERDATA_COL_TEMPLATE2 = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_ScannerManager = new UFScannerManager(this);
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            //آماده سازی اسکنر

            UFS_STATUS ufs_res;
            int nScannerNumber;

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                ufs_res = m_ScannerManager.Init();



                if (ufs_res == UFS_STATUS.OK)
                {
                }
                else
                {
                    UFScanner.GetErrorString(ufs_res, out m_strError);
                    tbxMessage.AppendText("آماده سازی اسکنر با خطا مواجه شد: " + m_strError + "\r\n");
                    Cursor.Current = this.Cursor;
                    return;
                }

                m_ScannerManager.ScannerEvent += new UFS_SCANNER_PROC(ScannerEvent);

                nScannerNumber = m_ScannerManager.Scanners.Count;
                if (nScannerNumber == 0)
                    tbxMessage.AppendText("اسکنر یافت نشد. اتصال دستگاه را بررسی نمایید."  + "\r\n");
                else
                {
                    tbxMessage.AppendText("آماده سازی اسکنر انجام شد.\r\n");

                    tbxMessage.AppendText("کد اسکنر: " + nScannerNumber + "\r\n");
                }

                UpdateScannerList();
            }
            catch (System.DllNotFoundException )
            {
                tbxMessage.AppendText("خطا: فایل های اجرایی مورد نیاز یافت نشد\r\n");

            }


            Cursor.Current = this.Cursor;
        }

        //تعریف دلگیت به روزرسانی تصویر 
        private delegate void _UpdatePictureBox(PictureBox pbox, Bitmap image);

        public void UpdatePictureBox(PictureBox pbox, Image image)
        {
            //جهت نمایش تصیویر
            if (pbox.InvokeRequired)
            {
                _UpdatePictureBox del = new _UpdatePictureBox(UpdatePictureBox);
                // Call the function in the correct thread
                BeginInvoke(del, new object[] { pbox, image });
            }
            else
            {
                // We are in the correct thread, so assign the image
                pbox.Image = image;
                //System.Threading.Thread.Sleep(100);
            }
        }
        public int CaptureEvent(object sender, UFScannerCaptureEventArgs e)
        {
            int lfdScore;
            //جهت تشخیص اثر انگشت جعلی
            UFScanner temp = (UFScanner)sender;
            if (temp.DetectFake > 0 && isPreview == false)
            {
                temp.GetLFDScore(e.ImageFrame, out lfdScore);
                if (this.tbxMessage.InvokeRequired)
                {
                    this.tbxMessage.Invoke(new MethodInvoker(delegate ()
                    {
                        tbxMessage.AppendText(" LFD امتیاز : " + lfdScore + "\r\n");
                    }));
                }
                else
                {
                    this.tbxMessage.AppendText(" LFD امتیاز: " + lfdScore + "\r\n");
                }
            }

            UpdatePictureBox(pbImageFrame, e.ImageFrame);
            //MessageBox.Show("Enroll UI is not supported."+ sender.ToString());
            if (e.FingerOn)
            {
                m_LFDImg = e.ImageFrame;
            }

            return 1;
        }
        public void ScannerEvent(object sender, UFScannerManagerScannerEventArgs e)
        {
            if (e.SensorOn)
            {
                UpdateScannerList();
            }
            else
            {
                UpdateScannerList();
            }
        }
        private void UpdateScannerList()
        {
            int nScannerNumber;

            nScannerNumber = m_ScannerManager.Scanners.Count;

            lbScannerList.Items.Clear();

            for (int i = 0; i < nScannerNumber; i++)
            {
                UFScanner Scanner;
                UFS_SCANNER_TYPE ScannerType;
                string strScannerType;
                string strID;
                string str_tmp;

                Scanner = m_ScannerManager.Scanners[i];

                tbxMessage.AppendText("یک دستگاه متصل شناسایی شد" + i + " شماره سریال: " + Scanner.Serial + "\r\n");

                ScannerType = Scanner.ScannerType;
                strID = Scanner.ID;
              

                str_tmp = "دستگاه شناسایی شد" +"("+ strID.Substring(0,10)+")";
                lbScannerList.Items.Add(str_tmp);
                lbScannerList.SelectedIndex = 0;

            }


        }

        public Bitmap m_LFDImg;
        public bool isPreview;
        private void btnStartCapturing_Click(object sender, EventArgs e)
        {
            UFScanner Scanner;
            UFS_STATUS ufs_res;
            if (!GetGetCurrentScanner(out Scanner))
            {
                return;
            }
            isPreview = true;
            Scanner.CaptureEvent += new UFS_CAPTURE_PROC(CaptureEvent);
            ufs_res = Scanner.StartCapturing();
            if (ufs_res == UFS_STATUS.OK)
            {
                tbxMessage.AppendText("دریافت اثر انگشت با موفقیت انجام شد\r\n");
            }
            else
            {
                UFScanner.GetErrorString(ufs_res, out m_strError);
                tbxMessage.AppendText("خطا هنگام دریافت اثر انگشت: " + m_strError + "\r\n");
            }
        }
        private bool GetGetCurrentScanner(out UFScanner Scanner)
        {
            //جهت دریافت هندلر اسکنر انتخاب شده
            Scanner = m_ScannerManager.Scanners[lbScannerList.SelectedIndex];
            if (Scanner != null)
            {
                return true;
            }
            else
            {
                tbxMessage.AppendText("اسکنر انتخاب شده متصل نیست\r\n");
                return false;
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            UFScanner Scanner;
            UFS_STATUS ufs_res;
            if (!GetGetCurrentScanner(out Scanner))
            {
                return;
            }

            Scanner.TemplateSize = MAX_TEMPLATE_SIZE;
            Scanner.DetectCore = false;

            byte[] Template = new byte[MAX_TEMPLATE_SIZE];
            int TemplateSize;
            int EnrollQuality;

            Cursor.Current = Cursors.WaitCursor;
            ufs_res = Scanner.ExtractEx(MAX_TEMPLATE_SIZE, Template, out TemplateSize, out EnrollQuality);
            Cursor.Current = this.Cursor;

            if (ufs_res == UFS_STATUS.OK)
            {
                
                tbxMessage.AppendText(String.Format("عملیات موفق({0}), کیفیت({1})\r\n", TemplateSize, EnrollQuality));
            }
            else
            {
                UFScanner.GetErrorString(ufs_res, out m_strError);
                tbxMessage.AppendText("عملیات با خطا مواجه شد: " + m_strError + "\r\n");
            }
            DrawCapturedImage(Scanner);
        }
        private void DrawCapturedImage(UFScanner Scanner)
        {
            Graphics g = pbImageFrame.CreateGraphics();
            Rectangle rect = new Rectangle(0, 0, pbImageFrame.Width, pbImageFrame.Height);
            try
            {
                // 1. DrawCaptureImageBuffer
                Scanner.DrawCaptureImageBuffer(g, rect, false);

                // 2. GetCaptureImageBuffer
                //Bitmap bitmap;
                //int Resolution;
                //Scanner.GetCaptureImageBuffer(out bitmap, out Resolution);
                //pbImageFrame.Image = bitmap;
            }
            finally
            {
                g.Dispose();
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            UFScanner Scanner;
            UFS_STATUS ufs_res;

            int nFilterIdx = 0;

            if (!GetGetCurrentScanner(out Scanner))
            {
                return;
            }

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Bitmap files (*.bmp)|*.bmp";
            dlg.DefaultExt = "bmp";
            if (dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                nFilterIdx = dlg.FilterIndex;
            }

            if (nFilterIdx == 1)
            {
                ufs_res = Scanner.SaveCaptureImageBufferToBMP(dlg.FileName);
                if (ufs_res == UFS_STATUS.OK)
                {
                    tbxMessage.AppendText("تصویر اثر انگشت ذخیره شد: " + dlg.FileName + "\r\n");
                }
            }
            else if (nFilterIdx == 2)
            {
                ufs_res = Scanner.SaveCaptureImageBufferToWSQ(dlg.FileName, (float)2.25);
                if (ufs_res == UFS_STATUS.OK)
                {
                    tbxMessage.AppendText("تصویر اثر انگشت ذخیره شد: " + dlg.FileName + "\r\n");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxMessage.Clear();
        }
    }
}
