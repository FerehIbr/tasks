using System;
using System.Collections.Generic;
using System.Text;

namespace quvvet
{
    class Quvvet
    {
        public void Quvvetf(int f)
        {
            bool res = false;
            for (int i = 1; i <f; i*=2)
            {
                if (f == i*2)
                {
                    res = true;
                }
                else 
                {
                    res = false;
                }
              
            }
            if (res)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
