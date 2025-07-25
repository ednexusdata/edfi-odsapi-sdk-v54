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
    /// EdFiCourseOffering
    /// </summary>
    [DataContract(Name = "edFi_courseOffering")]
    public partial class EdFiCourseOffering : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseOffering" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCourseOffering() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseOffering" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="localCourseCode">The local code assigned by the School that identifies the course offering provided for the instruction of students. (required).</param>
        /// <param name="courseReference">courseReference (required).</param>
        /// <param name="schoolReference">schoolReference (required).</param>
        /// <param name="sessionReference">sessionReference (required).</param>
        /// <param name="courseLevelCharacteristics">An unordered collection of courseOfferingCourseLevelCharacteristics. The type of specific program or designation with which the course offering is associated (e.g., AP, IB, Dual Credit, CTE). This collection should only be populated if it differs from the Course Level Characteristics identified at the Course level..</param>
        /// <param name="curriculumUseds">An unordered collection of courseOfferingCurriculumUseds. The type of curriculum used in an early learning classroom or group..</param>
        /// <param name="instructionalTimePlanned">The planned total number of clock minutes of instruction for this course offering. Generally, this should be at least as many minutes as is required for completion by the related state- or district-defined course..</param>
        /// <param name="localCourseTitle">The descriptive name given to a course of study offered in the school, if different from the CourseTitle..</param>
        /// <param name="offeredGradeLevels">An unordered collection of courseOfferingOfferedGradeLevels. The grade levels in which the course is offered. This collection should only be populated if it differs from the Offered Grade Levels identified at the Course level..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">Extensions to the CourseOffering entity..</param>
        public EdFiCourseOffering(string id = default, string localCourseCode = default, EdFiCourseReference courseReference = default, EdFiSchoolReference schoolReference = default, EdFiSessionReference sessionReference = default, List<EdFiCourseOfferingCourseLevelCharacteristic> courseLevelCharacteristics = default, List<EdFiCourseOfferingCurriculumUsed> curriculumUseds = default, int instructionalTimePlanned = default, string localCourseTitle = default, List<EdFiCourseOfferingOfferedGradeLevel> offeredGradeLevels = default, string etag = default, Object ext = default)
        {
            // to ensure "localCourseCode" is required (not null)
            if (localCourseCode == null)
            {
                throw new ArgumentNullException("localCourseCode is a required property for EdFiCourseOffering and cannot be null");
            }
            this.LocalCourseCode = localCourseCode;
            // to ensure "courseReference" is required (not null)
            if (courseReference == null)
            {
                throw new ArgumentNullException("courseReference is a required property for EdFiCourseOffering and cannot be null");
            }
            this.CourseReference = courseReference;
            // to ensure "schoolReference" is required (not null)
            if (schoolReference == null)
            {
                throw new ArgumentNullException("schoolReference is a required property for EdFiCourseOffering and cannot be null");
            }
            this.SchoolReference = schoolReference;
            // to ensure "sessionReference" is required (not null)
            if (sessionReference == null)
            {
                throw new ArgumentNullException("sessionReference is a required property for EdFiCourseOffering and cannot be null");
            }
            this.SessionReference = sessionReference;
            this.Id = id;
            this.CourseLevelCharacteristics = courseLevelCharacteristics;
            this.CurriculumUseds = curriculumUseds;
            this.InstructionalTimePlanned = instructionalTimePlanned;
            this.LocalCourseTitle = localCourseTitle;
            this.OfferedGradeLevels = offeredGradeLevels;
            this.Etag = etag;
            this.Ext = ext;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The local code assigned by the School that identifies the course offering provided for the instruction of students.
        /// </summary>
        /// <value>The local code assigned by the School that identifies the course offering provided for the instruction of students.</value>
        [DataMember(Name = "localCourseCode", IsRequired = true, EmitDefaultValue = true)]
        public string LocalCourseCode { get; set; }

        /// <summary>
        /// Gets or Sets CourseReference
        /// </summary>
        [DataMember(Name = "courseReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiCourseReference CourseReference { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [DataMember(Name = "schoolReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiSchoolReference SchoolReference { get; set; }

        /// <summary>
        /// Gets or Sets SessionReference
        /// </summary>
        [DataMember(Name = "sessionReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiSessionReference SessionReference { get; set; }

        /// <summary>
        /// An unordered collection of courseOfferingCourseLevelCharacteristics. The type of specific program or designation with which the course offering is associated (e.g., AP, IB, Dual Credit, CTE). This collection should only be populated if it differs from the Course Level Characteristics identified at the Course level.
        /// </summary>
        /// <value>An unordered collection of courseOfferingCourseLevelCharacteristics. The type of specific program or designation with which the course offering is associated (e.g., AP, IB, Dual Credit, CTE). This collection should only be populated if it differs from the Course Level Characteristics identified at the Course level.</value>
        [DataMember(Name = "courseLevelCharacteristics", EmitDefaultValue = false)]
        public List<EdFiCourseOfferingCourseLevelCharacteristic> CourseLevelCharacteristics { get; set; }

        /// <summary>
        /// An unordered collection of courseOfferingCurriculumUseds. The type of curriculum used in an early learning classroom or group.
        /// </summary>
        /// <value>An unordered collection of courseOfferingCurriculumUseds. The type of curriculum used in an early learning classroom or group.</value>
        [DataMember(Name = "curriculumUseds", EmitDefaultValue = false)]
        public List<EdFiCourseOfferingCurriculumUsed> CurriculumUseds { get; set; }

        /// <summary>
        /// The planned total number of clock minutes of instruction for this course offering. Generally, this should be at least as many minutes as is required for completion by the related state- or district-defined course.
        /// </summary>
        /// <value>The planned total number of clock minutes of instruction for this course offering. Generally, this should be at least as many minutes as is required for completion by the related state- or district-defined course.</value>
        [DataMember(Name = "instructionalTimePlanned", EmitDefaultValue = false)]
        public int InstructionalTimePlanned { get; set; }

        /// <summary>
        /// The descriptive name given to a course of study offered in the school, if different from the CourseTitle.
        /// </summary>
        /// <value>The descriptive name given to a course of study offered in the school, if different from the CourseTitle.</value>
        [DataMember(Name = "localCourseTitle", EmitDefaultValue = false)]
        public string LocalCourseTitle { get; set; }

        /// <summary>
        /// An unordered collection of courseOfferingOfferedGradeLevels. The grade levels in which the course is offered. This collection should only be populated if it differs from the Offered Grade Levels identified at the Course level.
        /// </summary>
        /// <value>An unordered collection of courseOfferingOfferedGradeLevels. The grade levels in which the course is offered. This collection should only be populated if it differs from the Offered Grade Levels identified at the Course level.</value>
        [DataMember(Name = "offeredGradeLevels", EmitDefaultValue = false)]
        public List<EdFiCourseOfferingOfferedGradeLevel> OfferedGradeLevels { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name = "_etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// Extensions to the CourseOffering entity.
        /// </summary>
        /// <value>Extensions to the CourseOffering entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiCourseOffering {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LocalCourseCode: ").Append(LocalCourseCode).Append("\n");
            sb.Append("  CourseReference: ").Append(CourseReference).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  SessionReference: ").Append(SessionReference).Append("\n");
            sb.Append("  CourseLevelCharacteristics: ").Append(CourseLevelCharacteristics).Append("\n");
            sb.Append("  CurriculumUseds: ").Append(CurriculumUseds).Append("\n");
            sb.Append("  InstructionalTimePlanned: ").Append(InstructionalTimePlanned).Append("\n");
            sb.Append("  LocalCourseTitle: ").Append(LocalCourseTitle).Append("\n");
            sb.Append("  OfferedGradeLevels: ").Append(OfferedGradeLevels).Append("\n");
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
            // LocalCourseCode (string) maxLength
            if (this.LocalCourseCode != null && this.LocalCourseCode.Length > 60)
            {
                yield return new ValidationResult("Invalid value for LocalCourseCode, length must be less than 60.", new [] { "LocalCourseCode" });
            }

            // LocalCourseTitle (string) maxLength
            if (this.LocalCourseTitle != null && this.LocalCourseTitle.Length > 60)
            {
                yield return new ValidationResult("Invalid value for LocalCourseTitle, length must be less than 60.", new [] { "LocalCourseTitle" });
            }

            yield break;
        }
    }

}
