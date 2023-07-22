using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WinUI3_DataTemplate_Bind_ParentProperty.Views.Data;

namespace WinUI3_DataTemplate_Bind_ParentProperty.ViewModels
{
    internal partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<MyItemViewData> _myItemViewData;

        [ObservableProperty]
        private List<MyItemViewModel> _myItemViewModels;

        [ObservableProperty]
        private bool _openInfoBar = false;

        [ObservableProperty]
        private string _infoBarMessage;

        public MainPageViewModel()
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
        private void ClickButton(string clickedText)
        {
            ShowInfoBar(clickedText);
        }

        private void ShowInfoBar(string clickedText)
        {
            OpenInfoBar = true;
            InfoBarMessage = $"{clickedText} clicked.";
        }
    }
}
