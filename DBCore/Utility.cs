using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace DBCore
{

    public enum AppSetting { BgImage, SinhalaFontName, AddressPrintLocation, fontSize , DonarNameLocation, SchoolCatLocation, MagazinePrice }
    public enum UserLevel { SystemUser = 0, SystemUser_I = 1, SystemUser_IUD = 2, SystemAdmin = 3 };
    public enum Banks { BOC = 1, Sampath = 2, HNB = 3 }
    public enum PaymentType { Asapuwa = 1, Bank = 2 }
    public enum SubscriptionType { Yearly = 1, Monthly = 2}

    public class Utility
    {

        public static string GetConnectionString()
        {
            return string.Concat(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            //"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data.mdb;Persist Security Info=True;Jet OLEDB:Database Password=";

        }

        public static string GetAppsetting(AppSetting key)
        {
            return ConfigurationManager.AppSettings[key.ToString()];
        }
    }
}
