/*
 * Camunda Platform REST API
 *
 * OpenApi Spec for Camunda Platform REST API.
 *
 * The version of the OpenAPI document: 7.21.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Camunda.OpenApi.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConditionApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Evaluate
        /// </summary>
        /// <remarks>
        /// Triggers evaluation of conditions for conditional start event(s).  Internally this maps to the engines condition evaluation builder method ConditionEvaluationBuilder#evaluateStartConditions().  For more information see the [Conditional Start Events](https://docs.camunda.org/manual/7.21/reference/bpmn20/events/conditional-events/#conditional-start-event) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.21/reference/bpmn20/).
        /// </remarks>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evaluationConditionDto"> (optional)</param>
        /// <returns>List&lt;ProcessInstanceDto&gt;</returns>
        List<ProcessInstanceDto> EvaluateCondition(EvaluationConditionDto evaluationConditionDto = default(EvaluationConditionDto));

        /// <summary>
        /// Evaluate
        /// </summary>
        /// <remarks>
        /// Triggers evaluation of conditions for conditional start event(s).  Internally this maps to the engines condition evaluation builder method ConditionEvaluationBuilder#evaluateStartConditions().  For more information see the [Conditional Start Events](https://docs.camunda.org/manual/7.21/reference/bpmn20/events/conditional-events/#conditional-start-event) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.21/reference/bpmn20/).
        /// </remarks>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evaluationConditionDto"> (optional)</param>
        /// <returns>ApiResponse of List&lt;ProcessInstanceDto&gt;</returns>
        ApiResponse<List<ProcessInstanceDto>> EvaluateConditionWithHttpInfo(EvaluationConditionDto evaluationConditionDto = default(EvaluationConditionDto));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConditionApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Evaluate
        /// </summary>
        /// <remarks>
        /// Triggers evaluation of conditions for conditional start event(s).  Internally this maps to the engines condition evaluation builder method ConditionEvaluationBuilder#evaluateStartConditions().  For more information see the [Conditional Start Events](https://docs.camunda.org/manual/7.21/reference/bpmn20/events/conditional-events/#conditional-start-event) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.21/reference/bpmn20/).
        /// </remarks>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evaluationConditionDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ProcessInstanceDto&gt;</returns>
        System.Threading.Tasks.Task<List<ProcessInstanceDto>> EvaluateConditionAsync(EvaluationConditionDto evaluationConditionDto = default(EvaluationConditionDto), System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Evaluate
        /// </summary>
        /// <remarks>
        /// Triggers evaluation of conditions for conditional start event(s).  Internally this maps to the engines condition evaluation builder method ConditionEvaluationBuilder#evaluateStartConditions().  For more information see the [Conditional Start Events](https://docs.camunda.org/manual/7.21/reference/bpmn20/events/conditional-events/#conditional-start-event) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.21/reference/bpmn20/).
        /// </remarks>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evaluationConditionDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ProcessInstanceDto&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ProcessInstanceDto>>> EvaluateConditionWithHttpInfoAsync(EvaluationConditionDto evaluationConditionDto = default(EvaluationConditionDto), System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConditionApi : IConditionApiSync, IConditionApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ConditionApi : IDisposable, IConditionApi
    {
        private Camunda.OpenApi.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public ConditionApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public ConditionApi(string basePath)
        {
            this.Configuration = Camunda.OpenApi.Client.Client.Configuration.MergeConfigurations(
                Camunda.OpenApi.Client.Client.GlobalConfiguration.Instance,
                new Camunda.OpenApi.Client.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new Camunda.OpenApi.Client.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Camunda.OpenApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public ConditionApi(Camunda.OpenApi.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Camunda.OpenApi.Client.Client.Configuration.MergeConfigurations(
                Camunda.OpenApi.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new Camunda.OpenApi.Client.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Camunda.OpenApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ConditionApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ConditionApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = Camunda.OpenApi.Client.Client.Configuration.MergeConfigurations(
                Camunda.OpenApi.Client.Client.GlobalConfiguration.Instance,
                new Camunda.OpenApi.Client.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new Camunda.OpenApi.Client.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Camunda.OpenApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionApi"/> class using Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ConditionApi(HttpClient client, Camunda.OpenApi.Client.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = Camunda.OpenApi.Client.Client.Configuration.MergeConfigurations(
                Camunda.OpenApi.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new Camunda.OpenApi.Client.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Camunda.OpenApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ConditionApi(Camunda.OpenApi.Client.Client.ISynchronousClient client, Camunda.OpenApi.Client.Client.IAsynchronousClient asyncClient, Camunda.OpenApi.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Camunda.OpenApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public Camunda.OpenApi.Client.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Camunda.OpenApi.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Camunda.OpenApi.Client.Client.ISynchronousClient Client { get; set; }

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
        public Camunda.OpenApi.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Camunda.OpenApi.Client.Client.ExceptionFactory ExceptionFactory
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
        /// Evaluate Triggers evaluation of conditions for conditional start event(s).  Internally this maps to the engines condition evaluation builder method ConditionEvaluationBuilder#evaluateStartConditions().  For more information see the [Conditional Start Events](https://docs.camunda.org/manual/7.21/reference/bpmn20/events/conditional-events/#conditional-start-event) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.21/reference/bpmn20/).
        /// </summary>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evaluationConditionDto"> (optional)</param>
        /// <returns>List&lt;ProcessInstanceDto&gt;</returns>
        public List<ProcessInstanceDto> EvaluateCondition(EvaluationConditionDto evaluationConditionDto = default(EvaluationConditionDto))
        {
            Camunda.OpenApi.Client.Client.ApiResponse<List<ProcessInstanceDto>> localVarResponse = EvaluateConditionWithHttpInfo(evaluationConditionDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Evaluate Triggers evaluation of conditions for conditional start event(s).  Internally this maps to the engines condition evaluation builder method ConditionEvaluationBuilder#evaluateStartConditions().  For more information see the [Conditional Start Events](https://docs.camunda.org/manual/7.21/reference/bpmn20/events/conditional-events/#conditional-start-event) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.21/reference/bpmn20/).
        /// </summary>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evaluationConditionDto"> (optional)</param>
        /// <returns>ApiResponse of List&lt;ProcessInstanceDto&gt;</returns>
        public Camunda.OpenApi.Client.Client.ApiResponse<List<ProcessInstanceDto>> EvaluateConditionWithHttpInfo(EvaluationConditionDto evaluationConditionDto = default(EvaluationConditionDto))
        {
            Camunda.OpenApi.Client.Client.RequestOptions localVarRequestOptions = new Camunda.OpenApi.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Camunda.OpenApi.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Camunda.OpenApi.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = evaluationConditionDto;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Camunda.OpenApi.Client.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<List<ProcessInstanceDto>>("/condition", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EvaluateCondition", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Evaluate Triggers evaluation of conditions for conditional start event(s).  Internally this maps to the engines condition evaluation builder method ConditionEvaluationBuilder#evaluateStartConditions().  For more information see the [Conditional Start Events](https://docs.camunda.org/manual/7.21/reference/bpmn20/events/conditional-events/#conditional-start-event) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.21/reference/bpmn20/).
        /// </summary>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evaluationConditionDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ProcessInstanceDto&gt;</returns>
        public async System.Threading.Tasks.Task<List<ProcessInstanceDto>> EvaluateConditionAsync(EvaluationConditionDto evaluationConditionDto = default(EvaluationConditionDto), System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            Camunda.OpenApi.Client.Client.ApiResponse<List<ProcessInstanceDto>> localVarResponse = await EvaluateConditionWithHttpInfoAsync(evaluationConditionDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Evaluate Triggers evaluation of conditions for conditional start event(s).  Internally this maps to the engines condition evaluation builder method ConditionEvaluationBuilder#evaluateStartConditions().  For more information see the [Conditional Start Events](https://docs.camunda.org/manual/7.21/reference/bpmn20/events/conditional-events/#conditional-start-event) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.21/reference/bpmn20/).
        /// </summary>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evaluationConditionDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ProcessInstanceDto&gt;)</returns>
        public async System.Threading.Tasks.Task<Camunda.OpenApi.Client.Client.ApiResponse<List<ProcessInstanceDto>>> EvaluateConditionWithHttpInfoAsync(EvaluationConditionDto evaluationConditionDto = default(EvaluationConditionDto), System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            Camunda.OpenApi.Client.Client.RequestOptions localVarRequestOptions = new Camunda.OpenApi.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Camunda.OpenApi.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Camunda.OpenApi.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = evaluationConditionDto;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Camunda.OpenApi.Client.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<List<ProcessInstanceDto>>("/condition", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EvaluateCondition", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
