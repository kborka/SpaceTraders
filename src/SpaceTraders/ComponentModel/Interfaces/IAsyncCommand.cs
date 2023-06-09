﻿using System.Threading.Tasks;
using System.Windows.Input;

namespace SpaceTraders.ComponentModel.Interfaces;

public interface IAsyncCommand : ICommand
{
    Task ExecuteAsync();
    bool CanExecute();

    void RaiseCanExecuteChanged();
}