using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Services
{
    public class Calculator
    {
        public int FirstNumber {get;set;}
        public int SecondNumber { get; set;}
        public int Total { get; set; }

        public int Add()
        {
            return Total = FirstNumber + SecondNumber;
        }
    }
}
