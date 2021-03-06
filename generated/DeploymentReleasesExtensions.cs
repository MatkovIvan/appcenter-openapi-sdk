// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DeploymentReleases.
    /// </summary>
    public static partial class DeploymentReleasesExtensions
    {
            /// <summary>
            /// Modifies a CodePush release metadata under the given Deployment
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deploymentName'>
            /// deployment name
            /// </param>
            /// <param name='releaseLabel'>
            /// release label
            /// </param>
            /// <param name='release'>
            /// Release modification. All fields are optional and only provided fields will
            /// get updated.
            /// </param>
            /// <param name='ownerName'>
            /// The name of the owner
            /// </param>
            /// <param name='appName'>
            /// The name of the application
            /// </param>
            public static CodePushRelease Update(this IDeploymentReleases operations, string deploymentName, string releaseLabel, CodePushReleaseModification release, string ownerName, string appName)
            {
                return operations.UpdateAsync(deploymentName, releaseLabel, release, ownerName, appName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Modifies a CodePush release metadata under the given Deployment
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deploymentName'>
            /// deployment name
            /// </param>
            /// <param name='releaseLabel'>
            /// release label
            /// </param>
            /// <param name='release'>
            /// Release modification. All fields are optional and only provided fields will
            /// get updated.
            /// </param>
            /// <param name='ownerName'>
            /// The name of the owner
            /// </param>
            /// <param name='appName'>
            /// The name of the application
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CodePushRelease> UpdateAsync(this IDeploymentReleases operations, string deploymentName, string releaseLabel, CodePushReleaseModification release, string ownerName, string appName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(deploymentName, releaseLabel, release, ownerName, appName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
