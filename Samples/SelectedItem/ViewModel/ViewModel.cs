using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace SelectedItem.ViewModel
{
    public class ViewModel : NotificationObject
    {
        private Brush tabItemSelectedForeground = Brushes.Red;
        private Brush tabItemSelectedBackground = Brushes.Green;
        private FontWeight selectedItemFontWeight = FontWeights.Bold;
        private bool isDisableUnloadTabItemExtContent;
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
        public Brush TabItemSelectedForeground
        {
            get { return tabItemSelectedForeground; }
            set
            {
                tabItemSelectedForeground = value;
                this.RaisePropertyChanged(nameof(TabItemSelectedForeground));
            }
        }
        public Brush TabItemSelectedBackground
        {
            get { return tabItemSelectedBackground; }
            set
            {
                tabItemSelectedBackground = value;
                this.RaisePropertyChanged(nameof(TabItemSelectedBackground));
            }
        }

        public FontWeight SelectedItemFontWeight
        {
            get { return selectedItemFontWeight; }
            set
            {
                selectedItemFontWeight = value;
                this.RaisePropertyChanged(nameof(SelectedItemFontWeight));
            }
        }

        public bool IsDisableUnloadTabItemExtContent
        {
            get { return isDisableUnloadTabItemExtContent; }
            set
            {
                isDisableUnloadTabItemExtContent = value;
                this.RaisePropertyChanged(nameof(IsDisableUnloadTabItemExtContent));
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
                Content = "This is the content of first tabitem."
            };
            TabItem_ViewModel tabItem2 = new TabItem_ViewModel()
            {
                Header = "tabItem2",
                Content = "This is the content of second tabitem."
            };
            TabItem_ViewModel tabItem3 = new TabItem_ViewModel()
            {
                Header = "tabItem3",
                Content = "This is the content of third tabitem."
            };

            //Adding tab item details to the collection
            tabItems.Add(tabItem1);
            tabItems.Add(tabItem2);
            tabItems.Add(tabItem3);
        }
    }
}