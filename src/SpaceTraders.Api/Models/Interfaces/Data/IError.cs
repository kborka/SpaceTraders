namespace SpaceTraders.Api.Models.Interfaces.Data;

public interface IError
{
    string Message { get; set; }

    int Code { get; set; }

    IErrorData Data { get; set; }
}