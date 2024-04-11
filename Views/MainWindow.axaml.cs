using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Interactivity;
using StellarMVVM_2024.ViewModels;

namespace StellarMVVM_2024.Views
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Content = new home_screen();
        }

        public static void changeView (UserControl newView)
        {
            var desktop = Application.Current.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime;
            var mainWindow = desktop.MainWindow;
            mainWindow.Content = newView;
        }

    }
}