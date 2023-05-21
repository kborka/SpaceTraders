using System;
using System.ComponentModel;
using System.Threading.Tasks;
using SpaceTraders.ComponentModel.Interfaces;

namespace SpaceTraders.ComponentModel;

/// <summary>
/// Runs asynchronous tasks and notifies when they have completed. Used for async bindings.
/// </summary>
/// <typeparam name="TResult">
/// The return type of the task object.
/// </typeparam>
/// <remarks>
/// Code taken from Microsoft Magazine March 2014 Volume 29 Number 3
/// https://learn.microsoft.com/en-us/archive/msdn-magazine/2014/march/async-programming-patterns-for-asynchronous-mvvm-applications-data-binding
/// </remarks>
public sealed class NotifyTaskCompletion<TResult> : INotifyTaskCompletion, INotifyPropertyChanged
{
    private readonly Task<TResult> _task;
    public NotifyTaskCompletion(Task<TResult> task)
    {
        _task = task;
        if (!task.IsCompleted)
        {
            var _ = WatchTaskAsync(task);
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public TResult? Result => _task.Status == TaskStatus.RanToCompletion ? _task.Result : default;

    public TaskStatus Status => _task.Status;

    public bool IsCompleted => _task.IsCompleted;

    public bool IsCompletedSuccessfully => _task.IsCompletedSuccessfully;

    public bool IsCancelled => _task.IsCanceled;

    public bool IsFaulted => _task.IsFaulted;

    public AggregateException? Exception => _task.Exception;

    public Exception? InnerException => Exception?.InnerException;

    public string? ErrorMessage => InnerException?.Message;

    private async Task WatchTaskAsync(Task task)
    {
        try
        {
            await task;
        }
        catch
        {
            // ignored
        }

        var propertyChanged = PropertyChanged;
        if (propertyChanged is null) return;

        propertyChanged(this, new PropertyChangedEventArgs(nameof(Status)));
        propertyChanged(this, new PropertyChangedEventArgs(nameof(IsCompleted)));
        if (task.IsCanceled)
        {
            propertyChanged(this, new PropertyChangedEventArgs(nameof(IsCancelled)));
        }
        else if (task.IsFaulted)
        {
            propertyChanged(this, new PropertyChangedEventArgs(nameof(IsFaulted)));
            propertyChanged(this, new PropertyChangedEventArgs(nameof(Exception)));
            propertyChanged(this, new PropertyChangedEventArgs(nameof(InnerException)));
            propertyChanged(this, new PropertyChangedEventArgs(nameof(ErrorMessage)));
        }
        else
        {
            propertyChanged(this, new PropertyChangedEventArgs(nameof(IsCompletedSuccessfully)));
            propertyChanged(this, new PropertyChangedEventArgs(nameof(Result)));
        }
    }
}