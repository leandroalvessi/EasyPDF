using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EasyPDF.Controllers
{
    internal class AppInfo
    {
        public static string GetAppVersion()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version; 
            return version.ToString();
        }
    }
}
