using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmMaslahatchi.Data.Model
{
    public class DoriSinonim
    {
        public int Id { get; set; }
        [JsonProperty("G1")]
        public string PP { get; set; }
        [JsonProperty("G2")]
        public string XalqaroNomi { get; set; }
        [JsonProperty("G3")]
        public string SavdoNomiVaSinonimi { get; set; }
        [JsonProperty("G5")]
        public string IshlabChiqarganDavlat { get; set; }
        [JsonProperty("G6")]
        public string IshlabChiqaruvchi { get; set; }
        [JsonProperty("G7")]
        public string Guruhi { get; set; }
        [JsonProperty("G8")]
        public string ATXCode { get; set; }
    }
}
