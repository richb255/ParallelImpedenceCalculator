using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ParallelImpedenceCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        ///  This function handles the Calculate button click event and it is here
        ///  where the impedence value is calculated. I am making the error checking
        ///  more sophisticated this time, displaying more information to the user about
        ///  what went wromg.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double dblResistance = 0.0;
            double dblCapacitance = 0.0;
            double dblInductance = 0.0;
            double dblFrequency = 0.0;
            bool bResistanceBad = false;
            bool bCapacitanceBad = false;
            bool bInductanceBad = false;
            bool bFrequencyBad = false;
            String message = "";
            
            try
            {
               if (0 == frequencyTextbox.Text.Length)
               {
                   dblFrequency = 0.0;
               }
               else
               {
                   dblFrequency = Double.Parse(frequencyTextbox.Text);
               }
            }
            catch (Exception ex)
            {
                  message = "Frequency input: " + ex.Message;
                  bFrequencyBad = true;
            }

            if (true == bFrequencyBad)
            {
                  ShowMessage(message);
                  return;
            }
            
            try
            {
                if (0 == resistanceTextbox.Text.Length)
                {
                    dblResistance = 0.0;
                }
                else
                {
                    dblResistance = Double.Parse(resistanceTextbox.Text);
                }
            }
            catch (Exception ex)
            {
                message = "Resistance input: " + ex.Message;
                bResistanceBad = true;
            }

            if (true == bResistanceBad)
            {
                ShowMessage(message);
                return;
            }

            try
            {
                if (0 == capacitanceTextbox.Text.Length)
                {
                    dblCapacitance = 0.0;
                }
                else
                {
                    dblCapacitance = Double.Parse(capacitanceTextbox.Text);
                }
            }
            catch (Exception ex)
            {
                message = "Capacitance input: " + ex.Message;
                bCapacitanceBad = true;
            }

            if (true == bCapacitanceBad)
            {
                ShowMessage(message);
                return;
            }

            try
            {
                if (0 == inductanceTextbox.Text.Length)
                {
                    dblInductance = 0.0;
                }
                else
                {
                    dblInductance = Double.Parse(inductanceTextbox.Text);
                }
            }
            catch (Exception ex)
            {
                message = "Inductance input: " + ex.Message;
                bInductanceBad = true;
            }

            if (true == bInductanceBad)
            {
                ShowMessage(message);
                return;
            }

            // Here is where we do the calculations.
            try
            {

            }
            catch (Exception ex)
            {

            }

        }

        /// <summary>
        ///  This function handles the click event from the Clear button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resistanceTextbox.Text = "";
            capacitanceTextbox.Text = "";
            inductanceTextbox.Text = "";
            resultsBox.Text = "";
        }

        /// <summary>
        /// This function displays a message to the user.
        /// </summary>
        /// <param name="Msg"></param>
        private async void ShowMessage(String Msg)
        {
            var messageDialog = new MessageDialog(Msg);

            messageDialog.Commands.Add(new UICommand("OK"));

            await messageDialog.ShowAsync();
        }
    }
}
