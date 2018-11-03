using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int> { 4, 8, 11, 13, 21 };
            Console.WriteLine("List");
            foreach(int i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");

            LinkedList<int> linkList = new LinkedList<int>();
            linkList.AddFirst(1);
            linkList.AddAfter(linkList.First, 2);
            linkList.AddAfter(linkList.First, 3);
            linkList.AddAfter(linkList.First, 4);
            linkList.AddAfter(linkList.First, 5);
            Console.WriteLine("LinkedList");
            foreach(int i in linkList)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Hi! ");
            queue.Enqueue("How ");
            queue.Enqueue("are ");
            queue.Enqueue("you ");
            queue.Enqueue("today?");
            Console.WriteLine("Queue");
            foreach(var i in queue)
            {
                Console.Write($"{i}");
            }
            Console.WriteLine("\n");

            Stack<string> stack = new Stack<string>();
            stack.Push("well.");
            stack.Push("doing ");
            stack.Push("am ");
            stack.Push("I ");
            stack.Push("Hello! ");
            Console.WriteLine("Stack");
            foreach(var i in stack)
            {
                Console.Write($"{i}");
            }
            Console.WriteLine("\n");

            Dictionary<int, string> footballRank = new Dictionary<int, string>();
            footballRank.Add(1, "Alabama");
            footballRank.Add(2, "Clemson");
            footballRank.Add(3, "LSU");
            footballRank.Add(4, "Notre Dame");
            footballRank.Add(5, "Michigan");
            Console.WriteLine("Dictionary");
            foreach(KeyValuePair<int, string> rank in footballRank)
            {
                Console.WriteLine($"Rank = {rank.Key}, Team = {rank.Value} ");
            }
            Console.WriteLine("\n");

            SortedList<int, string> sortList = new SortedList<int, string>();
            sortList.Add(4, "is ");
            sortList.Add(1, "My ");
            sortList.Add(3, "color ");
            sortList.Add(5, "orange. ");
            sortList.Add(2, "favorite ");
            Console.WriteLine("Sorted List");
            foreach(KeyValuePair<int, string> pair in sortList)
            {
                Console.Write($"{pair.Key}, {pair.Value}");
            }
            Console.WriteLine("\n");

            HashSet<int> hash = new HashSet<int>();
            for(int i = 1; i < 10; i++)
            {
                hash.Add(i * 4);
            }
            Console.WriteLine("Hash Set");
            foreach(var i in hash)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");

        }
    }
}
