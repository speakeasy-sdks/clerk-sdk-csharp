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
    
    public class SignUpVerifications
    {

        [JsonProperty("email_address", NullValueHandling = NullValueHandling.Include)]
        public SignUpVerification? EmailAddress { get; set; }

        [JsonProperty("phone_number", NullValueHandling = NullValueHandling.Include)]
        public SignUpVerification? PhoneNumber { get; set; }

        [JsonProperty("web3_wallet", NullValueHandling = NullValueHandling.Include)]
        public SignUpVerification? Web3Wallet { get; set; }

        [JsonProperty("external_account", NullValueHandling = NullValueHandling.Include)]
        public ExternalAccount? ExternalAccount { get; set; }
    }
}