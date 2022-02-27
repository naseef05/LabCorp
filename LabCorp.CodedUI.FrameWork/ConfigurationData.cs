using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCorp.CodedUI.FrameWork
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Configuration;

    namespace LabCorp.CodedUI.FrameWork
    {
        class ConfigurationData : ConfigurationDataBase
        {

            private static bool _allowServiceCharges;
            public static string ArizonaAgentUserId = ConfigurationManager.AppSettings["ArizonaAgentUserId"].ToString();
            public static string ArizonaAgentCode = ConfigurationManager.AppSettings["ArizonaAgentCode"].ToString();
            public static string ArizonaAgentPassword = ConfigurationManager.AppSettings["ArizonaAgentPassword"].ToString();
            public static string FloridaAgentUserId = ConfigurationManager.AppSettings["FloridaAgentUserId"].ToString();
            public static string FloridaAgentCode = ConfigurationManager.AppSettings["FloridaAgentCode"].ToString();
            public static string FloridaAgentPassword = ConfigurationManager.AppSettings["FloridaAgentPassword"].ToString();
            public static string GeorgiaAgentUserId = ConfigurationManager.AppSettings["GeorgiaAgentUserId"].ToString();
            public static string GeorgiaAgentCode = ConfigurationManager.AppSettings["GeorgiaAgentCode"].ToString();
            public static string GeorgiaAgentPassword = ConfigurationManager.AppSettings["GeorgiaAgentPassword"].ToString();
            public static string NewMexicoAgentUserId = ConfigurationManager.AppSettings["NewMexicoAgentUserId"].ToString();
            public static string NewMexicoAgentCode = ConfigurationManager.AppSettings["NewMexicoAgentCode"].ToString();
            public static string NewMexicoAgentPassword = ConfigurationManager.AppSettings["NewMexicoAgentPassword"].ToString();
            public static string OklahomaAgentUserId = ConfigurationManager.AppSettings["OklahomaAgentUserId"].ToString();
            public static string OklahomaAgentCode = ConfigurationManager.AppSettings["OklahomaAgentCode"].ToString();
            public static string OklahomaAgentPassword = ConfigurationManager.AppSettings["OklahomaAgentPassword"].ToString();
            public static string SouthCarolinaAgentUserId = ConfigurationManager.AppSettings["SouthCarolinaAgentUserId"].ToString();
            public static string SouthCarolinaAgentCode = ConfigurationManager.AppSettings["SouthCarolinaAgentCode"].ToString();
            public static string SouthCarolinaAgentPassword = ConfigurationManager.AppSettings["SouthCarolinaAgentPassword"].ToString();
            public static string TennesseeAgentUserId = ConfigurationManager.AppSettings["TennesseeAgentUserId"].ToString();
            public static string TennesseeAgentCode = ConfigurationManager.AppSettings["TennesseeAgentCode"].ToString();
            public static string TennesseeAgentPassword = ConfigurationManager.AppSettings["TennesseeAgentPassword"].ToString();
            public static string TexasAgentUserId = ConfigurationManager.AppSettings["TexasAgentUserId"].ToString();
            public static string TexasAgentCode = ConfigurationManager.AppSettings["TexasAgentCode"].ToString();
            public static string TexasAgentPassword = ConfigurationManager.AppSettings["TexasAgentPassword"].ToString();
            public static string VirginiaAgentUserId = ConfigurationManager.AppSettings["VirginiaAgentUserId"].ToString();
            public static string VirginiaAgentCode = ConfigurationManager.AppSettings["VirginiaAgentCode"].ToString();
            public static string VirginiaAgentPassword = ConfigurationManager.AppSettings["VirginiaAgentPassword"].ToString();
            public static long TimeSpanWaitTicks = long.Parse(ConfigurationManager.AppSettings["TimeSpanWaitTicks"].ToString());
            public static long TimeSpanShortWaitTicks = long.Parse(ConfigurationManager.AppSettings["TimeSpanShortWaitTicks"].ToString());
            public static long TimeSpanMedianWaitTicks = long.Parse(ConfigurationManager.AppSettings["TimeSpanMedianWaitTicks"].ToString());
            public static int SleepTime = int.Parse(ConfigurationManager.AppSettings["SleepTime"].ToString());
            public static string ValidFirstNameTX = ConfigurationManager.AppSettings["ValidFirstNameTX"].ToString();
            public static string ValidLastNameTX = ConfigurationManager.AppSettings["ValidLastNameTX"].ToString();
            public static string ValidAddressTX = ConfigurationManager.AppSettings["ValidAddressTX"].ToString();
            public static string ValidCityTX = ConfigurationManager.AppSettings["ValidCityTX"].ToString();
            public static string ValidZipTX = ConfigurationManager.AppSettings["ValidZipTX"].ToString();
            public static string AccountAndRoutingNumber = ConfigurationManager.AppSettings["AccountAndRoutingNumber"].ToString();
            public static string InvalidAccountAndRoutingNumber = ConfigurationManager.AppSettings["InvalidAccountAndRoutingNumber"].ToString();
            public static int PDFFromRequestDBPoolingTimeSpan = int.Parse(ConfigurationManager.AppSettings["PDFFromRequestDBPoolingTimeSpan"].ToString());
            public static int PDFFromRequestDBMaxRetry = int.Parse(ConfigurationManager.AppSettings["PDFFromRequestDBMaxRetry"].ToString());
            public static int RequestMaxRetry = int.Parse(ConfigurationManager.AppSettings["RequestMaxRetry"].ToString());
            public static int PDFFileExistPoolingTimeSpan = int.Parse(ConfigurationManager.AppSettings["PDFFileExistPoolingTimeSpan"].ToString());
            public static int PDFFileExistBMaxRetry = int.Parse(ConfigurationManager.AppSettings["PDFFileExistBMaxRetry"].ToString());

            public static string FirstNameTX
            {
                get
                {
                    return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveFirstNameTX"].ToString() : ConfigurationManager.AppSettings["FakeFirstNameTX"].ToString();
                }
            }

            public static string MiddleNameTX
            {
                get
                {
                    return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveMiddleNameTX"].ToString() : ConfigurationManager.AppSettings["FakeMiddleNameTX"].ToString();
                }
            }

            public static string LastNameTX
            {
                get
                {
                    return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveLastNameTX"].ToString() : ConfigurationManager.AppSettings["FakeLastNameTX"].ToString();
                }
            }

            public static string AddressTX
            {
                get
                {
                    return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveAddressTX"].ToString() : ConfigurationManager.AppSettings["FakeAddressTX"].ToString();
                }
            }

            public static string CityTX
            {
                get
                {
                    return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveCityTX"].ToString() : ConfigurationManager.AppSettings["FakeCityTX"].ToString();
                }
            }

            public static string ZipTX
            {
                get
                {
                    return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveZipTX"].ToString() : ConfigurationManager.AppSettings["FakeZipTX"].ToString();
                }
            }

            public static string VIN
            {
                get
                {
                    return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveVIN"].ToString() : ConfigurationManager.AppSettings["FakeVIN"].ToString();
                }
            }

            public static string SecondVIN
            {
                get
                {
                    return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveSecondVIN"].ToString() : ConfigurationManager.AppSettings["FakeSecondVIN"].ToString();
                }
            }

            public static string DOB
            {
                get
                {
                    return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDOB"].ToString() : ConfigurationManager.AppSettings["FakeDOB"].ToString();
                }
            }

            public static bool AllowServiceCharges
            {
                get
                {
                    try
                    {
                        _allowServiceCharges = bool.Parse(ConfigurationManager.AppSettings["AllowServiceCharges"].ToString());
                    }
                    catch
                    {
                        _allowServiceCharges = false;
                    }
                    return _allowServiceCharges;
                }
            }
        }
    }

}
