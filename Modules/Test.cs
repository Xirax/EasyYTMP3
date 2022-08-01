using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YoutubeDownloader
{
    class Test
    {
        public string URL;

        public async void getFromYt()
        {
            var youtube = new YoutubeClient();

            // You can specify both video ID or URL
            var video = await youtube.Videos.GetAsync("https://www.youtube.com/watch?v=bvC_0foemLY");

            var title = video.Title; // "Collections - Blender 2.80 Fundamentals"
            var author = video.Author.Title; // "Blender"
            var duration = video.Duration; // 00:07:20

            var streamManifest = await youtube.Videos.Streams.GetManifestAsync("https://www.youtube.com/watch?v=bvC_0foemLY");

            var streams = streamManifest.GetVideoStreams();
            var audio = streamManifest.GetAudioOnlyStreams();


            var streamInfo = streamManifest.GetVideoOnlyStreams().Where(s => s.Container == Container.Mp4).GetWithHighestVideoQuality();
            await youtube.Videos.Streams.DownloadAsync(streamInfo, $"D:\\video.mp4");

            foreach (var stream in streams)
            {
                Console.WriteLine(stream);
            }

            foreach(var ad in audio)
            {
                Console.WriteLine(ad);
            }


            Console.WriteLine(video);
            Console.WriteLine(streams);
        }
    }
}
