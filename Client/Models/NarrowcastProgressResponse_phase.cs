// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace KiotaPosts.Client.Models
{
    /// <summary>The current status. One of:`waiting`: Messages are not yet ready to be sent. They are currently being filtered or processed in some way.`sending`: Messages are currently being sent.`succeeded`: Messages were sent successfully. This may not mean the messages were successfully received.`failed`: Messages failed to be sent. Use the failedDescription property to find the cause of the failure.</summary>
    public enum NarrowcastProgressResponse_phase
    {
        [EnumMember(Value = "waiting")]
        #pragma warning disable CS1591
        Waiting,
        #pragma warning restore CS1591
        [EnumMember(Value = "sending")]
        #pragma warning disable CS1591
        Sending,
        #pragma warning restore CS1591
        [EnumMember(Value = "succeeded")]
        #pragma warning disable CS1591
        Succeeded,
        #pragma warning restore CS1591
        [EnumMember(Value = "failed")]
        #pragma warning disable CS1591
        Failed,
        #pragma warning restore CS1591
    }
}
