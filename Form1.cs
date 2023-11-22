using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Suprema;

namespace FingerPrint
{
    public partial class Form1 : Form
    {
        UFScannerManager m_ScannerManager;
        string m_strError;
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
            UFS_STATUS ufs_res;
            int nScannerNumber;

            Cursor.Current = Cursors.WaitCursor;
            ufs_res = m_ScannerManager.Init();
            if (ufs_res == UFS_STATUS.OK)
            {
                tbxMessage.AppendText("UFScanner Init: OK\r\n");
            }
            else
            {
                UFScanner.GetErrorString(ufs_res, out m_strError);
                tbxMessage.AppendText("UFScanner Init: " + m_strError + "\r\n");
                Cursor.Current = this.Cursor;
                return;
            }
            UpdateScannerList();

          Cursor.Current = this.Cursor;
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
    }
}
