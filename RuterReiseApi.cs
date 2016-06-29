using System.Collections.Generic;
using RuterServices.DTO;
using RuterServices.DTO.Requests;
using RuterServices.Services;

namespace RuterServices
{
    public class RuterReiseApi
    {
        #region Line
        public static List<Line> GetLines()
        {
            return LineService.GetLines();
        }
        public static List<Line> GetLinesByStopId(string id)
        {
            return LineService.GetLinesByStopId(id);
        }

        #endregion

        #region Travel
        public static TravelResponse GetTravels(string fromPlaceId, string toPlaceId, bool isAfter)
        {
            return TravelServices.GetTravels(fromPlaceId, toPlaceId, isAfter);
        }

        public static TravelResponse GetTravels(TravelRequest travelRequest)
        {
            return TravelServices.GetTravels(travelRequest);
        }

        #endregion


    }
}
