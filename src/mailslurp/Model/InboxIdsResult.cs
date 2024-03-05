/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://docs.mailslurp.com/) - [Examples](https://github.com/mailslurp/examples) repository
 *
 * The version of the OpenAPI document: 6.5.2
 * Contact: contact@mailslurp.dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = mailslurp.Client.OpenAPIDateConverter;

namespace mailslurp.Model
{
    /// <summary>
    /// List of inbox IDs and email addresses
    /// </summary>
    [DataContract(Name = "InboxIdsResult")]
    public partial class InboxIdsResult : IEquatable<InboxIdsResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InboxIdsResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InboxIdsResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboxIdsResult" /> class.
        /// </summary>
        /// <param name="inboxIds">inboxIds (required).</param>
        public InboxIdsResult(List<InboxIdItem> inboxIds = default(List<InboxIdItem>))
        {
            // to ensure "inboxIds" is required (not null)
            if (inboxIds == null)
            {
                throw new ArgumentNullException("inboxIds is a required property for InboxIdsResult and cannot be null");
            }
            this.InboxIds = inboxIds;
        }

        /// <summary>
        /// Gets or Sets InboxIds
        /// </summary>
        [DataMember(Name = "inboxIds", IsRequired = true, EmitDefaultValue = true)]
        public List<InboxIdItem> InboxIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InboxIdsResult {\n");
            sb.Append("  InboxIds: ").Append(InboxIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InboxIdsResult);
        }

        /// <summary>
        /// Returns true if InboxIdsResult instances are equal
        /// </summary>
        /// <param name="input">Instance of InboxIdsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboxIdsResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InboxIds == input.InboxIds ||
                    this.InboxIds != null &&
                    input.InboxIds != null &&
                    this.InboxIds.SequenceEqual(input.InboxIds)
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
                if (this.InboxIds != null)
                {
                    hashCode = (hashCode * 59) + this.InboxIds.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
