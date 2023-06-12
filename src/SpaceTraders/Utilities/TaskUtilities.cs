using System;
using System.Threading.Tasks;
using SpaceTraders.Interfaces;

namespace SpaceTraders.Utilities;

public static class TaskUtilities
{
    public static async void FireAndForgetSafeAsync(this Task task, IErrorHandler? handler = null)
    {
        try
        {
            await task;
        }
        catch (Exception ex)
        {
            handler?.HandleError(ex);
        }
    }
}