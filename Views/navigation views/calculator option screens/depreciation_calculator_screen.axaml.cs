using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;

namespace StellarMVVM_2024.Views;

public partial class depreciation_calculator_screen : UserControl
{
    public depreciation_calculator_screen()
    {
        InitializeComponent();
    }
    private void returnPrevious(object sender, PointerReleasedEventArgs e)
    {
        MainWindow.changeView(new financial_calculators_screen());
    }

    private void calculateDepreciation (object sender, RoutedEventArgs e)
    {
        depreciationDirections.Text = " ";

        double newPrice = -69420;
        double oldPrice = -69420;
        double rate = -69420;
        double time = -69420;
        int emptyCount = 0;

        if (Double.TryParse(depreciationOriginalPrice.Text, out double unused))
        {
            oldPrice = Double.Parse(depreciationOriginalPrice.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(depreciationFutureValue.Text, out double a))
        {
            newPrice = Double.Parse(depreciationFutureValue.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(depreciationRate.Text, out double b))
        {
            rate = Double.Parse(depreciationRate.Text);
        }
        else
        {
            emptyCount++;
        }

        if (Double.TryParse(depreciationFutureYears.Text, out double c))
        {
            time = Double.Parse(depreciationFutureYears.Text);
        }
        else
        {
            emptyCount++;
        }

        if (emptyCount > 1)
        {
            depreciationDirections.Text = "too many missing variables";
            return;
        }
        else if (emptyCount == 0)
        {
            depreciationDirections.Text = "no variables to solve for!";
            return;
        }

        if (newPrice == -69420)
        {
            depreciationFutureValue.Text = (oldPrice * Math.Pow(1 - rate / 100, time)).ToString("0.00");
            return;
        }

        if (oldPrice == -69420)
        {
            depreciationFutureValue.Text = (newPrice / Math.Pow(1 - rate / 100, time)).ToString("0.00");
            return;
        }

        if (rate == -69420)
        {
            if (newPrice > oldPrice)
            {
                depreciationDirections.Text = "this looks like appreciation!";
                depreciationRate.Text = " ";
                return;
            }
            if (oldPrice == 0 || newPrice == oldPrice)
            {
                depreciationRate.Text = "0.00";
            }
            depreciationRate.Text = ((oldPrice - newPrice) / oldPrice * 100).ToString("0.00");
            return;
        }

        if (time == -69420)
        {
            depreciationFutureYears.Text = Math.Log(newPrice / oldPrice, 1 - rate / 100).ToString("0.00");
            return;
        }
        return;
    }

}