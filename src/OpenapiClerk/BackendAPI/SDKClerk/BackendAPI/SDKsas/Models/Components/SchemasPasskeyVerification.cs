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
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using OpenapiClerk.BackendAPI.SDKClerk.BackendAPI.SDKsas.Models.Components;
    using OpenapiClerk.BackendAPI.SDKClerk.BackendAPI.SDKsas.Utils;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    using System;
    

    public class SchemasPasskeyVerificationType
    {
        private SchemasPasskeyVerificationType(string value) { Value = value; }

        public string Value { get; private set; }
        public static SchemasPasskeyVerificationType Passkey { get { return new SchemasPasskeyVerificationType("Passkey"); } }
        
        public static SchemasPasskeyVerificationType Null { get { return new SchemasPasskeyVerificationType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(SchemasPasskeyVerificationType v) { return v.Value; }
        public static SchemasPasskeyVerificationType FromString(string v) {
            switch(v) {
                case "Passkey": return Passkey;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for SchemasPasskeyVerificationType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((SchemasPasskeyVerificationType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(SchemasPasskeyVerification.SchemasPasskeyVerificationConverter))]
    public class SchemasPasskeyVerification {
        public SchemasPasskeyVerification(SchemasPasskeyVerificationType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public Passkey? Passkey { get; set; }

        public SchemasPasskeyVerificationType Type { get; set; }


        public static SchemasPasskeyVerification CreatePasskey(Passkey passkey) {
            SchemasPasskeyVerificationType typ = SchemasPasskeyVerificationType.Passkey;

            SchemasPasskeyVerification res = new SchemasPasskeyVerification(typ);
            res.Passkey = passkey;
            return res;
        }

        public static SchemasPasskeyVerification CreateNull() {
            SchemasPasskeyVerificationType typ = SchemasPasskeyVerificationType.Null;
            return new SchemasPasskeyVerification(typ);
        }

        public class SchemasPasskeyVerificationConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(SchemasPasskeyVerification);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            {
                var json = JRaw.Create(reader).ToString();
                if (json == "null")
                {
                    return null;
                }

                var fallbackCandidates = new List<(System.Type, object, string)>();

                try
                {
                    return new SchemasPasskeyVerification(SchemasPasskeyVerificationType.Passkey)
                    {
                        Passkey = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<Passkey>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(Passkey), new SchemasPasskeyVerification(SchemasPasskeyVerificationType.Passkey), "Passkey"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                if (fallbackCandidates.Count > 0)
                {
                    fallbackCandidates.Sort((a, b) => ResponseBodyDeserializer.CompareFallbackCandidates(a.Item1, b.Item1, json));
                    foreach(var (deserializationType, returnObject, propertyName) in fallbackCandidates)
                    {
                        try
                        {
                            return ResponseBodyDeserializer.DeserializeUndiscriminatedUnionFallback(deserializationType, returnObject, propertyName, json);
                        }
                        catch (ResponseBodyDeserializer.DeserializationException)
                        {
                            // try next fallback option
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                SchemasPasskeyVerification res = (SchemasPasskeyVerification)value;
                if (SchemasPasskeyVerificationType.FromString(res.Type).Equals(SchemasPasskeyVerificationType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.Passkey != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Passkey));
                    return;
                }

            }

        }

    }
}