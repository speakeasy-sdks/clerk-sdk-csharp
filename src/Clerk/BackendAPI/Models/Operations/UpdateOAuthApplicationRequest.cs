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
    
    public class UpdateOAuthApplicationRequest
    {

        /// <summary>
        /// The ID of the OAuth application to update
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=oauth_application_id")]
        public string OauthApplicationId { get; set; } = default!;

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public UpdateOAuthApplicationRequestBody RequestBody { get; set; } = default!;
    }
}