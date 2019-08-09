using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EX_6A___Manipulating_Arrays
{
    class Assignment
    {






        public void Display(int[] array)
        {
            Console.Write(string.Join(", ", array));
        }


        public void Count(int[] array)
        {
            Console.Write($"\nThe count of elements: {array.Length}");
        }
        public int Sum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.Write($"\nThe sum of the array is:  {sum} ");
            return sum;
        }
        public void Mean(int[] array, int sum)
        {
            double mean = ((double)sum / array.Length);
            Console.WriteLine($"\nThe mean is {mean} ");
        }
        public void Reverse(int[] array)
        {
            Console.Write("The array reversed: ");
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tmp;
            }
            Console.Write(string.Join(" ", array));


        }

        public int Directions(int[] array)
        {
            Console.Write("Rotate Right or Left? 1 for RIGHT and 2 for LEFT\n");
            Console.Write("I will rotate: ");
            int userInput = int.Parse(Console.ReadLine());
            if(userInput!=1 || userInput!=2)
            {
                Console.Write("Please enter 1 for RIGHT or 2 for LEFT...  ");
                Console.Write("I will rotate: ");
            }

            Console.Write("How many positions to the left or right do you want to rotate? ");
            Console.Write("I will rotate: ");
            int hop = int.Parse(Console.ReadLine());
            if(hop <=array.Length)
            {
                for (int i = 0; i < array.Length; i++)
                {
                     += array[i];
                }
            }
            else if(hop>array.Length)
            {

            }
            else { }

            return Directions;

        }


        public void Rotate(int[] array)
        {
            
            if (array == null || array.Length < hop) return;
            


            hop %= array.Length;
            if (hop == 0) return;
            int left= hop < 0 ? -hop : array.Length + hop;
            int right = hop > 0 ? hop : array.Length - hop;
            if (left<=right)
            {
                for (int i = 0; i < left; i++)
                {

                    var temp = array[0];
                    Array.Copy(array, 1, array, 0, array.Length - 1);
                    array[array.Length - 1] = temp;
                    for (i = 0; i < array.Length / 2; i++)
                    {
                        int tmp = array[i];
                        array[i] = array[array.Length - i - 1];
                        array[array.Length - i - 1] = tmp;
                    }
                    Console.Write(string.Join(" ", array), hop);
                }
                return;

            }
            else
            {
                for (int i = 0; i < right; i--)
                {
                    var temp = array[0];
                    Array.Copy(array, 0, array, 1, array.Length - 1);
                    array[0] = temp;

                    for ( i = 0; i < array.Length / 2; i++)
                    {
                        int tmp = array[i];
                        array[i] = array[array.Length - i - 1];
                        array[array.Length - i - 1] = tmp;
                    }
                    Console.Write(string.Join(" ", array),- hop);
                }
                return;


            }
         




        }


        public int[] Sort(int[] array)
        {
            Console.Write("\nThe array sorted: ");
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
            Console.Write(string.Join(" ", array));
            return array;
        }
        
        
    }
}
