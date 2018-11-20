using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Management_Solution
{
    class Logger
    {
        public static StringBuilder sb = new StringBuilder("");



        public static void log(String text)
        {
            sb.AppendLine(text);
            Console.WriteLine(text);
            File.AppendAllText(Constants.LOG_FILE, sb.ToString());
            sb.Clear();
        }
    }
}
