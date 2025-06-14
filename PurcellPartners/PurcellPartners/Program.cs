using PurcellPartners.Validators;
using System;
using System.Linq;

namespace PurcellPartners
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntegerArray myArray = new IntegerArray(new int[] { 0,1, 2, 4, });
            Console.WriteLine($"Missing number is: {myArray.GetMissingNumber()}");
            
        }
    }
}
