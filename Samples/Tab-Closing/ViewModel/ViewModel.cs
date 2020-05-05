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
        private ObservableCollection<TabItem_ViewModel> tabItems;
        private CloseMode closeMode= CloseMode.Hide;
        private CloseButtonType closeButtonType= CloseButtonType.Both;
        private bool closeTabOnMiddleClick;

        public ObservableCollection<TabItem_ViewModel> TabItems
        {
            get { return tabItems; }
            set
            {
                tabItems = value;
                this.RaisePropertyChanged(nameof(TabItems));
            }
        }
        
        public bool CloseTabOnMiddleClick
        {
            get { return closeTabOnMiddleClick; }
            set
            {
                closeTabOnMiddleClick = value;
                this.RaisePropertyChanged(nameof(CloseTabOnMiddleClick));
            }
        }

        public CloseMode CloseMode
        {
            get { return closeMode; }
            set
            {
                closeMode = value;
                this.RaisePropertyChanged(nameof(CloseMode));
            }
        }
        
        public CloseButtonType CloseButtonType
        {
            get { return closeButtonType; }
            set
            {
                closeButtonType = value;
                this.RaisePropertyChanged(nameof(CloseButtonType));
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
                CanClose = true,
                CloseButtonState = Visibility.Visible
            };
            TabItem_ViewModel tabItem2 = new TabItem_ViewModel()
            {
                Header = "tabItem2",
                Content = "This is the content of second tabitem.",
                CanClose = false,
                CloseButtonState = Visibility.Visible
            };
            TabItem_ViewModel tabItem3 = new TabItem_ViewModel()
            {
                Header = "tabItem3",
                Content = "This is the content of third tabitem.",
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
