/*
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * The version of the OpenAPI document: 3
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
using OpenAPIDateConverter = EdFi.OdsApi.Sdk.v54.Client.OpenAPIDateConverter;

namespace EdFi.OdsApi.Sdk.v54.Models.All
{
    /// <summary>
    /// EdFiStudentEducationOrganizationAssociationLanguageUse
    /// </summary>
    [DataContract(Name = "edFi_studentEducationOrganizationAssociationLanguageUse")]
    public partial class EdFiStudentEducationOrganizationAssociationLanguageUse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationLanguageUse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentEducationOrganizationAssociationLanguageUse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationLanguageUse" /> class.
        /// </summary>
        /// <param name="languageUseDescriptor">A description of how the language is used (e.g. Home Language, Native Language, Spoken Language). (required).</param>
        /// <param name="ext">Extensions to the StudentEducationOrganizationAssociationLanguageUse entity..</param>
        public EdFiStudentEducationOrganizationAssociationLanguageUse(string languageUseDescriptor = default, Object ext = default)
        {
            // to ensure "languageUseDescriptor" is required (not null)
            if (languageUseDescriptor == null)
            {
                throw new ArgumentNullException("languageUseDescriptor is a required property for EdFiStudentEducationOrganizationAssociationLanguageUse and cannot be null");
            }
            this.LanguageUseDescriptor = languageUseDescriptor;
            this.Ext = ext;
        }

        /// <summary>
        /// A description of how the language is used (e.g. Home Language, Native Language, Spoken Language).
        /// </summary>
        /// <value>A description of how the language is used (e.g. Home Language, Native Language, Spoken Language).</value>
        [DataMember(Name = "languageUseDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string LanguageUseDescriptor { get; set; }

        /// <summary>
        /// Extensions to the StudentEducationOrganizationAssociationLanguageUse entity.
        /// </summary>
        /// <value>Extensions to the StudentEducationOrganizationAssociationLanguageUse entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentEducationOrganizationAssociationLanguageUse {\n");
            sb.Append("  LanguageUseDescriptor: ").Append(LanguageUseDescriptor).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // LanguageUseDescriptor (string) maxLength
            if (this.LanguageUseDescriptor != null && this.LanguageUseDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for LanguageUseDescriptor, length must be less than 306.", new [] { "LanguageUseDescriptor" });
            }

            yield break;
        }
    }

}
