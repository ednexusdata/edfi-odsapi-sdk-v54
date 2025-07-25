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
    /// EdFiEducationContent
    /// </summary>
    [DataContract(Name = "edFi_educationContent")]
    public partial class EdFiEducationContent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiEducationContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationContent" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="contentIdentifier">A unique identifier for the EducationContent. (required).</param>
        /// <param name="learningStandardReference">learningStandardReference.</param>
        /// <param name="additionalAuthorsIndicator">Indicates whether there are additional un-named authors. In a research report, this is often marked by the abbreviation \&quot;et al\&quot;..</param>
        /// <param name="appropriateGradeLevels">An unordered collection of educationContentAppropriateGradeLevels. Grade levels for which this education content is applicable-if omitted, considered generally applicable..</param>
        /// <param name="appropriateSexes">An unordered collection of educationContentAppropriateSexes. Sexes for which this education content is applicable. If omitted, considered generally applicable..</param>
        /// <param name="authors">An unordered collection of educationContentAuthors. The individual credited with the creation of the resource..</param>
        /// <param name="contentClassDescriptor">The predominate type or kind characterizing the learning resource..</param>
        /// <param name="cost">An amount that has to be paid or spent to buy or obtain the EducationContent..</param>
        /// <param name="costRateDescriptor">The rate by which the cost applies..</param>
        /// <param name="derivativeSourceEducationContents">An unordered collection of educationContentDerivativeSourceEducationContents. Relates the education content source to the education content..</param>
        /// <param name="derivativeSourceLearningResourceMetadataURIs">An unordered collection of educationContentDerivativeSourceLearningResourceMetadataURIs. The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item..</param>
        /// <param name="derivativeSourceURIs">An unordered collection of educationContentDerivativeSourceURIs. The URI (typical a URL) pointing to an education content item..</param>
        /// <param name="description">An extended written representation of the education content..</param>
        /// <param name="interactivityStyleDescriptor">The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed..</param>
        /// <param name="languages">An unordered collection of educationContentLanguages. An indication of the languages in which the Education Content is designed..</param>
        /// <param name="learningResourceMetadataURI">The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item..</param>
        /// <param name="varNamespace">Namespace for the EducationContent. (required).</param>
        /// <param name="publicationDate">The date on which this content was first published..</param>
        /// <param name="publicationYear">The year at which this content was first published..</param>
        /// <param name="publisher">The organization credited with publishing the resource..</param>
        /// <param name="shortDescription">A short description or name of the entity..</param>
        /// <param name="timeRequired">Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience..</param>
        /// <param name="useRightsURL">The URL where the owner specifies permissions for using the resource..</param>
        /// <param name="varVersion">The version identifier for the content..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">Extensions to the EducationContent entity..</param>
        public EdFiEducationContent(string id = default, string contentIdentifier = default, EdFiLearningStandardReference learningStandardReference = default, bool additionalAuthorsIndicator = default, List<EdFiEducationContentAppropriateGradeLevel> appropriateGradeLevels = default, List<EdFiEducationContentAppropriateSex> appropriateSexes = default, List<EdFiEducationContentAuthor> authors = default, string contentClassDescriptor = default, double cost = default, string costRateDescriptor = default, List<EdFiEducationContentDerivativeSourceEducationContent> derivativeSourceEducationContents = default, List<EdFiEducationContentDerivativeSourceLearningResourceMetadataURI> derivativeSourceLearningResourceMetadataURIs = default, List<EdFiEducationContentDerivativeSourceURI> derivativeSourceURIs = default, string description = default, string interactivityStyleDescriptor = default, List<EdFiEducationContentLanguage> languages = default, string learningResourceMetadataURI = default, string varNamespace = default, DateOnly publicationDate = default, int publicationYear = default, string publisher = default, string shortDescription = default, string timeRequired = default, string useRightsURL = default, string varVersion = default, string etag = default, Object ext = default)
        {
            // to ensure "contentIdentifier" is required (not null)
            if (contentIdentifier == null)
            {
                throw new ArgumentNullException("contentIdentifier is a required property for EdFiEducationContent and cannot be null");
            }
            this.ContentIdentifier = contentIdentifier;
            // to ensure "varNamespace" is required (not null)
            if (varNamespace == null)
            {
                throw new ArgumentNullException("varNamespace is a required property for EdFiEducationContent and cannot be null");
            }
            this.Namespace = varNamespace;
            this.Id = id;
            this.LearningStandardReference = learningStandardReference;
            this.AdditionalAuthorsIndicator = additionalAuthorsIndicator;
            this.AppropriateGradeLevels = appropriateGradeLevels;
            this.AppropriateSexes = appropriateSexes;
            this.Authors = authors;
            this.ContentClassDescriptor = contentClassDescriptor;
            this.Cost = cost;
            this.CostRateDescriptor = costRateDescriptor;
            this.DerivativeSourceEducationContents = derivativeSourceEducationContents;
            this.DerivativeSourceLearningResourceMetadataURIs = derivativeSourceLearningResourceMetadataURIs;
            this.DerivativeSourceURIs = derivativeSourceURIs;
            this.Description = description;
            this.InteractivityStyleDescriptor = interactivityStyleDescriptor;
            this.Languages = languages;
            this.LearningResourceMetadataURI = learningResourceMetadataURI;
            this.PublicationDate = publicationDate;
            this.PublicationYear = publicationYear;
            this.Publisher = publisher;
            this.ShortDescription = shortDescription;
            this.TimeRequired = timeRequired;
            this.UseRightsURL = useRightsURL;
            this.VarVersion = varVersion;
            this.Etag = etag;
            this.Ext = ext;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique identifier for the EducationContent.
        /// </summary>
        /// <value>A unique identifier for the EducationContent.</value>
        [DataMember(Name = "contentIdentifier", IsRequired = true, EmitDefaultValue = true)]
        public string ContentIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets LearningStandardReference
        /// </summary>
        [DataMember(Name = "learningStandardReference", EmitDefaultValue = false)]
        public EdFiLearningStandardReference LearningStandardReference { get; set; }

        /// <summary>
        /// Indicates whether there are additional un-named authors. In a research report, this is often marked by the abbreviation \&quot;et al\&quot;.
        /// </summary>
        /// <value>Indicates whether there are additional un-named authors. In a research report, this is often marked by the abbreviation \&quot;et al\&quot;.</value>
        [DataMember(Name = "additionalAuthorsIndicator", EmitDefaultValue = true)]
        public bool AdditionalAuthorsIndicator { get; set; }

        /// <summary>
        /// An unordered collection of educationContentAppropriateGradeLevels. Grade levels for which this education content is applicable-if omitted, considered generally applicable.
        /// </summary>
        /// <value>An unordered collection of educationContentAppropriateGradeLevels. Grade levels for which this education content is applicable-if omitted, considered generally applicable.</value>
        [DataMember(Name = "appropriateGradeLevels", EmitDefaultValue = false)]
        public List<EdFiEducationContentAppropriateGradeLevel> AppropriateGradeLevels { get; set; }

        /// <summary>
        /// An unordered collection of educationContentAppropriateSexes. Sexes for which this education content is applicable. If omitted, considered generally applicable.
        /// </summary>
        /// <value>An unordered collection of educationContentAppropriateSexes. Sexes for which this education content is applicable. If omitted, considered generally applicable.</value>
        [DataMember(Name = "appropriateSexes", EmitDefaultValue = false)]
        public List<EdFiEducationContentAppropriateSex> AppropriateSexes { get; set; }

        /// <summary>
        /// An unordered collection of educationContentAuthors. The individual credited with the creation of the resource.
        /// </summary>
        /// <value>An unordered collection of educationContentAuthors. The individual credited with the creation of the resource.</value>
        [DataMember(Name = "authors", EmitDefaultValue = false)]
        public List<EdFiEducationContentAuthor> Authors { get; set; }

        /// <summary>
        /// The predominate type or kind characterizing the learning resource.
        /// </summary>
        /// <value>The predominate type or kind characterizing the learning resource.</value>
        [DataMember(Name = "contentClassDescriptor", EmitDefaultValue = false)]
        public string ContentClassDescriptor { get; set; }

        /// <summary>
        /// An amount that has to be paid or spent to buy or obtain the EducationContent.
        /// </summary>
        /// <value>An amount that has to be paid or spent to buy or obtain the EducationContent.</value>
        [DataMember(Name = "cost", EmitDefaultValue = false)]
        public double Cost { get; set; }

        /// <summary>
        /// The rate by which the cost applies.
        /// </summary>
        /// <value>The rate by which the cost applies.</value>
        [DataMember(Name = "costRateDescriptor", EmitDefaultValue = false)]
        public string CostRateDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of educationContentDerivativeSourceEducationContents. Relates the education content source to the education content.
        /// </summary>
        /// <value>An unordered collection of educationContentDerivativeSourceEducationContents. Relates the education content source to the education content.</value>
        [DataMember(Name = "derivativeSourceEducationContents", EmitDefaultValue = false)]
        public List<EdFiEducationContentDerivativeSourceEducationContent> DerivativeSourceEducationContents { get; set; }

        /// <summary>
        /// An unordered collection of educationContentDerivativeSourceLearningResourceMetadataURIs. The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item.
        /// </summary>
        /// <value>An unordered collection of educationContentDerivativeSourceLearningResourceMetadataURIs. The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item.</value>
        [DataMember(Name = "derivativeSourceLearningResourceMetadataURIs", EmitDefaultValue = false)]
        public List<EdFiEducationContentDerivativeSourceLearningResourceMetadataURI> DerivativeSourceLearningResourceMetadataURIs { get; set; }

        /// <summary>
        /// An unordered collection of educationContentDerivativeSourceURIs. The URI (typical a URL) pointing to an education content item.
        /// </summary>
        /// <value>An unordered collection of educationContentDerivativeSourceURIs. The URI (typical a URL) pointing to an education content item.</value>
        [DataMember(Name = "derivativeSourceURIs", EmitDefaultValue = false)]
        public List<EdFiEducationContentDerivativeSourceURI> DerivativeSourceURIs { get; set; }

        /// <summary>
        /// An extended written representation of the education content.
        /// </summary>
        /// <value>An extended written representation of the education content.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed.
        /// </summary>
        /// <value>The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed.</value>
        [DataMember(Name = "interactivityStyleDescriptor", EmitDefaultValue = false)]
        public string InteractivityStyleDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of educationContentLanguages. An indication of the languages in which the Education Content is designed.
        /// </summary>
        /// <value>An unordered collection of educationContentLanguages. An indication of the languages in which the Education Content is designed.</value>
        [DataMember(Name = "languages", EmitDefaultValue = false)]
        public List<EdFiEducationContentLanguage> Languages { get; set; }

        /// <summary>
        /// The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item.
        /// </summary>
        /// <value>The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item.</value>
        [DataMember(Name = "learningResourceMetadataURI", EmitDefaultValue = false)]
        public string LearningResourceMetadataURI { get; set; }

        /// <summary>
        /// Namespace for the EducationContent.
        /// </summary>
        /// <value>Namespace for the EducationContent.</value>
        [DataMember(Name = "namespace", IsRequired = true, EmitDefaultValue = true)]
        public string Namespace { get; set; }

        /// <summary>
        /// The date on which this content was first published.
        /// </summary>
        /// <value>The date on which this content was first published.</value>
        [DataMember(Name = "publicationDate", EmitDefaultValue = false)]
        public DateOnly PublicationDate { get; set; }

        /// <summary>
        /// The year at which this content was first published.
        /// </summary>
        /// <value>The year at which this content was first published.</value>
        [DataMember(Name = "publicationYear", EmitDefaultValue = false)]
        public int PublicationYear { get; set; }

        /// <summary>
        /// The organization credited with publishing the resource.
        /// </summary>
        /// <value>The organization credited with publishing the resource.</value>
        [DataMember(Name = "publisher", EmitDefaultValue = false)]
        public string Publisher { get; set; }

        /// <summary>
        /// A short description or name of the entity.
        /// </summary>
        /// <value>A short description or name of the entity.</value>
        [DataMember(Name = "shortDescription", EmitDefaultValue = false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience.
        /// </summary>
        /// <value>Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience.</value>
        [DataMember(Name = "timeRequired", EmitDefaultValue = false)]
        public string TimeRequired { get; set; }

        /// <summary>
        /// The URL where the owner specifies permissions for using the resource.
        /// </summary>
        /// <value>The URL where the owner specifies permissions for using the resource.</value>
        [DataMember(Name = "useRightsURL", EmitDefaultValue = false)]
        public string UseRightsURL { get; set; }

        /// <summary>
        /// The version identifier for the content.
        /// </summary>
        /// <value>The version identifier for the content.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string VarVersion { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name = "_etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// Extensions to the EducationContent entity.
        /// </summary>
        /// <value>Extensions to the EducationContent entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiEducationContent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContentIdentifier: ").Append(ContentIdentifier).Append("\n");
            sb.Append("  LearningStandardReference: ").Append(LearningStandardReference).Append("\n");
            sb.Append("  AdditionalAuthorsIndicator: ").Append(AdditionalAuthorsIndicator).Append("\n");
            sb.Append("  AppropriateGradeLevels: ").Append(AppropriateGradeLevels).Append("\n");
            sb.Append("  AppropriateSexes: ").Append(AppropriateSexes).Append("\n");
            sb.Append("  Authors: ").Append(Authors).Append("\n");
            sb.Append("  ContentClassDescriptor: ").Append(ContentClassDescriptor).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  CostRateDescriptor: ").Append(CostRateDescriptor).Append("\n");
            sb.Append("  DerivativeSourceEducationContents: ").Append(DerivativeSourceEducationContents).Append("\n");
            sb.Append("  DerivativeSourceLearningResourceMetadataURIs: ").Append(DerivativeSourceLearningResourceMetadataURIs).Append("\n");
            sb.Append("  DerivativeSourceURIs: ").Append(DerivativeSourceURIs).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  InteractivityStyleDescriptor: ").Append(InteractivityStyleDescriptor).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  LearningResourceMetadataURI: ").Append(LearningResourceMetadataURI).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  PublicationDate: ").Append(PublicationDate).Append("\n");
            sb.Append("  PublicationYear: ").Append(PublicationYear).Append("\n");
            sb.Append("  Publisher: ").Append(Publisher).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  TimeRequired: ").Append(TimeRequired).Append("\n");
            sb.Append("  UseRightsURL: ").Append(UseRightsURL).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
            // ContentIdentifier (string) maxLength
            if (this.ContentIdentifier != null && this.ContentIdentifier.Length > 225)
            {
                yield return new ValidationResult("Invalid value for ContentIdentifier, length must be less than 225.", new [] { "ContentIdentifier" });
            }

            // ContentClassDescriptor (string) maxLength
            if (this.ContentClassDescriptor != null && this.ContentClassDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for ContentClassDescriptor, length must be less than 306.", new [] { "ContentClassDescriptor" });
            }

            // CostRateDescriptor (string) maxLength
            if (this.CostRateDescriptor != null && this.CostRateDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for CostRateDescriptor, length must be less than 306.", new [] { "CostRateDescriptor" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 1024)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 1024.", new [] { "Description" });
            }

            // InteractivityStyleDescriptor (string) maxLength
            if (this.InteractivityStyleDescriptor != null && this.InteractivityStyleDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for InteractivityStyleDescriptor, length must be less than 306.", new [] { "InteractivityStyleDescriptor" });
            }

            // LearningResourceMetadataURI (string) maxLength
            if (this.LearningResourceMetadataURI != null && this.LearningResourceMetadataURI.Length > 255)
            {
                yield return new ValidationResult("Invalid value for LearningResourceMetadataURI, length must be less than 255.", new [] { "LearningResourceMetadataURI" });
            }

            // Namespace (string) maxLength
            if (this.Namespace != null && this.Namespace.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Namespace, length must be less than 255.", new [] { "Namespace" });
            }

            // Publisher (string) maxLength
            if (this.Publisher != null && this.Publisher.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Publisher, length must be less than 50.", new [] { "Publisher" });
            }

            // ShortDescription (string) maxLength
            if (this.ShortDescription != null && this.ShortDescription.Length > 75)
            {
                yield return new ValidationResult("Invalid value for ShortDescription, length must be less than 75.", new [] { "ShortDescription" });
            }

            // TimeRequired (string) maxLength
            if (this.TimeRequired != null && this.TimeRequired.Length > 30)
            {
                yield return new ValidationResult("Invalid value for TimeRequired, length must be less than 30.", new [] { "TimeRequired" });
            }

            // UseRightsURL (string) maxLength
            if (this.UseRightsURL != null && this.UseRightsURL.Length > 255)
            {
                yield return new ValidationResult("Invalid value for UseRightsURL, length must be less than 255.", new [] { "UseRightsURL" });
            }

            // VarVersion (string) maxLength
            if (this.VarVersion != null && this.VarVersion.Length > 10)
            {
                yield return new ValidationResult("Invalid value for VarVersion, length must be less than 10.", new [] { "VarVersion" });
            }

            yield break;
        }
    }

}
