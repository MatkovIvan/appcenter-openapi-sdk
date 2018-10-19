// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// CodePushAcquisition operations.
    /// </summary>
    public partial interface ICodePushAcquisition
    {
        /// <summary>
        /// Check for updates
        /// </summary>
        /// <param name='deploymentKey'>
        /// </param>
        /// <param name='appVersion'>
        /// </param>
        /// <param name='packageHash'>
        /// </param>
        /// <param name='label'>
        /// </param>
        /// <param name='clientUniqueId'>
        /// </param>
        /// <param name='isCompanion'>
        /// </param>
        /// <param name='previousLabelOrAppVersion'>
        /// </param>
        /// <param name='previousDeploymentKey'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="FailureException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<UpdateCheckResponse>> UpdateCheckWithHttpMessagesAsync(string deploymentKey, string appVersion, string packageHash = default(string), string label = default(string), string clientUniqueId = default(string), bool? isCompanion = default(bool?), string previousLabelOrAppVersion = default(string), string previousDeploymentKey = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the acquisition service status to the caller
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="FailureException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<AcquisitionStatusSuccessResponse>> GetAcquisitionStatusWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Report download of specified release
        /// </summary>
        /// <param name='releaseMetadata'>
        /// Deployment status metric properties
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="FailureException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> UpdateDownloadStatusWithHttpMessagesAsync(CodePushStatusMetricMetadata releaseMetadata, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Report Deployment status metric
        /// </summary>
        /// <param name='releaseMetadata'>
        /// Deployment status metric properties
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="FailureException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> UpdateDeployStatusWithHttpMessagesAsync(CodePushStatusMetricMetadata releaseMetadata, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}