using System;
//insertion sort
//algroithms HLA
namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = new int[] { 5, 4, 3, 2, 1 }; //vlaues in list
            int n = 5, i, j; //size set to 5
            int greater, on;
            Console.WriteLine("Insertion Sort Algorithms");
            Console.Write("Inputs is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(inputs[i] + " "); //print array before sort
            }
            for (i = 1; i < n; i++)
            {
                greater = inputs[i]; //add first value in greater vaiable
                on = 0;
                for (j = i - 1; j >= 0 && on != 1;)
                {
                    if (greater < inputs[j])
                    {
                        inputs[j + 1] = inputs[j]; //here checking next array index with previous
                        j--;
                        inputs[j + 1] = greater; //set next index to first one value which store before
                    }
                    else on = 1;
                }
            }
            Console.Write("\nafter sort list is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(inputs[i] + " "); //printing sorted array
            }
        }
    }
}
