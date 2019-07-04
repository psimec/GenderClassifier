using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pythontest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void getGender(string imgPath)
        {
            string fileName = @"./pythontest/python/label_image.py --graph=./pythontest/python/tmp/output_graph.pb --labels=./pythontest/python/tmp/output_labels.txt --input_layer=Placeholder --output_layer=final_result --image=" + imgPath;

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("python", fileName)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            p.Start();

            uiShowResult.Text = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
        }

        private void setImage(string imgPath, string imgName, string type)
        {
            string fileName = @"./pythontest/python/face_recognition.py " + imgPath + " " + type;

            Process p = new Process();

            p.StartInfo = new ProcessStartInfo("python", fileName)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            p.Start();

            uiShowResult.Text = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            uiShowPicture.Image = new Bitmap(@"./pythontest/tmp/" + imgName);          
        }

        private void uiActionChoosePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = fd.FileName;
                string fileName = Path.GetFileName(selectedPath);
                try
                {
                    setImage(selectedPath, fileName, "img");
                    getGender(selectedPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Potreban je Python 3.6");
                }
            }
        }
    }
}
