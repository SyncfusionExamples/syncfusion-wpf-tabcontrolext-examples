
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CloseMode = Syncfusion.Windows.Tools.Controls.CloseMode;

namespace Tab_Closing
{
    public class ViewModel : NotificationObject
    {
        private ObservableCollection<TabItem> tabItems;
        private CloseMode closeMode= CloseMode.Hide;
        private CloseButtonType closeButtonType= CloseButtonType.Both;
        private bool closeTabOnMiddleClick;

        public ObservableCollection<TabItem> TabItems
        {
            get { return tabItems; }
            set
            {
                tabItems = value;
                this.RaisePropertyChanged("TabItems");
            }
        }
        
        public bool CloseTabOnMiddleClick
        {
            get { return closeTabOnMiddleClick; }
            set
            {
                closeTabOnMiddleClick = value;
                this.RaisePropertyChanged("CloseTabOnMiddleClick");
            }
        }

        public CloseMode CloseMode
        {
            get { return closeMode; }
            set
            {
                closeMode = value;
                this.RaisePropertyChanged("CloseMode");
            }
        }
        
        public CloseButtonType CloseButtonType
        {
            get { return closeButtonType; }
            set
            {
                closeButtonType = value;
                this.RaisePropertyChanged("CloseButtonType");
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
                CanClose = true,
                CloseButtonState = Visibility.Visible
            };
            TabItem tabItem2 = new TabItem()
            {
                Header = "tabItem2",
                Content = new TextBlock()
                {
                    Text = "This is the content of second tabitem.",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,

                },
                CanClose = false,
                CloseButtonState = Visibility.Visible
            };
            TabItem tabItem3 = new TabItem()
            {
                Header = "tabItem3",
                Content = new TextBlock()
                {
                    Text = "This is the content of third tabitem.",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                },
                CanClose = true,
                CloseButtonState = Visibility.Visible
            };

            //Adding tab item details to the collection
            tabItems.Add(tabItem1);
            tabItems.Add(tabItem2);
            tabItems.Add(tabItem3);
        }
    }
}
