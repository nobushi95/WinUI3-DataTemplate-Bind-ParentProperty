using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WinUI3_DataTemplate_Bind_ParentProperty.ViewModels
{
    internal partial class MyItemViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _icon;

        [ObservableProperty]
        private string _text;

        private readonly Action<string> _showInfoBar;

        public MyItemViewModel(string icon, string text, Action<string> showInfoBar)
        {
            Icon = icon;
            Text = text;
            _showInfoBar = showInfoBar;
        }

        [RelayCommand]
        private async Task ShowInfoBar()
        {
            var delayTask = Task.Delay(TimeSpan.FromSeconds(1));
            _showInfoBar.Invoke(Text);
            await delayTask;
        }
    }
}
