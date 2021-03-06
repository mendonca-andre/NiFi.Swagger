/* 
 * NiFi Rest Api
 *
 * The Rest Api provides programmatic access to command and control a NiFi instance in real time. Start and                                              stop processors, monitor queues, query provenance data, and more. Each endpoint below includes a description,                                             definitions of the expected input and output, potential response codes, and the authorizations required                                             to invoke each service.
 *
 * OpenAPI spec version: 1.9.1
 * Contact: dev@nifi.apache.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

namespace NiFi.Swagger.Api
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    using NiFi.Swagger.Client;
    using NiFi.Swagger.Model;

    using RestSharp;

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFunnelApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets a funnel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <returns>FunnelEntity</returns>
        FunnelEntity GetFunnel (string id);

        /// <summary>
        /// Gets a funnel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <returns>ApiResponse of FunnelEntity</returns>
        ApiResponse<FunnelEntity> GetFunnelWithHttpInfo (string id);
        /// <summary>
        /// Deletes a funnel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <param name="version">The revision is used to verify the client is working with the latest version of the flow. (optional)</param>
        /// <param name="clientId">If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional)</param>
        /// <param name="disconnectedNodeAcknowledged">Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional, default to false)</param>
        /// <returns>FunnelEntity</returns>
        FunnelEntity RemoveFunnel (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null);

        /// <summary>
        /// Deletes a funnel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <param name="version">The revision is used to verify the client is working with the latest version of the flow. (optional)</param>
        /// <param name="clientId">If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional)</param>
        /// <param name="disconnectedNodeAcknowledged">Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional, default to false)</param>
        /// <returns>ApiResponse of FunnelEntity</returns>
        ApiResponse<FunnelEntity> RemoveFunnelWithHttpInfo (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null);
        /// <summary>
        /// Updates a funnel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <param name="body">The funnel configuration details.</param>
        /// <returns>FunnelEntity</returns>
        FunnelEntity UpdateFunnel (string id, FunnelEntity body);

        /// <summary>
        /// Updates a funnel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <param name="body">The funnel configuration details.</param>
        /// <returns>ApiResponse of FunnelEntity</returns>
        ApiResponse<FunnelEntity> UpdateFunnelWithHttpInfo (string id, FunnelEntity body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Gets a funnel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <returns>Task of FunnelEntity</returns>
        System.Threading.Tasks.Task<FunnelEntity> GetFunnelAsync (string id);

        /// <summary>
        /// Gets a funnel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <returns>Task of ApiResponse (FunnelEntity)</returns>
        System.Threading.Tasks.Task<ApiResponse<FunnelEntity>> GetFunnelAsyncWithHttpInfo (string id);
        /// <summary>
        /// Deletes a funnel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <param name="version">The revision is used to verify the client is working with the latest version of the flow. (optional)</param>
        /// <param name="clientId">If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional)</param>
        /// <param name="disconnectedNodeAcknowledged">Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional, default to false)</param>
        /// <returns>Task of FunnelEntity</returns>
        System.Threading.Tasks.Task<FunnelEntity> RemoveFunnelAsync (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null);

        /// <summary>
        /// Deletes a funnel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <param name="version">The revision is used to verify the client is working with the latest version of the flow. (optional)</param>
        /// <param name="clientId">If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional)</param>
        /// <param name="disconnectedNodeAcknowledged">Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (FunnelEntity)</returns>
        System.Threading.Tasks.Task<ApiResponse<FunnelEntity>> RemoveFunnelAsyncWithHttpInfo (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null);
        /// <summary>
        /// Updates a funnel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <param name="body">The funnel configuration details.</param>
        /// <returns>Task of FunnelEntity</returns>
        System.Threading.Tasks.Task<FunnelEntity> UpdateFunnelAsync (string id, FunnelEntity body);

        /// <summary>
        /// Updates a funnel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <param name="body">The funnel configuration details.</param>
        /// <returns>Task of ApiResponse (FunnelEntity)</returns>
        System.Threading.Tasks.Task<ApiResponse<FunnelEntity>> UpdateFunnelAsyncWithHttpInfo (string id, FunnelEntity body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FunnelApi : IFunnelApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FunnelApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FunnelApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            this.ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunnelApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FunnelApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            this.ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (this._exceptionFactory != null && this._exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return this._exceptionFactory;
            }
            set { this._exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Gets a funnel 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <returns>FunnelEntity</returns>
        public FunnelEntity GetFunnel (string id)
        {
             ApiResponse<FunnelEntity> localVarResponse = this.GetFunnelWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a funnel 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <returns>ApiResponse of FunnelEntity</returns>
        public ApiResponse< FunnelEntity > GetFunnelWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FunnelApi->GetFunnel");

            var localVarPath = "/funnels/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetFunnel", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FunnelEntity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FunnelEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FunnelEntity)));
        }

        /// <summary>
        /// Gets a funnel 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <returns>Task of FunnelEntity</returns>
        public async System.Threading.Tasks.Task<FunnelEntity> GetFunnelAsync (string id)
        {
             ApiResponse<FunnelEntity> localVarResponse = await this.GetFunnelAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a funnel 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <returns>Task of ApiResponse (FunnelEntity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FunnelEntity>> GetFunnelAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FunnelApi->GetFunnel");

            var localVarPath = "/funnels/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetFunnel", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FunnelEntity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FunnelEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FunnelEntity)));
        }

        /// <summary>
        /// Deletes a funnel 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <param name="version">The revision is used to verify the client is working with the latest version of the flow. (optional)</param>
        /// <param name="clientId">If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional)</param>
        /// <param name="disconnectedNodeAcknowledged">Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional, default to false)</param>
        /// <returns>FunnelEntity</returns>
        public FunnelEntity RemoveFunnel (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null)
        {
             ApiResponse<FunnelEntity> localVarResponse = this.RemoveFunnelWithHttpInfo(id, version, clientId, disconnectedNodeAcknowledged);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Deletes a funnel 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <param name="version">The revision is used to verify the client is working with the latest version of the flow. (optional)</param>
        /// <param name="clientId">If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional)</param>
        /// <param name="disconnectedNodeAcknowledged">Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional, default to false)</param>
        /// <returns>ApiResponse of FunnelEntity</returns>
        public ApiResponse< FunnelEntity > RemoveFunnelWithHttpInfo (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FunnelApi->RemoveFunnel");

            var localVarPath = "/funnels/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (version != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "version", version)); // query parameter
            if (clientId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "clientId", clientId)); // query parameter
            if (disconnectedNodeAcknowledged != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "disconnectedNodeAcknowledged", disconnectedNodeAcknowledged)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RemoveFunnel", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FunnelEntity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FunnelEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FunnelEntity)));
        }

        /// <summary>
        /// Deletes a funnel 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <param name="version">The revision is used to verify the client is working with the latest version of the flow. (optional)</param>
        /// <param name="clientId">If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional)</param>
        /// <param name="disconnectedNodeAcknowledged">Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional, default to false)</param>
        /// <returns>Task of FunnelEntity</returns>
        public async System.Threading.Tasks.Task<FunnelEntity> RemoveFunnelAsync (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null)
        {
             ApiResponse<FunnelEntity> localVarResponse = await this.RemoveFunnelAsyncWithHttpInfo(id, version, clientId, disconnectedNodeAcknowledged);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Deletes a funnel 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <param name="version">The revision is used to verify the client is working with the latest version of the flow. (optional)</param>
        /// <param name="clientId">If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional)</param>
        /// <param name="disconnectedNodeAcknowledged">Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (FunnelEntity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FunnelEntity>> RemoveFunnelAsyncWithHttpInfo (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FunnelApi->RemoveFunnel");

            var localVarPath = "/funnels/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (version != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "version", version)); // query parameter
            if (clientId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "clientId", clientId)); // query parameter
            if (disconnectedNodeAcknowledged != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "disconnectedNodeAcknowledged", disconnectedNodeAcknowledged)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RemoveFunnel", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FunnelEntity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FunnelEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FunnelEntity)));
        }

        /// <summary>
        /// Updates a funnel 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <param name="body">The funnel configuration details.</param>
        /// <returns>FunnelEntity</returns>
        public FunnelEntity UpdateFunnel (string id, FunnelEntity body)
        {
             ApiResponse<FunnelEntity> localVarResponse = this.UpdateFunnelWithHttpInfo(id, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates a funnel 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <param name="body">The funnel configuration details.</param>
        /// <returns>ApiResponse of FunnelEntity</returns>
        public ApiResponse< FunnelEntity > UpdateFunnelWithHttpInfo (string id, FunnelEntity body)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FunnelApi->UpdateFunnel");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling FunnelApi->UpdateFunnel");

            var localVarPath = "/funnels/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("UpdateFunnel", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FunnelEntity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FunnelEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FunnelEntity)));
        }

        /// <summary>
        /// Updates a funnel 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <param name="body">The funnel configuration details.</param>
        /// <returns>Task of FunnelEntity</returns>
        public async System.Threading.Tasks.Task<FunnelEntity> UpdateFunnelAsync (string id, FunnelEntity body)
        {
             ApiResponse<FunnelEntity> localVarResponse = await this.UpdateFunnelAsyncWithHttpInfo(id, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates a funnel 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The funnel id.</param>
        /// <param name="body">The funnel configuration details.</param>
        /// <returns>Task of ApiResponse (FunnelEntity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FunnelEntity>> UpdateFunnelAsyncWithHttpInfo (string id, FunnelEntity body)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FunnelApi->UpdateFunnel");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling FunnelApi->UpdateFunnel");

            var localVarPath = "/funnels/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("UpdateFunnel", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FunnelEntity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FunnelEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FunnelEntity)));
        }

    }
}
