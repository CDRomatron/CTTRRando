using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTRRando.Elements
{
    public static class Courses
    {
        static string start = "this.AddAction_UnlockRace(\"";
        static string end = "\")";

        static List<string> items = new List<string>()
        {
            "adventure1",
            "adventure2",
            "adventure3",
            "fairy1",
            "fairy2",
            "fairy3",
            "dino1",
            "dino2",
            "dino3",
            "egypt1",
            "egypt2",
            "egypt3",
            "solar1",
            "solar2",
            "solar3"
        };        

        public static string get(int position)
        {
            return start + items[position] + end;
        }

        public static List<string> ExportList()
        {
            List<string> newList = new List<string>();

            foreach(string item in items)
            {
                newList.Add(start + item + end);
            }

            return newList;
        }

        public static void Shuffle()
        {
            List<string> courses = new List<string>(ExportList());
            courses.Shuffle();

            for(int i=0; i<15; i++)
            {
                courses.Add("this.AddAction_DisplayMessage(\"" + courses[i].Substring(27,courses[i].Length-30) + "gate" + courses[i].Substring(courses[i].Length - 3, 1) + "\",1.0,6.0)");
            }

            List<string> courselines = new List<string>(ExportList());

            for (int i = 0; i < 15; i++)
            {
                courselines.Add("this.AddAction_DisplayMessage(\"" + courselines[i].Substring(27, courselines[i].Length - 30) + "gate" + courselines[i].Substring(courselines[i].Length - 3, 1) + "\",1.0,6.0)");
            }

            foreach (GODFile file in Files.objectives)
            {
                Replacer.ReplaceRCF("common.rcf", file.start, Replacer.ReplaceInstances(file, courses, courselines), file.length);
            }

        }
    }
}
