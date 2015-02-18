using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigPlay
{
    public class SsrsConfig : ConfigurationSection
    {
        [ConfigurationProperty("url", DefaultValue = "", IsRequired = false)]
        public string Url 
        {
            get { return (string)this["url"]; }
            set { this["url"] = value; }
        }

        [ConfigurationProperty("serviceUrl", DefaultValue = "", IsRequired = false)]
        public string ServiceUrl
        {
            get { return (string)this["serviceUrl"]; }
            set { this["serviceUrl"] = value; }
        }

        [ConfigurationProperty("reportsPath", DefaultValue = "", IsRequired = false)]
        public string ReportsPath
        {
            get { return (string)this["reportsPath"]; }
            set { this["reportsPath"] = value; }
        }
    }

    public class MySection : ConfigurationSection
    {
        [ConfigurationProperty("x", DefaultValue = false, IsRequired = false)]
        public Boolean X
        {
            get
            {
                return (Boolean)this["x"];
            }
            set
            {
                this["x"] = value;
            }
        }
    }
}
