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
using Learning.Pages.HambugerHeavenChallenge;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Learning.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HamburgerHeavenChallenge : Page
    {
        public HamburgerHeavenChallenge()
        {
            this.InitializeComponent();
            BackButton.Visibility = Visibility.Collapsed;
            FianncialListBoxItem.IsSelected = true;
            MyFrame.Navigate(typeof(Financial));
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            FinancialSplitView.IsPaneOpen = !FinancialSplitView.IsPaneOpen;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PaneListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FianncialListBoxItem.IsSelected)
            {
                BackButton.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(Financial));
                TitleTextBlock.Text = "Financial";
            }
            else if (FoodListBoxItem.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Food));
                TitleTextBlock.Text = "Food";
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
                FianncialListBoxItem.IsSelected = true;
            }
        }
    }
}
