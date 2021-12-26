using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartaMuzycznaCore3
{
    public partial class Form1 : Form
    {
        readonly MusicCardController mcc = new MusicCardController();
        public Form1()
        {
            InitializeComponent();
            buttonStopRecording.Enabled = false;
            labelRecordedFileLocation.Text = "Lokalizacja nagrań:\nfolder z projektem";
            buttonPauseContinue.Text = "Zatrzymaj\n/\nWznów";
            labelNowPlaying.Visible = false;
        }

        private void buttonLoadWAV_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void LoadFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "WAV files (*.wav)|*.wav|MP3 files (.mp3)|*.mp3";

            if (dialog.ShowDialog() != DialogResult.OK) return;

            mcc.fileName = dialog.FileName;
            var fileInfo = mcc.HeaderInfo();

            labelFileInfo.Text = "";
            foreach (var info in fileInfo)
            {
                labelFileInfo.Text += (info.Key + ": " + info.Value + "\n");
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (mcc.fileName != "")
            {
                mcc.Play();
                labelNowPlaying.Visible = true;
                labelMusicName.Text = mcc.fileName;
            }
            else MessageBox.Show("Wybierz plik!", "Brak pliku do odtworzenia", MessageBoxButtons.OK);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            mcc.Stop();
            labelNowPlaying.Visible = false;
        }

        private void radioButtonActiveX_CheckedChanged(object sender, EventArgs e)
        {
            mcc.ChangePlayerType(MusicCardController.PlayerType.ACTIVEX);
        }

        private void radioButtonDirectSound_CheckedChanged(object sender, EventArgs e)
        {
            mcc.ChangePlayerType(MusicCardController.PlayerType.DIRECTSOUND);
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            buttonRecord.Enabled = false;
            mcc.StartRecording();
            buttonStopRecording.Enabled = true;
        }

        private void buttonStopRecording_Click(object sender, EventArgs e)
        {
            mcc.StopRecording();
            buttonRecord.Enabled = true;
            buttonStopRecording.Enabled = false;
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            mcc.ChangeVolume(trackBarVolume.Value);
        }

        private void trackBarLeftRight_Scroll(object sender, EventArgs e)
        {
            mcc.ChangeLR(trackBarLeftRight.Value);
        }

        private void buttonPauseContinue_Click(object sender, EventArgs e)
        {
            mcc.PauseContinue();
        }
    }
}
