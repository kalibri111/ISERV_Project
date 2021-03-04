using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISERV_Project
{
    public class GetIntException : Exception
    {
/*
 An exception for ToInt class
 */
        public GetIntException()
        {
        }

        public GetIntException(string message)
            : base(message)
        {
        }

        public GetIntException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    class ToInt
    {
/*
 this class provides method to get int from string if it is
 */
        private static string int_str = "";

        public static int GetInt( string str)
        {
            // return first number contains on string or throw GetIntException

            bool is_int_started = false;
            foreach (char c in str)
            {
                if(Char.IsDigit(c))
                {
                    if(!is_int_started)
                    {
                        is_int_started = true;
                    }

                    int_str += c;
                } else if (!Char.IsDigit(c) && is_int_started)
                {
                    return System.Convert.ToInt32(int_str);
                }
            }
            throw new GetIntException("number not found");
        }
    }
}
