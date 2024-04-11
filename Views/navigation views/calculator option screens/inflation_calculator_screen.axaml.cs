using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace StellarMVVM_2024.Views;

public partial class inflation_calculator_screen : UserControl
{
    public inflation_calculator_screen()
    {
        InitializeComponent();
    }

    private void returnPrevious(object sender, PointerReleasedEventArgs e)
    {
        MainWindow.changeView(new financial_calculators_screen());
    }

    private void calculateInflation(object sender, RoutedEventArgs e)
    {
        inflationDirections.Text = "  ";
      
        double newPrice = -69420;
        double oldPrice = -69420;
        double rate = -69420;
        double time = -69420;
        int emptyCount = 0;
        if (Double.TryParse(inflationCurrentWorth.Text, out double unused))
        {
            oldPrice = Double.Parse(inflationCurrentWorth.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(inflationNewWorth.Text, out double a))
        {
            newPrice = Double.Parse(inflationNewWorth.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(inflationRate.Text, out double b))
        {
            rate = Double.Parse(inflationRate.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(inflationFutureYears.Text, out double c))
        {
            time = Double.Parse(inflationFutureYears.Text);
        }
        else
        {
            emptyCount++;
        }

        if (emptyCount > 1)
        {
            inflationDirections.Text = "too many missing variables";
            return;
        }
        else if (emptyCount == 0)
        {
            inflationDirections.Text = "no variables to solve for!";
            return;
        }

        if (newPrice == -69420)
        {
            inflationNewWorth.Text = (oldPrice * Math.Pow(1 + rate / 100, time)).ToString("0.00");
            return;
        }

        if (oldPrice == -69420)
        {
            inflationCurrentWorth.Text = (newPrice / Math.Pow(1 + rate / 100, time)).ToString("0.00");
            return;
        }

        if (rate == -69420)
        {
            if (newPrice < oldPrice)
            {
                inflationDirections.Text = "this looks like deflation!";
                inflationRate.Text = " ";
                return;
            }
            if (oldPrice == 0 || newPrice == oldPrice)
            {
                inflationRate.Text = "0.00";
            }
            inflationRate.Text = ((oldPrice - newPrice) / oldPrice * 100).ToString("0.00");
            return;
        }

        if (time == -69420)
        {
            if (newPrice < oldPrice)
            {
                inflationDirections.Text = "this looks like deflation!";
                inflationFutureYears.Text = " ";
                return;
            }
            inflationFutureYears.Text = Math.Log(newPrice / oldPrice, 1 + rate / 100).ToString("0.00");
            return;
        }
        return;
    }
}