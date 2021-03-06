// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A request containing a set of release ids to validate
    /// </summary>
    public partial class GDPRValidationRequest
    {
        /// <summary>
        /// Initializes a new instance of the GDPRValidationRequest class.
        /// </summary>
        public GDPRValidationRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GDPRValidationRequest class.
        /// </summary>
        /// <param name="releaseIds">a list of release ids to validate</param>
        public GDPRValidationRequest(IList<int?> releaseIds)
        {
            ReleaseIds = releaseIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of release ids to validate
        /// </summary>
        [JsonProperty(PropertyName = "release_ids")]
        public IList<int?> ReleaseIds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ReleaseIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ReleaseIds");
            }
        }
    }
}
