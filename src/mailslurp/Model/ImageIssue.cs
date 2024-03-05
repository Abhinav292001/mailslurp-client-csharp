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
    /// ImageIssue
    /// </summary>
    [DataContract(Name = "ImageIssue")]
    public partial class ImageIssue : IEquatable<ImageIssue>, IValidatableObject
    {
        /// <summary>
        /// Defines Severity
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SeverityEnum
        {
            /// <summary>
            /// Enum Warning for value: Warning
            /// </summary>
            [EnumMember(Value = "Warning")]
            Warning = 1,

            /// <summary>
            /// Enum Error for value: Error
            /// </summary>
            [EnumMember(Value = "Error")]
            Error = 2

        }


        /// <summary>
        /// Gets or Sets Severity
        /// </summary>
        [DataMember(Name = "severity", IsRequired = true, EmitDefaultValue = true)]
        public SeverityEnum Severity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageIssue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageIssue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageIssue" /> class.
        /// </summary>
        /// <param name="url">url (required).</param>
        /// <param name="responseStatus">responseStatus.</param>
        /// <param name="severity">severity (required).</param>
        /// <param name="message">message (required).</param>
        public ImageIssue(string url = default(string), int responseStatus = default(int), SeverityEnum severity = default(SeverityEnum), string message = default(string))
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for ImageIssue and cannot be null");
            }
            this.Url = url;
            this.Severity = severity;
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for ImageIssue and cannot be null");
            }
            this.Message = message;
            this.ResponseStatus = responseStatus;
        }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets ResponseStatus
        /// </summary>
        [DataMember(Name = "responseStatus", EmitDefaultValue = false)]
        public int ResponseStatus { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ImageIssue {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ResponseStatus: ").Append(ResponseStatus).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as ImageIssue);
        }

        /// <summary>
        /// Returns true if ImageIssue instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageIssue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageIssue input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.ResponseStatus == input.ResponseStatus ||
                    this.ResponseStatus.Equals(input.ResponseStatus)
                ) && 
                (
                    this.Severity == input.Severity ||
                    this.Severity.Equals(input.Severity)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ResponseStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.Severity.GetHashCode();
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
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
