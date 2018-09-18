using EssexCelebrant.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace EssexCelebrant.Business
{
    public class Venues
    {
        public static List<VenuesPoco> GetVenues(string url)
        {
            var results = VenuesData.Get(url);

            var resultData = new List<VenuesPoco>();

            foreach (var r in results)
            {
                resultData.Add(new VenuesPoco()
                {
                     County = r.County,
                     Link = r.Link,
                     Venue = r.Venue
                });
            }

            return resultData.OrderBy(o => o.Venue).ToList();
        }
    }
}
