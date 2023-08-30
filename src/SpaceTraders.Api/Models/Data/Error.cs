using SpaceTraders.Core.Interfaces.Data;

namespace SpaceTraders.Api.Models.Data;

public class Error : IError
{
    public ErrorData Data { get; set; } = null!;
    public string Message { get; set; } = null!;

    public int Code { get; set; }

    IErrorData IError.Data
    {
        get => Data;
        set
        {
            if (value is not ErrorData data)
            {
                throw new InvalidCastException(
                                               "Invalid IErrorData type: Expected ErrorData");
            }

            Data = data;
        }
    }
}
