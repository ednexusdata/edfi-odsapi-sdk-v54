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
    /// EdFiSurveyProgramAssociation
    /// </summary>
    [DataContract(Name = "edFi_surveyProgramAssociation")]
    public partial class EdFiSurveyProgramAssociation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSurveyProgramAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSurveyProgramAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSurveyProgramAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="programReference">programReference (required).</param>
        /// <param name="surveyReference">surveyReference (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">Extensions to the SurveyProgramAssociation entity..</param>
        public EdFiSurveyProgramAssociation(string id = default, EdFiProgramReference programReference = default, EdFiSurveyReference surveyReference = default, string etag = default, Object ext = default)
        {
            // to ensure "programReference" is required (not null)
            if (programReference == null)
            {
                throw new ArgumentNullException("programReference is a required property for EdFiSurveyProgramAssociation and cannot be null");
            }
            this.ProgramReference = programReference;
            // to ensure "surveyReference" is required (not null)
            if (surveyReference == null)
            {
                throw new ArgumentNullException("surveyReference is a required property for EdFiSurveyProgramAssociation and cannot be null");
            }
            this.SurveyReference = surveyReference;
            this.Id = id;
            this.Etag = etag;
            this.Ext = ext;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ProgramReference
        /// </summary>
        [DataMember(Name = "programReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiProgramReference ProgramReference { get; set; }

        /// <summary>
        /// Gets or Sets SurveyReference
        /// </summary>
        [DataMember(Name = "surveyReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiSurveyReference SurveyReference { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name = "_etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// Extensions to the SurveyProgramAssociation entity.
        /// </summary>
        /// <value>Extensions to the SurveyProgramAssociation entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiSurveyProgramAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProgramReference: ").Append(ProgramReference).Append("\n");
            sb.Append("  SurveyReference: ").Append(SurveyReference).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
            yield break;
        }
    }

}
