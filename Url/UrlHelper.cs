using System.Collections.Generic;
using System.Linq;
using System.Web;
using RuterServices.DTO.Requests;

namespace RuterServices.Url
{
    internal static class UrlHelper
    {
        internal static string GetQueryString(object obj)
        {
            var properties = from p in obj.GetType().GetProperties()
                             where p.GetValue(obj, null) != null
                             select p.Name + "=" + HttpUtility.UrlEncode(p.GetValue(obj, null).ToString());

            return "?" + string.Join("&", properties.ToArray());
        }
        internal static string DictionaryToQueryString(IEnumerable<KeyValuePair<string, string>> dictionaryParameters)
        {
           return dictionaryParameters.Aggregate("?", (current, param) => current + string.Concat(param.Key, "=", param.Value, "&"));
        }
    }
}
