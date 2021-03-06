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

    public partial class XamarinToolset
    {
        /// <summary>
        /// Initializes a new instance of the XamarinToolset class.
        /// </summary>
        public XamarinToolset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the XamarinToolset class.
        /// </summary>
        /// <param name="xamarinSolutions">Xamarin solutions for the
        /// toolset</param>
        public XamarinToolset(IList<XamarinSolution> xamarinSolutions)
        {
            XamarinSolutions = xamarinSolutions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets xamarin solutions for the toolset
        /// </summary>
        [JsonProperty(PropertyName = "xamarinSolutions")]
        public IList<XamarinSolution> XamarinSolutions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (XamarinSolutions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "XamarinSolutions");
            }
            if (XamarinSolutions != null)
            {
                foreach (var element in XamarinSolutions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
