using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTRRando.Elements
{
    public static class NPCMind
    {
        static string start = "this.SetNPCMindType(\"";
        static string end = "\")";

        static List<string> items = new List<string>()
        {
            "Stationary",
            "EnemyGuard",
            "Ambient"
        };

        static List<string> items5 = new List<string>()
        {
            "this.SetNPCMindType(\"Stationary\")",
            "this.SetNPCMindType(\"Stationary\")",
            "this.SetNPCMindType(\"Stationary\")",
            "this.SetNPCMindType(\"Stationary\")",
            "this.SetNPCMindType(\"Stationary\")",
            "this.SetNPCMindType(\"Stationary\")",
            "this.SetNPCMindType(\"Stationary\")",
            "this.SetNPCMindType(\"Stationary\")",
            "this.SetNPCMindType(\"Stationary\")",
            "this.SetNPCMindType(\"Stationary\")",
            "this.SetNPCMindType(\"Stationary\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")",
            "this.SetNPCMindType(\"Ambient\")"
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

        private static List<string> ExportList5()
        {
            List<string> newList = new List<string>();

            foreach (string item in items5)
            {
                newList.Add(item);
            }

            return newList;
        }

        public static void Shuffle()
        {
            List<string> npcminds = new List<string>(ExportList());
            List<string> npcmindlines = new List<string>(ExportList());

            List<string> npcmindlines5 = new List<string>(ExportList5());
            npcmindlines5.Shuffle();


            Replacer.ReplaceRCF("onfoot.rcf", Files.onfoot[0].start, Replacer.ReplaceInstancesRandom(Files.onfoot[0], npcminds, npcmindlines), Files.onfoot[0].length);
            Replacer.ReplaceRCF("onfoot1.rcf", Files.onfoot1[0].start, Replacer.ReplaceInstancesRandom(Files.onfoot1[0], npcminds, npcmindlines), Files.onfoot1[0].length);
            Replacer.ReplaceRCF("onfoot2.rcf", Files.onfoot2[0].start, Replacer.ReplaceInstancesRandom(Files.onfoot2[0], npcminds, npcmindlines), Files.onfoot2[0].length);
            Replacer.ReplaceRCF("onfoot3.rcf", Files.onfoot3[0].start, Replacer.ReplaceInstancesRandom(Files.onfoot3[0], npcminds, npcmindlines), Files.onfoot3[0].length);
            Replacer.ReplaceRCF("onfoot5.rcf", Files.onfoot5[0].start, Replacer.ReplaceInstancesSetRandom(Files.onfoot5[0], npcmindlines5, npcmindlines), Files.onfoot5[0].length);
            Replacer.ReplaceRCF("onfoot6.rcf", Files.onfoot6[0].start, Replacer.ReplaceInstancesRandom(Files.onfoot6[0], npcminds, npcmindlines), Files.onfoot6[0].length);


        }
    }
}
