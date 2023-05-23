using SpaceTraders.Api.Models.Interfaces.Data;

namespace SpaceTraders.Api.Models.Data;

public class RequestData<T> : IRequestData<T>
{
    public bool HasError => Error is not null;

    public T? Data { get; set; }

    public IError? Error { get; set; }

    public IMeta? Meta { get; set; }
}