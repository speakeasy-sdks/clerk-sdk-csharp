//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Clerk.BackendAPI.Models.Operations
{
    using Clerk.BackendAPI.Models.Operations;
    using Clerk.BackendAPI.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    /// <summary>
    /// Required parameters
    /// </summary>
    public class CreateInvitationRequestBody
    {

        /// <summary>
        /// The email address the invitation will be sent to
        /// </summary>
        [JsonProperty("email_address")]
        public string EmailAddress { get; set; } = default!;

        /// <summary>
        /// Metadata that will be attached to the newly created invitation.<br/>
        /// 
        /// <remarks>
        /// The value of this property should be a well-formed JSON object.<br/>
        /// Once the user accepts the invitation and signs up, these metadata will end up in the user&apos;s public metadata.
        /// </remarks>
        /// </summary>
        [JsonProperty("public_metadata")]
        public Dictionary<string, object>? PublicMetadata { get; set; }

        /// <summary>
        /// Optional URL which specifies where to redirect the user once they click the invitation link.<br/>
        /// 
        /// <remarks>
        /// This is only required if you have implemented a <a href="https://clerk.com/docs/authentication/invitations#custom-flow">custom flow</a> and you&apos;re not using Clerk Hosted Pages or Clerk Components.
        /// </remarks>
        /// </summary>
        [JsonProperty("redirect_url")]
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// Optional flag which denotes whether an email invitation should be sent to the given email address.<br/>
        /// 
        /// <remarks>
        /// Defaults to `true`.
        /// </remarks>
        /// </summary>
        [JsonProperty("notify")]
        public bool? Notify { get; set; } = true;

        /// <summary>
        /// Whether an invitation should be created if there is already an existing invitation for this email address, or it&apos;s claimed by another user.
        /// </summary>
        [JsonProperty("ignore_existing")]
        public bool? IgnoreExisting { get; set; } = false;

        /// <summary>
        /// The number of days the invitation will be valid for. By default, the invitation expires after 30 days.
        /// </summary>
        [JsonProperty("expires_in_days")]
        public long? ExpiresInDays { get; set; } = null;

        /// <summary>
        /// The slug of the email template to use for the invitation email.
        /// </summary>
        [JsonProperty("template_slug")]
        public TemplateSlug? TemplateSlug { get; set; }
    }
}