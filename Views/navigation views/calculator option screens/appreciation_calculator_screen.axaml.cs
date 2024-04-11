using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace StellarMVVM_2024.Views;

public partial class appreciation_calculator_screen : UserControl
{
    public appreciation_calculator_screen()
    {
        InitializeComponent();
    }
    private void returnPrevious(object sender, PointerReleasedEventArgs e)
    {
        MainWindow.changeView(new financial_calculators_screen());
    }

    private void calculateAppreciation(object sender, RoutedEventArgs e)
    {
        appreciationDirections.Text = "  ";

        double newPrice = -69420;
        double oldPrice = -69420;
        double rate = -69420;
        double time = -69420;
        int emptyCount = 0;

        if (Double.TryParse(appreciationOriginalPrice.Text, out double unused))
        {
            oldPrice = Double.Parse(appreciationOriginalPrice.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(appreciationFutureValue.Text, out double a))
        {
            newPrice = Double.Parse(appreciationFutureValue.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(appreciationRate.Text, out double b))
        {
            rate = Double.Parse(appreciationRate.Text);
        }
        else
        {
            emptyCount++;
        }

        if (Double.TryParse(appreciationFutureYears.Text, out double c))
        {
            time = Double.Parse(appreciationFutureYears.Text);
        }
        else
        {
            emptyCount++;
        }

        if (emptyCount > 1)
        {
            appreciationDirections.Text = "too many missing variables";
            return;
        }
        else if (emptyCount == 0)
        {
            appreciationDirections.Text = "no variables to solve for!";
            return;
        }

        if (newPrice == -69420)
        {
            appreciationFutureValue.Text = (oldPrice * Math.Pow(1 + rate / 100, time)).ToString("0.00");
            return;
        }

        if (oldPrice == -69420)
        {
            appreciationOriginalPrice.Text = (newPrice / Math.Pow(1 + rate / 100, time)).ToString("0.00");
            return;
        }

        if (rate == -69420)
        {
            if (newPrice < oldPrice)
            {
                appreciationDirections.Text = "this looks like depreciation!";
                appreciationRate.Text = " ";
                return;
            }
            if (oldPrice == 0 || newPrice == oldPrice)
            {
                appreciationRate.Text = "0.00";
            }
            appreciationRate.Text = ((newPrice - oldPrice) / oldPrice * 100).ToString("0.00");
            return;
        }

        if (time == -69420)
        {
            appreciationFutureYears.Text = Math.Log(newPrice / oldPrice, 1 + rate / 100).ToString("0.00");
            return;
        }
        return;
    }
}