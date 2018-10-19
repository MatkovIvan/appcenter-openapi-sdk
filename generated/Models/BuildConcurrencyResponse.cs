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
    /// Number of pipelines
    /// </summary>
    public partial class BuildConcurrencyResponse
    {
        /// <summary>
        /// Initializes a new instance of the BuildConcurrencyResponse class.
        /// </summary>
        public BuildConcurrencyResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BuildConcurrencyResponse class.
        /// </summary>
        /// <param name="quantity">The number of pipelines set by the billing
        /// plan</param>
        /// <param name="committedQuantity">The number of pipelines committed,
        /// which can be equal or greater than the number from the billing
        /// plan</param>
        public BuildConcurrencyResponse(double? quantity = default(double?), double? committedQuantity = default(double?))
        {
            Quantity = quantity;
            CommittedQuantity = committedQuantity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of pipelines set by the billing plan
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// Gets or sets the number of pipelines committed, which can be equal
        /// or greater than the number from the billing plan
        /// </summary>
        [JsonProperty(PropertyName = "committed_quantity")]
        public double? CommittedQuantity { get; set; }

    }
}