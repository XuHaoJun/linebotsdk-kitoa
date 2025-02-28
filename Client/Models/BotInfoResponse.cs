// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaPosts.Client.Models
{
    #pragma warning disable CS1591
    public class BotInfoResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Bot&apos;s basic ID</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BasicId { get; set; }
#nullable restore
#else
        public string BasicId { get; set; }
#endif
        /// <summary>Chat settings set in the LINE Official Account Manager. One of:`chat`: Chat is set to &quot;On&quot;.`bot`: Chat is set to &quot;Off&quot;.</summary>
        public KiotaPosts.Client.Models.BotInfoResponse_chatMode? ChatMode { get; set; }
        /// <summary>Bot&apos;s display name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Automatic read setting for messages. If the chat is set to &quot;Off&quot;, auto is returned. If the chat is set to &quot;On&quot;, manual is returned.`auto`: Auto read setting is enabled.`manual`: Auto read setting is disabled.</summary>
        public KiotaPosts.Client.Models.BotInfoResponse_markAsReadMode? MarkAsReadMode { get; set; }
        /// <summary>Profile image URL. `https` image URL. Not included in the response if the bot doesn&apos;t have a profile image.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PictureUrl { get; set; }
#nullable restore
#else
        public string PictureUrl { get; set; }
#endif
        /// <summary>Bot&apos;s premium ID. Not included in the response if the premium ID isn&apos;t set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PremiumId { get; set; }
#nullable restore
#else
        public string PremiumId { get; set; }
#endif
        /// <summary>Bot&apos;s user ID</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Models.BotInfoResponse"/> and sets the default values.
        /// </summary>
        public BotInfoResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Models.BotInfoResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaPosts.Client.Models.BotInfoResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaPosts.Client.Models.BotInfoResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "basicId", n => { BasicId = n.GetStringValue(); } },
                { "chatMode", n => { ChatMode = n.GetEnumValue<KiotaPosts.Client.Models.BotInfoResponse_chatMode>(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "markAsReadMode", n => { MarkAsReadMode = n.GetEnumValue<KiotaPosts.Client.Models.BotInfoResponse_markAsReadMode>(); } },
                { "pictureUrl", n => { PictureUrl = n.GetStringValue(); } },
                { "premiumId", n => { PremiumId = n.GetStringValue(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("basicId", BasicId);
            writer.WriteEnumValue<KiotaPosts.Client.Models.BotInfoResponse_chatMode>("chatMode", ChatMode);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<KiotaPosts.Client.Models.BotInfoResponse_markAsReadMode>("markAsReadMode", MarkAsReadMode);
            writer.WriteStringValue("pictureUrl", PictureUrl);
            writer.WriteStringValue("premiumId", PremiumId);
            writer.WriteStringValue("userId", UserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
