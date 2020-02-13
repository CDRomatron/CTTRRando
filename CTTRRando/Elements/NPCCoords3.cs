using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTRRando.Elements
{
    public static class NPCCoords3
    {
        static string start = "this.SetHomeAxis(\"";
        static string end = "\")";

        static List<string> items = new List<string>()
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

            foreach (GODFile file in Files.onfoot3)
            {
                Replacer.ReplaceRCF("onfoot3.rcf", file.start, Replacer.ReplaceInstances(file, npccoords, npccoordlines), file.length);
            }

        }
    }
}
