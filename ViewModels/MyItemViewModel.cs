using CommunityToolkit.Mvvm.ComponentModel;

namespace WinUI3_DataTemplate_Bind_ParentProperty.ViewModels
{
    internal partial class MyItemViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _icon;

        [ObservableProperty]
        private string _text;

        public MyItemViewModel(string icon, string text)
        {
            Icon = icon;
            Text = text;
        }
    }
}
