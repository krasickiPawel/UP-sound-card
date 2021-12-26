
namespace KartaMuzycznaCore3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.labelFileInfo = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBoxPlayerType = new System.Windows.Forms.GroupBox();
            this.radioButtonDirectSound = new System.Windows.Forms.RadioButton();
            this.radioButtonActiveX = new System.Windows.Forms.RadioButton();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.buttonStopRecording = new System.Windows.Forms.Button();
            this.labelRecordedFileLocation = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.trackBarLeftRight = new System.Windows.Forms.TrackBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelLR = new System.Windows.Forms.Label();
            this.buttonPauseContinue = new System.Windows.Forms.Button();
            this.labelNowPlaying = new System.Windows.Forms.Label();
            this.labelMusicName = new System.Windows.Forms.Label();
            this.groupBoxPlayerType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeftRight)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonLoadFile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLoadFile.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonLoadFile.Location = new System.Drawing.Point(38, 45);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(138, 47);
            this.buttonLoadFile.TabIndex = 0;
            this.buttonLoadFile.Text = "Wczytaj plik";
            this.buttonLoadFile.UseVisualStyleBackColor = false;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadWAV_Click);
            // 
            // labelFileInfo
            // 
            this.labelFileInfo.AutoSize = true;
            this.labelFileInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFileInfo.Location = new System.Drawing.Point(38, 110);
            this.labelFileInfo.Name = "labelFileInfo";
            this.labelFileInfo.Size = new System.Drawing.Size(0, 20);
            this.labelFileInfo.TabIndex = 1;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonPlay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPlay.Location = new System.Drawing.Point(201, 45);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(138, 47);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Odtwarzaj";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonStop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStop.Location = new System.Drawing.Point(363, 45);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(138, 47);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Zakończ słuchanie";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // groupBoxPlayerType
            // 
            this.groupBoxPlayerType.Controls.Add(this.radioButtonDirectSound);
            this.groupBoxPlayerType.Controls.Add(this.radioButtonActiveX);
            this.groupBoxPlayerType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxPlayerType.Location = new System.Drawing.Point(549, 12);
            this.groupBoxPlayerType.Name = "groupBoxPlayerType";
            this.groupBoxPlayerType.Size = new System.Drawing.Size(204, 95);
            this.groupBoxPlayerType.TabIndex = 4;
            this.groupBoxPlayerType.TabStop = false;
            this.groupBoxPlayerType.Text = "Typ odtwarzacza WAV:";
            // 
            // radioButtonDirectSound
            // 
            this.radioButtonDirectSound.AutoSize = true;
            this.radioButtonDirectSound.Location = new System.Drawing.Point(6, 56);
            this.radioButtonDirectSound.Name = "radioButtonDirectSound";
            this.radioButtonDirectSound.Size = new System.Drawing.Size(112, 24);
            this.radioButtonDirectSound.TabIndex = 1;
            this.radioButtonDirectSound.TabStop = true;
            this.radioButtonDirectSound.Text = "DirectSound";
            this.radioButtonDirectSound.UseVisualStyleBackColor = true;
            this.radioButtonDirectSound.CheckedChanged += new System.EventHandler(this.radioButtonDirectSound_CheckedChanged);
            // 
            // radioButtonActiveX
            // 
            this.radioButtonActiveX.AutoSize = true;
            this.radioButtonActiveX.Checked = true;
            this.radioButtonActiveX.Location = new System.Drawing.Point(6, 26);
            this.radioButtonActiveX.Name = "radioButtonActiveX";
            this.radioButtonActiveX.Size = new System.Drawing.Size(80, 24);
            this.radioButtonActiveX.TabIndex = 0;
            this.radioButtonActiveX.TabStop = true;
            this.radioButtonActiveX.Text = "ActiveX";
            this.radioButtonActiveX.UseVisualStyleBackColor = true;
            this.radioButtonActiveX.CheckedChanged += new System.EventHandler(this.radioButtonActiveX_CheckedChanged);
            // 
            // buttonRecord
            // 
            this.buttonRecord.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonRecord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRecord.Location = new System.Drawing.Point(201, 120);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(138, 47);
            this.buttonRecord.TabIndex = 5;
            this.buttonRecord.Text = "Nagraj dźwięk";
            this.buttonRecord.UseVisualStyleBackColor = false;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // buttonStopRecording
            // 
            this.buttonStopRecording.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonStopRecording.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStopRecording.Location = new System.Drawing.Point(363, 120);
            this.buttonStopRecording.Name = "buttonStopRecording";
            this.buttonStopRecording.Size = new System.Drawing.Size(138, 47);
            this.buttonStopRecording.TabIndex = 6;
            this.buttonStopRecording.Text = "Zakończ nagranie";
            this.buttonStopRecording.UseVisualStyleBackColor = false;
            this.buttonStopRecording.Click += new System.EventHandler(this.buttonStopRecording_Click);
            // 
            // labelRecordedFileLocation
            // 
            this.labelRecordedFileLocation.AutoSize = true;
            this.labelRecordedFileLocation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRecordedFileLocation.Location = new System.Drawing.Point(549, 133);
            this.labelRecordedFileLocation.Name = "labelRecordedFileLocation";
            this.labelRecordedFileLocation.Size = new System.Drawing.Size(0, 20);
            this.labelRecordedFileLocation.TabIndex = 7;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(201, 220);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(300, 56);
            this.trackBarVolume.SmallChange = 5;
            this.trackBarVolume.TabIndex = 8;
            this.trackBarVolume.Value = 100;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // trackBarLeftRight
            // 
            this.trackBarLeftRight.Location = new System.Drawing.Point(201, 282);
            this.trackBarLeftRight.Maximum = 100;
            this.trackBarLeftRight.Minimum = -100;
            this.trackBarLeftRight.Name = "trackBarLeftRight";
            this.trackBarLeftRight.Size = new System.Drawing.Size(300, 56);
            this.trackBarLeftRight.SmallChange = 5;
            this.trackBarLeftRight.TabIndex = 9;
            this.trackBarLeftRight.Scroll += new System.EventHandler(this.trackBarLeftRight_Scroll);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelVolume.Location = new System.Drawing.Point(326, 197);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(59, 20);
            this.labelVolume.TabIndex = 10;
            this.labelVolume.Text = "Volume";
            // 
            // labelLR
            // 
            this.labelLR.AutoSize = true;
            this.labelLR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLR.Location = new System.Drawing.Point(337, 259);
            this.labelLR.Name = "labelLR";
            this.labelLR.Size = new System.Drawing.Size(31, 20);
            this.labelLR.TabIndex = 11;
            this.labelLR.Text = "L/R";
            // 
            // buttonPauseContinue
            // 
            this.buttonPauseContinue.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonPauseContinue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPauseContinue.Location = new System.Drawing.Point(603, 220);
            this.buttonPauseContinue.Name = "buttonPauseContinue";
            this.buttonPauseContinue.Size = new System.Drawing.Size(88, 77);
            this.buttonPauseContinue.TabIndex = 12;
            this.buttonPauseContinue.UseVisualStyleBackColor = false;
            this.buttonPauseContinue.Click += new System.EventHandler(this.buttonPauseContinue_Click);
            // 
            // labelNowPlaying
            // 
            this.labelNowPlaying.AutoSize = true;
            this.labelNowPlaying.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNowPlaying.Location = new System.Drawing.Point(38, 351);
            this.labelNowPlaying.Name = "labelNowPlaying";
            this.labelNowPlaying.Size = new System.Drawing.Size(129, 20);
            this.labelNowPlaying.TabIndex = 13;
            this.labelNowPlaying.Text = "Teraz odtwarzane:";
            // 
            // labelMusicName
            // 
            this.labelMusicName.AutoSize = true;
            this.labelMusicName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMusicName.Location = new System.Drawing.Point(174, 351);
            this.labelMusicName.Name = "labelMusicName";
            this.labelMusicName.Size = new System.Drawing.Size(0, 20);
            this.labelMusicName.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMusicName);
            this.Controls.Add(this.labelNowPlaying);
            this.Controls.Add(this.buttonPauseContinue);
            this.Controls.Add(this.labelLR);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.trackBarLeftRight);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.labelRecordedFileLocation);
            this.Controls.Add(this.buttonStopRecording);
            this.Controls.Add(this.buttonRecord);
            this.Controls.Add(this.groupBoxPlayerType);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.labelFileInfo);
            this.Controls.Add(this.buttonLoadFile);
            this.Name = "Form1";
            this.Text = "Odtwarzacz muzyki";
            this.groupBoxPlayerType.ResumeLayout(false);
            this.groupBoxPlayerType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeftRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Label labelFileInfo;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.GroupBox groupBoxPlayerType;
        private System.Windows.Forms.RadioButton radioButtonDirectSound;
        private System.Windows.Forms.RadioButton radioButtonActiveX;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Button buttonStopRecording;
        private System.Windows.Forms.Label labelRecordedFileLocation;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.TrackBar trackBarLeftRight;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelLR;
        private System.Windows.Forms.Button buttonPauseContinue;
        private System.Windows.Forms.Label labelNowPlaying;
        private System.Windows.Forms.Label labelMusicName;
    }
}

