using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTTRRando.Elements;

namespace CTTRRando.ISO
{
    public static class ISOExtractor
    {
        static byte[] ReplaceInstances(GODFile file, List<string> replaceWith, List<string> replacing)
        {
            string[] generic = file.contentString;

            for (int i = 0; i < replaceWith.Count; i++)
            {
                Console.WriteLine(replacing[i] + " --> " + replaceWith[i]);
            }

            string output = "";

            for (int i = 0; i < generic.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < replacing.Count; j++)
                {

                    if (generic[i] == replacing[j] && flag)
                    {
                        generic[i] = replaceWith[j];
                        flag = false;
                    }
                }

                if (i < generic.Length)
                {
                    output = output + generic[i] + '\n';
                }
            }

            if (replaceWith[0] == "DELETEME")
            {
                List<string> listgen = new List<string>(generic);
                List<string> newlist = new List<string>();
                for (int i = 0; i < listgen.Count; i++)
                {
                    if (listgen[i] != "DELETEME")
                    {
                        newlist.Add(listgen[i]);
                    }
                }

                generic = newlist.ToArray();
                output = "";
                for (int i = 0; i < generic.Length; i++)
                {
                    output = output + generic[i] + '\n';
                }
            }

            byte[] newgeneric = Encoding.UTF8.GetBytes(output);

            file.contentByte = newgeneric;
            file.reload(file.path + ".new");

            return newgeneric;

        }


