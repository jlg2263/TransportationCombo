using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationCombo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare local variables
            string[] transportation = { "car", "boat", "motorcycle", "train", "plane" }; 
            string output = "";

            // For loop for each iteration
            for (int x = 0; x < transportation.Length; x++)
            {
                for (int y = 0; y < transportation.Length; y++)
                {
                    if (x != y)
                    {
                        output = transportation[x] + transportation[y];
                        Console.Write(output);
                        Console.ReadLine();
                    }
                    else
                    {
                        output = transportation[x] + transportation[y] + " is not a combination.";
                        Console.Write(output);
                        Console.ReadLine();
                    }
                }
            }

            output = "All combinations have been written.";
            Console.Write(output);
            Console.ReadLine();
        }
    }
}
