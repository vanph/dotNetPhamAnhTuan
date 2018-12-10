using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var tester = new MediaTester();
            //var mp3 = new MP3Player();
            //var mp4 = new MP4Player();

            //var mp3Delegate = new MediaFunction(mp3.PlayMP3File);
            //var mp4Delegate = new MediaFunction(mp4.PlayMP4File);

            //tester.RunTest(mp3Delegate);
            //tester.RunTest(mp4Delegate);

            tester.RunTest(Hello);
            tester.RunTest(Bye);

            Console.ReadLine();
        }

        static int Hello()
        {
            Console.WriteLine("hello");

            return 0;
        }


        static int Bye()
        {
            Console.WriteLine("bye");

            return 1;
        }
    }
}
