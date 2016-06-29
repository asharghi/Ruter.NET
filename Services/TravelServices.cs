using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RuterServices.DTO;
using RuterServices.DTO.Requests;
using RuterServices.Repository;
using RuterServices.Url;

namespace RuterServices.Services
{
    internal class TravelServices
    {
        internal static TravelResponse GetTravels(string fromPlaceId, string toPlaceId, bool isAfter)
        {
            return JsonConvert.DeserializeObject<TravelResponse>(RuterConnector.DownloadJson(string.Format(RuterUrl.TravelUrl.GetTravelsUrlWithArgs, fromPlaceId, toPlaceId, isAfter)));
        }

        internal static TravelResponse GetTravels(TravelRequest travelRequest)
        {
            var qs = UrlHelper.GetQueryString(travelRequest);
            return JsonConvert.DeserializeObject<TravelResponse>(RuterConnector.DownloadJson(RuterUrl.TravelUrl.GetTravelsUrl + qs));
        }

    }
}
