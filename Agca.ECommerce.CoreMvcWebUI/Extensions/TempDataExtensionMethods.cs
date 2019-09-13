using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;

namespace Agca.ECommerce.CoreMvcWebUI.Extensions
{
    public static class TempDataExtensionMethods
    {
        public static void SetNonSerializableObject<T>(this ITempDataDictionary tempData, string key, T value) where T : class
        {
            var serializedValue = JsonConvert.SerializeObject(value);
            tempData.Add(key, serializedValue);
        }

        public static T GetNonSerializableObject<T>(this ITempDataDictionary tempData, string key) where T : class
        {
            var serilazedObject = (string)tempData[key];
            return serilazedObject == null ? null : JsonConvert.DeserializeObject<T>(serilazedObject);
        }
    }
}
