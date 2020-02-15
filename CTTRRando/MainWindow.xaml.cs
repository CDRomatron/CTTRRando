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
                Rewards.Shuffle();
            }

            if(checkBox3.IsChecked == true)
            {
                NPCCoords.Shuffle();
            }

            if(checkBox4.IsChecked == true)
            {
                Minigames.Shuffle();
            }

            if(checkBox5.IsChecked == true)
            {
                NPCMind.Shuffle();
            }

            if(checkBox6.IsChecked == true)
            {
                Unlocks.Shuffle();
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
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.DefaultExt = ".iso";
            dlg.Filter = "Gamecube ISO Files (*.iso)|*.iso";
            dlg.Title = "Select an unmodified copy of Crash Tag Team Racing (NTSC)";

            Nullable<bool> result = dlg.ShowDialog();

            if(result == true)
            {
                ISOExtractor.Run(dlg.FileName);
                MessageBox.Show("Done!");
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.DefaultExt = ".iso";
            ofd.Filter = "Gamecube ISO Files (*.iso)|*.iso";
            ofd.Title = "Select an unmodified copy of Crash Tag Team Racing (NTSC)";

            Nullable<bool> result = ofd.ShowDialog();

            if(result == true)
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.DefaultExt = ".iso";
                sfd.Filter = "Gamecube ISO Files (*.iso)|*.iso";
                sfd.Title = "Save new randomised ISO";

                Nullable<bool> result2 = sfd.ShowDialog();

                if(result2 == true)
                {
                    ISOWriter.Run(ofd.FileName, sfd.FileName);
                    MessageBox.Show("Done!");
                }
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
