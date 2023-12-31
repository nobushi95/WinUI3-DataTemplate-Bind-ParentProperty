﻿using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using WinUI3_DataTemplate_Bind_ParentProperty.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3_DataTemplate_Bind_ParentProperty.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly MainPageViewModel _viewModel = new();
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void MyMainPage_Loaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            _viewModel.Initialize();
        }

        internal static Visibility BooleanToVisibilityConverter(bool value, bool inverte)
        {
            return inverte switch
            {
                false => value ? Visibility.Visible : Visibility.Collapsed,
                true => value ? Visibility.Collapsed : Visibility.Visible,
            };
        }
    }
}
