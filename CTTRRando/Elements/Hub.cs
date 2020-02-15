using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTRRando.Elements
{
    public class Hub
    {
        public int hubno;
        public int unlocks;
        public bool isunlocked;

        public Hub(int no, int un)
        {
            hubno = no;
            unlocks = un;
            isunlocked = false;
        }
    }
}
