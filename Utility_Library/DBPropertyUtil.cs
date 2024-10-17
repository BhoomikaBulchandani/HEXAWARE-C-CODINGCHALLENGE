using Microsoft.Extensions.Configuration;

namespace Utility_Library
{

    //public static class DBPropertyUtil
    //{
    //    private static IConfigurationRoot _configuration;
    //    static string s = null;
    //    static DBPropertyUtil()
    //    {
    //        var builder = new ConfigurationBuilder()
    //            .SetBasePath(Directory.GetCurrentDirectory())
    //           .AddJsonFile("D:\\HEXAWARE-C#\\C#CODINGCHALLENGE\\Utility_Library\\AppSettings.json",
    //           optional: true, reloadOnChange: true);
    //        _configuration = builder.Build();
    //    }
    //    public static string ReturnCn(string key)
    //    {

    //        s = _configuration.GetConnectionString("dbCn");

    //        return s;
    //    }
    //}
    public static class DBPropertyUtil
    {
        public static string GetConnectionString(string fileName)
        {

            return "Data Source=.\\sqlexpress;Initial Catalog=PetPals;Integrated Security=True;TrustServerCertificate=True";
        }
    }

}
