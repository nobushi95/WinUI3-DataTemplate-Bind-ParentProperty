using System.Collections.Generic;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WinUI3_DataTemplate_Bind_ParentProperty.Views.Data;

namespace WinUI3_DataTemplate_Bind_ParentProperty.ViewModels
{
    internal partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<MyItemViewData> _myItemViewData = new()
        {
            new("\ue701", "Wifi"),
            new("\ue702", "Bluetooth"),
            new("\ue706", "Brightness"),
            new("\ue709", "Airplane"),
        };

        [RelayCommand]
        private void ClickButton(string text)
        {
            Debug.WriteLine($"{text} clicked.");
        }
    }
}
