// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class BillingInformationSearchResultsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// BillingInformationSearchResultsItem class.
        /// </summary>
        public BillingInformationSearchResultsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// BillingInformationSearchResultsItem class.
        /// </summary>
        /// <param name="accountId">The Account ID</param>
        /// <param name="accountName">The Account Name</param>
        /// <param name="billingInternalAccountId">The Billing Internal Account
        /// ID</param>
        /// <param name="buildPlan">The ID of the Build Billing Plan</param>
        /// <param name="pushPlan">The ID of the Push Billing Plan</param>
        /// <param name="testPlan">The ID of the Test Billing Plan</param>
        public BillingInformationSearchResultsItem(string accountId = default(string), string accountName = default(string), string billingInternalAccountId = default(string), string buildPlan = default(string), string pushPlan = default(string), string testPlan = default(string))
        {
            AccountId = accountId;
            AccountName = accountName;
            BillingInternalAccountId = billingInternalAccountId;
            BuildPlan = buildPlan;
            PushPlan = pushPlan;
            TestPlan = testPlan;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Account ID
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets the Account Name
        /// </summary>
        [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets the Billing Internal Account ID
        /// </summary>
        [JsonProperty(PropertyName = "billingInternalAccountId")]
        public string BillingInternalAccountId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the Build Billing Plan
        /// </summary>
        [JsonProperty(PropertyName = "buildPlan")]
        public string BuildPlan { get; set; }

        /// <summary>
        /// Gets or sets the ID of the Push Billing Plan
        /// </summary>
        [JsonProperty(PropertyName = "pushPlan")]
        public string PushPlan { get; set; }

        /// <summary>
        /// Gets or sets the ID of the Test Billing Plan
        /// </summary>
        [JsonProperty(PropertyName = "testPlan")]
        public string TestPlan { get; set; }

    }
}