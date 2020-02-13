using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTRRando.Elements
{
    public static class NPCCoords5
    {
        static string start = "this.SetHomeAxis(\"";
        static string end = "\")";

        static List<string> items = new List<string>()
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

            foreach (GODFile file in Files.onfoot5)
            {
                Replacer.ReplaceRCF("onfoot5.rcf", file.start, Replacer.ReplaceInstances(file, npccoords, npccoordlines), file.length);
            }

        }
    }
}
