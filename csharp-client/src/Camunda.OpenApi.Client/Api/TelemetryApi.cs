/*
 * Camunda Platform REST API
 *
 * OpenApi Spec for Camunda Platform REST API.
 *
 * The version of the OpenAPI document: 7.17.0
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
    public interface ITelemetryApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Configure Telemetry
        /// </summary>
        /// <remarks>
        /// Configures whether Camunda receives data collection of the process engine setup and usage.
        /// </remarks>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telemetryConfigurationDto"> (optional)</param>
        /// <returns></returns>
        void ConfigureTelemetry(TelemetryConfigurationDto telemetryConfigurationDto = default(TelemetryConfigurationDto));

        /// <summary>
        /// Configure Telemetry
        /// </summary>
        /// <remarks>
        /// Configures whether Camunda receives data collection of the process engine setup and usage.
        /// </remarks>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telemetryConfigurationDto"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ConfigureTelemetryWithHttpInfo(TelemetryConfigurationDto telemetryConfigurationDto = default(TelemetryConfigurationDto));
        /// <summary>
        /// Fetch Telemetry Configuration
        /// </summary>
        /// <remarks>
        /// Fetches Telemetry Configuration.
        /// </remarks>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TelemetryConfigurationDto</returns>
        TelemetryConfigurationDto GetTelemetryConfiguration();

        /// <summary>
        /// Fetch Telemetry Configuration
        /// </summary>
        /// <remarks>
        /// Fetches Telemetry Configuration.
        /// </remarks>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TelemetryConfigurationDto</returns>
        ApiResponse<TelemetryConfigurationDto> GetTelemetryConfigurationWithHttpInfo();
        /// <summary>
        /// Fetch Telemetry Data
        /// </summary>
        /// <remarks>
        /// Fetches Telemetry Data.
        /// </remarks>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TelemetryDataDto</returns>
        TelemetryDataDto GetTelemetryData();

        /// <summary>
        /// Fetch Telemetry Data
        /// </summary>
        /// <remarks>
        /// Fetches Telemetry Data.
        /// </remarks>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TelemetryDataDto</returns>
        ApiResponse<TelemetryDataDto> GetTelemetryDataWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITelemetryApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Configure Telemetry
        /// </summary>
        /// <remarks>
        /// Configures whether Camunda receives data collection of the process engine setup and usage.
        /// </remarks>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telemetryConfigurationDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ConfigureTelemetryAsync(TelemetryConfigurationDto telemetryConfigurationDto = default(TelemetryConfigurationDto), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Configure Telemetry
        /// </summary>
        /// <remarks>
        /// Configures whether Camunda receives data collection of the process engine setup and usage.
        /// </remarks>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telemetryConfigurationDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConfigureTelemetryWithHttpInfoAsync(TelemetryConfigurationDto telemetryConfigurationDto = default(TelemetryConfigurationDto), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Fetch Telemetry Configuration
        /// </summary>
        /// <remarks>
        /// Fetches Telemetry Configuration.
        /// </remarks>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TelemetryConfigurationDto</returns>
        System.Threading.Tasks.Task<TelemetryConfigurationDto> GetTelemetryConfigurationAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Fetch Telemetry Configuration
        /// </summary>
        /// <remarks>
        /// Fetches Telemetry Configuration.
        /// </remarks>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TelemetryConfigurationDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelemetryConfigurationDto>> GetTelemetryConfigurationWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Fetch Telemetry Data
        /// </summary>
        /// <remarks>
        /// Fetches Telemetry Data.
        /// </remarks>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TelemetryDataDto</returns>
        System.Threading.Tasks.Task<TelemetryDataDto> GetTelemetryDataAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Fetch Telemetry Data
        /// </summary>
        /// <remarks>
        /// Fetches Telemetry Data.
        /// </remarks>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TelemetryDataDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelemetryDataDto>> GetTelemetryDataWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITelemetryApi : ITelemetryApiSync, ITelemetryApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TelemetryApi : IDisposable, ITelemetryApi
    {
        private Camunda.OpenApi.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryApi"/> class.
        /// **IMPORTANT** This will also create an istance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHander</see>.
        /// </summary>
        /// <returns></returns>
        public TelemetryApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryApi"/> class.
        /// **IMPORTANT** This will also create an istance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHander</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public TelemetryApi(string basePath)
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
        /// Initializes a new instance of the <see cref="TelemetryApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an istance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHander</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public TelemetryApi(Camunda.OpenApi.Client.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="TelemetryApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public TelemetryApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryApi"/> class.
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
        public TelemetryApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="TelemetryApi"/> class using Configuration object.
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
        public TelemetryApi(HttpClient client, Camunda.OpenApi.Client.Client.Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="TelemetryApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public TelemetryApi(Camunda.OpenApi.Client.Client.ISynchronousClient client, Camunda.OpenApi.Client.Client.IAsynchronousClient asyncClient, Camunda.OpenApi.Client.Client.IReadableConfiguration configuration)
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
        /// Configure Telemetry Configures whether Camunda receives data collection of the process engine setup and usage.
        /// </summary>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telemetryConfigurationDto"> (optional)</param>
        /// <returns></returns>
        public void ConfigureTelemetry(TelemetryConfigurationDto telemetryConfigurationDto = default(TelemetryConfigurationDto))
        {
            ConfigureTelemetryWithHttpInfo(telemetryConfigurationDto);
        }

        /// <summary>
        /// Configure Telemetry Configures whether Camunda receives data collection of the process engine setup and usage.
        /// </summary>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telemetryConfigurationDto"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Camunda.OpenApi.Client.Client.ApiResponse<Object> ConfigureTelemetryWithHttpInfo(TelemetryConfigurationDto telemetryConfigurationDto = default(TelemetryConfigurationDto))
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

            localVarRequestOptions.Data = telemetryConfigurationDto;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/telemetry/configuration", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConfigureTelemetry", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Configure Telemetry Configures whether Camunda receives data collection of the process engine setup and usage.
        /// </summary>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telemetryConfigurationDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ConfigureTelemetryAsync(TelemetryConfigurationDto telemetryConfigurationDto = default(TelemetryConfigurationDto), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ConfigureTelemetryWithHttpInfoAsync(telemetryConfigurationDto, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Configure Telemetry Configures whether Camunda receives data collection of the process engine setup and usage.
        /// </summary>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telemetryConfigurationDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Camunda.OpenApi.Client.Client.ApiResponse<Object>> ConfigureTelemetryWithHttpInfoAsync(TelemetryConfigurationDto telemetryConfigurationDto = default(TelemetryConfigurationDto), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Data = telemetryConfigurationDto;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/telemetry/configuration", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConfigureTelemetry", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Fetch Telemetry Configuration Fetches Telemetry Configuration.
        /// </summary>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TelemetryConfigurationDto</returns>
        public TelemetryConfigurationDto GetTelemetryConfiguration()
        {
            Camunda.OpenApi.Client.Client.ApiResponse<TelemetryConfigurationDto> localVarResponse = GetTelemetryConfigurationWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch Telemetry Configuration Fetches Telemetry Configuration.
        /// </summary>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TelemetryConfigurationDto</returns>
        public Camunda.OpenApi.Client.Client.ApiResponse<TelemetryConfigurationDto> GetTelemetryConfigurationWithHttpInfo()
        {
            Camunda.OpenApi.Client.Client.RequestOptions localVarRequestOptions = new Camunda.OpenApi.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Camunda.OpenApi.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Camunda.OpenApi.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = this.Client.Get<TelemetryConfigurationDto>("/telemetry/configuration", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTelemetryConfiguration", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Fetch Telemetry Configuration Fetches Telemetry Configuration.
        /// </summary>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TelemetryConfigurationDto</returns>
        public async System.Threading.Tasks.Task<TelemetryConfigurationDto> GetTelemetryConfigurationAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Camunda.OpenApi.Client.Client.ApiResponse<TelemetryConfigurationDto> localVarResponse = await GetTelemetryConfigurationWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch Telemetry Configuration Fetches Telemetry Configuration.
        /// </summary>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TelemetryConfigurationDto)</returns>
        public async System.Threading.Tasks.Task<Camunda.OpenApi.Client.Client.ApiResponse<TelemetryConfigurationDto>> GetTelemetryConfigurationWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Camunda.OpenApi.Client.Client.RequestOptions localVarRequestOptions = new Camunda.OpenApi.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Camunda.OpenApi.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Camunda.OpenApi.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<TelemetryConfigurationDto>("/telemetry/configuration", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTelemetryConfiguration", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Fetch Telemetry Data Fetches Telemetry Data.
        /// </summary>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TelemetryDataDto</returns>
        public TelemetryDataDto GetTelemetryData()
        {
            Camunda.OpenApi.Client.Client.ApiResponse<TelemetryDataDto> localVarResponse = GetTelemetryDataWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch Telemetry Data Fetches Telemetry Data.
        /// </summary>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TelemetryDataDto</returns>
        public Camunda.OpenApi.Client.Client.ApiResponse<TelemetryDataDto> GetTelemetryDataWithHttpInfo()
        {
            Camunda.OpenApi.Client.Client.RequestOptions localVarRequestOptions = new Camunda.OpenApi.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Camunda.OpenApi.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Camunda.OpenApi.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = this.Client.Get<TelemetryDataDto>("/telemetry/data", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTelemetryData", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Fetch Telemetry Data Fetches Telemetry Data.
        /// </summary>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TelemetryDataDto</returns>
        public async System.Threading.Tasks.Task<TelemetryDataDto> GetTelemetryDataAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Camunda.OpenApi.Client.Client.ApiResponse<TelemetryDataDto> localVarResponse = await GetTelemetryDataWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch Telemetry Data Fetches Telemetry Data.
        /// </summary>
        /// <exception cref="Camunda.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TelemetryDataDto)</returns>
        public async System.Threading.Tasks.Task<Camunda.OpenApi.Client.Client.ApiResponse<TelemetryDataDto>> GetTelemetryDataWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Camunda.OpenApi.Client.Client.RequestOptions localVarRequestOptions = new Camunda.OpenApi.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Camunda.OpenApi.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Camunda.OpenApi.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<TelemetryDataDto>("/telemetry/data", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTelemetryData", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
