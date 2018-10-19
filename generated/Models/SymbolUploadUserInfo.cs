// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SymbolUploadUserInfo
    {
        /// <summary>
        /// Initializes a new instance of the SymbolUploadUserInfo class.
        /// </summary>
        public SymbolUploadUserInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SymbolUploadUserInfo class.
        /// </summary>
        /// <param name="email">The email of the user</param>
        /// <param name="displayName">The full name of the user. Might for
        /// example be first and last name</param>
        public SymbolUploadUserInfo(string email = default(string), string displayName = default(string))
        {
            Email = email;
            DisplayName = displayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the email of the user
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the full name of the user. Might for example be first
        /// and last name
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }

    }
}