using System.Configuration;

namespace EssexCelebrant.Models
{
    public class Helper
    {
        public static string AppSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}