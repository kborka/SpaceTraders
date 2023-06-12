using System;

namespace SpaceTraders.Interfaces;

/// <summary>
/// Class for handling errors in code.
/// </summary>
/// <remarks>
/// Code taken from https://github.com/johnthiriet/AsyncVoid/
/// </remarks>
public interface IErrorHandler
{
    void HandleError(Exception ex);
}