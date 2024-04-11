using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace StellarMVVM_2024.Views;

public partial class compound_interest_calculator_screen : UserControl
{
    public compound_interest_calculator_screen()
    {
        InitializeComponent();
    }
    private void returnPrevious(object sender, PointerReleasedEventArgs e)
    {
        MainWindow.changeView(new financial_calculators_screen());
    }

    private void calculateCompoundInterest(object sender, RoutedEventArgs e)
    {
        compoundInterestDirections.Text = "  ";
        double principle = -69420;
        double simpleRate = -69420;
        double years = -69420;
        double futureValue = -69420;
        int emptyCount = 0;

        if (Double.TryParse(compoundInterestPrinciple.Text, out double unused))
        {
            principle = Double.Parse(compoundInterestPrinciple.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(compoundInterestRate.Text, out double b))
        {
            simpleRate = Double.Parse(compoundInterestRate.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(compoundInterestFutureYears.Text, out double stop))
        {
            years = Double.Parse(compoundInterestFutureYears.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(compoundInterestFutureValue.Text, out double h))
        {
            futureValue = Double.Parse(compoundInterestFutureValue.Text);
        }
        else
        {
            emptyCount++;
        }

        if (emptyCount > 1)
        {
            compoundInterestDirections.Text = "too many missing variables";
            return;
        }
        else if (emptyCount == 0)
        {
            compoundInterestDirections.Text = "no variables to solve for!";
            return;
        }

        if (principle == -69420)
        {
            compoundInterestPrinciple.Text = (futureValue / Math.Pow((1 + simpleRate), years)).ToString("0.00");
            return;
        }

        if (futureValue == -69420)
        {
            compoundInterestFutureValue.Text = (principle * Math.Pow(1 + simpleRate / 100, years)).ToString("0.00");
            return;
        }

        if (simpleRate == -69420)
        {
            compoundInterestRate.Text = (Math.Pow(futureValue / principle, 1 / years) - 1).ToString("0.00");
            return;
        }

        if (years == -69420)
        {
            compoundInterestFutureYears.Text = (Math.Log(futureValue / principle, 1 + simpleRate / 100)).ToString("0.00");
            return;
        }
        return;

    }
}
