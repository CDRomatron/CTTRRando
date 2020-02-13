using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTRRando.Elements
{
    public static class NPCCoords2
    {
        static string start = "this.SetHomeAxis(\"";
        static string end = "\")";

        static List<string> items = new List<string>()
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

            foreach (GODFile file in Files.onfoot2)
            {
                Replacer.ReplaceRCF("onfoot2.rcf", file.start, Replacer.ReplaceInstances(file, npccoords, npccoordlines), file.length);
            }

        }
    }
}
