using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using StellarMVVM_2024.ViewModels;


namespace StellarMVVM_2024.Views;

public partial class financial_calculators_screen : UserControl
{
    public financial_calculators_screen()
    {
        InitializeComponent();
    }

    private void appreciationClicked(object sender, RoutedEventArgs e)
    {
        // Call the static ChangeView method of the MainWindow class
        MainWindow.changeView(new appreciation_calculator_screen());
    }

    private void depreciationClicked(object sender, RoutedEventArgs e)
    {
        // Call the static ChangeView method of the MainWindow class
        MainWindow.changeView(new depreciation_calculator_screen());
    }

    private void simpleInterestClicked(object sender, RoutedEventArgs e)
    {
        // Call the static ChangeView method of the MainWindow class
        MainWindow.changeView(new simple_interest_calculator_screen());
    }
    private void compoundInterestClicked(object sender, RoutedEventArgs e)
    {
        // Call the static ChangeView method of the MainWindow class
        MainWindow.changeView(new compound_interest_calculator_screen());
    }
    private void inflationClicked(object sender, RoutedEventArgs e)
    {
        // Call the static ChangeView method of the MainWindow class
        MainWindow.changeView(new inflation_calculator_screen());
    }

    private void deflationClicked (object sender, RoutedEventArgs e)
    {
        // Call the static ChangeView method of the MainWindow class
        MainWindow.changeView(new deflation_calculator_screen());
    }

    private void returnHome(object sender, PointerReleasedEventArgs e)
    {
        MainWindow.changeView(new home_screen());
    }
}