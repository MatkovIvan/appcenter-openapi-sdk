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
    /// Subscription Tier
    /// </summary>
    public partial class Tier
    {
        /// <summary>
        /// Initializes a new instance of the Tier class.
        /// </summary>
        public Tier()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Tier class.
        /// </summary>
        /// <param name="name">The name of the tier</param>
        public Tier(string name = default(string))
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the tier
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}