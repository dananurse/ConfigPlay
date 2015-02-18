using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConfigPlay
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keys = ConfigurationManager.AppSettings.AllKeys;

            foreach(var key in keys)
            {
                Console.WriteLine("{0} : {1}", key, ConfigurationManager.AppSettings.Get(key));
                Debug.Assert(false, key);
            }

            SsrsConfig ssrsConfig =
                (SsrsConfig)ConfigurationManager.GetSection("ssrsConfigGroup/ssrsConfig");

            Console.WriteLine(ssrsConfig.Url);
            Console.WriteLine(ssrsConfig.ServiceUrl);
            Console.WriteLine(ssrsConfig.ReportsPath);

            Console.ReadKey();
        }
    }
}
