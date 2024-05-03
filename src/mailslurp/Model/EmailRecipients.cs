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
    /// The &#x60;To&#x60;,&#x60;CC&#x60;,&#x60;BCC&#x60; recipients stored in object form with email address and name accessible.
    /// </summary>
    [DataContract(Name = "EmailRecipients")]
    public partial class EmailRecipients : IEquatable<EmailRecipients>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailRecipients" /> class.
        /// </summary>
        /// <param name="to">to.</param>
        /// <param name="cc">cc.</param>
        /// <param name="bcc">bcc.</param>
        public EmailRecipients(List<Recipient> to = default(List<Recipient>), List<Recipient> cc = default(List<Recipient>), List<Recipient> bcc = default(List<Recipient>))
        {
            this.To = to;
            this.Cc = cc;
            this.Bcc = bcc;
        }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public List<Recipient> To { get; set; }

        /// <summary>
        /// Gets or Sets Cc
        /// </summary>
        [DataMember(Name = "cc", EmitDefaultValue = false)]
        public List<Recipient> Cc { get; set; }

        /// <summary>
        /// Gets or Sets Bcc
        /// </summary>
        [DataMember(Name = "bcc", EmitDefaultValue = false)]
        public List<Recipient> Bcc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailRecipients {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
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
            return this.Equals(input as EmailRecipients);
        }

        /// <summary>
        /// Returns true if EmailRecipients instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailRecipients to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailRecipients input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.To == input.To ||
                    this.To != null &&
                    input.To != null &&
                    this.To.SequenceEqual(input.To)
                ) && 
                (
                    this.Cc == input.Cc ||
                    this.Cc != null &&
                    input.Cc != null &&
                    this.Cc.SequenceEqual(input.Cc)
                ) && 
                (
                    this.Bcc == input.Bcc ||
                    this.Bcc != null &&
                    input.Bcc != null &&
                    this.Bcc.SequenceEqual(input.Bcc)
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
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.Cc != null)
                {
                    hashCode = (hashCode * 59) + this.Cc.GetHashCode();
                }
                if (this.Bcc != null)
                {
                    hashCode = (hashCode * 59) + this.Bcc.GetHashCode();
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
