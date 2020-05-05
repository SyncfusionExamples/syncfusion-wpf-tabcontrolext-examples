using Syncfusion.Windows.Shared;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Pin_UnPin
{
    public class ViewModel : NotificationObject
    {
        private ObservableCollection<TabItem_ViewModel> tabItems;
        public ObservableCollection<TabItem_ViewModel> TabItems
        {
            get { return tabItems; }
            set
            {
                tabItems = value;
                this.RaisePropertyChanged(nameof(TabItems));
            }
        }

        public ViewModel()
        {
            tabItems = new ObservableCollection<TabItem_ViewModel>();
            PopulateCollection();
        }

        public void PopulateCollection()
        {
            TabItem_ViewModel tabItem1 = new TabItem_ViewModel()
            {
                Header = "tabItem1",
                Content = "This is the content of first tabitem.",
                AllowPin = true,
                CanClose = false,
                ShowPin = true,
                IsPinned= false,
                CloseButtonState = Visibility.Visible
            };
            TabItem_ViewModel tabItem2 = new TabItem_ViewModel()
            {
                Header = "tabItem2",
                Content = "This is the content of second tabitem.",
                AllowPin = true,
                CanClose = false,
                ShowPin = true,
                IsPinned = true,
                CloseButtonState = Visibility.Visible
            };
            TabItem_ViewModel tabItem3 = new TabItem_ViewModel()
            {
                Header = "tabItem3",
                Content = "This is the content of third tabitem.",
                AllowPin = true,
                CanClose = true,
                ShowPin = true,
                IsPinned = true,
                CloseButtonState = Visibility.Visible
            };

            //Adding tab item details to the collection
            tabItems.Add(tabItem1);
            tabItems.Add(tabItem2);
            tabItems.Add(tabItem3);
        }
    }
}
