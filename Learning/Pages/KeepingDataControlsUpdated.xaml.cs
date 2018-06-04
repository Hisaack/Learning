using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Contacts;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Learning.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Learning.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class KeepingDataControlsUpdated : Page
    {
        private List<AvatarIcon> icons;
        private ObservableCollection<Contacts> contacts;
        public KeepingDataControlsUpdated()
        {
            this.InitializeComponent();
            icons=Icon.LoadAvatarIcons();
            contacts=new ObservableCollection<Contacts>();
        }

        private void ContactsGrid_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ontact = (Contacts) e.ClickedItem;
            NameTextBlock.Text = string.Concat(ontact.Name, " ", ontact.LastName);
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string avatar = ((AvatarIcon)AvatarComboBox.SelectedValue)?.IconPath;
            var contact = new Contacts()
            {
                Name = FirstNameTBox.Text,
                LastName = LastNameTBox.Text,
                Avatar = avatar
            };
            
            contacts.Add(contact);
        }
    }
}
