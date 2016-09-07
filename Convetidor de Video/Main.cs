using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convetidor_de_Video
{
    public partial class MainForm : Form
    {

        Convertidor VideoConvertidor = new Convertidor();

        public MainForm()
        {
            InitializeComponent();
        }


        //Event to read the file and get the path
        private void ButtonSelectFile_Click(object sender, EventArgs e)
        {

            MediaFile inputFile = new MediaFile();
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Video File";
            openFileDialog.Filter = "Video files|*.mp4;*.mov;*.avi|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            //String variable with the file path
                            VideoConvertidor.OpenFilePath = Path.GetFullPath(openFileDialog.FileName);
                            VideoConvertidor.Extension = Path.GetExtension(openFileDialog.FileName);
                            VideoConvertidor.VideoFile = new MediaFile();
                            VideoConvertidor.VideoFile.Filename = VideoConvertidor.OpenFilePath;
                            LabelFileName.Text = "Your file is: "+ inputFile.Filename;
                            VideoConvertidor.setMetaData();
                            VideoConvertidor.setDuration();
                            LabelFileName.Text = "Your file is: \n"+VideoConvertidor.OpenFilePath;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void RadioButtonMp4_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonMp4.Checked && VideoConvertidor.VideoFile!=null)
            {
                if (VideoConvertidor.Extension.Equals(".mp4"))
                {
                    MessageBox.Show("This video is mp4 already");
                    RadioButtonMp4.Checked = false;
                }
                else
                {
                    VideoConvertidor.NewExtension = ".mp4";
                }
            }
        }

        private void RadioButtonMov_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonMov.Checked && VideoConvertidor.VideoFile != null)
            {
                if (VideoConvertidor.Extension.Equals(".mov"))
                {
                    MessageBox.Show("This video is mov already");
                    RadioButtonMov.Checked = false;
                }
                else
                {
                    VideoConvertidor.NewExtension = ".mov";
                }
            }
        }

        private void RadioButtonAvi_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonAvi.Checked && VideoConvertidor.VideoFile != null)
            {
                if (VideoConvertidor.Extension.Equals(".avi"))
                {
                    MessageBox.Show("This video is avi already");
                    RadioButtonAvi.Checked = false;
                }
                else
                {
                    VideoConvertidor.NewExtension = ".avi";
                }
            }
        }

        private void NumericUpDownStart_ValueChanged(object sender, EventArgs e)
        {
            if(VideoConvertidor.VideoFile != null)
            {
                if ((double) NumericUpDownStart.Value > VideoConvertidor.Duration)
                {
                    MessageBox.Show("You can´t assign that value");
                    NumericUpDownStart.Value = 0;
                }
                else
                {
                    VideoConvertidor.StartTimeCut = (double)NumericUpDownStart.Value;
                }
            }
        }
    }
}
