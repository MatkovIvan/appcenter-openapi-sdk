// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CreateStoreSecretResponse
    {
        /// <summary>
        /// Initializes a new instance of the CreateStoreSecretResponse class.
        /// </summary>
        public CreateStoreSecretResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateStoreSecretResponse class.
        /// </summary>
        /// <param name="secretId">the secret id for store secret</param>
        public CreateStoreSecretResponse(string secretId = default(string))
        {
            SecretId = secretId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the secret id for store secret
        /// </summary>
        [JsonProperty(PropertyName = "secret_id")]
        public string SecretId { get; set; }

    }
}
