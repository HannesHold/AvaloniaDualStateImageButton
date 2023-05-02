using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaDualStateImageButton.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        #region Properties

        [ObservableProperty]
        private bool _isPlaying = false;

        #endregion

        #region Commands

        [RelayCommand(CanExecute = nameof(CanExecutePlay))]
        private void Play()
        {
            IsPlaying = !IsPlaying;
        }

        private bool CanExecutePlay()
        {
            return true;
        }

        #endregion
    }
}