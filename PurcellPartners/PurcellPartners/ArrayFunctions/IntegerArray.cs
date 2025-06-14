using System.Linq;

namespace PurcellPartners
{
    public class IntegerArray
    {
        public int[] Array
        { get; private set; }

        public IntegerArray(int[] array) 
        {
            Array = array;
        }

        public int GetMissingNumber()
        {
            int minNum = Array.Min();
            int maxNum = Array.Max();
            var range = Enumerable.Range(minNum, maxNum - minNum + 1);
            int rangeSum = range.Sum();
            int actualArraySum=Array.Sum();
            return rangeSum-actualArraySum;
        }
    }
}
