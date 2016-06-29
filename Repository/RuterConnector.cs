using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RuterServices.DTO;

namespace RuterServices.Repository
{
    internal class RuterConnector
    {
       internal static string DownloadJson(string url)
        {
            string json;
            using (var client = new WebClient())
            {
                var defaultWebProxy = WebRequest.DefaultWebProxy;
                defaultWebProxy.Credentials = CredentialCache.DefaultCredentials;
                client.Proxy = defaultWebProxy;
                json = client.DownloadString(url);
            }

            return json;
        }
    }
}
