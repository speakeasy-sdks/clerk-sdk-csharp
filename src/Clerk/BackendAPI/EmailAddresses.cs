//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Clerk.BackendAPI
{
    using Clerk.BackendAPI.Hooks;
    using Clerk.BackendAPI.Models.Components;
    using Clerk.BackendAPI.Models.Errors;
    using Clerk.BackendAPI.Models.Operations;
    using Clerk.BackendAPI.Utils.Retries;
    using Clerk.BackendAPI.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface IEmailAddresses
    {

        /// <summary>
        /// Create an email address
        /// 
        /// <remarks>
        /// Create a new email address
        /// </remarks>
        /// </summary>
        Task<CreateEmailAddressResponse> CreateAsync(CreateEmailAddressRequestBody? request = null);

        /// <summary>
        /// Retrieve an email address
        /// 
        /// <remarks>
        /// Returns the details of an email address.
        /// </remarks>
        /// </summary>
        Task<GetEmailAddressResponse> GetAsync(string emailAddressId);

        /// <summary>
        /// Delete an email address
        /// 
        /// <remarks>
        /// Delete the email address with the given ID
        /// </remarks>
        /// </summary>
        Task<DeleteEmailAddressResponse> DeleteAsync(string emailAddressId);

        /// <summary>
        /// Update an email address
        /// 
        /// <remarks>
        /// Updates an email address.
        /// </remarks>
        /// </summary>
        Task<UpdateEmailAddressResponse> UpdateAsync(string emailAddressId, UpdateEmailAddressRequestBody? requestBody = null);
    }

    public class EmailAddresses: IEmailAddresses
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.1.0";
        private const string _sdkGenVersion = "2.457.9";
        private const string _openapiDocVersion = "v1";
        private const string _userAgent = "speakeasy-sdk/csharp 0.1.0 2.457.9 v1 Clerk.BackendAPI";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<Clerk.BackendAPI.Models.Components.Security>? _securitySource;

        public EmailAddresses(ISpeakeasyHttpClient client, Func<Clerk.BackendAPI.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<CreateEmailAddressResponse> CreateAsync(CreateEmailAddressRequestBody? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();

            var urlString = baseUrl + "/email_addresses";

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "Request", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("CreateEmailAddress", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode == 401 || _statusCode == 403 || _statusCode == 404 || _statusCode == 422 || _statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<EmailAddress>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Include);
                    var response = new CreateEmailAddressResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.EmailAddress = obj;
                    return response;
                }

                throw new Models.Errors.SDKError("Unknown content type received", httpRequest, httpResponse);
            }
            else if(new List<int>{400, 401, 403, 404, 422}.Contains(responseStatusCode))
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<ClerkErrors>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Include);
                    throw obj!;
                }

                throw new Models.Errors.SDKError("Unknown content type received", httpRequest, httpResponse);
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKError("API error occurred", httpRequest, httpResponse);
            }

            throw new Models.Errors.SDKError("Unknown status code received", httpRequest, httpResponse);
        }

        public async Task<GetEmailAddressResponse> GetAsync(string emailAddressId)
        {
            var request = new GetEmailAddressRequest()
            {
                EmailAddressId = emailAddressId,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/email_addresses/{email_address_id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("GetEmailAddress", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode == 401 || _statusCode == 403 || _statusCode == 404 || _statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<EmailAddress>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetEmailAddressResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.EmailAddress = obj;
                    return response;
                }

                throw new Models.Errors.SDKError("Unknown content type received", httpRequest, httpResponse);
            }
            else if(new List<int>{400, 401, 403, 404}.Contains(responseStatusCode))
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<ClerkErrors>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    throw obj!;
                }

                throw new Models.Errors.SDKError("Unknown content type received", httpRequest, httpResponse);
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKError("API error occurred", httpRequest, httpResponse);
            }

            throw new Models.Errors.SDKError("Unknown status code received", httpRequest, httpResponse);
        }

        public async Task<DeleteEmailAddressResponse> DeleteAsync(string emailAddressId)
        {
            var request = new DeleteEmailAddressRequest()
            {
                EmailAddressId = emailAddressId,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/email_addresses/{email_address_id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("DeleteEmailAddress", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode == 401 || _statusCode == 403 || _statusCode == 404 || _statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<DeletedObject>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new DeleteEmailAddressResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.DeletedObject = obj;
                    return response;
                }

                throw new Models.Errors.SDKError("Unknown content type received", httpRequest, httpResponse);
            }
            else if(new List<int>{400, 401, 403, 404}.Contains(responseStatusCode))
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<ClerkErrors>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    throw obj!;
                }

                throw new Models.Errors.SDKError("Unknown content type received", httpRequest, httpResponse);
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKError("API error occurred", httpRequest, httpResponse);
            }

            throw new Models.Errors.SDKError("Unknown status code received", httpRequest, httpResponse);
        }

        public async Task<UpdateEmailAddressResponse> UpdateAsync(string emailAddressId, UpdateEmailAddressRequestBody? requestBody = null)
        {
            var request = new UpdateEmailAddressRequest()
            {
                EmailAddressId = emailAddressId,
                RequestBody = requestBody,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/email_addresses/{email_address_id}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "RequestBody", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("UpdateEmailAddress", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode == 401 || _statusCode == 403 || _statusCode == 404 || _statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<EmailAddress>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new UpdateEmailAddressResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.EmailAddress = obj;
                    return response;
                }

                throw new Models.Errors.SDKError("Unknown content type received", httpRequest, httpResponse);
            }
            else if(new List<int>{400, 401, 403, 404}.Contains(responseStatusCode))
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<ClerkErrors>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    throw obj!;
                }

                throw new Models.Errors.SDKError("Unknown content type received", httpRequest, httpResponse);
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKError("API error occurred", httpRequest, httpResponse);
            }

            throw new Models.Errors.SDKError("Unknown status code received", httpRequest, httpResponse);
        }
    }
}