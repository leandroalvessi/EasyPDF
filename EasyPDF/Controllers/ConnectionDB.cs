using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPDF.Controllers
{
    public class ConnectionDB
    {
        public static string ConnectionString()
        {
            return "Host=pg-bd85c4d-leandroalves-1f0f.e.aivencloud.com;Port=21959;Username=avnadmin;Password=AVNS_LE30XeKEW5NCvxIrQ8o;Database=defaultdb;SSL Mode=Require;Trust Server Certificate=true";
        }
    }
}
