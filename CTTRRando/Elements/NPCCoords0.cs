using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTRRando.Elements
{
    public static class NPCCoords0
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

            foreach (GODFile file in Files.onfoot)
            {
                Replacer.ReplaceRCF("onfoot.rcf", file.start, Replacer.ReplaceInstances(file, npccoords, npccoordlines), file.length);
            }

        }
    }
}
