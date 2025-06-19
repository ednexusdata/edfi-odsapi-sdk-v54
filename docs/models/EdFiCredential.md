# EdFi.OdsApi.Sdk.v54.Models.All.EdFiCredential

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CredentialIdentifier** | **string** | Identifier or serial number assigned to the credential. | 
**StateOfIssueStateAbbreviationDescriptor** | **string** | The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a license/credential was issued. | 
**CredentialTypeDescriptor** | **string** | An indication of the category of credential an individual holds. | 
**IssuanceDate** | **DateOnly** | The month, day, and year on which an active credential was issued to an individual. | 
**Namespace** | **string** | Namespace for the Credential. | 
**Id** | **string** |  | [optional] 
**AcademicSubjects** | [**List&lt;EdFiCredentialAcademicSubject&gt;**](EdFiCredentialAcademicSubject.md) | An unordered collection of credentialAcademicSubjects. The academic subjects to which the credential pertains. | [optional] 
**CredentialFieldDescriptor** | **string** | The field of certification for the certificate (e.g., Mathematics, Music). | [optional] 
**EffectiveDate** | **DateOnly** | The year, month and day on which an active credential held by an individual was issued. | [optional] 
**Endorsements** | [**List&lt;EdFiCredentialEndorsement&gt;**](EdFiCredentialEndorsement.md) | An unordered collection of credentialEndorsements. Endorsements are attachments to teaching certificates and indicate areas of specialization. | [optional] 
**ExpirationDate** | **DateOnly** | The month, day, and year on which an active credential held by an individual will expire. | [optional] 
**GradeLevels** | [**List&lt;EdFiCredentialGradeLevel&gt;**](EdFiCredentialGradeLevel.md) | An unordered collection of credentialGradeLevels. The grade level(s) certified for teaching. | [optional] 
**TeachingCredentialBasisDescriptor** | **string** | An indication of the pre-determined criteria for granting the teaching credential that an individual holds. | [optional] 
**TeachingCredentialDescriptor** | **string** | An indication of the category of a legal document giving authorization to perform teaching assignment services. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the Credential entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

