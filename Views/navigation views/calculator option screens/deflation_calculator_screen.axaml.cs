using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace StellarMVVM_2024.Views;

public partial class deflation_calculator_screen : UserControl
{
    public deflation_calculator_screen()
    {
        InitializeComponent();
    }
    private void returnPrevious(object sender, PointerReleasedEventArgs e)
    {
        MainWindow.changeView(new financial_calculators_screen());
    }

    private void calculateDeflation(object sender, RoutedEventArgs e)
    {
        deflationDirections.Text = " ";

        double newPrice = -69420;
        double oldPrice = -69420;
        double rate = -69420;
        double time = -69420;
        int emptyCount = 0;

        if (Double.TryParse(deflationCurrentWorth.Text, out double unused))
        {
            oldPrice = Double.Parse(deflationCurrentWorth.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(deflationFutureWorth.Text, out double a))
        {
            newPrice = Double.Parse(deflationFutureWorth.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(deflationRate.Text, out double b))
        {
            rate = Double.Parse(deflationRate.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(deflationYearsFuture.Text, out double c))
        {
            time = Double.Parse(deflationYearsFuture.Text);
        }
        else
        {
            emptyCount++;
        }


        if (emptyCount > 1)
        {
            deflationDirections.Text = "too many missing variables";
            return;
        }
        else if (emptyCount == 0)
        {
            deflationDirections.Text = "no variables to solve for!";
            return;
        }

        if (newPrice == -69420)
        {
            deflationFutureWorth.Text = (oldPrice * Math.Pow(1 - rate / 100, time)).ToString("0.00");
            deflationDirections.Text = " ";
            return;
        }

        if (oldPrice == -69420)
        {
            deflationCurrentWorth.Text = (newPrice / Math.Pow(1 - rate / 100, time)).ToString("0.00");
            deflationDirections.Text = " ";
            return;
        }

        if (rate == -69420)
        {
            if (newPrice > oldPrice)
            {
                deflationDirections.Text = "this looks like inflation!";
                deflationRate.Text = " ";
                return;
            }
            if (oldPrice == 0 || newPrice == oldPrice)
            {
                deflationRate.Text = "0.00";
            }
            deflationRate.Text = ((oldPrice - newPrice) / oldPrice * 100).ToString("0.00");
            return;
        }

        if (time == -69420)
        {
            if (newPrice > oldPrice)
            {
                deflationDirections.Text = "this looks like inflation!";
                return;
            }
            deflationFutureWorth.Text = Math.Log(newPrice / oldPrice, 1 - rate / 100).ToString("0.00");
            return;
        }
        return;
    }

}