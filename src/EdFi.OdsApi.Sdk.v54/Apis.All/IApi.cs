using System.Net.Http;

namespace EdFi.OdsApi.Sdk.v54.Apis.All
{
    /// <summary>
    /// Any Api client
    /// </summary>
    public interface IApi
    {
        /// <summary>
        /// The HttpClient
        /// </summary>
        HttpClient HttpClient { get; }
    }
}