using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTRRando.Elements
{
    public static class Minigames
    {
        static string start = "this.AddAction_UnlockMiniGame(\"OFMiniGames/MiniGame";
        static string end = "\")";

        static List<string> items = new List<string>()
        {
            "Bowling1",
            "Ducks1",
            "Skeets1",
            "FallingTargets1",
            "FloatingTargets1",
            "FallingTargets2",
            "Bowling2",
            "FloatingTargets2"
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
            List<string> minigames = new List<string>(ExportList());
            minigames.Shuffle();

            List<string> minigamelines = new List<string>(ExportList());

            foreach (GODFile file in Files.objectives)
            {
                Replacer.ReplaceRCF("common.rcf", file.start, Replacer.ReplaceInstances(file, minigames, minigamelines), file.length);
            }

        }
    }
}
