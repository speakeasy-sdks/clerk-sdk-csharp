//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Clerk.BackendAPI.Models.Components
{
    using Clerk.BackendAPI.Models.Components;
    using Clerk.BackendAPI.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    /// <summary>
    /// An organization invitation
    /// </summary>
    public class OrganizationInvitation
    {

        /// <summary>
        /// String representing the object&apos;s type. Objects of the same type share the same value.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("object")]
        public OrganizationInvitationObject Object { get; set; } = default!;

        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; } = default!;

        [JsonProperty("role")]
        public string Role { get; set; } = default!;

        [JsonProperty("role_name")]
        public string RoleName { get; set; } = default!;

        [JsonProperty("organization_id")]
        public string? OrganizationId { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("public_metadata")]
        public Dictionary<string, object> PublicMetadata { get; set; } = default!;

        [JsonProperty("private_metadata")]
        public Dictionary<string, object>? PrivateMetadata { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Include)]
        public string? Url { get; set; }

        /// <summary>
        /// Unix timestamp of expiration.
        /// </summary>
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Include)]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// Unix timestamp of creation.
        /// </summary>
        [JsonProperty("created_at")]
        public long CreatedAt { get; set; } = default!;

        /// <summary>
        /// Unix timestamp of last update.
        /// </summary>
        [JsonProperty("updated_at")]
        public long UpdatedAt { get; set; } = default!;
    }
}