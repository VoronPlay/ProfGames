using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfGames.ApplicationData
{
    public class AppConnect
    {
        public class Global
        {
            private static string _globalVar = "";

            public static string GlobalVar
            {
                get { return _globalVar; }
                set { _globalVar = value; }
            }
        }
    }
}
