using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace API.InvoiceNinja.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Product
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets ProductKey
        /// </summary>
        [DataMember(Name = "product_key", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "product_key")]
        public string ProductKey { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets DefaultTaxRateId
        /// </summary>
        [DataMember(Name = "default_tax_rate_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "default_tax_rate_id")]
        public int? DefaultTaxRateId { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Product {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProductKey: ").Append(ProductKey).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  DefaultTaxRateId: ").Append(DefaultTaxRateId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}
