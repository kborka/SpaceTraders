namespace SpaceTraders.Core.Interfaces.Data;

public interface IError
{
    string Message { get; set; }

    int Code { get; set; }

    IErrorData Data { get; set; }
}