        public static void Run(string iso)
        {
            //create rcf files

            byte[] common = new byte[Convert.ToInt32(0x8FD17)];
            byte[] onfoot = new byte[Convert.ToInt32(0x251E600)];
            byte[] onfoot1 = new byte[Convert.ToInt32(0x2B1EFC0)];
            byte[] onfoot2 = new byte[Convert.ToInt32(0x17CA310)];
            byte[] onfoot3 = new byte[Convert.ToInt32(0x24BE0A0)];
            byte[] onfoot5 = new byte[Convert.ToInt32(0x2F9B840)];
            byte[] onfoot6 = new byte[Convert.ToInt32(0x13D3B70)];

            using (Stream stream = File.Open(iso, FileMode.Open))
            {
                stream.Position = Convert.ToInt32(0x1ADB882C);
                stream.Read(common, 0, common.Length);

                stream.Position = Convert.ToInt32(0x4622D438);
                stream.Read(onfoot, 0, onfoot.Length);

                stream.Position = Convert.ToInt32(0x4874BA38);
                stream.Read(onfoot1, 0, onfoot1.Length);

                stream.Position = Convert.ToInt32(0x4B26A9F8);
                stream.Read(onfoot2, 0, onfoot2.Length);

                stream.Position = Convert.ToInt32(0x4CA34D08);
                stream.Read(onfoot3, 0, onfoot3.Length);

                stream.Position = Convert.ToInt32(0x4EEF2DA8);
                stream.Read(onfoot5, 0, onfoot5.Length);

                stream.Position = Convert.ToInt32(0x51E8E5E8);
                stream.Read(onfoot6, 0, onfoot6.Length);
            }

            File.WriteAllBytes("common.rcf", common);
            File.WriteAllBytes("onfoot.rcf", onfoot);
            File.WriteAllBytes("onfoot1.rcf", onfoot1);
            File.WriteAllBytes("onfoot2.rcf", onfoot2);
            File.WriteAllBytes("onfoot3.rcf", onfoot3);
            File.WriteAllBytes("onfoot5.rcf", onfoot5);
            File.WriteAllBytes("onfoot6.rcf", onfoot6);

            //create god files

            byte[] generic = new byte[Convert.ToInt32(0x5800)];
            byte[] adventure = new byte[Convert.ToInt32(0x7000)];
            byte[] dino = new byte[Convert.ToInt32(0x7000)];
            byte[] egypt = new byte[Convert.ToInt32(0x6800)];
            byte[] fairy = new byte[Convert.ToInt32(0x6800)];
            byte[] midway = new byte[Convert.ToInt32(0x16800)];
            byte[] solar = new byte[Convert.ToInt32(0x7800)];

            using (Stream stream = File.Open("common.rcf", FileMode.Open))
            {
                stream.Position = Convert.ToInt32(0x48800);
                stream.Read(generic, 0, generic.Length);

                stream.Position = Convert.ToInt32(0x4E000);
                stream.Read(adventure, 0, adventure.Length);

                stream.Position = Convert.ToInt32(0x55000);
                stream.Read(dino, 0, dino.Length);

                stream.Position = Convert.ToInt32(0x5C000);
                stream.Read(egypt, 0, egypt.Length);

                stream.Position = Convert.ToInt32(0x62800);
                stream.Read(fairy, 0, fairy.Length);

                stream.Position = Convert.ToInt32(0x69000);
                stream.Read(midway, 0, midway.Length);

                stream.Position = Convert.ToInt32(0x7F800);
                stream.Read(solar, 0, solar.Length);
            }

            File.WriteAllBytes("genericobjectives.god", generic);
            File.WriteAllBytes("missionobjectives_adventure.god", adventure);
            File.WriteAllBytes("missionobjectives_dino.god", dino);
            File.WriteAllBytes("missionobjectives_egypt.god", egypt);
            File.WriteAllBytes("missionobjectives_fairy.god", fairy);
            File.WriteAllBytes("missionobjectives_midway.god", midway);
            File.WriteAllBytes("missionobjectives_solar.god", solar);

            List<GODFile> files = new List<GODFile>();
            files.Add(new GODFile("missionobjectives_adventure.god", Convert.ToInt32(0x4E000), Convert.ToInt32(0x7000)));
            files.Add(new GODFile("missionobjectives_dino.god", Convert.ToInt32(0x55000), Convert.ToInt32(0x7000)));
            files.Add(new GODFile("missionobjectives_egypt.god", Convert.ToInt32(0x5C000), Convert.ToInt32(0x6800)));
            files.Add(new GODFile("missionobjectives_fairy.god", Convert.ToInt32(0x62800), Convert.ToInt32(0x6800)));
            files.Add(new GODFile("missionobjectives_midway.god", Convert.ToInt32(0x69000), Convert.ToInt32(0x16800)));
            files.Add(new GODFile("missionobjectives_solar.god", Convert.ToInt32(0x7F800), Convert.ToInt32(0x7800)));

            List<string> replacing = new List<string>()
            {
                "this.AddAction_FadeOut(0.25)",
                "this.AddAction_FadeIn(0.25)",
            };
            List<string> replacewith = new List<string>();
            foreach (string line in replacing)
            {
                if(line == "this.AddAction_FadeOut(0.25)")
                {
                    replacewith.Add("this.AddAction_FadeOut(0)");
                }
                else if(line == "this.AddAction_FadeIn(0.25)")
                {
                    replacewith.Add("this.AddAction_FadeIn(0)");
                }
                
            }
            foreach (GODFile file in files)
            {
                Replacer.ReplaceRCF("common.rcf", file.start, ReplaceInstances(file, replacewith, replacing), file.length);

            }

            using (Stream stream = File.Open("common.rcf", FileMode.Open))
            {
                stream.Position = Convert.ToInt32(0x4E000);
                stream.Read(adventure, 0, adventure.Length);

                stream.Position = Convert.ToInt32(0x55000);
                stream.Read(dino, 0, dino.Length);

                stream.Position = Convert.ToInt32(0x5C000);
                stream.Read(egypt, 0, egypt.Length);

                stream.Position = Convert.ToInt32(0x62800);
                stream.Read(fairy, 0, fairy.Length);

                stream.Position = Convert.ToInt32(0x69000);
                stream.Read(midway, 0, midway.Length);

                stream.Position = Convert.ToInt32(0x7F800);
                stream.Read(solar, 0, solar.Length);
            }

            File.WriteAllBytes("missionobjectives_adventure.god", adventure);
            File.WriteAllBytes("missionobjectives_dino.god", dino);
            File.WriteAllBytes("missionobjectives_egypt.god", egypt);
            File.WriteAllBytes("missionobjectives_fairy.god", fairy);
            File.WriteAllBytes("missionobjectives_midway.god", midway);
            File.WriteAllBytes("missionobjectives_solar.god", solar);

            byte[] npc0 = new byte[Convert.ToInt32(0x1800)];
            byte[] npc1 = new byte[Convert.ToInt32(0x2800)];
            byte[] npc2 = new byte[Convert.ToInt32(0x2800)];
            byte[] npc3 = new byte[Convert.ToInt32(0x1800)];
            byte[] npc5 = new byte[Convert.ToInt32(0x3000)];
            byte[] npc6 = new byte[Convert.ToInt32(0x2800)];

            using (Stream stream = File.Open("onfoot.rcf", FileMode.Open))
            {
                stream.Position = Convert.ToInt32(0x413000);
                stream.Read(npc0, 0, npc0.Length);
            }

            using (Stream stream = File.Open("onfoot1.rcf", FileMode.Open))
            {
                stream.Position = Convert.ToInt32(0x4D0800);
                stream.Read(npc1, 0, npc1.Length);
            }

            using (Stream stream = File.Open("onfoot2.rcf", FileMode.Open))
            {
                stream.Position = Convert.ToInt32(0x4C3800);
                stream.Read(npc2, 0, npc2.Length);
            }

            using (Stream stream = File.Open("onfoot3.rcf", FileMode.Open))
            {
                stream.Position = Convert.ToInt32(0x4B5800);
                stream.Read(npc3, 0, npc3.Length);
            }

            using (Stream stream = File.Open("onfoot5.rcf", FileMode.Open))
            {
                stream.Position = Convert.ToInt32(0x4EC000);
                stream.Read(npc5, 0, npc5.Length);
            }

            using (Stream stream = File.Open("onfoot6.rcf", FileMode.Open))
            {
                stream.Position = Convert.ToInt32(0x390000);
                stream.Read(npc6, 0, npc6.Length);
            }

            File.WriteAllBytes("NPC0.god", npc0);
            File.WriteAllBytes("NPC1.god", npc1);
            File.WriteAllBytes("NPC2.god", npc2);
            File.WriteAllBytes("NPC3.god", npc3);
            File.WriteAllBytes("NPC5.god", npc5);
            File.WriteAllBytes("NPC6.god", npc6);

            string[] delete = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.new");

            foreach (string file in delete)
            {
                File.Delete(file);
            }
        }
    }
}
