using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeDownloader.Modules;

namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {

        private DownloaderSettings videoSettings;
        private List<Control> progressIndicators;
        private List<Control> readyIndicators;

        public Form1(){
            videoSettings = new DownloaderSettings();

            InitializeComponent();
            downloadTypeCombo.DataSource = Enum.GetValues(typeof(StreamType));
            selectFilePathButton.Text = videoSettings.filePath;

            progressIndicators = new List<Control>();
            progressIndicators.Add(downloadProgressBar);
            progressIndicators.Add(downloadingInfoLabel);

            readyIndicators = new List<Control>();
            readyIndicators.Add(readyInfoLabel);
            readyIndicators.Add(folderPicture);
        }

        private async void downloadButtonClick(object sender, EventArgs e){
            videoSettings.videoURL = videoURLInput.Text;
            videoSettings.fileName = fileNameInput.Text;
            downloadProgressBar.Visible = true;
            downloadingInfoLabel.Visible = true;

            ComponentHider.showElements(progressIndicators);
            ComponentHider.hideElements(readyIndicators);

            bool result = await videoSettings.downloadVideo();

            ComponentHider.hideElements(progressIndicators);
            ComponentHider.showElements(readyIndicators);
        }

        private void onTypeComboListChange(object sender, EventArgs e){
            videoSettings.streamType = (StreamType) downloadTypeCombo.SelectedItem;
        }

        private void selectFilePathButtonClick(object sender, EventArgs e){
            filePathDialog.ShowDialog();
            videoSettings.filePath = filePathDialog.SelectedPath;
            selectFilePathButton.Text = videoSettings.filePath;
        }

        private void onFileNameCheckBoxChange(object sender, EventArgs e){
            videoSettings.nameSameAsOnYt = fileNameCheckBox.Checked;
        }

        private void openExplorerAtDownloadLocation(object sender, EventArgs e){
            Process.Start(@"" + videoSettings.filePath);
        }
    }
}
