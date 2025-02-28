// <auto-generated/>
using KiotaPosts.Client.V2.Bot.Message.Aggregation.Info;
using KiotaPosts.Client.V2.Bot.Message.Aggregation.List;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace KiotaPosts.Client.V2.Bot.Message.Aggregation
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\bot\message\aggregation
    /// </summary>
    public class AggregationRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The info property</summary>
        public KiotaPosts.Client.V2.Bot.Message.Aggregation.Info.InfoRequestBuilder Info
        {
            get => new KiotaPosts.Client.V2.Bot.Message.Aggregation.Info.InfoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The list property</summary>
        public KiotaPosts.Client.V2.Bot.Message.Aggregation.List.ListRequestBuilder List
        {
            get => new KiotaPosts.Client.V2.Bot.Message.Aggregation.List.ListRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.V2.Bot.Message.Aggregation.AggregationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AggregationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/bot/message/aggregation", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.V2.Bot.Message.Aggregation.AggregationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AggregationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/bot/message/aggregation", rawUrl)
        {
        }
    }
}
