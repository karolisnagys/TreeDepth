using System;
using System.Collections.Generic;

namespace TreeDepth
{
    class Program
    {

        // Structure
        class Saka
        {
            public string numeris;
            public List<Saka> sakos;

        }

        // func to create tree structure
        static Saka NewNode(string key)
        {
            Saka temp = new Saka
            {
                numeris = key, // Asign key
                sakos = new List<Saka>() // Asign list
            };

            return temp;
        }


        // Func returns depth of the tree
        static int DepthOfTree(Saka input)
        {

            if (input == null)
                return 0;

            int maxdepth = 0; // initial value
            foreach (Saka saka in input.sakos) // Check each node
            {
                maxdepth = DepthOfTree(saka); // Recursion
            }

            return maxdepth + 1; // Return answer // Start at 1 not 0

        }

        public static void Main()
        {

            // Test tree structure case
            Saka saknis = NewNode("1"); // Set root
            // Add all nodes // Each level of hierarchy is asigned the same number
            (saknis.sakos).Add(NewNode("2"));
            (saknis.sakos).Add(NewNode("2"));
            (saknis.sakos).Add(NewNode("2"));
            (saknis.sakos).Add(NewNode("2"));

            (saknis.sakos[0].sakos).Add(NewNode("3"));
            (saknis.sakos[0].sakos).Add(NewNode("3"));
            (saknis.sakos[2].sakos).Add(NewNode("3"));
            (saknis.sakos[3].sakos).Add(NewNode("3"));
            (saknis.sakos[3].sakos).Add(NewNode("3"));
            (saknis.sakos[3].sakos).Add(NewNode("3"));

            (saknis.sakos[0].sakos[0].sakos).Add(NewNode("4"));
            (saknis.sakos[0].sakos[0].sakos).Add(NewNode("4"));
            (saknis.sakos[3].sakos[2].sakos).Add(NewNode("4"));

            (saknis.sakos[0].sakos[0].sakos[0].sakos).Add(NewNode("5"));
            (saknis.sakos[0].sakos[0].sakos[0].sakos).Add(NewNode("5"));
            (saknis.sakos[3].sakos[2].sakos[0].sakos).Add(NewNode("5"));

            (saknis.sakos[0].sakos[0].sakos[0].sakos[0].sakos).Add(NewNode("6"));
            (saknis.sakos[0].sakos[0].sakos[0].sakos[0].sakos).Add(NewNode("6"));
            (saknis.sakos[3].sakos[2].sakos[0].sakos[0].sakos).Add(NewNode("6"));

            (saknis.sakos[3].sakos[2].sakos[0].sakos[0].sakos[0].sakos).Add(NewNode("7")); // Last node and the expected answer

            // Answer
            Console.Write("Depth of the tree is: " + DepthOfTree(saknis) + "\n"); // print the depth
        }
    }
}