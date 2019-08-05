using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Finances.App.Helpers
{
    public class JsonTransformer
    {
        public static string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

    }
}
