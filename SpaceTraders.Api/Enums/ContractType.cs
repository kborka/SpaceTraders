using System.Runtime.Serialization;

namespace SpaceTraders.Api.Enums;

public enum ContractType
{
    [EnumMember(Value = "PROCUREMENT")] Procurement,
    [EnumMember(Value = "TRANSPORT")] Transport,
    [EnumMember(Value = "SHUTTLE")] Shuttle
}