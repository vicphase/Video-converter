using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
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

        private void NumericUpDownDuration_ValueChanged(object sender, EventArgs e)
        {
            if (VideoConvertidor.VideoFile != null)
            {
                if ((double) NumericUpDownDuration.Value > VideoConvertidor.Duration-VideoConvertidor.StartTimeCut)
                {
                    MessageBox.Show("You can´t assign that value");
                    NumericUpDownDuration.Value = 0;
                }
                else
                {
                    VideoConvertidor.DurationCut = (double)NumericUpDownDuration.Value;
                }
            }
        }

        private void RadioButton480_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton480.Checked)
            {
                VideoConvertidor.SizeVideo = VideoSize.Hd480;
            }
        }

        private void RadioButton180_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton720.Checked)
            {
                VideoConvertidor.SizeVideo = VideoSize.Hd720;
            }
        }

        private void RadioButton270_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1080.Checked)
            {
                VideoConvertidor.SizeVideo = VideoSize.Hd1080;
            }
        }

        private void numericUpDownFps_ValueChanged(object sender, EventArgs e)
        {
            VideoConvertidor.Fps = (int)numericUpDownFps.Value;
        }


        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Title = "Save your video";
            saveFileDialog1.Filter = "Video Files|*" + VideoConvertidor.NewExtension;
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                    File.Delete(saveFileDialog1.FileName);
                    VideoConvertidor.SaveFilePath = saveFileDialog1.FileName;
                }
            }
            LabelDownloadFinished.Text = "Your video is being converted, please wait";
            VideoConvertidor.convertVideo();
            LabelDownloadFinished.Text = "Your video file has been converted";
        }

        private void ButtonCheckStatus_Click(object sender, EventArgs e)
        {

            MessageBox.Show(VideoConvertidor.toString());
        }

    }
}
