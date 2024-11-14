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
    
    public class UpdateUserMetadataRequest
    {

        /// <summary>
        /// The ID of the user whose metadata will be updated and merged
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=user_id")]
        public string UserId { get; set; } = default!;

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public UpdateUserMetadataRequestBody? RequestBody { get; set; }
    }
}