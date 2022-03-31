using System.Collections.Generic;
using Newtonsoft.Json;

namespace XmlToJson
{
    // Consignment class, containing all data to be serialized into json.
    class Consignment
    {
        [JsonProperty("consignmentId")]
        public string ConsignmentId { get; set; }

        [JsonProperty("packageIds")]
        public List<string> PackageIds { get; set; }
    }
}
