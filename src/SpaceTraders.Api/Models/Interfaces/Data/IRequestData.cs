namespace SpaceTraders.Api.Models.Interfaces.Data;

public interface IRequestData<T>
{
    bool HasError => Error is not null;

    T? Data { get; set; }

    IError? Error { get; set; }

    IMeta? Meta { get; set; }
}