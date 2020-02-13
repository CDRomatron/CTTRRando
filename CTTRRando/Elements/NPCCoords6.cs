using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTRRando.Elements
{
    public static class NPCCoords6
    {
        static string start = "this.SetHomeAxis(\"";
        static string end = "\")";

        static List<string> items = new List<string>()
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

            foreach (GODFile file in Files.onfoot6)
            {
                Replacer.ReplaceRCF("onfoot6.rcf", file.start, Replacer.ReplaceInstances(file, npccoords, npccoordlines), file.length);
            }

        }
    }
}
