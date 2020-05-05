using Syncfusion.Windows.Shared;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Tab_Header
{
    public class ViewModel : NotificationObject
    {
        private ObservableCollection<TabItem_ViewModel> tabItems;
        private bool hideHeaderOnSingleChild = true;
        private bool enableLabelEdit = true;

        public bool HideHeaderOnSingleChild
        {
            get { return hideHeaderOnSingleChild; }
            set
            {
                hideHeaderOnSingleChild = value;
                this.RaisePropertyChanged(nameof(HideHeaderOnSingleChild));
            }
        }

        public bool EnableLabelEdit
        {
            get { return enableLabelEdit; }
            set
            {
                enableLabelEdit = value;
                this.RaisePropertyChanged(nameof(EnableLabelEdit));
            }
        }

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
                Image = "Images/sync.png"
            };
            TabItem_ViewModel tabItem2 = new TabItem_ViewModel()
            {
                Header = "tabItem2",
                Content = "This is the content of second tabitem.",
                Image = "Images/tabimage.png"
            };
            TabItem_ViewModel tabItem3 = new TabItem_ViewModel()
            {
                Header = "tabItem3",
                Content = "This is the content of third tabitem.",
                Image = "Images/sync.png"
            };

            //Adding tab item details to the collection
            tabItems.Add(tabItem1);
            tabItems.Add(tabItem2);
            tabItems.Add(tabItem3);
        }
    }
}
