# EdFi.OdsApi.Sdk.v54.Models.All.EdFiStudent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StudentUniqueId** | **string** | A unique alphanumeric code assigned to a student. | 
**BirthDate** | **DateOnly** | The month, day, and year on which an individual was born. | 
**FirstName** | **string** | A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. | 
**LastSurname** | **string** | The name borne in common by members of a family. | 
**Id** | **string** |  | [optional] 
**PersonReference** | [**EdFiPersonReference**](EdFiPersonReference.md) |  | [optional] 
**BirthCity** | **string** | The city the student was born in. | [optional] 
**BirthCountryDescriptor** | **string** | The country in which an individual is born. It is strongly recommended that entries use only ISO 3166 2-letter country codes. | [optional] 
**BirthInternationalProvince** | **string** | For students born outside of the U.S., the Province or jurisdiction in which an individual is born. | [optional] 
**BirthSexDescriptor** | **string** | A person&#39;s gender at birth. | [optional] 
**BirthStateAbbreviationDescriptor** | **string** | The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which an individual was born. | [optional] 
**CitizenshipStatusDescriptor** | **string** | An indicator of whether or not the person is a U.S. citizen. | [optional] 
**DateEnteredUS** | **DateOnly** | For students born outside of the U.S., the date the student entered the U.S. | [optional] 
**GenerationCodeSuffix** | **string** | An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III). | [optional] 
**IdentificationDocuments** | [**List&lt;EdFiStudentIdentificationDocument&gt;**](EdFiStudentIdentificationDocument.md) | An unordered collection of studentIdentificationDocuments. Describe the documentation of citizenship. | [optional] 
**MaidenName** | **string** | The person&#39;s maiden name. | [optional] 
**MiddleName** | **string** | A secondary name given to an individual at birth, baptism, or during another naming ceremony. | [optional] 
**MultipleBirthStatus** | **bool** | Indicator of whether the student was born with other siblings (i.e., twins, triplets, etc.) | [optional] 
**OtherNames** | [**List&lt;EdFiStudentOtherName&gt;**](EdFiStudentOtherName.md) | An unordered collection of studentOtherNames. Other names (e.g., alias, nickname, previous legal name) associated with a person. | [optional] 
**PersonalIdentificationDocuments** | [**List&lt;EdFiStudentPersonalIdentificationDocument&gt;**](EdFiStudentPersonalIdentificationDocument.md) | An unordered collection of studentPersonalIdentificationDocuments. The documents presented as evident to verify one&#39;s personal identity; for example: drivers license, passport, birth certificate, etc. | [optional] 
**PersonalTitlePrefix** | **string** | A prefix used to denote the title, degree, position, or seniority of the person. | [optional] 
**Visas** | [**List&lt;EdFiStudentVisa&gt;**](EdFiStudentVisa.md) | An unordered collection of studentVisas. An indicator of a non-US citizen&#39;s Visa type. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the Student entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

