using System;
using System.IO;

namespace Hindeline5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What file would you like to move to fruit folder?");
            string userinput = Console.ReadLine();
            MoveFruitfile(userinput);
            
        }
        public static void MoveFruitfile(string Userinput)
        {
            string rootpath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string destinationpath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            string Fullfilename = $"{Userinput}.txt";
            string txt = $@"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit\{Fullfilename}";
            string[] time = new string[1];
            time[0] = DateTime.Now.ToShortTimeString();
            if (File.Exists(Path.Combine(rootpath, Fullfilename)))
            {
                File.Move(Path.Combine(rootpath, Fullfilename), Path.Combine(destinationpath, Fullfilename));
                File.WriteAllLines(txt, time);
                Console.WriteLine("File moved!");
            }else
            {
                Console.WriteLine("File not found!");
            }
        }
        public static void Movevegetalefile(string Userinput)
        {
            string rootpath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string destinationpath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetable";
            string Fullfilename = $"{Userinput}.txt";
            string txt = $@"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\Vegetable\{Fullfilename}";
            DateTime utc = DateTime.UtcNow;
            string[] time = new string[1];
            time[0] = utc.ToShortDateString();
            if (File.Exists(Path.Combine(rootpath, Fullfilename)))
            {
                File.Move(Path.Combine(rootpath, Fullfilename), Path.Combine(destinationpath, Fullfilename));
                File.WriteAllLines(txt, time);
                Console.WriteLine("File moved!");
            }
            else
            {
                Console.WriteLine("File not found!");
            }

        }public static void DeleteVegetablefile()
        {
            string destinationpath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetable";

        }

    }
}
