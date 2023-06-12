using System.ComponentModel;
using System.Windows;
using MaterialDesignThemes.Wpf;
using SpaceTraders.ViewModels.Dialogs;

namespace SpaceTraders.Views.Dialogs;

public partial class RegistrationDialog
{
    private RegistrationDialogViewModel? _vm;

    public RegistrationDialog()
    {
        InitializeComponent();
    }

    private void RegistrationDialog_OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
        if (e.NewValue is not RegistrationDialogViewModel registrationDialogViewModel) return;
        _vm = registrationDialogViewModel;
        _vm.PropertyChanged += VmOnPropertyChanged;
    }

    private void VmOnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName != nameof(RegistrationDialogViewModel.RegistrationInformation)) return;
        _vm!.PropertyChanged -= VmOnPropertyChanged;
        DialogHost.CloseDialogCommand.Execute(true, this);
    }
}