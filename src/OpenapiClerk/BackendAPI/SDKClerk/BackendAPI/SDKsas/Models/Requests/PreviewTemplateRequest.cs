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
    using OpenapiClerk.BackendAPI.SDKClerk.BackendAPI.SDKsas.Models.Requests;
    using OpenapiClerk.BackendAPI.SDKClerk.BackendAPI.SDKsas.Utils;
    
    public class PreviewTemplateRequest
    {

        /// <summary>
        /// The type of template to preview
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=template_type")]
        public string TemplateType { get; set; } = default!;

        /// <summary>
        /// The slug of the template to preview
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=slug")]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Required parameters
        /// </summary>
        [SpeakeasyMetadata("request:mediaType=application/json")]
        public PreviewTemplateRequestBody? RequestBody { get; set; }
    }
}