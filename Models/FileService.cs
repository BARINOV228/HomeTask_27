using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_27.Models
{
    public static class FileService
    {
        private static readonly string PATH = @"D:\KOMRON\Najot_ta'lim\dot_net\dars\4-oy(Takrorlash)\DateFileJson19-09-2023\DateFileJson\entries.json";

        public static ApiInfo GetApiInfo()
        {
            string json;
            using (StreamReader sr = new StreamReader(PATH))
            {
                json = sr.ReadToEnd();
            }
            var objs = JsonConvert.DeserializeObject<ApiInfo>(json);
            return objs;
        }
    }
}
