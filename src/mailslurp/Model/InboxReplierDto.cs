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
    /// Inbox replier. Will automatically reply to inbound emails that match given field for an inbox.
    /// </summary>
    [DataContract(Name = "InboxReplierDto")]
    public partial class InboxReplierDto : IEquatable<InboxReplierDto>, IValidatableObject
    {
        /// <summary>
        /// Defines Field
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldEnum
        {
            /// <summary>
            /// Enum RECIPIENTS for value: RECIPIENTS
            /// </summary>
            [EnumMember(Value = "RECIPIENTS")]
            RECIPIENTS = 1,

            /// <summary>
            /// Enum SENDER for value: SENDER
            /// </summary>
            [EnumMember(Value = "SENDER")]
            SENDER = 2,

            /// <summary>
            /// Enum SUBJECT for value: SUBJECT
            /// </summary>
            [EnumMember(Value = "SUBJECT")]
            SUBJECT = 3,

            /// <summary>
            /// Enum ATTACHMENTS for value: ATTACHMENTS
            /// </summary>
            [EnumMember(Value = "ATTACHMENTS")]
            ATTACHMENTS = 4

        }


        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name = "field", IsRequired = true, EmitDefaultValue = true)]
        public FieldEnum Field { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboxReplierDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InboxReplierDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboxReplierDto" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="inboxId">inboxId (required).</param>
        /// <param name="name">name.</param>
        /// <param name="field">field (required).</param>
        /// <param name="match">match (required).</param>
        /// <param name="replyTo">replyTo.</param>
        /// <param name="subject">subject.</param>
        /// <param name="from">from.</param>
        /// <param name="charset">charset.</param>
        /// <param name="isHTML">isHTML (required).</param>
        /// <param name="templateId">templateId.</param>
        /// <param name="templateVariables">templateVariables.</param>
        /// <param name="ignoreReplyTo">ignoreReplyTo (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        public InboxReplierDto(Guid id = default(Guid), Guid inboxId = default(Guid), string name = default(string), FieldEnum field = default(FieldEnum), string match = default(string), string replyTo = default(string), string subject = default(string), string from = default(string), string charset = default(string), bool isHTML = default(bool), Guid? templateId = default(Guid?), Dictionary<string, Object> templateVariables = default(Dictionary<string, Object>), bool ignoreReplyTo = default(bool), DateTime createdAt = default(DateTime))
        {
            this.Id = id;
            this.InboxId = inboxId;
            this.Field = field;
            // to ensure "match" is required (not null)
            if (match == null)
            {
                throw new ArgumentNullException("match is a required property for InboxReplierDto and cannot be null");
            }
            this.Match = match;
            this.IsHTML = isHTML;
            this.IgnoreReplyTo = ignoreReplyTo;
            this.CreatedAt = createdAt;
            this.Name = name;
            this.ReplyTo = replyTo;
            this.Subject = subject;
            this.From = from;
            this.Charset = charset;
            this.TemplateId = templateId;
            this.TemplateVariables = templateVariables;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets InboxId
        /// </summary>
        [DataMember(Name = "inboxId", IsRequired = true, EmitDefaultValue = true)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Match
        /// </summary>
        [DataMember(Name = "match", IsRequired = true, EmitDefaultValue = true)]
        public string Match { get; set; }

        /// <summary>
        /// Gets or Sets ReplyTo
        /// </summary>
        [DataMember(Name = "replyTo", EmitDefaultValue = true)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name = "from", EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets Charset
        /// </summary>
        [DataMember(Name = "charset", EmitDefaultValue = true)]
        public string Charset { get; set; }

        /// <summary>
        /// Gets or Sets IsHTML
        /// </summary>
        [DataMember(Name = "isHTML", IsRequired = true, EmitDefaultValue = true)]
        public bool IsHTML { get; set; }

        /// <summary>
        /// Gets or Sets TemplateId
        /// </summary>
        [DataMember(Name = "templateId", EmitDefaultValue = true)]
        public Guid? TemplateId { get; set; }

        /// <summary>
        /// Gets or Sets TemplateVariables
        /// </summary>
        [DataMember(Name = "templateVariables", EmitDefaultValue = true)]
        public Dictionary<string, Object> TemplateVariables { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreReplyTo
        /// </summary>
        [DataMember(Name = "ignoreReplyTo", IsRequired = true, EmitDefaultValue = true)]
        public bool IgnoreReplyTo { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InboxReplierDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Match: ").Append(Match).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Charset: ").Append(Charset).Append("\n");
            sb.Append("  IsHTML: ").Append(IsHTML).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  TemplateVariables: ").Append(TemplateVariables).Append("\n");
            sb.Append("  IgnoreReplyTo: ").Append(IgnoreReplyTo).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as InboxReplierDto);
        }

        /// <summary>
        /// Returns true if InboxReplierDto instances are equal
        /// </summary>
        /// <param name="input">Instance of InboxReplierDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboxReplierDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InboxId == input.InboxId ||
                    (this.InboxId != null &&
                    this.InboxId.Equals(input.InboxId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Field == input.Field ||
                    this.Field.Equals(input.Field)
                ) && 
                (
                    this.Match == input.Match ||
                    (this.Match != null &&
                    this.Match.Equals(input.Match))
                ) && 
                (
                    this.ReplyTo == input.ReplyTo ||
                    (this.ReplyTo != null &&
                    this.ReplyTo.Equals(input.ReplyTo))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Charset == input.Charset ||
                    (this.Charset != null &&
                    this.Charset.Equals(input.Charset))
                ) && 
                (
                    this.IsHTML == input.IsHTML ||
                    this.IsHTML.Equals(input.IsHTML)
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.TemplateVariables == input.TemplateVariables ||
                    this.TemplateVariables != null &&
                    input.TemplateVariables != null &&
                    this.TemplateVariables.SequenceEqual(input.TemplateVariables)
                ) && 
                (
                    this.IgnoreReplyTo == input.IgnoreReplyTo ||
                    this.IgnoreReplyTo.Equals(input.IgnoreReplyTo)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.InboxId != null)
                {
                    hashCode = (hashCode * 59) + this.InboxId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Field.GetHashCode();
                if (this.Match != null)
                {
                    hashCode = (hashCode * 59) + this.Match.GetHashCode();
                }
                if (this.ReplyTo != null)
                {
                    hashCode = (hashCode * 59) + this.ReplyTo.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.Charset != null)
                {
                    hashCode = (hashCode * 59) + this.Charset.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsHTML.GetHashCode();
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.TemplateVariables != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateVariables.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IgnoreReplyTo.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
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
