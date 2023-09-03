using ObserverPattern.Notifier;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var videoData = new VideoData();
            var email= new EmailNotifier(videoData);
            var phone= new PhoneNotifier(videoData);
            var youtube = new YoutubeNotifier(videoData);
            videoData.SetTitle("Observer Design Pattern");
            videoData.DetachObserver(youtube);
            Console.WriteLine("----------------------------------");
            videoData.SetDescription("Moan ne"); 

        }
    }
}