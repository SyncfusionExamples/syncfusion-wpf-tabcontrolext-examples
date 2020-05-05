using Syncfusion.Windows.Shared;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Templates
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
            TabItem_ViewModel model1 = new TabItem_ViewModel()
            {
                Header = "tabItem1",
                Content = "This is the content of first tabitem."
            };
            TabItem_ViewModel model2 = new TabItem_ViewModel()
            {
                Header = "tabItem2",
                Content = "This is the content of second tabitem."
            };
            TabItem_ViewModel model3 = new TabItem_ViewModel()
            {
                Header = "tabItem3",
                Content = "This is the content of third tabitem."
            };

            //Adding tab item details to the collection
            tabItems.Add(model1);
            tabItems.Add(model2);
            tabItems.Add(model3);
        }
    }
}