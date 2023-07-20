using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using WinUI3_DataTemplate_Bind_ParentProperty.Views.Data;

namespace WinUI3_DataTemplate_Bind_ParentProperty.ViewModels
{
    internal partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<MainPageItemViewData> _itemsViewData = new()
        {
            new("\ue701", "Wifi"),
            new("\ue702", "Bluetooth"),
            new("\ue706", "Brightness"),
            new("\ue709", "Airplane"),
        };
    }
}
