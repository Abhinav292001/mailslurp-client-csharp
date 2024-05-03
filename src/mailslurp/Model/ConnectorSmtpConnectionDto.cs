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
    /// ConnectorSmtpConnectionDto
    /// </summary>
    [DataContract(Name = "ConnectorSmtpConnectionDto")]
    public partial class ConnectorSmtpConnectionDto : IEquatable<ConnectorSmtpConnectionDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorSmtpConnectionDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConnectorSmtpConnectionDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorSmtpConnectionDto" /> class.
        /// </summary>
        /// <param name="connectorId">connectorId (required).</param>
        /// <param name="smtpHost">smtpHost.</param>
        /// <param name="smtpPort">smtpPort.</param>
        /// <param name="smtpUsername">smtpUsername.</param>
        /// <param name="smtpPassword">smtpPassword.</param>
        /// <param name="smtpSsl">smtpSsl.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="id">id (required).</param>
        public ConnectorSmtpConnectionDto(Guid connectorId = default(Guid), string smtpHost = default(string), int smtpPort = default(int), string smtpUsername = default(string), string smtpPassword = default(string), bool smtpSsl = default(bool), bool enabled = default(bool), DateTime createdAt = default(DateTime), Guid id = default(Guid))
        {
            this.ConnectorId = connectorId;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.SmtpHost = smtpHost;
            this.SmtpPort = smtpPort;
            this.SmtpUsername = smtpUsername;
            this.SmtpPassword = smtpPassword;
            this.SmtpSsl = smtpSsl;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Gets or Sets ConnectorId
        /// </summary>
        [DataMember(Name = "connectorId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ConnectorId { get; set; }

        /// <summary>
        /// Gets or Sets SmtpHost
        /// </summary>
        [DataMember(Name = "smtpHost", EmitDefaultValue = false)]
        public string SmtpHost { get; set; }

        /// <summary>
        /// Gets or Sets SmtpPort
        /// </summary>
        [DataMember(Name = "smtpPort", EmitDefaultValue = false)]
        public int SmtpPort { get; set; }

        /// <summary>
        /// Gets or Sets SmtpUsername
        /// </summary>
        [DataMember(Name = "smtpUsername", EmitDefaultValue = false)]
        public string SmtpUsername { get; set; }

        /// <summary>
        /// Gets or Sets SmtpPassword
        /// </summary>
        [DataMember(Name = "smtpPassword", EmitDefaultValue = false)]
        public string SmtpPassword { get; set; }

        /// <summary>
        /// Gets or Sets SmtpSsl
        /// </summary>
        [DataMember(Name = "smtpSsl", EmitDefaultValue = true)]
        public bool SmtpSsl { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectorSmtpConnectionDto {\n");
            sb.Append("  ConnectorId: ").Append(ConnectorId).Append("\n");
            sb.Append("  SmtpHost: ").Append(SmtpHost).Append("\n");
            sb.Append("  SmtpPort: ").Append(SmtpPort).Append("\n");
            sb.Append("  SmtpUsername: ").Append(SmtpUsername).Append("\n");
            sb.Append("  SmtpPassword: ").Append(SmtpPassword).Append("\n");
            sb.Append("  SmtpSsl: ").Append(SmtpSsl).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as ConnectorSmtpConnectionDto);
        }

        /// <summary>
        /// Returns true if ConnectorSmtpConnectionDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectorSmtpConnectionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorSmtpConnectionDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConnectorId == input.ConnectorId ||
                    (this.ConnectorId != null &&
                    this.ConnectorId.Equals(input.ConnectorId))
                ) && 
                (
                    this.SmtpHost == input.SmtpHost ||
                    (this.SmtpHost != null &&
                    this.SmtpHost.Equals(input.SmtpHost))
                ) && 
                (
                    this.SmtpPort == input.SmtpPort ||
                    this.SmtpPort.Equals(input.SmtpPort)
                ) && 
                (
                    this.SmtpUsername == input.SmtpUsername ||
                    (this.SmtpUsername != null &&
                    this.SmtpUsername.Equals(input.SmtpUsername))
                ) && 
                (
                    this.SmtpPassword == input.SmtpPassword ||
                    (this.SmtpPassword != null &&
                    this.SmtpPassword.Equals(input.SmtpPassword))
                ) && 
                (
                    this.SmtpSsl == input.SmtpSsl ||
                    this.SmtpSsl.Equals(input.SmtpSsl)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.ConnectorId != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectorId.GetHashCode();
                }
                if (this.SmtpHost != null)
                {
                    hashCode = (hashCode * 59) + this.SmtpHost.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SmtpPort.GetHashCode();
                if (this.SmtpUsername != null)
                {
                    hashCode = (hashCode * 59) + this.SmtpUsername.GetHashCode();
                }
                if (this.SmtpPassword != null)
                {
                    hashCode = (hashCode * 59) + this.SmtpPassword.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SmtpSsl.GetHashCode();
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
