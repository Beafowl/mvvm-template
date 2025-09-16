
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Model;
using ViewModel.Dialogs;
using ViewModel.Dialogs.YesNoDialog;

namespace ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public ExampleModel Model { get; set; }

        private readonly DialogService _dialogService = new DialogService();

        public RelayCommand RelayCommand { get; set; }

        public MainViewModel()
        {
            RelayCommand = new RelayCommand(Execute, CanExecute);
            Model = new ExampleModel();
        }

        public async void Execute()
        {
            Model.Name = "Button pressed";
            _dialogService.OpenDialogAsync(new YesNoDialogViewModel("Blabla", "Nachricht"));
        }

        public bool CanExecute()
        {
            return true;
        }
    }
}
