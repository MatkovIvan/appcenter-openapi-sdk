// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ErrorAttachmentText
    {
        /// <summary>
        /// Initializes a new instance of the ErrorAttachmentText class.
        /// </summary>
        public ErrorAttachmentText()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorAttachmentText class.
        /// </summary>
        public ErrorAttachmentText(string content = default(string))
        {
            Content = content;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

    }
}
