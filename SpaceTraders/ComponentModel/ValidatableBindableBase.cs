using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Prism.Mvvm;

namespace SpaceTraders.ComponentModel;

public abstract class ValidatableBindableBase : BindableBase, INotifyDataErrorInfo, IDataErrorInfo
{
    private readonly Dictionary<string, List<string>> _errors = new();

    public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

    public bool HasErrors => _errors.Any();

    public IEnumerable GetErrors(string? propertyName)
    {
        if (propertyName is null) return new List<string>();

        return _errors.TryGetValue(propertyName, out var error) ? error : new List<string>();
    }

    protected void ClearErrors() => _errors.Clear();

    protected void ClearErrors(string propertyName) => _errors.Remove(propertyName);

    protected void AddError(string propertyName, string errorString)
    {
        if (!_errors.ContainsKey(propertyName))
        {
            _errors.Add(propertyName, new List<string>());
        }

        _errors[propertyName].Add(errorString);
        ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
    }

    public string Error => _errors.FirstOrDefault().Value.FirstOrDefault() ?? string.Empty;

    public string this[string columnName]
    {
        get
        {
            _errors.TryGetValue(columnName, out var error);
            return error?.FirstOrDefault() ?? string.Empty;
        }
    }
}