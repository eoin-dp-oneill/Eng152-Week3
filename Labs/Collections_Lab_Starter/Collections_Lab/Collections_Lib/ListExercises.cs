using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            List<int> multiplesOfFive = new List<int>();
            for(int i=5;i<=max;i+=5)
            {
                multiplesOfFive.Add(i);
            }
            return multiplesOfFive;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            List<string> stringList = new List<string>();
            foreach(string source in sourceList)
            {
                if (source[0] == 'A' || source[0] == 'a') stringList.Add(source);
            }
            return stringList;
        }
    }
}
