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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double dblResistance = 0.0;
            double dblCapacitance = 0.0;
            bool bResistanceBad = false;
            bool bCapacitanceBad = false;

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
                bResistanceBad = true;
            }

            if (true == bResistanceBad)
            {

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
                bCapacitanceBad = true;
            }

            if (true == bCapacitanceBad)
            {

                return;
            }

        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resistanceTextbox.Text = "";
            capacitanceTextbox.Text = "";
            inductanceTextbox.Text = "";
            resultsBox.Text = "";
        }
    }
}
