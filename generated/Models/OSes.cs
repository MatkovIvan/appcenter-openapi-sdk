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

    public partial class OSes
    {
        /// <summary>
        /// Initializes a new instance of the OSes class.
        /// </summary>
        public OSes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OSes class.
        /// </summary>
        public OSes(long? total = default(long?), IList<OS> oses = default(IList<OS>))
        {
            Total = total;
            Oses = oses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public long? Total { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oses")]
        public IList<OS> Oses { get; set; }

    }
}