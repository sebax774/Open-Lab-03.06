using System;
using System.Linq;

namespace Open_Lab_03._06
{
    public class Checker
    {
        public bool HasSpaces(string str)
        {
            if (str.ToLower().Contains(" "))
                return true;
            else
                return false;
        }
    }
}