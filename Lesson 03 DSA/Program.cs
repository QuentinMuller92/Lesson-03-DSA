using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Lesson_03_DSA
{
    class Program
    {
        private static void StudentMarks()
        {
            Dictionary<string, int> studentMarks = new Dictionary<string, int>();
            studentMarks.Add("Jane", 90);
            studentMarks.Add("John", 80);
            studentMarks.Add("Ivan", 70);
            studentMarks.Add("Peter", 60);
            studentMarks.Add("Maria", 50);

            while (true)
            {
                foreach (KeyValuePair<string, int> studentMark in studentMarks)
                {
                    Console.WriteLine($"Student {studentMark.Key}, mark = {studentMark.Value}");
                }
                Console.WriteLine("-----------------------------------------------------");

                Console.Write("Student Name (type exit to exit) : ");
                string name = Console.ReadLine();

                if(name == "exit")
                {
                    break; //
                }

                if (studentMarks.TryGetValue(name, out int value))
                {
                    Console.WriteLine($"Student '{name}' score is {studentMarks[name]}.");
                }
                else
                {
                    Console.WriteLine($"Student '{name}' does not exist.");
                }
            }            
        }

        private static void SortedDict()
        {            
            string text = "a text some text just some text";
            IDictionary<string, int> wordsCount = new SortedDictionary<string, int>();

            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                int count = 1;
                if(wordsCount.ContainsKey(word))
                {
                    count = wordsCount[word] + 1;
                }
                wordsCount[word] = count;
            }

            foreach(var w in wordsCount)
            {
                Console.WriteLine($"Word { w.Key}, count  = {w.Value}");
            }
        }

        private static void MenuList()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Remove item");
                Console.WriteLine("3. List all items");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine(choice);
                        break;
                    case "2":
                        Console.WriteLine(choice);
                        break;
                    case "3":
                        Console.WriteLine(choice);
                        break;
                    case "4":
                        Console.WriteLine(choice);
                        return;
                }
            }
        }

        //Homework 1
        private static void Minesweeper()
        {
            Console.Write("What's the length of the battlefield ? ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("What's the width of the battlefield ? ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            bool[,] battlefield = new bool[width, length];
            Random rand = new Random();
            int generate = -1;
            for(int i = 0; i<battlefield.GetLength(0); i++)
            {
                for(int j = 0; j<battlefield.GetLength(1); j++)
                {                    
                    generate = rand.Next(0, 2); 
                    if(generate == 0)
                    {
                        battlefield[i, j] = true;
                        Console.Write("X ");
                    }
                    else if (generate == 1)
                    {
                        battlefield[i, j] = false;
                        Console.Write("O ");
                    }                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int line = 0;
            int row = 0;
            while(true)
            {
                Console.Write("Select a line > ");
                line = Convert.ToInt32(Console.ReadLine());
                Console.Write("Select a row > ");
                row = Convert.ToInt32(Console.ReadLine());

                if(battlefield[line, row] == true)
                {
                    Console.WriteLine("BOOOOOOM");
                }
                else
                {
                    Console.WriteLine(("YEAH!"));
                }

                Console.Write("If you want to exit write exit > ");
                string end = Console.ReadLine();
                if(end == "exit")
                {
                    break;
                }
                Console.WriteLine();
            }
        }

        //Homework 2
        private static void Phonebook()
        {
            Dictionary<string, int> phoneBook = new Dictionary<string, int>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Insert");
                Console.WriteLine("2. Delete");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. List");                
                Console.WriteLine();

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Insert(phoneBook);
                        break;
                    case "2":
                        Delete(phoneBook);
                        break;
                    case "3":
                        Search(phoneBook);
                        break;
                    case "4":
                        List(phoneBook);
                        break;
                    default:
                        break;
                }

                Console.Write("Would you like to do anything else ? If not write exit > ");
                choice = Console.ReadLine();
                if(choice == "exit")
                {
                    break;
                }
            }
        }

        private static void Insert(Dictionary<string, int> phoneBook)
        {            
            Console.Write("What name would you like to insert ? ");
            string name = Console.ReadLine();
            Console.Write("What phone number would you like to insert ? ");
            int phone = Convert.ToInt32(Console.ReadLine());

            phoneBook.Add(name, phone);
        }

        private static void Delete(Dictionary<string, int> phoneBook)
        {
            Console.Write("Name ? ");
            string name = Console.ReadLine();

            if (phoneBook.TryGetValue(name, out int value))
            {
                phoneBook.Remove(name);
                Console.WriteLine($"The contact {name} has been removed !");
            }
            else
            {
                Console.WriteLine("The name doesn't exist!");
            }            
        }

        private static void Search(Dictionary<string, int> phoneBook)
        {
            Console.Write("Name ? ");
            string name = Console.ReadLine();

            if (phoneBook.TryGetValue(name, out int value))
            {
                Console.WriteLine("The phone number is : " + value);
            }
            else
            {
                Console.WriteLine("The name doesn't exist!");
            }
        }

        private static void List(Dictionary<string, int> phoneBook)
        {
            foreach (KeyValuePair<string, int> contact in phoneBook)
            {
                Console.WriteLine($"Name {contact.Key}, Phone Number = {contact.Value}");
            }
        }

        static void Main(string[] args)
        {
            //StudentMarks();

            //SortedDict();  

            //MenuList();

            //Minesweeper();

            //Phonebook();

            Console.ReadKey();
        }
    }
}
