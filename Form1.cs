using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPUse
{
    public partial class Form1 : Form
    {
        private string defaultDir, tempFile;
        private string lastlog;
        private int loghow;

        public Form1()
        {
            defaultDir = @"D:\SecureFX\";
            tempFile = defaultDir + "TempLog.txt";
            lastlog = "";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                txtDir.Text = openFileDialog.FileName;
            }
        }

        private void btnGetAllLog_Click(object sender, EventArgs e)
        {
            if (File.Exists(tempFile))
                File.Delete(tempFile);
            lastlog = "";
            loghow = 0;
            GetFtpLog(loghow);
        }

        private void btnGetNowLog_Click(object sender, EventArgs e)
        {
            if (File.Exists(tempFile))
                File.Delete(tempFile);
            loghow = 1;
            GetFtpLog(loghow);
        }

        public void GetFtpLog(int loghow)
        {
            string allLog;
            txtResult.Text = "";
            File.Copy(txtDir.Text, tempFile);
            StreamReader readlog = new StreamReader(tempFile, Encoding.Default);
            allLog = readlog.ReadToEnd();
            if (allLog.Contains("00001: Attempting to connect to"))
            {
                allLog = allLog.Substring(allLog.LastIndexOf("00001: Attempting to connect to") - 32);
            }
            else
            {
                MessageBox.Show("Log 有問題請重開!");
                readlog.Close();
                return;
            }

            readlog.Close();
            StreamWriter writelog = new StreamWriter(tempFile, false);
            writelog.Write(allLog);
            writelog.Close();
            readlog = new StreamReader(tempFile, Encoding.Default);
            string sLine;
            List<string> Logs = new List<string>();
            List<string> Ip = new List<string>();
            while ((sLine = readlog.ReadLine()) != null)
            {
                if (sLine.Contains("Attempting to connect to"))
                {
                    Ip.Add(sLine);
                }
                if (sLine.Contains("Transfer"))
                {
                    if (sLine.Contains("SEND : Open:") || sLine.Contains("SUMMARY:") || sLine.Contains("Opening file"))
                        Logs.Add(sLine);
                }
            }
            readlog.Close();
            int i = 1;
            if (loghow == 1)
                Logs.RemoveRange(0, Logs.IndexOf(lastlog) + 1);
            foreach (var log in Logs)
            {
                i = 1;

                if (log.Contains("Transfer") && log.Contains("Opening file") || log.Contains("Transfer") && log.Contains("SEND : Open:"))
                {
                    if (lastlog.Contains("SUMMARY: Transferred") || lastlog.Equals(""))
                    {
                        while (i < 50)
                        {
                            if (log.Contains(i.ToString().PadLeft(5, '0') + ":"))
                            {
                                txtResult.AppendText(Ip[i - 1].Substring(53) + "\n");
                            }
                            i++;
                        }
                    }
                    txtResult.AppendText(log.Substring(0, 20) + log.Substring(48) + "\n");
                    lastlog = log;
                }

                if (log.Contains("SUMMARY: Transferred"))
                {
                    txtResult.AppendText(log.Substring(0, 20) + log.Substring(48) + "\n\n");

                    lastlog = log;
                }
            }
            string tmp;
            tmp = txtResult.Text;
            Clipboard.SetDataObject(tmp);
            File.Delete(tempFile);
            MessageBox.Show("Log產生成功!!");
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(txtDir.Text);
                MessageBox.Show("檔案已刪除");
            }
            catch (Exception)
            {
                MessageBox.Show("檔案不存在!");
            }
        }

        private void tsmiCut_Click(object sender, EventArgs e)
        {
            string tmp;
            tmp = txtResult.SelectedText;
            Clipboard.SetDataObject(tmp);
            this.txtResult.SelectedText = "";
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            string tmp;
            tmp = txtResult.SelectedText;
            Clipboard.SetDataObject(tmp);
        }

        private void tsmiPatse_Click(object sender, EventArgs e)
        {
            IDataObject obj;
            obj = Clipboard.GetDataObject();
            string tmp;
            tmp = obj.GetData(DataFormats.Text).ToString();

            this.txtResult.SelectedText = tmp;
        }

        private void btnUpdateFile_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(@"\\wnsp3r7cfis01\PRODUCT\Production Controller\AAZ\KevinUse\FTPUse.exe");
                File.Copy(@"C:\Users\wpcsb99\Documents\Visual Studio 2015\Projects\FTPUse\FTPUse\bin\Release\FTPUse.exe", @"\\wnsp3r7cfis01\PRODUCT\Production Controller\AAZ\KevinUse\FTPUse.exe");
                MessageBox.Show("更新成功!");
            }
            catch (Exception)
            {
                MessageBox.Show("Only for Kevin Use!");
            }
        }
    }
}