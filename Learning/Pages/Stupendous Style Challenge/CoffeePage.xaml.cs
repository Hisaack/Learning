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
using MenuFlyoutItem = Windows.UI.Xaml.Controls.MenuFlyoutItem;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Learning.Pages.Stupendous_Style_Challenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        private string _roast;
        private string _sweetener;
        private string _cream;
        private static string _coffeeComponent;

        public CoffeePage()
        {
            this.InitializeComponent();
        }

        private void Roast_Click(object sender, RoutedEventArgs e)
        {
            if (sender is MenuFlyoutItem itemSelected)
                _roast = itemSelected.Text;
            AddCoffeeComponent();
        }

        private void Sweetener_Click(object sender, RoutedEventArgs e)
        {
            if (sender is MenuFlyoutItem itemSelected)
                _sweetener = itemSelected.Text;
            AddCoffeeComponent();
        }

        private void Cream_Click(object sender, RoutedEventArgs e)
        {
            if (sender is MenuFlyoutItem itemSelected)
                _cream = itemSelected.Text;
            AddCoffeeComponent();
        }


        private void AddCoffeeComponent()
        {
            if (_roast.Equals("None") || string.IsNullOrEmpty(_roast))
            {
                CoffeeComponentsTextBlock.Text = "None";
                return;
            }

            CoffeeComponentsTextBlock.Text = _roast;

            if (_sweetener != "None" && !string.IsNullOrEmpty(_sweetener))
                CoffeeComponentsTextBlock.Text += " + " + _sweetener;

            if (_cream != "None" && !string.IsNullOrEmpty(_cream))
                CoffeeComponentsTextBlock.Text += " + " + _cream;
        }
    }
}
