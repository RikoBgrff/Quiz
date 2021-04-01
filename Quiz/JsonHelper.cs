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

        public static void JsonSerialize(List<User> users)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter("users.json",true))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, users);
                }
            }
        }

        public static void JsonDeserialize()
        {
            User[] users = null;
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader("users.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    users = serializer.Deserialize<User[]>(jr);
                   
                }
            }
        }
    }
}

