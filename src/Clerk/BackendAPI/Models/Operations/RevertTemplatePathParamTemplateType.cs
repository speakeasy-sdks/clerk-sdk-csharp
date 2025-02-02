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
    /// The type of template to revert
    /// </summary>
    public enum RevertTemplatePathParamTemplateType
    {
        [JsonProperty("email")]
        Email,
        [JsonProperty("sms")]
        Sms,
    }

    public static class RevertTemplatePathParamTemplateTypeExtension
    {
        public static string Value(this RevertTemplatePathParamTemplateType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static RevertTemplatePathParamTemplateType ToEnum(this string value)
        {
            foreach(var field in typeof(RevertTemplatePathParamTemplateType).GetFields())
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

                    if (enumVal is RevertTemplatePathParamTemplateType)
                    {
                        return (RevertTemplatePathParamTemplateType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum RevertTemplatePathParamTemplateType");
        }
    }

}