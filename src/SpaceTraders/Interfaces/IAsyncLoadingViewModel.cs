using System;
using System.Windows.Input;

namespace SpaceTraders.Interfaces;

/// <summary>
/// An interface representing a viewmodel that initializes asynchronously after it's view has loaded.
/// </summary>
public interface IAsyncLoadingViewModel
{
    /// <summary>
    /// An event that fires when initialization has completed.
    /// </summary>
    event EventHandler? InitializationCompleted;

    /// <summary>
    /// Gets a command that fires async initialization logic.
    /// </summary>
    ICommand InitializeCommand { get; }

    /// <summary>
    /// Gets whether or not initialization data loaded.
    /// </summary>
    bool DataLoaded { get; }
}
