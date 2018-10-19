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
    /// Date and time property.
    /// </summary>
    [Newtonsoft.Json.JsonObject("date_time")]
    public partial class DateTimePropertyDiagnostics : CustomPropertyDiagnostics
    {
        /// <summary>
        /// Initializes a new instance of the DateTimePropertyDiagnostics
        /// class.
        /// </summary>
        public DateTimePropertyDiagnostics()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DateTimePropertyDiagnostics
        /// class.
        /// </summary>
        /// <param name="value">Date time property value.</param>
        public DateTimePropertyDiagnostics(string name, System.DateTime value)
            : base(name)
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets date time property value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public System.DateTime Value { get; set; }

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