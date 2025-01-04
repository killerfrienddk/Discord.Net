using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IGatewayMessage : 
    IEquatable<Discord.Models.IGatewayMessage>
{
    new bool Equals(Discord.Models.IGatewayMessage? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<Discord.Models.GatewayOpCode>.Default.Equals(this.OpCode, other.OpCode) &&
            EqualityComparer<Discord.Models.IGatewayPayloadData?>.Default.Equals(this.Payload, other.Payload) &&
            EqualityComparer<int?>.Default.Equals(this.Sequence, other.Sequence) &&
            EqualityComparer<string?>.Default.Equals(this.EventName, other.EventName);
    }
    

    bool IEquatable<Discord.Models.IGatewayMessage>.Equals(Discord.Models.IGatewayMessage? other) => Equals(other);
}
