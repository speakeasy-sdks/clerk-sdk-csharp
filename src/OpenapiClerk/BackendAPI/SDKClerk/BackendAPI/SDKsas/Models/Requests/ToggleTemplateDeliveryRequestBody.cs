//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace OpenapiClerk.BackendAPI.SDKClerk.BackendAPI.SDKsas.Models.Requests
{
    using Newtonsoft.Json;
    using OpenapiClerk.BackendAPI.SDKClerk.BackendAPI.SDKsas.Utils;
    
    public class ToggleTemplateDeliveryRequestBody
    {

        /// <summary>
        /// Whether Clerk should deliver emails or SMS messages based on the current template
        /// </summary>
        [JsonProperty("delivered_by_clerk")]
        public bool? DeliveredByClerk { get; set; } = null;
    }
}