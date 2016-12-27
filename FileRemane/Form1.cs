using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace FileRemane
{
    public partial class Form1 : Form
    {
        public List<string> fileList = new List<string>();
        public string prefix = "DSC_";
        public string sub = ".JPG";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "請選擇資料夾";
            if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
            {
                txtPath.Text = dilog.SelectedPath ;

                lab_status.Text = "Reading";
                Debug.Write(txtPath.Text);

                //read all file
                DirectoryInfo di = new DirectoryInfo(txtPath.Text);

                foreach (var fi in di.GetFiles())
                {
                    Console.WriteLine(fi.Name);
                    txtFile.AppendText(fi.Name + "\n");
                    fileList.Add(fi.Name);
                }

                lab_status.Text = "read finished";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int start_number = Int32.Parse(txt_start_number.Text);
            foreach (string index in fileList)
            {
                File.Move(txtPath.Text + "\\" + index,
                    txtOutput.Text + "\\" + prefix + start_number.ToString("0000") + sub);
                start_number++;

            }

            lab_status.Text = "Done";
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "請選擇資料夾";
            if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
            {
                txtOutput.Text = dilog.SelectedPath;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
