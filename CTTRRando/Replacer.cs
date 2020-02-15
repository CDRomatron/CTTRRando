using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTRRando
{
    public static class Replacer
    {
        public static void ReplaceRCF(string filename, long position, byte[] data, int length)
        {

            byte[] output = new byte[length];

            for (int i = 0; i < length; i++)
            {
                if (i < data.Length)
                {
                    output[i] = data[i];
                }
                else
                {
                    output[i] = 0x0;
                }
            }

            using (Stream stream = File.Open(filename, FileMode.Open))
            {
                stream.Position = position;
                stream.Write(output, 0, length);

            }
        }
        public static byte[] ReplaceInstances(GODFile file, List<string> replaceWith, List<string> replacing)
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

        public static byte[] ReplaceInstancesRandom(GODFile file, List<string> replaceWith, List<string> replacing)
        {
            string[] generic = file.contentString;

            /*for (int i = 0; i < replaceWith.Count; i++)
            {
                Console.WriteLine(replacing[i] + " --> " + replaceWith[i]);
            }*/

            string output = "";

            for (int i = 0; i < generic.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < replacing.Count; j++)
                {

                    if (generic[i] == replacing[j] && flag)
                    {
                        int r = ThreadSafeRandom.ThisThreadsRandom.Next(0, replaceWith.Count);
                        generic[i] = replaceWith[r];
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

        public static byte[] ReplaceInstancesSetRandom(GODFile file, List<string> replaceWith, List<string> replacing)
        {
            string[] generic = file.contentString;

            /*for (int i = 0; i < replaceWith.Count; i++)
            {
                Console.WriteLine(replacing[i] + " --> " + replaceWith[i]);
            }*/

            string output = "";

            for (int i = 0; i < generic.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < replacing.Count; j++)
                {

                    if (generic[i] == replacing[j] && flag)
                    {
                        generic[i] = replaceWith[0];
                        flag = false;
                        replaceWith.RemoveAt(0);
                    }
                }

                if (i < generic.Length)
                {
                    output = output + generic[i] + '\n';
                }
            }

            byte[] newgeneric = Encoding.UTF8.GetBytes(output);

            file.contentByte = newgeneric;
            file.reload(file.path + ".new");

            return newgeneric;

        }
    }
}
