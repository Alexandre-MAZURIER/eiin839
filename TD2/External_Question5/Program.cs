﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External_Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
                Console.WriteLine("<br />From executable : " + args[0] + " & " + args[1]);
            else
                Console.WriteLine("External_Question5 <string parameter>");
        }
    }
}
