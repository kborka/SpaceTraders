using System.Runtime.Serialization;

namespace SpaceTraders.Core.Enums;

public enum TransactionType
{
    [EnumMember(Value = "PURCHASE")] Purchase,
    [EnumMember(Value = "SELL")] Sell
}
