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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Learning.Pages.Stupendous_Style_Challenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Stupendous_Style_Challenge : Page
    {
        public Stupendous_Style_Challenge()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(DonutPage));
        }

        private void DonutBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CoffeeBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ScheduleBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CompleteBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
