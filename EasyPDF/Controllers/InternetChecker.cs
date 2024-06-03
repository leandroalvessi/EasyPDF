using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace EasyPDF.Controllers
{
    internal class InternetChecker
    {
        public static bool IsConnectedToInternet()
        {
            try
            {
                // Primeiro, verificar se há algum adaptador de rede ativo
                if (!NetworkInterface.GetIsNetworkAvailable())
                {
                    return false;
                }

                // Enviar um ping para um servidor conhecido, como o DNS do Google
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send("8.8.8.8", 3000); // 8.8.8.8 é o DNS do Google
                    if (reply.Status == IPStatus.Success)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
