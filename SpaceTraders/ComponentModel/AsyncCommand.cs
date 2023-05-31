using System;
using System.Threading.Tasks;
using System.Windows.Input;
using SpaceTraders.ComponentModel.Interfaces;
using SpaceTraders.Interfaces;
using SpaceTraders.Utilities;

namespace SpaceTraders.ComponentModel;

/// <summary>
/// Implementation of the IAsyncCommand interface.
/// Fires commands asynchronously.
/// </summary>
/// <remarks>
/// Code taken from https://github.com/johnthiriet/AsyncVoid/
/// </remarks>
public class AsyncCommand : IAsyncCommand
{
   private bool _isExecuting;
   private readonly Func<Task> _execute;
   private readonly Func<bool>? _canExecute;
   private readonly IErrorHandler? _errorHandler;

   public bool CanExecute(object? parameter)
   {
      return CanExecute();
   }

   public void Execute(object? parameter)
   {
      ExecuteAsync().FireAndForgetSafeAsync(_errorHandler);
   }

   event EventHandler? ICommand.CanExecuteChanged
   {
      add => CanExecuteChanged += value;
      remove => CanExecuteChanged -= value;
   }

   public AsyncCommand(Func<Task> execute, Func<bool>? canExecute = null, IErrorHandler? errorHandler = null)
   {
      _execute = execute;
      _canExecute = canExecute;
      _errorHandler = errorHandler;
   }

   public event EventHandler? CanExecuteChanged;
   public async Task ExecuteAsync()
   {
      if (CanExecute())
      {
         try
         {
            _isExecuting = true;
            await _execute();
         }
         finally
         {
            _isExecuting = false;
         }
      }

      RaiseCanExecuteChanged();
   }

   public bool CanExecute()
   {
      return !_isExecuting && (_canExecute?.Invoke() ?? true);
   }

   public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
}