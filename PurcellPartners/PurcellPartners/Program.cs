using PurcellPartners.Validators;
using System;
using System.Linq;

namespace PurcellPartners
{
    public class Program
    {
        public static int[] getUserInputArray()
        {
            Console.WriteLine("Enter array numbers seperated by comma:");
            var arrayString = Console.ReadLine();
            return arrayString.Split(',').Select(ar=>Convert.ToInt32(ar)).ToArray();
        }
        static void Main(string[] args)
        {
            int[] userInput = getUserInputArray();
            IntegerArray myArray = new IntegerArray(userInput);
            IntegerArrayValidator arrayValidator = new IntegerArrayValidator();

            try
            {
                arrayValidator.ArrayToValidate = myArray.Array;
                arrayValidator.validateArray();
                arrayValidator.validateNumberArray();
                if (arrayValidator.Invaliditis.Count > 0)
                {
                    throw new Exception("Invalid array provided with following invalidities");
                }
                else
                {
                    Console.WriteLine($"Missing number is: {myArray.GetMissingNumber()}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                arrayValidator.Invaliditis.ForEach(inv => Console.WriteLine(inv));
            }

        }
    }
}
