// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class EventCountPerDevice
    {
        /// <summary>
        /// Initializes a new instance of the EventCountPerDevice class.
        /// </summary>
        public EventCountPerDevice()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventCountPerDevice class.
        /// </summary>
        public EventCountPerDevice(double? avgCountPerDevice = default(double?), double? previousAvgCountPerDevice = default(double?), IList<DateTimeDecimalCounts> countPerDevice = default(IList<DateTimeDecimalCounts>))
        {
            AvgCountPerDevice = avgCountPerDevice;
            PreviousAvgCountPerDevice = previousAvgCountPerDevice;
            CountPerDevice = countPerDevice;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "avg_count_per_device")]
        public double? AvgCountPerDevice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "previous_avg_count_per_device")]
        public double? PreviousAvgCountPerDevice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "count_per_device")]
        public IList<DateTimeDecimalCounts> CountPerDevice { get; set; }

    }
}
