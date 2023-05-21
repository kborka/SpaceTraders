using System;

namespace SpaceTraders.ComponentModel.Interfaces;

public interface INotifyTaskCompletion
{
    bool IsCompleted { get; }

    bool IsCompletedSuccessfully { get; }

    bool IsCancelled { get; }

    bool IsFaulted { get; }

    AggregateException? Exception { get; }

    Exception? InnerException { get; }

    string? ErrorMessage { get; }
}