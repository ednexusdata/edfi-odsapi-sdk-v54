# EdFi.OdsApi.Sdk.v54.Models.All.EdFiStudentPersonalIdentificationDocument

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentificationDocumentUseDescriptor** | **string** | The primary function of the document used for establishing identity. | 
**PersonalInformationVerificationDescriptor** | **string** | The category of the document relative to its purpose. | 
**IssuerCountryDescriptor** | **string** | Country of origin of the document. It is strongly recommended that entries use only ISO 3166 2-letter country codes. | [optional] 
**DocumentExpirationDate** | **DateOnly** | The day when the document  expires, if null then never expires. | [optional] 
**DocumentTitle** | **string** | The title of the document given by the issuer. | [optional] 
**IssuerDocumentIdentificationCode** | **string** | The unique identifier on the issuer&#39;s identification system. | [optional] 
**IssuerName** | **string** | Name of the entity or institution that issued the document. | [optional] 
**Ext** | **Object** | Extensions to the StudentPersonalIdentificationDocument entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

