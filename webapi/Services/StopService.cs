using webapi.Models;

namespace webapi.Services
{
    public class StopService
    {
        private static List<StopModel> listStops = new List<StopModel>()
        {
            new StopModel()
            {
                Place = "Wendy's",
                Distance = "4.3m"
            },
            new StopModel()
            {
                Place = "Shell",
                Distance = "9.7m"
            }
        };

        public IEnumerable<StopModel> GetStops()
        {
            return listStops;
        }

        public void InsertStop(StopModel stop)
        {
            listStops.Add(stop);
        }
    }
}
