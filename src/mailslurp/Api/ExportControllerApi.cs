/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://docs.mailslurp.com/) - [Examples](https://github.com/mailslurp/examples) repository
 *
 * The version of the OpenAPI document: 6.5.2
 * Contact: contact@mailslurp.dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using mailslurp.Client;
using mailslurp.Model;

namespace mailslurp.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExportControllerApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Export inboxes link callable via browser
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType"></param>
        /// <param name="apiKey"></param>
        /// <param name="outputFormat"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="listSeparatorToken"> (optional)</param>
        /// <param name="excludePreviouslyExported"> (optional)</param>
        /// <param name="createdEarliestTime"> (optional)</param>
        /// <param name="createdOldestTime"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>byte[]</returns>
        byte[] ExportEntities(string exportType, string apiKey, string outputFormat, string filter = default(string), string listSeparatorToken = default(string), bool? excludePreviouslyExported = default(bool?), DateTime? createdEarliestTime = default(DateTime?), DateTime? createdOldestTime = default(DateTime?), int operationIndex = 0);

        /// <summary>
        /// Export inboxes link callable via browser
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType"></param>
        /// <param name="apiKey"></param>
        /// <param name="outputFormat"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="listSeparatorToken"> (optional)</param>
        /// <param name="excludePreviouslyExported"> (optional)</param>
        /// <param name="createdEarliestTime"> (optional)</param>
        /// <param name="createdOldestTime"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of byte[]</returns>
        ApiResponse<byte[]> ExportEntitiesWithHttpInfo(string exportType, string apiKey, string outputFormat, string filter = default(string), string listSeparatorToken = default(string), bool? excludePreviouslyExported = default(bool?), DateTime? createdEarliestTime = default(DateTime?), DateTime? createdOldestTime = default(DateTime?), int operationIndex = 0);
        /// <summary>
        /// Get export link
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType"></param>
        /// <param name="exportOptions"></param>
        /// <param name="apiKey"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ExportLink</returns>
        ExportLink GetExportLink(string exportType, ExportOptions exportOptions, string apiKey = default(string), int operationIndex = 0);

        /// <summary>
        /// Get export link
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType"></param>
        /// <param name="exportOptions"></param>
        /// <param name="apiKey"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ExportLink</returns>
        ApiResponse<ExportLink> GetExportLinkWithHttpInfo(string exportType, ExportOptions exportOptions, string apiKey = default(string), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExportControllerApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Export inboxes link callable via browser
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType"></param>
        /// <param name="apiKey"></param>
        /// <param name="outputFormat"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="listSeparatorToken"> (optional)</param>
        /// <param name="excludePreviouslyExported"> (optional)</param>
        /// <param name="createdEarliestTime"> (optional)</param>
        /// <param name="createdOldestTime"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of byte[]</returns>
        System.Threading.Tasks.Task<byte[]> ExportEntitiesAsync(string exportType, string apiKey, string outputFormat, string filter = default(string), string listSeparatorToken = default(string), bool? excludePreviouslyExported = default(bool?), DateTime? createdEarliestTime = default(DateTime?), DateTime? createdOldestTime = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Export inboxes link callable via browser
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType"></param>
        /// <param name="apiKey"></param>
        /// <param name="outputFormat"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="listSeparatorToken"> (optional)</param>
        /// <param name="excludePreviouslyExported"> (optional)</param>
        /// <param name="createdEarliestTime"> (optional)</param>
        /// <param name="createdOldestTime"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        System.Threading.Tasks.Task<ApiResponse<byte[]>> ExportEntitiesWithHttpInfoAsync(string exportType, string apiKey, string outputFormat, string filter = default(string), string listSeparatorToken = default(string), bool? excludePreviouslyExported = default(bool?), DateTime? createdEarliestTime = default(DateTime?), DateTime? createdOldestTime = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get export link
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType"></param>
        /// <param name="exportOptions"></param>
        /// <param name="apiKey"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ExportLink</returns>
        System.Threading.Tasks.Task<ExportLink> GetExportLinkAsync(string exportType, ExportOptions exportOptions, string apiKey = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get export link
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType"></param>
        /// <param name="exportOptions"></param>
        /// <param name="apiKey"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ExportLink)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExportLink>> GetExportLinkWithHttpInfoAsync(string exportType, ExportOptions exportOptions, string apiKey = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExportControllerApi : IExportControllerApiSync, IExportControllerApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ExportControllerApi : IExportControllerApi
    {
        private mailslurp.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExportControllerApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExportControllerApi(string basePath)
        {
            this.Configuration = mailslurp.Client.Configuration.MergeConfigurations(
                mailslurp.Client.GlobalConfiguration.Instance,
                new mailslurp.Client.Configuration { BasePath = basePath }
            );
            this.Client = new mailslurp.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new mailslurp.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = mailslurp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportControllerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ExportControllerApi(mailslurp.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = mailslurp.Client.Configuration.MergeConfigurations(
                mailslurp.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new mailslurp.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new mailslurp.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = mailslurp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportControllerApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ExportControllerApi(mailslurp.Client.ISynchronousClient client, mailslurp.Client.IAsynchronousClient asyncClient, mailslurp.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = mailslurp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public mailslurp.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public mailslurp.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public mailslurp.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public mailslurp.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Export inboxes link callable via browser 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType"></param>
        /// <param name="apiKey"></param>
        /// <param name="outputFormat"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="listSeparatorToken"> (optional)</param>
        /// <param name="excludePreviouslyExported"> (optional)</param>
        /// <param name="createdEarliestTime"> (optional)</param>
        /// <param name="createdOldestTime"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>byte[]</returns>
        public byte[] ExportEntities(string exportType, string apiKey, string outputFormat, string filter = default(string), string listSeparatorToken = default(string), bool? excludePreviouslyExported = default(bool?), DateTime? createdEarliestTime = default(DateTime?), DateTime? createdOldestTime = default(DateTime?), int operationIndex = 0)
        {
            mailslurp.Client.ApiResponse<byte[]> localVarResponse = ExportEntitiesWithHttpInfo(exportType, apiKey, outputFormat, filter, listSeparatorToken, excludePreviouslyExported, createdEarliestTime, createdOldestTime);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Export inboxes link callable via browser 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType"></param>
        /// <param name="apiKey"></param>
        /// <param name="outputFormat"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="listSeparatorToken"> (optional)</param>
        /// <param name="excludePreviouslyExported"> (optional)</param>
        /// <param name="createdEarliestTime"> (optional)</param>
        /// <param name="createdOldestTime"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of byte[]</returns>
        public mailslurp.Client.ApiResponse<byte[]> ExportEntitiesWithHttpInfo(string exportType, string apiKey, string outputFormat, string filter = default(string), string listSeparatorToken = default(string), bool? excludePreviouslyExported = default(bool?), DateTime? createdEarliestTime = default(DateTime?), DateTime? createdOldestTime = default(DateTime?), int operationIndex = 0)
        {
            // verify the required parameter 'exportType' is set
            if (exportType == null)
            {
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'exportType' when calling ExportControllerApi->ExportEntities");
            }

            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
            {
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'apiKey' when calling ExportControllerApi->ExportEntities");
            }

            // verify the required parameter 'outputFormat' is set
            if (outputFormat == null)
            {
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'outputFormat' when calling ExportControllerApi->ExportEntities");
            }

            mailslurp.Client.RequestOptions localVarRequestOptions = new mailslurp.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "*/*"
            };

            var localVarContentType = mailslurp.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = mailslurp.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "exportType", exportType));
            localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "apiKey", apiKey));
            localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "outputFormat", outputFormat));
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (listSeparatorToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "listSeparatorToken", listSeparatorToken));
            }
            if (excludePreviouslyExported != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "excludePreviouslyExported", excludePreviouslyExported));
            }
            if (createdEarliestTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "createdEarliestTime", createdEarliestTime));
            }
            if (createdOldestTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "createdOldestTime", createdOldestTime));
            }

            localVarRequestOptions.Operation = "ExportControllerApi.ExportEntities";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (API_KEY) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<byte[]>("/export", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ExportEntities", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Export inboxes link callable via browser 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType"></param>
        /// <param name="apiKey"></param>
        /// <param name="outputFormat"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="listSeparatorToken"> (optional)</param>
        /// <param name="excludePreviouslyExported"> (optional)</param>
        /// <param name="createdEarliestTime"> (optional)</param>
        /// <param name="createdOldestTime"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of byte[]</returns>
        public async System.Threading.Tasks.Task<byte[]> ExportEntitiesAsync(string exportType, string apiKey, string outputFormat, string filter = default(string), string listSeparatorToken = default(string), bool? excludePreviouslyExported = default(bool?), DateTime? createdEarliestTime = default(DateTime?), DateTime? createdOldestTime = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            mailslurp.Client.ApiResponse<byte[]> localVarResponse = await ExportEntitiesWithHttpInfoAsync(exportType, apiKey, outputFormat, filter, listSeparatorToken, excludePreviouslyExported, createdEarliestTime, createdOldestTime, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Export inboxes link callable via browser 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType"></param>
        /// <param name="apiKey"></param>
        /// <param name="outputFormat"></param>
        /// <param name="filter"> (optional)</param>
        /// <param name="listSeparatorToken"> (optional)</param>
        /// <param name="excludePreviouslyExported"> (optional)</param>
        /// <param name="createdEarliestTime"> (optional)</param>
        /// <param name="createdOldestTime"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        public async System.Threading.Tasks.Task<mailslurp.Client.ApiResponse<byte[]>> ExportEntitiesWithHttpInfoAsync(string exportType, string apiKey, string outputFormat, string filter = default(string), string listSeparatorToken = default(string), bool? excludePreviouslyExported = default(bool?), DateTime? createdEarliestTime = default(DateTime?), DateTime? createdOldestTime = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'exportType' is set
            if (exportType == null)
            {
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'exportType' when calling ExportControllerApi->ExportEntities");
            }

            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
            {
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'apiKey' when calling ExportControllerApi->ExportEntities");
            }

            // verify the required parameter 'outputFormat' is set
            if (outputFormat == null)
            {
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'outputFormat' when calling ExportControllerApi->ExportEntities");
            }


            mailslurp.Client.RequestOptions localVarRequestOptions = new mailslurp.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "*/*"
            };

            var localVarContentType = mailslurp.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = mailslurp.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "exportType", exportType));
            localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "apiKey", apiKey));
            localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "outputFormat", outputFormat));
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (listSeparatorToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "listSeparatorToken", listSeparatorToken));
            }
            if (excludePreviouslyExported != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "excludePreviouslyExported", excludePreviouslyExported));
            }
            if (createdEarliestTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "createdEarliestTime", createdEarliestTime));
            }
            if (createdOldestTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "createdOldestTime", createdOldestTime));
            }

            localVarRequestOptions.Operation = "ExportControllerApi.ExportEntities";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (API_KEY) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<byte[]>("/export", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ExportEntities", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get export link 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType"></param>
        /// <param name="exportOptions"></param>
        /// <param name="apiKey"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ExportLink</returns>
        public ExportLink GetExportLink(string exportType, ExportOptions exportOptions, string apiKey = default(string), int operationIndex = 0)
        {
            mailslurp.Client.ApiResponse<ExportLink> localVarResponse = GetExportLinkWithHttpInfo(exportType, exportOptions, apiKey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get export link 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType"></param>
        /// <param name="exportOptions"></param>
        /// <param name="apiKey"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ExportLink</returns>
        public mailslurp.Client.ApiResponse<ExportLink> GetExportLinkWithHttpInfo(string exportType, ExportOptions exportOptions, string apiKey = default(string), int operationIndex = 0)
        {
            // verify the required parameter 'exportType' is set
            if (exportType == null)
            {
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'exportType' when calling ExportControllerApi->GetExportLink");
            }

            // verify the required parameter 'exportOptions' is set
            if (exportOptions == null)
            {
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'exportOptions' when calling ExportControllerApi->GetExportLink");
            }

            mailslurp.Client.RequestOptions localVarRequestOptions = new mailslurp.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "*/*"
            };

            var localVarContentType = mailslurp.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = mailslurp.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "exportType", exportType));
            if (apiKey != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "apiKey", apiKey));
            }
            localVarRequestOptions.Data = exportOptions;

            localVarRequestOptions.Operation = "ExportControllerApi.GetExportLink";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (API_KEY) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<ExportLink>("/export", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetExportLink", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get export link 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType"></param>
        /// <param name="exportOptions"></param>
        /// <param name="apiKey"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ExportLink</returns>
        public async System.Threading.Tasks.Task<ExportLink> GetExportLinkAsync(string exportType, ExportOptions exportOptions, string apiKey = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            mailslurp.Client.ApiResponse<ExportLink> localVarResponse = await GetExportLinkWithHttpInfoAsync(exportType, exportOptions, apiKey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get export link 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType"></param>
        /// <param name="exportOptions"></param>
        /// <param name="apiKey"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ExportLink)</returns>
        public async System.Threading.Tasks.Task<mailslurp.Client.ApiResponse<ExportLink>> GetExportLinkWithHttpInfoAsync(string exportType, ExportOptions exportOptions, string apiKey = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'exportType' is set
            if (exportType == null)
            {
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'exportType' when calling ExportControllerApi->GetExportLink");
            }

            // verify the required parameter 'exportOptions' is set
            if (exportOptions == null)
            {
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'exportOptions' when calling ExportControllerApi->GetExportLink");
            }


            mailslurp.Client.RequestOptions localVarRequestOptions = new mailslurp.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "*/*"
            };

            var localVarContentType = mailslurp.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = mailslurp.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "exportType", exportType));
            if (apiKey != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "apiKey", apiKey));
            }
            localVarRequestOptions.Data = exportOptions;

            localVarRequestOptions.Operation = "ExportControllerApi.GetExportLink";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (API_KEY) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<ExportLink>("/export", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetExportLink", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
