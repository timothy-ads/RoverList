using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
            RoverList<string> list = new RoverList<string>();

            list.Add("List");
            list.Add("Implement");
            list.Add("Class");
            list.Add("School");
            list.Add("Main");
            list.Add("String");
            list.Add("Print");
            list.Add("Word");
            list.Add("Remove");
            list.Add("Input");
            list.Add("Enter");
            list.Add("Prompt");
            list.Add("Create");
            list.Add("Fill");
            list.Add("Clear");
            list.Add("Add");

            while (true)
            {
                Console.WriteLine("Type something from the list of words.");
                string input = Console.ReadLine();
                if (input == "Done")
                    break;
                list.Add(0, input);
            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                string input = list.ElementAt(i);
                if (input.Length % 2 == 1)
                {
                    list.RemoveAt(i);
                }
            }

            list.Clear();

            list.ListNodes();

            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words

            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list

            // TODO:  Clear the list
            // TODO:  Print out the list


        }
    }
}
