using Microsoft.Win32;
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
using CTTRRando.Elements;
using CTTRRando.ISO;

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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if(checkBox.IsChecked == true)
            {
                Courses.Shuffle();
            }

            if(checkBox1.IsChecked == true)
            {
                Hubs.Shuffle();
            }

            if(checkBox2.IsChecked == true)
            {
                Unlocks.Shuffle();
            }

            if(checkBox3.IsChecked == true)
            {
                NPCCoords0.Shuffle();
                NPCCoords1.Shuffle();
                NPCCoords2.Shuffle();
                NPCCoords3.Shuffle();
                NPCCoords5.Shuffle();
                NPCCoords6.Shuffle();
            }

            if(checkBox4.IsChecked == true)
            {
                Minigames.Shuffle();
            }

            string[] delete = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.new");

            foreach (string file in delete)
            {
                File.Delete(file);
            }

            MessageBox.Show("Done!");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ISOExtractor.Run("Crash Tag Team Racing.iso");
            MessageBox.Show("Done!");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            ISOWriter.Run("Crash Tag Team Racing.iso", "Crash Tag Team Rando.iso");
            MessageBox.Show("Done!");
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
