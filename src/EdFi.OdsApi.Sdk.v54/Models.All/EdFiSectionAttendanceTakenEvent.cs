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
    /// EdFiSectionAttendanceTakenEvent
    /// </summary>
    [DataContract(Name = "edFi_sectionAttendanceTakenEvent")]
    public partial class EdFiSectionAttendanceTakenEvent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSectionAttendanceTakenEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSectionAttendanceTakenEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSectionAttendanceTakenEvent" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="calendarDateReference">calendarDateReference (required).</param>
        /// <param name="sectionReference">sectionReference (required).</param>
        /// <param name="staffReference">staffReference.</param>
        /// <param name="eventDate">The date the SectionAttendanceTakenEvent was submitted, which could be a different date than the instructional day. (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">Extensions to the SectionAttendanceTakenEvent entity..</param>
        public EdFiSectionAttendanceTakenEvent(string id = default, EdFiCalendarDateReference calendarDateReference = default, EdFiSectionReference sectionReference = default, EdFiStaffReference staffReference = default, DateOnly eventDate = default, string etag = default, Object ext = default)
        {
            // to ensure "calendarDateReference" is required (not null)
            if (calendarDateReference == null)
            {
                throw new ArgumentNullException("calendarDateReference is a required property for EdFiSectionAttendanceTakenEvent and cannot be null");
            }
            this.CalendarDateReference = calendarDateReference;
            // to ensure "sectionReference" is required (not null)
            if (sectionReference == null)
            {
                throw new ArgumentNullException("sectionReference is a required property for EdFiSectionAttendanceTakenEvent and cannot be null");
            }
            this.SectionReference = sectionReference;
            this.EventDate = eventDate;
            this.Id = id;
            this.StaffReference = staffReference;
            this.Etag = etag;
            this.Ext = ext;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CalendarDateReference
        /// </summary>
        [DataMember(Name = "calendarDateReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiCalendarDateReference CalendarDateReference { get; set; }

        /// <summary>
        /// Gets or Sets SectionReference
        /// </summary>
        [DataMember(Name = "sectionReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiSectionReference SectionReference { get; set; }

        /// <summary>
        /// Gets or Sets StaffReference
        /// </summary>
        [DataMember(Name = "staffReference", EmitDefaultValue = false)]
        public EdFiStaffReference StaffReference { get; set; }

        /// <summary>
        /// The date the SectionAttendanceTakenEvent was submitted, which could be a different date than the instructional day.
        /// </summary>
        /// <value>The date the SectionAttendanceTakenEvent was submitted, which could be a different date than the instructional day.</value>
        [DataMember(Name = "eventDate", IsRequired = true, EmitDefaultValue = true)]
        public DateOnly EventDate { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name = "_etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// Extensions to the SectionAttendanceTakenEvent entity.
        /// </summary>
        /// <value>Extensions to the SectionAttendanceTakenEvent entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiSectionAttendanceTakenEvent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CalendarDateReference: ").Append(CalendarDateReference).Append("\n");
            sb.Append("  SectionReference: ").Append(SectionReference).Append("\n");
            sb.Append("  StaffReference: ").Append(StaffReference).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
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
