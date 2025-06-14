using PurcellPartners.Validators;
using System;
using System.Linq;

namespace PurcellPartners
{
    public class Program
    {

        static void Main(string[] args)
        {
            IntegerArray myArray = new IntegerArray(new int[] { 0, 2, 4, });
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
