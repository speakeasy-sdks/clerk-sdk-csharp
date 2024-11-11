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
    using OpenapiClerk.BackendAPI.SDKClerk.BackendAPI.SDKsas.Utils;
    using System;
    
    public enum SchemasSAMLConnectionObject
    {
        [JsonProperty("saml_connection")]
        SamlConnection,
    }

    public static class SchemasSAMLConnectionObjectExtension
    {
        public static string Value(this SchemasSAMLConnectionObject value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static SchemasSAMLConnectionObject ToEnum(this string value)
        {
            foreach(var field in typeof(SchemasSAMLConnectionObject).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is SchemasSAMLConnectionObject)
                    {
                        return (SchemasSAMLConnectionObject)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum SchemasSAMLConnectionObject");
        }
    }

}