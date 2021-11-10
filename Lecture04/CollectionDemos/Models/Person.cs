using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Newtonsoft.Json;

namespace LinqDemo.Models
{
    public class Person
    {
        public int id { get; set; }
        
//        [JsonProperty("first_name")]
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }  
        public string ip_address { get; set; }

        public override string ToString() => $"{id}: {first_name} {last_name}";
    }
}
