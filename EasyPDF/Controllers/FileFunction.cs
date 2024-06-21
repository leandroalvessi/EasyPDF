using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPDF.Controllers
{
    internal class FileFunction
    {
        public static string GetReadableFileSize(long sizeInBytes)
        {
            string[] sizeUnits = { "B", "KB", "MB", "GB", "TB" };

            if (sizeInBytes < 0) sizeInBytes = 0;

            int unitIndex = 0;
            double size = sizeInBytes;

            while (size >= 1024 && unitIndex < sizeUnits.Length - 1)
            {
                size /= 1024;
                unitIndex++;
            }

            return $"{size:F2} {sizeUnits[unitIndex]}";
        }
    }
}
