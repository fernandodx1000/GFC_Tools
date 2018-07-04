using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace GFC_Tools
{
    class Variables
    {
        public string CurentVersion;
        Version version = Assembly.GetEntryAssembly().GetName().Version;

        public void Main()
        {
            CurentVersion = version.ToString();
            Console.WriteLine(CurentVersion);
        }
    }
}
