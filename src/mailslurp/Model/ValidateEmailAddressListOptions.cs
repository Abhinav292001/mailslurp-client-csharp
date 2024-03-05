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
    /// Options for validating a list of email addresses
    /// </summary>
    [DataContract(Name = "ValidateEmailAddressListOptions")]
    public partial class ValidateEmailAddressListOptions : IEquatable<ValidateEmailAddressListOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateEmailAddressListOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValidateEmailAddressListOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateEmailAddressListOptions" /> class.
        /// </summary>
        /// <param name="emailAddressList">emailAddressList (required).</param>
        /// <param name="ignoreOldResults">ignoreOldResults.</param>
        public ValidateEmailAddressListOptions(List<string> emailAddressList = default(List<string>), bool? ignoreOldResults = default(bool?))
        {
            // to ensure "emailAddressList" is required (not null)
            if (emailAddressList == null)
            {
                throw new ArgumentNullException("emailAddressList is a required property for ValidateEmailAddressListOptions and cannot be null");
            }
            this.EmailAddressList = emailAddressList;
            this.IgnoreOldResults = ignoreOldResults;
        }

        /// <summary>
        /// Gets or Sets EmailAddressList
        /// </summary>
        [DataMember(Name = "emailAddressList", IsRequired = true, EmitDefaultValue = true)]
        public List<string> EmailAddressList { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreOldResults
        /// </summary>
        [DataMember(Name = "ignoreOldResults", EmitDefaultValue = true)]
        public bool? IgnoreOldResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValidateEmailAddressListOptions {\n");
            sb.Append("  EmailAddressList: ").Append(EmailAddressList).Append("\n");
            sb.Append("  IgnoreOldResults: ").Append(IgnoreOldResults).Append("\n");
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
            return this.Equals(input as ValidateEmailAddressListOptions);
        }

        /// <summary>
        /// Returns true if ValidateEmailAddressListOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidateEmailAddressListOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateEmailAddressListOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EmailAddressList == input.EmailAddressList ||
                    this.EmailAddressList != null &&
                    input.EmailAddressList != null &&
                    this.EmailAddressList.SequenceEqual(input.EmailAddressList)
                ) && 
                (
                    this.IgnoreOldResults == input.IgnoreOldResults ||
                    (this.IgnoreOldResults != null &&
                    this.IgnoreOldResults.Equals(input.IgnoreOldResults))
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
                if (this.EmailAddressList != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddressList.GetHashCode();
                }
                if (this.IgnoreOldResults != null)
                {
                    hashCode = (hashCode * 59) + this.IgnoreOldResults.GetHashCode();
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
