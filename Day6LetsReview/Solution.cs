using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//given a string even number indexes print first
//odd number indexes print second
//with a space in between

//Sample Input

//2
//Hacker
//Rank
//Sample Output

//Hce akr
//Rn ak
namespace Day6LetsReview
{
    class Solution
    {
        static void Main(string[] args)
        {

            char[] evens;
            char[] odds;
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. 
             * Your class should be named Solution */
            int numStrings = Int32.Parse(Console.ReadLine());

            string[] myStrings = new string[numStrings];

            for (int i = 0; i < numStrings; i++)
            {
                myStrings[i] = Console.ReadLine();

            }



            for (int i = 0; i < myStrings.Length; i++)
            {




                //convert first string char array
                char[] arr = myStrings[i].ToCharArray();

                //create 2 arrays 
                //if array length is even make even array one longer 
                if ((arr.Length % 2) != 0)
                {

                   evens = new char[(arr.Length / 2)+1];
                   odds = new char[arr.Length / 2];
                }
                else
                {
                   evens = new char[arr.Length / 2];
                   odds = new char[arr.Length / 2];

                }

                //create counters to populate arrays
                int counterEven = 0;
                int counterOdd = 0;


                for (int j = 0; j < myStrings[i].Length; j++)
                {


                    //populate arrays
                    if (j % 2 == 0)
                    {
                        //index is even
                        evens[counterEven] = arr[j];
                        counterEven++;


                    }
                    else if (j % 2 != 0)
                    {
                        //index is odd
                        odds[counterOdd] = arr[j];
                        counterOdd++;
                    }
                    else
                    {
                        Console.WriteLine("Exception, we should not be here!");
                        Console.ReadLine();
                    }
                }
                PrintArray(evens);
                Console.Write(" ");
                PrintArray(odds);
                Console.WriteLine();


            }
            //Console.WriteLine();
            Console.ReadLine();
             




        }

        static void PrintArray(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);

            }
            

        }
    }
}
