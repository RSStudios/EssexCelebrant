using System.Collections.Generic;

namespace EssexCelebrant.DataAccess
{
    public class VenuesData
    {
        public string Venue { get; set; }
        public string Link { get; set; }
        public string County { get; set; }

        public static List<VenuesData> Get(string url)
        {
            return ReadJson.ReadTheJson<VenuesData>(url);
        }
    }
}
