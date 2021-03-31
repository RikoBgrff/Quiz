using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class JsonHelper
    {

        public static void JsonSerialize(User user)
        {
            var serializer = new JsonSerializer();
           
                using (var sw = new StreamWriter("users.json"))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                        serializer.Serialize(jw, user);
                    }
                }
        }

        //static void JsonDeserialize()
        //{
        //    Car[] cars = null;
        //    var serializer = new JsonSerializer();

        //    using (var sr = new StreamReader("json.json"))
        //    {
        //        using (var jr = new JsonTextReader(sr))
        //        {
        //            cars = serializer.Deserialize<Car[]>(jr);
        //        }
        //        foreach (var item in cars)
        //        {
        //            Console.WriteLine(item);
        //        }
        //    }

        //}
    }
}
