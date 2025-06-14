using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PurcellPartners.Validators
{
    public class IntegerArrayValidator:ArrayValidator
    {
        public void validateNumberArray()
        {
            var rangeLength = Enumerable.Range(ArrayToValidate.Min(), (ArrayToValidate.Max() - ArrayToValidate.Min() + 1)).Count();

            //see if no number is missing
            if (ArrayToValidate.Length== rangeLength)
            {
                Invaliditis.Add("No number is missing");
            }

            //see if more than one number is missing
            if(ArrayToValidate.Length<rangeLength - Constants.MISSING_NUMBER_COUNT)
            {
                Invaliditis.Add("More than one number missing");
            }
        }

    }
}
