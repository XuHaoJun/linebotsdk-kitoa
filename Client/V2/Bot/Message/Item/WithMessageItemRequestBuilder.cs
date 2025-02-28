// <auto-generated/>
using KiotaPosts.Client.V2.Bot.Message.Item.Content;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace KiotaPosts.Client.V2.Bot.Message.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\bot\message\{messageId}
    /// </summary>
    public class WithMessageItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The content property</summary>
        public KiotaPosts.Client.V2.Bot.Message.Item.Content.ContentRequestBuilder Content
        {
            get => new KiotaPosts.Client.V2.Bot.Message.Item.Content.ContentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.V2.Bot.Message.Item.WithMessageItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithMessageItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/bot/message/{messageId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.V2.Bot.Message.Item.WithMessageItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithMessageItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/bot/message/{messageId}", rawUrl)
        {
        }
    }
}
