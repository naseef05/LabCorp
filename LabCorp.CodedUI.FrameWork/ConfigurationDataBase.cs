using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCorp.CodedUI.FrameWork
{
    public abstract class ConfigurationDataBase
    {
        public static long TimeSpanWaitTicks = long.Parse(ConfigurationManager.AppSettings["TimeSpanWaitTicks"].ToString());
        public static int RequestMaxRetry = int.Parse(ConfigurationManager.AppSettings["RequestMaxRetry"].ToString());
        public static bool IsWebDriverUsingSauceLabs = bool.Parse(ConfigurationManager.AppSettings["IsWebDriverUsingSauceLabs"].ToString());
        public static String TunnelIdentifier = ConfigurationManager.AppSettings["TunnelIdentifier"].ToString();
    }
}
