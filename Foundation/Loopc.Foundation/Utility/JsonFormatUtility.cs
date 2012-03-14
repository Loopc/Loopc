using System.Collections;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Script.Serialization;

namespace Loopc.Foundation.Utility
{
    public static class JsonFormatUtility
    {
        public static string Serialize<T>(T obj)
        {
            return Serialize(obj, Encoding.UTF8);
        }

        public static string Serialize<T>(T obj, Encoding encoding)
        {
            var jsonFormater = new DataContractJsonSerializer(typeof(T));
            using (var memoryStream = new MemoryStream())
            {
                jsonFormater.WriteObject(memoryStream, obj);
                memoryStream.Position = 0;
                using (var streamReader = new StreamReader(memoryStream, encoding))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }

        public static T Deserialize<T>(string jsonDatas)
        {
            return Deserialize<T>(jsonDatas, Encoding.UTF8);
        }

        public static T Deserialize<T>(string jsonDatas, Encoding encoding)
        {
            var jsonFormater = new DataContractJsonSerializer(typeof(T));
            var buffer = encoding.GetBytes(jsonDatas);

            using (var memoryStream = new MemoryStream(buffer))
            {
                memoryStream.Position = 0;
                return (T)jsonFormater.ReadObject(memoryStream);
            }
        }

        public static IDictionary Deserialize(string jsonDatas)
        {
            var jsonFormater = new JavaScriptSerializer();
            return jsonFormater.DeserializeObject(jsonDatas) as IDictionary;
        }
    }
}
