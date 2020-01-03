using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTRRando
{
    class ObjectiveFile
    {
        public string path;
        public int start;
        public int length;

        public ObjectiveFile(string path, int start, int length)
        {
            this.path = path;
            this.start = start;
            this.length = length;
        }
    }
}
