using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace StellarMVVM_2024.Views
{
    public partial class archive_screen : UserControl
    {
        public archive_screen()
        {
            InitializeComponent();
        }

        private void debitVsCreditClicked(object sender, RoutedEventArgs e)
        {
            // Call the static ChangeView method of the MainWindow class
            MainWindow.changeView(new debt_vs_credit_archive_screen());
        }
        private void financeAccountsClicked(object sender, RoutedEventArgs e)
        {
            // Call the static ChangeView method of the MainWindow class
            MainWindow.changeView(new finance_accounts_archive_screen());
        }
        private void financeInstitutionsClicked(object sender, RoutedEventArgs e)
        {
            // Call the static ChangeView method of the MainWindow class
            MainWindow.changeView(new finance_institution_archive_screen());
        }
        private void incomeClicked(object sender, RoutedEventArgs e)
        {
            // Call the static ChangeView method of the MainWindow class
            MainWindow.changeView(new income_archive_screen());
        }
        private void inflationClicked(object sender, RoutedEventArgs e)
        {
            // Call the static ChangeView method of the MainWindow class
            MainWindow.changeView(new inflation_archive_screen());
        }
        private void interestRatesClicked(object sender, RoutedEventArgs e)
        {
            // Call the static ChangeView method of the MainWindow class
            MainWindow.changeView(new interest_rates_archive_screen());
        }
        private void makingDecisionsClicked(object sender, RoutedEventArgs e)
        {
            // Call the static ChangeView method of the MainWindow class
            MainWindow.changeView(new making_decisions_archive_screen());
        }
        private void settingGoalsClicked(object sender, RoutedEventArgs e)
        {
            // Call the static ChangeView method of the MainWindow class
            MainWindow.changeView(new setting_goals_archive_screen());
        }
        private void taxesClicked(object sender, RoutedEventArgs e)
        {
            // Call the static ChangeView method of the MainWindow class
            MainWindow.changeView(new taxes_archive_screen());
        }

        private void returnHome (object sender, PointerReleasedEventArgs e)
        {
            MainWindow.changeView(new home_screen());
        }
    }
}
