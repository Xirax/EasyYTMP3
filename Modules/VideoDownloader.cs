using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YoutubeDownloader.Modules
{
    class VideoDownloader
    {
        private static string videoURL;
        private static YoutubeClient ytClient = new YoutubeClient();

        public static async Task<bool> downloadVideoAndAudioFile(string url, string filePath){
            videoURL = url;
            StreamManifest streamInfos = await getStreamInfos();
   
            try{
                IStreamInfo selectedDownloadStream = streamInfos.GetMuxedStreams().TryGetWithHighestVideoQuality();
                await ytClient.Videos.Streams.DownloadAsync(selectedDownloadStream, $"{filePath}");

                return true;
            }catch (Exception e){
                return false;
            }
        }

        public static async Task<bool> downloadVideoOnlyFile(string url, string filePath){
            videoURL = url;
            StreamManifest streamInfos = await getStreamInfos();

            try{
                IStreamInfo selectedDownloadStream = streamInfos.GetVideoOnlyStreams().Where(s => s.Container == Container.Mp4).GetWithHighestVideoQuality();
                await ytClient.Videos.Streams.DownloadAsync(selectedDownloadStream, $"{filePath}");

                return true;
            }catch (Exception e){
                return false;
            }
        }

        public static async Task<bool> downloadAudioOnlyFile(string url, string filePath){
            videoURL = url;
            StreamManifest streamInfos = await getStreamInfos();

            try{
                IStreamInfo selectedDownloadStream = streamInfos.GetAudioOnlyStreams().GetWithHighestBitrate();
                await ytClient.Videos.Streams.DownloadAsync(selectedDownloadStream, $"{filePath}");

                return true;
            }catch (Exception e){
                return false;
            }
        }

        private static async Task<StreamManifest> getStreamInfos(){
            var video = await ytClient.Videos.GetAsync(videoURL);
            var streamInfos = await ytClient.Videos.Streams.GetManifestAsync(videoURL);

            return streamInfos;
        }

        public static async Task<string> getVideoTitleFromURL(string url){
            var video = await ytClient.Videos.GetAsync(url);
            return video.Title;
        }
    }
}
