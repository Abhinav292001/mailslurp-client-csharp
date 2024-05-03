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
    /// Options for IMAP connection to external email inbox. Allows syncing emails iva IMAP.
    /// </summary>
    [DataContract(Name = "CreateConnectorImapConnectionOptions")]
    public partial class CreateConnectorImapConnectionOptions : IEquatable<CreateConnectorImapConnectionOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorImapConnectionOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateConnectorImapConnectionOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorImapConnectionOptions" /> class.
        /// </summary>
        /// <param name="imapSsl">imapSsl.</param>
        /// <param name="imapUsername">imapUsername.</param>
        /// <param name="imapPassword">imapPassword.</param>
        /// <param name="selectFolder">Optional folder to select during IMAP connection.</param>
        /// <param name="searchTerms">searchTerms.</param>
        /// <param name="imapPort">IMAP server port.</param>
        /// <param name="imapHost">IMAP server host (required).</param>
        /// <param name="enabled">IMAP server enabled.</param>
        public CreateConnectorImapConnectionOptions(bool? imapSsl = default(bool?), string imapUsername = default(string), string imapPassword = default(string), string selectFolder = default(string), string searchTerms = default(string), int? imapPort = default(int?), string imapHost = default(string), bool? enabled = default(bool?))
        {
            // to ensure "imapHost" is required (not null)
            if (imapHost == null)
            {
                throw new ArgumentNullException("imapHost is a required property for CreateConnectorImapConnectionOptions and cannot be null");
            }
            this.ImapHost = imapHost;
            this.ImapSsl = imapSsl;
            this.ImapUsername = imapUsername;
            this.ImapPassword = imapPassword;
            this.SelectFolder = selectFolder;
            this.SearchTerms = searchTerms;
            this.ImapPort = imapPort;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Gets or Sets ImapSsl
        /// </summary>
        [DataMember(Name = "imapSsl", EmitDefaultValue = true)]
        public bool? ImapSsl { get; set; }

        /// <summary>
        /// Gets or Sets ImapUsername
        /// </summary>
        [DataMember(Name = "imapUsername", EmitDefaultValue = true)]
        public string ImapUsername { get; set; }

        /// <summary>
        /// Gets or Sets ImapPassword
        /// </summary>
        [DataMember(Name = "imapPassword", EmitDefaultValue = true)]
        public string ImapPassword { get; set; }

        /// <summary>
        /// Optional folder to select during IMAP connection
        /// </summary>
        /// <value>Optional folder to select during IMAP connection</value>
        [DataMember(Name = "selectFolder", EmitDefaultValue = true)]
        public string SelectFolder { get; set; }

        /// <summary>
        /// Gets or Sets SearchTerms
        /// </summary>
        [DataMember(Name = "searchTerms", EmitDefaultValue = true)]
        public string SearchTerms { get; set; }

        /// <summary>
        /// IMAP server port
        /// </summary>
        /// <value>IMAP server port</value>
        [DataMember(Name = "imapPort", EmitDefaultValue = true)]
        public int? ImapPort { get; set; }

        /// <summary>
        /// IMAP server host
        /// </summary>
        /// <value>IMAP server host</value>
        [DataMember(Name = "imapHost", IsRequired = true, EmitDefaultValue = true)]
        public string ImapHost { get; set; }

        /// <summary>
        /// IMAP server enabled
        /// </summary>
        /// <value>IMAP server enabled</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateConnectorImapConnectionOptions {\n");
            sb.Append("  ImapSsl: ").Append(ImapSsl).Append("\n");
            sb.Append("  ImapUsername: ").Append(ImapUsername).Append("\n");
            sb.Append("  ImapPassword: ").Append(ImapPassword).Append("\n");
            sb.Append("  SelectFolder: ").Append(SelectFolder).Append("\n");
            sb.Append("  SearchTerms: ").Append(SearchTerms).Append("\n");
            sb.Append("  ImapPort: ").Append(ImapPort).Append("\n");
            sb.Append("  ImapHost: ").Append(ImapHost).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as CreateConnectorImapConnectionOptions);
        }

        /// <summary>
        /// Returns true if CreateConnectorImapConnectionOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateConnectorImapConnectionOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateConnectorImapConnectionOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ImapSsl == input.ImapSsl ||
                    (this.ImapSsl != null &&
                    this.ImapSsl.Equals(input.ImapSsl))
                ) && 
                (
                    this.ImapUsername == input.ImapUsername ||
                    (this.ImapUsername != null &&
                    this.ImapUsername.Equals(input.ImapUsername))
                ) && 
                (
                    this.ImapPassword == input.ImapPassword ||
                    (this.ImapPassword != null &&
                    this.ImapPassword.Equals(input.ImapPassword))
                ) && 
                (
                    this.SelectFolder == input.SelectFolder ||
                    (this.SelectFolder != null &&
                    this.SelectFolder.Equals(input.SelectFolder))
                ) && 
                (
                    this.SearchTerms == input.SearchTerms ||
                    (this.SearchTerms != null &&
                    this.SearchTerms.Equals(input.SearchTerms))
                ) && 
                (
                    this.ImapPort == input.ImapPort ||
                    (this.ImapPort != null &&
                    this.ImapPort.Equals(input.ImapPort))
                ) && 
                (
                    this.ImapHost == input.ImapHost ||
                    (this.ImapHost != null &&
                    this.ImapHost.Equals(input.ImapHost))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
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
                if (this.ImapSsl != null)
                {
                    hashCode = (hashCode * 59) + this.ImapSsl.GetHashCode();
                }
                if (this.ImapUsername != null)
                {
                    hashCode = (hashCode * 59) + this.ImapUsername.GetHashCode();
                }
                if (this.ImapPassword != null)
                {
                    hashCode = (hashCode * 59) + this.ImapPassword.GetHashCode();
                }
                if (this.SelectFolder != null)
                {
                    hashCode = (hashCode * 59) + this.SelectFolder.GetHashCode();
                }
                if (this.SearchTerms != null)
                {
                    hashCode = (hashCode * 59) + this.SearchTerms.GetHashCode();
                }
                if (this.ImapPort != null)
                {
                    hashCode = (hashCode * 59) + this.ImapPort.GetHashCode();
                }
                if (this.ImapHost != null)
                {
                    hashCode = (hashCode * 59) + this.ImapHost.GetHashCode();
                }
                if (this.Enabled != null)
                {
                    hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
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
