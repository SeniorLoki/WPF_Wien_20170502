using System;

namespace HalloMVVM.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private string _welcomeText = "Hallo aus dem VM";
        public string WelcomeText
        {
            get { return _welcomeText; }
            set
            {
                SetProperty(ref _welcomeText, value);
            }
        }

        private RelayCommand<string> _changeTextCommand;
        public RelayCommand<string> ChangeTextCommand
        {
            get
            {
                return _changeTextCommand ??
                    (_changeTextCommand = new RelayCommand<string>(
                        execute: text => WelcomeText = text,
                        canExecute: text => WelcomeText?.Length < 10));
            }
        }

        public MainWindowViewModel()
        {
            //ChangeTextCommand = new RelayCommand(MachWas, KonIWosDoa);
        }

        private bool KonIWosDoa()
        {
            return WelcomeText.Length < 10;
        }

        private void MachWas()
        {
            WelcomeText = "Der spezielle Text aus meinem speziellen ViewModel! (aus dem Command)";
        }
    }
}