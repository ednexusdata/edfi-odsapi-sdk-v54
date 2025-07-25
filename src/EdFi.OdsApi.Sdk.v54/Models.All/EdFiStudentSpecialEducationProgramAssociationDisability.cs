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
    /// EdFiStudentSpecialEducationProgramAssociationDisability
    /// </summary>
    [DataContract(Name = "edFi_studentSpecialEducationProgramAssociationDisability")]
    public partial class EdFiStudentSpecialEducationProgramAssociationDisability : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSpecialEducationProgramAssociationDisability" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentSpecialEducationProgramAssociationDisability() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSpecialEducationProgramAssociationDisability" /> class.
        /// </summary>
        /// <param name="disabilityDescriptor">A disability category that describes a child&#39;s impairment. (required).</param>
        /// <param name="disabilityDeterminationSourceTypeDescriptor">The source that provided the disability determination..</param>
        /// <param name="disabilityDiagnosis">A description of the disability diagnosis..</param>
        /// <param name="orderOfDisability">The order by severity of student&#39;s disabilities: 1- Primary, 2 -  Secondary, 3 - Tertiary, etc..</param>
        /// <param name="designations">An unordered collection of studentSpecialEducationProgramAssociationDisabilityDesignations. Whether the disability is IDEA, Section 504, or other disability designation..</param>
        /// <param name="ext">Extensions to the StudentSpecialEducationProgramAssociationDisability entity..</param>
        public EdFiStudentSpecialEducationProgramAssociationDisability(string disabilityDescriptor = default, string disabilityDeterminationSourceTypeDescriptor = default, string disabilityDiagnosis = default, int orderOfDisability = default, List<EdFiStudentSpecialEducationProgramAssociationDisabilityDesignation> designations = default, Object ext = default)
        {
            // to ensure "disabilityDescriptor" is required (not null)
            if (disabilityDescriptor == null)
            {
                throw new ArgumentNullException("disabilityDescriptor is a required property for EdFiStudentSpecialEducationProgramAssociationDisability and cannot be null");
            }
            this.DisabilityDescriptor = disabilityDescriptor;
            this.DisabilityDeterminationSourceTypeDescriptor = disabilityDeterminationSourceTypeDescriptor;
            this.DisabilityDiagnosis = disabilityDiagnosis;
            this.OrderOfDisability = orderOfDisability;
            this.Designations = designations;
            this.Ext = ext;
        }

        /// <summary>
        /// A disability category that describes a child&#39;s impairment.
        /// </summary>
        /// <value>A disability category that describes a child&#39;s impairment.</value>
        [DataMember(Name = "disabilityDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string DisabilityDescriptor { get; set; }

        /// <summary>
        /// The source that provided the disability determination.
        /// </summary>
        /// <value>The source that provided the disability determination.</value>
        [DataMember(Name = "disabilityDeterminationSourceTypeDescriptor", EmitDefaultValue = false)]
        public string DisabilityDeterminationSourceTypeDescriptor { get; set; }

        /// <summary>
        /// A description of the disability diagnosis.
        /// </summary>
        /// <value>A description of the disability diagnosis.</value>
        [DataMember(Name = "disabilityDiagnosis", EmitDefaultValue = false)]
        public string DisabilityDiagnosis { get; set; }

        /// <summary>
        /// The order by severity of student&#39;s disabilities: 1- Primary, 2 -  Secondary, 3 - Tertiary, etc.
        /// </summary>
        /// <value>The order by severity of student&#39;s disabilities: 1- Primary, 2 -  Secondary, 3 - Tertiary, etc.</value>
        [DataMember(Name = "orderOfDisability", EmitDefaultValue = false)]
        public int OrderOfDisability { get; set; }

        /// <summary>
        /// An unordered collection of studentSpecialEducationProgramAssociationDisabilityDesignations. Whether the disability is IDEA, Section 504, or other disability designation.
        /// </summary>
        /// <value>An unordered collection of studentSpecialEducationProgramAssociationDisabilityDesignations. Whether the disability is IDEA, Section 504, or other disability designation.</value>
        [DataMember(Name = "designations", EmitDefaultValue = false)]
        public List<EdFiStudentSpecialEducationProgramAssociationDisabilityDesignation> Designations { get; set; }

        /// <summary>
        /// Extensions to the StudentSpecialEducationProgramAssociationDisability entity.
        /// </summary>
        /// <value>Extensions to the StudentSpecialEducationProgramAssociationDisability entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentSpecialEducationProgramAssociationDisability {\n");
            sb.Append("  DisabilityDescriptor: ").Append(DisabilityDescriptor).Append("\n");
            sb.Append("  DisabilityDeterminationSourceTypeDescriptor: ").Append(DisabilityDeterminationSourceTypeDescriptor).Append("\n");
            sb.Append("  DisabilityDiagnosis: ").Append(DisabilityDiagnosis).Append("\n");
            sb.Append("  OrderOfDisability: ").Append(OrderOfDisability).Append("\n");
            sb.Append("  Designations: ").Append(Designations).Append("\n");
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
            // DisabilityDescriptor (string) maxLength
            if (this.DisabilityDescriptor != null && this.DisabilityDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for DisabilityDescriptor, length must be less than 306.", new [] { "DisabilityDescriptor" });
            }

            // DisabilityDeterminationSourceTypeDescriptor (string) maxLength
            if (this.DisabilityDeterminationSourceTypeDescriptor != null && this.DisabilityDeterminationSourceTypeDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for DisabilityDeterminationSourceTypeDescriptor, length must be less than 306.", new [] { "DisabilityDeterminationSourceTypeDescriptor" });
            }

            // DisabilityDiagnosis (string) maxLength
            if (this.DisabilityDiagnosis != null && this.DisabilityDiagnosis.Length > 80)
            {
                yield return new ValidationResult("Invalid value for DisabilityDiagnosis, length must be less than 80.", new [] { "DisabilityDiagnosis" });
            }

            yield break;
        }
    }

}
