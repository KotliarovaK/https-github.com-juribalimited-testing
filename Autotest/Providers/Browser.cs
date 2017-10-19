using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotest.Providers
{
    public static class Browser
    {
        public static string Type => ConfigurationManager.AppSettings["targetBrowser"];
    }
}
