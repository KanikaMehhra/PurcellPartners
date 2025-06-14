using System;
using System.Collections.Generic;

namespace PurcellPartners.Validators
{
    public class ArrayValidator
    {
        public int[] ArrayToValidate
        { get; set; }
        public List<string> Invaliditis
        { get; set; } = new List<string>();

        public void validateArray()
        {
            if(ArrayToValidate == null || ArrayToValidate.Length==0) {
                Invaliditis.Add("Empty array provided");
            }
        }
    }
}
