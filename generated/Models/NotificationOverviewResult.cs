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

    /// <summary>
    /// Notification statistics
    /// </summary>
    public partial class NotificationOverviewResult
    {
        /// <summary>
        /// Initializes a new instance of the NotificationOverviewResult class.
        /// </summary>
        public NotificationOverviewResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NotificationOverviewResult class.
        /// </summary>
        /// <param name="notificationId">Notification id.</param>
        /// <param name="state">State of the notification. Possible values
        /// include: 'Cancelled', 'Completed', 'Enqueued', 'Processing',
        /// 'Unknown'</param>
        /// <param name="name">Notification name</param>
        /// <param name="sendTime">Notification send time</param>
        /// <param name="pnsSendFailure">Number of the notifications failed to
        /// send to the push provider.</param>
        /// <param name="pnsSendSuccess">Number of the notifications
        /// successfully sent to push the provider.</param>
        public NotificationOverviewResult(string notificationId, string state, string name = default(string), NotificationTarget notificationTarget = default(NotificationTarget), System.DateTime? sendTime = default(System.DateTime?), int? pnsSendFailure = default(int?), int? pnsSendSuccess = default(int?))
        {
            NotificationId = notificationId;
            Name = name;
            NotificationTarget = notificationTarget;
            SendTime = sendTime;
            PnsSendFailure = pnsSendFailure;
            PnsSendSuccess = pnsSendSuccess;
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets notification id.
        /// </summary>
        [JsonProperty(PropertyName = "notification_id")]
        public string NotificationId { get; set; }

        /// <summary>
        /// Gets or sets notification name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "notification_target")]
        public NotificationTarget NotificationTarget { get; set; }

        /// <summary>
        /// Gets or sets notification send time
        /// </summary>
        [JsonProperty(PropertyName = "send_time")]
        public System.DateTime? SendTime { get; set; }

        /// <summary>
        /// Gets or sets number of the notifications failed to send to the push
        /// provider.
        /// </summary>
        [JsonProperty(PropertyName = "pns_send_failure")]
        public int? PnsSendFailure { get; set; }

        /// <summary>
        /// Gets or sets number of the notifications successfully sent to push
        /// the provider.
        /// </summary>
        [JsonProperty(PropertyName = "pns_send_success")]
        public int? PnsSendSuccess { get; set; }

        /// <summary>
        /// Gets or sets state of the notification. Possible values include:
        /// 'Cancelled', 'Completed', 'Enqueued', 'Processing', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NotificationId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NotificationId");
            }
            if (State == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "State");
            }
            if (Name != null)
            {
                if (Name.Length > 64)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 64);
                }
            }
        }
    }
}
