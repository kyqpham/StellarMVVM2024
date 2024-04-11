using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace StellarMVVM_2024.Views;

public partial class simple_interest_calculator_screen : UserControl
{
    public simple_interest_calculator_screen()
    {
        InitializeComponent();
    }
    private void returnPrevious(object sender, PointerReleasedEventArgs e)
    {
        MainWindow.changeView(new financial_calculators_screen());
    }
    private void calculateSimpleInterest(object sender, RoutedEventArgs e)
    {
        simpleIntersestDirections.Text = "  ";

        double principle = -69420;
        double simpleRate = -69420;
        double years = -69420;
        double futureValue = -69420;
        int emptyCount = 0;

        if (Double.TryParse(simpleInterestPrinciple.Text, out double unused))
        {
            principle = Double.Parse(simpleInterestPrinciple.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(simpleInterestRate.Text, out double b))
        {
            simpleRate = Double.Parse(simpleInterestRate.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(simpleInterestFutureYears.Text, out double stop))
        {
            years = Double.Parse(simpleInterestFutureYears.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(simpleInterestFutureValue.Text, out double h))
        {
            futureValue = Double.Parse(simpleInterestFutureValue.Text);
        }
        else
        {
            emptyCount++;
        }

        if (emptyCount > 1)
        {
            simpleIntersestDirections.Text = "too many missing variables";
            return;
        }
        else if (emptyCount == 0)
        {
            simpleIntersestDirections.Text = "no variables to solve for!";
            return;
        }

        if (principle == -69420)
        {
            simpleInterestPrinciple.Text = (futureValue / (1 + (simpleRate / 100) * years)).ToString("0.00");
            return;
        }

        if (futureValue == -69420)
        {
            simpleInterestFutureValue.Text = (principle * (1 + (simpleRate / 100) * years)).ToString("0.00");
            return;
        }

        if (simpleRate == -69420)
        {
            simpleInterestRate.Text = ((((futureValue / principle) - 1) / years) * 100).ToString("0.00");
            return;
        }

        if (years == -69420)
        {
            simpleInterestFutureYears.Text = (((futureValue / principle) - 1) / (simpleRate / 100)).ToString("0.00");
            return;
        }
        return;
    }

}