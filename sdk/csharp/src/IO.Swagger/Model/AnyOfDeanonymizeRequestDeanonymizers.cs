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
    /// AnyOfDeanonymizeRequestDeanonymizers
    /// </summary>
    [DataContract]
        public partial class AnyOfDeanonymizeRequestDeanonymizers :  IEquatable<AnyOfDeanonymizeRequestDeanonymizers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnyOfDeanonymizeRequestDeanonymizers" /> class.
        /// </summary>
        public AnyOfDeanonymizeRequestDeanonymizers()
        {
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnyOfDeanonymizeRequestDeanonymizers {\n");
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
            return this.Equals(input as AnyOfDeanonymizeRequestDeanonymizers);
        }

        /// <summary>
        /// Returns true if AnyOfDeanonymizeRequestDeanonymizers instances are equal
        /// </summary>
        /// <param name="input">Instance of AnyOfDeanonymizeRequestDeanonymizers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnyOfDeanonymizeRequestDeanonymizers input)
        {
            if (input == null)
                return false;

            return false;
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
