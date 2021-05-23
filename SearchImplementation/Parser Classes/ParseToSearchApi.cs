using System;
using System.Web.Script.Serialization;

namespace SearchImplementation.Parser_Classes
{
    public class ParseToSearchApi<T>
    {
        public static T jsParse(String result) {
            T obj = default(T);
            obj = new JavaScriptSerializer().Deserialize<T>(result);
            return obj;
        }
    }
}
