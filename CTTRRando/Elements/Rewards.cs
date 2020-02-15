using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTRRando.Elements
{
    public static class Rewards
    {

        static List<string[]> items = new List<string[]>()
            {
                new string[]{ "this.AddAction_ReceiveCrystals(1)", "this.AddAction_DisplayMessage(\"missionend01\",1.0,6.0)"},
                new string[]{ "this.AddAction_ReceiveCrystals(1)", "this.AddAction_DisplayMessage(\"missionend02\",1.0,6.0)"},
                new string[]{ "this.AddAction_ReceiveCrystals(1)", "this.AddAction_DisplayMessage(\"missionend04\",1.0,6.0)"},
                new string[]{ "this.AddAction_ReceiveCrystals(1)", "this.AddAction_DisplayMessage(\"missionend24\",1.0,6.0)"},
                new string[]{ "this.AddAction_ReceiveCrystals(1)", "this.AddAction_DisplayMessage(\"missionend30\",1.0,6.0)"},
                new string[]{ "this.AddAction_ReceiveCrystals(1)", "this.AddAction_DisplayMessage(\"missionend31\",1.0,6.0)"},
                new string[]{ "this.AddAction_ReceiveCrystals(1)", "this.AddAction_DisplayMessage(\"missione3end\",1.0,6.0)"},
                new string[]{ "this.AddAction_ReceiveCrystals(1)", "this.AddAction_DisplayMessage(\"missionfinal39\",1.0,6.0)"},
                new string[]{ "this.AddAction_ReceiveCrystals(1)", "this.AddAction_DisplayMessage(\"missionfinal40\",1.0,6.0)"},
                new string[]{ "this.AddAction_ReceiveCrystals(1)", "this.AddAction_DisplayMessage(\"missionfinal41\",1.0,6.0)"},
                new string[]{ "this.AddAction_ReceiveCrystals(1)", "this.AddAction_DisplayMessage(\"missionend19\",1.0,6.0)"},
                new string[]{ "this.AddAction_ReceiveCrystals(1)", "this.AddAction_DisplayMessage(\"missionend20\",1.0,6.0)"},
                new string[]{ "this.AddAction_ReceiveCrystals(1)", "this.AddAction_DisplayMessage(\"missionend21\",1.0,6.0)"},
                new string[]{ "this.AddAction_ReceiveCrystals(1)", "this.AddAction_DisplayMessage(\"missionfinal04\",1.0,6.0)"},
                new string[]{ "this.AddAction_ReceiveCrystals(1)", "this.AddAction_DisplayMessage(\"missionfinal50\",1.0,6.0)"},
                new string[]{ "this.AddAction_ReceiveCrystals(1)", "this.AddAction_DisplayMessage(\"missionend49\",1.0,6.0)"},
                new string[]{ "this.AddAction_ReceiveCrystals(1)", "this.AddAction_DisplayMessage(\"missionend50\",1.0,6.0)"},
                new string[]{ "this.AddAction_ReceiveCrystals(1)", "this.AddAction_DisplayMessage(\"missionend51\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"pasadena\",1)", "this.AddAction_DisplayMessage(\"missionfinal05\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"ngin\",1)", "this.AddAction_DisplayMessage(\"missionfinal06\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"coco\",1)", "this.AddAction_DisplayMessage(\"missionfinal07\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"crunch\",1)", "this.AddAction_DisplayMessage(\"missionfinal08\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"nina\",1)", "this.AddAction_DisplayMessage(\"missionfinal09\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"vonclutch\",1)", "this.AddAction_DisplayMessage(\"missionfinal10\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"crash\",2)", "this.AddAction_DisplayMessage(\"missionfinal15\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"coco\",2)", "this.AddAction_DisplayMessage(\"missionfinal16\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"pasadena\",2)", "this.AddAction_DisplayMessage(\"missionfinal17\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"ngin\",2)", "this.AddAction_DisplayMessage(\"missionfinal18\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"nina\",2)", "this.AddAction_DisplayMessage(\"missionfinal26\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"crunch\",2)", "this.AddAction_DisplayMessage(\"missionfinal27\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"vonclutch\",2)", "this.AddAction_DisplayMessage(\"missionfinal28\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"neocortex\",2)", "this.AddAction_DisplayMessage(\"missionfinal29\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"crash\",3)", "this.AddAction_DisplayMessage(\"missionfinal33\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"coco\",3)", "this.AddAction_DisplayMessage(\"missionfinal34\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"crunch\",3)", "this.AddAction_DisplayMessage(\"missionfinal35\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"pasadena\",3)", "this.AddAction_DisplayMessage(\"missionfinal36\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"vonclutch\",3)", "this.AddAction_DisplayMessage(\"missionfinal45\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"nina\",3)", "this.AddAction_DisplayMessage(\"missionfinal46\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"neocortex\",3)", "this.AddAction_DisplayMessage(\"missionfinal47\",1.0,6.0)"},
                new string[]{ "this.AddAction_UnlockCar(\"ngin\",3)", "this.AddAction_DisplayMessage(\"missionfinal48\",1.0,6.0)" }
            };

        public static void Shuffle()
        {
            List<string[]> rewardsshuffled = new List<string[]>(items);
            rewardsshuffled.Shuffle();

            List<string> rewards = new List<string>();
            List<string> rewardLines = new List<string>();
            for(int i=0; i<rewardsshuffled.Count;i++)
            {
                rewards.Add(rewardsshuffled[i][1]);
                rewardLines.Add(items[i][1]);
            }

            foreach (GODFile file in Files.objectives)
            {
                Replacer.ReplaceRCF("common.rcf", file.start, Replacer.ReplaceInstancesSetRandom(file, rewards, rewardLines), file.length);
            }

            rewards = new List<string>();
            rewardLines = new List<string>();
            for (int i = 0; i < rewardsshuffled.Count; i++)
            {
                rewards.Add(rewardsshuffled[i][0]);
                rewardLines.Add(items[i][0]);
            }

            foreach (GODFile file in Files.objectives)
            {
                Replacer.ReplaceRCF("common.rcf", file.start, Replacer.ReplaceInstancesSetRandom(file, rewards, rewardLines), file.length);
            }

        }
    }
}
