﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
   class Program
   {
      static void Main(string[] args)
      {
         InteractiveShell ish = new InteractiveShell();
         ish.Run();
      }
   }
}
