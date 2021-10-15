/*
 * Camunda Platform REST API
 *
 * OpenApi Spec for Camunda Platform REST API.
 *
 * The version of the OpenAPI document: 7.16.0
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
    public interface ISignalApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Event
        /// </summary>
        /// <remarks>
        /// A signal is an event of global scope (broadcast semantics) and is delivered to all active handlers. Internally this maps to the engine&#39;s signal event received builder method &#x60;RuntimeService#createSignalEvent()&#x60;. For more information about the signal behavior, see the [Signal Events](https://docs.camunda.org/manual/7.16/reference/bpmn20/events/signal-events/) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.16/reference/bpmn20/).
        /// </remarks>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signalDto"> (optional)</param>
        /// <returns></returns>
        void ThrowSignal(SignalDto signalDto = default(SignalDto));

        /// <summary>
        /// Event
        /// </summary>
        /// <remarks>
        /// A signal is an event of global scope (broadcast semantics) and is delivered to all active handlers. Internally this maps to the engine&#39;s signal event received builder method &#x60;RuntimeService#createSignalEvent()&#x60;. For more information about the signal behavior, see the [Signal Events](https://docs.camunda.org/manual/7.16/reference/bpmn20/events/signal-events/) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.16/reference/bpmn20/).
        /// </remarks>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signalDto"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ThrowSignalWithHttpInfo(SignalDto signalDto = default(SignalDto));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISignalApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Event
        /// </summary>
        /// <remarks>
        /// A signal is an event of global scope (broadcast semantics) and is delivered to all active handlers. Internally this maps to the engine&#39;s signal event received builder method &#x60;RuntimeService#createSignalEvent()&#x60;. For more information about the signal behavior, see the [Signal Events](https://docs.camunda.org/manual/7.16/reference/bpmn20/events/signal-events/) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.16/reference/bpmn20/).
        /// </remarks>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signalDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ThrowSignalAsync(SignalDto signalDto = default(SignalDto), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Event
        /// </summary>
        /// <remarks>
        /// A signal is an event of global scope (broadcast semantics) and is delivered to all active handlers. Internally this maps to the engine&#39;s signal event received builder method &#x60;RuntimeService#createSignalEvent()&#x60;. For more information about the signal behavior, see the [Signal Events](https://docs.camunda.org/manual/7.16/reference/bpmn20/events/signal-events/) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.16/reference/bpmn20/).
        /// </remarks>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signalDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ThrowSignalWithHttpInfoAsync(SignalDto signalDto = default(SignalDto), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISignalApi : ISignalApiSync, ISignalApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SignalApi : IDisposable, ISignalApi
    {
        private Camunda.OpenApi.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalApi"/> class.
        /// **IMPORTANT** This will also create an istance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHander</see>.
        /// </summary>
        /// <returns></returns>
        public SignalApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalApi"/> class.
        /// **IMPORTANT** This will also create an istance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHander</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public SignalApi(string basePath)
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
        /// Initializes a new instance of the <see cref="SignalApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an istance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHander</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public SignalApi(Camunda.OpenApi.Client.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="SignalApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public SignalApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalApi"/> class.
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
        public SignalApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="SignalApi"/> class using Configuration object.
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
        public SignalApi(HttpClient client, Camunda.OpenApi.Client.Client.Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="SignalApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SignalApi(Camunda.OpenApi.Client.Client.ISynchronousClient client, Camunda.OpenApi.Client.Client.IAsynchronousClient asyncClient, Camunda.OpenApi.Client.Client.IReadableConfiguration configuration)
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
        /// Event A signal is an event of global scope (broadcast semantics) and is delivered to all active handlers. Internally this maps to the engine&#39;s signal event received builder method &#x60;RuntimeService#createSignalEvent()&#x60;. For more information about the signal behavior, see the [Signal Events](https://docs.camunda.org/manual/7.16/reference/bpmn20/events/signal-events/) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.16/reference/bpmn20/).
        /// </summary>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signalDto"> (optional)</param>
        /// <returns></returns>
        public void ThrowSignal(SignalDto signalDto = default(SignalDto))
        {
            ThrowSignalWithHttpInfo(signalDto);
        }

        /// <summary>
        /// Event A signal is an event of global scope (broadcast semantics) and is delivered to all active handlers. Internally this maps to the engine&#39;s signal event received builder method &#x60;RuntimeService#createSignalEvent()&#x60;. For more information about the signal behavior, see the [Signal Events](https://docs.camunda.org/manual/7.16/reference/bpmn20/events/signal-events/) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.16/reference/bpmn20/).
        /// </summary>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signalDto"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Camunda.OpenApi.Client.Client.ApiResponse<Object> ThrowSignalWithHttpInfo(SignalDto signalDto = default(SignalDto))
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

            localVarRequestOptions.Data = signalDto;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/signal", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ThrowSignal", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Event A signal is an event of global scope (broadcast semantics) and is delivered to all active handlers. Internally this maps to the engine&#39;s signal event received builder method &#x60;RuntimeService#createSignalEvent()&#x60;. For more information about the signal behavior, see the [Signal Events](https://docs.camunda.org/manual/7.16/reference/bpmn20/events/signal-events/) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.16/reference/bpmn20/).
        /// </summary>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signalDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ThrowSignalAsync(SignalDto signalDto = default(SignalDto), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ThrowSignalWithHttpInfoAsync(signalDto, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Event A signal is an event of global scope (broadcast semantics) and is delivered to all active handlers. Internally this maps to the engine&#39;s signal event received builder method &#x60;RuntimeService#createSignalEvent()&#x60;. For more information about the signal behavior, see the [Signal Events](https://docs.camunda.org/manual/7.16/reference/bpmn20/events/signal-events/) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.16/reference/bpmn20/).
        /// </summary>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signalDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Camunda.OpenApi.Client.Client.ApiResponse<Object>> ThrowSignalWithHttpInfoAsync(SignalDto signalDto = default(SignalDto), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Data = signalDto;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/signal", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ThrowSignal", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
