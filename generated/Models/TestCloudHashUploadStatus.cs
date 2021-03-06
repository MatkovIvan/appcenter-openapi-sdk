// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Test Cloud Hash Upload Status
    /// </summary>
    /// <remarks>
    /// Result of uploading a single file hash
    /// </remarks>
    public partial class TestCloudHashUploadStatus
    {
        /// <summary>
        /// Initializes a new instance of the TestCloudHashUploadStatus class.
        /// </summary>
        public TestCloudHashUploadStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TestCloudHashUploadStatus class.
        /// </summary>
        /// <param name="statusCode">HTTP status code that represent result of
        /// upload</param>
        /// <param name="location">URI that should be used to make POST request
        /// if file with given hash doesn't exist. This is set when status_code
        /// is equal to 412</param>
        public TestCloudHashUploadStatus(double statusCode, string location = default(string))
        {
            StatusCode = statusCode;
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets HTTP status code that represent result of upload
        /// </summary>
        [JsonProperty(PropertyName = "statusCode")]
        public double StatusCode { get; set; }

        /// <summary>
        /// Gets or sets URI that should be used to make POST request if file
        /// with given hash doesn't exist. This is set when status_code is
        /// equal to 412
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
