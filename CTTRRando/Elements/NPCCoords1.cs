using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTRRando.Elements
{
    public static class NPCCoords1
    {
        static string start = "this.SetHomeAxis(\"";
        static string end = "\")";

        static List<string> items = new List<string>()
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

        public static string get(int position)
        {
            return start + items[position] + end;
        }

        public static List<string> ExportList()
        {
            List<string> newList = new List<string>();

            foreach (string item in items)
            {
                newList.Add(start + item + end);
            }

            return newList;
        }

        public static void Shuffle()
        {
            List<string> npccoords = new List<string>(ExportList());
            List<string> npccoordlines = new List<string>(ExportList());

            npccoords.Shuffle();

            foreach (GODFile file in Files.onfoot1)
            {
                Replacer.ReplaceRCF("onfoot1.rcf", file.start, Replacer.ReplaceInstances(file, npccoords, npccoordlines), file.length);
            }

        }
    }
}
