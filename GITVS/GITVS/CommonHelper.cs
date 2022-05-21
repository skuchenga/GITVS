using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace GITVS
{
    public static class CommonHelper
    {

        public static string GetBaseDirectory()
        {
            return AppContext.BaseDirectory;

        }

        public static int Add()
        {
            var num1 = 3;
            var num2 = 5;
            return num1 + num2;
        }

    }
}
