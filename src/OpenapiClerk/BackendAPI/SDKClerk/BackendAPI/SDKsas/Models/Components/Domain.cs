//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace OpenapiClerk.BackendAPI.SDKClerk.BackendAPI.SDKsas.Models.Components
{
    using Newtonsoft.Json;
    using OpenapiClerk.BackendAPI.SDKClerk.BackendAPI.SDKsas.Models.Components;
    using OpenapiClerk.BackendAPI.SDKClerk.BackendAPI.SDKsas.Utils;
    using System.Collections.Generic;
    
    public class Domain
    {

        [JsonProperty("object")]
        public DomainObject Object { get; set; } = default!;

        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("is_satellite")]
        public bool IsSatellite { get; set; } = default!;

        [JsonProperty("frontend_api_url")]
        public string FrontendApiUrl { get; set; } = default!;

        /// <summary>
        /// Null for satellite domains.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("accounts_portal_url")]
        public string? AccountsPortalUrl { get; set; } = null;

        [JsonProperty("proxy_url")]
        public string? ProxyUrl { get; set; } = null;

        [JsonProperty("development_origin")]
        public string DevelopmentOrigin { get; set; } = default!;

        [JsonProperty("cname_targets")]
        public List<CNameTarget>? CnameTargets { get; set; } = null;
    }
}