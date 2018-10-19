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
    /// Itunes teams details .
    /// </summary>
    public partial class ItunesTeamsResponse
    {
        /// <summary>
        /// Initializes a new instance of the ItunesTeamsResponse class.
        /// </summary>
        public ItunesTeamsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ItunesTeamsResponse class.
        /// </summary>
        /// <param name="teamId">Itunes team id.</param>
        /// <param name="teamName">Itunes Team Name</param>
        public ItunesTeamsResponse(string teamId = default(string), string teamName = default(string))
        {
            TeamId = teamId;
            TeamName = teamName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets itunes team id.
        /// </summary>
        [JsonProperty(PropertyName = "teamId")]
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or sets itunes Team Name
        /// </summary>
        [JsonProperty(PropertyName = "teamName")]
        public string TeamName { get; set; }

    }
}