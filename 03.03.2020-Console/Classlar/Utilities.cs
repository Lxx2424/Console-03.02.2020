using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._03._2020_Console.Classlar
{
   static class Utilities
    {
        public static bool isInt(string name)
        {
            try
            {
                Convert.ToUInt32(name);

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
