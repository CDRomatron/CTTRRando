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
using System.Text.RegularExpressions;

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

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if(textBox.Text != "")
            {
                GlobalRandom.rnd = new Random(Convert.ToInt32(textBox.Text));
            }

            if(checkBox.IsChecked == true)
            {
                Courses.Shuffle();
            }

            if(checkBox1.IsChecked == true)
            {
                Hubs.Shuffle(checkBox7.IsChecked ?? false);
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

    public static class GlobalRandom
    {
        public static Random rnd = new Random();
    }

    static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = GlobalRandom.rnd.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
