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

        private void PopulateCourses(List<string> courselines)
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

        private void PopulateHubs(List<string> hublines)
        {
            hublines.Add("this.AddAction_ChangeLevel(\"onfoot_adventure\",\"StartLocationFromMidway\")");
            hublines.Add("this.AddAction_ChangeLevel(\"onfoot_fairy\",\"StartLocationFromMidway\")");
            hublines.Add("this.AddAction_ChangeLevel(\"onfoot_dino\",\"StartLocationFromMidway\")");
            hublines.Add("this.AddAction_ChangeLevel(\"onfoot_egypt\",\"StartLocationFromMidway\")");
            hublines.Add("this.AddAction_ChangeLevel(\"onfoot_solar\",\"StartLocationFromMidway\")");
        }

        private void PopulateMinigames(List<string> minigameslines)
        {
            minigameslines.Add("this.AddAction_UnlockMiniGame(\"OFMiniGames/MiniGameBowling1\")");
            minigameslines.Add("this.AddAction_UnlockMiniGame(\"OFMiniGames/MiniGameDucks1\")");
            minigameslines.Add("this.AddAction_UnlockMiniGame(\"OFMiniGames/MiniGameSkeets1\")");
            minigameslines.Add("this.AddAction_UnlockMiniGame(\"OFMiniGames/MiniGameFallingTargets1\")");
            minigameslines.Add("this.AddAction_UnlockMiniGame(\"OFMiniGames/MiniGameFloatingTargets1\")");
            minigameslines.Add("this.AddAction_UnlockMiniGame(\"OFMiniGames/MiniGameFallingTargets2\")");
            minigameslines.Add("this.AddAction_UnlockMiniGame(\"OFMiniGames/MiniGameBowling2\")");
            minigameslines.Add("this.AddAction_UnlockMiniGame(\"OFMiniGames/MiniGameFloatingTargets2\")");
        }

        private void PopulateUnlocks(List<string> unlocklines)
        {
            unlocklines.Add("this.AddAction_UnlockCar(\"crash\",1)");
            unlocklines.Add("this.AddAction_UnlockCar(\"neocortex\",1)");
            unlocklines.Add("this.AddAction_UnlockCar(\"pasadena\",1)");
            unlocklines.Add("this.AddAction_UnlockCar(\"ngin\",1)");
            unlocklines.Add("this.AddAction_UnlockCar(\"coco\",1)");
            unlocklines.Add("this.AddAction_UnlockCar(\"crunch\",1)");
            unlocklines.Add("this.AddAction_UnlockCar(\"nina\",1)");
            unlocklines.Add("this.AddAction_UnlockCar(\"vonclutch\",1)");
            unlocklines.Add("this.AddAction_UnlockCar(\"crash\",2)");
            unlocklines.Add("this.AddAction_UnlockCar(\"coco\",2)");
            unlocklines.Add("this.AddAction_UnlockCar(\"pasadena\",2)");
            unlocklines.Add("this.AddAction_UnlockCar(\"ngin\",2)");
            unlocklines.Add("this.AddAction_UnlockCar(\"nina\",2)");
            unlocklines.Add("this.AddAction_UnlockCar(\"crunch\",2)");
            unlocklines.Add("this.AddAction_UnlockCar(\"vonclutch\",2)");
            unlocklines.Add("this.AddAction_UnlockCar(\"neocortex\",2)");
            unlocklines.Add("this.AddAction_UnlockCar(\"crash\",3)");
            unlocklines.Add("this.AddAction_UnlockCar(\"coco\",3)");
            unlocklines.Add("this.AddAction_UnlockCar(\"crunch\",3)");
            unlocklines.Add("this.AddAction_UnlockCar(\"pasadena\",3)");
            unlocklines.Add("this.AddAction_UnlockCar(\"vonclutch\",3)");
            unlocklines.Add("this.AddAction_UnlockCar(\"nina\",3)");
            unlocklines.Add("this.AddAction_UnlockCar(\"neocortex\",3)");
            unlocklines.Add("this.AddAction_UnlockCar(\"ngin\",3)");
        }

        private void PopulateNPCCords0(List<string> npccoords)
        {
            npccoords.Add("this.SetHomeAxis(\"neocortexlocation\")");
            npccoords.Add("this.SetHomeAxis(\"dronecrystal1\")");
            npccoords.Add("this.SetHomeAxis(\"dronecrystal2\")");
            npccoords.Add("this.SetHomeAxis(\"dronecortexskin\")");
            npccoords.Add("this.SetHomeAxis(\"dronecrashfedoraskin\")");
            npccoords.Add("this.SetHomeAxis(\"dronenegacrash\")");
            npccoords.Add("this.SetHomeAxis(\"HomeMiniGame02\")");
            npccoords.Add("this.SetHomeAxis(\"penguin01\")");
            npccoords.Add("this.SetHomeAxis(\"penguin01b\")");
            npccoords.Add("this.SetHomeAxis(\"penguin02\")");
            npccoords.Add("this.SetHomeAxis(\"penguin02b\")");
            npccoords.Add("this.SetHomeAxis(\"penguin02c\")");
            //npccoords.Add("this.SetHomeAxis(\"penguin03\")");
            //npccoords.Add("this.SetHomeAxis(\"penguin03\")");
        }

        private void PopulateNPCCords1(List<string> npccoords)
        {
            npccoords.Add("this.SetHomeAxis(\"dronecaveskin\")");
            npccoords.Add("this.SetHomeAxis(\"dronecrystal1dino\")");
            npccoords.Add("this.SetHomeAxis(\"droneninaskin\")");
            npccoords.Add("this.SetHomeAxis(\"dronecrystal2dino\")");
            npccoords.Add("this.SetHomeAxis(\"dronecrystal3dino\")");
            npccoords.Add("this.SetHomeAxis(\"crunch2\")");
            npccoords.Add("this.SetHomeAxis(\"HomeMiniGame06\")");
            npccoords.Add("this.SetHomeAxis(\"penguin10\")");
            npccoords.Add("this.SetHomeAxis(\"penguin11\")");
            npccoords.Add("this.SetHomeAxis(\"penguin12\")");
            npccoords.Add("this.SetHomeAxis(\"penguin13\")");
            npccoords.Add("this.SetHomeAxis(\"penguin13b\")");
            npccoords.Add("this.SetHomeAxis(\"penguin13c\")");
            npccoords.Add("this.SetHomeAxis(\"penguin13d\")");
            npccoords.Add("this.SetHomeAxis(\"penguin13e\")");
            npccoords.Add("this.SetHomeAxis(\"penguin14\")");
            npccoords.Add("this.SetHomeAxis(\"penguin15\")");
            npccoords.Add("this.SetHomeAxis(\"penguin16\")");
            npccoords.Add("this.SetHomeAxis(\"penguin16b\")");
            npccoords.Add("this.SetHomeAxis(\"penguin16c\")");
            npccoords.Add("this.SetHomeAxis(\"penguin17\")");
            npccoords.Add("this.SetHomeAxis(\"penguin18\")");
            npccoords.Add("this.SetHomeAxis(\"penguin19\")");
            npccoords.Add("this.SetHomeAxis(\"penguin20\")");
            npccoords.Add("this.SetHomeAxis(\"penguin21\")");
            npccoords.Add("this.SetHomeAxis(\"penguin22\")");
            npccoords.Add("this.SetHomeAxis(\"penguin23\")");
            npccoords.Add("this.SetHomeAxis(\"penguin24\")");
            npccoords.Add("this.SetHomeAxis(\"penguin24b\")");
            npccoords.Add("this.SetHomeAxis(\"penguin24c\")");
            npccoords.Add("this.SetHomeAxis(\"penguin24d\")");
            npccoords.Add("this.SetHomeAxis(\"penguin24e\")");
            npccoords.Add("this.SetHomeAxis(\"penguin25\")");
            npccoords.Add("this.SetHomeAxis(\"penguin25b\")");
            npccoords.Add("this.SetHomeAxis(\"penguin25c\")");
            npccoords.Add("this.SetHomeAxis(\"penguin26\")");
            npccoords.Add("this.SetHomeAxis(\"penguin27\")");
            npccoords.Add("this.SetHomeAxis(\"penguin28\")");
            npccoords.Add("this.SetHomeAxis(\"penguin29\")");
            npccoords.Add("this.SetHomeAxis(\"penguin29b\")");
            npccoords.Add("this.SetHomeAxis(\"penguin29c\")");
            npccoords.Add("this.SetHomeAxis(\"penguin29d\")");
            npccoords.Add("this.SetHomeAxis(\"penguin29e\")");
            npccoords.Add("this.SetHomeAxis(\"penguin29f\")");
            npccoords.Add("this.SetHomeAxis(\"DinoChicken\")");
        }

        private void PopulateNPCCords2(List<string> npccoords)
        {
            npccoords.Add("this.SetHomeAxis(\"HomeMiniGame09\")");
            npccoords.Add("this.SetHomeAxis(\"dronepasadenaskin\")");
            npccoords.Add("this.SetHomeAxis(\"dronecrunchskin\")");
            npccoords.Add("this.SetHomeAxis(\"dronecrystal1egypt\")");
            npccoords.Add("this.SetHomeAxis(\"dronecrystal2egypt\")");
            npccoords.Add("this.SetHomeAxis(\"dronecrystal3egypt\")");
            npccoords.Add("this.SetHomeAxis(\"dronemadcrashskinegypt\")");
            npccoords.Add("this.SetHomeAxis(\"penguin30\")");
            npccoords.Add("this.SetHomeAxis(\"penguin31\")");
            npccoords.Add("this.SetHomeAxis(\"penguin32\")");
            npccoords.Add("this.SetHomeAxis(\"penguin33\")");
            npccoords.Add("this.SetHomeAxis(\"penguin34\")");
            npccoords.Add("this.SetHomeAxis(\"penguin35\")");
            npccoords.Add("this.SetHomeAxis(\"penguin36\")");
            npccoords.Add("this.SetHomeAxis(\"penguin37\")");
            npccoords.Add("this.SetHomeAxis(\"penguin38\")");
            npccoords.Add("this.SetHomeAxis(\"penguin39\")");
            npccoords.Add("this.SetHomeAxis(\"penguin40\")");
            npccoords.Add("this.SetHomeAxis(\"penguin41\")");
            npccoords.Add("this.SetHomeAxis(\"penguin42\")");
            npccoords.Add("this.SetHomeAxis(\"penguin43\")");
            npccoords.Add("this.SetHomeAxis(\"penguin44\")");
            npccoords.Add("this.SetHomeAxis(\"penguin45\")");
            npccoords.Add("this.SetHomeAxis(\"penguin46\")");
            npccoords.Add("this.SetHomeAxis(\"penguin46b\")");
            npccoords.Add("this.SetHomeAxis(\"penguin46c\")");
            npccoords.Add("this.SetHomeAxis(\"penguin46d\")");
            npccoords.Add("this.SetHomeAxis(\"penguin46e\")");
            npccoords.Add("this.SetHomeAxis(\"penguin46f\")");
            npccoords.Add("this.SetHomeAxis(\"penguin46g\")");
            npccoords.Add("this.SetHomeAxis(\"penguin47\")");
            npccoords.Add("this.SetHomeAxis(\"penguin47b\")");
            npccoords.Add("this.SetHomeAxis(\"penguin47c\")");
            npccoords.Add("this.SetHomeAxis(\"penguin47d\")");
            npccoords.Add("this.SetHomeAxis(\"penguin47e\")");
            npccoords.Add("this.SetHomeAxis(\"penguin47f\")");
            npccoords.Add("this.SetHomeAxis(\"penguin47g\")");
            npccoords.Add("this.SetHomeAxis(\"EgyptChicken\")");
        }

        private void PopulateNPCCords3(List<string> npccoords)
        {
            npccoords.Add("this.SetHomeAxis(\"dronecocoskin\")");
            npccoords.Add("this.SetHomeAxis(\"dronenginskin\")");
            npccoords.Add("this.SetHomeAxis(\"dronecrystal1fairy\")");
            npccoords.Add("this.SetHomeAxis(\"dronecrystal2fairy\")");
            npccoords.Add("this.SetHomeAxis(\"dronecrystal3fairy\")");
            npccoords.Add("this.SetHomeAxis(\"droneblacktieskin\")");
            npccoords.Add("this.SetHomeAxis(\"HomeMiniGame05\")");
            npccoords.Add("this.SetHomeAxis(\"penguin04\")");
            npccoords.Add("this.SetHomeAxis(\"penguin04b\")");
            npccoords.Add("this.SetHomeAxis(\"penguin04c\")");
            npccoords.Add("this.SetHomeAxis(\"penguin04d\")");
            npccoords.Add("this.SetHomeAxis(\"penguin05\")");
            npccoords.Add("this.SetHomeAxis(\"penguin05b\")");
            npccoords.Add("this.SetHomeAxis(\"penguin05c\")");
            npccoords.Add("this.SetHomeAxis(\"penguin06\")");
            npccoords.Add("this.SetHomeAxis(\"penguin07\")");
            npccoords.Add("this.SetHomeAxis(\"penguin07b\")");
            npccoords.Add("this.SetHomeAxis(\"penguin08\")");
            npccoords.Add("this.SetHomeAxis(\"penguin09\")");
            npccoords.Add("this.SetHomeAxis(\"penguin09b\")");
            npccoords.Add("this.SetHomeAxis(\"penguin09c\")");
            npccoords.Add("this.SetHomeAxis(\"FairyChicken\")");
        }

        private void PopulateNPCCords5(List<string> npccoords)
        {
            npccoords.Add("this.SetHomeAxis(\"crunchcar1\")");
            npccoords.Add("this.SetHomeAxis(\"cortexlocation\")");
            npccoords.Add("this.SetHomeAxis(\"pasadenalocation\")");
            npccoords.Add("this.SetHomeAxis(\"nginlocation\")");
            npccoords.Add("this.SetHomeAxis(\"cocolocation\")");
            npccoords.Add("this.SetHomeAxis(\"ninalocation\")");
            npccoords.Add("this.SetHomeAxis(\"vonclutchlocator\")");
            npccoords.Add("this.SetHomeAxis(\"stewlocator\")");
            npccoords.Add("this.SetHomeAxis(\"chicklocator\")");
            npccoords.Add("this.SetHomeAxis(\"willielocator\")");
            npccoords.Add("this.SetHomeAxis(\"HomeGenericMale00\")");
            npccoords.Add("this.SetHomeAxis(\"HomeGenericMale02\")");
            npccoords.Add("this.SetHomeAxis(\"HomeGenericParkworker00\")");
            npccoords.Add("this.SetHomeAxis(\"HomeGenericParkworker06\")");
            npccoords.Add("this.SetHomeAxis(\"HomeGenericParkworker07\")");
            npccoords.Add("this.SetHomeAxis(\"HomeGenericParkworker08\")");
            npccoords.Add("this.SetHomeAxis(\"HomeGenericParkworker09\")");
            npccoords.Add("this.SetHomeAxis(\"HomeGenericParkworker10\")");
            npccoords.Add("this.SetHomeAxis(\"HomeGenericParkworker11\")");
            npccoords.Add("this.SetHomeAxis(\"HomeGenericParkworker12\")");
            npccoords.Add("this.SetHomeAxis(\"HomeGenericParkworker13\")");
            npccoords.Add("this.SetHomeAxis(\"HomeGenericParkworker14\")");
            npccoords.Add("this.SetHomeAxis(\"HomeGenericParkworker15\")");
            npccoords.Add("this.SetHomeAxis(\"HomeGenericParkworker16\")");
            npccoords.Add("this.SetHomeAxis(\"HomeGenericParkworker17\")");
            npccoords.Add("this.SetHomeAxis(\"HomeGenericParkworker18\")");
            npccoords.Add("this.SetHomeAxis(\"HomeGenericParkWorker99\")");
            npccoords.Add("this.SetHomeAxis(\"HomeGenericParkWorker100\")");
            npccoords.Add("this.SetHomeAxis(\"1_npc_01\")");
            npccoords.Add("this.SetHomeAxis(\"1_npc_02\")");
            npccoords.Add("this.SetHomeAxis(\"1_npc_03\")");
            npccoords.Add("this.SetHomeAxis(\"1_npc_04\")");
            npccoords.Add("this.SetHomeAxis(\"2_npc_01\")");
            npccoords.Add("this.SetHomeAxis(\"2_npc_02\")");
            npccoords.Add("this.SetHomeAxis(\"3_npc_01\")");
            npccoords.Add("this.SetHomeAxis(\"3_npc_02\")");
            npccoords.Add("this.SetHomeAxis(\"4_npc_01\")");
            npccoords.Add("this.SetHomeAxis(\"4_npc_02\")");
            npccoords.Add("this.SetHomeAxis(\"5_npc_01\")");
            npccoords.Add("this.SetHomeAxis(\"5_npc_02\")");
            npccoords.Add("this.SetHomeAxis(\"5_npc_03\")");
            npccoords.Add("this.SetHomeAxis(\"5_npc_04\")");
            npccoords.Add("this.SetHomeAxis(\"6_npc_01\")");
            npccoords.Add("this.SetHomeAxis(\"6_npc_02\")");
            npccoords.Add("this.SetHomeAxis(\"7_npc_01\")");
            npccoords.Add("this.SetHomeAxis(\"7_npc_02\")");
            npccoords.Add("this.SetHomeAxis(\"7_npc_03\")");
            npccoords.Add("this.SetHomeAxis(\"8_npc_01\")");
            npccoords.Add("this.SetHomeAxis(\"8_npc_03\")");
            npccoords.Add("this.SetHomeAxis(\"8_npc_04\")");
            npccoords.Add("this.SetHomeAxis(\"9_npc_01\")");
            npccoords.Add("this.SetHomeAxis(\"9_npc_02\")");
            npccoords.Add("this.SetHomeAxis(\"9_npc_03\")");
            npccoords.Add("this.SetHomeAxis(\"9_npc_04\")");
            npccoords.Add("this.SetHomeAxis(\"9_npc_05\")");
            npccoords.Add("this.SetHomeAxis(\"10_npc_01\")");
            npccoords.Add("this.SetHomeAxis(\"11_npc_01\")");
            npccoords.Add("this.SetHomeAxis(\"11_npc_02\")");
        }

        private void PopulateNPCCords6(List<string> npccoords)
        {
            npccoords.Add("this.SetHomeAxis(\"HomeMiniGame10\")");
            npccoords.Add("this.SetHomeAxis(\"HomeMiniGame11\")");
            npccoords.Add("this.SetHomeAxis(\"dronecrashhiphopskin\")");
            npccoords.Add("this.SetHomeAxis(\"dronevonclutchskin\")");
            npccoords.Add("this.SetHomeAxis(\"dronecrystal1solar\")");
            npccoords.Add("this.SetHomeAxis(\"dronecrystal2solar\")");
            npccoords.Add("this.SetHomeAxis(\"dronecrystal3solar\")");
            npccoords.Add("this.SetHomeAxis(\"dronecrashskinsolar\")");
            npccoords.Add("this.SetHomeAxis(\"dronecrashkirksolar\")");
            npccoords.Add("this.SetHomeAxis(\"penguin48\")");
            npccoords.Add("this.SetHomeAxis(\"penguin49\")");
            npccoords.Add("this.SetHomeAxis(\"penguin50\")");
            npccoords.Add("this.SetHomeAxis(\"penguin51\")");
            npccoords.Add("this.SetHomeAxis(\"penguin52\")");
            npccoords.Add("this.SetHomeAxis(\"penguin53\")");
            npccoords.Add("this.SetHomeAxis(\"penguin54\")");
            npccoords.Add("this.SetHomeAxis(\"penguin55\")");
            npccoords.Add("this.SetHomeAxis(\"penguin56\")");
            npccoords.Add("this.SetHomeAxis(\"penguin57\")");
            npccoords.Add("this.SetHomeAxis(\"penguin58\")");
            npccoords.Add("this.SetHomeAxis(\"penguin59\")");
            npccoords.Add("this.SetHomeAxis(\"penguin60\")");
            npccoords.Add("this.SetHomeAxis(\"penguin61\")");
            npccoords.Add("this.SetHomeAxis(\"penguin62\")");
            npccoords.Add("this.SetHomeAxis(\"penguin63\")");
            npccoords.Add("this.SetHomeAxis(\"penguin64\")");
            npccoords.Add("this.SetHomeAxis(\"penguin65\")");
            npccoords.Add("this.SetHomeAxis(\"penguin66\")");
            npccoords.Add("this.SetHomeAxis(\"penguin67\")");
            npccoords.Add("this.SetHomeAxis(\"penguin68\")");
            npccoords.Add("this.SetHomeAxis(\"penguin69\")");
            npccoords.Add("this.SetHomeAxis(\"penguin70\")");
            npccoords.Add("this.SetHomeAxis(\"penguin71\")");
            npccoords.Add("this.SetHomeAxis(\"penguin72\")");
            npccoords.Add("this.SetHomeAxis(\"penguin73\")");
            npccoords.Add("this.SetHomeAxis(\"penguin73b\")");
            npccoords.Add("this.SetHomeAxis(\"penguin74\")");
            npccoords.Add("this.SetHomeAxis(\"penguin74b\")");
            npccoords.Add("this.SetHomeAxis(\"penguin74c\")");
            npccoords.Add("this.SetHomeAxis(\"penguin74d\")");
            npccoords.Add("this.SetHomeAxis(\"penguin74e\")");
            npccoords.Add("this.SetHomeAxis(\"penguin75\")");
            npccoords.Add("this.SetHomeAxis(\"SolarChicken\")");
        }


        private byte[] ReplaceInstances(ObjectiveFile file, List<string> replaceWith, List<string> replacing)
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
                        generic[i] = replaceWith[j];
                        flag = false;
                    }
                }

                if (i < generic.Length)
                {
                    output = output + generic[i] + '\n';
                }
            }

            if(replaceWith[0] == "DELETEME")
            {
                List<string> listgen = new List<string>(generic);
                List<string> newlist = new List<string>();
                for(int i = 0; i<listgen.Count; i++)
                {
                    if(listgen[i] != "DELETEME")
                    {
                        newlist.Add(listgen[i]);
                    }
                }

                generic = newlist.ToArray();
                output = "";
                for(int i = 0; i < generic.Length; i++)
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
            PopulateCourses(courselines);

            foreach(ObjectiveFile file in files)
            {
                ReplaceRCF("common.rcf", file.start, ReplaceInstances(file, courses, courselines), file.length); 
            }
            
        }

        private void ShuffleHubs(List<ObjectiveFile> files)
        {
            List<string> hubs = new List<string>();
            PopulateHubs(hubs);
            hubs.Shuffle();

            List<string> hublines = new List<string>();
            PopulateHubs(hublines);

            foreach (ObjectiveFile file in files)
            {
                ReplaceRCF("common.rcf", file.start, ReplaceInstances(file, hubs, hublines), file.length);
            }

        }

        private void ShuffleMinigames(List<ObjectiveFile> files)
        {
            List<string> minigames = new List<string>();
            PopulateMinigames(minigames);
            minigames.Shuffle();

            List<string> minigamelines = new List<string>();
            PopulateMinigames(minigamelines);

            

            foreach (ObjectiveFile file in files)
            {
                ReplaceRCF("common.rcf", file.start, ReplaceInstances(file, minigames, minigamelines), file.length);
            }

        }

        private void ShuffleUnlocks(List<ObjectiveFile> files)
        {
            List<string> unlocks = new List<string>();
            PopulateUnlocks(unlocks);
            unlocks.Shuffle();

            List<string> unlocklines = new List<string>();
            PopulateUnlocks(unlocklines);

            while (unlocks[0].Length + unlocks[1].Length != unlocklines[0].Length + unlocklines[1].Length)
            {
                unlocks.Shuffle();
            }

            foreach (ObjectiveFile file in files)
            {
                ReplaceRCF("common.rcf", file.start, ReplaceInstances(file, unlocks, unlocklines), file.length);
            }

        }

        private void ShuffleNPCCoords(List<ObjectiveFile> files, string rcf)
        {
            List<string> npccoords = new List<string>();
            List<string> npccoordlines = new List<string>();
            switch (rcf)
            {
                case "":
                    PopulateNPCCords0(npccoords);
                    PopulateNPCCords0(npccoordlines);
                    break;
                case "1":
                    PopulateNPCCords1(npccoords);
                    PopulateNPCCords1(npccoordlines);
                    break;
                case "2":
                    PopulateNPCCords2(npccoords);
                    PopulateNPCCords2(npccoordlines);
                    break;
                case "3":
                    PopulateNPCCords3(npccoords);
                    PopulateNPCCords3(npccoordlines);
                    break;
                case "5":
                    PopulateNPCCords5(npccoords);
                    PopulateNPCCords5(npccoordlines);
                    break;
                case "6":
                    PopulateNPCCords6(npccoords);
                    PopulateNPCCords6(npccoordlines);
                    break;
            }
   
            
            npccoords.Shuffle();

            foreach (ObjectiveFile file in files)
            {
                ReplaceRCF("onfoot" + rcf + ".rcf", file.start, ReplaceInstances(file, npccoords, npccoordlines), file.length);
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

            if(checkBox.IsChecked == true)
            {
                ShuffleCourses(files);
            }

            if(checkBox1.IsChecked == true)
            {
                ShuffleHubs(files);

            }

            if(checkBox2.IsChecked == true)
            {
                ShuffleUnlocks(files);
            }

            if(checkBox3.IsChecked == true)
            {
                List<ObjectiveFile> hub0 = new List<ObjectiveFile>();
                hub0.Add(new ObjectiveFile("NPC0.god", Convert.ToInt32(0x413000), Convert.ToInt32(0x1800)));
                ShuffleNPCCoords(hub0, "");

                List<ObjectiveFile> hub1 = new List<ObjectiveFile>();
                hub1.Add(new ObjectiveFile("NPC1.god", Convert.ToInt32(0x4D0800), Convert.ToInt32(0x2800)));
                ShuffleNPCCoords(hub1, "1");

                List<ObjectiveFile> hub2 = new List<ObjectiveFile>();
                hub2.Add(new ObjectiveFile("NPC2.god", Convert.ToInt32(0x4C3800), Convert.ToInt32(0x2800)));
                ShuffleNPCCoords(hub2, "2");

                List<ObjectiveFile> hub3 = new List<ObjectiveFile>();
                hub3.Add(new ObjectiveFile("NPC3.god", Convert.ToInt32(0x4B5800), Convert.ToInt32(0x1800)));
                ShuffleNPCCoords(hub3, "3");

                List<ObjectiveFile> hub5 = new List<ObjectiveFile>();
                hub5.Add(new ObjectiveFile("NPC5.god", Convert.ToInt32(0x4EC000), Convert.ToInt32(0x3000)));
                ShuffleNPCCoords(hub5, "5");

                List<ObjectiveFile> hub6 = new List<ObjectiveFile>();
                hub6.Add(new ObjectiveFile("NPC6.god", Convert.ToInt32(0x390000), Convert.ToInt32(0x2800)));
                ShuffleNPCCoords(hub6, "6");
            }

            if(checkBox4.IsChecked == true)
            {
                ShuffleMinigames(files);
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
            //create rcf files

            byte[] common = new byte[Convert.ToInt32(0x8FD17)];
            byte[] onfoot = new byte[Convert.ToInt32(0x251E600)];
            byte[] onfoot1 = new byte[Convert.ToInt32(0x2B1EFC0)];
            byte[] onfoot2 = new byte[Convert.ToInt32(0x17CA310)];
            byte[] onfoot3 = new byte[Convert.ToInt32(0x24BE0A0)];
            byte[] onfoot5 = new byte[Convert.ToInt32(0x2F9B840)];
            byte[] onfoot6 = new byte[Convert.ToInt32(0x13D3B70)];

            using (Stream stream = File.Open("Crash Tag Team Racing.iso", FileMode.Open))
            {
                stream.Position = Convert.ToInt32(0x1ADB882C);
                stream.Read(common, 0, common.Length);

                stream.Position = Convert.ToInt32(0x4622D438);
                stream.Read(onfoot, 0, onfoot.Length);

                stream.Position = Convert.ToInt32(0x4874BA38);
                stream.Read(onfoot1, 0, onfoot1.Length);

                stream.Position = Convert.ToInt32(0x4B26A9F8);
                stream.Read(onfoot2, 0, onfoot2.Length);

                stream.Position = Convert.ToInt32(0x4CA34D08);
                stream.Read(onfoot3, 0, onfoot3.Length);

                stream.Position = Convert.ToInt32(0x4EEF2DA8);
                stream.Read(onfoot5, 0, onfoot5.Length);

                stream.Position = Convert.ToInt32(0x51E8E5E8);
                stream.Read(onfoot6, 0, onfoot6.Length);
            }

            File.WriteAllBytes("common.rcf", common);
            File.WriteAllBytes("onfoot.rcf", onfoot);
            File.WriteAllBytes("onfoot1.rcf", onfoot1);
            File.WriteAllBytes("onfoot2.rcf", onfoot2);
            File.WriteAllBytes("onfoot3.rcf", onfoot3);
            File.WriteAllBytes("onfoot5.rcf", onfoot5);
            File.WriteAllBytes("onfoot6.rcf", onfoot6);

            //create god files

            byte[] generic = new byte[Convert.ToInt32(0x5800)];
            byte[] adventure = new byte[Convert.ToInt32(0x7000)];
            byte[] dino = new byte[Convert.ToInt32(0x7000)];
            byte[] egypt = new byte[Convert.ToInt32(0x6800)];
            byte[] fairy = new byte[Convert.ToInt32(0x6800)];
            byte[] midway = new byte[Convert.ToInt32(0x16800)];
            byte[] solar = new byte[Convert.ToInt32(0x7800)];

            using (Stream stream = File.Open("common.rcf", FileMode.Open))
            {
                stream.Position = Convert.ToInt32(0x48800);
                stream.Read(generic, 0, generic.Length);

                stream.Position = Convert.ToInt32(0x4E000);
                stream.Read(adventure, 0, adventure.Length);

                stream.Position = Convert.ToInt32(0x55000);
                stream.Read(dino, 0, dino.Length);

                stream.Position = Convert.ToInt32(0x5C000);
                stream.Read(egypt, 0, egypt.Length);

                stream.Position = Convert.ToInt32(0x62800);
                stream.Read(fairy, 0, fairy.Length);

                stream.Position = Convert.ToInt32(0x69000);
                stream.Read(midway, 0, midway.Length);

                stream.Position = Convert.ToInt32(0x7F800);
                stream.Read(solar, 0, solar.Length);
            }

            File.WriteAllBytes("genericobjectives.god", generic);
            File.WriteAllBytes("missionobjectives_adventure.god", adventure);
            File.WriteAllBytes("missionobjectives_dino.god", dino);
            File.WriteAllBytes("missionobjectives_egypt.god", egypt);
            File.WriteAllBytes("missionobjectives_fairy.god", fairy);
            File.WriteAllBytes("missionobjectives_midway.god", midway);
            File.WriteAllBytes("missionobjectives_solar.god", solar);

            List<ObjectiveFile> files = new List<ObjectiveFile>();
            files.Add(new ObjectiveFile("missionobjectives_adventure.god", Convert.ToInt32(0x4E000), Convert.ToInt32(0x7000)));
            files.Add(new ObjectiveFile("missionobjectives_dino.god", Convert.ToInt32(0x55000), Convert.ToInt32(0x7000)));
            files.Add(new ObjectiveFile("missionobjectives_egypt.god", Convert.ToInt32(0x5C000), Convert.ToInt32(0x6800)));
            files.Add(new ObjectiveFile("missionobjectives_fairy.god", Convert.ToInt32(0x62800), Convert.ToInt32(0x6800)));
            files.Add(new ObjectiveFile("missionobjectives_midway.god", Convert.ToInt32(0x69000), Convert.ToInt32(0x16800)));
            files.Add(new ObjectiveFile("missionobjectives_solar.god", Convert.ToInt32(0x7F800), Convert.ToInt32(0x7800)));

            List<string> replacing = new List<string>();
            PopulateCourses(replacing);
            List<string> replacewith = new List<string>();
            foreach(string course in replacing)
            {
                replacewith.Add("DELETEME");
            }
            foreach(ObjectiveFile file in files)
            {
                ReplaceRCF("common.rcf", file.start, ReplaceInstances(file, replacewith, replacing), file.length);
                
            }

            using (Stream stream = File.Open("common.rcf", FileMode.Open))
            {
                stream.Position = Convert.ToInt32(0x4E000);
                stream.Read(adventure, 0, adventure.Length);

                stream.Position = Convert.ToInt32(0x55000);
                stream.Read(dino, 0, dino.Length);

                stream.Position = Convert.ToInt32(0x5C000);
                stream.Read(egypt, 0, egypt.Length);

                stream.Position = Convert.ToInt32(0x62800);
                stream.Read(fairy, 0, fairy.Length);

                stream.Position = Convert.ToInt32(0x69000);
                stream.Read(midway, 0, midway.Length);

                stream.Position = Convert.ToInt32(0x7F800);
                stream.Read(solar, 0, solar.Length);
            }

            File.WriteAllBytes("missionobjectives_adventure.god", adventure);
            File.WriteAllBytes("missionobjectives_dino.god", dino);
            File.WriteAllBytes("missionobjectives_egypt.god", egypt);
            File.WriteAllBytes("missionobjectives_fairy.god", fairy);
            File.WriteAllBytes("missionobjectives_midway.god", midway);
            File.WriteAllBytes("missionobjectives_solar.god", solar);

            byte[] npc0 = new byte[Convert.ToInt32(0x1800)];
            byte[] npc1 = new byte[Convert.ToInt32(0x2800)];
            byte[] npc2 = new byte[Convert.ToInt32(0x2800)];
            byte[] npc3 = new byte[Convert.ToInt32(0x1800)];
            byte[] npc5 = new byte[Convert.ToInt32(0x3000)];
            byte[] npc6 = new byte[Convert.ToInt32(0x2800)];

            using (Stream stream = File.Open("onfoot.rcf", FileMode.Open))
            {
                stream.Position = Convert.ToInt32(0x413000);
                stream.Read(npc0, 0, npc0.Length);
            }

            using (Stream stream = File.Open("onfoot1.rcf", FileMode.Open))
            {
                stream.Position = Convert.ToInt32(0x4D0800);
                stream.Read(npc1, 0, npc1.Length);
            }

            using (Stream stream = File.Open("onfoot2.rcf", FileMode.Open))
            {
                stream.Position = Convert.ToInt32(0x4C3800);
                stream.Read(npc2, 0, npc2.Length);
            }

            using (Stream stream = File.Open("onfoot3.rcf", FileMode.Open))
            {
                stream.Position = Convert.ToInt32(0x4B5800);
                stream.Read(npc3, 0, npc3.Length);
            }

            using (Stream stream = File.Open("onfoot5.rcf", FileMode.Open))
            {
                stream.Position = Convert.ToInt32(0x4EC000);
                stream.Read(npc5, 0, npc5.Length);
            }

            using (Stream stream = File.Open("onfoot6.rcf", FileMode.Open))
            {
                stream.Position = Convert.ToInt32(0x390000);
                stream.Read(npc6, 0, npc6.Length);
            }

            File.WriteAllBytes("NPC0.god", npc0);
            File.WriteAllBytes("NPC1.god", npc1);
            File.WriteAllBytes("NPC2.god", npc2);
            File.WriteAllBytes("NPC3.god", npc3);
            File.WriteAllBytes("NPC5.god", npc5);
            File.WriteAllBytes("NPC6.god", npc6);

            string[] delete = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.new");

            foreach (string file in delete)
            {
                File.Delete(file);
            }

            MessageBox.Show("Done!");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            //write rcf files
            File.Copy("Crash Tag Team Racing.iso", "Crash Tag Team Rando.iso");

            byte[] common = File.ReadAllBytes("common.rcf");
            byte[] onfoot = File.ReadAllBytes("onfoot.rcf");
            byte[] onfoot1 = File.ReadAllBytes("onfoot1.rcf");
            byte[] onfoot2 = File.ReadAllBytes("onfoot2.rcf");
            byte[] onfoot3 = File.ReadAllBytes("onfoot3.rcf");
            byte[] onfoot5 = File.ReadAllBytes("onfoot5.rcf");
            byte[] onfoot6 = File.ReadAllBytes("onfoot6.rcf");

            using (Stream stream = File.Open("Crash Tag Team Rando.iso", FileMode.Open))
            {
                stream.Position = Convert.ToInt32(0x1ADB882C);
                stream.Write(common, 0, common.Length);

                stream.Position = Convert.ToInt32(0x4622D438);
                stream.Write(onfoot, 0, onfoot.Length);

                stream.Position = Convert.ToInt32(0x4874BA38);
                stream.Write(onfoot1, 0, onfoot1.Length);

                stream.Position = Convert.ToInt32(0x4B26A9F8);
                stream.Write(onfoot2, 0, onfoot2.Length);

                stream.Position = Convert.ToInt32(0x4CA34D08);
                stream.Write(onfoot3, 0, onfoot3.Length);

                stream.Position = Convert.ToInt32(0x4EEF2DA8);
                stream.Write(onfoot5, 0, onfoot5.Length);

                stream.Position = Convert.ToInt32(0x51E8E5E8);
                stream.Write(onfoot6, 0, onfoot6.Length);
            }

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
