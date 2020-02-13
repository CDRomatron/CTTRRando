using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTRRando.Elements
{
    public static class Unlocks
    {
        static string start = "this.AddAction_UnlockCar(\"";
        static string end = ")";

        static List<string> items = new List<string>()
        {
            "crash\",1",
            "neocortex\",1",
            "pasadena\",1",
            "ngin\",1",
            "coco\",1",
            "crunch\",1",
            "nina\",1",
            "vonclutch\",1",
            "crash\",2",
            "coco\",2",
            "pasadena\",2",
            "ngin\",2",
            "nina\",2",
            "crunch\",2",
            "vonclutch\",2",
            "neocortex\",2",
            "crash\",3",
            "coco\",3",
            "crunch\",3",
            "pasadena\",3",
            "vonclutch\",3",
            "nina\",3",
            "neocortex\",3",
            "ngin\",3"
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
            List<string> unlocks = new List<string>(ExportList());
            unlocks.Shuffle();

            List<string> unlocklines = new List<string>(ExportList());

            while (unlocks[0].Length + unlocks[1].Length != unlocklines[0].Length + unlocklines[1].Length)
            {
                unlocks.Shuffle();
            }

            foreach (GODFile file in Files.objectives)
            {
                Replacer.ReplaceRCF("common.rcf", file.start, Replacer.ReplaceInstances(file, unlocks, unlocklines), file.length);
            }

        }
    }
}
