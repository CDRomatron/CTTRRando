using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTRRando.Elements
{
    public static class Hubs
    {
        static string start = "this.AddAction_ChangeLevel(\"onfoot_";
        static string end = "\",\"StartLocationFromMidway\")";

        static List<string> items = new List<string>()
        {
            "adventure",
            "fairy",
            "dino",
            "egypt",
            "solar"
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

        public static void Shuffle(bool logic)
        {
            List<string> hubs = new List<string>();

            switch (logic)
            {
                case (true):
                    List<List<int>> combinations = new List<List<int>>();

                    Hub h1 = new Hub(1, 2);
                    Hub h2 = new Hub(2, 3);
                    Hub h3 = new Hub(3, 4);
                    Hub h4 = new Hub(4, 5);
                    Hub h5 = new Hub(5, 1);

                    List<Hub> listi = new List<Hub>();
                    listi.Add(h1);
                    listi.Add(h2);
                    listi.Add(h3);
                    listi.Add(h4);
                    listi.Add(h5);

                    foreach (List<Hub> permu in Permutate(listi, listi.Count))
                    {
                        permu[0].isunlocked = true;
                        permu[1].isunlocked = true;
                        permu[2].isunlocked = false;
                        permu[3].isunlocked = false;
                        permu[4].isunlocked = false;

                        for (int i = 0; i < 5; i++)
                        {
                            if (permu[i].isunlocked && permu[permu[i].unlocks - 1].isunlocked == false)
                            {
                                permu[permu[i].unlocks - 1].isunlocked = true;
                                i = 0;
                            }
                        }

                        //Console.Write(permu[0].hubno + " " + permu[1].hubno + " " + permu[2].hubno + " " + permu[3].hubno + " " + permu[4].hubno);

                        if (h1.isunlocked && h2.isunlocked && h3.isunlocked && h4.isunlocked && h5.isunlocked)
                        {
                            //Console.WriteLine(" True");
                            combinations.Add(new List<int>() { permu[0].hubno, permu[1].hubno, permu[2].hubno, permu[3].hubno, permu[4].hubno });
                        }
                        else
                        {
                            //Console.WriteLine(" False");
                        }
                    }

                    combinations.Shuffle();
                    foreach (int val in combinations[0])
                    {
                        hubs.Add(get(val-1));
                    }
                    break;
                case (false):
                    hubs = new List<string>(ExportList());
                    hubs.Shuffle();
                    break;
            }

            List<string> hublines = new List<string>(ExportList());

            foreach (GODFile file in Files.objectives)
            {
                Replacer.ReplaceRCF("common.rcf", file.start, Replacer.ReplaceInstances(file, hubs, hublines), file.length);
            }

        }

        public static void RotateRight(IList sequence, int count)
        {
            object tmp = sequence[count - 1];
            sequence.RemoveAt(count - 1);
            sequence.Insert(0, tmp);
        }


        public static IEnumerable<IList> Permutate(IList sequence, int count)
        {
            if (count == 1) yield return sequence;
            else
            {
                for (int i = 0; i < count; i++)
                {
                    foreach (var perm in Permutate(sequence, count - 1))
                        yield return perm;
                    RotateRight(sequence, count);
                }
            }
        }
    }
}
