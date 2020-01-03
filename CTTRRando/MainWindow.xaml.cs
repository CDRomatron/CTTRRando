using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CTTRRando
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static void ReplaceRCF(string filename, long position, byte[] data, int length)
        {

            byte[] output = new byte[length];

            for(int i=0;i<length;i++)
            {
                if (i < data.Length)
                {
                    output[i] = data[i];
                }
                else
                {
                    output[i] = 0x0;
                }
            }

            using (Stream stream = File.Open(filename, FileMode.Open))
            {
                stream.Position = position;
                stream.Write(output, 0, length);

            }
        }

        private void PopulateCourses(List<string> courses)
        {
            courses.Add("adventure1");
            courses.Add("adventure2");
            courses.Add("adventure3");
            courses.Add("fairy1");
            courses.Add("fairy2");
            courses.Add("fairy3");
            courses.Add("dino1");
            courses.Add("dino2");
            courses.Add("dino3");
            courses.Add("egypt1");
            courses.Add("egypt2");
            courses.Add("egypt3");
            courses.Add("solar1");
            courses.Add("solar2");
            courses.Add("solar3");
        }

        private void PopulateCourseLines(List<string> courselines)
        {
            courselines.Add("this.AddAction_UnlockRace(\"adventure1\")");
            courselines.Add("this.AddAction_UnlockRace(\"adventure2\")");
            courselines.Add("this.AddAction_UnlockRace(\"adventure3\")");
            courselines.Add("this.AddAction_UnlockRace(\"fairy1\")");
            courselines.Add("this.AddAction_UnlockRace(\"fairy2\")");
            courselines.Add("this.AddAction_UnlockRace(\"fairy3\")");
            courselines.Add("this.AddAction_UnlockRace(\"dino1\")");
            courselines.Add("this.AddAction_UnlockRace(\"dino2\")");
            courselines.Add("this.AddAction_UnlockRace(\"dino3\")");
            courselines.Add("this.AddAction_UnlockRace(\"egypt1\")");
            courselines.Add("this.AddAction_UnlockRace(\"egypt2\")");
            courselines.Add("this.AddAction_UnlockRace(\"egypt3\")");
            courselines.Add("this.AddAction_UnlockRace(\"solar1\")");
            courselines.Add("this.AddAction_UnlockRace(\"solar2\")");
            courselines.Add("this.AddAction_UnlockRace(\"solar3\")");
        }

        private void PopulateHubs(List<string> hubs)
        {
            hubs.Add("adventure");
            hubs.Add("fairy");
            hubs.Add("dino");
            hubs.Add("egypt");
            hubs.Add("solar");
        }

        private void PopulateHubLines(List<string> hublines)
        {
            hublines.Add("this.AddAction_ChangeLevel(\"onfoot_adventure\",\"StartLocationFromMidway\")");
            hublines.Add("this.AddAction_ChangeLevel(\"onfoot_fairy\",\"StartLocationFromMidway\")");
            hublines.Add("this.AddAction_ChangeLevel(\"onfoot_dino\",\"StartLocationFromMidway\")");
            hublines.Add("this.AddAction_ChangeLevel(\"onfoot_egypt\",\"StartLocationFromMidway\")");
            hublines.Add("this.AddAction_ChangeLevel(\"onfoot_solar\",\"StartLocationFromMidway\")");
        }


        private byte[] ReplaceInstances(ObjectiveFile file, List<string> replaceWith, List<string> replacing, string before, string after)
        {
            string[] generic = file.contentString;
            byte[] input = file.contentByte;

            string output = "";

            for (int i = 0; i < generic.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < replacing.Count; j++)
                {

                    if (generic[i] == replacing[j] && flag)
                    {
                        generic[i] = before + replaceWith[j] + after;
                        flag = false;
                    }
                }

                if (i < generic.Length)
                {
                    output = output + generic[i] + '\n';
                }
            }

            byte[] newgeneric = Encoding.UTF8.GetBytes(output);

            if(newgeneric.Length > input.Length)
            {
                Console.WriteLine(file.path + " became larger " + Convert.ToString(newgeneric.Length-input.Length));
            }
            else if(newgeneric.Length == input.Length)
            {
                Console.WriteLine(file.path + " did not change " + Convert.ToString(newgeneric.Length - input.Length));
            }
            else
            {
                Console.WriteLine(file.path + " became smaller " + Convert.ToString(newgeneric.Length - input.Length));
            }

            file.contentByte = newgeneric;
            file.reload(file.path + ".new");

            return newgeneric;

        }

        private void ShuffleCourses(List<ObjectiveFile> files)
        {
            List<string> courses = new List<string>();
            PopulateCourses(courses);
            courses.Shuffle();

            List<string> courselines = new List<string>();
            PopulateCourseLines(courselines);

            foreach(ObjectiveFile file in files)
            {
                ReplaceRCF("common.rcf", file.start, ReplaceInstances(file, courses, courselines, "this.AddAction_UnlockRace(\"", "\")"), file.length); 
            }
            
        }

        private void ShuffleHubs(List<ObjectiveFile> files)
        {
            List<string> hubs = new List<string>();
            PopulateHubs(hubs);
            hubs.Shuffle();

            List<string> hublines = new List<string>();
            PopulateHubLines(hublines);

            foreach (ObjectiveFile file in files)
            {
                ReplaceRCF("common.rcf", file.start, ReplaceInstances(file, hubs, hublines, "this.AddAction_ChangeLevel(\"onfoot_", "\",\"StartLocationFromMidway\")"), file.length);
            }

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            List<ObjectiveFile> files = new List<ObjectiveFile>();
            files.Add(new ObjectiveFile("genericobjectives.god", Convert.ToInt32(0x48800), Convert.ToInt32(0x5800)));
            files.Add(new ObjectiveFile("missionobjectives_adventure.god", Convert.ToInt32(0x4E000), Convert.ToInt32(0x7000)));
            files.Add(new ObjectiveFile("missionobjectives_dino.god", Convert.ToInt32(0x55000), Convert.ToInt32(0x7000)));
            files.Add(new ObjectiveFile("missionobjectives_egypt.god", Convert.ToInt32(0x5C000), Convert.ToInt32(0x6800)));
            files.Add(new ObjectiveFile("missionobjectives_fairy.god", Convert.ToInt32(0x62800), Convert.ToInt32(0x6800)));
            files.Add(new ObjectiveFile("missionobjectives_midway.god", Convert.ToInt32(0x69000), Convert.ToInt32(0x16800)));
            files.Add(new ObjectiveFile("missionobjectives_solar.god", Convert.ToInt32(0x7F800), Convert.ToInt32(0x7800)));

            ShuffleCourses(files);
            ShuffleHubs(files);

            string[] delete = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.new");

            foreach (string file in delete)
            {
                File.Delete(file);
            }
        }
    }

    public static class ThreadSafeRandom
    {
        [ThreadStatic] private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }

    static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
