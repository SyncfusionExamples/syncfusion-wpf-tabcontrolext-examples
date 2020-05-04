using Syncfusion.Windows.Shared;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Tab_Header
{
    public class ViewModel : NotificationObject
    {
        private ObservableCollection<TabItem> tabItems;
        private bool hideHeaderOnSingleChild = true;
        private bool enableLabelEdit = true;

        public bool HideHeaderOnSingleChild
        {
            get { return hideHeaderOnSingleChild; }
            set
            {
                hideHeaderOnSingleChild = value;
                this.RaisePropertyChanged("HideHeaderOnSingleChild");
            }
        }

        public bool EnableLabelEdit
        {
            get { return enableLabelEdit; }
            set
            {
                enableLabelEdit = value;
                this.RaisePropertyChanged("EnableLabelEdit");
            }
        }

        public ObservableCollection<TabItem> TabItems
        {
            get { return tabItems; }
            set
            {
                tabItems = value;
                this.RaisePropertyChanged("TabItems");
            }
        }

        public ViewModel()
        {
            tabItems = new ObservableCollection<TabItem>();
            PopulateCollection();
        }

        public void PopulateCollection()
        {
            TabItem tabItem1 = new TabItem()
            {
                Header = "tabItem1",
                Content = new TextBlock()
                {
                    Text = "This is the content of first tabitem.",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                },
                Image = "Images/sync.png"
            };
            TabItem tabItem2 = new TabItem()
            {
                Header = "tabItem2",
                Content = new TextBlock()
                {
                    Text = "This is the content of second tabitem.",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
                    Background = Brushes.LightYellow
                },
                Image = "Images/tabimage.png"
            };
            TabItem tabItem3 = new TabItem()
            {
                Header = "tabItem3",
                Content = new TextBlock()
                {
                    Text = "This is the content of third tabitem.",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
                    Background = Brushes.Green
                },
                Image = "Images/sync.png"
            };

            //Adding tab item details to the collection
            tabItems.Add(tabItem1);
            tabItems.Add(tabItem2);
            tabItems.Add(tabItem3);
        }
    }
}
