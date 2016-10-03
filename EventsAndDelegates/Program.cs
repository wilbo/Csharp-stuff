using System;
using System.Threading;

namespace ConsoleApplication
{

    // This program simulates the encoding of a video. Multiple messages are sent when de video is done encoding.

    public class Program
    {
        public static void Main(string[] args)
        {
            // the video & encoder
            Video video = new Video("Toy Story 3");
            VideoEncoder encoder = new VideoEncoder(); // publisher

            // the message services
            MailService mailService = new MailService(); 
            MessageService messageService = new MessageService();

            // subscribing to the "VideoEncoded" event
            encoder.VideoEncoded += mailService.OnVideoEncoded;
            encoder.VideoEncoded += messageService.OnVideoEncoded;

            // start encoding
            encoder.encode(video);
        }
    }

    // a basic video
    public class Video
    {
        public String Title { get; set; }
        public Video(String t) { this.Title = t; }
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {

        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        public void encode(Video v)
        {
            Console.WriteLine(" - Encoder: Encoding video ({0})...", v.Title);
            Thread.Sleep(3000);
            Console.WriteLine(" - Encoder: Video encoded.");
            
            OnVideoEncoded(v);
        }

        protected virtual void OnVideoEncoded(Video v)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs(){ Video = v });
            }
        }
    }


    // 
    // subscribers
    //

    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine(" - MailService: Sending an email ({0})...", e.Video.Title);
        }
    }

    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine(" - MessageService: Sending a text message ({0})...", e.Video.Title);
        }
    }
}
