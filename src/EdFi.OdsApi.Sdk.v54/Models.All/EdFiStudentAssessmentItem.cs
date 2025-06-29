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
    /// EdFiStudentAssessmentItem
    /// </summary>
    [DataContract(Name = "edFi_studentAssessmentItem")]
    public partial class EdFiStudentAssessmentItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAssessmentItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentAssessmentItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAssessmentItem" /> class.
        /// </summary>
        /// <param name="assessmentItemResultDescriptor">The analyzed result of a student&#39;s response to an assessment item. For example:        Correct        Incorrect         Met standard        ... (required).</param>
        /// <param name="responseIndicatorDescriptor">Indicator of the response. For example:        Nonscorable response        Ineffective response        Effective response        Partial response        ....</param>
        /// <param name="assessmentResponse">A student&#39;s response to a stimulus on a test..</param>
        /// <param name="descriptiveFeedback">The formative descriptive feedback that was given to a learner in response to the results from a scored/evaluated assessment item..</param>
        /// <param name="rawScoreResult">A meaningful raw score of the performance of an individual on an assessment item..</param>
        /// <param name="timeAssessed">The overall time a student actually spent during the AssessmentItem..</param>
        /// <param name="assessmentItemReference">assessmentItemReference (required).</param>
        /// <param name="ext">Extensions to the StudentAssessmentItem entity..</param>
        public EdFiStudentAssessmentItem(string assessmentItemResultDescriptor = default, string responseIndicatorDescriptor = default, string assessmentResponse = default, string descriptiveFeedback = default, double rawScoreResult = default, string timeAssessed = default, EdFiAssessmentItemReference assessmentItemReference = default, Object ext = default)
        {
            // to ensure "assessmentItemResultDescriptor" is required (not null)
            if (assessmentItemResultDescriptor == null)
            {
                throw new ArgumentNullException("assessmentItemResultDescriptor is a required property for EdFiStudentAssessmentItem and cannot be null");
            }
            this.AssessmentItemResultDescriptor = assessmentItemResultDescriptor;
            // to ensure "assessmentItemReference" is required (not null)
            if (assessmentItemReference == null)
            {
                throw new ArgumentNullException("assessmentItemReference is a required property for EdFiStudentAssessmentItem and cannot be null");
            }
            this.AssessmentItemReference = assessmentItemReference;
            this.ResponseIndicatorDescriptor = responseIndicatorDescriptor;
            this.AssessmentResponse = assessmentResponse;
            this.DescriptiveFeedback = descriptiveFeedback;
            this.RawScoreResult = rawScoreResult;
            this.TimeAssessed = timeAssessed;
            this.Ext = ext;
        }

        /// <summary>
        /// The analyzed result of a student&#39;s response to an assessment item. For example:        Correct        Incorrect         Met standard        ...
        /// </summary>
        /// <value>The analyzed result of a student&#39;s response to an assessment item. For example:        Correct        Incorrect         Met standard        ...</value>
        [DataMember(Name = "assessmentItemResultDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string AssessmentItemResultDescriptor { get; set; }

        /// <summary>
        /// Indicator of the response. For example:        Nonscorable response        Ineffective response        Effective response        Partial response        ...
        /// </summary>
        /// <value>Indicator of the response. For example:        Nonscorable response        Ineffective response        Effective response        Partial response        ...</value>
        [DataMember(Name = "responseIndicatorDescriptor", EmitDefaultValue = false)]
        public string ResponseIndicatorDescriptor { get; set; }

        /// <summary>
        /// A student&#39;s response to a stimulus on a test.
        /// </summary>
        /// <value>A student&#39;s response to a stimulus on a test.</value>
        [DataMember(Name = "assessmentResponse", EmitDefaultValue = false)]
        public string AssessmentResponse { get; set; }

        /// <summary>
        /// The formative descriptive feedback that was given to a learner in response to the results from a scored/evaluated assessment item.
        /// </summary>
        /// <value>The formative descriptive feedback that was given to a learner in response to the results from a scored/evaluated assessment item.</value>
        [DataMember(Name = "descriptiveFeedback", EmitDefaultValue = false)]
        public string DescriptiveFeedback { get; set; }

        /// <summary>
        /// A meaningful raw score of the performance of an individual on an assessment item.
        /// </summary>
        /// <value>A meaningful raw score of the performance of an individual on an assessment item.</value>
        [DataMember(Name = "rawScoreResult", EmitDefaultValue = false)]
        public double RawScoreResult { get; set; }

        /// <summary>
        /// The overall time a student actually spent during the AssessmentItem.
        /// </summary>
        /// <value>The overall time a student actually spent during the AssessmentItem.</value>
        [DataMember(Name = "timeAssessed", EmitDefaultValue = false)]
        public string TimeAssessed { get; set; }

        /// <summary>
        /// Gets or Sets AssessmentItemReference
        /// </summary>
        [DataMember(Name = "assessmentItemReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiAssessmentItemReference AssessmentItemReference { get; set; }

        /// <summary>
        /// Extensions to the StudentAssessmentItem entity.
        /// </summary>
        /// <value>Extensions to the StudentAssessmentItem entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentAssessmentItem {\n");
            sb.Append("  AssessmentItemResultDescriptor: ").Append(AssessmentItemResultDescriptor).Append("\n");
            sb.Append("  ResponseIndicatorDescriptor: ").Append(ResponseIndicatorDescriptor).Append("\n");
            sb.Append("  AssessmentResponse: ").Append(AssessmentResponse).Append("\n");
            sb.Append("  DescriptiveFeedback: ").Append(DescriptiveFeedback).Append("\n");
            sb.Append("  RawScoreResult: ").Append(RawScoreResult).Append("\n");
            sb.Append("  TimeAssessed: ").Append(TimeAssessed).Append("\n");
            sb.Append("  AssessmentItemReference: ").Append(AssessmentItemReference).Append("\n");
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
            // AssessmentItemResultDescriptor (string) maxLength
            if (this.AssessmentItemResultDescriptor != null && this.AssessmentItemResultDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for AssessmentItemResultDescriptor, length must be less than 306.", new [] { "AssessmentItemResultDescriptor" });
            }

            // ResponseIndicatorDescriptor (string) maxLength
            if (this.ResponseIndicatorDescriptor != null && this.ResponseIndicatorDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for ResponseIndicatorDescriptor, length must be less than 306.", new [] { "ResponseIndicatorDescriptor" });
            }

            // AssessmentResponse (string) maxLength
            if (this.AssessmentResponse != null && this.AssessmentResponse.Length > 60)
            {
                yield return new ValidationResult("Invalid value for AssessmentResponse, length must be less than 60.", new [] { "AssessmentResponse" });
            }

            // DescriptiveFeedback (string) maxLength
            if (this.DescriptiveFeedback != null && this.DescriptiveFeedback.Length > 1024)
            {
                yield return new ValidationResult("Invalid value for DescriptiveFeedback, length must be less than 1024.", new [] { "DescriptiveFeedback" });
            }

            // TimeAssessed (string) maxLength
            if (this.TimeAssessed != null && this.TimeAssessed.Length > 30)
            {
                yield return new ValidationResult("Invalid value for TimeAssessed, length must be less than 30.", new [] { "TimeAssessed" });
            }

            yield break;
        }
    }

}
