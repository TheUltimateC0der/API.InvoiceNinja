using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace API.InvoiceNinja.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Invoice
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "client_id")]
        public int? ClientId { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceNumber
        /// </summary>
        [DataMember(Name = "invoice_number", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "invoice_number")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceStatusId
        /// </summary>
        [DataMember(Name = "invoice_status_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "invoice_status_id")]
        public int? InvoiceStatusId { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Invoice {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  InvoiceStatusId: ").Append(InvoiceStatusId).Append("\n");
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
