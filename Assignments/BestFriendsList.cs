using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List_Assignments
{
    public class BestFriendsList
    {
        public void Main()
        {
            List<string> boys = new List<string>();
            boys.Add("Amal");
            boys.Add("Sam");
            boys.Add("Vivek");
            boys.Add("Tinu");

            List<string> girls = new List<string>();
            girls.Add("Supriya");
            girls.Add("Jisna");
            girls.Add("Aswani");
            girls.Add("Gopika");

            List<string> schoolFriends = new List<string>();
            schoolFriends.Add("Supriya");
            schoolFriends.Add("Vivek");
            schoolFriends.Add("Rahul");
            schoolFriends.Add("Maya");
            schoolFriends.Add("Jisna");
            schoolFriends.Add("Dilsha");

            List<string> bestFriends = new List<string>();
            Console.WriteLine("Girls List");
            DisplayFriendsList(girls);
            DrawLine(20, "-");

            Console.WriteLine("Boys List");
            DisplayFriendsList(boys);
            DrawLine(20, "-");

            Console.WriteLine("School Friends List");
            DisplayFriendsList(schoolFriends);
            DrawLine(20, "-");

            foreach (var schoolfriend in schoolFriends)
            {
                if(girls.Contains(schoolfriend))
                {
                    bestFriends.Add(schoolfriend);
                    girls.Remove(schoolfriend);
                   
                }
                if (boys.Contains(schoolfriend))
                {
                    bestFriends.Add(schoolfriend);
                    boys.Remove(schoolfriend);
                   
                }
            }

            foreach (var bestFriend in bestFriends)
            {
                if(schoolFriends.Contains(bestFriend))
                {
                    schoolFriends.Remove(bestFriend);
                }
            }
            
            Console.WriteLine("BestFriends List:");
            DisplayFriendsList(bestFriends);

            Console.WriteLine("After Removing Common Friends:");
            DrawLine(20, "-");

            Console.WriteLine("Girls List");
            DisplayFriendsList(girls);
            DrawLine(20, "-");

            Console.WriteLine("Boys List");
            DisplayFriendsList(boys);
            DrawLine(20, "-");

            Console.WriteLine("School Friends List");
            DisplayFriendsList(schoolFriends);
            DrawLine(20, "-");




        }

        private void DisplayFriendsList(List<string> friends)
        {
            foreach (var friend in friends)
            {
                Console.WriteLine(friend);
            }
        }

        private static void DrawLine(int noOfPrint, string pattern)
        {
            for (int i = 0; i < noOfPrint; i++)
            {
                Console.Write(pattern);
            }
            Console.WriteLine();
        }
    }
}
