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
    
    public class SignUpVerification
    {

        [JsonProperty("next_action")]
        public NextAction? NextAction { get; set; }

        [JsonProperty("supported_strategies")]
        public List<string>? SupportedStrategies { get; set; }

        [JsonProperty("additionalProperties")]
        public Dictionary<string, object>? AdditionalProperties { get; set; }
    }
}