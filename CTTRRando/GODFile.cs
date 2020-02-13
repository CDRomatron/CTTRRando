using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTRRando
{
    public class GODFile
    {
        public string path;
        public int start;
        public int length;
        public string[] contentString;
        public byte[] contentByte;

        public GODFile(string path, int start, int length)
        {
            this.start = start;
            this.length = length;
            load(path);
        }

        public void reload(string path)
        {
            save(path);
            load(path);
        }

        public void load(string path)
        {
            this.path = path;
            contentString = File.ReadAllLines(path);
            contentByte = File.ReadAllBytes(path);
        }

        public void save(string path)
        {
            File.WriteAllBytes(path, contentByte);
        }
    }
}
