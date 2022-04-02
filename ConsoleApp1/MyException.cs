using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MyException:Exception
    {
        public MyException(string message):base(message)
        {

        }
    }
}
