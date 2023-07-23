using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WinUI3_DataTemplate_Bind_ParentProperty.Views.Data;

namespace WinUI3_DataTemplate_Bind_ParentProperty.ViewModels
{
    internal partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<MyItemViewData> _myItemViewData = new();

        [ObservableProperty]
        private List<MyItemViewModel> _myItemViewModels = new();

        [ObservableProperty]
        private bool _openInfoBar = false;

        [ObservableProperty]
        private string _infoBarMessage;

        public void Initialize()
        {
            MyItemViewData = new()
            {
                new("\ue701", "Wifi"),
                new("\ue702", "Bluetooth"),
                new("\ue706", "Brightness"),
                new("\ue709", "Airplane"),
            };

            MyItemViewModels = new()
            {
                new("\ue701", "Wifi", ShowInfoBar),
                new("\ue702", "Bluetooth", ShowInfoBar),
                new("\ue706", "Brightness", ShowInfoBar),
                new("\ue709", "Airplane", ShowInfoBar),
            };
        }

        [RelayCommand]
        private async Task ClickButton(string clickedText)
        {
            var delayTask = Task.Delay(TimeSpan.FromSeconds(1));
            ShowInfoBar(clickedText);
            await delayTask;
        }

        private void ShowInfoBar(string clickedText)
        {
            OpenInfoBar = true;
            InfoBarMessage = $"{clickedText} clicked.";
        }
    }
}
