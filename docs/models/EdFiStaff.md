# EdFi.OdsApi.Sdk.v54.Models.All.EdFiStaff

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StaffUniqueId** | **string** | A unique alphanumeric code assigned to a staff. | 
**FirstName** | **string** | A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. | 
**LastSurname** | **string** | The name borne in common by members of a family. | 
**Id** | **string** |  | [optional] 
**PersonReference** | [**EdFiPersonReference**](EdFiPersonReference.md) |  | [optional] 
**Addresses** | [**List&lt;EdFiStaffAddress&gt;**](EdFiStaffAddress.md) | An unordered collection of staffAddresses. The set of elements that describes an address, including the street address, city, state, and ZIP code. | [optional] 
**AncestryEthnicOrigins** | [**List&lt;EdFiStaffAncestryEthnicOrigin&gt;**](EdFiStaffAncestryEthnicOrigin.md) | An unordered collection of staffAncestryEthnicOrigins. The original peoples or cultures with which the individual identifies. | [optional] 
**BirthDate** | **DateOnly** | The month, day, and year on which an individual was born. | [optional] 
**CitizenshipStatusDescriptor** | **string** | An indicator of whether or not the person is a U.S. citizen. | [optional] 
**Credentials** | [**List&lt;EdFiStaffCredential&gt;**](EdFiStaffCredential.md) | An unordered collection of staffCredentials. The legal document giving authorization to perform teaching assignment services. | [optional] 
**ElectronicMails** | [**List&lt;EdFiStaffElectronicMail&gt;**](EdFiStaffElectronicMail.md) | An unordered collection of staffElectronicMails. The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the individual or organization belongs. | [optional] 
**GenerationCodeSuffix** | **string** | An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III). | [optional] 
**HighestCompletedLevelOfEducationDescriptor** | **string** | The extent of formal instruction an individual has received (e.g., the highest grade in school completed or its equivalent or the highest degree received). | [optional] 
**HighlyQualifiedTeacher** | **bool** | An indication of whether a teacher is classified as highly qualified for his/her assignment according to state definition. This attribute indicates the teacher is highly qualified for ALL Sections being taught. | [optional] 
**HispanicLatinoEthnicity** | **bool** | An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race. The term, \&quot;Spanish origin,\&quot; can be used in addition to \&quot;Hispanic or Latino.\&quot; | [optional] 
**IdentificationCodes** | [**List&lt;EdFiStaffIdentificationCode&gt;**](EdFiStaffIdentificationCode.md) | An unordered collection of staffIdentificationCodes. A unique number or alphanumeric code assigned to a staff member by a school, school system, a state, or other agency or entity. | [optional] 
**IdentificationDocuments** | [**List&lt;EdFiStaffIdentificationDocument&gt;**](EdFiStaffIdentificationDocument.md) | An unordered collection of staffIdentificationDocuments. Describe the documentation of citizenship. | [optional] 
**InternationalAddresses** | [**List&lt;EdFiStaffInternationalAddress&gt;**](EdFiStaffInternationalAddress.md) | An unordered collection of staffInternationalAddresses. The set of elements that describes an international address. | [optional] 
**Languages** | [**List&lt;EdFiStaffLanguage&gt;**](EdFiStaffLanguage.md) | An unordered collection of staffLanguages. The language(s) the individual uses to communicate. It is strongly recommended that entries use only ISO 639-2 language codes. | [optional] 
**LoginId** | **string** | The login ID for the user; used for security access control interface. | [optional] 
**MaidenName** | **string** | The person&#39;s maiden name. | [optional] 
**MiddleName** | **string** | A secondary name given to an individual at birth, baptism, or during another naming ceremony. | [optional] 
**OldEthnicityDescriptor** | **string** | Previous definition of Ethnicity combining Hispanic/Latino and race:        1 - American Indian or Alaskan Native        2 - Asian or Pacific Islander        3 - Black, not of Hispanic origin        4 - Hispanic        5 - White, not of Hispanic origin. | [optional] 
**OtherNames** | [**List&lt;EdFiStaffOtherName&gt;**](EdFiStaffOtherName.md) | An unordered collection of staffOtherNames. Other names (e.g., alias, nickname, previous legal name) associated with a person. | [optional] 
**PersonalIdentificationDocuments** | [**List&lt;EdFiStaffPersonalIdentificationDocument&gt;**](EdFiStaffPersonalIdentificationDocument.md) | An unordered collection of staffPersonalIdentificationDocuments. The documents presented as evident to verify one&#39;s personal identity; for example: drivers license, passport, birth certificate, etc. | [optional] 
**PersonalTitlePrefix** | **string** | A prefix used to denote the title, degree, position, or seniority of the person. | [optional] 
**Races** | [**List&lt;EdFiStaffRace&gt;**](EdFiStaffRace.md) | An unordered collection of staffRaces. The general racial category which most clearly reflects the individual&#39;s recognition of his or her community or with which the individual most identifies. The way this data element is listed, it must allow for multiple entries so that each individual can specify all appropriate races. | [optional] 
**Recognitions** | [**List&lt;EdFiStaffRecognition&gt;**](EdFiStaffRecognition.md) | An unordered collection of staffRecognitions. Recognitions given to the staff for accomplishments in a co-curricular or extracurricular activity. | [optional] 
**SexDescriptor** | **string** | A person&#39;s gender. | [optional] 
**Telephones** | [**List&lt;EdFiStaffTelephone&gt;**](EdFiStaffTelephone.md) | An unordered collection of staffTelephones. The 10-digit telephone number, including the area code, for the person. | [optional] 
**TribalAffiliations** | [**List&lt;EdFiStaffTribalAffiliation&gt;**](EdFiStaffTribalAffiliation.md) | An unordered collection of staffTribalAffiliations. An American Indian tribe with which the staff member is affiliated. | [optional] 
**Visas** | [**List&lt;EdFiStaffVisa&gt;**](EdFiStaffVisa.md) | An unordered collection of staffVisas. An indicator of a non-US citizen&#39;s Visa type. | [optional] 
**YearsOfPriorProfessionalExperience** | **double** | The total number of years that an individual has previously held a similar professional position in one or more education institutions. | [optional] 
**YearsOfPriorTeachingExperience** | **double** | The total number of years that an individual has previously held a teaching position in one or more education institutions. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the Staff entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

