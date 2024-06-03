using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EasyPDF
{
    internal class HardwareInfo
    {
        public static string GetHardwareId()
        {
            string cpuId = GetCpuId();
            string motherboardId = GetMotherboardId();
            string diskId = GetDiskId();

            string combinedId = cpuId + motherboardId + diskId;
            return ComputeSha256Hash(combinedId);
        }

        private static string GetCpuId()
        {
            string cpuId = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                cpuId = mo.Properties["processorID"].Value.ToString();
                break;
            }
            return cpuId;
        }

        private static string GetMotherboardId()
        {
            string motherboardId = string.Empty;
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            foreach (ManagementObject mo in mos.Get())
            {
                motherboardId = mo["SerialNumber"].ToString();
            }
            return motherboardId;
        }

        private static string GetDiskId()
        {
            string diskId = string.Empty;
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            foreach (ManagementObject mo in mos.Get())
            {
                diskId = mo["SerialNumber"].ToString();
            }
            return diskId;
        }

        private static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
