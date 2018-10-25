using System;


/*       Array slot:
 *                    [0]
 *                  [1] [2]
 *                [3] [4] [5]
 *              [6] [7] [8] [9]
 *            [6] [7] [8] [9] [10]
 * */

namespace PascalTriangleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pascal's Triangle!");

            const int MAX = 1024;   // MAX size of array is 1024
            int n;                  // User input

            Console.WriteLine("How deep do you want to go? (Enter an integer greater than 0)");
            n = Convert.ToInt32(Console.ReadLine());

            // Initialize array
            int[] pascal = new int[MAX];

            // Call function to perform calculation
            pascalTriangle(pascal, n);
            printPascal(pascal);

            // To stop the window from closing automatically
            Console.WriteLine("\n\nPress enter to exit. . .");
            Console.ReadLine();
        }

        public static int[] pascalTriangle(int[] array, int rows)
        {
            
            int count = 0;  // Counter

            int start = 1;  // Initialize array slot for start
            int end = 2;    // Initialize array slot for end
            int temp = end; // Initialize temp to hold end

            int u = 4;      // Used to hold array value
            int v = 1;      // Used to hold array value
            int w = 2;      // Used to hold array value

            int x = 3;      // Used to increment start
            int y = 4;      // Used to increment end

            // Initialize first 3 levels of pascal traiangle
            // because the first 3 levels are a special case to
            // the algorithm used in the program
            array[0] = 1;
            array[1] = 1;
            array[2] = 1;
            array[3] = 1;
            array[4] = 2;
            array[5] = 1;
            start = 3;
            end = 5;
            u = 7;  // Hard code
            v = 3;  // Hard code
            w = 4;  // Hard code

            // This initializes the array with the 1's at start and end
            
            while (count < rows)
            {
                // This puts the 1's into the Pascal's Triangle
                array[start] = 1;
                array[end] = 1;
                start += x;
                end += y;
                x++;
                y++;
                u = start + 1;
                temp = end;
                
                while(w < temp)
                {
                    // This puts the middle numbers into the Pascal's Triangle
                    array[u] = array[v] + array[w];
                    u++;
                    v++;
                    w++;
                    if(u == end)
                    {
                        v++;
                        w++;
                        break;
                    }
                    if(w == end)
                    {
                        array[w] = 1;
                    }
                }                

                count++;
            }

            return array;
            }
    

        public static void printPascal(int[] array)
        {
            Console.WriteLine("Printing Pascal Triangle\n");

            int start = 1;  // Initialize array slot for start
            int end = 2;    // Initialize array slot for end

            int x = 1;      // Used to increment start
            int y = 2;      // Used to increment end

            start = start + x;
            end = end + y;


            // The first 3 layers must be hard coded
            for (int i = 0; i < array.Length; i++)
            //for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Array[" + i + "] = " + array[i]);
            }
        }
    }
}