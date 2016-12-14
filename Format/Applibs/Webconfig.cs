using System.Configuration;

namespace Format.Applibs
{
    public class Webconfig
    {
        //public static string DBConnectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString();

        public static string WebTitle = ConfigurationManager.AppSettings["WebTitle"];
        public static string SysMail = ConfigurationManager.AppSettings["SysMail"];
        public static string Smtp = ConfigurationManager.AppSettings["Smtp"];
    }
}