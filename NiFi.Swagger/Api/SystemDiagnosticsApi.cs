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
    public interface ISystemDiagnosticsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets the diagnostics for the system NiFi is running on
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodewise">Whether or not to include the breakdown per node. Optional, defaults to false (optional, default to false)</param>
        /// <param name="clusterNodeId">The id of the node where to get the status. (optional)</param>
        /// <returns>SystemDiagnosticsEntity</returns>
        SystemDiagnosticsEntity GetSystemDiagnostics (bool? nodewise = null, string clusterNodeId = null);

        /// <summary>
        /// Gets the diagnostics for the system NiFi is running on
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodewise">Whether or not to include the breakdown per node. Optional, defaults to false (optional, default to false)</param>
        /// <param name="clusterNodeId">The id of the node where to get the status. (optional)</param>
        /// <returns>ApiResponse of SystemDiagnosticsEntity</returns>
        ApiResponse<SystemDiagnosticsEntity> GetSystemDiagnosticsWithHttpInfo (bool? nodewise = null, string clusterNodeId = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Gets the diagnostics for the system NiFi is running on
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodewise">Whether or not to include the breakdown per node. Optional, defaults to false (optional, default to false)</param>
        /// <param name="clusterNodeId">The id of the node where to get the status. (optional)</param>
        /// <returns>Task of SystemDiagnosticsEntity</returns>
        System.Threading.Tasks.Task<SystemDiagnosticsEntity> GetSystemDiagnosticsAsync (bool? nodewise = null, string clusterNodeId = null);

        /// <summary>
        /// Gets the diagnostics for the system NiFi is running on
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodewise">Whether or not to include the breakdown per node. Optional, defaults to false (optional, default to false)</param>
        /// <param name="clusterNodeId">The id of the node where to get the status. (optional)</param>
        /// <returns>Task of ApiResponse (SystemDiagnosticsEntity)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemDiagnosticsEntity>> GetSystemDiagnosticsAsyncWithHttpInfo (bool? nodewise = null, string clusterNodeId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SystemDiagnosticsApi : ISystemDiagnosticsApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemDiagnosticsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SystemDiagnosticsApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            this.ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemDiagnosticsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SystemDiagnosticsApi(Configuration configuration = null)
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
        /// Gets the diagnostics for the system NiFi is running on 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodewise">Whether or not to include the breakdown per node. Optional, defaults to false (optional, default to false)</param>
        /// <param name="clusterNodeId">The id of the node where to get the status. (optional)</param>
        /// <returns>SystemDiagnosticsEntity</returns>
        public SystemDiagnosticsEntity GetSystemDiagnostics (bool? nodewise = null, string clusterNodeId = null)
        {
             ApiResponse<SystemDiagnosticsEntity> localVarResponse = this.GetSystemDiagnosticsWithHttpInfo(nodewise, clusterNodeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the diagnostics for the system NiFi is running on 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodewise">Whether or not to include the breakdown per node. Optional, defaults to false (optional, default to false)</param>
        /// <param name="clusterNodeId">The id of the node where to get the status. (optional)</param>
        /// <returns>ApiResponse of SystemDiagnosticsEntity</returns>
        public ApiResponse< SystemDiagnosticsEntity > GetSystemDiagnosticsWithHttpInfo (bool? nodewise = null, string clusterNodeId = null)
        {

            var localVarPath = "/system-diagnostics";
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
                Exception exception = this.ExceptionFactory("GetSystemDiagnostics", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SystemDiagnosticsEntity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemDiagnosticsEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemDiagnosticsEntity)));
        }

        /// <summary>
        /// Gets the diagnostics for the system NiFi is running on 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodewise">Whether or not to include the breakdown per node. Optional, defaults to false (optional, default to false)</param>
        /// <param name="clusterNodeId">The id of the node where to get the status. (optional)</param>
        /// <returns>Task of SystemDiagnosticsEntity</returns>
        public async System.Threading.Tasks.Task<SystemDiagnosticsEntity> GetSystemDiagnosticsAsync (bool? nodewise = null, string clusterNodeId = null)
        {
             ApiResponse<SystemDiagnosticsEntity> localVarResponse = await this.GetSystemDiagnosticsAsyncWithHttpInfo(nodewise, clusterNodeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the diagnostics for the system NiFi is running on 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodewise">Whether or not to include the breakdown per node. Optional, defaults to false (optional, default to false)</param>
        /// <param name="clusterNodeId">The id of the node where to get the status. (optional)</param>
        /// <returns>Task of ApiResponse (SystemDiagnosticsEntity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemDiagnosticsEntity>> GetSystemDiagnosticsAsyncWithHttpInfo (bool? nodewise = null, string clusterNodeId = null)
        {

            var localVarPath = "/system-diagnostics";
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
                Exception exception = this.ExceptionFactory("GetSystemDiagnostics", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SystemDiagnosticsEntity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemDiagnosticsEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemDiagnosticsEntity)));
        }

    }
}
