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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            List<string> courses = new List<string>();
            PopulateCourses(courses);

            List<string> courselines = new List<string>();
            PopulateCourseLines(courselines);


            List<string> hubs = new List<string>();
            PopulateHubs(hubs);

            courses.Shuffle();
            hubs.Shuffle();

            string[] generic = File.ReadAllLines("C:\\Users\\short\\OneDrive\\Documents\\CTTR2\\genericobjectives.god");

            for(int i=0; i<generic.Length; i++)
            {
                bool flag = true;
                for(int j=0;j<courselines.Count;j++)
                {
     
                    if(generic[i] == courselines[j] && flag)
                    {
                        generic[i] = "this.AddAction_UnlockRace(\"" + courses[j] + "\")";
                        flag = false;
                    }
                }

                Console.WriteLine(generic[i]);
            }
            Console.WriteLine("");
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
