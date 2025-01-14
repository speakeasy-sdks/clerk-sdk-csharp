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
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// The type of templates to list (email or SMS)
    /// </summary>
    public enum TemplateType
    {
        [JsonProperty("email")]
        Email,
        [JsonProperty("sms")]
        Sms,
    }

    public static class TemplateTypeExtension
    {
        public static string Value(this TemplateType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static TemplateType ToEnum(this string value)
        {
            foreach(var field in typeof(TemplateType).GetFields())
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

                    if (enumVal is TemplateType)
                    {
                        return (TemplateType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum TemplateType");
        }
    }

}