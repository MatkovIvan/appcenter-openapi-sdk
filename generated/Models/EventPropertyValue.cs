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
    /// An event property value with counts
    /// </summary>
    public partial class EventPropertyValue
    {
        /// <summary>
        /// Initializes a new instance of the EventPropertyValue class.
        /// </summary>
        public EventPropertyValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventPropertyValue class.
        /// </summary>
        /// <param name="name">The event property value name</param>
        /// <param name="count">The count of the the event property
        /// value</param>
        /// <param name="previousCount">The count of previous time range of the
        /// event property value</param>
        public EventPropertyValue(string name = default(string), long? count = default(long?), long? previousCount = default(long?))
        {
            Name = name;
            Count = count;
            PreviousCount = previousCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the event property value name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the count of the the event property value
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; set; }

        /// <summary>
        /// Gets or sets the count of previous time range of the event property
        /// value
        /// </summary>
        [JsonProperty(PropertyName = "previous_count")]
        public long? PreviousCount { get; set; }

    }
}
