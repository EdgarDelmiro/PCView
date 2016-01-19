using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCView
{
    class Sistema
    {

        OperatingSystem sysOP = Environment.OSVersion;

        public String getSystem()
        {
            string system = sysOP.Platform.ToString();

            return system;
        }

        public String getSPK()
        {
            string spk = sysOP.ServicePack.ToString();

            return spk;
        }

        public String getSOVersion()
        {
            string systemVersion = sysOP.Version.ToString();

            return systemVersion;
        }

        public String getVersionCLR()
        {
            string versionCLR = System.Environment.Version.ToString();

            return versionCLR;
        }

        public String getHostName()
        {
            string hostName = System.Environment.MachineName.ToString();

            return hostName;
        }

        public String getDate()
        {
            string date = DateTime.Now.ToString("dd-MM-yyyy");

            return date;
        }
    }
}
