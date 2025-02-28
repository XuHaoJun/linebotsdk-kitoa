// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaPosts.Client.Models
{
    #pragma warning disable CS1591
    public class FlexVideo : KiotaPosts.Client.Models.FlexComponent, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Action</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KiotaPosts.Client.Models.ActionObject? Action { get; set; }
#nullable restore
#else
        public KiotaPosts.Client.Models.ActionObject Action { get; set; }
#endif
        /// <summary>The altContent property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KiotaPosts.Client.Models.FlexComponent? AltContent { get; set; }
#nullable restore
#else
        public KiotaPosts.Client.Models.FlexComponent AltContent { get; set; }
#endif
        /// <summary>The aspectRatio property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AspectRatio { get; set; }
#nullable restore
#else
        public string AspectRatio { get; set; }
#endif
        /// <summary>The previewUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreviewUrl { get; set; }
#nullable restore
#else
        public string PreviewUrl { get; set; }
#endif
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Models.FlexVideo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new KiotaPosts.Client.Models.FlexVideo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaPosts.Client.Models.FlexVideo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "action", n => { Action = n.GetObjectValue<KiotaPosts.Client.Models.ActionObject>(KiotaPosts.Client.Models.ActionObject.CreateFromDiscriminatorValue); } },
                { "altContent", n => { AltContent = n.GetObjectValue<KiotaPosts.Client.Models.FlexComponent>(KiotaPosts.Client.Models.FlexComponent.CreateFromDiscriminatorValue); } },
                { "aspectRatio", n => { AspectRatio = n.GetStringValue(); } },
                { "previewUrl", n => { PreviewUrl = n.GetStringValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<KiotaPosts.Client.Models.ActionObject>("action", Action);
            writer.WriteObjectValue<KiotaPosts.Client.Models.FlexComponent>("altContent", AltContent);
            writer.WriteStringValue("aspectRatio", AspectRatio);
            writer.WriteStringValue("previewUrl", PreviewUrl);
            writer.WriteStringValue("url", Url);
        }
    }
}
