using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using YoutubeDownloader.Modules;

namespace YoutubeDownloader
{
    class DownloaderSettings
    {
        public string videoURL;
        public StreamType streamType;
        public string filePath;
        public string fileName;
        public bool nameSameAsOnYt;


        public DownloaderSettings(){
            filePath = "C:\\Users\\" + WindowsIdentity.GetCurrent().Name.Split('\\')[1] + "\\Downloads";
            fileName = "file";
            nameSameAsOnYt = false;
        }

        public async Task<bool> downloadVideo(){
            string fullPath = filePath;
            bool result;
  
            if (nameSameAsOnYt)
                fullPath += "\\" + await VideoDownloader.getVideoTitleFromURL(videoURL);
            else{
                setNameToNonExisting();
                fullPath += "\\" + fileName;
            }
         
            if (streamType == StreamType.VideoOnly)
                result = await VideoDownloader.downloadVideoOnlyFile(videoURL, fullPath + ".mp4");
            else if (streamType == StreamType.AudioOnly)
                result = await VideoDownloader.downloadAudioOnlyFile(videoURL, fullPath + ".mp3");
            else
                result = await VideoDownloader.downloadVideoAndAudioFile(videoURL, fullPath + ".mp4");

            return result;
        }

        private void setNameToNonExisting(){
            while (fileAlreadyExists())
                fileName += "1";
        }

        private bool fileAlreadyExists(){
            return File.Exists(filePath + "\\" + fileName + ".mp3") || File.Exists(filePath + "\\" + fileName + ".mp4");
        }
    }
}
