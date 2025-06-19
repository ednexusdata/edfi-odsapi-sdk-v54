# EdFi.OdsApi.Sdk.v54.Models.All.EdFiEducationContent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContentIdentifier** | **string** | A unique identifier for the EducationContent. | 
**Namespace** | **string** | Namespace for the EducationContent. | 
**Id** | **string** |  | [optional] 
**LearningStandardReference** | [**EdFiLearningStandardReference**](EdFiLearningStandardReference.md) |  | [optional] 
**AdditionalAuthorsIndicator** | **bool** | Indicates whether there are additional un-named authors. In a research report, this is often marked by the abbreviation \&quot;et al\&quot;. | [optional] 
**AppropriateGradeLevels** | [**List&lt;EdFiEducationContentAppropriateGradeLevel&gt;**](EdFiEducationContentAppropriateGradeLevel.md) | An unordered collection of educationContentAppropriateGradeLevels. Grade levels for which this education content is applicable-if omitted, considered generally applicable. | [optional] 
**AppropriateSexes** | [**List&lt;EdFiEducationContentAppropriateSex&gt;**](EdFiEducationContentAppropriateSex.md) | An unordered collection of educationContentAppropriateSexes. Sexes for which this education content is applicable. If omitted, considered generally applicable. | [optional] 
**Authors** | [**List&lt;EdFiEducationContentAuthor&gt;**](EdFiEducationContentAuthor.md) | An unordered collection of educationContentAuthors. The individual credited with the creation of the resource. | [optional] 
**ContentClassDescriptor** | **string** | The predominate type or kind characterizing the learning resource. | [optional] 
**Cost** | **double** | An amount that has to be paid or spent to buy or obtain the EducationContent. | [optional] 
**CostRateDescriptor** | **string** | The rate by which the cost applies. | [optional] 
**DerivativeSourceEducationContents** | [**List&lt;EdFiEducationContentDerivativeSourceEducationContent&gt;**](EdFiEducationContentDerivativeSourceEducationContent.md) | An unordered collection of educationContentDerivativeSourceEducationContents. Relates the education content source to the education content. | [optional] 
**DerivativeSourceLearningResourceMetadataURIs** | [**List&lt;EdFiEducationContentDerivativeSourceLearningResourceMetadataURI&gt;**](EdFiEducationContentDerivativeSourceLearningResourceMetadataURI.md) | An unordered collection of educationContentDerivativeSourceLearningResourceMetadataURIs. The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item. | [optional] 
**DerivativeSourceURIs** | [**List&lt;EdFiEducationContentDerivativeSourceURI&gt;**](EdFiEducationContentDerivativeSourceURI.md) | An unordered collection of educationContentDerivativeSourceURIs. The URI (typical a URL) pointing to an education content item. | [optional] 
**Description** | **string** | An extended written representation of the education content. | [optional] 
**InteractivityStyleDescriptor** | **string** | The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed. | [optional] 
**Languages** | [**List&lt;EdFiEducationContentLanguage&gt;**](EdFiEducationContentLanguage.md) | An unordered collection of educationContentLanguages. An indication of the languages in which the Education Content is designed. | [optional] 
**LearningResourceMetadataURI** | **string** | The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item. | [optional] 
**PublicationDate** | **DateOnly** | The date on which this content was first published. | [optional] 
**PublicationYear** | **int** | The year at which this content was first published. | [optional] 
**Publisher** | **string** | The organization credited with publishing the resource. | [optional] 
**ShortDescription** | **string** | A short description or name of the entity. | [optional] 
**TimeRequired** | **string** | Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience. | [optional] 
**UseRightsURL** | **string** | The URL where the owner specifies permissions for using the resource. | [optional] 
**VarVersion** | **string** | The version identifier for the content. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the EducationContent entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

