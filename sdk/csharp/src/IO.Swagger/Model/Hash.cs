/* 
 * Presidio
 *
 * Context aware, pluggable and customizable PII anonymization service for text and images.
 *
 * OpenAPI spec version: 2.0
 * Contact: presidio@microsoft.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Replace with hashed value
    /// </summary>
    [DataContract]
        public partial class Hash :  IEquatable<Hash>, IValidatableObject
    {
        /// <summary>
        /// The hashing algorithm
        /// </summary>
        /// <value>The hashing algorithm</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum HashTypeEnum
        {
            /// <summary>
            /// Enum Md5 for value: md5
            /// </summary>
            [EnumMember(Value = "md5")]
            Md5 = 1,
            /// <summary>
            /// Enum Sha256 for value: sha256
            /// </summary>
            [EnumMember(Value = "sha256")]
            Sha256 = 2,
            /// <summary>
            /// Enum Sha512 for value: sha512
            /// </summary>
            [EnumMember(Value = "sha512")]
            Sha512 = 3        }
        /// <summary>
        /// The hashing algorithm
        /// </summary>
        /// <value>The hashing algorithm</value>
        [DataMember(Name="hash_type", EmitDefaultValue=false)]
        public HashTypeEnum? HashType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Hash" /> class.
        /// </summary>
        /// <param name="type">hash (required).</param>
        /// <param name="hashType">The hashing algorithm (default to HashTypeEnum.Md5).</param>
        public Hash(string type = default(string), HashTypeEnum? hashType = HashTypeEnum.Md5)
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Hash and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // use default value if no "hashType" provided
            if (hashType == null)
            {
                this.HashType = HashTypeEnum.Md5;
            }
            else
            {
                this.HashType = hashType;
            }
        }
        
        /// <summary>
        /// hash
        /// </summary>
        /// <value>hash</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Hash {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  HashType: ").Append(HashType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Hash);
        }

        /// <summary>
        /// Returns true if Hash instances are equal
        /// </summary>
        /// <param name="input">Instance of Hash to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Hash input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.HashType == input.HashType ||
                    (this.HashType != null &&
                    this.HashType.Equals(input.HashType))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.HashType != null)
                    hashCode = hashCode * 59 + this.HashType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
