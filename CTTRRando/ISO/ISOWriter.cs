using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTRRando.ISO
{
    public static class ISOWriter
    {
        public static void Run(string oldfile, string newfile)
        {
            if(File.Exists(newfile))
            {
                File.Delete(newfile);
            }

            //write rcf files
            File.Copy(oldfile, newfile);

            byte[] common = File.ReadAllBytes("common.rcf");
            byte[] onfoot = File.ReadAllBytes("onfoot.rcf");
            byte[] onfoot1 = File.ReadAllBytes("onfoot1.rcf");
            byte[] onfoot2 = File.ReadAllBytes("onfoot2.rcf");
            byte[] onfoot3 = File.ReadAllBytes("onfoot3.rcf");
            byte[] onfoot5 = File.ReadAllBytes("onfoot5.rcf");
            byte[] onfoot6 = File.ReadAllBytes("onfoot6.rcf");

            using (Stream stream = File.Open("Crash Tag Team Rando.iso", FileMode.Open))
            {
                stream.Position = Convert.ToInt32(0x1ADB882C);
                stream.Write(common, 0, common.Length);

                stream.Position = Convert.ToInt32(0x4622D438);
                stream.Write(onfoot, 0, onfoot.Length);

                stream.Position = Convert.ToInt32(0x4874BA38);
                stream.Write(onfoot1, 0, onfoot1.Length);

                stream.Position = Convert.ToInt32(0x4B26A9F8);
                stream.Write(onfoot2, 0, onfoot2.Length);

                stream.Position = Convert.ToInt32(0x4CA34D08);
                stream.Write(onfoot3, 0, onfoot3.Length);

                stream.Position = Convert.ToInt32(0x4EEF2DA8);
                stream.Write(onfoot5, 0, onfoot5.Length);

                stream.Position = Convert.ToInt32(0x51E8E5E8);
                stream.Write(onfoot6, 0, onfoot6.Length);
            }
        }
    }
}
