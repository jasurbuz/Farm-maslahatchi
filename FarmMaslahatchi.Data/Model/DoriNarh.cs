using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmMaslahatchi.Data.Model
{
    public class DoriNarh
    {
        public int Id { get; set; }
        [JsonProperty("G1")]
        public string DoriNomi { get; set; }
        [JsonProperty("G2")]
        public string Narx { get; set; }
        [JsonProperty("G3")]
        public string Jami { get; set; }
        [JsonProperty("G4")]
        public string IshlabChiqaruvchi { get; set; }
    }
}
