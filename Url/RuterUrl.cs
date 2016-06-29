namespace RuterServices.Url
{
    internal static  class RuterUrl
    {
        internal static string RuterApiUrl = "http://reisapi.ruter.no/";

        internal static class LineUrl
        {
            public static string GetLinesUrl = RuterApiUrl + "Line/GetLines";
            public static string GetLinesByStopIDUrlWithArgs = RuterApiUrl + "Line/GetLinesByStopID/{0}";
        }
        
        internal static class TravelUrl
        {
            public static string GetTravelsUrl = RuterApiUrl + "Travel/GetTravels";
            public static string GetTravelsUrlWithArgs = GetTravelsUrl + "?fromPlace={0}&toPlace={1}&isafter={2}";
        }
        
        
    }
}
