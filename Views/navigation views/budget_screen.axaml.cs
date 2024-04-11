using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;

namespace StellarMVVM_2024.Views
{
    public partial class budget_screen : UserControl
    {

        public budget_screen()
        {
            InitializeComponent();
        }
        private void budgetRecommendationClicked(object sender, RoutedEventArgs e)
        {
            budget.IsVisible = false;
            recommendation.IsVisible = true;
            budgetCalculations();
        }

        private void returnToBudget(object sender, PointerReleasedEventArgs e)
        {
            budget.IsVisible = true;
            recommendation.IsVisible = false;
        }
        private void returnHome(object sender, PointerReleasedEventArgs e)
        {
            MainWindow.changeView(new home_screen());
        }

        private void budgetCalculations()
        {
            if (Double.TryParse(incomeInput.Text, out double unused) && Double.TryParse(debtInput.Text, out double otherunused))
            {
                double difference = double.Parse(incomeInput.Text) - double.Parse(debtInput.Text);
                assets.Text = "assets: $" + difference.ToString();
                income.Text = "income: $" + incomeInput.Text;

                recommendedHousing.Text = "$" + ((double.Parse(incomeInput.Text) * 0.30).ToString());
                recommendedUtilities.Text = "$" + ((double.Parse(incomeInput.Text) * 0.10).ToString());
                recommendedInsurance.Text = "$" + ((double.Parse(incomeInput.Text) * 0.15).ToString());
                recommendedTransportation.Text = "$" + ((double.Parse(incomeInput.Text) * 0.10).ToString());
                recommendedGroceries.Text = "$" + ((double.Parse(incomeInput.Text) * 0.15).ToString());
                recommendedOtherSpending.Text = "$" + ((double.Parse(incomeInput.Text) * 0.20).ToString());

                if (Double.TryParse(housingInput.Text, out double a) &&
                    Double.TryParse(utilitiesInput.Text, out double b) &&
                    Double.TryParse(transportationInput.Text, out double c) &&
                    Double.TryParse(groceriesInput.Text, out double d) &&
                    Double.TryParse(insuranceInput.Text, out double p) &&
                    Double.TryParse(otherInput.Text, out double f))
                    {
                        if (difference < 0 || ((a + b + c + d + p + f >= 101)))
                        {
                            budgetRecommendation.Text = "start a plan to pay off your liabilities!";
                            return;
                        }
                        else if (double.Parse(housingInput.Text) > 30)
                        {
                            budgetRecommendation.Text = "try finding cheaper housing!";
                            return;
                        }
                        else if (double.Parse(utilitiesInput.Text) > 10)
                        {
                            budgetRecommendation.Text = "try to use less electricity!";
                            return;
                        }
                        else if (double.Parse(groceriesInput.Text) > 15)
                        {
                            budgetRecommendation.Text = "try to find alternatives for your brand of food!";
                            return;
                        }
                        else if (double.Parse(transportationInput.Text) > 10)
                        {
                            budgetRecommendation.Text = "try to find alternatives for your transportation!";
                            return;
                        }
                        else if (double.Parse(insuranceInput.Text) > 15)
                        {
                            budgetRecommendation.Text = "try to find an alternative to your insurance!";
                            return;
                        }
                        else if (double.Parse(otherInput.Text) > 20)
                        {
                            budgetRecommendation.Text = "try to add more to your savings!";
                            return;
                        }
                        else
                        {
                            budgetRecommendation.Text = "make sure you have an emergency fund!";
                        }
                    }
                    else
                    {
                        budgetRecommendation.Text = "add your current budget for a recommendation!";
                    }
                }
            else
            {
                assets.Text = "$0";
                income.Text = "$0";
                budgetRecommendation.Text = "make sure to input income AND debt as numbers!";
            }
        }
     }
 }

