using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace API.InvoiceNinja.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Vendor
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets AccountKey
        /// </summary>
        [DataMember(Name = "account_key", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "account_key")]
        public string AccountKey { get; set; }

        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        [DataMember(Name = "address1", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name = "address2", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name = "postal_code", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name = "country_id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "country_id")]
        public int? CountryId { get; set; }

        /// <summary>
        /// Gets or Sets WorkPhone
        /// </summary>
        [DataMember(Name = "work_phone", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "work_phone")]
        public string WorkPhone { get; set; }

        /// <summary>
        /// Gets or Sets PrivateNotes
        /// </summary>
        [DataMember(Name = "private_notes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "private_notes")]
        public string PrivateNotes { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name = "website", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "website")]
        public string Website { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name = "is_deleted", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "is_deleted")]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets VatNumber
        /// </summary>
        [DataMember(Name = "vat_number", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vat_number")]
        public string VatNumber { get; set; }

        /// <summary>
        /// Gets or Sets IdNumber
        /// </summary>
        [DataMember(Name = "id_number", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id_number")]
        public string IdNumber { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Vendor {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AccountKey: ").Append(AccountKey).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  WorkPhone: ").Append(WorkPhone).Append("\n");
            sb.Append("  PrivateNotes: ").Append(PrivateNotes).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  VatNumber: ").Append(VatNumber).Append("\n");
            sb.Append("  IdNumber: ").Append(IdNumber).Append("\n");
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
