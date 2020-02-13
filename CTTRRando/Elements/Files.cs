using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTRRando.Elements
{
    public static class Files
    {
        public static List<GODFile> objectives = new List<GODFile>()
        {
            new GODFile("genericobjectives.god", Convert.ToInt32(0x48800), Convert.ToInt32(0x5800)),
            new GODFile("missionobjectives_adventure.god", Convert.ToInt32(0x4E000), Convert.ToInt32(0x7000)),
            new GODFile("missionobjectives_dino.god", Convert.ToInt32(0x55000), Convert.ToInt32(0x7000)),
            new GODFile("missionobjectives_egypt.god", Convert.ToInt32(0x5C000), Convert.ToInt32(0x6800)),
            new GODFile("missionobjectives_fairy.god", Convert.ToInt32(0x62800), Convert.ToInt32(0x6800)),
            new GODFile("missionobjectives_midway.god", Convert.ToInt32(0x69000), Convert.ToInt32(0x16800)),
            new GODFile("missionobjectives_solar.god", Convert.ToInt32(0x7F800), Convert.ToInt32(0x7800))
        };

        public static List<GODFile> onfoot = new List<GODFile>()
        {
            new GODFile("NPC0.god", Convert.ToInt32(0x413000), Convert.ToInt32(0x1800))
        };

        public static List<GODFile> onfoot1 = new List<GODFile>()
        {
            new GODFile("NPC1.god", Convert.ToInt32(0x4D0800), Convert.ToInt32(0x2800))
        };

        public static List<GODFile> onfoot2 = new List<GODFile>()
        {
            new GODFile("NPC2.god", Convert.ToInt32(0x4C3800), Convert.ToInt32(0x2800))
        };

        public static List<GODFile> onfoot3 = new List<GODFile>()
        {
            new GODFile("NPC3.god", Convert.ToInt32(0x4B5800), Convert.ToInt32(0x1800))
        };

        public static List<GODFile> onfoot5 = new List<GODFile>()
        {
            new GODFile("NPC5.god", Convert.ToInt32(0x4EC000), Convert.ToInt32(0x3000))
        };

        public static List<GODFile> onfoot6 = new List<GODFile>()
        {
            new GODFile("NPC6.god", Convert.ToInt32(0x390000), Convert.ToInt32(0x2800))
        };
    }
}
