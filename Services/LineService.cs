using System.Collections.Generic;
using Newtonsoft.Json;
using RuterServices.DTO;
using RuterServices.Repository;
using RuterServices.Url;

namespace RuterServices.Services
{
    internal class LineService
    {
        internal static List<Line> GetLines()
        {
            return JsonConvert.DeserializeObject<List<Line>>(RuterConnector.DownloadJson(RuterUrl.LineUrl.GetLinesUrl));
        }
        internal static List<Line> GetLinesByStopId(string id)
        {
            return JsonConvert.DeserializeObject<List<Line>>(RuterConnector.DownloadJson(string.Format(RuterUrl.LineUrl.GetLinesByStopIDUrlWithArgs, id)));
        }
    }
}
