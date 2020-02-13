using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTRRando.Elements
{
    public static class Hubs
    {
        static string start = "this.AddAction_ChangeLevel(\"onfoot_";
        static string end = "\",\"StartLocationFromMidway\")";

        static List<string> items = new List<string>()
        {
            "adventure",
            "fairy",
            "dino",
            "egypt",
            "solar"
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
            List<string> hubs = new List<string>(ExportList());
            hubs.Shuffle();

            List<string> hublines = new List<string>(ExportList());

            foreach (GODFile file in Files.objectives)
            {
                Replacer.ReplaceRCF("common.rcf", file.start, Replacer.ReplaceInstances(file, hubs, hublines), file.length);
            }

        }
    }
}
