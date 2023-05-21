namespace SpaceTraders.Api.Models;

public class RequestData<T>
{
    public bool HasError => Error is not null;

    public T? Data { get; set; }

    public Error? Error { get; set; }
}