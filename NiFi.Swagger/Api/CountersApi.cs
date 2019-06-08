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
    public interface ICountersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets the current counters for this NiFi
        /// </summary>
        /// <remarks>
        /// Note: This endpoint is subject to change as NiFi and it&#39;s REST API evolve.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodewise">Whether or not to include the breakdown per node. Optional, defaults to false (optional, default to false)</param>
        /// <param name="clusterNodeId">The id of the node where to get the status. (optional)</param>
        /// <returns>CountersEntity</returns>
        CountersEntity GetCounters (bool? nodewise = null, string clusterNodeId = null);

        /// <summary>
        /// Gets the current counters for this NiFi
        /// </summary>
        /// <remarks>
        /// Note: This endpoint is subject to change as NiFi and it&#39;s REST API evolve.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodewise">Whether or not to include the breakdown per node. Optional, defaults to false (optional, default to false)</param>
        /// <param name="clusterNodeId">The id of the node where to get the status. (optional)</param>
        /// <returns>ApiResponse of CountersEntity</returns>
        ApiResponse<CountersEntity> GetCountersWithHttpInfo (bool? nodewise = null, string clusterNodeId = null);
        /// <summary>
        /// Updates the specified counter. This will reset the counter value to 0
        /// </summary>
        /// <remarks>
        /// Note: This endpoint is subject to change as NiFi and it&#39;s REST API evolve.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the counter.</param>
        /// <returns>CounterEntity</returns>
        CounterEntity UpdateCounter (string id);

        /// <summary>
        /// Updates the specified counter. This will reset the counter value to 0
        /// </summary>
        /// <remarks>
        /// Note: This endpoint is subject to change as NiFi and it&#39;s REST API evolve.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the counter.</param>
        /// <returns>ApiResponse of CounterEntity</returns>
        ApiResponse<CounterEntity> UpdateCounterWithHttpInfo (string id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Gets the current counters for this NiFi
        /// </summary>
        /// <remarks>
        /// Note: This endpoint is subject to change as NiFi and it&#39;s REST API evolve.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodewise">Whether or not to include the breakdown per node. Optional, defaults to false (optional, default to false)</param>
        /// <param name="clusterNodeId">The id of the node where to get the status. (optional)</param>
        /// <returns>Task of CountersEntity</returns>
        System.Threading.Tasks.Task<CountersEntity> GetCountersAsync (bool? nodewise = null, string clusterNodeId = null);

        /// <summary>
        /// Gets the current counters for this NiFi
        /// </summary>
        /// <remarks>
        /// Note: This endpoint is subject to change as NiFi and it&#39;s REST API evolve.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodewise">Whether or not to include the breakdown per node. Optional, defaults to false (optional, default to false)</param>
        /// <param name="clusterNodeId">The id of the node where to get the status. (optional)</param>
        /// <returns>Task of ApiResponse (CountersEntity)</returns>
        System.Threading.Tasks.Task<ApiResponse<CountersEntity>> GetCountersAsyncWithHttpInfo (bool? nodewise = null, string clusterNodeId = null);
        /// <summary>
        /// Updates the specified counter. This will reset the counter value to 0
        /// </summary>
        /// <remarks>
        /// Note: This endpoint is subject to change as NiFi and it&#39;s REST API evolve.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the counter.</param>
        /// <returns>Task of CounterEntity</returns>
        System.Threading.Tasks.Task<CounterEntity> UpdateCounterAsync (string id);

        /// <summary>
        /// Updates the specified counter. This will reset the counter value to 0
        /// </summary>
        /// <remarks>
        /// Note: This endpoint is subject to change as NiFi and it&#39;s REST API evolve.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the counter.</param>
        /// <returns>Task of ApiResponse (CounterEntity)</returns>
        System.Threading.Tasks.Task<ApiResponse<CounterEntity>> UpdateCounterAsyncWithHttpInfo (string id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CountersApi : ICountersApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CountersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CountersApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            this.ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CountersApi(Configuration configuration = null)
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
        /// Gets the current counters for this NiFi Note: This endpoint is subject to change as NiFi and it&#39;s REST API evolve.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodewise">Whether or not to include the breakdown per node. Optional, defaults to false (optional, default to false)</param>
        /// <param name="clusterNodeId">The id of the node where to get the status. (optional)</param>
        /// <returns>CountersEntity</returns>
        public CountersEntity GetCounters (bool? nodewise = null, string clusterNodeId = null)
        {
             ApiResponse<CountersEntity> localVarResponse = this.GetCountersWithHttpInfo(nodewise, clusterNodeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the current counters for this NiFi Note: This endpoint is subject to change as NiFi and it&#39;s REST API evolve.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodewise">Whether or not to include the breakdown per node. Optional, defaults to false (optional, default to false)</param>
        /// <param name="clusterNodeId">The id of the node where to get the status. (optional)</param>
        /// <returns>ApiResponse of CountersEntity</returns>
        public ApiResponse< CountersEntity > GetCountersWithHttpInfo (bool? nodewise = null, string clusterNodeId = null)
        {

            var localVarPath = "/counters";
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

            if (nodewise != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "nodewise", nodewise)); // query parameter
            if (clusterNodeId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "clusterNodeId", clusterNodeId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetCounters", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CountersEntity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CountersEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CountersEntity)));
        }

        /// <summary>
        /// Gets the current counters for this NiFi Note: This endpoint is subject to change as NiFi and it&#39;s REST API evolve.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodewise">Whether or not to include the breakdown per node. Optional, defaults to false (optional, default to false)</param>
        /// <param name="clusterNodeId">The id of the node where to get the status. (optional)</param>
        /// <returns>Task of CountersEntity</returns>
        public async System.Threading.Tasks.Task<CountersEntity> GetCountersAsync (bool? nodewise = null, string clusterNodeId = null)
        {
             ApiResponse<CountersEntity> localVarResponse = await this.GetCountersAsyncWithHttpInfo(nodewise, clusterNodeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the current counters for this NiFi Note: This endpoint is subject to change as NiFi and it&#39;s REST API evolve.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodewise">Whether or not to include the breakdown per node. Optional, defaults to false (optional, default to false)</param>
        /// <param name="clusterNodeId">The id of the node where to get the status. (optional)</param>
        /// <returns>Task of ApiResponse (CountersEntity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CountersEntity>> GetCountersAsyncWithHttpInfo (bool? nodewise = null, string clusterNodeId = null)
        {

            var localVarPath = "/counters";
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

            if (nodewise != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "nodewise", nodewise)); // query parameter
            if (clusterNodeId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "clusterNodeId", clusterNodeId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetCounters", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CountersEntity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CountersEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CountersEntity)));
        }

        /// <summary>
        /// Updates the specified counter. This will reset the counter value to 0 Note: This endpoint is subject to change as NiFi and it&#39;s REST API evolve.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the counter.</param>
        /// <returns>CounterEntity</returns>
        public CounterEntity UpdateCounter (string id)
        {
             ApiResponse<CounterEntity> localVarResponse = this.UpdateCounterWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates the specified counter. This will reset the counter value to 0 Note: This endpoint is subject to change as NiFi and it&#39;s REST API evolve.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the counter.</param>
        /// <returns>ApiResponse of CounterEntity</returns>
        public ApiResponse< CounterEntity > UpdateCounterWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CountersApi->UpdateCounter");

            var localVarPath = "/counters/{id}";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("UpdateCounter", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CounterEntity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CounterEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CounterEntity)));
        }

        /// <summary>
        /// Updates the specified counter. This will reset the counter value to 0 Note: This endpoint is subject to change as NiFi and it&#39;s REST API evolve.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the counter.</param>
        /// <returns>Task of CounterEntity</returns>
        public async System.Threading.Tasks.Task<CounterEntity> UpdateCounterAsync (string id)
        {
             ApiResponse<CounterEntity> localVarResponse = await this.UpdateCounterAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates the specified counter. This will reset the counter value to 0 Note: This endpoint is subject to change as NiFi and it&#39;s REST API evolve.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the counter.</param>
        /// <returns>Task of ApiResponse (CounterEntity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CounterEntity>> UpdateCounterAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CountersApi->UpdateCounter");

            var localVarPath = "/counters/{id}";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("UpdateCounter", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CounterEntity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CounterEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CounterEntity)));
        }

    }
}
