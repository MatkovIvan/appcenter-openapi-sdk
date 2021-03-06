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
    /// The place code and the count
    /// </summary>
    public partial class Place
    {
        /// <summary>
        /// Initializes a new instance of the Place class.
        /// </summary>
        public Place()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Place class.
        /// </summary>
        /// <param name="code">the place code</param>
        /// <param name="count">the count of the this place</param>
        /// <param name="previousCount">the count of previous time range of the
        /// place</param>
        public Place(string code = default(string), long? count = default(long?), long? previousCount = default(long?))
        {
            Code = code;
            Count = count;
            PreviousCount = previousCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the place code
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the count of the this place
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; set; }

        /// <summary>
        /// Gets or sets the count of previous time range of the place
        /// </summary>
        [JsonProperty(PropertyName = "previous_count")]
        public long? PreviousCount { get; set; }

    }
}
