using SpaceTraders.Core.Interfaces.Data;

namespace SpaceTraders.Api.Models.Data;

public class RequestData<T> : IRequestData<T>
{
    public Error? Error { get; set; }

    public Meta? Meta { get; set; }
    public bool HasError => Error is not null;

    public T? Data { get; set; }

    IError? IRequestData<T>.Error
    {
        get => Error;
        set
        {
            if (value is not Error error)
            {
                throw new InvalidCastException("Invalid IError? type: Expected Error?");
            }

            Error = error;
        }
    }

    IMeta? IRequestData<T>.Meta
    {
        get => Meta;
        set
        {
            if (value is not Meta meta)
            {
                throw new InvalidCastException("Invalid IMeta? type: Expected Meta?");
            }

            Meta = meta;
        }
    }
}
