using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using StellarMVVM_2024.ViewModels;

namespace StellarMVVM_2024.Views
{
    public partial class home_screen : UserControl
    {

        public home_screen()
        {
            InitializeComponent();
        }

        private void archiveClicked (object sender, RoutedEventArgs e)
        {
            // Call the static ChangeView method of the MainWindow class
            MainWindow.changeView(new archive_screen());
        }

        private void budgetClicked (object sender, RoutedEventArgs e)
        {
            // Call the static ChangeView method of the MainWindow class
            MainWindow.changeView(new budget_screen());
        }

        private void calculatorsClicked(object sender, RoutedEventArgs e)
        {
            // Call the static ChangeView method of the MainWindow class
            MainWindow.changeView(new financial_calculators_screen());
        }

    }
}

