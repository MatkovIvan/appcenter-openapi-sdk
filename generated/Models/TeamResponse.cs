// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TeamResponse
    {
        /// <summary>
        /// Initializes a new instance of the TeamResponse class.
        /// </summary>
        public TeamResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TeamResponse class.
        /// </summary>
        /// <param name="id">The internal unique id (UUID) of the team.</param>
        /// <param name="name">The name of the team</param>
        /// <param name="displayName">The display name of the team</param>
        /// <param name="description">The description of the team</param>
        public TeamResponse(System.Guid id, string name, string displayName, string description = default(string))
        {
            Id = id;
            Name = name;
            DisplayName = displayName;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the internal unique id (UUID) of the team.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the team
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display name of the team
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the description of the team
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
        }
    }
}
