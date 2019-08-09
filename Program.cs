using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_6A___Manipulating_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
            int[] arrayA = new int[6] { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = new int[5] { 1, 3, 5, 7, 9 };
            int[] arrayC = new int[12] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            var assignment = new Assignment();

            








            Console.Write("Array A: ");
            assignment.Display(arrayA);
            int sumA = assignment.Sum(arrayA);
            assignment.Count(arrayA);
            assignment.Mean(arrayA, sumA);
            assignment.Reverse(arrayA);
            assignment.Sort(arrayA);
            



            Console.Write("\n\nArray B: ");
            assignment.Display(arrayB);
            int sumB = assignment.Sum(arrayB);
            assignment.Count(arrayB);
            assignment.Mean(arrayB, sumB);
            assignment.Reverse(arrayB);
            assignment.Sort(arrayB);


            Console.Write("\n\nArray C: ");
            assignment.Display(arrayC);
            int sumC = assignment.Sum(arrayC);
            assignment.Count(arrayC);            
            assignment.Mean(arrayC, sumC);
            assignment.Reverse(arrayC);
            assignment.Sort(arrayC);
            




            assignment.Rotate(arrayA);
            assignment.Rotate(arrayB);
            assignment.Rotate(arrayC);
        }

    }
}
