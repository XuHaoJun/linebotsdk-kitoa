// <auto-generated/>
using KiotaPosts.Client.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KiotaPosts.Client.V2.Bot.Message.Delivery.Ad_phone
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\bot\message\delivery\ad_phone
    /// </summary>
    public class Ad_phoneRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.V2.Bot.Message.Delivery.Ad_phone.Ad_phoneRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Ad_phoneRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/bot/message/delivery/ad_phone?date={date}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.V2.Bot.Message.Delivery.Ad_phone.Ad_phoneRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Ad_phoneRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/bot/message/delivery/ad_phone?date={date}", rawUrl)
        {
        }
        /// <summary>
        /// Get result of message delivery using phone number
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Models.NumberOfMessagesResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KiotaPosts.Client.Models.NumberOfMessagesResponse?> GetAsync(Action<RequestConfiguration<KiotaPosts.Client.V2.Bot.Message.Delivery.Ad_phone.Ad_phoneRequestBuilder.Ad_phoneRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KiotaPosts.Client.Models.NumberOfMessagesResponse> GetAsync(Action<RequestConfiguration<KiotaPosts.Client.V2.Bot.Message.Delivery.Ad_phone.Ad_phoneRequestBuilder.Ad_phoneRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<KiotaPosts.Client.Models.NumberOfMessagesResponse>(requestInfo, KiotaPosts.Client.Models.NumberOfMessagesResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get result of message delivery using phone number
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KiotaPosts.Client.V2.Bot.Message.Delivery.Ad_phone.Ad_phoneRequestBuilder.Ad_phoneRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KiotaPosts.Client.V2.Bot.Message.Delivery.Ad_phone.Ad_phoneRequestBuilder.Ad_phoneRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.V2.Bot.Message.Delivery.Ad_phone.Ad_phoneRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KiotaPosts.Client.V2.Bot.Message.Delivery.Ad_phone.Ad_phoneRequestBuilder WithUrl(string rawUrl)
        {
            return new KiotaPosts.Client.V2.Bot.Message.Delivery.Ad_phone.Ad_phoneRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get result of message delivery using phone number
        /// </summary>
        public class Ad_phoneRequestBuilderGetQueryParameters 
        {
            /// <summary>Date the message was sentFormat: `yyyyMMdd` (e.g. `20190831`)Time Zone: UTC+9</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("date")]
            public string? Date { get; set; }
#nullable restore
#else
            [QueryParameter("date")]
            public string Date { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class Ad_phoneRequestBuilderGetRequestConfiguration : RequestConfiguration<KiotaPosts.Client.V2.Bot.Message.Delivery.Ad_phone.Ad_phoneRequestBuilder.Ad_phoneRequestBuilderGetQueryParameters>
        {
        }
    }
}
