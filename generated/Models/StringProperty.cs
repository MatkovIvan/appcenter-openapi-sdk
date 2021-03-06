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
    /// String property.
    /// </summary>
    [Newtonsoft.Json.JsonObject("string")]
    public partial class StringProperty : CustomProperty
    {
        /// <summary>
        /// Initializes a new instance of the StringProperty class.
        /// </summary>
        public StringProperty()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StringProperty class.
        /// </summary>
        /// <param name="value">String property value.</param>
        public StringProperty(string name, string value)
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
        /// Gets or sets string property value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
            if (Value != null)
            {
                if (Value.Length > 128)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Value", 128);
                }
            }
        }
    }
}
