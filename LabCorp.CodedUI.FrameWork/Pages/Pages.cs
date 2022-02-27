using LabCorp.CodedUI.FrameWork.EnumType;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCorp.CodedUI.FrameWork.Pages
{
    public static partial class Pages
    {
        private static DriverType _drivertype = default(DriverType);
        private static string Browser = ConfigurationManager.AppSettings["Browser"].ToString();
        public static DriverType DriverType
        {
            get
            {
                if (Browser == "Chrome")
                {
                    _drivertype = DriverType.ChromeDriver;
                }
                //else if (Browser == "Internet Explorer")
                //{
                //    _drivertype = DriverType.InternetExplorerDriver;
                //}
                //else if (Browser == "Firefox")
                //{
                //    _drivertype = DriverType.FirefoxDriver;
                //}
                //else
                //{
                //    _drivertype = DriverType.FirefoxDriver;
                //}

                return _drivertype;

            }
            set
            {
                _drivertype = value;
            }
        }
    }
}
