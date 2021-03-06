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

    public partial class UserProfileResponseManagement : UserProfileResponseInternal
    {
        /// <summary>
        /// Initializes a new instance of the UserProfileResponseManagement
        /// class.
        /// </summary>
        public UserProfileResponseManagement()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserProfileResponseManagement
        /// class.
        /// </summary>
        /// <param name="id">The unique id (UUID) of the user</param>
        /// <param name="displayName">The full name of the user. Might for
        /// example be first and last name</param>
        /// <param name="email">The email address of the user</param>
        /// <param name="name">The unique name that is used to identify the
        /// user.</param>
        /// <param name="origin">The creation origin of this user. Possible
        /// values include: 'appcenter', 'hockeyapp', 'codepush'</param>
        /// <param name="avatarUrl">The avatar URL of the user</param>
        /// <param name="canChangePassword">User is required to send an old
        /// password in order to change the password.</param>
        /// <param name="permissions">The permissions the user has for the
        /// app</param>
        /// <param name="featureFlags">The feature flags that are enabled for
        /// this app</param>
        /// <param name="adminRole">The new admin_role. Possible values
        /// include: 'superAdmin', 'admin', 'devOps', 'customerSupport',
        /// 'notAdmin'</param>
        /// <param name="settings">The user's settings</param>
        /// <param name="updatedAt">The date when the app was last
        /// updated</param>
        /// <param name="verified">A boolean flag that indicates if the user is
        /// already verified</param>
        public UserProfileResponseManagement(System.Guid id, string displayName, string email, string name, string origin, string avatarUrl = default(string), bool? canChangePassword = default(bool?), IList<string> permissions = default(IList<string>), IList<string> featureFlags = default(IList<string>), string adminRole = default(string), UserProfileResponseInternalSettings settings = default(UserProfileResponseInternalSettings), string updatedAt = default(string), bool? verified = default(bool?))
            : base(id, displayName, email, name, origin, avatarUrl, canChangePassword, permissions, featureFlags, adminRole, settings)
        {
            UpdatedAt = updatedAt;
            Verified = verified;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the date when the app was last updated
        /// </summary>
        [JsonProperty(PropertyName = "updated_at")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets a boolean flag that indicates if the user is already
        /// verified
        /// </summary>
        [JsonProperty(PropertyName = "verified")]
        public bool? Verified { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
