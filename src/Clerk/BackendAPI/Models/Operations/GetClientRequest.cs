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
    using Clerk.BackendAPI.Utils;
    
    public class GetClientRequest
    {

        /// <summary>
        /// Client ID.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=client_id")]
        public string ClientId { get; set; } = default!;
    }
}