using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using MaterialDesignThemes.Wpf;
using SpaceTraders.ViewModels.Dialogs;

namespace SpaceTraders.Views.Dialogs;

public partial class RegistrationDialog : UserControl
{
    private RegistrationDialogViewModel? vm;

    public RegistrationDialog()
    {
        InitializeComponent();
    }

    private void RegistrationDialog_OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
        if (e.NewValue is not RegistrationDialogViewModel registrationDialogViewModel) return;
        vm = registrationDialogViewModel;
        vm.PropertyChanged += VmOnPropertyChanged;
    }

    private void VmOnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName != nameof(RegistrationDialogViewModel.RegistrationInformation)) return;
        vm.PropertyChanged -= VmOnPropertyChanged;
        DialogHost.CloseDialogCommand.Execute(true, this);
    }
}