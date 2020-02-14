using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTRRando.Elements
{
    public static class NPCCoords
    {
        static string start = "this.SetHomeAxis(\"";
        static string end = "\")";

        static List<string> items = new List<string>()
        {
            "neocortexlocation",
            "dronecrystal1",
            "dronecrystal2",
            "dronecortexskin",
            "dronecrashfedoraskin",
            "dronenegacrash",
            "HomeMiniGame02",
            "penguin01",
            "penguin01b",
            "penguin02",
            "penguin02b",
            "penguin02c"
            //"penguin03",
            //"penguin03",
        };

        static List<string> items1 = new List<string>()
        {
            "dronecaveskin",
            "dronecrystal1dino",
            "droneninaskin",
            "dronecrystal2dino",
            "dronecrystal3dino",
            "crunch2",
            "HomeMiniGame06",
            "penguin10",
            "penguin11",
            "penguin12",
            "penguin13",
            "penguin13b",
            "penguin13c",
            "penguin13d",
            "penguin13e",
            "penguin14",
            "penguin15",
            "penguin16",
            "penguin16b",
            "penguin16c",
            "penguin17",
            "penguin18",
            "penguin19",
            "penguin20",
            "penguin21",
            "penguin22",
            "penguin23",
            "penguin24",
            "penguin24b",
            "penguin24c",
            "penguin24d",
            "penguin24e",
            "penguin25",
            "penguin25b",
            "penguin25c",
            "penguin26",
            "penguin27",
            "penguin28",
            "penguin29",
            "penguin29b",
            "penguin29c",
            "penguin29d",
            "penguin29e",
            "penguin29f",
            "DinoChicken"
        };

        static List<string> items2 = new List<string>()
        {
            "HomeMiniGame09",
            "dronepasadenaskin",
            "dronecrunchskin",
            "dronecrystal1egypt",
            "dronecrystal2egypt",
            "dronecrystal3egypt",
            "dronemadcrashskinegypt",
            "penguin30",
            "penguin31",
            "penguin32",
            "penguin33",
            "penguin34",
            "penguin35",
            "penguin36",
            "penguin37",
            "penguin38",
            "penguin39",
            "penguin40",
            "penguin41",
            "penguin42",
            "penguin43",
            "penguin44",
            "penguin45",
            "penguin46",
            "penguin46b",
            "penguin46c",
            "penguin46d",
            "penguin46e",
            "penguin46f",
            "penguin46g",
            "penguin47",
            "penguin47b",
            "penguin47c",
            "penguin47d",
            "penguin47e",
            "penguin47f",
            "penguin47g",
            "EgyptChicken"
        };

        static List<string> items3 = new List<string>()
        {
            "dronecocoskin",
            "dronenginskin",
            "dronecrystal1fairy",
            "dronecrystal2fairy",
            "dronecrystal3fairy",
            "droneblacktieskin",
            "HomeMiniGame05",
            "penguin04",
            "penguin04b",
            "penguin04c",
            "penguin04d",
            "penguin05",
            "penguin05b",
            "penguin05c",
            "penguin06",
            "penguin07",
            "penguin07b",
            "penguin08",
            "penguin09",
            "penguin09b",
            "penguin09c",
            "FairyChicken"
        };

        static List<string> items5 = new List<string>()
        {
            "crunchcar1",
            "cortexlocation",
            "pasadenalocation",
            "nginlocation",
            "cocolocation",
            "ninalocation",
            "vonclutchlocator",
            "stewlocator",
            "chicklocator",
            "willielocator",
            "HomeGenericMale00",
            "HomeGenericMale02",
            "HomeGenericParkworker00",
            "HomeGenericParkworker06",
            "HomeGenericParkworker07",
            "HomeGenericParkworker08",
            "HomeGenericParkworker09",
            "HomeGenericParkworker10",
            "HomeGenericParkworker11",
            "HomeGenericParkworker12",
            "HomeGenericParkworker13",
            "HomeGenericParkworker14",
            "HomeGenericParkworker15",
            "HomeGenericParkworker16",
            "HomeGenericParkworker17",
            "HomeGenericParkworker18",
            "HomeGenericParkWorker99",
            "HomeGenericParkWorker100",
            "1_npc_01",
            "1_npc_02",
            "1_npc_03",
            "1_npc_04",
            "2_npc_01",
            "2_npc_02",
            "3_npc_01",
            "3_npc_02",
            "4_npc_01",
            "4_npc_02",
            "5_npc_01",
            "5_npc_02",
            "5_npc_03",
            "5_npc_04",
            "6_npc_01",
            "6_npc_02",
            "7_npc_01",
            "7_npc_02",
            "7_npc_03",
            "8_npc_01",
            "8_npc_03",
            "8_npc_04",
            "9_npc_01",
            "9_npc_02",
            "9_npc_03",
            "9_npc_04",
            "9_npc_05",
            "10_npc_01",
            "11_npc_01",
            "11_npc_02"
        };

        static List<string> items6 = new List<string>()
        {
            "HomeMiniGame10",
            "HomeMiniGame11",
            "dronecrashhiphopskin",
            "dronevonclutchskin",
            "dronecrystal1solar",
            "dronecrystal2solar",
            "dronecrystal3solar",
            "dronecrashskinsolar",
            "dronecrashkirksolar",
            "penguin48",
            "penguin49",
            "penguin50",
            "penguin51",
            "penguin52",
            "penguin53",
            "penguin54",
            "penguin55",
            "penguin56",
            "penguin57",
            "penguin58",
            "penguin59",
            "penguin60",
            "penguin61",
            "penguin62",
            "penguin63",
            "penguin64",
            "penguin65",
            "penguin66",
            "penguin67",
            "penguin68",
            "penguin69",
            "penguin70",
            "penguin71",
            "penguin72",
            "penguin73",
            "penguin73b",
            "penguin74",
            "penguin74b",
            "penguin74c",
            "penguin74d",
            "penguin74e",
            "penguin75",
            "SolarChicken"
        };

        public static List<string> ExportList(int number)
        {
            List<string> itemlist = new List<String>();
            switch(number)
            {
                case (0):
                    itemlist = items;
                    break;
                case (1):
                    itemlist = items1;
                    break;
                case (2):
                    itemlist = items2;
                    break;
                case (3):
                    itemlist = items3;
                    break;
                case (5):
                    itemlist = items5;
                    break;
                case (6):
                    itemlist = items6;
                    break;
            }
            List<string> newList = new List<string>();

            foreach (string item in itemlist)
            {
                newList.Add(start + item + end);
            }

            return newList;
        }

        public static void Shuffle()
        {
            for(int i=0; i<8; i++)
            {
                if(i!=4 && i==0)
                {
                    List<string> npccoords = new List<string>(ExportList(0));
                    List<string> npccoordlines = new List<string>(ExportList(0));

                    npccoords.Shuffle();

                    foreach (GODFile file in Files.onfoot)
                    {
                        Replacer.ReplaceRCF("onfoot.rcf", file.start, Replacer.ReplaceInstances(file, npccoords, npccoordlines), file.length);
                    }
                }
                else if(i!=4)
                {
                    List<string> npccoords = new List<string>(ExportList(i));
                    List<string> npccoordlines = new List<string>(ExportList(i));

                    npccoords.Shuffle();

                    List<GODFile> temp = new List<GODFile>();

                    switch(i)
                    {
                        case (1):
                            temp = Files.onfoot1;
                            break;
                        case (2):
                            temp = Files.onfoot2;
                            break;
                        case (3):
                            temp = Files.onfoot3;
                            break;
                        case (5):
                            temp = Files.onfoot5;
                            break;
                        case (6):
                            temp = Files.onfoot6;
                            break;
                    }

                    foreach (GODFile file in temp)
                    {
                        Replacer.ReplaceRCF("onfoot" + i + ".rcf", file.start, Replacer.ReplaceInstances(file, npccoords, npccoordlines), file.length);
                    }
                }
            }
            

        }
    }
}
