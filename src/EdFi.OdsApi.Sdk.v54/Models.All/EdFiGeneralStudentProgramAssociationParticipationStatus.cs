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
    /// EdFiGeneralStudentProgramAssociationParticipationStatus
    /// </summary>
    [DataContract(Name = "edFi_generalStudentProgramAssociationParticipationStatus")]
    public partial class EdFiGeneralStudentProgramAssociationParticipationStatus : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGeneralStudentProgramAssociationParticipationStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiGeneralStudentProgramAssociationParticipationStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGeneralStudentProgramAssociationParticipationStatus" /> class.
        /// </summary>
        /// <param name="participationStatusDescriptor">The student&#39;s program participation status. (required).</param>
        /// <param name="designatedBy">The person, organization, or department that designated the participation status..</param>
        /// <param name="statusBeginDate">The date the student&#39;s program participation status began..</param>
        /// <param name="statusEndDate">The date the student&#39;s program participation status ended..</param>
        /// <param name="ext">Extensions to the GeneralStudentProgramAssociationParticipationStatus entity..</param>
        public EdFiGeneralStudentProgramAssociationParticipationStatus(string participationStatusDescriptor = default, string designatedBy = default, DateOnly statusBeginDate = default, DateOnly statusEndDate = default, Object ext = default)
        {
            // to ensure "participationStatusDescriptor" is required (not null)
            if (participationStatusDescriptor == null)
            {
                throw new ArgumentNullException("participationStatusDescriptor is a required property for EdFiGeneralStudentProgramAssociationParticipationStatus and cannot be null");
            }
            this.ParticipationStatusDescriptor = participationStatusDescriptor;
            this.DesignatedBy = designatedBy;
            this.StatusBeginDate = statusBeginDate;
            this.StatusEndDate = statusEndDate;
            this.Ext = ext;
        }

        /// <summary>
        /// The student&#39;s program participation status.
        /// </summary>
        /// <value>The student&#39;s program participation status.</value>
        [DataMember(Name = "participationStatusDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string ParticipationStatusDescriptor { get; set; }

        /// <summary>
        /// The person, organization, or department that designated the participation status.
        /// </summary>
        /// <value>The person, organization, or department that designated the participation status.</value>
        [DataMember(Name = "designatedBy", EmitDefaultValue = false)]
        public string DesignatedBy { get; set; }

        /// <summary>
        /// The date the student&#39;s program participation status began.
        /// </summary>
        /// <value>The date the student&#39;s program participation status began.</value>
        [DataMember(Name = "statusBeginDate", EmitDefaultValue = false)]
        public DateOnly StatusBeginDate { get; set; }

        /// <summary>
        /// The date the student&#39;s program participation status ended.
        /// </summary>
        /// <value>The date the student&#39;s program participation status ended.</value>
        [DataMember(Name = "statusEndDate", EmitDefaultValue = false)]
        public DateOnly StatusEndDate { get; set; }

        /// <summary>
        /// Extensions to the GeneralStudentProgramAssociationParticipationStatus entity.
        /// </summary>
        /// <value>Extensions to the GeneralStudentProgramAssociationParticipationStatus entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiGeneralStudentProgramAssociationParticipationStatus {\n");
            sb.Append("  ParticipationStatusDescriptor: ").Append(ParticipationStatusDescriptor).Append("\n");
            sb.Append("  DesignatedBy: ").Append(DesignatedBy).Append("\n");
            sb.Append("  StatusBeginDate: ").Append(StatusBeginDate).Append("\n");
            sb.Append("  StatusEndDate: ").Append(StatusEndDate).Append("\n");
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
            // ParticipationStatusDescriptor (string) maxLength
            if (this.ParticipationStatusDescriptor != null && this.ParticipationStatusDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for ParticipationStatusDescriptor, length must be less than 306.", new [] { "ParticipationStatusDescriptor" });
            }

            // DesignatedBy (string) maxLength
            if (this.DesignatedBy != null && this.DesignatedBy.Length > 60)
            {
                yield return new ValidationResult("Invalid value for DesignatedBy, length must be less than 60.", new [] { "DesignatedBy" });
            }

            yield break;
        }
    }

}
