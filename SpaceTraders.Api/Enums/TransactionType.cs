using System.Runtime.Serialization;

namespace SpaceTraders.Api.Enums;

public enum TransactionType
{
    [EnumMember(Value = "PURCHASE")] Purchase,
    [EnumMember(Value = "SELL")] Sell
}