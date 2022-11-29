using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        // FIFO -- first in first out
        public static string NextInQueue(int num, Queue<string> queue)
        {
            Queue<string> testQueue = new Queue<string>();
            string nextEntries = "";
            for(int i=0;i < num;i++)
            {
                nextEntries = testQueue.Dequeue() + ", ";
            }
            return nextEntries;
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        // LIFO - Last in first out
        public static int[] Reverse(int[] original)
        {
            Stack<int> reverseStack = new Stack<int>();
            foreach(int num in original)
            {
                reverseStack.Push(num);
            }
            return reverseStack.ToArray();
        }

        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            // key-number corresponds to count-elementt
            string countString = "";
            Dictionary<string, int> countDictionary = new Dictionary<string, int>();

            for(int i =0;i<10;i++)
            {
                countDictionary.Add(i.ToString(), 0);
            }

            foreach(KeyValuePair<string,int> countVal in countDictionary)
            {
                foreach (string letter in input)
                {
                    if (letter == countVal.Key) countDictionary[countVal.Key]+=1;
                }
                countString += $"[{countVal.Key},{countVal.Value}]";
            }

            return countString; 
        }
    }
}
