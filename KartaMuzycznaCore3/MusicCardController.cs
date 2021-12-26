using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace KartaMuzycznaCore3
{
    class MusicCardController
    {
        public string fileName = "";
        SoundPlayer wavPlayer = new SoundPlayer();
        WMPLib.WindowsMediaPlayer mp3player = new WMPLib.WindowsMediaPlayer();
        DirectSoundOut wavPlayerDirectSound = null;
        WaveIn recorder = null;
        WaveFileWriter fileWriter = null;

        public enum PlayerType
        {
            ACTIVEX,
            DIRECTSOUND
        }
        PlayerType playerType = PlayerType.ACTIVEX;

        public Dictionary<string, string> HeaderInfo()
        {
            var fileInfo = new Dictionary<string, string>();
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            if (fileName.Contains(".wav"))
            {
                fs.Position = 8;
                fileInfo.Add("format", new string(br.ReadChars(4)));

                fs.Position = 22;
                fileInfo.Add("channels", br.ReadInt16().ToString());

                fs.Position = 24;
                fileInfo.Add("sample rate", br.ReadInt32().ToString());

                fs.Position = 34;
                fileInfo.Add("bits per sample", br.ReadInt16().ToString());

            }
            else if (fileName.Contains(".mp3"))
            {
                var bits = new BitArray(br.ReadBytes(4));
                List<string> bitList = new List<string>();

                for(int i = 0; i < bits.Length; i++)
                {
                    if (bits[i]) bitList.Add("1");
                    else bitList.Add("0");

                }

                var mpegVerstion = bitList[19] + bitList[20];

                switch (mpegVerstion)
                {
                    case "00":
                        {
                            mpegVerstion = "2.5";
                            break;
                        }
                    case "01":
                        {
                            mpegVerstion = "reserved";
                            break;
                        }
                    case "10":
                        {
                            mpegVerstion = "2";
                            break;
                        }
                    case "11":
                        {
                            mpegVerstion = "1";
                            break;
                        }
                }

                fileInfo.Add("MPEG Version", mpegVerstion);

                var layer = bitList[17] + bitList[18];

                switch (layer)
                {
                    case "00":
                        {
                            layer = "reserved";
                            break;
                        }
                    case "01":
                        {
                            layer = "L3";
                            break;
                        }
                    case "10":
                        {
                            layer = "L2";
                            break;
                        }
                    case "11":
                        {
                            layer = "L1";
                            break;
                        }
                }

                fileInfo.Add("Layer", layer);

                var channelMode = bitList[6] + bitList[7];

                switch (channelMode)
                {
                    case "00":
                        {
                            channelMode = "stereo";
                            break;
                        }
                    case "01":
                        {
                            channelMode = "joint stereo";
                            break;
                        }
                    case "10":
                        {
                            channelMode = "2 mono";
                            break;
                        }
                    case "11":
                        {
                            channelMode = "mono";
                            break;
                        }
                }

                fileInfo.Add("channel mode", channelMode);

                fileInfo.Add("frequency index", bitList[10] + bitList[11]);

                fileInfo.Add("bitrate index", bitList[12] + bitList[13] + bitList[14] + bitList[15]);

            }

            return fileInfo;
        }

        public void Play()
        {
            if (fileName.Contains(".mp3"))
            {
                PlayMP3();
            }
            else if(fileName.Contains(".wav"))
            {
                PlayWAV();
            }

        }

        private void PlayWAV()
        {
            switch (playerType)
            {
                case PlayerType.ACTIVEX:
                    {
                        wavPlayer.SoundLocation = fileName;
                        wavPlayer.Play();
                        break;
                    }
                case PlayerType.DIRECTSOUND:
                    {
                        WaveChannel32 wave = new WaveChannel32(new WaveFileReader(fileName));
                        wavPlayerDirectSound = new DirectSoundOut();
                        wavPlayerDirectSound.Init(wave);
                        wavPlayerDirectSound.Play();
                        break;
                    }
            }
        }

        private void PlayMP3()
        {
            mp3player.URL = fileName;
            mp3player.controls.play();
        }

        public void ChangePlayerType(PlayerType playerType)
        {
            this.playerType = playerType;
        }

        public void Stop()
        {
            wavPlayer.Stop();
            mp3player.controls.stop();
            if(wavPlayerDirectSound != null)
            {
                wavPlayerDirectSound.Stop();
                wavPlayerDirectSound = null;
            }

        }

        public void StartRecording()
        {
            recorder = new WaveIn();
            recorder.WaveFormat = new WaveFormat(44100, 1);
            recorder.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
            recorder.RecordingStopped += new EventHandler<StoppedEventArgs>(waveSource_RecordingStopped);

            string currentDate = DateTime.Now.ToString();
            currentDate = currentDate.Replace(".", "_");
            currentDate = currentDate.Replace(" ", "_");
            currentDate = currentDate.Replace(":", "_");
            string recordFile = "audio" + currentDate + ".wav";
            fileWriter = new WaveFileWriter(recordFile, recorder.WaveFormat);
            recorder.StartRecording();
        }

        private void waveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            if(fileWriter != null)
            {
                fileWriter.Write(e.Buffer, 0, e.BytesRecorded);
                fileWriter.Flush();
            }
        }

        private void waveSource_RecordingStopped(object sender, StoppedEventArgs e)
        {
            recorder.Dispose();
            recorder = null;
            fileWriter.Dispose();
            fileWriter = null;
        }

        public void StopRecording()
        {
            if(recorder != null) recorder.StopRecording();
        }

        public void ChangeLR(int valLR)
        {
            if (mp3player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                mp3player.settings.balance = valLR;
        }
        
        public void ChangeVolume(int volume)
        {
            if(mp3player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                mp3player.settings.volume = volume;
        }

        public void PauseContinue()
        {
            if (mp3player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                mp3player.controls.pause();
            else if (mp3player.playState == WMPLib.WMPPlayState.wmppsPaused)
                mp3player.controls.play();
            if(wavPlayerDirectSound != null)
            {
                if (wavPlayerDirectSound.PlaybackState == PlaybackState.Playing)
                    wavPlayerDirectSound.Pause();
                else if (wavPlayerDirectSound.PlaybackState == PlaybackState.Paused)
                    wavPlayerDirectSound.Play();
            }

        }
    }
}
