/*
 * Camunda BPM REST API
 *
 * OpenApi Spec for Camunda BPM REST API.
 *
 * The version of the OpenAPI document: 7.14.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using CamundaClient.Client;
using CamundaClient.Model;

namespace CamundaClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISignalApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// A signal is an event of global scope (broadcast semantics) and is delivered to all active handlers. Internally this maps to the engine&#39;s signal event received builder method &#x60;RuntimeService#createSignalEvent()&#x60;. For more information about the signal behavior, see the [Signal Events](https://docs.camunda.org/manual/7.14/reference/bpmn20/events/signal-events/) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.14/reference/bpmn20/).
        /// </remarks>
        /// <exception cref="CamundaClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signalDto"> (optional)</param>
        /// <returns></returns>
        void ThrowSignal(SignalDto signalDto = default(SignalDto));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// A signal is an event of global scope (broadcast semantics) and is delivered to all active handlers. Internally this maps to the engine&#39;s signal event received builder method &#x60;RuntimeService#createSignalEvent()&#x60;. For more information about the signal behavior, see the [Signal Events](https://docs.camunda.org/manual/7.14/reference/bpmn20/events/signal-events/) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.14/reference/bpmn20/).
        /// </remarks>
        /// <exception cref="CamundaClient.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// 
        /// </summary>
        /// <remarks>
        /// A signal is an event of global scope (broadcast semantics) and is delivered to all active handlers. Internally this maps to the engine&#39;s signal event received builder method &#x60;RuntimeService#createSignalEvent()&#x60;. For more information about the signal behavior, see the [Signal Events](https://docs.camunda.org/manual/7.14/reference/bpmn20/events/signal-events/) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.14/reference/bpmn20/).
        /// </remarks>
        /// <exception cref="CamundaClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signalDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ThrowSignalAsync(SignalDto signalDto = default(SignalDto), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// A signal is an event of global scope (broadcast semantics) and is delivered to all active handlers. Internally this maps to the engine&#39;s signal event received builder method &#x60;RuntimeService#createSignalEvent()&#x60;. For more information about the signal behavior, see the [Signal Events](https://docs.camunda.org/manual/7.14/reference/bpmn20/events/signal-events/) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.14/reference/bpmn20/).
        /// </remarks>
        /// <exception cref="CamundaClient.Client.ApiException">Thrown when fails to make API call</exception>
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
    public partial class SignalApi : ISignalApi
    {
        private CamundaClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SignalApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SignalApi(String basePath)
        {
            this.Configuration = CamundaClient.Client.Configuration.MergeConfigurations(
                CamundaClient.Client.GlobalConfiguration.Instance,
                new CamundaClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new CamundaClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new CamundaClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = CamundaClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SignalApi(CamundaClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = CamundaClient.Client.Configuration.MergeConfigurations(
                CamundaClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new CamundaClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new CamundaClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = CamundaClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SignalApi(CamundaClient.Client.ISynchronousClient client, CamundaClient.Client.IAsynchronousClient asyncClient, CamundaClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = CamundaClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public CamundaClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public CamundaClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public CamundaClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CamundaClient.Client.ExceptionFactory ExceptionFactory
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
        ///  A signal is an event of global scope (broadcast semantics) and is delivered to all active handlers. Internally this maps to the engine&#39;s signal event received builder method &#x60;RuntimeService#createSignalEvent()&#x60;. For more information about the signal behavior, see the [Signal Events](https://docs.camunda.org/manual/7.14/reference/bpmn20/events/signal-events/) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.14/reference/bpmn20/).
        /// </summary>
        /// <exception cref="CamundaClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signalDto"> (optional)</param>
        /// <returns></returns>
        public void ThrowSignal(SignalDto signalDto = default(SignalDto))
        {
            ThrowSignalWithHttpInfo(signalDto);
        }

        /// <summary>
        ///  A signal is an event of global scope (broadcast semantics) and is delivered to all active handlers. Internally this maps to the engine&#39;s signal event received builder method &#x60;RuntimeService#createSignalEvent()&#x60;. For more information about the signal behavior, see the [Signal Events](https://docs.camunda.org/manual/7.14/reference/bpmn20/events/signal-events/) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.14/reference/bpmn20/).
        /// </summary>
        /// <exception cref="CamundaClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signalDto"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public CamundaClient.Client.ApiResponse<Object> ThrowSignalWithHttpInfo(SignalDto signalDto = default(SignalDto))
        {
            CamundaClient.Client.RequestOptions localVarRequestOptions = new CamundaClient.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = CamundaClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = CamundaClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
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
        ///  A signal is an event of global scope (broadcast semantics) and is delivered to all active handlers. Internally this maps to the engine&#39;s signal event received builder method &#x60;RuntimeService#createSignalEvent()&#x60;. For more information about the signal behavior, see the [Signal Events](https://docs.camunda.org/manual/7.14/reference/bpmn20/events/signal-events/) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.14/reference/bpmn20/).
        /// </summary>
        /// <exception cref="CamundaClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signalDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ThrowSignalAsync(SignalDto signalDto = default(SignalDto), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ThrowSignalWithHttpInfoAsync(signalDto, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        ///  A signal is an event of global scope (broadcast semantics) and is delivered to all active handlers. Internally this maps to the engine&#39;s signal event received builder method &#x60;RuntimeService#createSignalEvent()&#x60;. For more information about the signal behavior, see the [Signal Events](https://docs.camunda.org/manual/7.14/reference/bpmn20/events/signal-events/) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.14/reference/bpmn20/).
        /// </summary>
        /// <exception cref="CamundaClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signalDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<CamundaClient.Client.ApiResponse<Object>> ThrowSignalWithHttpInfoAsync(SignalDto signalDto = default(SignalDto), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            CamundaClient.Client.RequestOptions localVarRequestOptions = new CamundaClient.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = CamundaClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = CamundaClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
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
