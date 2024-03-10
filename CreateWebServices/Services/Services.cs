using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Services
    {

        private static string url = "https://jsonplaceholder.typicode.com/posts";

        public static string GetPost()
        {
            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";

            var httpResponse = (HttpWebResponse) request.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                return streamReader.ReadToEnd();

            }
        }
    }
}
